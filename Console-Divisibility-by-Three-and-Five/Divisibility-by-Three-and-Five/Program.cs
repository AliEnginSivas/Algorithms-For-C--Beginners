﻿using System;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("Console-Divisibility-by-Three-and-Five\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {

            string numInput1 = "";

            Console.Write("Öğrenmek istediğiniz Değeri Giriniz: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("Girdiğiniz Değer bir sayı değildir: ");
                numInput1 = Console.ReadLine();
            }

            if (((cleanNum1 % 3 == 0) && (cleanNum1 % 5 == 0)))
            {
                Console.WriteLine("Girdiğiniz sayı Bölünüyor : " + cleanNum1);
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı Bölünmüyor : " + cleanNum1);
            }
            Console.WriteLine("------------------------\n");


            Console.Write("Uygulamayı kapatmak için 'n' ve Enter'a basın veya devam etmek için başka bir tuşa ve Enter'a basın:");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}
