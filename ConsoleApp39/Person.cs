using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class NPC
    {

            public string Name { get; set; }
            public int Age { get; set; }
            public int XueLiang { get; set; }
        
            public string J1 { get; set; }
        public string J2 { get; set; }
        public string J3 { get; set; }
        public void IncrementAge(string name,int age,int xueLiang,string j1,string j2,string j3)
        {
            Name = name;
            Age = age;
            XueLiang = xueLiang;
            J1 = j1;
            J2 = j2;
            J3 = j3;
        }
    }


    }

