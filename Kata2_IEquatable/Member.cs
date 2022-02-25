using Kata2_IEquitable;

namespace Kata2_IEquatable
{
    internal class Member : IMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public MemberLevel Level { get; set; }
        public DateTime Since { get; set; }

        public int CompareTo(IMember other)
        {
            if (this.Level != other.Level)
            {
                return this.Level.CompareTo(other.Level);
            }
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            return this.Since.CompareTo(other.Since);
        }
        public bool Equals(IMember member) => (this.Level, this.FirstName, this.LastName, this.Since) == (member.Level, member.FirstName, member.LastName, member.Since);
        public override bool Equals(object obj) => Equals(obj as IMember);
        public override int GetHashCode() => (Level, FirstName, LastName, Since).GetHashCode();

        public void RandomInit()
        {
            var rnd = new Random();
            bool bAllOk = false;
            while (!bAllOk)
            {
                try
                {
                    int year = rnd.Next(1980, DateTime.Today.Year +1);
                    int month = rnd.Next(1, 13);
                    int day = rnd.Next(1, 31);

                    this.Since = new DateTime(year, month, day);
                    this.Level = (MemberLevel)rnd.Next((int)MemberLevel.Platinum, (int)MemberLevel.Blue +1);

                    string[] _firstnames = "Fred Marie Oliver Rebecca Adam Louise Erik Per".Split(' ');
                    string[] _lastnames = "Johnsson Valmin Grundeberg Isaksen Vallbo Grähs Hultgren Sandberg".Split(' ');
                    string[] _cities = "Stockholm Göteborg Malmö Borås Umeå Karlstad".Split(' ');

                    this.FirstName = _firstnames[rnd.Next(0, _firstnames.Length)];
                    this.LastName = _lastnames[rnd.Next(0, _lastnames.Length)];
                    this.City = _cities[rnd.Next(0, _cities.Length)];

                    bAllOk = true;
                }
                catch 
                {
                    Console.WriteLine("Does not work");   
                }
            }
        }
        public Member() { }

        public static class Factory
        {
            public static IMember CreateWithRandomData()
            {
                var member = new Member();
                member.RandomInit();
                return member;
            }
        }
        public override string ToString() => $"{FirstName} {LastName} is a {Level} member since {Since.Year}-{Since.Month}-{Since.Day}\n";
        
        /*
        static DateTime RandomDate()
        {
            var rnd = new Random();
            while (true)
            {
                try
                {
                    int year = rnd.Next(1980, DateTime.Today.Year);
                    int month = rnd.Next(1, 13);
                    int day = rnd.Next(1, 31);

                    return new DateTime(year, month, day);
                }
                catch { }
            }
        }
        static string RandomCity()
        {
            var rnd = new Random();
            string[] _cities = "Stockholm Göteborg Malmö".Split(' ');
            return _cities[rnd.Next(0, _cities.Length)];
        }
        */
    }
}