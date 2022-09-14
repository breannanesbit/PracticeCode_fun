using System.IO;
namespace Fun_PracticeCode_Fall22
{
    public class Class1
    {
        public void Unscramble()
        {
            var scrambled = Console.ReadLine();
            var emptyString1 = "";
            var emptyString2 = "";
            var scrambledCharArray = scrambled.ToCharArray();

            for(int i = 0; i<scrambled.Length-1; i = i+2)
            {
                emptyString1 = emptyString1 + scrambledCharArray[i];
            }
            for(int i = scrambled.Length; i>0; i = i-2)
            {
                emptyString2 = emptyString2 + scrambledCharArray[i];
            }
        }

        Console.WriteLine(emptyString1 + emptyString2);
    }

}
