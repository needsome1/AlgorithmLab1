using System.Diagnostics;
Stopwatch sw = Stopwatch.StartNew(); sw.Start();
Random rand = new Random(); int n = rand.Next(10, 50000000);
int[] array = new int[n];
int even = 0;
int odd = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next();
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        even++;
    }
    if (array[i] % 2 != 0)
    {
        odd++;
    }
}
sw.Stop();
Console.WriteLine($"{n} размер одономерного массива");
Console.WriteLine($"{even} четных чисел");
Console.WriteLine($"{odd} нечетных чисел");
Console.WriteLine($"{sw.ElapsedMilliseconds} времени потрачено в мс");
