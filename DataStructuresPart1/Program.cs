using DataStructuresPart1;

/** Arrays, Struct and int
string[] users = { "john", "Matt" };
Console.WriteLine(users[0]);
Console.WriteLine(users[1]);

//Struct
Name myName = new Name("Kumar", "Pratap", "Singh");
string fullName = myName.ToString();
string initials = myName.Initials();
Console.WriteLine($"my initials are {initials}");
Console.WriteLine($"Full name is {fullName}");

int num; string sNum;
Console.Write("Enter a number: ");
sNum = Console.ReadLine();
num = Int32.Parse(sNum);
Console.WriteLine(num);
Console.ReadLine();
 * */

#region Collections using ArrayLists
//Collection courses = new Collection();
//courses.Add("Javascript");
//courses.Add("ASP.NET MVC");
//courses.Add("C#");
//courses.Add("Python");

//foreach (var course in courses)
//    Console.WriteLine(course);

//Console.WriteLine("Number of courses:" + courses.Count());
//courses.Remove("C#");

//Console.WriteLine("Number of courses:" + courses.Count());
//courses.Clear();
//Console.WriteLine("Number of courses:" + courses.Count());
//Console.ReadLine();
#endregion

#region Generic Class
//DataStructuresPart1.LinkedList<string> node1 = new DataStructuresPart1.LinkedList<string>("John", null);
//DataStructuresPart1.LinkedList<string> node2 = new DataStructuresPart1.LinkedList<string>("Matt", node1);
//DataStructuresPart1.LinkedList<string> obj = node2.link;
//Console.WriteLine(node1.data);
//Console.WriteLine(node2.data);
//Console.WriteLine(obj.data);
//Console.ReadLine();

#endregion

#region Jagged Arrays
//int[] Jan = new int[31];
//int[] Feb = new int[29];
//int[][] sales = new int[][] { Jan, Feb };
//int month, day, total;
//double average = 0.0;
//sales[0][0] = 41;
//sales[0][1] = 42;
//sales[0][2] = 43;
//sales[0][3] = 44;
//sales[0][4] = 48;
//sales[0][5] = 45;
//sales[0][6] = 49;
//sales[1][0] = 45;
//sales[1][1] = 47;
//sales[1][2] = 42;
//sales[1][3] = 48;
//sales[1][4] = 41;
//sales[1][5] = 40;
//sales[1][6] = 42;
//for(month =0; month<=1;month++)
//{
//    total = 0;
//    for(day =0; day <= 6; day++)
//    {
//        total += sales[month][day];
//    }
//    average = total / 7;
//    Console.WriteLine($"Average sale for {month} month is {average}");
//}
//Console.ReadLine();
#endregion

#region Bubble Sort
Collection numbers = new Collection();
Random random = new Random(100);
for (int i = 0; i <= 10; i++)
{
    numbers.Add((int)(random.NextDouble() * 100));
}
foreach (int i in numbers) 
    Console.WriteLine(i);
numbers.BubbleSort();
Console.WriteLine("----------------------------------");
foreach (int i in numbers)
    Console.WriteLine(i);
Console.ReadLine();
#endregion