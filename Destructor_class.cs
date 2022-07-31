/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_task20
{
    internal class Destructor_class
    {
        public void Runthis(int i, int j)
        {
            int k = i;
            int m = j;
            Console.WriteLine("values are" + k + " " + m);

        }
        ~Destructor_class()
        {
            Console.WriteLine("Destructor was called");
        }
    }


    class class1
    {
        public static void Main(string[] args)
        {
            Destructor_class obj = new Destructor_class();
            obj.Runthis(20, 20);
            obj.Runthis(50, 50);
        }
    }

}
*/