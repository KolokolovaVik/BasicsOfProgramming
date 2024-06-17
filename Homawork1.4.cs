using System;

namespace ConsoleApp2
{
    internal class Homawork1
    {
        static void Main(string[] args)
        {
            int filledRows;
            int additionalImages;

            int image = 52;
            int inRowOfPictures = 3;

            filledRows = image / inRowOfPictures;
            additionalImages = image % inRowOfPictures;

            Console.WriteLine($"Количество заполненных рядов картинками: {filledRows}, осталось картинок: {additionalImages}");
        }  
    }
}
