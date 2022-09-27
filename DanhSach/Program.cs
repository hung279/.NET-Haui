using System;
using System.Collections;
using System.Collections.Generic;

namespace DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> flList = new List<float>();
            for (int i = 0; i < 5; i++)
            {
                flList.Add(float.Parse(Console.ReadLine()));
            }
            flList.Sort();
            foreach (float fl in flList)
            {
                if (fl < 0)
                {
                    flList.Remove(fl);
                    
                }
            }
            foreach (float fl in flList)
            {
                Console.Write(fl + " ");
            }
            Console.Write("Nhap x = ");
            float x = float.Parse(Console.ReadLine());
            for (int i = 0; i < flList.Count; i++)
            {
                if (x < flList[i])
                {
                    flList.Insert(i, x);
                }
            }
            foreach (float fl in flList)
            {
                Console.Write(fl + " ");
            }
        }
    }
}
