using System;
using System.Collections.Generic;  // без этого никак 

using number_ot_0_do_5;
/*Пользователь вводит словами цифру от 0 до 9. Приложение должно перевести слово в цифру. Например, если 
пользователь ввёл five, приложение должно вывести на 
экран 5.*/
namespace number_ot_0_do_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string slovo;
            Console.WriteLine("Введите слово");
            slovo = Console.ReadLine();
            var number = new Dictionary<string,int>()
    {
                 {"zero",0},
                 { "one",1},
                 { "two",2},
                 {"tree",3},
                 {"four",4},                 /* как stl map из с++*/
                 {"five",5},
                 {"six",6},
                 {"seven",7},
                 {"eight",8},
                 {"nine",9}
    };
            int sam = number[slovo];
            Console.WriteLine(sam);
            //правда пытался сделать сам но увы решил погуглить и посмотреть библиотеки типо stl
        }
    }
}
