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
        public static int Character_Pos_LR { get; set; }
        public static int Character_Pos_UD { get; set; }
        
        public static bool GameOver { get; set; }

        public static string Character_Name { get; set; }
        public static string Recent_Move_Direction { get; set; }


        static void Main()
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
            Title();

        }
        public static void Title()
        {
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
                    Console.Clear();
                    Console.WriteLine("not an option given");
                    Console.WriteLine("Press a key:");
                    Console.ReadKey(true);
                    Title();
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



            for (int i = 0; i <= 79; i++)
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

            //init character position
            



            

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
                            Character_Pos_UD --;
                            Console.SetCursorPosition(Character_Pos_LR, Character_Pos_UD);
                            Console.WriteLine("X");
                            Console.SetCursorPosition(0, 0);
                            Recent_Move_Direction = "n";
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
                            Character_Pos_UD ++;
                            Console.SetCursorPosition(Character_Pos_LR, Character_Pos_UD);
                            Console.WriteLine("X");
                            Console.SetCursorPosition(0, 0);
                            Recent_Move_Direction = "s";
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
                            Character_Pos_LR --;
                            Console.SetCursorPosition(Character_Pos_LR, Character_Pos_UD);
                            Console.WriteLine("X");
                            Console.SetCursorPosition(0, 0);
                            Recent_Move_Direction = "w";
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
                            Character_Pos_LR ++;
                            Console.SetCursorPosition(Character_Pos_LR, Character_Pos_UD);
                            Console.WriteLine("X");
                            Console.SetCursorPosition(0, 0);
                            Recent_Move_Direction = "e";
                        }
                        break;

                    case ConsoleKey.X:
                        Attack(Character_Pos_LR, Character_Pos_UD, Recent_Move_Direction);

                        break;
                }
            } while (!GameOver);
        }

        public static void Attack(int pos_x, int pos_y, string atk_dir)
        {
            switch (atk_dir)
            {
                case "n":
                    //check if vaild targetable spot
                    if (pos_y > 4)
                    {
                        Console.SetCursorPosition(pos_x, pos_y - 1);
                        Console.WriteLine("^");
                        System.Threading.Thread.Sleep(1000);
                        Console.SetCursorPosition(pos_x, pos_y - 1);
                        Console.WriteLine(" ");
                    }
                    break;
                case "s":
                    //check if vaild targetable spot
                    if (pos_y < 28)
                    {
                        Console.SetCursorPosition(pos_x, pos_y + 1);
                        Console.WriteLine("V");
                        System.Threading.Thread.Sleep(1000);
                        Console.SetCursorPosition(pos_x, pos_y + 1);
                        Console.WriteLine(" ");
                    }
                    break;
                case "e":
                    //check if vaild targetable spot
                    if (pos_x < 78)
                    {
                        Console.SetCursorPosition(pos_x + 1, pos_y);
                        Console.WriteLine(">");
                        System.Threading.Thread.Sleep(1000);
                        Console.SetCursorPosition(pos_x + 1, pos_y);
                        Console.WriteLine(" ");
                    }
                    break;
                case "w":
                    //check if vaild targetable spot
                    if (pos_x > 1)
                    {
                        Console.SetCursorPosition(pos_x - 1, pos_y);
                        Console.WriteLine("<");
                        System.Threading.Thread.Sleep(1000);
                        Console.SetCursorPosition(pos_x - 1, pos_y);
                        Console.WriteLine(" ");
                    }
                    break;
            }
        }
        
    }
}
