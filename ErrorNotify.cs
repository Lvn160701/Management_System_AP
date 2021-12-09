using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System
{
    class ErrorNotify
    {
        public void checkInput()
        {
            Console.WriteLine("Notice: Please check the input data!" +
                                   "\nMaybe you enter characters instead of numbers" +
                                   " or maybe you entered the wrong date of birth\n");
        }

        public void notNum()
        {
            Console.WriteLine("Not numder! Press 0 to continue");
            int tt = int.Parse(Console.ReadLine());
            if (tt == 0) { Console.Clear(); }
        }
    }
}
