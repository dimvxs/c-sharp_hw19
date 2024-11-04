using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace hw1
{
    public class Window: IPart
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public bool Installed { get; set; }

           public Window(){
            Name = "window";
            Count = 4;
            Installed = false;
        }

    

          public void Install(){
                Console.Write(Name + "installed  \n");
                Installed = true;
                }
    }
}