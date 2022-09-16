using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExeceptionHandling
{
    internal class class1
    {
        public static void execute()
        {


            //
            /*

           
            Console.WriteLine(100/0);
            */

            //2
            /*
            int[] arr=new int[3];
            for (int i = 0; i < 3; i++)
            {
                arr[i+1]=i;
            }*/

            //3
            /*
            class2 c;
            Console.WriteLine(c.name);
            */

            //4
            /*
            float num = 30.15f;
            int num1 = num;
            */


            String[] arr = File.ReadAllLines(path);
        }
    }
    class class2
    {
      public  int id;
       public int name;
    }
}
