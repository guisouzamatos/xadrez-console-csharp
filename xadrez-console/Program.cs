using System;
using System.Collections.Generic;
using System.Linq;
using xadrez_console.table;

namespace xadrez
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Position p;

            p = new Position(3, 4);

            Console.WriteLine("Posição: " + p);

            Console.ReadLine();
        }
    }
}