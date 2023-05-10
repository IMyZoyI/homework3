using System;
using System.Threading.Channels;

namespace project
{
    class programm
    {
        static void Main()
        {
            //float user_input;
            // user_input = Convert.ToDouble(Console.ReadLine());
            //user_input = float.Parse(Console.ReadLine());
            // float user_input = float.Parse(Console.ReadLine());
            //float result;
            //result = user_input + 20f;
            //result = result + 6f;
            // или
            //result += 6f;
            //result = user_input - 10f;
            //result = user_input * 5f;
            //result = user_input / 10f;
            // процент позваляет узнавать остаток при делении 
            //result = user_input % 2f;
            //int a = 6, b = 8;
            //int res = a + b;
            //Console.WriteLine("Переменная: " + result);
            //Console.WriteLine(Math.PI);
            //Console.WriteLine(Math.Abs());
            //Ceiling позваоляет округлять числа в положительную сторону 
            //Console.WriteLine(Math.Ceiling(4.6f));
            //Floor округляет к меньшему
            //Console.WriteLine(Math.Floor(4.6f));
            //Round округляет либо к большему либо  к меньшему
            //Console.WriteLine(Math.Round(4.6f));
            // min позволяет узнать минимальное значение из двух чисел
            //Console.WriteLine(Math.Min(4,1));
            // max позволяет узнать максимальное значение из двух чисел
            //Console.WriteLine(Math.Max(4, 1));
            //pow позволяет возводить числла в степень
            //Console.WriteLine(Math.Pow(4, 3));
            //Console.WriteLine("Введите число которое нужно округлить:");
            //double number = double.Parse(Console.ReadLine());
            //double numb = Math.Round(number);
            //Console.WriteLine("Введёное число {0}, Округлёное число {1}", number, numb);
            //Console.WriteLine("вычисление степени введите первое число: ");
            //    double number = Convert.ToInt32 (Console.ReadLine());
            //Console.WriteLine("Введите степень: ");
            //double numbe =Convert.ToInt32 (Console.ReadLine());
            //double numb = Math.Pow(number, numbe);
            //Console.WriteLine($"Введёное число {number} степень {numbe} результат :{numb}");







            /*
            int decima_literal = 42; // просто число в десятичной форме
            int hexLiteral = 0x2A; // 0x указывает на шестнадцатеричную форму
            int binaryliteral = 0b_0010_1010; // 0b укзывает на двоичную форму
            DateTime date = new DateTime(2018, 12, 5, 18, 15, 16); //полная запись времени
            DateTime date2 = new DateTime(2018, 12, 5); // или более грубая версия
            */

            //int x =10;
            //x += 5; //правильное сложение
            /*
            bool adminrules = true;
            int age = 17;
            // && оперетор при котором можно добавить дополнительную переменную
            // || этот оператор указывает на или/ или
            if (adminrules && age > 18)
            {
                Console.WriteLine("полный доступ!");

            } else if (adminrules)
            {
                Console.WriteLine("оганиченный доступ");


            }
            else if (age > 18)
            {
                Console.WriteLine("Права пользователя !");


            }
            else
            {
                Console.WriteLine("нет доступа!");


            }
            */

            //Тернанрый оператор урезанная версия if else и выполняет либо то либо другое 
            //int age = 10;
            //string res = age > 18 ? "больше 18" : "меньше 18";
            //Console.WriteLine(res);

            //bool adminrules = true;
            //int age = 17;
            //string res = null;
            //if (age > 0 & adminrules == false)
            //{
            //Console.WriteLine( "yes1");

            //}

            //if (age > 0 && res.StartsWith("test"))
            //{
            //Console.WriteLine("yes");

            //}
            //else
            // {

            // Console.WriteLine("no");
            //}


            //int res = 10;
            //if (res !=0) // неравенство != равенство ==

            /*
            int daysofweek = 5;
            string daytitle = "";

            switch (daysofweek)//услоынй оператор который может смотреть только по одной переменной
            {
                case 0:
                    daytitle = "понедельник";
                    break;

                case 1:
                    daytitle = "вторник";
                    break;
                case 2:
                    daytitle = "среда";
                    break;
                case 3:
                    daytitle = "четверг";
                    break;

                default:
                    Console.WriteLine("выходные");
                    break;

            }
            Console.WriteLine(daytitle);
            */
            /*
            [Flags];// flags позволяет выводить значение команд  а не сами цифры
             enum seasons// enum позволяет сделать группу численных значений
        {
            spring = 10,
            summer = 20,
            autumn = 30,
            winter = 40,
        }
            */
            //неявное преобразование
            //byte b = 10;
            //short s = b;
            // явное преобразование при этом мы говорим программе что часть данных может быть утеряна при таком преобразовании
            //short s = 10000;
            //byte b = (byte) s;

            //string s = "12345";
            //int i =Convert.ToInt32(s);

            //string s = null; //ссылочный тип данных это null
            /*
            int age = 17;
            if (age < 17)
            {
                Console.WriteLine("вам ещё рановато!");
                    return; //услоынй оператор который возварщает к самому началу программы и завершает её

            }

            Console.WriteLine("какие сигареты вы любите?");
            */

            Console.WriteLine("Введите минимальную температуру: ");
            int minTemp =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру: ");
            int maxTemp =Convert.ToInt32(Console.ReadLine());
            int medTemp = (minTemp + maxTemp)/2;
            Console.WriteLine($"Минимальная температура {minTemp}, максимальная температура {maxTemp}, средняя температура {medTemp} ") ;

            Console.WriteLine("Введите номер месяца :");
            int MonthNomber =Convert.ToInt32 (Console.ReadLine());
            string MonthTitle = "";
            switch(MonthNomber){
                case 1:
                    MonthTitle = "Январь";
                    break;
                case 2:
                    MonthTitle = "февраль";
                    break;
                case 3:
                    MonthTitle = "Март";
                    break;
                case 4:
                    MonthTitle = "апрель";
                    break;
                case 5:
                    MonthTitle = "Май";
                    break;
                case 6:
                    MonthTitle = "Июнь";
                    break;
                case 7:
                    MonthTitle = "Июль";
                    break;
                case 8:
                    MonthTitle = "Август";
                    break;
                case 9:
                    MonthTitle = "Сентябрь";
                    break;
                case 10:
                    MonthTitle = "Октябрь";
                    break;
                case 11:
                    MonthTitle = "Ноябрь";
                    break;
                case 12:
                    MonthTitle = "Декабрь";
                    break;
                default:
                    Console.WriteLine("Вы ввели некорекктное число месяца");
                    break;  

            }
            Console.WriteLine(MonthTitle);

            if (minTemp > 0 && MonthNomber >10 && MonthNomber < 13)
            {
                Console.WriteLine("Дождливая зима");

            }

                Console.WriteLine("Введите число");

            int number = Convert.ToInt32 (Console.ReadLine());
            if (number % 2 == 0 )
            {
                Console.WriteLine("Чётное");
            }
            else {
                Console.WriteLine("Нечётное");
            }

            DateTime date = DateTime.Now;
            int result1 = MonthNomber * number;
            int result2 = maxTemp * number;
            int result3 = result1 + result2;
            Console.WriteLine($"Время покупки {date}");
            Console.WriteLine($"Товар:суп с макаронам ={result1}рублей") ;
            Console.WriteLine($"рис с котлетами  ={result2}рублей");
            Console.WriteLine($"Итого к опалте ={result3}рублей");

            int week = 0b_1111111; //дни недели
            //маски рабочей неедли
                int office1 = 0b0111100; // работают с вторника по пятницу
                int office2 = 0b1111111; // работают с понеделька по воскресенье
                int office3 = 0b1000001;

            int fullworkweek = week & office2;
            int tus_fridayweek = week & office1;
            int mon_sunweek = week & office3;

            Console.WriteLine(fullworkweek == office1);
            Console.WriteLine(tus_fridayweek == office2);
            Console.WriteLine(mon_sunweek == office3);

            if (week == office1)
            {
                Console.WriteLine("Работает первый офис");
            }
            else if (week == office2)
            {
                Console.WriteLine("Работает второй офис");

            }
            else if(week == office3)
            {
                Console.WriteLine("Работает третий офис");

            }
            else
            {
                Console.WriteLine("Работают все");
            }



        }
    }
}





