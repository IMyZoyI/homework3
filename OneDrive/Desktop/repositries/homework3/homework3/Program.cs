using System;
namespace homework3
{
    class programm
    {
        static void Main(string[] args)
        {

            /* //*1
             int[,] line = new int[5, 5];
             line[1, 1] = 1;
             line[2, 2] = 2;
             line[3, 3] = 3;
             line[4, 4] = 4;
             for (int i = 0; i < line.GetLength(0); i++)
             {
                 for (int j = 0; j < line.GetLength(1); j++)
                 {
                     if (i == j)
                     {
                         Console.Write($"{line[i, j]}");
                     }

                 }
                 Console.WriteLine();
             }*/
            //*2

            string[,] phonebook = new string[5, 2] { 
                { "илья", "mail" },
                { "petya", "google" }, 
                { "artem", "yandex" }, 
                { "володя", "yahoo" }, 
                { "den", "bing" } };


            for (int i = 0; i < phonebook.GetLength(0); i++)
            {
                for (int j = 0; j < phonebook.GetLength(1); j++)

                    Console.Write($"{phonebook[i, j]} ");
                Console.WriteLine();

            }

        }
    }
}
