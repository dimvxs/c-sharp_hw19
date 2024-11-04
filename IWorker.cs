using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw1
{
    public interface IWorker
    {
        string Name {get; set;} 
        string Surname {get; set;}
        int Salary {get; set;} 

    
         void AboutWorker();
    }
}