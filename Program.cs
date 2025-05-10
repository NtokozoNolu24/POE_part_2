using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace POE_part_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create instance class for voice greeting
            new voice_greeting() { };

            //create instance class for ASCII image
            new logo() { };
           
            //Create an instance for AI chatbot
            new chatbot() { };

            //Create an instance class for memory and recall 
            new memory() { };

            //create an instance class for random responses
            new random_resp() { };
        }
    }
    }

