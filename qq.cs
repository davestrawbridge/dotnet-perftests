using System;
using System.Linq;
using System.Diagnostics;
using System.Text.RegularExpressions;

class Q {
    static void Main() {
        
        var sw = new Stopwatch();
        
        sw.Start();
        
        int theNumber = 0;
        
        
        var r = new Random();
        
        var numbers = Enumerable.Range(0, 1000000).Select(x => r.Next(1234).ToString().Replace("1", "Q")).ToArray();
        
        foreach (var n in numbers) {
            if (Regex.Match(n, @"^(\+|-)?[0-9]*$").Success)
                 theNumber = Convert.ToInt32(n); // or int - also wrap in something

        }
        
        sw.Stop();
        
        Console.WriteLine("regex {0}", sw.ElapsedMilliseconds);

        sw.Restart();

        foreach (var n in numbers) {
            int.TryParse(n, out theNumber);
        }
        
        sw.Stop();
        
        Console.WriteLine("tryparse {0}", sw.ElapsedMilliseconds);
    }
}