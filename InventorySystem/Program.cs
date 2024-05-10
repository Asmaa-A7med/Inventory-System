namespace InventorySystem
{
    internal class Program
    {
        // methode for Add Product 
        private static void AddProduct()
        {
            Console.WriteLine("Enter product name");
            string name= Console.ReadLine();

            Console.WriteLine("Enter product quantity");
            string quantity= Console.ReadLine();

            Console.WriteLine("Enter product price");
            string price =Console.ReadLine();

            inventory[productCount, 0] = name;
            inventory[productCount, 1] = quantity;
            inventory[productCount, 2] = price;

            productCount++;
            Console.WriteLine("product Added successfully");
        }

        // methode for view products
        private static void ViewProduct()
        {
            if (productCount > 0)
            {
                Console.WriteLine("product list ");
                for(int i=0; i<productCount;i++)
                {
                    Console.WriteLine($"product id :{i} product name : {inventory[i, 0]} product quantity : {inventory[i, 1]} product price : {inventory[i, 2]}");
                }
            }
        }

        // methode for update product
        private static void UpdateProduct()
        {
            int productId=-1;
            Console.WriteLine("Ener product name to update ");
            string SearchProduct=Console.ReadLine();

            if (productCount > 0)
            {
                for(int i=0; i<productCount; i++)
                {
                    if (inventory[i, 0] == SearchProduct)
                    {
                        productId = i; 
                        
                        break;
                    }
                }
                if (productId != -1)
                {
                    Console.WriteLine("Enter the new quntity ");
                    string newQuantity=Console.ReadLine();

                    inventory[productId, 1] = newQuantity;
                    Console.WriteLine("quantity updated successfully ");
                }
            }

            else
            {
                Console.WriteLine("product not found");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Welcome to inventory sustem, Enter yourchoice number ");
                Console.WriteLine("1 :Add Product \n2: Update Product \n3: View Product \n4: Exit ");
                string UserInput = Console.ReadLine();
                int choice = Convert.ToInt32(UserInput);

                switch (choice)
                {
                    case 1:
                        //Add product
                        AddProduct();
                        break;
                    case 2:
                        //update product
                        UpdateProduct();
                        break;
                    case 3:
                        //view product
                        ViewProduct();
                        break;
                    case 4:
                        //Exit
                        Environment.Exit(0);
                        break;
                }

            }
        }
        // 50 for raws(values) , 3 for coulmns(name, price , quantity)

      static String[,] inventory = new string[50, 3];

       static int productCount = 0;
    }
}

