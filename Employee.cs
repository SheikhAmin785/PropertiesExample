using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{
    class Employee
    {
        private int id;//private value
        private string name;//private value
        public int Eid//private value k public kora//Eid=id
        {
            set { id = value; }
            get { return id; }
        }

        public string Ename//private value k public kora/Ename=name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("id value should be greater than");
                }
                
                name = value;
            }
            get
            {
                return name; 
            }
        }
      
        public static void Myname()
        {
            Employee e1 = new Employee();
            e1.Eid = 101;
            e1.Ename = "alamin";
            Console.WriteLine("my property value:"+e1.Eid);
            Console.ReadKey();
        }
    }
}
