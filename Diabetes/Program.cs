using System;

namespace Diabetes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Hb, NG, height, weight, IMT;

            Console.Write("Введите значение гликированного гемоглобина (HbA1c, %) = ");

            Hb = Convert.ToDouble(Console.ReadLine());

            if (Hb < 5.7)
            {
                Console.WriteLine("Нет сахарного диабета");
            }
            else if (5.7 <= Hb && Hb < 6.5)
            {
                Console.WriteLine("HbA1c незначительное повышение");
                Console.WriteLine("Введите значение тощаковой глюкозы (NG, mg/dl)");
                NG = Convert.ToDouble(Console.ReadLine());

                if (NG < 100)
                {
                    Console.WriteLine("Нет сахарного диабета");
                    Console.WriteLine("Выяснение причин повышения риска диабета, изменение стиля жизни, лечение факторов риска. Новая оценка риска и HbA1c через год");
                }
                else if (100 <= NG && NG < 125)
                {
                    Console.WriteLine("Выяснение причин повышения риска диабета, изменение стиля жизни, лечение факторов риска. Новая оценка риска и HbA1c через год");
                }
                else if (NG >= 125)
                {
                    Console.WriteLine("Сахарный диабет");
                    Console.WriteLine("Проверка на ожирение");

                    Console.WriteLine("Введите ваш рост, в см");
                    height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите ваш вес, в кг");
                    weight = Convert.ToDouble(Console.ReadLine());

                    IMT = weight / Math.Pow(height / 100, 2);
                    if (IMT <= 25)
                    {
                        Console.WriteLine("Нет предостережений к ожирению");
                        Console.WriteLine("Введите показатель Аутоантител (GAD65-Ak, IA-2-Ak, Insulin-Ak, ZnT8-Ak, Inselzell-Ak*): 1-положительный, 0 - отрицательный");
                        int Autoanti = Convert.ToInt32(Console.ReadLine());
                        if (Autoanti == 1)
                            Console.WriteLine("Тип 1 - Сахарный диабет");
                        else if (Autoanti == 0) ;
                        Console.WriteLine("Введите показатель C-инсулина и Инсулина (каждый натощак): 1-повышенный, 0 - низкий");
                        int CInsul = Convert.ToInt32(Console.ReadLine());
                        if (CInsul == 1)
                            Console.WriteLine("Тип 2 - Сахарный диабет");
                        else if (CInsul == 2) ;
                        Console.WriteLine("МОДИ-диагностика");
                    }
                    else if (IMT > 25)
                    {
                        Console.WriteLine("Ожирение");
                        Console.WriteLine("Введите показатель C-пептида или Инсулина (каждый натощак): 1-повышенный, 0 - низкий");
                        int CpI = Convert.ToInt32(Console.ReadLine());
                        if (CpI == 1)
                            Console.WriteLine("Тип 2 - Сахарный диабет");
                        else if (CpI == 0) ;
                        Console.WriteLine("Введите показатель Аутоантител (GAD65-Ak, IA-2-Ak, Insulin-Ak, ZnT8-Ak, Inselzell-Ak*): 1-положительный, 0 - отрицательный");
                        int Autoanti = Convert.ToInt32(Console.ReadLine());
                        if (Autoanti == 1)
                            Console.WriteLine("Тип 1 - Сахарный диабет");
                        else if (Autoanti == 0) ;
                        Console.WriteLine("МОДИ-диагностика");
                    }
                }
            }
            else if (Hb >= 6.5)
            {
                Console.WriteLine("Сахарный диабет");
                Console.WriteLine("Проверка на ожирение");

                Console.WriteLine("Введите ваш рост, в см");
                height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите ваш вес, в кг");
                weight = Convert.ToDouble(Console.ReadLine());

                IMT = weight / Math.Pow(height / 100, 2);
                if (IMT <= 25)
                {
                    Console.WriteLine("Нет предостережений к ожирению");
                    Console.WriteLine("Введите показатель Аутоантител (GAD65-Ak, IA-2-Ak, Insulin-Ak, ZnT8-Ak, Inselzell-Ak*): 1-положительный, 0 - отрицательный");
                    int Autoanti = Convert.ToInt32(Console.ReadLine());
                    if (Autoanti == 1)
                        Console.WriteLine("Тип 1 - Сахарный диабет");
                    else if (Autoanti == 0) ;
                    Console.WriteLine("Введите показатель C-инсулина и Инсулина (каждый натощак): 1-повышенный, 0 - низкий");
                    int CInsul = Convert.ToInt32(Console.ReadLine());
                    if (CInsul == 1)
                        Console.WriteLine("Тип 2 - Сахарный диабет");
                    else if (CInsul == 2) ;
                    Console.WriteLine("МОДИ-диагностика");
                }
                else if (IMT > 25)
                {
                    Console.WriteLine("Ожирение");
                    Console.WriteLine("Введите показатель C-пептида или Инсулина (каждый натощак): 1-повышенный, 0 - низкий");
                    int CpI = Convert.ToInt32(Console.ReadLine());
                    if (CpI == 1)
                        Console.WriteLine("Тип 2 - Сахарный диабет");
                    else if (CpI == 0) ;
                    Console.WriteLine("Введите показатель Аутоантител (GAD65-Ak, IA-2-Ak, Insulin-Ak, ZnT8-Ak, Inselzell-Ak*): 1-положительный, 0 - отрицательный");
                    int Autoanti = Convert.ToInt32(Console.ReadLine());
                    if (Autoanti == 1)
                        Console.WriteLine("Тип 1 - Сахарный диабет");
                    else if (Autoanti == 0) ;
                    Console.WriteLine("МОДИ-диагностика");
                }
            }
            Console.WriteLine("Диагностика завершена");
            Console.ReadLine();
        }

    }
}