using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Vezba1
{

    enum MyEnum
    {
        Sasa = 0,
        Vlado = 1
    }

    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Enum.GetName(typeof(MyEnum), 1));
            foreach (var VARIABLE in Enum.GetNames(typeof(MyEnum)))
            {
                Console.WriteLine(VARIABLE);
            }

               

            MyEnum ee;
            Enum.TryParse("1", out ee);

            Console.WriteLine(ee);
        }

       

    }
}


 

 
