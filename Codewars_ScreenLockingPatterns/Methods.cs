using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_ScreenLockingPatterns
{
    public class Methods
    {
        public static string DotOptions(char dot, string dotPath)
        {
            var dotOptions = "";
            switch (dot)
            {
                case 'A': 
                    dotOptions += dotPath.Contains('B') ? dotPath.Contains('C') ? "" : "C" : "B";
                    dotOptions += dotPath.Contains('D') ? dotPath.Contains('G') ? "" : "G" : "D";
                    dotOptions += dotPath.Contains('E') ? dotPath.Contains('I') ? "" : "I" : "E";
                    dotOptions += dotPath.Contains('F') ? "" : "F";
                    dotOptions += dotPath.Contains('H') ? "" : "H";
                    break; 
                case 'B':
                    dotOptions += dotPath.Contains('A') ? "" : "A";
                    dotOptions += dotPath.Contains('C') ? "" : "C";
                    dotOptions += dotPath.Contains('D') ? "" : "D";
                    dotOptions += dotPath.Contains('F') ? "" : "F";
                    dotOptions += dotPath.Contains('G') ? "" : "G";
                    dotOptions += dotPath.Contains('I') ? "" : "I";
                    dotOptions += dotPath.Contains('E') ? dotPath.Contains('H') ? "" : "H" : "E";
                    break;
                case 'C':
                    dotOptions += dotPath.Contains('B') ? dotPath.Contains('A') ? "" : "A" : "B";
                    dotOptions += dotPath.Contains('F') ? dotPath.Contains('I') ? "" : "I" : "F";
                    dotOptions += dotPath.Contains('E') ? dotPath.Contains('G') ? "" : "G" : "E";
                    dotOptions += dotPath.Contains('D') ? "" : "D";
                    dotOptions += dotPath.Contains('H') ? "" : "H";
                    break;
                case 'D':
                    dotOptions += dotPath.Contains('A') ? "" : "A";
                    dotOptions += dotPath.Contains('B') ? "" : "B";
                    dotOptions += dotPath.Contains('C') ? "" : "C";
                    dotOptions += dotPath.Contains('G') ? "" : "G";
                    dotOptions += dotPath.Contains('H') ? "" : "H";
                    dotOptions += dotPath.Contains('I') ? "" : "I";
                    dotOptions += dotPath.Contains('E') ? dotPath.Contains('F') ? "" : "F" : "E";
                    break;
                case 'E':
                    dotOptions += dotPath.Contains('A') ? "" : "A";
                    dotOptions += dotPath.Contains('B') ? "" : "B";
                    dotOptions += dotPath.Contains('C') ? "" : "C";
                    dotOptions += dotPath.Contains('D') ? "" : "D";
                    dotOptions += dotPath.Contains('F') ? "" : "F";
                    dotOptions += dotPath.Contains('G') ? "" : "G";
                    dotOptions += dotPath.Contains('H') ? "" : "H";
                    dotOptions += dotPath.Contains('I') ? "" : "I";
                    break;
                case 'F':
                    dotOptions += dotPath.Contains('A') ? "" : "A";
                    dotOptions += dotPath.Contains('B') ? "" : "B";
                    dotOptions += dotPath.Contains('C') ? "" : "C";
                    dotOptions += dotPath.Contains('G') ? "" : "G";
                    dotOptions += dotPath.Contains('H') ? "" : "H";
                    dotOptions += dotPath.Contains('I') ? "" : "I";
                    dotOptions += dotPath.Contains('E') ? dotPath.Contains('D') ? "" : "D" : "E";
                    break;
                case 'G':
                    dotOptions += dotPath.Contains('D') ? dotPath.Contains('A') ? "" : "A" : "D";
                    dotOptions += dotPath.Contains('H') ? dotPath.Contains('I') ? "" : "I" : "H";
                    dotOptions += dotPath.Contains('E') ? dotPath.Contains('C') ? "" : "C" : "E";
                    dotOptions += dotPath.Contains('B') ? "" : "B";
                    dotOptions += dotPath.Contains('F') ? "" : "F";
                    break;
                case 'H':
                    dotOptions += dotPath.Contains('A') ? "" : "A";
                    dotOptions += dotPath.Contains('C') ? "" : "C";
                    dotOptions += dotPath.Contains('D') ? "" : "D";
                    dotOptions += dotPath.Contains('F') ? "" : "F";
                    dotOptions += dotPath.Contains('G') ? "" : "G";
                    dotOptions += dotPath.Contains('I') ? "" : "I";
                    dotOptions += dotPath.Contains('E') ? dotPath.Contains('B') ? "" : "B" : "E";
                    break;
                case 'I':
                    dotOptions += dotPath.Contains('H') ? dotPath.Contains('G') ? "" : "G" : "H";
                    dotOptions += dotPath.Contains('F') ? dotPath.Contains('C') ? "" : "C" : "F";
                    dotOptions += dotPath.Contains('E') ? dotPath.Contains('A') ? "" : "A" : "E";
                    dotOptions += dotPath.Contains('D') ? "" : "D";
                    dotOptions += dotPath.Contains('B') ? "" : "B";
                    break;
            }
            return dotOptions;
        }

        public static int CountPatternsFrom(char firstDot, int length)
        {
            if (length < 1 || length > 9) return 0;
            if (length == 1) return 1;

            if (length == 2)
            {
                switch (firstDot)
                {
                    case 'A': return 5;
                    case 'B': return 7;
                    case 'C': return 5;
                    case 'D': return 7;
                    case 'E': return 8;
                    case 'F': return 7;
                    case 'G': return 5;
                    case 'H': return 7;
                    case 'I': return 5;
                }
            }

            var count = 0;

            var dotPath = firstDot.ToString();

            var secondDotOptions = DotOptions(firstDot, dotPath);

            foreach (var dot in secondDotOptions)
            {
                dotPath += dot;
                if (length > 3)
                {
                    var thirdDotOptions = DotOptions(dot, dotPath);
                    foreach (var dot3 in thirdDotOptions)
                    {
                        dotPath += dot3;
                        if (length > 4)
                        {
                            var fourthDotOptions = DotOptions(dot3, dotPath);
                            foreach (var dot4 in fourthDotOptions)
                            {
                                dotPath += dot4;
                                if (length > 5)
                                {
                                    var fifthDotOptions = DotOptions(dot4, dotPath);
                                    foreach (var dot5 in fifthDotOptions)
                                    {
                                        dotPath += dot5;
                                        if (length > 6)
                                        {
                                            var sixthDotOptions = DotOptions(dot5, dotPath);
                                            foreach (var dot6 in sixthDotOptions)
                                            {
                                                dotPath += dot6;
                                                if (length > 7)
                                                {
                                                    var seventhDotOptions = DotOptions(dot6, dotPath);
                                                    foreach (var dot7 in seventhDotOptions)
                                                    {
                                                        dotPath += dot7;
                                                        if (length > 8)
                                                        {
                                                            var eigthDotOptions = DotOptions(dot7, dotPath);
                                                            foreach (var dot8 in eigthDotOptions)
                                                            {
                                                                dotPath += dot8;
                                                                count += DotOptions(dot8, dotPath).Length;
                                                                dotPath = dotPath.Remove(dotPath.Length - 1);
                                                            }
                                                            dotPath = dotPath.Remove(dotPath.Length - 1);
                                                        }
                                                        else
                                                        {
                                                            count += DotOptions(dot7, dotPath).Length;
                                                            dotPath = dotPath.Remove(dotPath.Length - 1);
                                                        }
                                                    }
                                                    dotPath = dotPath.Remove(dotPath.Length - 1);
                                                }
                                                else
                                                {
                                                    count += DotOptions(dot6, dotPath).Length;
                                                    dotPath = dotPath.Remove(dotPath.Length - 1);
                                                }
                                            }
                                            dotPath = dotPath.Remove(dotPath.Length - 1);
                                        }
                                        else
                                        {
                                            count += DotOptions(dot5, dotPath).Length;
                                            dotPath = dotPath.Remove(dotPath.Length - 1);
                                        }
                                    }
                                    dotPath = dotPath.Remove(dotPath.Length - 1);
                                }
                                else
                                {
                                    count += DotOptions(dot4, dotPath).Length;
                                    dotPath = dotPath.Remove(dotPath.Length - 1);
                                }
                            }
                            dotPath = dotPath.Remove(dotPath.Length - 1);
                        }
                        else
                        {
                            count += DotOptions(dot3, dotPath).Length;
                            dotPath = dotPath.Remove(dotPath.Length - 1);
                        }
                    }
                    dotPath = dotPath.Remove(dotPath.Length - 1);
                }
                else
                {
                    count += DotOptions(dot, dotPath).Length;
                    dotPath = dotPath.Remove(dotPath.Length - 1);
                }
            }

            return count;
        }
    }
}
