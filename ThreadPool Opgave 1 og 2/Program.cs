﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPool_Opgave_1_og_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch mywatch = new Stopwatch();
            Console.WriteLine("Thread Pool Execution");

            mywatch.Start();

            ProcessWithThreadPoolMethod();

            mywatch.Stop();

            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks.ToString());
            mywatch.Reset();
            Console.WriteLine("Thread Execution");
            mywatch.Start();
            ProcessWithThreadMethod();
            mywatch.Stop();
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks.ToString());
        }
        static void Process(object callback)
        {
            //Eksekveringstiden stiger en stor mængde
            for (int i = 0; i < 100000; i++) 
            {
                for (int j = 0; j < 100000; i++)
                {

                }
            }
        }
        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i < 10; i++) 
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }
        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }
    }
}
