using System.Collections.Specialized;

namespace DZ12
{
    internal class Customer
    {
        public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Был добавлен товар: ID=" + ((Item)e.NewItems[0])?.Id + ", Название " + ((Item)e.NewItems[0])?.Name);
                    break;

                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Был удалён товар:" + ((Item)e.OldItems[0])?.Name);
                    break;
            }
        }
    }
}
