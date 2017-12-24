using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bancs;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Banc bank = new Banc();
            bank.Menu();
        }


    }
}
