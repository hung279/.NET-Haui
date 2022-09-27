using System;

namespace TinhToan
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float a, b;
                string pt;
                Console.Write("Nhap a = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Nhap b = ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Nhap pt = ");
                pt = Console.ReadLine();
                switch(pt)
                {
                    case "+":
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                    case "-":
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case "*":
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case "/":
                        if (b == 0)
                            throw new Exception("Mau phai khac 0");
                        Console.WriteLine($"{a} / {b} = {a / b}");
                        break;
                    default:
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            
        }
    }
}
