using System;
namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Cactus c = new Cactus()
            {
                StemLength = 6.5,
                Color = "Green"
            };
            Orchid o = new Orchid()
            {
                Color = "Blue",
                PetalCount = 9
            };
            Rose r = new Rose()
            {
                Color = "Black",
                PetalCount = 22
            };
            List<IMothersDayFlower> MDFlowers = new List<IMothersDayFlower>()
            {
                c
            };
            List<IBirthdayFlower>BDFlowers = new List<IBirthdayFlower>()
            {
                o, r
            };
            foreach (IMothersDayFlower md in MDFlowers)

            {
            Console.WriteLine(md);    
            }
            foreach (IBirthdayFlower bd in BDFlowers)

            {
            Console.WriteLine(bd);    
            }

            // Console.WriteLine ($"It's a beautiful flower");
        }
    }
}
