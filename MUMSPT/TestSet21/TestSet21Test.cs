﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMSPT.TestSet21
{
  public static class TestSet21Test
    {
        public static void isSystematicallyIncreasing()
        {
            Console.WriteLine("test for isSystematicallyIncreasing ");
            Console.WriteLine("========================");

            Console.Write("isSystematicallyIncreasing of  {1}   is"); Console.WriteLine(" = {0}"
             , TestSet21.isSystematicallyIncreasing(new int[] { 1 }));

            Console.Write("isSystematicallyIncreasing of  {1, 2, 1, 2, 3}   is"); Console.WriteLine(" = {0}"
                         , TestSet21.isSystematicallyIncreasing(new int[] { 1, 2, 1, 2, 3 }));

            Console.Write("isSystematicallyIncreasing of  {1, 1, 3}   is"); Console.WriteLine(" = {0}"
                         , TestSet21.isSystematicallyIncreasing(new int[] { 1, 1, 3 }));

            Console.Write("isSystematicallyIncreasing of  {1, 2, 1, 2, 1, 2}   is"); Console.WriteLine(" = {0}"
                         , TestSet21.isSystematicallyIncreasing(new int[] { 1, 2, 1, 2, 1, 2 }));


            Console.Write("isSystematicallyIncreasing of  {1, 2, 3, 1, 2, 1}   is"); Console.WriteLine(" = {0}"
                         , TestSet21.isSystematicallyIncreasing(new int[] { 1, 2, 3, 1, 2, 1 }));


            Console.Write("isSystematicallyIncreasing of  {1, 1, 2, 3}   is"); Console.WriteLine(" = {0}"
                         , TestSet21.isSystematicallyIncreasing(new int[] { 1, 1, 2, 3 }));


            Console.WriteLine("========================");
        }


        public static void isFactorialPrime()
        {
            Console.WriteLine("test for isFactorialPrime ");
            Console.WriteLine("========================");

            Console.Write("isFactorialPrime of  2   is"); Console.WriteLine(" = {0}"
             , TestSet21.isFactorialPrime(2));

            Console.Write("isFactorialPrime of  3   is"); Console.WriteLine(" = {0}"
             , TestSet21.isFactorialPrime(3));

            Console.Write("isFactorialPrime of  7   is"); Console.WriteLine(" = {0}"
            , TestSet21.isFactorialPrime(7));

            Console.Write("isFactorialPrime of  8   is"); Console.WriteLine(" = {0}"
            , TestSet21.isFactorialPrime(8));

            Console.Write("isFactorialPrime of  11  is"); Console.WriteLine(" = {0}"
            , TestSet21.isFactorialPrime(11));

            Console.Write("isFactorialPrime of  721   is"); Console.WriteLine(" = {0}"
            , TestSet21.isFactorialPrime(721));




            Console.WriteLine("========================");
        }
    }
}
