// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

int [] feld = new int [int.MaxValue-1000000];
Random rnd = new Random ();
Stopwatch stopwatch = new Stopwatch ();
stopwatch.Start ();
for (int i = 0; i < feld.Length; i++)
{
    feld[i] = rnd.Next (int.MinValue, int.MaxValue);
}


stopwatch.Stop();
var Duration = stopwatch.Elapsed.TotalMilliseconds;

Console.WriteLine ($"Duration: {Duration}");