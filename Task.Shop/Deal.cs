namespace Task.Shop
{
    internal class Deal
    {
        public Deal(in Seller tradesman, in Player player)
        {
            SellItem(tradesman, player);
        }

        private void SellItem(in Seller trader, in Player player)
        {
            trader.ItemsToSell.ShowAllItems();
            Write("Введите номер предмета, который хотите купить: ");
            string input = ReadLine();

            if (Int32.TryParse(input, out int numberItem) == true)
            {
                int indexItem = numberItem - 1;

                if (trader.ItemsToSell.TryGetItemByIndex(indexItem, out Item itemToSell) == true)
                {
                    if (CheckForMoneyPlayer(itemToSell.Price, player.Money) == true)
                    {
                        player.WithdrawMoney(itemToSell);
                        trader.AddMoney(itemToSell);

                        player.Inventory.AddItem(itemToSell);
                        trader.ItemsToSell.RemoveItem(itemToSell);
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
            if (money >= price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
