

using System.Drawing;

namespace ShoppingCartApp
{
    public class ClothingProduct : Product
    {
        private readonly string size;
        private readonly string colour;

        public string Size
        {
            get { return size; }
        }
        public string Colour
        {
            get => colour;

        }
        public ClothingProduct(string name, double price, ProductCategory category, string size, string colour) : base(name, price, category)
        {


            this.size = size;
            this.colour = colour;
        }


        public override void GetInfo()
        {
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: R{Price}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Colour: {Colour}");
        }
    }
    
}
