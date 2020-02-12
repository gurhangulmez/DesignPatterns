using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPatternExample
{
    public sealed class SingletonClass
    {
        private static readonly object lockObj = new object();
        private static SingletonClass instance;

        private SingletonClass()
        {
        }

        public static SingletonClass GetInstance
        {
            get
            { 
                lock(lockObj)
                {
                    if (instance == null)
                    {
                        instance = new SingletonClass();
                    }
                    return instance;
                }
            }
        }

        public void WriteMyName()
        {
            Console.WriteLine("HELLO! I am thread-safety Singleton Class!");
        }
    }
}
