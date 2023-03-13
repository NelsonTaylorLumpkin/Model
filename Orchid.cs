namespace FlowerShop

{
    

 public class Orchid : IMothersDayFlower, IBirthdayFlower
    {
        public string Color { get; set; }
        public int PetalCount { get; set; }
        public string Species { get; set; }
        public double StemLength { get; set; }
        public bool Thorny { get; set; }

        public override string ToString()
        {
            return $"A haunted {Color} orchid with {PetalCount} petals and a dog-like yet human face begins growing out of the very top of your head.";
        }
    }
}