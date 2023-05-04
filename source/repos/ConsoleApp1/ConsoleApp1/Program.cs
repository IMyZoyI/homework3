using System;
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
            Console.WriteLine("Введите число которое нужно округлить:");
            double number = double.Parse(Console.ReadLine());
            double numb = Math.Round(number);
            Console.WriteLine("Введёное число {0}, Округлёное число {1}", number, numb);





        }





    }

























}




