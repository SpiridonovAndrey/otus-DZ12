namespace DZ12
{
    internal class Program
    {
        static void Main()
        {
            Customer customer = new Customer();
            Shop shop = new Shop();
            shop.Products.CollectionChanged += customer.OnItemChanged;
            int Id = 0; int c = 0;

            while (true)
            {
                Console.WriteLine("Нажмите: 'А' для добавления товара, 'D' для удаления товара, 'P' для вывода всех товаров, 'Х' для выхода из программы");

                switch (Console.ReadLine())
                {
                    case "A":
                        Item newItem = new Item(Id, "Товар от " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        shop.Add(newItem);
                        Id++;
                        break;

                    case "D":
                        Console.WriteLine("Введите ID товара?");
                        c = 0;
                        while (c == 0)
                        {
                            var Parse = int.TryParse(Console.ReadLine(), out c) && c >= 0;
                            if (!Parse) Console.WriteLine("Введите число от '0'");
                        }
                        shop.Remove(c);
                        break;

                    case "P":
                        foreach (var product in shop.Products)
                            Console.WriteLine(product.Id + " " + product.Name + ", ");
                        break;

                    case "X":
                        System.Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Введите букву из предложенных");
                        break;
                }
            }
        }
    }
}