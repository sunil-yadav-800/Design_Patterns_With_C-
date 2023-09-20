using System;

namespace Singleton_Non_Thread_Safe
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            if(s1 == s2)
            {
                Console.WriteLine("s1 and s2 both have same instance");
            }
            else
            {
                Console.WriteLine("s1 and s2 both have different instance");
            }
        }
    }
}
