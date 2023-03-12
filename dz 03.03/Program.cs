using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz03_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1
            /*string Str1 = "ahb acb aeb aeeb adcb axeb";
            string Pattern1 = @"([a])(\w)([b])";
            Regex Reg1 = new Regex(Pattern1);
            Match M1 = Reg1.Match(Str1);
            while (M1.Success) {
                Console.WriteLine(M1.Groups[0]);
                M1 = M1.NextMatch();
            }*/
            

            //ex2
            /*string Str2 = "aba aca aea abba adca abea";
            string Pattern2 = @"([a])(\w{2})([a])";
            Regex Reg2 = new Regex(Pattern2);
            Match M2 = Reg2.Match(Str2);
            while (M2.Success) {
                Console.WriteLine(M2.Groups[0]);
                M2 = M2.NextMatch();
            }*/
            

            //ex3
            /*string Str3 = "aba aca aea abba adca abea";
            string Pattern3 = @"([a])([b])(\w)([a])";
            Regex Reg3 = new Regex(Pattern3);
            Match M3 = Reg3.Match(Str3);
            while (M3.Success) {
                Console.WriteLine(M3.Groups[0]);
                M3 = M3.NextMatch();
            }*/
            

            //ex4
            /*string Str4 = "aa aba abba abbba abca abea";
            string Pattern4 = @"([a])([b]+)([a])";
            Regex Reg4 = new Regex(Pattern4);
            Match M4 = Reg4.Match(Str4);
            while (M4.Success) {
                Console.WriteLine(M4.Groups[0]);
                M4 = M4.NextMatch();
            }*/
            

            //ex5
            /*string Str5 = "aa aba abba abbba abca abea";
            string Pattern5 = @"([a])([b]+)?([a])";
            Regex Reg5 = new Regex(Pattern5);
            Match M5 = Reg5.Match(Str5);
            while (M5.Success) {
                Console.WriteLine(M5.Groups[0]);
                M5 = M5.NextMatch();
            }*/
            


            //ex7
            /*string Str7 = "aa aba abba abbba abca abea";
            string Pattern7 = @"([a])([b]+)?([a])";
            Regex Reg7 = new Regex(Pattern7);
            Match M7 = Reg7.Match(Str7);
            while (M7.Success) {
                Console.WriteLine(M7.Groups[0]);
                M7 = M7.NextMatch();
            }*/
            

            //ex8
            /*string Str8 = "ab abab abab abababab abea";
            string Pattern8 = @"((ab)+)";
            Regex Reg8 = new Regex(Pattern8);
            Match M8 = Reg8.Match(Str8);
            while (M8.Success) {
                Console.WriteLine(M8.Groups[0]);
                M8 = M8.NextMatch();
            }*/
            

        }
    }
}