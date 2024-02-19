using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int armor = 50;
            int damagePerSecond = 5;
            uint money = 100;
            int heals = 100;
            ushort stamina = 100;
            sbyte morale = 100;
            string appeal = "привет";
            bool isDead = heals <= 0;
            bool isTired = stamina <= 0;
            bool haveLowMorale = morale <= 0;
        }
    }
}
