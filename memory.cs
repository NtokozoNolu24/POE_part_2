using System.Collections.Generic;
using System.IO;
using System;

namespace POE_part_2
{
    internal class memory
    {
        public memory()
        {
            //get app path
            string Full_path = AppDomain.CurrentDomain.BaseDirectory;
            string new_path = Full_path.Replace("bin\\Debug\\", "");
            string path = Path.Combine(new_path, "memory.txt");

            //check memory 
            //List<string> memory_collected = loadMemory(path);  [Assigned the variable first makes it a constant]
            var memory_collected = loadMemory(path);

            //check all stored
            foreach (var check in memory_collected)
            {
                Console.WriteLine(check);
            }
            memory_collected.Add("Luna, What is password?");
            //then save 
            File.WriteAllLines(path, memory_collected);


        }//end of const

        //method to load memory and to check if the file exists 
        private List<string> loadMemory(string path)
        {
            //check if the file exists
            if (File.Exists(path))
            {

                //then return all values or data in file
                return new List<string>(File.ReadAllLines(path));
            }
            else
            {
                //create text file
                File.CreateText(path);
                return new List<string>();
            }

        }// end of memory method


    }
}
