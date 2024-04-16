namespace ConsoleApp2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("시작 부분");

            int aMoney = 10000;
            int bMoney = aMoney;
            aMoney = 20000;
            Console.WriteLine("aMoney: " + aMoney);
            Console.WriteLine("bMoney: " + bMoney);

            GiftBox giftBoxA = new GiftBox()
            {
                Letter = "안녕",
                Money = 10000
            };

            GiftBox giftboxB = giftBoxA;
            giftBoxA.Money = 20000;
            Console.WriteLine("giftBoxA: " + giftBoxA.Money);
            Console.WriteLine("giftBoxB: " + giftboxB.Money);
        }
    }
}
