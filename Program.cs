// See https://aka.ms/new-console-template for more information

//https://www.youtube.com/watch?v=SQim2adwVJI

//dotnet build, run
Console.WriteLine("Hello, World! First commit");
int i = 123;
object o = i;
int j = (int)o;
Console.WriteLine(j);

logico();

void logico()
{
    int maxx = int.MaxValue;
    int minn = int.MinValue;
    string sr = "ääääääää";
    if (maxx > minn)
    {
        workNums();
        Console.WriteLine(sr);
    };


}

//workNums(); //<-----method invocation
void workNums()
{
    int counter = 0;
    string o = "----";
    int a = 7; int b = 4; int c = a + b;

    int d = (a + b) / c;
    int max = int.MaxValue; //  && MinValue
    double ww = 1.2 + max;
    Console.WriteLine(c + o + $"----: {d}" + max + o + ww);
    return;

}


while (i > 10)
{
    Console.WriteLine($"ll {i}");
    break;
}

var names = new List<string> { "<name>", "Ana", "Feppp" };
names.Add("Yessenia"); //Added
names.Remove(names[1]); //Adios Ana
var index = names.IndexOf("Feppp");
names.Sort(); // alphabetically
foreach (var iii in names)
{
    Console.WriteLine($"hui {iii.ToUpper()} and see {names[1]} now index ->" + index);
}
//Integers list
var numberz = new List<int> { 1, 1 };
var prev = numberz[numberz.Count - 1];
var prev2 = numberz[numberz.Count - 2];
numberz.Add(prev + prev2);
foreach (var inn in numberz)
{
    Console.WriteLine(inn);
}