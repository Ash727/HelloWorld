using Methods;
using Methods.ANewPath;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//var value = SamppleMethods.Add(5 + 7, 2);

Console.WriteLine(SamppleMethods.GetGoogleHomePage());
Console.ReadLine();

//(string firstName, string lastName)  = Path2.GetFullName();

// Discard character (_)
//(string firstName, _) = Path2.GetFullName();

(string firstName, string lastName) = Path2.GetFullName();


Console.WriteLine($"Full Name:{firstName} {lastName}");
