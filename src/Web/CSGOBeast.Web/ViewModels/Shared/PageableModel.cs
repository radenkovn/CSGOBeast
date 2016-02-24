using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSGOBeast.Web.ViewModels.Shared
{
    public abstract class PageableModel
    {
        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }
    }
}