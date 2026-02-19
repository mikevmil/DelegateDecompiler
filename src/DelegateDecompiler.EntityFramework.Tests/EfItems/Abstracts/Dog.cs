using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDecompiler.EntityFramework.Tests.EfItems.Abstracts
{
    public class Dog : Animal
    {
        public override string Species => "Canis lupus";
        public override bool IsPet => true;

        [Computed]
        public override string SpeciesAndAge() => string.Concat(Species, " : ", Age);
    }
}
