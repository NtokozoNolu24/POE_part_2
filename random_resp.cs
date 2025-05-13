using System.Collections.Generic;

namespace POE_part_2
{
    public class random_resp
    {
        /// Dictionary to store tips for different categories
        public Dictionary<string, List<string>> Tips { get; private set; }
        public random_resp()
        {
            // Initialize tips dictionary
            Tips = new Dictionary<string, List<string>>();

            //Storing information for random responses for the tips (generic collection)

            //phishing tips
            Tips["phishing"] = new List<string>()
            {
                "Be cautious of emails requesting personal info.",
                "Always check the sender's email address.",
                "Never click on suspicious links."
            };

            //password tips
            Tips["password"] = new List<string>()
            {
                "Use a mix of letters, numbers, and symbols.",
                "Change your passwords regularly.",
                "Avoid using the same password for multiple accounts."
            };

            //malware tips
            Tips["malware"] = new List<string>()
            {
                "Keep your software updated.",
                "Use reputable antivirus software.",
                "Be careful when downloading files from the internet."
            };

            //online safety tips
            Tips["safe"] = new List<string>()
            {
                "Regular backups ensure you won’t lose important files in a cyberattack."
                
            };
        }
    }
}