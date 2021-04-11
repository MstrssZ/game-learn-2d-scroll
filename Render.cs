using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Adventure
{
    class Render
    {
        static void ScreenUpdate(string refreshPiece)
        {
            switch (refreshPiece)
            {
                case "Character_HP":
                    //draw HP
                    Console.SetCursorPosition(25, 1);
                    Console.WriteLine("HP: {0}/{1}", Program.Character_HP_Current, Program.Character_HP_Full);
                    break;
                case "Character_EXP":
                    //draw EXP
                    Console.SetCursorPosition(40, 1);
                    Console.WriteLine("EXP: {0}/{1}", Program.Character_EXP_Current, Program.Character_EXP_Full);
                    break;
                case "Character_LVL":
                    //draw LVL
                    Console.SetCursorPosition(60, 1);
                    Console.WriteLine("LVL: {0}", Program.Character_LVL);





                    /*
                     on LVL up:
                        max HP +10
                        max EXP *1.2
                        heal for 10% of new max
                        reset EXP = EXP-MaxEXP 
                        
                     */



                    break;
                default:
                    break;
            }



            return;
        }
    }
}
