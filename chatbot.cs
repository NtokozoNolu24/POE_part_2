using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace POE_part_2
{
    public class chatbot
    {
        //Delegate for user name
        public delegate string name();

        // Random database for extra topic-based responses
        private static Random random = new Random();

        // Dictionary for keyword main responses (each base response has a keyword)
        private Dictionary<string, List<string>> baseResponses = new Dictionary<string, List<string>>();

        // Dictionary for extra randomized tips 
        private Dictionary<string, List<string>> extraTips = new Dictionary<string, List<string>>();

      

        public chatbot()
        {
            //Call all methods in here
            stored_responses();
            ai_chat();

            //Extra tips for the user from the random_resp class
            random_resp tips = new random_resp();

        }//end of constructor


        //method for the AI chatbot
        public void ai_chat()
        {
            //Welcome the user
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("WELCOME TO THE CYBERSECURITY AWARENESS BOT. I AM HERE TO HELP YOU STAY SAFE ONLINE");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

            //AI bot is white in color
            Console.ForegroundColor = ConsoleColor.White;
            //making use of a delegate called user_name to prompt a user for their name
            name getUserName = () =>
            {
                //prompting the user for username
                Console.WriteLine("AIChat:-> Please enter your name");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("User:-> ");
                string user_Name = Console.ReadLine();

                //returning the user name 
                return user_Name ;
            };

            //call delegate and store username
            string username = getUserName();

            //AI response
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("AIChat:-> Hi there " + username + "!" + " How are you today?");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("AIChat:-> If there isn't anything you need, Type 'leave' to exit the chat");

                //use while loop to allow user to continue to interact with chatbot
                //while loop will end when "leave" is typed
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(username + ":-> ");
                    string input = Console.ReadLine().ToLower();

                    //if "leave" is typed, then display message and end program
                    if (input == "leave")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("AIChat:-> Thank you " + username + " for chatting! Stay safe online.");
                        break;
                    }

                //This if statement will ask the user a follow-up question if the input is empty
                //This is to keep the conversation going
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    string followUpQuestion = followUps[random.Next(followUps.Count)];
                    Console.WriteLine("AIChat:-> " + followUpQuestion);
                }

                //to get response
                string response = Response(input);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(response);

                }
            }
        // This is the list of follow-up questions
        private List<string> followUps = new List<string>()
        {
            "Is there anything you'd like to ask me about cybersecurity?",
            "Remember, I'm here to help you stay safe online. Any questions?",
            "Don't hesitate to ask about phishing, malware, or online privacy!"
        };

        //then store responses using a method 
        //In this method, the base responses are stored in a dictionary and they identify multiple keywords
        private void stored_responses()
        {
            string youResponse = "AIChat:-> I am great thanks!\nHow can I assist you today?";
            baseResponses["you?"] = new List<string> {youResponse};

            string scamResponse = "AIChat:-> To avoid online scams, users should stay vigilant and skeptical of unsolicited messages,\n" +
                " offers that seem too good to be true, or urgent requests for personal or financial information.\n" +
                " Always verify the legitimacy of websites and emails by checking URLs carefully and looking\n" +
                " for secure connections (https://). Avoid clicking on suspicious links or downloading unknown attachments.\n" +
                " Use strong, unique passwords and enable two-factor authentication wherever possible.\n" +
                " Regularly update software and security settings, and report suspicious activity to relevant platforms or authorities";
            baseResponses["scam"] = new List<string> { scamResponse };
            baseResponses["scams"] = new List<string> { scamResponse };
            baseResponses["scam?"] = new List<string> { scamResponse };
            baseResponses["scammed"] = new List<string> { scamResponse };

            string phishingResponse =
            "AIChat:-> Phishing is a cyberattack where scammers trick you into revealing personal information,\n" +
            "like passwords or credit card numbers, by pretending to be a trusted source (e.g., bank, email provider).";
            baseResponses["phishing"] = new List<string> { phishingResponse };
            baseResponses["phish"] = new List<string> { phishingResponse };
            baseResponses["phishing?"] = new List<string> { phishingResponse };

            string malwareResponse = 
            "AIChat:-> Malware is malicious software designed to damage,\n" +
            " disrupt, or gain unauthorized access to computer systems.";
            baseResponses["malware"] = new List<string>{malwareResponse};
            baseResponses["malware?"] = new List<string> { malwareResponse };
            baseResponses["malwares"] = new List<string> { malwareResponse };

            string onlineResponse =
            "AIChat:-> To stay safe online, use strong passwords, enable two-factor authentication,\n"+
            " avoid clicking on suspicious links, keep your software updated, \n" +
            " and be cautious about sharing personal information.";
            baseResponses["online"] = new List<string> {onlineResponse };
            baseResponses["online?"] = new List<string> { onlineResponse };

            string privacyResponse =
            "AIChat:-> Limit personal info shared online, use strong passwords, VPNs, and adjust privacy settings.";
            baseResponses["privacy"] = new List<string>{privacyResponse};

            string purposeResponse =
            "AIChat:-> I'm here to boost your cybersecurity awareness and guide you on best practices!\n" +
            " and to provide tips on cybersecurity threats like phishing, malware, and password safety.";
            baseResponses["purpose"] = new List<string> {purposeResponse };
            baseResponses["purpose?"] = new List<string> { purposeResponse };

            string protectResponse =
            "AIChat:-> To protect yourself online, use strong, unique passwords,\n" +
            " enable two-factor authentication, avoid suspicious links or downloads,\n" +
            " keep your software updated, and be cautious about sharing personal information.";
            baseResponses["protect"] = new List<string>{protectResponse};

            string askResponse =
            "AIChat:-> You can ask me about anything related to cybersecurity :)";
            baseResponses["ask"] = new List<string>{askResponse};

            string cyberResponse =
            "AIChat:-> Cybersecurity is the practice of protecting computers,\n" +
            " networks, and data from unauthorized access, attacks, or damage.";
            baseResponses["cybersecurity"] = new List<string>{cyberResponse};
            baseResponses["cybersecurity?"] = new List<string> { cyberResponse };

            string passwordResponse =
            "AIChat:-> A strong password is a combination of letters, numbers, and symbols,\n" +
            " typically at least 12 characters long, and not easily guessable.\n" +
            " Avoid using personal information like birthdays or common words.";
            baseResponses["password"] = new List<string>{passwordResponse};
            baseResponses["password?"] = new List<string> { passwordResponse };
            baseResponses["passwords"] = new List<string> { passwordResponse };

            string attackResponse = "AIChat:-> Cyber attacks are attempts to steal, damage, or disrupt data or systems.";
            baseResponses["attacks"] = new List<string>{attackResponse};
            baseResponses["attack"] = new List<string> { attackResponse };

            string injectionResponse =
            "AIChat:-> SQL injection is a code injection technique that exploits a security vulnerability in an application's software.\n" +
            " lets attackers manipulate databases by inserting malicious queries.";
            baseResponses["injection"] = new List<string>{injectionResponse};
            baseResponses["SQL injection"] = new List<string> { injectionResponse };

            string thanksResponse =
            "AIChat:-> Always glad to help! Let me know if you need anything :)";
            baseResponses["thank"] = new List<string> {thanksResponse};
            baseResponses["thanks"] = new List<string> { thanksResponse };
        }

        //method for ignore words
        // Words to ignore during keyword filtering
        private List<string> ignoreWords = new List<string>
        {
            "tell", "online", "can", "i", "create", "stay", "me", "about", "what", "is", "how", "your"
        };
        //end of ignore_words method

        

        private string Response(string input)
        {
            string[] words = input.ToLower().Split(' ');
            var filteredWords = words
                .Select(word => new string(word.Where(char.IsLetterOrDigit).ToArray()))
                .Where(word => !ignoreWords.Contains(word))
                .ToList();

            foreach (var word in filteredWords)
            {
                if (baseResponses.ContainsKey(word))
                {
                    string baseReply = baseResponses[word][random.Next(baseResponses[word].Count)];
                    string extraReply = "";

                    if (extraTips.ContainsKey(word))
                    {
                        extraReply = "\n\nExtra Tip: " + extraTips[word][random.Next(extraTips[word].Count)];
                    }


                    return baseReply + extraReply;
                }
            }

            return "AIChat:-> I'm sorry, I don't understand that. Can you please rephrase your question?\n" +
                   followUps[random.Next(followUps.Count)];
        }
         
}//end of class
}//end of namespace

