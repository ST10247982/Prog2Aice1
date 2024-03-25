

using System.Drawing;
using System.Runtime.CompilerServices;

namespace ShoppingCartApp
{
    public  class ElectronicProducts: Product
    {
        private readonly string brand;
        private readonly string model;

         public  ElectronicProducts(string name, double price, ProductCategory category,string brand, string model): base( name,  price, category)
        {
            this.brand = brand;
            this.model = model;  
        }
        public string Brand { 
            get { return brand; } 
            
        }
        public string Model
        {
            get { return model; }
          
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: R{Price}");
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Model: {model}");
        }
    }
}
