//Задача 19: 

Console.WriteLine("Input num: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 1000 && N < 10000);
{
    int First = (N / 10000) % 10;
    int Second = (N / 1000) % 10;
    int Third = (N / 100) % 10;
    int Fourth = (N / 10) % 10;
    int Fifth = (N / 1) % 10;
    if (Second == Fourth && First == Fifth)
    {
        Console.WriteLine("Pal");
    }
    else if(Second != Fourth && First != Fifth)
    {
        Console.WriteLine("NoPal");
    }
}

//2

/*
int x1 = Input("Add x1: ");
int y1 = Input("Add y1: ");
int z1 = Input("Add z1: ");
int x2 = Input("Add x2: ");
int y2 = Input("Add y2: ");
int z2 = Input("Add z2: ");
int linex = x2 - x1;
int liney = y2 - y1;
int linez = z2 - z1;
Console.WriteLine(Math.Sqrt((linex * linex) + (liney * liney) + linez * linez));
int Input(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}
*/


//3

/*
int Cube (int a)
{
    return a * a * a;
}
Console.WriteLine("Add num N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count < n)
{
    int sq = Cube(count);
    count ++;
    Console.Write($"{sq}, ");
}
Console.WriteLine(Cube(n));
*/