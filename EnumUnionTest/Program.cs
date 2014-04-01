using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumUnionTest
{
    class Program
    {
        enum UnionTest
        {
            UA = 1 << 0,
            UB = 1 << 1,
            UC = 1 << 2,
            UD = 1 << 3,
            UE = 1 << 4,
            UF = 1 << 5,
            UG = 1 << 6,
            UH = 1 << 7,
            UI = 1 << 8,
            UJ = 1 << 9
        }     
        static void Main(string[] args)
        {
            UnionTest test = UnionTest.UA | UnionTest.UB | UnionTest.UD | UnionTest.UE | UnionTest.UF | UnionTest.UG | UnionTest.UI;
            foreach (string str in Enum.GetNames(typeof(UnionTest)))
            {
                
                Console.WriteLine("Enum Name :{0} Value = {1}", str, (int)Enum.Parse(typeof(UnionTest), str));
            }
            Console.WriteLine("--------------------------------------------------------");
            foreach (UnionTest str in Enum.GetValues(typeof(UnionTest)))
            {
                if ((test & str) == str)
                    Console.WriteLine("Enum Name :{0} Value = {1}", str, (int)str);
            }
            Console.Read();
        }
    }
}
