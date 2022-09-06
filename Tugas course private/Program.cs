using System;


namespace Tugas_course_private
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\tZWINGLI LEONARDO MIRA MANGNGI");
            Console.WriteLine("\n\n");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input Data Secara Statis");

            int a = 3;
            int b = 4;
            int c = 5;
            int d = 6;

            
           Console.WriteLine("Masukan variabel a = 3 ");
           Console.WriteLine("Masukan variabel b = 4 ");
           Console.WriteLine("Masukan variabel c = 5 ");
           Console.WriteLine("Masukan variabel d = 6");


            
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("Penjumlahan");
            Console.WriteLine(a + b);
            Console.WriteLine(b + c);
            Console.WriteLine(c + d);
            Console.WriteLine(d + a);
            
            

            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Pengurangan");
            Console.WriteLine(a - b);
            Console.WriteLine(b - c);
            Console.WriteLine(c - d);
            Console.WriteLine(d - a);
            
            

            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Perkalian");
            Console.WriteLine(a * b);
            Console.WriteLine(b * c);   
            Console.WriteLine(c * d);   
            Console.WriteLine(d * a);

           



            Console.ReadLine();
        }
    }
}
