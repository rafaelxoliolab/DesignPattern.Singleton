using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public static class Structural
    {
        public static void Run() {
            Singleton instance1 = Singleton.GetInstance();
            Singleton instance2 = Singleton.GetInstance();

            if (instance1 == instance2)
            {
                Console.WriteLine("Same Singleton Object");
            }

            Console.ReadKey();
        }
    }

    class Singleton
    {
        private static Singleton instance;

        protected Singleton() { 
        }

        public static Singleton GetInstance()
        {
            if (instance==null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}
