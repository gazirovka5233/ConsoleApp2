﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public void ExistingMethod()
        {
            Console.WriteLine("Это новый изменённый метод в основном ветке");
        }
        public void NewMethodConflictBracnh()
        {
            Console.WriteLine("Это новый метод в ветке conflict-branch");
        }
    }
}
