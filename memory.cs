using System.Collections.Generic;
using System.IO;
using System;

namespace POE_part_2
{
    public class memory
    {
        private string path;
        public Dictionary<string, string> userData;

        public memory()
        {
          
            userData = new Dictionary<string, string>();

            //get app path
            string Full_path = AppDomain.CurrentDomain.BaseDirectory;
            string new_path = Full_path.Replace("bin\\Debug\\", "");
            path = Path.Combine(new_path, "memory.txt");

            // load memory
            userData = loadMemory(path);
        }//end of constructor

        public Dictionary<string, string> loadMemory(string path)
        {
            var data = new Dictionary<string, string>();

            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    if (line.Contains("="))
                    {
                        // Split each line only at the first '=' to preserve values with '=' in them
                        string[] parts = line.Split(new char[] { '=' }, 2);
                        if (parts.Length == 2)
                        {
                            data.Add(parts[0], parts[1]); // store as-is without trimming
                        }
                    }
                }
            }
            else
            {
                // Create the file if it does not exist
                File.CreateText(path).Close();
            }

            return data;
        }

        // Save memory to file
        public void SaveMemory()
        {
            var lines = new List<string>();
            foreach (KeyValuePair<string, string> entry in userData)
            {
                lines.Add(entry.Key + "=" + entry.Value);
            }
            File.WriteAllLines(path, lines);
        }
        
        public void SetData(string key, string value)
        {
            if (userData.ContainsKey(key))
                userData[key] = value;
            else
                userData.Add(key, value);
        }

        public string GetData(string key)
        {
            return userData.ContainsKey(key) ? userData[key] : null;
        }
    }//end of class

}//end of namespace


