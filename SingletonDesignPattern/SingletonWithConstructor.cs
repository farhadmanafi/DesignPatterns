using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class SingletonWithConstructor
    {
        private static SingletonWithConstructor _instance;
        public static SingletonWithConstructor GetInstance()
        {
            if (_instance == null)
                _instance = new SingletonWithConstructor();

            return _instance;
        }

        private List<string> _users = new List<string>();
        private SingletonWithConstructor()
        {
            Console.WriteLine("Initializing User ...");
            List<string> users = new List<string>() { "farhad", "mohammad", "alisan" };
            foreach (var item in users)
            {
                _users.Add(item);
            }
        }
        public string GetUserName(int userId)
        {
            if (_users.Count() <= userId)
                return null;
            return _users[userId];
        }

    }
}
