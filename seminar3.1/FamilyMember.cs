using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar3._1
{
    public class FamilyMember
    {
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public string FullName { get; set; }
        public FamilyMember Mother { get; set; }
        public FamilyMember Father { get; set; }
        public FamilyMember Married { get; set; }
        


        

        public FamilyMember[] GetGrantMothers()
        {
            return new FamilyMember[] { Mother.Mother, Father.Mother };
        }

        public FamilyMember[] GetGrantFathers()
        {
            return new FamilyMember[] { Mother.Father, Father.Father };
        }

        public void Print()
        {
            Console.WriteLine($"fullname={FullName}, gender={Gender}, age={Age}");
        }

        public FamilyMember[] GetWifeAndHusband()
        {
            return new FamilyMember[] { Mother, Father };
        }

        public void DisplayCloseRelatives()
        {
            if (Married != null)
            {
                Console.WriteLine($"{FullName}'s married is {Married.FullName}");
            }
            else
            {
                Console.WriteLine($"{FullName} has no spouse listed.");
            }
        }

    }
}
