global using static System.Console;
global using static System.ConsoleKey;
global using Task.Shop.Products;
global using Task.Shop.Weapons;
global using Task.Shop.Pawns;

namespace Task.Shop
{
    internal class Menu
    {
        private const ConsoleKey CommandShowAllItemsToSell = D1;
        private const ConsoleKey CommandBuyItem = D2;
        private const ConsoleKey CommandShowPlayerInventory = D3;
        private const ConsoleKey CommandExit = Escape;

        static void Main(string[] args)
        {
            bool isGame = true;

            Login(out string playerName, out int playerMoney);

            Player player = new(playerName, playerMoney);
            Seller tradesman = new("Торговец всем, что под руку попало", 1653003030);

            DeliverItemsToSeller(tradesman);
            Clear();

            WriteLine($"Здравствуй, {player.Name}! Сейчас доступен только один продавец - {tradesman.Name}.");

            while (isGame)
            {
                WriteLine($"Денег в кармане: {player.Money}.");
                ChooseCommand(in player, in tradesman, ref isGame);
            }
        }

        private static void Login(out string playerName, out int playerMoney)
        {
            bool isLogin = false;

            playerName = "NoneName";
            playerMoney = 0;

            while (isLogin == false)
            {
                Write("Игрок, введи своё имя: ");
                playerName = ReadLine();

                Write("Сколько денег у твоего персонажа? ");
                string playerInputAmount = ReadLine();

                if (Int32.TryParse(playerInputAmount, out playerMoney) == true)
                {
                    isLogin = true;
                }
                else
                {
                    WriteLine("Введено неккоректное значение.");
                }
            }
        }

        private static void ChooseCommand(in Player player, in Seller tradesman, ref bool isGame)
        {
            DisplayCommand();
            Write("Что вы хотите сделать? ");

            ConsoleKeyInfo playerInput = ReadKey();

            Clear();

            switch (playerInput.Key)
            {
                case CommandShowAllItemsToSell:
                    tradesman.ItemsToSell.ShowAllItems();
                    break;

                case CommandBuyItem:
                    Deal deal = new(tradesman, player);
                    break;

                case CommandShowPlayerInventory:
                    player.Inventory.ShowAllItems();
                    break;

                case CommandExit:
                    isGame = false;
                    break;
            }
        }

        private static void DisplayCommand()
        {
            WriteLine($"Чтобы посмотреть список товаров торговца - нажми {CommandShowAllItemsToSell}.");
            WriteLine($"Чтобы купить какой-то товар - нажми {CommandBuyItem}.");
            WriteLine($"Чтобы посмотреть свой инвентарь - нажми {CommandShowPlayerInventory}.");
            WriteLine($"А если хочешь уйти - нажми {CommandExit}.");
        }

        private static void DeliverItemsToSeller(in Seller seller)
        {
            seller.ItemsToSell.AddItem(new Food("Горячее крылышко", 154, "Кусочек жаренного крылышка какого-то бедолажного птенца.", "Очень свежее."));
            seller.ItemsToSell.AddItem(new Food("Нежнятина", 1771, "Самый нежный стейк из кафельной говядины, это даже лучше, чем мраморная.", "Очень свежее."));
            seller.ItemsToSell.AddItem(new Drink("Холодная штучка", 45, "Напиток от известного производителя - Вкусно и запятая.", 0.5f));
            seller.ItemsToSell.AddItem(new Drink("Холодная штучка", 113, "Напиток от известного производителя - Вкусно и запятая.", 1f));
            seller.ItemsToSell.AddItem(new Food("Буханка в буханке", 17, "Обычная буханка в буханке, пресно, зато недорого.", "Свежее."));
            seller.ItemsToSell.AddItem(new Food("Буханка в буханке", 15, "Обычная буханка в буханке, пресно, зато недорого.", "Не очень свежее."));
            seller.ItemsToSell.AddItem(new Food("Пакет травы", 7, "Вкусная, полезная и дешёвая.", "Свежее."));
            seller.ItemsToSell.AddItem(new Food("Очень холодная зима", 77, "Мороженное, которое сделает ваш зимний денёк ещё приятнее.", "Свежее."));
            seller.ItemsToSell.AddItem(new Knife("Мини-катана", 1320, "Маленькая, но смертоносная.", 110.0f, 9.2f));
            seller.ItemsToSell.AddItem(new Knife("Нож-стрекоза", 700, "Лучше, чем нож-бабочка.", 25.0f, 10.1f));
            seller.ItemsToSell.AddItem(new Pistol("Осиный гнев", 2776, "Компактный травматический пистолет, стреляет маленькими пулями. Тот, в кого стреляют, будет недоволен.", 12.0f, 30));
            seller.ItemsToSell.AddItem(new Pistol("Лапа слона", 15087, "Очень мощный пистолет-дробовик, после выстрела откидывает и стреляющего, и того, в кого стреляют.", 100.0f, 8));
            seller.ItemsToSell.AddItem(new Pistol("Ядерное лето", 52393, "Что тут говорить, гранатомёт он и в Мабритании гранотомёт. Только это пистолет-гранатомёт.", 1400.0f, 5));
        }
    }
}