using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создайте переменную типа string в которую пользователь вводит пароль, далее проверьте пароль на правильность, и если пароль неверный, то попросите его ввести пароль ещё раз. Если пароль подошёл, выведите секретное сообщение. 
            /*Дополнительный балл:
            Сделайте счётчик неверных вводов пароля, и при достижении числа 5, завершите программу. */



            int tryOuts = 5;
            bool noAnswer = true;
            string secretPasswd = "SecretPasswd";
            while(tryOuts > 0 && noAnswer)
            {
                Console.WriteLine($"Please enter secret password, you have {tryOuts} try");
                string userEntries = Console.ReadLine();
                if(userEntries == secretPasswd)
                {
                    Console.WriteLine("Gracia, you may pass");
                    noAnswer = false;
                }
                else if(tryOuts == 1)
                {
                    Console.WriteLine("Cya later");
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                tryOuts--;

            }
        }
    }
}
