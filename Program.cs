﻿using ClassProject;
using System;
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
            Console.WriteLine("Привет, Git");
            var logger = new Logger();
            logger.Log("Программа запущена");
        }
        public void ExistingMethod()
        {
            Console.WriteLine("Этот метод был изменен в основной ветке!");
        }
        public void NewMethodConflictBracnh()
        {
            Console.WriteLine("Это новый метод в ветке conflict-branch!");
        }
        public void NewMethod()
        {
            Console.WriteLine("Это новый метод");
        }
    }
}
