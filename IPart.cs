using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw1
{
    public interface IPart
    {
        string Name { get; set; }
        int Count { get; set; }
        public bool Installed { get; set; }


        void Install();
    }
}