using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounts;

namespace Bancs
{
    public class Banc
    {
        private Account client;
        public Banc()
        {
            client = new Account();
        }

        public void Menu()
        {
            Console.Write("Введите ваш пароль: ");
            int tryes = 3;
            bool isOK = false;

            string temp;
            for (int i = 0; i < tryes; i++)
            {
                temp = Console.ReadLine();

                if (temp.Equals(client.GetPassword()) == true)
                {
                    isOK = true; break;
                }
                else if (i < 2) Console.Write("\nНеверный пароль, введите снова: ");
            }

            if (isOK == false)
            {
                Console.WriteLine("\nУ вас закончились попыти ввода!");
                return;
            }

            string choice;
            bool menuforever = true;

            while (menuforever == true)
            {
                Console.Clear();
                Console.Write("Qazaq Bank\n" + "1. Показать баланс счета\n" + "2. Пополнить счет\n" + "3. Снять деньги со счета\n" + "4. Выход\nВаше действие: ");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();

                        client.ShowMoney();

                        Console.ReadLine();
                        break;

                    case "2":
                        Console.Clear();

                        Console.Write("Введите сумму: ");
                        int wantedMoney = int.Parse(Console.ReadLine());

                        client.AddMoney(wantedMoney);

                        Console.ReadLine();
                        break;

                    case "3":
                        Console.Clear();

                        Console.Write("Введите сумму: ");
                        int getRequest = int.Parse(Console.ReadLine());

                        client.GetMoney(getRequest);

                        Console.ReadLine();
                        break;

                    case "4":
                        Console.Clear();

                        Console.WriteLine("Выход...");
                        menuforever = false;

                        Console.ReadLine();
                        break;

                    default:
                        Console.Clear();

                        Console.WriteLine("Такого действия нет!");

                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
