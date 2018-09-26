using System;

namespace _04._Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int date = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double photoSizeInBytes = double.Parse(Console.ReadLine());
            int photoWidth = int.Parse(Console.ReadLine());
            int photoHeight = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {date:d2}/{month:d2}/{year} {hours:d2}:{minutes:d2}");
            
            if(photoSizeInBytes < 1000)
            {
                Console.WriteLine($"Size: {photoSizeInBytes}B");
            }
            else if(photoSizeInBytes >= 1000 && photoSizeInBytes < 1000000)
            {
                double sizeToKB = photoSizeInBytes / 1000;
                Console.WriteLine($"Size: {sizeToKB}KB");
            }
            else
            {
                double sizeToMB = (photoSizeInBytes / 100000) / 10;
                Console.WriteLine($"Size: {sizeToMB}MB");
            }

            
            if(photoWidth > photoHeight)
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (landscape)");
            }
            else if(photoHeight > photoWidth)
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (portrait)");
            }
            else
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (square)");
            }

        }
    }
}
