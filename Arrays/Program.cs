
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] firstNames = new string[]
{
    "cloud", "Tiffa", "Yuna", "Aries"
};
string[,] board = new string[4, 4];
Weapons.types[,] weaponGallery = new Weapons.types[10, 10];
weaponGallery[0 , 1] = Weapons.types.bullet;
string a = "am,pm";

int[] ages = new int[] { 1, 2, 3 };

Dictionary<string, int> weoponsDataBase = new Dictionary<string, int>();
weoponsDataBase.Add("sword", 1);
weoponsDataBase.Add("gun", 23);
Console.WriteLine($"I've got a {weoponsDataBase.Keys.First()}");
public static class Weapons
{
public enum types {
bullet,
sword,
magma 
};
}


