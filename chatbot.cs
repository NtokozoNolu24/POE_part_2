using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace POE_part_2
{
    public class chatbot
    {
        //first arraylist stores the answer of the user
        ArrayList responses = new ArrayList();
        //second arrayist filters the answer( by picking out keywords)
        ArrayList ignore = new ArrayList();
        //this arraylist id for keywords that the bot will pick up when the user asks their question
        ArrayList keyWords = new ArrayList();
        //Delegate for user name
        public delegate string name();

        public chatbot()
        {
            //Call all methods in here
            stored_responses();
            ignore_words();
            ai_chat();
            
       
           }//end of constructor

        //method for the AI chatbot
        public void ai_chat()
        {
            //Welcome user
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
                    //to get response
                    string response = Response(input);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(response);


               
                }
            }
            

         
            //then store responses using a method 
            //keywords are also added to quickly identify the response and give it yo the user
            private void stored_responses() {
            keyWords.Add("you?");
            responses.Add("AIChat:-> I am great thanks!\n"+"How can I assist you today?");

            keyWords.Add("purpose");
            responses.Add("AIChat:-> I am designed to enhance cybersecurity awareness,\n" +
                         " generate responses to security incidents and provide guidance on cybersecurity best practices\n" +
                         " such as recognizing phishing attempts, securing passwords and avoiding social engineering attacks!");

            //in case the user asks a question
            keyWords.Add("purpose?");
            responses.Add("AIChat:-> I am designed to enhance cybersecurity awareness,\n" +
                         " generate responses to security incidents and provide guidance on cybersecurity best practices\n" +
                         " such as recognizing phishing attempts, securing passwords and avoiding social engineering attacks!");

            keyWords.Add("protect");
            responses.Add("AIChat:-> Use strong passwords, keep software up-to-date, and be cautious with emails.");

            keyWords.Add("ask");
            responses.Add("AIChat:-> You can ask me about anything related to cybersecurity :)");

            keyWords.Add("browsing?");
            responses.Add("AIChat:-> Safe browsing refers to the practice of using the internet securely\n" +
                          " while protecting yourself from online threats such as malware, phishing attacks, and data theft.\n" +
                          " It involves adopting habits and using tools that help minimize risks while surfing the web.");

            keyWords.Add("browsing");
            responses.Add("AIChat:-> Safe browsing refers to the practice of using the internet securely\n" +
                          " while protecting yourself from online threats such as malware, phishing attacks, and data theft.\n" +
                          " It involves adopting habits and using tools that help minimize risks while surfing the web.");


            keyWords.Add("safe");
            responses.Add("AIChat:-> There are many ways to stay safe online.\n " +
                          " Here are some key cybersecurity tips:\n" +
                          "~ Always use strong, unique passwords for each account.\n" +
                          "~ Be cautious about what you share online\n" +
                          " (avoid posting sensitive details like your address or phone number).\n" +
                          "~ Adjust privacy settings on social media to control who can see your information.\n" +
                          "~ Never click on suspicious links in emails or messages.");

            keyWords.Add("phishing");
            responses.Add("AIChat:-> Phishing is a type of cyberattack where scammers try to trick you into providing personal information,\n" +
                          " such as passwords, credit card numbers, or other sensitive data. These attacks often come in the form of emails,\n" +
                          " text messages,or fake websites that appear to be from legitimate companies or individuals");

            //in case the user asks a question
            keyWords.Add("phishing?");
            responses.Add("AIChat:-> Phishing is a type of cyberattack where scammers try to trick you into providing personal information,\n" +
                          " such as passwords, credit card numbers, or other sensitive data. These attacks often come in the form of emails,\n" +
                          " text messages,or fake websites that appear to be from legitimate companies or individuals");

            keyWords.Add("cybersecurity");
            responses.Add("AIChat:-> Cybersecurity is the practice of protecting computer systems, networks, and data from digital threats,\n" +
                          " such as hacking, malware, phishing, and other cyberattacks. It involves using technologies, processes,\n" +
                          " and best practices to prevent unauthorized access, data breaches, and damage to sensitive information.");
            //in case the user asks a question
            keyWords.Add("cybersecurity?");
            responses.Add("AIChat:-> Cybersecurity is the practice of protecting computer systems, networks, and data from digital threats,\n" +
                          " such as hacking, malware, phishing, and other cyberattacks. It involves using technologies, processes,\n" +
                          " and best practices to prevent unauthorized access, data breaches, and damage to sensitive information.");

            keyWords.Add("thank");
            responses.Add("AIChat:-> Always glad to help! Let me know if you need anything :)");

            keyWords.Add("thanks");
            responses.Add("AIChat:-> Always glad to help! Let me know if you need anything :)");

            keyWords.Add("password");
            responses.Add("AIChat:-> A strong password is a secure and hard-to-guess combination\n" +
                          " of characters that helps protect your accounts and data from hackers.\n" +
                         " A good password should be long, complex, and unique.");

            keyWords.Add("attacks");
            responses.Add("AIChat:-> Different Types of Cyber Attacks: \n" +
                          " Phishing – Tricking users into revealing personal information through fake emails or websites.\n" +
                          " Malware – Malicious software like viruses, worms, and ransomware that harm systems.\n" +
                          " Ransomware – Attackers lock your files and demand payment to unlock them.\n" +
                          " SQL Injection – Inserting harmful SQL code to gain access to databases.\n" +
                          " Denial of Service (DoS) & Distributed DoS (DDoS) – Overloading a system to make it unavailable.\n" +
                          " Man-in-the-Middle (MitM) Attack – Hackers intercept communication between two parties.\n" +
                          " Brute Force Attack – Repeatedly guessing passwords until access is gained.\n" +
                          " Zero-Day Exploit – Attacking a software vulnerability before it's patched.\n" +
                          " Spyware – Software that secretly collects your data without permission.\n" +
                          " Trojan Horse – Malicious software disguised as a legitimate program.");


            keyWords.Add("injection");
            responses.Add("AIChat:-> SQL injection is a type of cyber attack where hackers manipulate SQL \n" +
                          " queries to gain unauthorized access to a database.\n" +
                          " This is done by inserting malicious SQL code into input fields, which can allow attackers to\n" +
                          " bypass authentication, retrieve sensitive data, modify databases, or even delete entire tables.");

        }

        //method for ignore words
        private void ignore_words()
        {
            ignore.Add("tell");
            ignore.Add("Tell");
            ignore.Add("online");
            ignore.Add("online?");
            ignore.Add("can");
            ignore.Add("i");
            ignore.Add("create");
            ignore.Add("I");
            ignore.Add("stay");
            ignore.Add("me");
            ignore.Add("about");
            ignore.Add("what");
            ignore.Add("is");
            ignore.Add("how");
            ignore.Add("your");
            
        }//end of ignore_words method
    
            private string Response(string input)
        {
            string[] words = input.Split(' ');
            ArrayList filteredWords = new ArrayList();

            // Filter out ignored words
            foreach (string word in words)
            {
                if (!ignore.Contains(word))
                {
                    filteredWords.Add(word);
                }
            }//end of foreach 

            // Check if the keyword matches in responses
            for (int i = 0; i < keyWords.Count; i++)
            {
                if (filteredWords.Contains(keyWords[i]))
                {
                    return responses[i].ToString();
                }
            }

            return "I can only answer to questions related to Cybersecurity. Please ask me something related to cybersecurity :)";
        }//end of response method
    }//end of class
}//end of namespace

