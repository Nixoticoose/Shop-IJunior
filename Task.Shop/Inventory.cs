using System.Reflection;

namespace Task.Shop
{
    internal class Inventory
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }

        public void ShowAllItems()
        {
            int numberItem = 0;

            foreach (Item item in _items)
            {
                ++numberItem;

                Write($"{numberItem}. ");
                item.ShowInfo();
                WriteLine();
            }

            WriteLine();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            if (TryGetItem(item) == true)
            {
                _items.Remove(item);
            }
        }

        public bool TryGetItemByIndex(int indexItem, out Item itemToGet)
        {
            int firstIndexElement = 0;

            itemToGet = null;

            if (indexItem >= firstIndexElement && indexItem < _items.Count)
            {
                if (_items.Contains(_items[indexItem]) == true)
                {
                    itemToGet = _items[indexItem];

                    return true;
                }
                else
                {
                    WriteLine("Такого предмета нет.");
                    return false;
                }
            }
            else
            {
                WriteLine("Вы ввели некорректное число.");
                return false;
            }
        }

        private bool TryGetItem(Item item)
        {
            bool isGet = false;

            if (_items.Contains(item) == true)
            {
                isGet = true;
            }

            return isGet;
        }
    }
}
