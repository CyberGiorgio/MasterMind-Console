using masterMind;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace masterMind
{
    public static class InputTerminal 
    {
        public static bool Try { get; private set; }
        static public bool TryAgain()                                      //end of game, press "y" to restart
        {
            Console.WriteLine("Would you like to play again? Press 'Y' or any other button to exit");
            Try = Console.ReadKey().Key == ConsoleKey.Y;    
            if (Try == true)
            {
                return true;
            }
            else
            {
                return false;                                   //if !"Y" stop the program
            }
        }
        static public int[] InputCodeBreak()                                //input code
        {
        int[] code;
        bool isAnInt;
            code = new int [4];                                 //array of 4 numbers                   
            for (int i = 0; i < code.Length; i++)
            {
                do
                {
                    isAnInt = false;
                    try
                    {
                        code[i] = Convert.ToInt32(Console.ReadLine());      //read string and convert into int
                        if (code[i] > 8 || code[i] < 1)         // must be a number between 1 and 8
                        {
                            Debug.WriteLine("Input was not an integer between 1 and 8");
                            Console.WriteLine("Input not valid, type a number between 1 and 8");
                            isAnInt = true;
                        }
                    }
                    catch (FormatException)                     // must be a number between 1 and 8
                    {
                        Debug.WriteLine("Input was a different format");
                        Console.WriteLine("Input not valid, it must be an integer between 1 and 8");
                        isAnInt = true;
                    }
                } while (isAnInt == true);              //repeat until isAnInt = false
            }
            return code;
        }
        static public int[] InputCodeMaster()                                //input code
        {
            int[] code;
            bool isAnInt;
            code = new int[4];                                 //array of 4 numbers                   
            for (int i = 0; i < code.Length; i++)
            {
                do
                {
                    isAnInt = false;
                    try
                    {
                        code[i] = Convert.ToInt32(Console.ReadLine());      //read string and convert into int
                        Console.SetCursorPosition(Console.CursorLeft,Console.CursorTop - 1);      //hide the number typed by codeMaster                                           //levelDifficult false, keep looping and clear the previous choice

                        if (code[i] > 8 || code[i] < 1)         // must be a number between 1 and 8
                        {
                            Debug.WriteLine("Input was not an integer between 1 and 8");
                            Console.WriteLine("Input not valid, type a number between 1 and 8");
                            isAnInt = true;
                        }
                    }
                    catch (FormatException)                     // must be a number between 1 and 8
                    {
                        Debug.WriteLine("Input was a different format");
                        Console.WriteLine("Input not valid, it must be an integer between 1 and 8");
                        isAnInt = true;
                    }
                } while (isAnInt == true);              //repeat until isAnInt = false
                Console.WriteLine("Element n " + (i + 1) + " stored");
            }
            return code;
        }
        static public int[] RandomCode()
        {
           Random rnd;
           int[] codeMast;
           codeMast = new int[4];
            for (int i = 0; i < 4; i++)                           // random secret code of 4 numbers between 1 and 8                                 
            {
                rnd = new Random();
                codeMast[i] = rnd.Next(1, 8);
                // random numbers from 1 to 8
            }
            return codeMast;
        }
        public static int Level()
        {
            int rows = 0;
            bool levelDifficult;
            do
            {
                Console.WriteLine("Choose a level: type 1, 2 or 3" +
                    "\n   1 for 10 attempts, " +
                    "\n   2 for 8 attempts, " +
                    "\n   3 for 6 attempts");
                //Read key from keyboard
                ConsoleKeyInfo keyReaded2 = Console.ReadKey();
                switch (keyReaded2.Key)
                {
                    case ConsoleKey.D1:                              //if you press 1 = 10 attempts/ rows
                        rows = 10;
                        levelDifficult = true;
                        break;
                    case ConsoleKey.D2:                             //if you press 2 = 8 attempts/ rows
                        rows = 8;
                        levelDifficult = true;
                        //end of loop
                        break;
                    case ConsoleKey.D3:                             //if you press 3 = 6 attempts/ rows
                        rows = 6;
                        levelDifficult = true;
                        break;
                    default:
                        Debug.WriteLine("Input was not an integer between 1 and 3");
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);              //levelDifficult false, keep looping and clear the previous choice
                        Console.WriteLine("\bThis is not a valid number, 1, 2 or 3?");
                        levelDifficult = false;
                        break;
                }
            } while (levelDifficult == false);
            Console.WriteLine("");
            return rows;
        }
        static public void Menu()                                      //loop intro and rules
        {
            string intro;
            intro ="Welcome in 2020, this is the new MasterMind 2.0, are you ready to play? \npress 'Enter' to start, or press 'any other button' for rules and guidelines";
            Console.WriteLine(intro);
            while (Console.ReadKey().Key != ConsoleKey.Enter)       //if press a key different than Enter, show rules and description
            {
                       Console.WriteLine("\nMastermind is a code-breaking game invented in 1970 by a postmaster and telecommunication expert name “Mordecai Meirowitz”. " +
                       "\nThis is a game for 2 players: codeBreaker(player1) and codeMaster(player2 or COM)." +
                       "\n" +
                       "\nThe code maker will chooses a pattern of four Secret Numbers." +
                       "\nDuplicates are allowed which means that four pegs with the same number are allowed." +
                       "\nThe codebreaker needs to guess the pattern, numbers and positions within 10, 8 or 6 turns" +
                       "\nEach time the codebreaker will try to guess the pattern," +
                       "\nthe codeMaster will provides feedback placing from zero to four “key pegs”" +
                       "\nA white key peg for a correct number in a wrong position, and a red peg for a correct number in correct position." +
                       "\nThe game will ends up when the codebreaker will guess the entire pattern or " +
                       "\nthe attempts(depending the level chosen: easy, medium, hard) will run out." +
                       "\nPlaying time will be displayed at the end of the game." +
                       "\n" +
                       "\nPress 'any button' to get back");
                Console.ReadKey();                  // press any button get back
                
                Console.Clear();                    // clear screen
                Console.WriteLine(intro);           // intro message
            }
        }
        public static void ConfigurePlayer(masterMind.Player codeBreakPlayer, masterMind.Player codeMastPlayer) // configure type of players
        {
            bool nameCodeBreak;
            string nameCodeBr;
            bool nameCodeMast;
            string nameCodeMst;
            if (codeMastPlayer.GetType() == typeof(masterMind.CodeMastCOMPlayer))           //case of codeBreaker VS COM
            {
                do {
                    nameCodeBreak = true;
                    Console.WriteLine("\nWhat is your name?");
                    nameCodeBr = Console.ReadLine();
                    if (nameCodeBr == "")
                    {
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                        Debug.WriteLine("Input was an empty string");//name cannot be empty string
                        Console.Write("\bEmpty name not valid");
                        nameCodeBreak = false;
                    }
                } while (nameCodeBreak == false);
                codeBreakPlayer.SetName(nameCodeBr);                             //codeBreaker name
                codeMastPlayer.SetName("COM");                                            //codeMaster COM name
                Console.WriteLine("Hi {0}, get ready to play versus {1}", codeBreakPlayer.GetName(), codeMastPlayer.GetName());

                Console.WriteLine("CodeMaster will create a secret code of 4 numbers between 1 and 8");
                codeMastPlayer.SetCode(RandomCode());                //Generate Random secret code
                //codeMastPlayer.Print();                          //show the secret code, must be removed to play
            }
            else                                                              //Multiplayer Human 1 VS 1
            {
                Console.WriteLine("\nType the name of the codeMaster");
                do
                {
                    nameCodeMast = true;
                    nameCodeMst = Console.ReadLine();
                    if (nameCodeMst == "")
                    {
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);                 //name cannot be empty string
                        Debug.WriteLine("Input was an empty string");
                        Console.WriteLine("\bEmpty name not valid");
                        nameCodeMast = false;
                    }
                } while (nameCodeMast == false);
                codeMastPlayer.SetName(nameCodeMst);                      // codeMaster name
                Console.WriteLine("\nType the name of the codeBreaker");
                do
                {
                    nameCodeBreak = true;
                    nameCodeBr = Console.ReadLine();
                    if (nameCodeBr == "")
                    {
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                        Debug.WriteLine("Input was an empty string");
                        Console.WriteLine("\bEmpty name not valid");
                        nameCodeBreak = false;
                    }
                } while (nameCodeBreak == false);
                codeBreakPlayer.SetName(nameCodeBr);             // codeBreaker name 
                Console.WriteLine("Hi {0} and {1}, get ready to play with me", codeBreakPlayer.GetName(), codeMastPlayer.GetName());

                Console.WriteLine("CodeMaster, type your secret code of 4 numbers (one by one pressing enter) between 1 and 8");
                codeMastPlayer.SetCode(InputTerminal.InputCodeMaster());                // codeMaster will create code to break 
            }
        }
    }
}
