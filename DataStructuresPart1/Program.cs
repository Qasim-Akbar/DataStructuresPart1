using DataStructuresPart1;
using System.Collections;
using System.Diagnostics;

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
//Collection numbers = new Collection();
//Random random = new Random(100);
//for (int i = 0; i <= 10; i++)
//{
//    numbers.Add((int)(random.NextDouble() * 100));
//}
//foreach (int i in numbers) 
//    Console.WriteLine(i);
//numbers.BubbleSort();
//Console.WriteLine("----------------------------------");
//foreach (int i in numbers)
//    Console.WriteLine(i);
//Console.ReadLine();
#endregion

#region Selection Sort
//Collection numbers = new Collection();
//Random random = new Random(80);

//for (int i = 0; i <= 10; i++)
//{
//    numbers.Add((int)(random.NextDouble() * 100));
//}
//foreach (int i in numbers)
//    Console.WriteLine(i);
//numbers.SelectionSort();
//Console.WriteLine("----------------------------------");
//foreach (int i in numbers)
//    Console.WriteLine(i);
//Console.ReadLine();
#endregion

#region Merge Sort
//Collection numbers = new Collection();
//Random random = new Random(101);

//for (int i = 0; i <= 10; i++)
//{
//    numbers.Add((int)(random.NextDouble() * 100));
//}
////Print before sorting
//printArray(numbers);
//Stopwatch stopwatch = Stopwatch.StartNew();
//stopwatch.Start();
////Sorting Array
//numbers.MergeSort();
//stopwatch.Stop();
//Console.WriteLine($"Elapsed Time: {stopwatch.Elapsed}");

////Print After sorting
//printArray(numbers);
//Console.ReadLine();
#endregion

#region Insertion Sort
//Collection numbers = new Collection();
//Random random = new Random(101);

//for (int i = 0; i <= 10; i++)
//{
//    numbers.Add((int)(random.NextDouble() * 100));
//}
////Print before sorting
//printArray(numbers);
//Stopwatch stopwatch = Stopwatch.StartNew();
//stopwatch.Start();
////Sorting Array
//numbers.InsertionSort();
//stopwatch.Stop();
//Console.WriteLine($"Elapsed Time: {stopwatch.Elapsed}");

////Print After sorting
//printArray(numbers);
//Console.ReadLine();
#endregion

#region Shell Sort
//Collection numbers = new Collection();
//Random random = new Random(1001);

//for (int i = 0; i <= 130; i++)
//{
//    numbers.Add((int)(random.NextDouble() * 100));
//}
////Print before sorting
//printArray(numbers);
//Stopwatch stopwatch = Stopwatch.StartNew();
//stopwatch.Start();
////Sorting Array
//numbers.ShellSort();
//stopwatch.Stop();
//Console.WriteLine($"Elapsed Time: {stopwatch.Elapsed}");

////Print After sorting
//printArray(numbers);
//Console.ReadLine();
#endregion

#region Quick Sort
//Collection numbers = new Collection();
//Random random = new Random(1001);

//for (int i = 0; i <= 13; i++)
//{
//    numbers.Add((int)(random.NextDouble() * 100));
//}
////Print before sorting
//printArray(numbers);
//Stopwatch stopwatch = Stopwatch.StartNew();
//stopwatch.Start();
////Sorting Array
//numbers.QuickSort();
//stopwatch.Stop();
//Console.WriteLine($"Elapsed Time: {stopwatch.Elapsed}");

////Print After sorting
//printArray(numbers);
//Console.ReadLine();
#endregion

#region Sequential/Linear Search
//Collection numbers = new Collection();
//Random random = new Random(1001);

//for (int i = 0; i <= 13; i++)
//{
//    numbers.Add((int)(random.NextDouble() * 100));
//}
//printArray(numbers);
//Stopwatch stopwatch = Stopwatch.StartNew();
//stopwatch.Start();
//bool result = numbers.SequentialSerach(62);
//stopwatch.Stop();
//Console.WriteLine($"result:{result}, Elapsed Time: {stopwatch.Elapsed}");

//Console.ReadLine();
#endregion

#region Binary Search
//Collection numbers = new Collection();
//Random random = new Random(1001);

//for (int i = 0; i <= 13; i++)
//{
//    numbers.Add((int)(random.NextDouble() * 100));
//}
//numbers.SelectionSort();
//printArray(numbers);
//Stopwatch stopwatch = Stopwatch.StartNew();
//stopwatch.Start();
//bool result = numbers.BinarySearch(81);
//stopwatch.Stop();
//Console.WriteLine($"result:{result}, Elapsed Time: {stopwatch.Elapsed}");

//Console.ReadLine();
#endregion

#region Recursive Binary Search
//Collection numbers = new Collection();
//Random random = new Random(1001);

//for (int i = 0; i <= 13; i++)
//{
//    numbers.Add((int)(random.NextDouble() * 100));
//}
//numbers.SelectionSort();
//printArray(numbers);
//Stopwatch stopwatch = Stopwatch.StartNew();
//stopwatch.Start();
//bool result = numbers.RBinarySearch(95, 0, numbers.Count());
//stopwatch.Stop();
//Console.WriteLine($"result:{result}, Elapsed Time: {stopwatch.Elapsed}");

//Console.ReadLine();
#endregion

#region Stacks LIFO or FILO - PUSH and POP
//DataStructuresPart1.Stack numbers = new DataStructuresPart1.Stack();
//Random rnd = new Random(100);

//Console.WriteLine("Push Operation");
//for (int i = 0; i <= 13; i++)
//    numbers.push((int)(rnd.NextDouble() * 100));

//Console.WriteLine("Peek Operation");
//Console.WriteLine(numbers.peek());

//Console.WriteLine("Pop Operation");
//Console.WriteLine(numbers.pop());

//Console.WriteLine("Total Count");
//Console.WriteLine(numbers.count());

//Console.WriteLine("Clear Operation");
//numbers.clear();

//Console.WriteLine("Total Count");
//Console.WriteLine(numbers.count());

//Console.WriteLine("---------------------------------------");

//Stack<string> stack = new Stack<string>();

//for (int i = 0; i <= 13; i++)
//    stack.Push(""+ (int)(rnd.NextDouble() * 100)); //.push((int)(rnd.NextDouble() * 100));

//Console.WriteLine("Total Count");
//Console.WriteLine(stack.Count());

//Console.WriteLine("Peek Operation");
//Console.WriteLine(stack.Peek());

//Console.WriteLine("Pop Operation");
//Console.WriteLine(stack.Pop());

//Console.WriteLine("Total Count");
//Console.WriteLine(stack.Count());

//Console.WriteLine("Clear Operation");
//stack.Clear();

//Console.WriteLine("Total Count");
//Console.WriteLine(stack.Count());

#endregion

#region Queues FIFO - EnQueue and DeQueue

//DataStructuresPart1.Queue numbers = new DataStructuresPart1.Queue();
//Random rnd = new Random(100);

//Console.WriteLine("EnQueue Operation");
//for (int i = 0; i <= 13; i++)
//    numbers.EnQueue((int)(rnd.NextDouble() * 100));



//Console.WriteLine("DeQueue Operation");
//Console.WriteLine(numbers.DeQueue());

//Console.WriteLine("Total Count");
//Console.WriteLine(numbers.Count());

//Console.WriteLine("Peek Operation");
//Console.WriteLine(numbers.Peek());

//Console.WriteLine("Clear Operation");
//numbers.ClearQueue();

//Console.WriteLine("Total Count");
//Console.WriteLine(numbers.Count());

//Console.WriteLine("---------------------------------------");

//Queue<string> queue = new Queue<string>();
//for (int i = 0; i <= 13; i++)
//    queue.Enqueue("A " + (int)(rnd.NextDouble() * 100)); //.push((int)(rnd.NextDouble() * 100));

//Console.WriteLine("Total Count");
//Console.WriteLine(queue.Count());

//Console.WriteLine("DeQueue Operation");
//Console.WriteLine(queue.Dequeue());

//Console.WriteLine("Peek Operation");
//Console.WriteLine(queue.Peek());

//Console.WriteLine("Total Count");
//Console.WriteLine(queue.Count());

//Console.WriteLine("Clear Operation");
//queue.Clear();

//Console.WriteLine("Total Count");
//Console.WriteLine(queue.Count());

#endregion

#region Dictionary Key Pair

//DataStructuresPart1.Dictionary dictionary = new DataStructuresPart1.Dictionary();
//Random rnd = new Random(100);

//dictionary.Add("Ali", "Paid");
//dictionary.Add("Boota", "Due");
//dictionary.Add("Nade", "Paid");

//Console.WriteLine($"There are {dictionary.Count} students");
//Console.WriteLine($"Ali fee status is {dictionary.Item("Ali")}");

//dictionary.Clear();

#endregion

#region Hashtable

Hashtable symbols = new Hashtable(25);

symbols.Add("salary", 10000);
symbols.Add("name", "Davis");
symbols.Add("age", 45);
symbols.Add("dept", "Information Technology");
symbols.Add("gender", "Male");

Console.WriteLine("The keys are: ");
foreach (var key in symbols.Keys)
    Console.WriteLine(key);
Console.WriteLine();

Console.WriteLine("The values are: ");
foreach (var val in symbols.Values)
    Console.WriteLine(val);
Console.WriteLine();

Console.WriteLine("The Data is: ");
foreach (var symbol in symbols)
    Console.WriteLine(symbol);
Console.WriteLine();
#endregion

#region Left Rotation of Array by 1
//Collection numbers = new Collection();
//Random random = new Random(101);

//for (int i = 0; i <= 10; i++)
//{
//    numbers.Add((int)(random.NextDouble() * 100));
//}
////Print before sorting
//printArray(numbers);
//Stopwatch stopwatch = Stopwatch.StartNew();
//stopwatch.Start();
////Sorting Array
//numbers.LeftRotationByOne();
//stopwatch.Stop();
//Console.WriteLine($"Elapsed Time: {stopwatch.Elapsed}");

////Print After sorting
//printArray(numbers);
//Console.ReadLine();
#endregion



static void printArray(Collection list)
{
    Console.WriteLine("----------------------------------");
    string printData = "";
    foreach (int i in list) printData += ", " + i;

    Console.WriteLine(printData);
}