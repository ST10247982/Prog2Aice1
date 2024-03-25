namespace ShoppingCartApp
{
    // Base class for products in the shopping cart
    public class Product
    {
        private string name; // Name of the product
        private double price; // Price of the product
        private ProductCategory category; // Category of the product

        // Constructor to initialize product properties
        public Product(string name, double price, ProductCategory category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        // Property to get or set the name of the product
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Property to get or set the price of the product
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        // Property to get or set the category of the product
        public ProductCategory Category
        {
            get { return category; }
            set { category = value; }
        }

        // Method to get information about the product
        public virtual void GetInfo()
        {
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: R{Price}");
        }
    }
}