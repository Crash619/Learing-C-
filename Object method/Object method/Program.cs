using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Mike", "CS", 2.86);
            Student student2 = new Student("Ahemd", "Art", 3.86);

            Console.WriteLine(student1.HasHoners());
            Console.WriteLine(student2.HasHoners());

            Console.ReadLine();
        }

        
    }
}
