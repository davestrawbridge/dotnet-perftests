using System;
using System.Linq;
using System.Diagnostics;
using System.Text.RegularExpressions;

class Q {
    static void Main() {
        
        var sw = new Stopwatch();
        
        
        var r = new Random();
        
        var chars = Enumerable.Range(0, 10000000).Select(x => (char) (r.Next(256))).ToArray();
        
        sw.Start();

        bool b;
        foreach (var c in chars) {
             b = Whitespace.Contains(c);
        }
        
        sw.Stop();
        
        Console.WriteLine("Contains {0}", sw.ElapsedMilliseconds);

        sw.Restart();

        foreach (var c in chars) {
             b = IsWhitespace(c);
        }
        
        sw.Stop();
        
        Console.WriteLine("== {0}", sw.ElapsedMilliseconds);
    }
    
    private static readonly char[] Whitespace = {'\0', '\t', '\n', '\f', '\r', ' '};
    
    private static bool IsWhitespace(char c) {
        return c == '\0' || c == '\t' || c == '\n' || c == '\f' || c == '\r' || c == ' ';
    }
}