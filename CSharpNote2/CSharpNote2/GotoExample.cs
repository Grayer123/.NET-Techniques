﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class GotoExample
    {
        public static void Main()
        {
            
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    goto skipped;
                }
            
                Console.WriteLine(i);
            skipped:
                Console.WriteLine();
            }
        
            
        }
    }
}
