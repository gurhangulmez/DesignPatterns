using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPatternExample
{
    //Singleton DP: For example you have a web application and millions of customers enters the web site, 
    //And all of them wants to current user count. All of them needs to Access same object to increase it and read it's value.
    //You want to control same objects state. A lot of code tries to change same objects state.
    //This is the case that we need to use this DP.

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
