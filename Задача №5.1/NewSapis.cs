using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача__5._1
{
    class NewSapis : Pokupatel
    {
        public string number;
        public NewSapis(string number, string fam,string imya,string otch, string date_rod) :base(fam,imya,otch, date_rod)
        {
            this.number = number;
        }
        public override void show()
        {
            base.show();
            Console.WriteLine($"Номер телефона {number}");
        }
    }
}
