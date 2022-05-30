using System;

namespace Задача__5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fam, im, otch, date_rod,number;
            int count_new_sapis = 0;
            int count_old_sapis = 0;
            Console.WriteLine($"Введите количество вводимых записей");
            int i = Convert.ToInt32(Console.ReadLine());
            Pokupatel[] shoppers = new Pokupatel[i];
            for (int x = 0; x <shoppers.Length; x++)
            {
                Console.Clear();
                Console.WriteLine("Введите фамилию");
                fam = Console.ReadLine();
                Console.WriteLine("Введите имя");
                im = Console.ReadLine();
                Console.WriteLine("Введите отчество");
                otch = Console.ReadLine();
                Console.WriteLine("Введите дату рожденния");
                date_rod = Console.ReadLine();
                Console.WriteLine("Если покупатель предъявил номер телефона, введите его, либо же нажмите Enter");
                number = Console.ReadLine();
                if (number == "")
                {
                    shoppers[x] = new Pokupatel(fam, im, otch, date_rod);
                    count_old_sapis++;
                }
                else
                {
                    shoppers[x] = new NewSapis(number, fam, im, otch, date_rod);
                    count_new_sapis++;
                }
            }
            for (int x = 0; x<shoppers.Length; x++)
            {
                shoppers[x].show();
            }
            Console.WriteLine("Введите Enter для продолжения");
            Console.Clear();
            Console.WriteLine("Введите через Enter фамилию, имя, отчество покупателя у которого вы хотите получить номер телефона");
            fam = Console.ReadLine();
            im = Console.ReadLine();
            otch = Console.ReadLine();
            if (fam == null) fam = "";
            if (im == null) im = "";
            if (otch == null) otch = "";
            for (int x = 0; x < shoppers.Length; x++)
            {
                if ((shoppers[x].fam == fam) || (shoppers[x].imya == im) || (shoppers[x].otch == otch))
                {
                    Console.Write($"Номер телефона {fam} {im} {otch}\n");
                    shoppers[x].show();
                }
            }
            Console.WriteLine($"Количество новых записей {count_new_sapis}\nКоличество старых записей {count_old_sapis}");
        }
    }
}
