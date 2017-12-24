using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;

namespace Accounts
{
    public class Account
    {
        private Client newclient;

        private int money;
        private int id;
        private string password="123";

        public Account()
        {
            newclient = new Client();
            newclient.AddClient();

            Random random = new Random();
            id = random.Next(1000, 10000);
            Console.WriteLine("Ваш ИД:"+id);

            CreatePassword();
            Console.WriteLine("\nВаш пароль: " + password);

        }

        public Account(string name, int age)
        {
            newclient = new Client(name, age);
            Random random = new Random();
            id = random.Next(1000, 10000);
            Console.WriteLine("Ваш ИД:{0}" + id);

            CreatePassword();
            Console.WriteLine("\nВаш пароль:{0} " + password);
        }

        public void ShowInfo()
        {
            newclient.ShowInformation();
            Console.WriteLine("Ваш ИД:{0}\n Ваш пароль:{1}", id,password);
        }

        public void ShowMoney()
        {
            Console.WriteLine("Ваш баланс равен:{0}",money);
        }

        public void AddMoney(int money1)
        {
            money += money1;
            Console.WriteLine("Вы успешно положили деньги на счет!");
        }

        public int GetMoney(int wantedMoney)
        {
            if (wantedMoney > money)
            {
                Console.WriteLine("У вас недостаточно средств для этой операций!");
                return 0;
            }

            else
            {
                money -= wantedMoney;
                Console.WriteLine("Вы успешно сняли деньги!");
                return wantedMoney;
            }
        }

        private void CreatePassword()
        {
            Console.Write("\nСоздайте свой пароль: ");

            Console.ReadLine();
        }

        public string GetPassword()
        {
            return password;
        }

    }
}
