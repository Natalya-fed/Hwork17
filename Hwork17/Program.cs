using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork17
{
    class Program
    {
        static void Main(string[] args)
        {
             Bank<int> bank = new Bank<int>();
            bank.InputAccount(4535003, 15067.04, "Демидов Владимир Леонидович");
            bank.UserAccount();
            Console.WriteLine("-----------------------------------------------");
            Bank<string> bank1 = new Bank<string>();
            bank1.InputAccount("4535003", 15067.04, "Демидов Владимир Леонидович");
            bank1.UserAccount();
            Console.WriteLine("-----------------------------------------------");
            Bank<double> bank3 = new Bank<double>();
            bank3.InputAccount(4535003, 15067.04, "Демидов Владимир Леонидович");
            bank3.UserAccount();
            Console.ReadKey();
        }
        class Bank<T>
        {
            T number;
            double balans;
            string name;
            public void InputAccount(T number, double balans, string name)
            {
                this.number = number;
                this.balans = balans;
                this.name = name;

            }
            public void UserAccount()
            {
                Console.Write($"Номер счета:\t{number}\nБаланс счета:\t{balans}\nФИО Пользователя:\t{name}\n");
            }
        }
    }
}
