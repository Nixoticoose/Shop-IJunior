namespace Task.Shop
{
    internal class Shop
    {
        public void SellItem(in Seller trader, in Player player)
        {
            trader.ShowItemsInventory();
            Write("Введите номер предмета, который хотите купить: ");
            string input = ReadLine();

            if (Int32.TryParse(input, out int numberItem) == true)
            {
                int indexItem = numberItem - 1;

                if (trader.TryGetItemByIndex(indexItem, out Item itemToSell))
                {
                    if (CheckForMoneyPlayer(itemToSell.Price, player.Money) == true)
                    {
                        player.BuyItem(itemToSell);
                        trader.SellItem(itemToSell);
                    }
                    else
                    {
                        WriteLine("Недостаточно денег для покупки.");
                    }
                }
            }
            else
            {
                WriteLine("Вы ввели не число.");
            }
        }

        private bool CheckForMoneyPlayer(int price, int money)
        {
            return money >= price;
        }
    }
}
