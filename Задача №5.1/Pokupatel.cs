using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача__5._1
{
    class Pokupatel
    {
        public string fam;
        public string imya;
        public string otch;
        public string date_rod;
        public Pokupatel(string fam, string imya, string otch, string date_rod)
        {
            this.fam = fam;
            this.imya = imya;
            this.otch = otch;
            this.date_rod = date_rod;
        }
        public virtual void show()
        {
            Console.WriteLine($"Имя {imya}\nФамилия {fam}\nОтчество {otch}\nДата рождения {date_rod}");
        }
    }
}
