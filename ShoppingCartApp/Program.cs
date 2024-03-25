using ShoppingCartApp;

public class Program
{
    private static void Main(string[] args)
    {
        // Creating product objects
        Product shirt = new ClothingProduct("Supreme", 179.99, ProductCategory.Clothing, "Medium", "Red");
        Product pants = new ClothingProduct("Pants", 149.99, ProductCategory.Clothing, "Medium", "Black");

        Product phone = new ElectronicProducts("Phone", 20_000.00, ProductCategory.Electronics, "Samsung", "S24");
        Product toaster = new ElectronicProducts("Toaster", 1_500.00, ProductCategory.Electronics, "Smeg", "Ultra deluxe");

        Product lipstick = new Product("Lipstick", 70, ProductCategory.Beauty);
        Product facewash = new Product("Mens Face Wash", 6_000, ProductCategory.Beauty);

        Product couch = new Product("Couch", 8_000, ProductCategory.Home);
        Product chair = new Product("Chair", 2_000, ProductCategory.Home);

        Product food = new Product("Chicken", 8_000, ProductCategory.Groceries);
        Product dessert = new Product("Ice Cream", 100, ProductCategory.Groceries);

        // Array of available products
        Product[] availableProducts = { shirt, pants, phone, toaster, facewash, lipstick, couch, chair, food, dessert };
        int AvailableProductCapacity = availableProducts.Length;

        // Creating a shopping cart
        ShoppingCart cart = new ShoppingCart(10, AvailableProductCapacity);

        // Populating available products into the shopping cart
        for (int i = 0; i < availableProducts.Length; i++)
        {
            cart.populateAvailableProducts(availableProducts[i]);
        }

        // Displaying available products
        for (int i = 0; i < availableProducts.Length; i++)
        {
            int productNum = i + 1;
            Console.WriteLine("Product: " + productNum);
            availableProducts[i].GetInfo();
            Console.WriteLine();
        }

        string decision = "true";
        Console.WriteLine("Do you want to add a product? (1) for yes,(0) for no.");
        int UserInput = Convert.ToInt32(Console.ReadLine());

        // Asking user for input to add or delete products
        while (UserInput != 0)
        {
            Console.WriteLine("Enter from the list of products you want to add: ");
            UserInput = Convert.ToInt32(Console.ReadLine());
            cart.UserInput(UserInput, decision);
            Console.WriteLine("Do you want to delete a product? (1) for yes,(0) for no");
            UserInput = Convert.ToInt32(Console.ReadLine());
            if (UserInput == 1)
            {
                decision = "false";
                Console.WriteLine("Enter from the list of products you want to delete: ");
                cart.DisplayProduct();
                UserInput = Convert.ToInt32(Console.ReadLine());
                cart.UserInput(UserInput, decision);
            }

            Console.WriteLine("Do you want to add a product? (1) for yes, (0) for no");
            UserInput = Convert.ToInt32(Console.ReadLine());
            if (UserInput == 1)
            {
                decision = "true";
            }
        }

        // Displaying products in the cart
        cart.DisplayProduct();

        // Displaying total amount due
        Console.WriteLine("Total amount due: " + cart.TotalPrice);
    }
}