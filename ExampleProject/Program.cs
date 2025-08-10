using System.IO;
using System;
using System.Drawing;
Console.BackgroundColor= ConsoleColor.DarkGray;
Console.ForegroundColor = ConsoleColor.White;

Console.ReadKey();
Console.WriteLine("");
using (Bitmap bitmap = new Bitmap(@"C:\Users\kelol\source\repos\ExampleProject\ExampleProject\music.jpg"))
{
    int OriginalHeight;
    int OriginalWidth;
    OriginalWidth = bitmap.Width;
    OriginalHeight = bitmap.Height;
    int height = 200;
    int width = 320;
    float scaleX = (float)OriginalWidth / width;
    float scaleY = (float)OriginalHeight / height;
    string grayScaleChar = @"@#0UJLl!our<=+*-;:^`',. ";

    for (int targetY = 0; targetY < height; targetY++)
    {
        
        for (int targetX = 0; targetX < width; targetX++)
        {
            int originalXLoc = Math.Min((int)(targetX * scaleX), OriginalWidth - 1);
            int originalYLoc = Math.Min((int)(targetY * scaleY), OriginalHeight - 1);


            Color pixelcolor = bitmap.GetPixel(originalXLoc, originalYLoc);
            int g = (int)(0.299 * pixelcolor.R + 0.587 * pixelcolor.G + 0.114 * pixelcolor.B);

            if (g > 250) Console.Write(grayScaleChar[0]);
            else if (g > 240) Console.Write(grayScaleChar[1]);
            else if (g > 230) Console.Write(grayScaleChar[2]);
            else if (g > 220) Console.Write(grayScaleChar[3]);
            else if (g > 210) Console.Write(grayScaleChar[4]);
            else if (g > 200) Console.Write(grayScaleChar[5]);
            else if (g > 190) Console.Write(grayScaleChar[6]);
            else if (g > 180) Console.Write(grayScaleChar[7]);
            else if (g > 160) Console.Write(grayScaleChar[8]);
            else if (g > 150) Console.Write(grayScaleChar[9]);
            else if (g > 140) Console.Write(grayScaleChar[10]);
            else if (g > 130) Console.Write(grayScaleChar[11]);
            else if (g > 120) Console.Write(grayScaleChar[12]);
            else if (g > 110) Console.Write(grayScaleChar[13]);
            else if (g > 100) Console.Write(grayScaleChar[14]);
            else if (g > 90) Console.Write(grayScaleChar[15]);
            else if (g > 80) Console.Write(grayScaleChar[16]);
            else if (g > 70) Console.Write(grayScaleChar[17]);
            else if (g > 60) Console.Write(grayScaleChar[18]);
            else if (g > 50) Console.Write(grayScaleChar[19]);
            else if (g > 40) Console.Write(grayScaleChar[20]);
            else if (g > 30) Console.Write(grayScaleChar[21]);
            else if (g > 20) Console.Write(grayScaleChar[22]);
            else if (g > 10) Console.Write(grayScaleChar[23]);
            else Console.Write(' ');

            // threads 

        }
        Console.WriteLine();
    }
}
