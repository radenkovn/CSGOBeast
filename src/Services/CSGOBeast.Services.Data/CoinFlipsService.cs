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

        public CoinFlipsService(IDbRepository<CoinFlip> coinflips)
        {
            this.coinflips = coinflips;
        }

        public IQueryable<CoinFlip> GetCurrent()
        {
            return this.coinflips.All().Where(x => x.Win == CoinFlipWin.Pending);
        }
    }
}
