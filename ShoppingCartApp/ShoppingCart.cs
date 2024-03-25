namespace ShoppingCartApp
{
    public class ShoppingCart
    {
        private Product[] availableProducts; // Array to store available products
        private int AvailableProductCount = 0; // Counter for available products
        private Product[] products; // Array to store added products to cart
        private int itemCount = 0; // Counter for added products
        private double totalPrice = 0; // Total price of products in the cart

        // Property to access total price of products in the cart
        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        // Constructor to initialize shopping cart with given capacity
        public ShoppingCart(int capacity, int AvailableProductCapacity)
        {
            products = new Product[capacity]; // Initialize products array with given capacity
            availableProducts = new Product[AvailableProductCapacity]; // Initialize availableProducts array with given capacity
        }

        // Method to populate available products
        public void populateAvailableProducts(Product product)
        {
            if (AvailableProductCount < 10)
            {
                availableProducts[AvailableProductCount] = product;
                AvailableProductCount++;
            }
            else
            {
                Console.WriteLine("Unable to add more products!"); // Inform if available products capacity is reached
            }
        }

        // Method to handle user input for adding or removing products
        public void UserInput(int Choice, string desicion)
        {
            if (Choice > 0 && Choice < 11 && desicion == "true")
            {
                AddProduct(availableProducts[Choice - 1]); // Add selected product to cart
                Console.WriteLine("Product successfully added");
            }
            else if (Choice > 0 && Choice < 11 && desicion == "false")
            {
                RemoveProduct(availableProducts[Choice - 1]); // Remove selected product from cart
                Console.WriteLine("Product successfully deleted");
            }
            else
            {
                Console.WriteLine("You have entered an invalid value!"); // Inform if invalid choice is entered
            }

        }

        // Method to add product to the cart
        public void AddProduct(Product product)
        {
            if (itemCount < products.Length)
            {
                products[itemCount] = product;
                itemCount++;
                TotalPrice += product.Price;
            }
            else
            {
                Console.WriteLine("There is not enough space to hold more products."); // Inform if cart capacity is reached
            }
        }

        // Method to remove product from the cart
        public void RemoveProduct(Product product)
        {
            Product temp;
            int index = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == product)
                {
                    TotalPrice -= product.Price; // Decrease total price by price of removed product
                    products[i] = null;
                    for (int j = i + 1; j < products.Length - 1; j++)
                    {
                        temp = products[i];
                        products[i] = products[j];
                        products[j] = temp;
                    }
                }
                itemCount--; // Decrease itemCount after removing product
                return;
            }
        }

        // Method to display products in the cart
        public void DisplayProduct()
        {
            int count = 0;
            while (count < products.Length && products[count] != null)
            {
                Console.WriteLine("Product: " + (count + 1));
                products[count].GetInfo();
                Console.WriteLine();
                count++;
            }
        }
    }
}