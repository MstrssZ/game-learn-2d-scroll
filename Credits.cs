using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Adventure
{
    class Credits
    {
        public static void Begin()
        {
            Console.Clear();
            Console.Write("This game was made by me. \nPublished to git at https://github.com/MstrssZ/game-learn-2d-scroll.git \n" +
                            "Feel free to branch and work on it on your own, or to add issues for more features.\n" +
                            "have fun");
            Console.ReadKey(true);
            Program.Title();
        }
    }
}
