﻿using System;
using System.Collections.Generic;
  
namespace practice6_10
{
    class GClass<T>
    {
        private List<T> list;
        public GClass()
        {
            list = new List<T>();
        }
        public String getValue()
        {
            String str = "";
            foreach (T e in list) str += (e.ToString() + " ");
            return str;
        }
        public void setValue(params T[] args)
        {
            foreach (T e in args) list.Add(e);
        }
    }
    internal class ExerciseCh6_10_1
    {
        public static void Main(String[] args)
        {
            GClass<int> gInteger = new GClass<int>();
            gInteger.setValue(10, 20, 30);
            Console.WriteLine(gInteger.getValue());
        }
    }
}
 
