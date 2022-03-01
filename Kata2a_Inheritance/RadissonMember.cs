using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata2a_Inheritance;

namespace Kata2a_Inheritance
{
    internal class RadissonMember : Member,IRadissonMember
    {
        public override string[] Benefits { get; set; }
        public new void RandomInit()
        {
            base.RandomInit();

            var rnd = new Random();
            Benefits = "R = free breakfast R = free drink in the pool bar R = Lower price at the hotel bar ".Split(' ');
        }
    }
}
