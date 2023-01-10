
// Aggregate
int[] numbers = { 1, 2, 3, 4, 5};
var factorial = numbers.Aggregate((x, y) => x * y);
Console.WriteLine($"factorial of numbers is [{factorial}] using Aggregate");

string[] words = { "I", "am", "here" };
var concated = words.Aggregate((x, y) => $"{x} {y}");
Console.WriteLine($"concated of words is [{concated}] using Aggregate");

Console.WriteLine($"--------------------------------------------------------");

// GroupBy
var myClasses = new List<MyClass>()
{
    new(){ Name = "Behzad", City = "Tehran", Age = 24},
    new(){ Name = "Ali", City = "Mashhad", Age = 25},
    new(){ Name = "Mehdi", City = "Mashhad", Age = 22},
    new(){ Name = "Milad", City = "Tehran", Age = 22},
    new(){ Name = "Amir", City = "Tabriz", Age = 24},
};
var groups = myClasses.GroupBy(x => x.Age);
Console.WriteLine($"groups of myclasses using GroupBy");
foreach (var group in groups)
{
    Console.WriteLine($"number of age {group.Key} is {group.Count()}");
    foreach(var item in group)
    {
        Console.WriteLine($"{item.Name} from {item.City}");
    }
    Console.WriteLine();
}

Console.WriteLine($"--------------------------------------------------------");

// SequenceEqual
string[] array1 = { "hi", "there" };
string[] array2 = { "Hi", "There" };
var result1 = array1.SequenceEqual(array2);
var result2 = array1.SequenceEqual(array2, StringComparer.OrdinalIgnoreCase);
Console.WriteLine($"compare of array1 and array2 is [{result1}] (case sensitive) using SequenceEqual");
Console.WriteLine($"compare of array1 and array2 is [{result2}] (ignore case) using SequenceEqual");

Console.WriteLine($"--------------------------------------------------------");

// Concat
var concat = array1.Concat(array2);
Console.WriteLine($"concat of array1 and array2 using Concat");
foreach(var item in concat)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

Console.WriteLine($"--------------------------------------------------------");

// Range
var range = Enumerable.Range(100, 10);
Console.WriteLine($"range of numbers in Enumerable");
foreach (var item in range)
{
    Console.Write($"{item}, ");
}
Console.WriteLine();

Console.WriteLine($"--------------------------------------------------------");

// Repeat
var repeat = Enumerable.Repeat(100, 10);
Console.WriteLine($"repeat of numbers in Enumerable");
foreach (var item in repeat)
{
    Console.Write($"{item}, ");
}
Console.WriteLine();

Console.WriteLine($"--------------------------------------------------------");




class MyClass
{
    public string Name { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public int Age { get; set; }
}