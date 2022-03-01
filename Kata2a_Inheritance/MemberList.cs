using Kata2a_Inheritance;
using System.Linq;

namespace Kata2_IEquatable
{
    public class MemberList : IMemberList
    {
        List<IMember> ListOfMembers = new List<IMember>();

        public MemberList() { }

        public IMember this[int idx]
        {
            get { return ListOfMembers[idx]; }
        }
        
        public static class Factory
        {
            public static IMemberList CreateWithRandomData(int nrOfMembers)
            {
                var member = new MemberList();

                for (int i = 0; i < nrOfMembers; i++)
                {
                    member.ListOfMembers.Add(Member.Factory.CreateWithRandomData());
                }
                return member;
            }
        }
        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < ListOfMembers.Count; i++)
            {
                sRet += $"{ListOfMembers[i],-20:d}";

                if ((i + 1) % 10 == 0)
                {
                    sRet += $"\n";
                }
            }
            return sRet;
        }

        public int Count() => ListOfMembers.Count();
        public int Count(int year)
        {
            int count = 0;
            foreach (var members in ListOfMembers)
            {
                if (members.Since.Year == year)
                    count++;
            }
            return count;
        }
 
        public void Sort() => ListOfMembers.Sort();
    }
}