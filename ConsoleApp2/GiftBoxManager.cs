using System.Diagnostics;
using static ConsoleApp2.Program;

namespace ConsoleApp2
{
    class GiftBoxManager
    {
        public void SetInput()
        {
            GiftBox addressA = GiftBoxMaker("A친구야 잘 지내지?", 110000, ITEM_GRADE.NOMAL);
            GiftBox addressB = GiftBoxMaker("B친구야 잘 지내지?", 120000, ITEM_GRADE.RARE);
            GiftBox addressC = GiftBoxMaker("C친구야 잘 지내지?", 130000, ITEM_GRADE.UNICLE);

            Console.WriteLine($"addressC: Letter = {addressC.Letter} item: {addressC.Grade}");
        }

        private static GiftBox GiftBoxMaker(string letter, int money, ITEM_GRADE ItemGrade)
        {
            GiftBox addressA = new GiftBox()
            {
                Letter = letter,
                Money = money,
                Grade = ItemGrade
            };
            return addressA;
        }
    }
}
