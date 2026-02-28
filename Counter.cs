using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSession02_OOP_
{
    internal class Counter
    {
        public static int _count = 0;

        //Static Method ==>Called by ClassName
        public static void Increment()=>_count++;
        public static void Decrement()=>_count--;
    }
}
