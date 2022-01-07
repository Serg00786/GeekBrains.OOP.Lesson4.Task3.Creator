using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.Lesson4.Task1
{
   public class Creator
    {
        Hashtable HT = new Hashtable();

        static Creator()
        {
        }
       public int CreateBuild()
        {
            
            Buildings builder1 = new Buildings("Строим высокое здание");
            int a=builder1.SetBuildingNumber(1);
            HT.Add(a,builder1);
            Console.WriteLine("Построено здание 1");
            return a;
        }

        public int CreateBuild(double b)
        {

            Buildings builder2 = new Buildings("Строим низкое здание b метров");
            int a = builder2.SetBuildingNumber(2);
            builder2.SetHeight(b);
            HT.Add(a,builder2);
            Console.WriteLine("Построено здание 2, " + b+" метров");
            return a;
        }
        
        public void DestroyBuilding(int a)
        {
            HT.Remove(a);
        }
    }
}
