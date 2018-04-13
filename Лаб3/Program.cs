using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tipinv Tip1 = new Tipinv("Тренажеры", "Инвентарь для тренировок", 1);
            Tipinv Tip2 = new Tipinv("Компьютеры", "Инвентарь для администрирования", 2);
            Tipinv Tip3 = new Tipinv("Мебель", "Прочий инвентарь", 3);
            Inventar Inv1 = new Inventar("Беговая дорожка", 1, 15000.50, DateTime.Today, Tip1);
            Inventar Inv2 = new Inventar("Скамья", 2, 10000.00, DateTime.Today, Tip1);
            Inventar Inv3 = new Inventar("Ноутбук бухгалтера", 3, 20000.00, DateTime.Today, Tip2);
            Inventar Inv4 = new Inventar("Зеркало", 4, 15000.00, DateTime.Today, Tip3);

            Inv1.GetInfo();

            Console.ReadLine();            
        }

    }
}
