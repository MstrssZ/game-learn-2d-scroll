using System;
using System.Runtime.CompilerServices;

namespace Text_Adventure
{
    class Program
    {
        // vars for character info display
        public static int Character_HP_Current { get; set; }
        public static int Character_HP_Full { get; set; }
        public static int Character_EXP_Current { get; set; }
        public static int Character_EXP_Full { get; set; }
        public static int Character_LVL { get; set; }
 
        public static string Character_Name { get; set; }


        static void Main(string[] args)
        {
            Console.Title = "Text Adventure 0.0";
            Console.WriteLine("Welcome to Text Adventure 0.0");
            Console.WriteLine("Press a key to continue");

            Console.ReadKey(true);
            Console.Clear();

            Console.Write
                (
                "You awake to find yourself in an empty room without and noticable way for you to have entered\n" +
                "Upon trying to remember how you got here a sharp throb in you spine causes you to ...\n" +
                "...\n" +
                "....\n" +
                "...\n" +
                "...\n" +
                "expo\n"
                );
            Console.ReadKey(true);
            Console.Clear();

            Console.Write("What would you like to do?\n" +
                "1. Play\n" +
                "2. Options (not implemented yet)\n" +
                "3. Credits\n" +
                "4. Exit\n");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    GameStart();
                    break;

                case ConsoleKey.D2:
                    break;

                case ConsoleKey.D3:
                    Credits.Begin();
                    break;

                case ConsoleKey.D4:
                    break;

                default:
                    Console.WriteLine("not 1");
                    break;
            }
        }
        public static void GameStart() //draws GUI character info display an enters game loop
        {
            Console.Clear();
            
            //intitalize vars for character info display
            Character_HP_Current = 20;
            Character_HP_Full = 100;
            Character_EXP_Current = 10;
            Character_EXP_Full = 50;
            Character_LVL = 1;
            Character_Name = "name of character";



            for (int i = 0; i < 79; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("~");
                Console.SetCursorPosition(i, 2);
                Console.WriteLine("~");
            }
            //draw name
            Console.SetCursorPosition(0, 1);
            Console.WriteLine(Character_Name);

            //draw HP
            Console.SetCursorPosition(25, 1);
            Console.WriteLine("HP: {0}/{1}", Character_HP_Current, Character_HP_Full);

            //draw EXP
            Console.SetCursorPosition(40, 1);
            Console.WriteLine("EXP: {0}/{1}", Character_EXP_Current, Character_EXP_Full);

            //draw LVL
            Console.SetCursorPosition(60, 1);
            Console.WriteLine("LVL: {0}", Character_LVL);

            //move cursor to top left
            Console.SetCursorPosition(0, 0);

            //start game loop
            GameLoop();

        }
        static void GameLoop()
        {
            int Character_Pos_LR = 10;
            int Character_Pos_UD = 10;
            bool GameOver = false;



            Console.SetCursorPosition(Character_Pos_LR, Character_Pos_UD);
            Console.WriteLine("X");
            do
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        //Check if movement is valid
                        if (Character_Pos_UD > 3)
                        {
                            //remove current character
                            Console.SetCursorPosition(Character_Pos_LR, Character_Pos_UD);
                            Console.WriteLine(" ");

                            //move character up one
                            Character_Pos_UD = Character_Pos_UD - 1;
                            Console.SetCursorPosition(Character_Pos_LR, Character_Pos_UD);
                            Console.WriteLine("X");
                            Console.SetCursorPosition(0, 0);
                        }

                        break;

                    case ConsoleKey.DownArrow:
                        // check if movement is valid
                        if (Character_Pos_UD < 29)
                        {
                            //remove current character
                            Console.SetCursorPosition(Character_Pos_LR, Character_Pos_UD);
                            Console.WriteLine(" ");

                            //move character up one
                            Character_Pos_UD = Character_Pos_UD + 1;
                            Console.SetCursorPosition(Character_Pos_LR, Character_Pos_UD);
                            Console.WriteLine("X");
                            Console.SetCursorPosition(0, 0);
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        //Check if movement is valid
                        if (Character_Pos_LR > 0)
                        {
                            //remove current character
                            Console.SetCursorPosition(Character_Pos_LR, Character_Pos_UD);
                            Console.WriteLine(" ");

                            //move character up one
                            Character_Pos_LR = Character_Pos_LR - 1;
                            Console.SetCursorPosition(Character_Pos_LR, Character_Pos_UD);
                            Console.WriteLine("X");
                            Console.SetCursorPosition(0, 0);
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        //Check if movement is valid
                        if (Character_Pos_LR < 79)
                        {
                            //remove current character
                            Console.SetCursorPosition(Character_Pos_LR, Character_Pos_UD);
                            Console.WriteLine(" ");

                            //move character up one
                            Character_Pos_LR = Character_Pos_LR + 1;
                            Console.SetCursorPosition(Character_Pos_LR, Character_Pos_UD);
                            Console.WriteLine("X");
                            Console.SetCursorPosition(0, 0);
                        }
                        break;
                }
            } while (!GameOver);
        }
        
    }

    class Credits
    {
        public static void Begin()
        {
            Console.Clear();
            Console.Write("This game was made by me. \nPublished to git at https://github.com/MstrssZ/game-learn-2d-scroll.git \n" +
                            "Feel free to branch and work on it on your own, or to add issues for more features.\n" +
                            "have fun");
            Console.ReadKey(true);
        }
    }
}
