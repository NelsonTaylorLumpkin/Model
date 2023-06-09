 namespace FlowerShop

 {
    
 
 public class Cactus : IMothersDayFlower, IBirthdayFlower
    {
        public string Color { get; set; }
        public int PetalCount { get; set; }
        public string Species { get; set; }
        public double StemLength { get; set; }
        public bool Thorny { get; set; }

        public override string ToString()
        {
            return $"A grumpy {Color} cactus with {PetalCount} petals is showing out and being loud!";
        }
    }
 }