using InterfaceExamples.Contracts;

namespace InterfaceExamples
{
    internal class Science : IDepartmentHod
    {
        public void InstanceMethod()
        {

        }
        string IBiology.BiologyCalci()
        {
            return "Biology Calci Method from IBiology Interface";
        }

        string IChemistry.ChemistryCalci()
        {
            return "Chemistry Calci Method from IChemistry Interface";
        }

        double IPhysics.PhysicsCalci()
        {
            return 3.14;
        }
    }
}
