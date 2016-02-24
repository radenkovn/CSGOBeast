namespace CSGOBeast.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CSGOBeast.Data.Common;
    using CSGOBeast.Data.Models;

    public class CoinFlipsService : ICoinFlipsService
    {
        private IDbRepository<CoinFlip> coinflips;
        private IUsersRepository<User> users;

        public CoinFlipsService(IDbRepository<CoinFlip> coinflips, IUsersRepository<User> users)
        {
            this.coinflips = coinflips;
            this.users = users;
        }

        public IQueryable<CoinFlip> GetCurrent()
        {
            return this.coinflips.All().Where(x => x.Win == CoinFlipWin.Pending);
        }

        public IQueryable<CoinFlip> CompleteCoinFlip(int coinflipId, string userId)
        {
            var currentUser = this.users.GetById(userId);
            var rand = new Random();
            var winner = rand.Next(1, 3);
            if (currentUser != null)
            {
                var coinFlipToChange = this.coinflips.GetById(coinflipId);
                if (coinFlipToChange != null)
                {
                    if (coinFlipToChange.CreatorSum > currentUser.Balance)
                    {
                        return this.GetCurrent();
                    }

                    coinFlipToChange.PlayerId = userId;
                    this.coinflips.Save();
                    if (winner == 1)
                    {
                        coinFlipToChange.Win = CoinFlipWin.Creator;
                        coinFlipToChange.Creator.Balance += coinFlipToChange.CreatorSum;
                        currentUser.Balance -= coinFlipToChange.CreatorSum;
                    }

                    if (winner == 2)
                    {
                        coinFlipToChange.Win = CoinFlipWin.Player;
                        coinFlipToChange.Creator.Balance -= coinFlipToChange.CreatorSum;
                        currentUser.Balance += coinFlipToChange.CreatorSum;
                    }

                    this.coinflips.Save();
                    this.users.SaveChanges();
                }
            }

            return this.GetCurrent();
        }
    }
}
