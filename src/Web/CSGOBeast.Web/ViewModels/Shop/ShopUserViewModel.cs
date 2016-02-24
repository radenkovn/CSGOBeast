namespace CSGOBeast.Web.ViewModels.Shop
{
    using Data.Models;
    using Infrastructure.Mapping;

    public class ShopUserViewModel : IMapFrom<User>
    {
        public decimal Balance { get; set; }
    }
}
