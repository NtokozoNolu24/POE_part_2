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
                "Regular backups ensure you won’t lose important files in a cyberattack.",
                "Avoid sharing personal information on public platforms.",
            };

            //social engineering tips
            Tips["engineering"] = new List<string>()
            {
                "Be cautious of unsolicited requests for information.",
                "Verify the identity of anyone asking for sensitive data.",
                "Educate yourself about common social engineering tactics."
            };

            //sql injection tips
            Tips["sql"] = new List<string>()
            {
                "Use parameterized queries to prevent SQL injection.",
                "Validate and sanitize user inputs.",
                "Regularly update your database management system."
            };

            //privacy tips
            Tips["privacy"] = new List<string>()
            {
                "Regularly review and adjust privacy settings on apps \n" +
                "and websites, and be cautious when granting permission. "
            };
        }
    }
}