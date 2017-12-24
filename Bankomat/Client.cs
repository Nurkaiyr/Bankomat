using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bankomat;

namespace Clients
{
    public class Client
    {
        private string name;
        private int age;

        public Client()
        {

        }

        public Client(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void AddClient()
        {
            Console.WriteLine("Введите Имя: ");
            name = Console.ReadLine();

            Console.WriteLine("\nВведите возраст: ");
            while(int.TryParse(Console.ReadLine(),out age) != true)
            {
                Console.WriteLine("Вы ввели неправильное значение!\n" + "Введите снова: ");
            }
            Console.ReadLine();
            Console.Clear();
        }

        public void ShowInformation()
        {
            Console.WriteLine("Имя:{0}\nВозраст: {1}", name,age);
        }
    }
}
