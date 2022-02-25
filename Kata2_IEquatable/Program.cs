// See https://aka.ms/new-console-template for more information
using Kata2_IEquatable;
using System.Linq;


#region Refresh how to generate random initialization data
// Console.WriteLine(RandomDate());
// Console.WriteLine(RandomCity());

/*
var member1 = new Member();
Console.WriteLine(member1.ToString());

var member2 = new Member();
Console.WriteLine(member2.ToString());

var member3 = new Member();
Console.WriteLine(member3.ToString());

var member4 = new Member();
Console.WriteLine(member4.ToString());
*/

var newMembers = MemberList.Factory.CreateWithRandomData(40);

Console.WriteLine("Unsorted list with 40 members");
Console.WriteLine(newMembers.ToString());
Console.WriteLine("-----------------------------");

Console.WriteLine("A list with 20 members of Hilton members:\n");
var HiltonMembers = MemberList.Factory.CreateWithRandomData(20);
HiltonMembers.Sort();
Console.WriteLine(HiltonMembers);

Console.WriteLine("----------------------------------------");

Console.WriteLine("A list with 20 members of Radisson members:\n");
var RadissonMembers = MemberList.Factory.CreateWithRandomData(20);
RadissonMembers.Sort();
Console.WriteLine(RadissonMembers);

Console.WriteLine($"First Hilton member: {HiltonMembers[0]}");
Console.WriteLine($"Last Hilton member: {HiltonMembers[19]}");

Console.WriteLine($"First Radisson member: {RadissonMembers[0]}");
Console.WriteLine($"First Radisson member: {RadissonMembers[19]}");



#endregion