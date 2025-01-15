using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCSharp
{
    public class HelloWorld
    {
        public static string StringTest()
        {
            return "Hello";
        }

        public static int IntTest()
        {
            int a = 10;
            int b = 20;

            return a * b + 10;
        }

        public static List<int> ListTest()
        {
            List<int> a = new List<int>();
            try
            {
                a.Add(1);
                Console.WriteLine(a[0]);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            return a;
        }

        public static string StringTest2()
        {
            string a = null;
            return a;
        }
    }
}
