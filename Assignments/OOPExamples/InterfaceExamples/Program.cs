using InterfaceExamples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPhysics phyHod=new Science();
            Console.WriteLine(phyHod.PhysicsCalci());
            IChemistry chemHod = new Science();
            Console.WriteLine(chemHod.ChemistryCalci());
            IBiology bioHod = new Science();
            Console.WriteLine(bioHod.BiologyCalci());
            IDepartmentHod departmentHod = new Science();
            departmentHod.
        }
    }
}
