namespace DelegateDecompiler.EntityFramework.Tests.EfItems.Abstracts
{
    public class HoneyBee : Animal
    {
        public override string Species => "Apis mellifera";

        public override bool IsPet => false;

        [Computed]
        public override string SpeciesAndAge() => string.Concat(Species, " : ", Age);
    }
}
