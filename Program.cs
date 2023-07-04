using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Двумерная_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветсвует 2Gis");
            Console.WriteLine("Определить ваше местоположение?");
            string answer = Console.ReadLine();
            if (answer == "да")
            {
                Console.WriteLine("Определяю Ваше местоположение ...");
                Console.ReadKey();
                Random randomplace = new Random();
                Double x = randomplace.Next(0, 10000);
                Double y = randomplace.Next(0, 10000);
                Console.WriteLine("Ваше место положение определено:");
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                Console.ReadKey();
                Console.WriteLine("Укажите место прибытия по координате Х:");
                Double x2 = Convert.ToSingle(Console.ReadLine());
                if (x2 <= 10000)
                {
                    Console.WriteLine("Укажите место прибытия по координате Y:");
                    Double y2 = Convert.ToSingle(Console.ReadLine());
                    if (y2 <= 10000)
                    {
                        Double distance = Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2));
                        Console.WriteLine(distance.ToString("Ваше расстояние до пункта назначения =" + distance));
                        Console.WriteLine("С какой скоростью Вам комфортно передвигаться по дорогам общего пользования (КМ/Ч) ? :");
                        Double speed = Convert.ToSingle(Console.ReadLine());
                        Double time = distance / speed;
                        Console.WriteLine("Ваше время в пути составит:" + time);
                        Console.WriteLine("Счастлтвого пути");
                        Console.WriteLine("Спасибо что используете 2Gis");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("Указанное место находится вне зоны обслуживания");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Указанное место находится вне зоны обслуживания");
                    Console.ReadKey();
                }










                if (answer == "нет")
                {
                    Console.WriteLine("Укажите вручную");
                    Console.WriteLine("Ваше местоположение по координате Х: ");
                    Double x0 = Convert.ToSingle(Console.ReadLine());
                    if (x0 <= 10000)
                    {
                        Console.WriteLine("Ваше местоположение по координате Y:");
                        Double y0 = Convert.ToSingle(Console.ReadLine());
                        if (y0 <= 10000)
                        {
                            Console.WriteLine("Укажите место прибытия по координате Х:");
                            Double x3 = Convert.ToSingle(Console.ReadLine());
                            if (x3 <= 10000)
                            {
                                Console.WriteLine("Укажите место прибытия по координате Y:");
                                Double y3 = Convert.ToSingle(Console.ReadLine());
                                if (y3 <= 10000)
                                {
                                    Double distance = Math.Sqrt(Math.Pow(x3 - x0, 2) + Math.Pow(y3 - y0, 2));
                                    Console.WriteLine(distance.ToString("Ваше расстояние до пункта назначения =" + distance));
                                    Console.WriteLine("С какой скоростью Вам комфортно передвигаться по дорогам общего пользования (КМ/Ч) ? :");
                                    Double speed = Convert.ToSingle(Console.ReadLine());
                                    Double time = distance / speed;
                                    Console.WriteLine("Ваше время в пути составит:" + time);
                                    Console.WriteLine("Счастлтвого пути");
                                    Console.WriteLine("Спасибо что используете 2Gis");
                                    Console.ReadKey();

                                }
                                else
                                {
                                    Console.WriteLine("Указанное место вне диапазона работы 2Gis");
                                    Console.ReadKey();
                                }


                            }
                            else
                            {
                                Console.WriteLine("Указанное место вне диапазона работы 2Gis");
                                Console.ReadKey();

                            }
                        }
                        else
                        {
                            Console.WriteLine("Вы находитесь вне зоны подачи машины");
                            Console.WriteLine("Подойдите ближе и попробуйте ещё раз");
                            Console.ReadKey();
                        }


                    }
                    else
                    {
                        Console.WriteLine("Вы находитесь вне зоны подачи машины");
                        Console.WriteLine("Подойдите ближе и попробуйте ещё раз");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine("Ответ введён не корректно. Попробуйте ещё раз.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Ответ введён не корректно. Попробуйте ещё раз.");
                Console.ReadKey ();
            }
                

            

        }
    }
}
