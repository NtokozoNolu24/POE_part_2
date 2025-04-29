using System;
using System.Drawing;
using System.IO;

namespace POE_part_2
{
    public class logo
    {
        public logo()
        {
            //get the location of image
            string location = AppDomain.CurrentDomain.BaseDirectory;

            //replacing bin\\Debug
            string new_location = location.Replace("bin\\Debug\\", "");

            //combine the path
            string full_path = Path.Combine(new_location, "logo_2.jfif");

            //create ASCII image using Bitmap class(use lowercase m for Bitmap)
            //select 'using System.Drawing(from System.Drawing)'
            Bitmap image = new Bitmap(full_path);

            //set the size 
            image = new Bitmap(image, new Size(90, 90));

            //outer and inner loop
            for (int height = 0; height < image.Height; height++)
            {
                //inner loop
                for (int width = 0; width < image.Width; width++)
                {

                }//end of inner loop
                for (int width = 0; width < image.Height; width++)
                {
                    Color pixelColor = image.GetPixel(width, height);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    char asciiChar = gray > 200 ? '.' : gray > 100 ? '*' : gray > 50 ? 'o' : gray > 80 ? '#' : '@';
                    Console.Write(asciiChar);
                }
                Console.WriteLine();
            }//end of outer loop

        }//end of constructor

    }//end of class

}//end of namespace 