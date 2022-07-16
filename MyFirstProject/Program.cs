using System.IO;
using System.Net;
using MyFirstProject;
using Newtonsoft.Json; 

    EmptyClass em = new EmptyClass();
em.someEvent += mehod1;
em.method();

void mehod1(object? sender, int e)
{
    Console.WriteLine(DateTime.Now);
}


Console.WriteLine("Hello, World!");
Console.Write("What is your name:");
//Console.WriteLine("What is your name:" + Console.ReadLine());
 var name = Console.ReadLine();
Console.WriteLine($" Your name is {name}");
var apply = true;
if (apply)
{
    Console.WriteLine($"Wheres the FOOD? {name}");

}
string filePath = Directory.GetCurrentDirectory();

//string filePath = @"C:\Temp\Demo\";
Console.WriteLine(filePath);

string v = Console.ReadLine();
//int age = int.Parse(v);
bool valid = int.TryParse(v, out int realAge2);
if (valid)
{
    Console.Write("All is valid yo");
}

Console.WriteLine($"Valid {valid} and realAge : { realAge2 }");

LinkedList<string> boys = new LinkedList<string>();

var first = boys.AddLast("Tim");
boys.AddLast("mark");
boys.AddLast("Billy");
var pointer = boys.First;

while (pointer != null)
{
    Console.WriteLine(pointer.Value);
    pointer = pointer.Next; 
}
int someInt = 0;
double a = someInt;
bool testdecimal =  decimal.TryParse( a.ToString(), out decimal count) ;

Console.Write("What year were you born?");
string year = Console.ReadLine();
bool isValidAge = int.TryParse(year, out int outPutAge );

if (isValidAge)
{
    DateTime dateTime = (new DateTime(outPutAge, 08, 04));
    var birthDate = (DateTime.Now - dateTime);

    Console.WriteLine($"You are {birthDate}");
    if ((outPutAge - 25) < 0)
    {
        Console.WriteLine("You werent Born yet ");
    }
    else
    {
        Console.WriteLine($"25 years ago you were be { outPutAge - 25 }");
    }
    Console.WriteLine($"25 years in the future you will be { outPutAge + 25}");


}

Console.ReadLine();
var lines = File.ReadAllLines("");


JsonSerializer serializer = new JsonSerializer();
EmptyClass obj;
using (var reader = new StreamReader("gibby.json"))
using (var JReader = new JsonTextReader(reader))
{
    obj = serializer.Deserialize<EmptyClass>(JReader);

}

//using (var jsonReader = new JSONTextReader()