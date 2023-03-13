using System.Collections.Generic;
namespace FlowerShop
{


    public class FlowerShopModel
    {
        public List<Rose> Roses { get; set; } = new List<Rose>();
        public List<Orchid> Orchids { get; set; } = new List<Orchid>();
        public List<Cactus> Cactuses { get; set; } = new List<Cactus>();

        public List<IMothersDayFlower> MakeMothersDayFlower()
        {
            List<IMothersDayFlower> arrangement = new List<IMothersDayFlower>()
        {
            new Rose() { StemLength = 12.5 },
            new Orchid() { StemLength = 8.5 },
            new Cactus() { StemLength = 6.5 }

        };
            return arrangement;

        }
        public List<IBirthdayFlower> MakeBirthdayFlower()
        {
            List<IBirthdayFlower> color = new List<IBirthdayFlower>()
        {
            new Rose() { Color = "Black" },
            new Orchid() { Color = "Blue" },
            new Cactus() { Color = "Green" }

        };
            return color;

        }
    }
}