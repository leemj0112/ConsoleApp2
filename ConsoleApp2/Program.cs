namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("시작 부분");

            //call by value (value type), call by reperence (reperence type)
            int money = 10000;
            Console.WriteLine(money);
            SetMoney(money);
            Console.WriteLine(money);

            GiftBox giftBox = new GiftBox()
            {
                Money = 10000,
            };
            Console.WriteLine(giftBox.Money);
            SetGiftBox(giftBox);
            Console.WriteLine(giftBox.Money);
        }

        static void SetMoney(int needmoney)
        {
            needmoney = 30000;
        }

        //call by reference

        static void SetGiftBox(GiftBox info)
        {
            info.Money = 50000;
        }
    }
}
