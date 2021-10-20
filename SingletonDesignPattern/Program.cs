using System;

namespace SingletonDesignPattern
{
    /// <summary>
    /// Mohammad Gholami
    /// MohammadGholamiHarunieh1@gmail.com
    /// Farhad Manafi
    /// Farhad.manafi@gmail.com
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton With Constructor");
            for (int i = 0; i < 10; i++)
            {
                var singletonWithConstructor = SingletonWithConstructor.GetInstance();

                if (singletonWithConstructor.GetUserName(i) == null)
                    break;

                Console.WriteLine($"No: {i} - UserName: {singletonWithConstructor.GetUserName(i)}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Singleton With Instance");
            for (int i = 0; i < 10; i++)
            {
                var singletonWithInstance = SingletonWithInstance.Instance;

                if (singletonWithInstance.GetUserName(i) == null)
                    break;

                Console.WriteLine($"No: {i} - UserName: {singletonWithInstance.GetUserName(i)}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Singleton With Lazy");
            for (int i = 0; i < 10; i++)
            {
                var singletonWithLazy = SingletonWithLazy.Instance;

                if (singletonWithLazy.Value.GetUserName(i) == null)
                    break;

                Console.WriteLine($"No: {i} - UserName: {singletonWithLazy.Value.GetUserName(i)}");
            }

            Console.ReadLine();
        }
    }
}
