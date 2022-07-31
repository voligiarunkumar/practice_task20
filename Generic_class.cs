/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_task20
{
    internal class Generic_class
    { 

       public class Animal_category<Animal>
        {
           private Animal? value1;
            
           public Animal value
            {
                get
                {
                    return this.value1;
                }
                set
                {
                    this.value1=value;
                }
            }
        }
        class class1

        {
            public static void Main(string[] args)
            {
                Animal_category<string> name= new Animal_category<string>();
                name.value = "elephent";
                Animal_category<int> span = new Animal_category<int>();
                span.value = 5000;
                Console.WriteLine("animal_category is:"+name.value);
                Console.WriteLine("life span is:" + span.value);
            }
        }
    }
}
*/