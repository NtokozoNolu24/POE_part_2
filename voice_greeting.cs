using System;
using System.IO;
using System.Media;

namespace POE_part_2
{
    public class voice_greeting
    {
        public voice_greeting()
        {
            //getting full project location for voice greeting
            string full_location = AppDomain.CurrentDomain.BaseDirectory;

            //replace the bin\Debug folder in the full_location 
            string new_path = full_location.Replace("bin\\Debug\\", "");

            //try and catch
            try
            {
                string full_path = Path.Combine(new_path, "voice_greeting.wav");

                //create an instance for the SoundPlay class
                using (SoundPlayer play = new SoundPlayer(full_path))
                {

                    //play audio
                    play.PlaySync();
                }//end of using
            }
            catch (Exception error){//error message will be displayed if audio does not play
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Unable to play the voice greeting.");
                Console.WriteLine("\nTechnical details: "+ error.Message);
                Console.ResetColor();
            }//end of catch

        }//end of constructor
    }//end of class
}//end of namespace