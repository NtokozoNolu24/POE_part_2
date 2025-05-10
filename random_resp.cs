using System.Collections.Generic;

namespace POE_part_2
{
    public class random_resp
    {
        public random_resp()
        {
            //Storing information for random responses for the tips (generic collection)
            List<string> phishing_tips = new List<string>()
            {
                "Be cautious of emails requesting personal info.",
                "Always check the sender's email address.",
                "Never click on suspicious links."
            };
            List<string> password_tips = new List<string>()
            {
                "Use a mix of letters, numbers, and symbols.",
                "Change your passwords regularly.",
                "Avoid using the same password for multiple accounts."
            };
            List<string> malware_tips = new List<string>()
            {
                "Keep your software updated.",
                "Use reputable antivirus software.",
                "Be careful when downloading files from the internet."
            };
        }
    }
}