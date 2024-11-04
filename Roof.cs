using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw1
{
    public class Roof: IPart
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public bool Installed { get; set; }

         public Roof(){
            Name = "roof";
            Count = 1;
            Installed = false;
        }


      public void Install(){
                Console.Write(Name + "installed  \n");
                Installed = true;
                }

    }
}