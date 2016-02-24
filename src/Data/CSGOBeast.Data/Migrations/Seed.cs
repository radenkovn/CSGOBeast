namespace CSGOBeast.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CSGOBeast.Data.Models;

    public class Seed
    {
        private static Random rand = new Random();

        public Seed(User author)
        {
            this.Author = author;

            this.Items = new List<Item>();
            this.Items.Add(new Item
            {
                Name = "AK-47 | Fuel Injector",
                ImageLink = "https://csgostash.com/img/skins/s720fn.png",
                GroupType = GroupType.Rifle,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.Covert,
                Price = 124.5m,
                WeaponType = WeaponType.AK47
            });
            this.Items.Add(new Item
            {
                Name = "AK-47 | Fuel Injector",
                ImageLink = "https://csgostash.com/img/skins/s720fn.png",
                GroupType = GroupType.Rifle,
                Quality = ItemQuality.MinimalWear,
                Classification = ItemClassification.Covert,
                Price = 74.25m,
                WeaponType = WeaponType.AK47
            });
            this.Items.Add(new Item
            {
                Name = "AK-47 | Fuel Injector",
                ImageLink = "https://csgostash.com/img/skins/s720fn.png",
                GroupType = GroupType.Rifle,
                Quality = ItemQuality.WellWorn,
                Classification = ItemClassification.Covert,
                Price = 45.2m,
                WeaponType = WeaponType.AK47
            });
            this.Items.Add(new Item
            {
                Name = "M4A4 | The Battlestar",
                ImageLink = "https://csgostash.com/img/skins/s720fn.png",
                GroupType = GroupType.Rifle,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.Covert,
                Price = 115.2m,
                WeaponType = WeaponType.M4A4
            });
            this.Items.Add(new Item
            {
                Name = "M4A4 | The Battlestar",
                ImageLink = "https://csgostash.com/img/skins/s721fn.png",
                GroupType = GroupType.Rifle,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.Covert,
                Price = 115.2m,
                WeaponType = WeaponType.M4A4
            });

            this.Items.Add(new Item
            {
                Name = "M4A4 | The Battlestar",
                ImageLink = "https://csgostash.com/img/skins/s721fn.png",
                GroupType = GroupType.Rifle,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.Covert,
                Price = 115.2m,
                WeaponType = WeaponType.M4A4
            });
            this.Items.Add(new Item
            {
                Name = "AWP | Elite Build",
                ImageLink = "https://csgostash.com/img/skins/s717fn.png",
                GroupType = GroupType.Rifle,
                Quality = ItemQuality.FieldTested,
                Classification = ItemClassification.Classified,
                Price = 84.95m,
                WeaponType = WeaponType.AWP
            });
            this.Items.Add(new Item
            {
                Name = "AWP | Elite Build",
                ImageLink = "https://csgostash.com/img/skins/s717fn.png",
                GroupType = GroupType.Rifle,
                Quality = ItemQuality.MinimalWear,
                Classification = ItemClassification.Classified,
                Price = 65.48m,
                WeaponType = WeaponType.AWP
            });
            this.Items.Add(new Item
            {
                Name = "Desert Eagle | Kumicho Dragon",
                ImageLink = "https://csgostash.com/img/skins/s718fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.Classified,
                Price = 25.84m,
                WeaponType = WeaponType.DesertEagle
            });
            this.Items.Add(new Item
            {
                Name = "Nova | Hyper Beast",
                ImageLink = "https://csgostash.com/img/skins/s719fn.png",
                GroupType = GroupType.Heavy,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.Classified,
                Price = 12.8m,
                WeaponType = WeaponType.Nova
            });
            this.Items.Add(new Item
            {
                Name = "Nova | Hyper Beast",
                ImageLink = "https://csgostash.com/img/skins/s719fn.png",
                GroupType = GroupType.Heavy,
                Quality = ItemQuality.MinimalWear,
                Classification = ItemClassification.Classified,
                Price = 8.49m,
                WeaponType = WeaponType.Nova
            });
            this.Items.Add(new Item
            {
                Name = "FAMAS | Valence",
                ImageLink = "https://csgostash.com/img/skins/s712fn.png",
                GroupType = GroupType.Rifle,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.Restricted,
                Price = 8.34m,
                WeaponType = WeaponType.FAMAS
            });
            this.Items.Add(new Item
            {
                Name = "FAMAS | Valence",
                ImageLink = "https://csgostash.com/img/skins/s712fn.png",
                GroupType = GroupType.Rifle,
                Quality = ItemQuality.MinimalWear,
                Classification = ItemClassification.Restricted,
                Price = 6.95m,
                WeaponType = WeaponType.FAMAS
            });
            this.Items.Add(new Item
            {
                Name = "FAMAS | Valence",
                ImageLink = "https://csgostash.com/img/skins/s712fn.png",
                GroupType = GroupType.Rifle,
                Quality = ItemQuality.WellWorn,
                Classification = ItemClassification.Restricted,
                Price = 4.95m,
                WeaponType = WeaponType.FAMAS
            });
            this.Items.Add(new Item
            {
                Name = "FAMAS | Valence",
                ImageLink = "https://csgostash.com/img/skins/s712fn.png",
                GroupType = GroupType.Rifle,
                Quality = ItemQuality.BattleScarred,
                Classification = ItemClassification.Restricted,
                Price = 3.85m,
                WeaponType = WeaponType.FAMAS
            });
            this.Items.Add(new Item
            {
                Name = "Five-SeveN | Triumvirate",
                ImageLink = "https://csgostash.com/img/skins/s713fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.Restricted,
                Price = 2.4m,
                WeaponType = WeaponType.FiveSeven
            });
            this.Items.Add(new Item
            {
                Name = "Five-SeveN | Triumvirate",
                ImageLink = "https://csgostash.com/img/skins/s713fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.FieldTested,
                Classification = ItemClassification.Restricted,
                Price = 1.8m,
                WeaponType = WeaponType.FiveSeven
            });
            this.Items.Add(new Item
            {
                Name = "Five-SeveN | Triumvirate",
                ImageLink = "https://csgostash.com/img/skins/s713fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.BattleScarred,
                Classification = ItemClassification.Restricted,
                Price = 1.04m,
                WeaponType = WeaponType.FiveSeven
            });
            this.Items.Add(new Item
            {
                Name = "Glock-18 | Royal Legion",
                ImageLink = "https://csgostash.com/img/skins/s714fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.Restricted,
                Price = 6.06m,
                WeaponType = WeaponType.Glock18m
            });
            this.Items.Add(new Item
            {
                Name = "Glock-18 | Royal Legion",
                ImageLink = "https://csgostash.com/img/skins/s714fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.Restricted,
                Price = 6.06m,
                WeaponType = WeaponType.Glock18m
            });
            this.Items.Add(new Item
            {
                Name = "Glock-18 | Royal Legion",
                ImageLink = "https://csgostash.com/img/skins/s714fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.MinimalWear,
                Classification = ItemClassification.Restricted,
                Price = 5.34m,
                WeaponType = WeaponType.Glock18m
            });
            this.Items.Add(new Item
            {
                Name = "Glock-18 | Royal Legion",
                ImageLink = "https://csgostash.com/img/skins/s714fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.WellWorn,
                Classification = ItemClassification.Restricted,
                Price = 4.86m,
                WeaponType = WeaponType.Glock18m
            });
            this.Items.Add(new Item
            {
                Name = "Glock-18 | Royal Legion",
                ImageLink = "https://csgostash.com/img/skins/s714fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.BattleScarred,
                Classification = ItemClassification.Restricted,
                Price = 2.84m,
                WeaponType = WeaponType.Glock18m
            });

            this.Items.Add(new Item
            {
                Name = "MAG-7 | Praetorian",
                ImageLink = "https://csgostash.com/img/skins/s715fn.png",
                GroupType = GroupType.Heavy,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.Restricted,
                Price = 2.20m,
                WeaponType = WeaponType.MAG7
            });
            this.Items.Add(new Item
            {
                Name = "MAG-7 | Praetorian",
                ImageLink = "https://csgostash.com/img/skins/s715fn.png",
                GroupType = GroupType.Heavy,
                Quality = ItemQuality.MinimalWear,
                Classification = ItemClassification.Restricted,
                Price = 1.87m,
                WeaponType = WeaponType.MAG7
            });
            this.Items.Add(new Item
            {
                Name = "MAG-7 | Praetorian",
                ImageLink = "https://csgostash.com/img/skins/s715fn.png",
                GroupType = GroupType.Heavy,
                Quality = ItemQuality.WellWorn,
                Classification = ItemClassification.Restricted,
                Price = 1.30m,
                WeaponType = WeaponType.MAG7
            });

            this.Items.Add(new Item
            {
                Name = "MAG-7 | Praetorian",
                ImageLink = "https://csgostash.com/img/skins/s715fn.png",
                GroupType = GroupType.Heavy,
                Quality = ItemQuality.FieldTested,
                Classification = ItemClassification.Restricted,
                Price = 1.53m,
                WeaponType = WeaponType.MAG7
            });
            this.Items.Add(new Item
            {
                Name = "MAG-7 | Praetorian",
                ImageLink = "https://csgostash.com/img/skins/s715fn.png",
                GroupType = GroupType.Heavy,
                Quality = ItemQuality.BattleScarred,
                Classification = ItemClassification.Restricted,
                Price = 0.95m,
                WeaponType = WeaponType.MAG7
            });
            this.Items.Add(new Item
            {
                Name = "MP7 | Impire",
                ImageLink = "https://csgostash.com/img/skins/s716fn.png",
                GroupType = GroupType.SMG,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.Restricted,
                Price = 2.36m,
                WeaponType = WeaponType.MP7
            });
            this.Items.Add(new Item
            {
                Name = "MP7 | Impire",
                ImageLink = "https://csgostash.com/img/skins/s716fn.png",
                GroupType = GroupType.SMG,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.Restricted,
                Price = 2.36m,
                WeaponType = WeaponType.MP7
            });
            this.Items.Add(new Item
            {
                Name = "MP7 | Impire",
                ImageLink = "https://csgostash.com/img/skins/s716fn.png",
                GroupType = GroupType.SMG,
                Quality = ItemQuality.FieldTested,
                Classification = ItemClassification.Restricted,
                Price = 1.38m,
                WeaponType = WeaponType.MP7
            });
            this.Items.Add(new Item
            {
                Name = "MP7 | Impire",
                ImageLink = "https://csgostash.com/img/skins/s716fn.png",
                GroupType = GroupType.SMG,
                Quality = ItemQuality.BattleScarred,
                Classification = ItemClassification.Restricted,
                Price = 1.12m,
                WeaponType = WeaponType.MP7
            });
            this.Items.Add(new Item
            {
                Name = "PP-Bizon | Photic Zone",
                ImageLink = "https://csgostash.com/img/skins/s706fn.png",
                GroupType = GroupType.SMG,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.MilSpec,
                Price = 1.27m,
                WeaponType = WeaponType.PPBizon
            });
            this.Items.Add(new Item
            {
                Name = "PP-Bizon | Photic Zone",
                ImageLink = "https://csgostash.com/img/skins/s706fn.png",
                GroupType = GroupType.SMG,
                Quality = ItemQuality.MinimalWear,
                Classification = ItemClassification.MilSpec,
                Price = 0.85m,
                WeaponType = WeaponType.PPBizon
            });
            this.Items.Add(new Item
            {
                Name = "PP-Bizon | Photic Zone",
                ImageLink = "https://csgostash.com/img/skins/s706fn.png",
                GroupType = GroupType.SMG,
                Quality = ItemQuality.FieldTested,
                Classification = ItemClassification.MilSpec,
                Price = 0.74m,
                WeaponType = WeaponType.PPBizon
            });
            this.Items.Add(new Item
            {
                Name = "PP-Bizon | Photic Zone",
                ImageLink = "https://csgostash.com/img/skins/s706fn.png",
                GroupType = GroupType.SMG,
                Quality = ItemQuality.BattleScarred,
                Classification = ItemClassification.MilSpec,
                Price = 0.18m,
                WeaponType = WeaponType.PPBizon
            });
            this.Items.Add(new Item
            {
                Name = "Dual Berettas | Cartel",
                ImageLink = "https://csgostash.com/img/skins/s707fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.MilSpec,
                Price = 1.05m,
                WeaponType = WeaponType.DualBerettas
            });
            this.Items.Add(new Item
            {
                Name = "Dual Berettas | Cartel",
                ImageLink = "https://csgostash.com/img/skins/s707fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.FieldTested,
                Classification = ItemClassification.MilSpec,
                Price = 0.18m,
                WeaponType = WeaponType.DualBerettas
            });
            this.Items.Add(new Item
            {
                Name = "Dual Berettas | Cartel",
                ImageLink = "https://csgostash.com/img/skins/s707fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.WellWorn,
                Classification = ItemClassification.MilSpec,
                Price = 0.54m,
                WeaponType = WeaponType.DualBerettas
            });
            this.Items.Add(new Item
            {
                Name = "MAC-10 | Lapis Gator",
                ImageLink = "https://csgostash.com/img/skins/s708fn.png",
                GroupType = GroupType.SMG,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.MilSpec,
                Price = 0.49m,
                WeaponType = WeaponType.MAC10
            });
            this.Items.Add(new Item
            {
                Name = "MAC-10 | Lapis Gator",
                ImageLink = "https://csgostash.com/img/skins/s708fn.png",
                GroupType = GroupType.SMG,
                Quality = ItemQuality.WellWorn,
                Classification = ItemClassification.MilSpec,
                Price = 0.38m,
                WeaponType = WeaponType.MAC10
            });
            this.Items.Add(new Item
            {
                Name = "MAC-10 | Lapis Gator",
                ImageLink = "https://csgostash.com/img/skins/s708fn.png",
                GroupType = GroupType.SMG,
                Quality = ItemQuality.FieldTested,
                Classification = ItemClassification.MilSpec,
                Price = 0.29m,
                WeaponType = WeaponType.MAC10
            });
            this.Items.Add(new Item
            {
                Name = "SSG 08 | Necropos",
                ImageLink = "https://csgostash.com/img/skins/s709fn.png",
                GroupType = GroupType.Rifle,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.MilSpec,
                Price = 2.44m,
                WeaponType = WeaponType.SSG08
            });
            this.Items.Add(new Item
            {
                Name = "SSG 08 | Necropos",
                ImageLink = "https://csgostash.com/img/skins/s709fn.png",
                GroupType = GroupType.Rifle,
                Quality = ItemQuality.MinimalWear,
                Classification = ItemClassification.MilSpec,
                Price = 2.18m,
                WeaponType = WeaponType.SSG08
            });
            this.Items.Add(new Item
            {
                Name = "SSG 08 | Necropos",
                ImageLink = "https://csgostash.com/img/skins/s709fn.png",
                GroupType = GroupType.Rifle,
                Quality = ItemQuality.WellWorn,
                Classification = ItemClassification.MilSpec,
                Price = 1.68m,
                WeaponType = WeaponType.SSG08
            });
            this.Items.Add(new Item
            {
                Name = "Tec-9 | Jambiya",
                ImageLink = "https://csgostash.com/img/skins/s710fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.MilSpec,
                Price = 1.17m,
                WeaponType = WeaponType.Tec9
            });
            this.Items.Add(new Item
            {
                Name = "Tec-9 | Jambiya",
                ImageLink = "https://csgostash.com/img/skins/s710fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.MinimalWear,
                Classification = ItemClassification.MilSpec,
                Price = 0.83m,
                WeaponType = WeaponType.Tec9
            });
            this.Items.Add(new Item
            {
                Name = "Tec-9 | Jambiya",
                ImageLink = "https://csgostash.com/img/skins/s710fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.WellWorn,
                Classification = ItemClassification.MilSpec,
                Price = 0.37m,
                WeaponType = WeaponType.Tec9
            });
            this.Items.Add(new Item
            {
                Name = "USP-S | Lead Conduit",
                ImageLink = "https://csgostash.com/img/skins/s711fn.png",
                GroupType = GroupType.Pistol,
                Quality = ItemQuality.FactoryNew,
                Classification = ItemClassification.MilSpec,
                Price = 2.08m,
                WeaponType = WeaponType.USP
            });

            this.Tickets = new List<Ticket>();
            this.Tickets.Add(new Ticket
            {
                AuthorName = "George Bush",
                EmailAddress = "george@whitehouse.com",
                Message = "I recently lost all my money. Is there a way for me to retrieve it?",
                Subject = "My website money",
                Answered = false,
                UserId = this.Author.Id
            });
            this.Tickets.Add(new Ticket
            {
                AuthorName = "Michael Jordan",
                EmailAddress = "michael@nba.com",
                Message = "How long does it take for me to withdraw an item from your store?",
                Subject = "Item withdrawal",
                Answer = "Withdrawal from this website is instan!",
                Answered = true,
                UserId = this.Author.Id
            });

            this.Coinflips = new List<CoinFlip>();

            this.Coinflips.Add(new CoinFlip
            {
                CreatorId = this.Author.Id,
                CreatorSum = 48.59m
            });
            this.Coinflips.Add(new CoinFlip
            {
                CreatorId = this.Author.Id,
                CreatorSum = 53.2m
            });
            this.Coinflips.Add(new CoinFlip
            {
                CreatorId = this.Author.Id,
                CreatorSum = 28.3m
            });
            this.Coinflips.Add(new CoinFlip
            {
                CreatorId = this.Author.Id,
                CreatorSum = 12.38m
            });

        }

        public List<CoinFlip> Coinflips { get; set; }

        public List<Ticket> Tickets { get; set; }

        public List<Item> Items { get; set; }

        public User Author { get; set; }
    }
}
