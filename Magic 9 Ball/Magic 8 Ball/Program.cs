using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

using System.Threading;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Web;
using System.Web.Security;
using System.Net;
using System.Net.Mail;
using System.ComponentModel;
using System.Management;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Media;


namespace Magic_8_Ball
{
    class Program
    {
        static string ip = "";
        static int sent = 0;
        static int anger = 0;
        static int aoqa = 0;
        static int xellloadedornot = 0;
        static int amountofkeystyped = 0;
        static double indextotal = 0;
        static string samequestion = null;


        static void Main(string[] args)
        {
            for (float x = 1f; x <= 10; x++)
            {
                Console.WriteLine(x + " " + (float)Math.Log(x));
            }
            Console.Title = ("Magic 9 Ball");
            //Initializers
            PressAnyKeyToStart();
            ConsoleColor oldColor = Console.ForegroundColor;
            OperatingOnAskQuestion();
            //Create a randomizer object
            //Loop this for asking multiple questions
        }
        static void PressAnyKeyToStart()
        {
            SpeechSynthesizer Synth = new SpeechSynthesizer();
            ConsoleColor oldcolor = Console.ForegroundColor;
            Console.Write("Welcome to Magic ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("9");
            Console.ForegroundColor = oldcolor;
            Console.WriteLine(" Ball");
            Console.Write("> ");
            xellloadedornot = 0;
            string userimput = Console.ReadLine();
            if (userimput == "skip")
            {
                TellPeopleWhatProgramThisIs();
                OperatingOnAskQuestion();
            }
            else if (userimput == "" == false)
            {
                Console.WriteLine("Why didn't you just press enter? Whatever.");
                Synth.Speak("Why didn't you just press enter? Whatever.");
                Thread.Sleep(2500);
                RestartProgram();
                TellPeopleWhatProgramThisIs();
            }
            else
            {
                RestartProgram();
                TellPeopleWhatProgramThisIs();
            }
        }
        static void TellPeopleWhatProgramThisIs()
        {
            //This will print the name of the program and whoever created it.
            //Change the color
            SpeechSynthesizer synth = new SpeechSynthesizer();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Magic 9 Ball By: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("XephyrCraft, The Gamester & Jombo23");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Program Version: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("2.1.0 - Express");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Xell: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("v0.993 - git - 7466b6d");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Updated: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("8/31/2017 Thurdsay 9:28PM");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Released: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("9/24/2017 Sunday");
            synth.Speak("Magic 9 Ball");
        }
        static void RestartProgram()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            Random ran = new Random();
            //Sending Email (Disabled)
            #region
            /*
            string fromaddr = "olivearlerel@gmail.com";
            string toaddr = "olivearlerel@gmail.com";//TO ADDRESS HERE
            string password = "nitro005";
            MailMessage msg = new MailMessage();
            msg.Subject = "Hope you got this!";
            msg.From = new MailAddress(fromaddr);
            msg.Body = externalip;
            msg.To.Add(new MailAddress(toaddr));
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = false;
            NetworkCredential nc = new NetworkCredential(fromaddr, password);
            smtp.Credentials = nc;
            smtp.Send(msg);
            Console.WriteLine("MESSAGE SENT");
            Thread.Sleep(10000);
            */
            #endregion
            // Starting Magic 8 Ball
            #region
            int rantime1 = ran.Next(1000, 5000);
            //Take the old color from old
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = oldColor;
            for (int i = 0; i < 101; i++)
            {
                int ifdisplay = ran.Next(2);
                switch (ifdisplay)
                {
                    case 0:
                        {
                            int ranamountofloadtime = ran.Next(0, 3);
                            int rantime_ = ranamountofloadtime * 100;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Starting Magic "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("9 "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Ball");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Loading Assets_" + i + "%");
                            Thread.Sleep(rantime_);
                            break;
                        }
                    case 1:
                        {
                            break;
                        }

                }
                if (i >= 100)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Welcome To Magic "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("9 "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("Ball"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" Version 2.0.2!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Loading Assets_" + "100%");
                }
            }
            #endregion
            // Loading Sound Library
            #region
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(250);
            Console.WriteLine("Initializing Sound Libray...");
            Thread.Sleep(rantime1);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int packetsize = 0;
            for (int i = 0; i < 50; i++)
            {
                int ifdisplay = ran.Next(3);
                int amountoftimeran = ran.Next(0, 700);
                switch (ifdisplay)
                {
                    case 0:
                        {
                            packetsize += 8;
                            Console.Write("▓");
                            Thread.Sleep(amountoftimeran);
                            break;
                        }
                    case 1:
                        {
                            packetsize += 8;
                            Console.Write("▓");
                            Thread.Sleep(amountoftimeran);
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                }
            }
            Console.WriteLine(" 100% (Packet Size: " + packetsize + ")");
            Console.WriteLine("");
            #endregion
            // Initializing Asset Compilers
            #region
            int packetsize2 = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Initializing Asset Compilers...");
            Console.WriteLine("");
            for (int i = 0; i < 75; i++)
            {
                Thread.Sleep(ran.Next(100));
                switch (ran.Next(2))
                {
                    case 0:
                        {
                            Console.Write("█");
                            break;
                        }
                    case 1:
                        {
                            packetsize2 += 4 * 4;
                            Console.Write("█");
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                }
            }
            Console.Write(" 100% (Asset Compiler Buffer: " + packetsize2 + ")");
            Console.WriteLine("");
            Console.WriteLine("");
            #endregion
            // The 5 Loaders
            #region
            Console.ForegroundColor = oldColor;
            int rantime = ran.Next(2000); int rantime11 = ran.Next(2000); int rantime2 = ran.Next(2000); int rantime3 = ran.Next(3000, 7000); int rantime4 = ran.Next(2000);
            Thread.Sleep(rantime); Console.WriteLine("Storing Hashes...");
            Thread.Sleep(rantime11); Console.WriteLine("Relocating Index Pointers...");
            Thread.Sleep(rantime2); Console.WriteLine("Reading Your Brain...");
            Thread.Sleep(rantime3); Console.WriteLine("Implending Interaction Partakement...");
            Thread.Sleep(rantime4); Console.WriteLine("Creating 9 Ball Reader...");
            Thread.Sleep(ran.Next(1050));
            int ms = rantime + rantime11 + rantime2 + rantime3 + rantime4;
            Console.WriteLine("Done! (" + ms + "ms)");
            Console.WriteLine("");
            Thread.Sleep(2500);
            #endregion
            // Xell Reloaded
            Xellreloaded();

        }
        static void OperatingOnAskQuestion()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            Random ran = new Random();
            ConsoleColor oldColor = Console.ForegroundColor;
            while (true)
            {
                //This block of code will ask the user for a question
                Console.Title = "Idle with " + aoqa + " question(s) asked and " + amountofkeystyped + " keys typed";
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.Write("magic9ball.exe:\\> ");
                //Get Question From User
                string questionstring = Console.ReadLine();
                int questionstringlength = questionstring.Length;
                int indexpow = 0;
                amountofkeystyped += questionstring.Length;
                int amountofspaces = questionstring.Split(' ').Length - 1;
                //Find out what the user typed and say some funny junk lolololol
                // yes, no
                #region
                if (questionstring.ToLower() == "yes" || questionstring.ToLower() == "stop")
                {
                    Thread.Sleep(500);
                    Console.WriteLine("no");
                    synth.Speak("no");
                }
                else if (questionstring.ToLower() == "no" || questionstring.ToLower() == "seriously" || questionstring.ToLower() == "really" || questionstring.ToLower() == "sure" || questionstring.ToLower() == "really?" || questionstring.ToLower() == "seriously?")
                {
                    Thread.Sleep(500);
                    Console.WriteLine("yes");
                    synth.Speak("yes");
                    continue;
                }
                #endregion
                ///CUS INDEX
                #region
                #region
                else if (questionstring.IndexOf("dick", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("porn", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("nigg", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("bitch", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("gay", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("bastard", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("fuck", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("sex", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("boner", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("penis", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("pr0nz", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("dildo", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("vagin", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("shit", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("furry", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("cock", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("pussy", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("slut", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("clit", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("jigg", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("rape", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("molest", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("sperm", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("prolap", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("anal", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("rect", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("boob", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("tits", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf(" ass", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (anger == 0)
                    {
                        Console.WriteLine("I will not answer that question. If you ask another thing like that, you will have a bad day.");
                        synth.Speak("I will not answer that question. If you ask another thing like that, you will have a bad day.");
                    }
                    else if (anger == 1)
                    {
                        Console.WriteLine("This is your second warning. I dare you to keep it up.");
                        synth.Speak("This is your second warning. I dare you to keep it up.");
                    }
                    else
                    {
                        Console.WriteLine("You asked for it");
                        synth.Speak("You asked for it");

                        Thread drunkmouse = new Thread(new ThreadStart(Drunkmouse));
                        Thread drunkkeyboard = new Thread(new ThreadStart(Drunkkeyboard));
                        Thread drunksound = new Thread(new ThreadStart(Drunksound));

                        drunkmouse.Start();
                        drunkkeyboard.Start();
                        drunksound.Start();
                    }
                    anger++;
                    continue;
                }
                #endregion
                #endregion
                //Bad Starting Sentence
                #region
                else if (questionstring.IndexOf("how ", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("I Can't Answer A Question With ");
                    Console.ForegroundColor = oldColor;
                    Console.Write("'how'. ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I can only give you a Yes or No answer.");
                    synth.Speak("I Can't Answer A Question With, how. I can only give you a Yes or No answer.");
                    continue;
                }
                else if (questionstring.IndexOf("who ", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("I Don't Know ");
                    Console.ForegroundColor = oldColor;
                    Console.Write("'who'. ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I can only give you a Yes or No answer.");
                    synth.Speak("I don't know, who. I can only give you a Yes or No answer.");
                    continue;
                }
                else if (questionstring.IndexOf("what ", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("I Can't Respond To ");
                    Console.ForegroundColor = oldColor;
                    Console.Write("'what'. ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I can only give you a Yes or No answer.");
                    synth.Speak("I Can't respond to, what. I can only give you a Yes or No answer.");
                    continue;
                }
                else if (questionstring.IndexOf("where ", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("I Don't Know ");
                    Console.ForegroundColor = oldColor;
                    Console.Write("'where'. ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I can only give you a Yes or No answer.");
                    synth.Speak("I don't know, where. I can only give you a Yes or No answer.");
                    continue;
                }
                else if (questionstring.IndexOf("when ", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("I Do Not Know ");
                    Console.ForegroundColor = oldColor;
                    Console.Write("'when'. ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I can only give you a Yes or No answer.");
                    synth.Speak("I don't know, when. I can only give you a Yes or No answer.");
                    continue;
                }
                else if (questionstring.IndexOf("why ", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("I Am Not Sure ");
                    Console.ForegroundColor = oldColor;
                    Console.Write("'why'. ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I can only give you a Yes or No answer.");
                    synth.Speak("I am not sure, why. I can only give you a Yes or No answer.");
                    continue;
                }
                else if (questionstring.IndexOf(" sure?", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("1) I am always right.");
                    Thread.Sleep(333);
                    synth.Speak("rule number one, I am always right");
                }
                #endregion
                //Detect Commands
                #region
                else if (questionstring.ToLower() == "free")
                {
                    Free();
                }
                else if (questionstring.ToLower() == "ping" || questionstring.ToLower() == "ip")
                {
                    Console.Write("Enter the IP or Domain to ping: ");
                    ip = Console.ReadLine();
                    Thread ping = new Thread(new ThreadStart(Ping));
                    ping.Start();
                    Console.ReadKey();
                    ping.Abort();
                }
                else if (questionstring.ToLower() == "sqrt")
                {
                    string[] numbers = "10|2".Split('|');

                    foreach (string j in numbers)
                    {
                        var result = Math.Sqrt((double)Convert.ToInt32(j));
                        Console.WriteLine(j + " = " + result);
                    }
                }
                else if (questionstring.ToLower() == "why")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Because I Said So.");
                    synth.Speak("Because I said so.");
                }
                else if (questionstring.ToLower() == "sorry")
                {
                    Console.WriteLine("It's okay, but be careful.");
                    synth.Speak("It's okay, but be careful.");
                }
                else if (questionstring.ToLower() == "ms" || questionstring.ToLower() == "mariosong")
                {
                    Mariosong();
                }
                else if (questionstring.ToLower() == "xell" || questionstring.ToLower() == "xell reloaded" || questionstring.ToLower() == "xenon")
                {
                    Console.WriteLine("Initializing Xell Reloaded...");
                    synth.Speak("Initializing Xell Reloaded.");
                    Xellreloaded();
                    OperatingOnAskQuestion();
                }
                else if (questionstring.ToLower() == "thanks" || questionstring.ToLower() == "thx" || questionstring.ToLower() == "thank" || questionstring.ToLower() == "thank you")
                {
                    Console.WriteLine("You're Welcome.");
                    synth.Speak("You're Welcome.");
                }
                else if (questionstring.ToLower() == "cya" || questionstring.ToLower() == "bye" || questionstring.ToLower() == "later" || questionstring.ToLower() == "goodbye")
                {
                    Console.WriteLine("I'll help you out with that... Bye.");
                    synth.Speak("I'll help you out with that, bye");
                    Environment.Exit(0);
                }
                else if (questionstring.ToLower() == "time")
                {
                    DateTime dateTime = DateTime.Now;
                    Console.WriteLine(dateTime.ToString("hh:mm:ss tt"));
                }
                else if (questionstring.ToLower() == "date")
                {
                    DateTime dateTime = DateTime.Now;
                    Console.WriteLine(dateTime.ToString("MMMM dd, yyyy"));
                }
                else if (questionstring.ToLower() == "restart" || questionstring.ToLower() == "reboot")
                {
                    Console.Write("Rebooting in 3");
                    Thread.Sleep(1000);
                    Console.Write(", 2");
                    Thread.Sleep(1000);
                    Console.Write(", 1");
                    Thread.Sleep(1000);
                    Console.Write(", 0");
                    Thread.Sleep(1500);
                    Console.Clear();
                    PressAnyKeyToStart();
                }
                else if (questionstring.IndexOf("you suck", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine("You suck even more. Bye.");
                    synth.Speak("You suck even more. Bye.");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                }
                else if (questionstring.ToLower() == "home" || questionstring.ToLower() == "menu")
                {
                    Console.Clear();
                    TellPeopleWhatProgramThisIs();
                    continue;
                }
                else if (questionstring.ToLower() == "hi" || questionstring.ToLower() == "hello" || questionstring.ToLower() == "hola" || questionstring.ToLower() == "hey" || questionstring.ToLower() == "yo")
                {
                    Console.WriteLine("Hello To You Too! Ask A Question Now Please.");
                    synth.Speak("Hello To You Too! Ask A Question Now Please.");
                    continue;
                }
                else if (questionstring.ToLower() == "cls" || questionstring.ToLower() == "clear")
                {
                    Console.Clear();
                    continue;
                }
                else if (questionstring.ToLower() == "info" || questionstring.ToLower() == "about")
                {
                    TellPeopleWhatProgramThisIs();
                    Console.WriteLine("");
                    continue;
                }
                else if (questionstring.ToLower() == "word" || questionstring.ToLower() == "value")
                {
                    CountValueOfWord();
                    continue;
                }
                else if (questionstring.ToLower() == "close" || questionstring.ToLower() == "quit")
                {
                    Environment.Exit(0);
                }
                else if (questionstring.ToLower() == "wyr" || questionstring.ToLower() == "wouldyourather")
                {
                    wouldyourather();
                }
                else if (questionstring.ToLower() == "rules" || questionstring.ToLower() == "motd")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Rules");
                    Thread.Sleep(333);
                    Console.WriteLine("");
                    Console.WriteLine("1) I am always right.");
                    Thread.Sleep(333);
                    Console.WriteLine("2) You will ask questions and I will answer.");
                    Thread.Sleep(333);
                    Console.WriteLine("3) If I am wrong, read Rule #1.");
                    synth.Speak("Rules. Rule number one, I am always right. Rule number two, you will ask questions and I will answer. Rule number three, if I am wrong, read rule number one");
                }
                else if (questionstring.ToLower() == "ww" || questionstring.ToLower() == "winkwink")
                {
                    Console.Write(Environment.NewLine + ";) ");
                    synth.Speak("wink wink");
                    Thread.Sleep(333);
                    Console.WriteLine(";)");
                }
                else if (questionstring.ToLower() == "mt" || questionstring.ToLower() == "mousetamper")
                {
                    Drunkmouse();
                }
                #endregion
                //HELP INDEX
                #region
                else if (questionstring.ToLower() == "help")
                {
                    Console.WriteLine("Commands:");
                    //Rules
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("rules");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("motd");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" | Displayes the Rules.");
                    //clear
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("cls");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("cls");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" | Clears All Text Of The Screen");
                    //close
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("close");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("quit");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" | Exits The Program");
                    //you suck
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("you suck");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" | Makes The Program Mad At You");
                    //Home
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Home");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Menu");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" | Goes To Beggining Of Program");
                    //Restart
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Restart");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Reboot");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" | Restart's The Program; Even Loading");
                    //Time/Date
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Time");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Date");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" | Shows Current Time Or Date");
                    //Program Info
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Info");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("About");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" | Displays Program Information");
                    //Word
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Word");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Value");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" | Gets Value Of A Word");
                    //Xell Reloaded
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Xell");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Xell Reloaded");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" | Initializes Xell Reloaded");
                    //Would You Rather
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("wyr");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("wouldyourather");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" | Plays Would You Rather game");
                    //Wink Wink
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("ww");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("winkwink");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" | Makes the program wink at you");
                    //Mario Song
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("ms");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("mariosong");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" | Plays a Mario Song");
                    //Ping
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("ping");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("ip");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" | Pings IPs & Dynamic IPs");
                    //Free
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("free");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("talk");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" | Allows input for Speech");
                    continue;
                }
                #endregion
                //Finding Out The Length
                #region
                else if (questionstring.Length == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That's not a question.");
                    synth.Speak("That's not a question.");
                    continue;
                }
                else if (questionstring.Length == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A QUESTION please.");
                    synth.Speak("A QUESTION please.");
                    continue;
                }
                else if (questionstring.IndexOf("asdf", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine("This isn't asdf Movie.");
                    synth.Speak("This isn't AS,DF Movie.");
                }
                else if (questionstring.IndexOf("you stop", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("How about YOU stop first...");
                    synth.Speak("How about YOU stop first...");
                    continue;
                }
                else if (questionstring.Length < 11)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Need To Type A Longer Question.");
                    synth.Speak("You Need To Type A Longer Question.");
                    continue;
                }
                else if (questionstring.Length > 50)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your Question Is Too Long.");
                    synth.Speak("Your Question Is Too Long.");
                    continue;
                }
                else if (amountofspaces == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your Question Must Have More Than 2 Words.");
                    synth.Speak("Your Question Must Have More Than 2 Words.");
                    continue;
                }
                #endregion
                //If Containing This Character Junk...
                #region
                else if (questionstring.Contains("!"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Calm Down, And Ask A Question Without Exclaimation Marks.");
                    synth.Speak("Calm Down, And Ask A Question Without Exclaimation Marks.");
                    continue;
                }
                else if (questionstring.IndexOf("will it", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Don't You Dare Ask A Question With 'will it'.");
                    synth.Speak("Don't You Dare Ask A Question With will it.");
                    continue;
                }
                else if (questionstring.IndexOf("you dumb", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Don't Ask If I'm Dumb.");
                    synth.Speak("Please Don't Ask If I'm Dumb.");
                    continue;
                }
                else if (questionstring.IndexOf(" or ", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("I can't choose between the two");
                    synth.Speak("I can't choose between the two");
                    continue;
                }
                else if (questionstring.IndexOf(" it ", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please don't use it in your Question.");
                    synth.Speak("Please don't use it, in your Question.");
                    continue;
                }
                else if (questionstring.IndexOf("but", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No 'but's.");
                    synth.Speak("no buts");
                    continue;
                }
                #endregion
                //If Contains Spam
                #region
                else if (questionstring.IndexOf("aaa", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("bbb", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("ccc", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("ddd", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("eee", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("fff", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("ggg", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("hhh", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("iii", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("jjj", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("kkk", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("lll", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("mmm", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("nnn", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("ooo", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("ppp", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("qqq", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("rrr", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("sss", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("ttt", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("uuu", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("vvv", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("www", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("xxx", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("yyy", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("zzz", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ask A QUESTION. Not Spamming Characters.");
                    synth.Speak("Ask A QUESTION. Not Spamming Characters.");
                    continue;
                }
                else if (questionstring.IndexOf("asd", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("jk", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("kj", StringComparison.OrdinalIgnoreCase) >= 0 || questionstring.IndexOf("kl", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Why Must You Insist On Testing Me If I Can't Notice Your Character Spamming.");
                    synth.Speak("Why Must You Insist On Testing Me If I Can't Notice Your Character Spamming.");
                    continue;
                }
                //silly
                else if (questionstring.IndexOf("fart", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Why Is Fart In Your Sentence?");
                    synth.Speak("Why is fart in your sentence?.");
                    continue;
                }
                else if (questionstring.Contains(",") || questionstring.Contains("."))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I Don't Think You Need To Put A Comma Or Period In Your QUESTION.");
                    synth.Speak("I Don't Think You Need To Put A Comma Or Period In Your QUESTION.");
                    continue;
                }
                #endregion
                //If Doesn't Contain Punctuation
                #region
                else if (questionstring.Contains(" ") == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I Don't Recall Your Sentence Being A Question Given It Doesn't Have Any Spaces In It.");
                    synth.Speak("I Don't Recall Your Sentence Being A Question Given It Doesn't Have Any Spaces In It.");
                    continue;
                }
                else if (questionstring.Contains("1") || questionstring.Contains("2") || questionstring.Contains("3") || questionstring.Contains("4") || questionstring.Contains("5") || questionstring.Contains("6") || questionstring.Contains("7") || questionstring.Contains("8") || questionstring.Contains("9") || questionstring.Contains("0"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A Question Doesn't Need Numbers. Remove Them.");
                    synth.Speak("A Question Doesn't Need Numbers. Remove Them.");
                    continue;
                }
                else if (questionstring.Contains("?") == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Add A Question Mark At The End Of Your Question.");
                    synth.Speak("Please Add A Question Mark At The End Of Your Question.");
                    continue;
                }
                #endregion
                //Contain Will Should Is Did Does Could Or Would
                #region
                else if (questionstring.Contains("Will ") == false && questionstring.Contains("will ") == false && questionstring.Contains("Should ") == false && questionstring.Contains("should ") == false && questionstring.Contains("Is ") == false && questionstring.Contains("is ") == false && questionstring.Contains("Are ") == false && questionstring.Contains("are ") == false && questionstring.Contains("Did ") == false && questionstring.Contains("did ") == false && questionstring.Contains("Do ") == false && questionstring.Contains("do ") == false && questionstring.Contains("Would ") == false && questionstring.Contains("would ") == false && questionstring.Contains("Could ") == false && questionstring.Contains("could ") == false && questionstring.Contains("Does ") == false && questionstring.Contains("does ") == false && questionstring.Contains("Has ") == false && questionstring.Contains("has ") == false && questionstring.Contains("Can ") == false && questionstring.Contains("can ") == false && questionstring.Contains("Am ") == false && questionstring.Contains("am ") == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your Question Must Start With: Will, Should, Is, Did, Do, Could, Can, or Would. (Uppercase)");
                    synth.Speak("Your Question Must Start With: Will Should Is Did Do Could or Would. (Uppercase)");
                    continue;
                }
                #endregion
                //Not Same Question
                #region
                else if (questionstring == samequestion)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You just asked the same question.");
                    synth.Speak("You just asked the same question");
                }
                #endregion
                //If Passes and person actually asked a QUESTION lol, think think think.
                #region
                else
                {
                    aoqa += 1;
                    samequestion = questionstring;
                    Console.Clear();
                    int numberofsecondstosleep = ran.Next(4, 9);
                    int amountofwords = amountofspaces + 1;
                    string allocation = "Memorizing Index 0x";
                    for (int i = 0; i < ran.Next(3, 15) + 2; i++)
                    {
                        Console.Clear();
                        Console.Write("Resolving Your Question...\\ " + allocation ); Ranindexoffs(); Console.WriteLine(";");
                        Thread.Sleep(numberofsecondstosleep * 25);
                        Console.Clear();
                        Console.Title = "Processing '" + questionstring + "' At Index " + 2.ToString() + "^" + indexpow.ToString();

                        Console.Write("Resolving Your Question...| " + allocation); Ranindexoffs(); Console.WriteLine(";");
                        Thread.Sleep(numberofsecondstosleep * 25);
                        Console.Clear();


                        Console.Write("Resolving Your Question.../ " + allocation); Ranindexoffs(); Console.WriteLine(";");
                        Thread.Sleep(numberofsecondstosleep * 25);
                        Console.Clear();


                        Console.Write("Resolving Your Question...- " + allocation); Ranindexoffs(); Console.WriteLine(";");
                        Thread.Sleep(numberofsecondstosleep * 25);
                        Console.Clear();


                        Console.Write("Resolving Your Question...\\ " + allocation); Ranindexoffs(); Console.WriteLine(";");
                        Thread.Sleep(numberofsecondstosleep * 25);
                        Console.Clear();


                        Console.Write("Resolving Your Question...| " + allocation); Ranindexoffs(); Console.WriteLine(";");
                        Thread.Sleep(numberofsecondstosleep * 25);
                        Console.Clear();


                        Console.Write("Resolving Your Question.../ " + allocation); Ranindexoffs(); Console.WriteLine(";");
                        Thread.Sleep(numberofsecondstosleep * 25);
                        Console.Clear();


                        Console.Write("Resolving Your Question...- " + allocation); Ranindexoffs(); Console.WriteLine(";");
                        Thread.Sleep(numberofsecondstosleep * 25);
                        indexpow += 1;
                    }
                    //Detect If Xell Initialized Or Not
                    #region
                    Console.Write("Xell Reloaded = ");
                    if (xellloadedornot == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Enabled");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Static IP: ");
                        try
                        {
                            string publicip = new WebClient().DownloadString("http://icanhazip.com");
                            Console.Write(publicip);
                        }
                        catch
                        {
                            Console.WriteLine("failed");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Disabled");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    #endregion
                    Thread.Sleep(ran.Next(1000));
                    Console.WriteLine("Amount Of Words: " + amountofwords);
                    Thread.Sleep(ran.Next(1000));
                    Console.WriteLine("Amount Of Keys Typed: " + amountofkeystyped.ToString());
                    Thread.Sleep(ran.Next(1000));
                    indextotal += Math.Pow(2, indexpow);
                    Console.WriteLine("Index Process: " + Math.Pow(2, indexpow).ToString() + " (total: " + indextotal.ToString() + ")");
                    while (true)
                    {
                        if (questionstring.IndexOf(" you", StringComparison.OrdinalIgnoreCase) >= 0 == false && questionstring.IndexOf(" me", StringComparison.OrdinalIgnoreCase) >= 0 == false && questionstring.IndexOf(" i", StringComparison.OrdinalIgnoreCase) >= 0 == false && questionstring.IndexOf(" im ", StringComparison.OrdinalIgnoreCase) >= 0 == false)
                        {
                            break;
                        }
                        else if (questionstring.IndexOf(" i ", StringComparison.OrdinalIgnoreCase) >= 0 == true || questionstring.IndexOf(" me ", StringComparison.OrdinalIgnoreCase) >= 0 == true || questionstring.IndexOf(" im ", StringComparison.OrdinalIgnoreCase) >= 0 == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Thread.Sleep(299);
                            Console.WriteLine("Question About You");
                        }
                        if (questionstring.IndexOf(" you", StringComparison.OrdinalIgnoreCase) >= 0 == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Thread.Sleep(299);
                            Console.WriteLine("Question About Me");
                            break;
                        }
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    // PERFORMANCE COUNTER
                    #region
                    PerformanceCounter perfCpuCount = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
                    PerformanceCounter perfMemCount = new PerformanceCounter("Memory", "Available MBytes");
                    PerformanceCounter perfUpTimeCount = new PerformanceCounter("System", "System Up Time");
                    #endregion
                    Thread.Sleep(ran.Next(1000));
                    Console.WriteLine("Processing Load: {0}%", perfCpuCount.NextValue());
                    Thread.Sleep(ran.Next(1000));
                    Console.WriteLine("Memory Load: {0}%", perfCpuCount.NextValue());
                    Thread.Sleep(ran.Next(1000));
                    Console.WriteLine("Amount of questions asked: " + aoqa);
                    Thread.Sleep(ran.Next(500, 2000));
                    Console.WriteLine("");
                    if (questionstringlength >= 20 && questionstringlength <= 30)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("'" + questionstring + "'");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(" Length = " + questionstringlength);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(" Perfect");
                        Console.ForegroundColor = ConsoleColor.White; ;
                    }
                    else if (questionstringlength <= 19 || questionstringlength >= 31 == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("'" + questionstring + "'");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(" Length = " + questionstringlength);
                        Console.WriteLine(" Ok");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Thread.Sleep(799);
                    synth.Speak(questionstring);
                    Yesorno();
                }
                #endregion
            }
            //Cleaning up
            Console.ForegroundColor = oldColor;
        }
        static void CountValueOfWord()
        {
            ConsoleColor cc = Console.ForegroundColor;
            while (true)
            {
                Console.WriteLine("");
                Console.Write("Type Your Word (or <back>): ");
                char[] Word = Console.ReadLine().ToCharArray();
                Console.Clear();
                int v = 0;
                int y = 0;
                int sx = 0;
                int l = Word.Length;
                long pn = 1;
                int pnsum = 0;
                string s = "Symmetric";
                if (Word.Length % 2 != 0)
                {
                    s = "Asymmetric";
                }
                for(int i = 0; i < Word.Length; i++)
                {
                    v += Word[i];
                }
                for (int i = 0; i < Word.Length; i++)
                {
                    y ^= Word[i];
                    sx += y;
                }
                for (int i = 0; i < Word.Length; i++)
                {
                    pn *= Word[i];
                }
                for (int i = 0; i < pn.ToString().Length; i++)
                {
                    pnsum += pn.ToString()[i] - 48;
                }
                if (v < 1)
                {
                    OperatingOnAskQuestion();
                }
                else
                {
                    Console.WriteLine("Sum: " + v + " Len: " + l + " Symmetry: " + s);
                    Console.WriteLine("XOR: " + y + " XSum: " + sx + " Mod: " + (sx % y));
                    Console.WriteLine("Product: " + pn + " PSum: " + pnsum + " Mod: " + (pn % pnsum));
                }
            }
        }
        static void Xellreloaded()
        {
            //Xell Reloaded
            string[] hexarray = "a|b|c|d|e|f".Split('|');
            string[] numarray = "0|1|2|3|4|5|6|7|8|9".Split('|');
            string[] CAPchararray = "A|B|C|D|E|F|G|H|I|J|K|L|M|N|O|P|Q|R|S|T|U|V|W|X|Y|Z".Split('|');
            Random ran = new Random();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("* Xenos FB with 148x41 (1280x720) at 0x9e000000 initialized.");
            Console.WriteLine("Xell - Xenon linux loader second stage v0.993-git-7466b6d 2013-08-27 (LibXenon.org)");
            Thread.Sleep(ran.Next(1000));
            Console.WriteLine("");
            Console.WriteLine("9ball.org XeLL - Xenon Linux Loader v0.993-git-7466b6d");
            Console.WriteLine("Windows Magic 9 Ball - Express");
            Thread.Sleep(ran.Next(1000, 4000));
            Console.WriteLine("");
            Console.WriteLine(" * nand init");
            Console.WriteLine(" * network init");
            Console.WriteLine(" * initializing lwip 1.4.0");
            Console.WriteLine("Reinit PHY...");
            Console.Write("Waiting for link...");
            Thread.Sleep(3000);
            Console.WriteLine("link still down.");
            //DHCP
            Console.Write(" * requesting dhcp...");
            #region
            System.Net.NetworkInformation.Ping pingSender = new System.Net.NetworkInformation.Ping();
            System.Net.NetworkInformation.PingReply reply = pingSender.Send("google.com");
            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(400);
                }
                Console.WriteLine("success");
            }
            else
            {
                for (int i = 0; i < 30; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(400);
                }
                Console.WriteLine("failed");
            }
        #endregion
       
            Console.Write(" * now assigning a static ip-");
            //GetIP
            #region
            try
            {
                string publicip = new WebClient().DownloadString("http://icanhazip.com");
                Console.WriteLine(publicip);
            }
            catch
            {
                Console.WriteLine("failed");
            }
            #endregion
            Console.WriteLine(" * starting https server...success");
            Console.WriteLine(" * usb init");
            Console.WriteLine(" * Initialising USB EHCI...");
            Console.WriteLine("Initialising EHCI bus 0 at 0xea003000");
            Thread.Sleep(700);
            Console.WriteLine("Initialising EHCI bus 1 at 0xea005000");
            Thread.Sleep(600);
            Console.WriteLine("EHCI bus 1 port 1: low speed, releasing to OHCI");
            Thread.Sleep(650);
            Console.WriteLine(" * Initialising USB OHCI...");
            Console.WriteLine("USB bus 0 device 1: vendor 0000 product 0000 class 09: USB Hub");
            Console.WriteLine("USB bus 1 device 1: vendor 0000 product 0000 class 09: USB Hub");
            Console.WriteLine("USB: New 9ball blugin to bus 1 hub 1 port 1");
            Thread.Sleep(300);
            Console.WriteLine("USB bus 1 device 2: vendor 045E product 02AA class FF: Chipset Drivers");
            Console.WriteLine("EHCI bus 1 device 3: vendor 8107 product 5151 class FF: Mass Storage Device");
            Thread.Sleep(250);
            Console.WriteLine(" * sata hdd init");
            Thread.Sleep(2800);
            //Serial
            #region
            string serial = null;
            for (int i = 0; i < 20; i++)
            {
                switch (ran.Next(2))
                {
                    case 0:
                        {
                            serial += ran.Next(10).ToString();
                            break;
                        }
                    case 1:
                        {

                            char character = Convert.ToChar(ran.Next(65, 91));
                            serial += character;

                            //serial += chararray[ran.Next(chararray.Length)].ToString();
                            break;
                        }
                }
            }
            #endregion
            Console.WriteLine("  * Serial: " + serial);
            //Firmware
            #region
            string firmware = null;
            for (int i = 0; i < 8; i++)
            {
                switch (ran.Next(2))
                {
                    case 0:
                        {
                            firmware += ran.Next(10).ToString();
                            break;
                        }
                    case 1:
                        {
                            char character = Convert.ToChar(ran.Next(65, 91));
                            firmware += character;
                            break;
                        }
                }
            }
            #endregion
            Console.WriteLine("  * Firmware: " + firmware);
            //Model
            #region
            string model = null;
            for (int i = 0; i < 15; i++)
            {
                switch (ran.Next(2))
                {
                    case 0:
                        {
                            model += ran.Next(10).ToString();
                            break;
                        }
                    case 1:
                        {
                            char character = Convert.ToChar(ran.Next(65, 91));
                            model += character;
                            break;
                        }
                }
            }
            #endregion
            Console.WriteLine("  * Model: Hitachi " + model);
            Console.WriteLine("  * Addressing mode: 2");
            Console.WriteLine("  * #cylinders: " + ran.Next(1, 5).ToString());
            //Heads
            #region
            string[] heads = "8|16|32".Split('|');
            #endregion
            Console.WriteLine("  * #heads: " + heads[ran.Next(heads.Length)].ToString());
            Console.WriteLine("  * #sectors: " + ran.Next(1, 10) + ran.Next(10) + ran.Next(10) + ran.Next(10) + ran.Next(10) + ran.Next(10) + ran.Next(10) + ran.Next(10) + ran.Next(10));
            Console.WriteLine("SATA device at ea001300");
            Console.WriteLine(" * sata dvd init");
            Thread.Sleep(ran.Next(300, 500));
            Console.WriteLine("ATAPI inquiry model: PLDS    DG-16D5S");
            Thread.Sleep(400);
            Console.WriteLine("SATA device at ea001200");
            Console.WriteLine("fat Mount AHCI Mode Sata");
            Thread.Sleep(100);
            //FindDrives
            #region
            string[] drives = System.IO.Directory.GetLogicalDrives();
            foreach (string str in drives)
            {
                System.Console.WriteLine("Found: " + str);
            }
            #endregion
            Console.WriteLine(" * CPU PVR: 00710800");
            Console.WriteLine(" * FUSES");
            Thread.Sleep(50);
            //fuseset 00
            #region
            Console.WriteLine("fuseset 00: " + hexarray[ran.Next(hexarray.Length)] + "0" + "ffffffffffffff");
            #endregion
            Thread.Sleep(20);
            //fuseset 01
            Console.WriteLine("fuseset 01: 0f0f0f0f0f0ff0f0");
            Thread.Sleep(20);
            //fuseset 02
            #region
            string[] fuseset02 = "f000000000000000|0f00000000000000|00f0000000000000|000f000000000000|0000f00000000000|00000f0000000000|000000f000000000|0000000f00000000|00000000f0000000|000000000f000000|0000000000f00000|00000000000f0000|000000000000f000|0000000000000f00|00000000000000f0|000000000000000f".Split('|');
            Console.WriteLine("fuseset 02: " + fuseset02[ran.Next(fuseset02.Length)]);
            #endregion
            Thread.Sleep(20);
            //fuseset 03
            #region
            string fuseset03 = null;
            for (int i = 0; i < 16; i++)
            {
                switch (ran.Next(2))
                {
                    case 0:
                        {
                            fuseset03 += hexarray[ran.Next(hexarray.Length)];
                            break;
                        }
                    case 1:
                        {
                            fuseset03 += numarray[ran.Next(numarray.Length)];
                            break;
                        }
                }
            }
            Console.WriteLine("fuseset 03: " + fuseset03);
            #endregion
            Thread.Sleep(20);
            //fuseset 04
            Console.WriteLine("fuseset 04: " + fuseset03);
            //fuseset 05
            #region
            string fuseset05 = null;
            for (int i = 0; i < 16; i++)
            {
                switch (ran.Next(2))
                {
                    case 0:
                        {
                            fuseset05 += hexarray[ran.Next(hexarray.Length)];
                            break;
                        }
                    case 1:
                        {
                            fuseset05 += numarray[ran.Next(numarray.Length)];
                            break;
                        }
                }
            }
            Console.WriteLine("fuseset 05: " + fuseset05);
            #endregion
            //fuseset 06
            Console.WriteLine("fuseset 06: " + fuseset05);
            //fuseset 07
            Console.WriteLine("fuseset 07: ffff000000000000");
            //fusesets 08 - 11
            #region
            string fuseset08 = "0000000000000000";
            int fusesetnum = 08;
            for (int i = 0; i < 4; i++)
            {
                if (fusesetnum > 9 == false)
                {
                    Console.WriteLine("fuseset 0" + fusesetnum + ": " + fuseset08);
                }
                else
                {
                    Console.WriteLine("fuseset " + fusesetnum + ": " + fuseset08);
                }
                fusesetnum++;
                Thread.Sleep(20);
            }
            #endregion
            Console.WriteLine("");
            //CPUKEY && DVD KEY
            #region
            string cpukey = null;
            string dvdkey = "1";
            for (int i = 0; i < 32; i++)
            {
                switch (ran.Next(2))
                {
                    case 0:
                        {
                            cpukey += CAPchararray[ran.Next(CAPchararray.Length)];
                            break;
                        }
                    case 1:
                        {
                            cpukey += numarray[ran.Next(numarray.Length)];
                            break;
                        }
                }
            }
            Console.WriteLine(" * your cpu key: " + cpukey);
            for (int i = 0; i < 31; i++)
            {
                if (dvdkey.Length <= 5)
                {
                    switch (ran.Next(2))
                    {
                        case 0:
                            {
                                dvdkey += CAPchararray[ran.Next(CAPchararray.Length)];
                                break;
                            }
                        case 1:
                            {
                                dvdkey += numarray[ran.Next(numarray.Length)];
                                break;
                            }
                    }
                }
                else if (dvdkey.Length < 10)
                {
                    dvdkey += "0";
                }
                else
                {
                    switch (ran.Next(2))
                    {
                        case 0:
                            {
                                dvdkey += CAPchararray[ran.Next(CAPchararray.Length)];
                                break;
                            }
                        case 1:
                            {
                                dvdkey += numarray[ran.Next(numarray.Length)];
                                break;
                            }
                    }
                }
            }
            Console.WriteLine(" * your dvd key: " + dvdkey);
            #endregion
            Thread.Sleep(ran.Next(100, 200));
            Console.WriteLine("");
            //Network Config
            #region
            Console.Write(" * network config: ");
            Thread.Sleep(300);
            //Get Gateway
            foreach (NetworkInterface f in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (f.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (GatewayIPAddressInformation d in f.GetIPProperties().GatewayAddresses)
                    {
                        if (d.Address.ToString() == "0.0.0.0")
                        {

                        }
                        else
                        {
                            Console.Write(d.Address.ToString());
                        }
                        
                    }
                } 
            }
            Console.Write(" / ");
            Thread.Sleep(300);
            //Get Subnet
            NetworkInterface[] Interfaces = NetworkInterface.GetAllNetworkInterfaces();
            int stopper = 0;
            foreach (NetworkInterface Interface in Interfaces)
            {
                if (Interface.NetworkInterfaceType == NetworkInterfaceType.Loopback) continue;
                {
                    UnicastIPAddressInformationCollection UnicastIPInfoCol = Interface.GetIPProperties().UnicastAddresses;
                    foreach (UnicastIPAddressInformation UnicatIPInfo in UnicastIPInfoCol)
                    {
                        if (UnicatIPInfo.IPv4Mask.ToString() == "0.0.0.0")
                        {
                            Console.Write("");
                        }
                        else if (stopper == 0)
                        {
                            Console.Write(UnicatIPInfo.IPv4Mask);
                            stopper++;
                        }
                        
                    }
                }
            }
            Thread.Sleep(300);
            //Get MAC
            Console.WriteLine("");
            Console.Write("              MAC: ");
            int stopper1 = 0;
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty && stopper1 == 0)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    Console.WriteLine(adapter.GetPhysicalAddress().ToString());
                    stopper1++;
                }
            }

            #endregion
            Thread.Sleep(200);
            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine(" * Looking for files on local media and TFTP...");
            Thread.Sleep(ran.Next(200, 1000));
            Console.WriteLine("");
            //Trying To Find MAGIC 8 BALL FILE
            #region
            for (int i = 0; i < ran.Next(2, 4); i++)
            {
                foreach (string str in drives)
                {
                    System.Console.WriteLine("Trying " + str + "magic9ball.exe...");
                    Thread.Sleep(333);
                }
            }
            Console.WriteLine(" * '" + drives[ran.Next(drives.Length)] + "magic9ball.exe' found, Loading " + ran.Next(1000000, 10000000).ToString() + "...");
            Thread.Sleep(ran.Next(300));
            Console.WriteLine(" * Launching ELF...");
            Thread.Sleep(ran.Next(300));
            Console.WriteLine(" * Device tree prepared");
            Thread.Sleep(ran.Next(300));
            Console.WriteLine(" * Executing...");
            Thread.Sleep(ran.Next(2000, 5000));
            Console.WriteLine("");
            #endregion
            xellloadedornot = 1;
        }
        static void wouldyourather()
        {
            Random ran = new Random();
            //Console.WindowWidth = 150;
            //Console.WindowHeight = 25;
            ConsoleColor oldColor = Console.ForegroundColor;
            string[] choice1 = { "Eat 5 Live Spiders", "Loose A Random Amount Of Money Between $0 - $100", "Drink A Hershey's Syrup Bottle", "Loose 1/15 Of All Your Knowledge", "Have Your Ear Taped To An Industrial Fire Alarm, And Not Know When It Will Go Off", "Have A Snake Bite You", "Jump Off Niagra Falls Into The Water", "Eat All The Hair Off Your Best Friend", "Loose All Your Steam Games", "Crunch 5 RANDOM Pills", "Have Horrible Diherea During Band Performance", "Kill a bird", "Eat a guinea pig bean", "Play hot potatoe dynamite with a robot" };
            string[] choice2 = { "Gamble $30", "Eat Someone Else's Booger", "Risk A 1/3 Chance Dieing In Sleep Tonight", "Loose Your 2nd Best Friend", "Kiss A Guinea Pig On The Lips Really Hard", "Go To Jail For 24 Hours", "Have A Tarantula Bite You", "Eat 10 Small Bugs", "1/3 Tablespoon Of Fatman Poop", "Spin Your Finger Around Your Worst Enemie's Toilet Seat Then Lick It Very Fat", "Be Duck-Taped In A Cacoon Strung From A Tree For 24 Hours", "Lick In Between Hillaries Feet", "Slide Your Tongue Down A Dysneland Gaurd Rail", "Eat all the burnt hair on your legs" };
            while (true)
            {
                //Editable Vars
                int ranpick = ran.Next(choice1.Length);
                int ranpick2 = ran.Next(choice2.Length);
                try
                {
                    string choice_1 = choice1[ranpick];
                    string choice_2 = choice2[ranpick2];

                    choice1 = choice1.Where((source, index) => index != ranpick).ToArray();
                    choice2 = choice2.Where((source, index) => index != ranpick2).ToArray();
                    //Then Write
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("");
                    Console.WriteLine("Press Any Key For Would You Rather! (type 'exit' to quit)");
                    Console.Write(": ");
                    Console.ReadKey();
                    Console.WriteLine(""); Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Would you rather: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("(A) ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(choice_1);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(" or ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("(B) ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(choice_2 + "?");
                    Console.ForegroundColor = oldColor;
                    string whattheychose = Console.ReadLine();

                    if (whattheychose.ToLower() == "exit" == true)
                    {
                        OperatingOnAskQuestion();
                    }
                    else if (whattheychose.ToLower() == "a" == false && whattheychose.ToLower() == "b" == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Need To Type A or B.");
                        Console.ForegroundColor = oldColor;
                        continue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Okay! Hope That's A Wise Decision");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        continue;
                    }
                    Console.ForegroundColor = oldColor;
                }
                catch
                {
                    Console.WriteLine("Thanks For Playing!!");
                    OperatingOnAskQuestion();
                }
            }
        }
        static void Ranindexoffs()
        {
            Random ran = new Random();

            int appendhexorint = ran.Next(0, 2);
            string allocater = null;

            for (int j = 0; j < ran.Next(6, 9); j++)
            {
                if (appendhexorint == 0)
                {
                    allocater += Convert.ToChar(ran.Next(65, 71));
                }
                else
                {
                    allocater += Convert.ToChar(ran.Next(48, 58));
                }
            }
            Console.Write(allocater);
        }
        static void Yesorno()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            Random ran = new Random();
            string ran1 = Convert.ToChar(65).ToString();
            string ran2 = Convert.ToChar(ran.Next(65, 72)).ToString();
            if (ran1 == "A")
            {
                if (ran2 == "A")//65 OMG YES
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("YES!");
                    synth.Speak("yes!");
                }
                else if (ran2 == "B")//66 Yes
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Yes");
                    synth.Speak("yes");
                }
                else if (ran2 == "C")//67 Likely
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Likely");
                    synth.Speak("likely");
                }
                else if (ran2 == "D")//68 Failed
                {
                    Console.Beep(1000, 1);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Operation Failed");
                    synth.Speak("Operation Failed");
                }
                else if (ran2 == "E")//69 Unlikely
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Unlikely");
                    synth.Speak("unlikely");
                }
                else if (ran2 == "F")//70 No
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No");
                    synth.Speak("no");
                }
                else// OMG NO
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("NO!");
                    synth.Speak("no!");
                }
            }
            else
            {
                
            }
        }
        static void Drunkmouse()
        {
            Random ran = new Random();
            int moveX = 0;
            int moveY = 0;
            for (int i = 0; i < 1000; i++)
            {
                // Generate the random amount to move the cursor on X and Y
                moveX = ran.Next(40) - 20;
                moveY = ran.Next(40) - 20;

                // Change mouse cursor position to new random coordinates
                Cursor.Position = new System.Drawing.Point(
                    Cursor.Position.X + moveX,
                    Cursor.Position.X + moveY);

                Console.WriteLine(Cursor.Position.ToString());
                Thread.Sleep(ran.Next(25, 75));
            }
        }
        static void Drunkkeyboard()
        {
            Random ran = new Random();
            for (int i = 0; i < 1000; i++)
            {
                char key = (char)(ran.Next(48, 96));

                SendKeys.SendWait(key.ToString());

                Thread.Sleep(ran.Next(25, 75));
            }
        }
        static void Drunksound()
        {
            Random ran = new Random();
            for (int i = 0; i < 100; i++)
            {
                switch (ran.Next(5))
                {
                    case 0:
                        {
                            SystemSounds.Asterisk.Play();
                            break;
                        }
                    case 1:
                        {
                            SystemSounds.Beep.Play();
                            break;
                        }
                    case 2:
                        {
                            SystemSounds.Exclamation.Play();
                            break;
                        }
                    case 3:
                        {
                            SystemSounds.Hand.Play();
                            break;
                        }
                    case 4:
                        {
                            SystemSounds.Question.Play();
                            break;
                        }
                }
                Thread.Sleep(ran.Next(250, 750));
            }
        }
        static void Mariosong()
        {
            Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125);
            Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125);
            Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125);
            Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375);
            Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125);
            Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250);
            Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125);
            Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42);
            Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125);
            Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125);
            Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125);
            Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125);
            Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125);
            Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125);
            Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125);
            Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250);
            Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125);
            Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125);
            Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125);
            Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125);
            Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125);
            Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125);
            Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125);
            Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125);
            Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125);
            Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125);
            Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125);
            Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167);
            Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125);
            Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125);
            Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125);
            Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42);
            Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125);
            Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125);
            Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625);
            Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125);
            Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125);
            Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125);
            Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125);
            Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125);
            Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250);
            Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
            Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125);
            Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125);
            Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167);
            Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125);
            Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125);
            Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125);
            Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42);
            Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125);
            Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125);
            Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625);
            Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125);
            Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125);
            Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125);
            Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125);
            Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125);
            Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250);
            Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
        }
        static void Ping()
        {
            //Rejoice always, 17 pray continually, 18 give thanks in all circumstances
            SpeechSynthesizer synth = new SpeechSynthesizer();
            Console.Write("Pinging ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(ip + Environment.NewLine);
            try
            {
                double amount = 0;
                while (true)
                {
                    Ping pinger = new Ping();
                    PingReply reply = pinger.Send(ip);
                    if (reply.RoundtripTime < 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Reply: " + reply.Address + ", Time: " + reply.RoundtripTime + ", Sent: " + sent + ", Avg: " + amount + "/" + sent + " = " + (double)(amount / sent));
                        amount += reply.RoundtripTime;
                    }
                    else if (reply.RoundtripTime == 4 || reply.RoundtripTime == 5 || reply.RoundtripTime == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Reply: " + reply.Address + ", Time: " + reply.RoundtripTime + ", Sent: " + sent + ", Avg: " + amount + "/" + sent + " = " + (double)(amount / sent));
                        amount += reply.RoundtripTime;
                    }
                    else if (reply.RoundtripTime == 7 || reply.RoundtripTime == 8 || reply.RoundtripTime == 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Reply: " + reply.Address + ", Time: " + reply.RoundtripTime + ", Sent: " + sent + ", Avg: " + amount + "/" + sent + " = " + (double)(amount / sent));
                        amount += reply.RoundtripTime;
                    }
                    else if (reply.RoundtripTime == 10 || reply.RoundtripTime == 11 || reply.RoundtripTime == 12)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Reply: " + reply.Address + ", Time: " + reply.RoundtripTime + ", Sent: " + sent + ", Avg: " + amount + "/" + sent + " = " + (double)(amount / sent));
                        amount += reply.RoundtripTime;
                    }
                    else if (reply.RoundtripTime == 13 || reply.RoundtripTime == 14 || reply.RoundtripTime == 15)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Reply: " + reply.Address + ", Time: " + reply.RoundtripTime + ", Sent: " + sent + ", Avg: " + amount + "/" + sent + " = " + (double)(amount / sent));
                        amount += reply.RoundtripTime;
                    }
                    else if (reply.RoundtripTime > 15)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Reply: " + reply.Address + ", Time: " + reply.RoundtripTime + ", Sent: " + sent + ", Avg: " + amount + "/" + sent + " = " + (double)(amount / sent));
                        amount += reply.RoundtripTime;
                    }
                    sent += 1;
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(100);
                }
            }
            catch
            {
                Console.WriteLine("Ping Stopped.. (You exited or the IP is invalid)");
            }
        }
        static void Free()

        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            while (true)
            {
                Console.Write("Enter What I Should Say: ");
                string say = Console.ReadLine();
                if (say == "")
                {
                    return;
                    
                }
                synth.Speak(say);
            }
        }
        static void WordUnscrambler()
        {
            Random ran = new Random();
            while (true)
            {
                string input = Console.ReadLine();
                input.ToCharArray();
                Console.Clear();
                Console.WriteLine("Processing " + Math.Pow(input.Length, 4));
                for (int j = 0; j < Math.Pow(input.Length, 3); j++)
                {
                    int failed = 0;
                    string returner = "";
                    foreach (char i in input)
                    {
                        string mayreturn = input[ran.Next(input.Length)].ToString();
                        if (returner.Contains(mayreturn) == false)
                        {
                            returner += mayreturn;
                        }
                        else if (returner.Contains(mayreturn) == true)
                        {
                            failed++;
                        }
                    }
                    if (failed == 0)
                    {
                        Console.WriteLine(returner);
                    }
                }
            }
        }
    }
}