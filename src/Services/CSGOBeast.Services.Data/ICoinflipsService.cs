﻿namespace CSGOBeast.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CSGOBeast.Data.Models;

    public interface ICoinFlipsService
    {
        IQueryable<CoinFlip> GetCurrent();

        IQueryable<CoinFlip> CompleteCoinFlip(int id, string userId);
    }
}
