using System.Collections.ObjectModel;

namespace DZ12
{
    internal class Shop
    {
        public ObservableCollection<Item> Products = new ObservableCollection<Item>();

        public void Add(Item item)
        {
            Products.Add(item);
        }

        public void Remove(int id)
        {
            foreach (var product in Products)
            {
                if (product.Id == id)
                {
                    Products.Remove(product);
                    return;
                }
            }
            Console.WriteLine("Тавар c ID="+ id + " не найден");
        }
    }
}
