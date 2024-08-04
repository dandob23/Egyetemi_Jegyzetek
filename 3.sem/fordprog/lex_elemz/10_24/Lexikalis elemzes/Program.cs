using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lexikalis_elemzes
{
    internal class Program
    {
        //public void lexer()
        //{
        //    string patternNumb = @"([0-9]+)";
        //    string patternVar = @"([a-z-_]+)";

        //    content = Regex.Replace(content, patternNumb, findAndReplaceSymbolTableContent("@1");

        //    content = Regex.Replace(content, patternVar, findAndReplaceSymbolTableContent("@1")

        //}

        static void Main(string[] args)
        {
            string patternNumb = @"([0-9]+)";
            string patternVar = @"([a-z-_]+)";
            string input = "IF (a==2) {b=6}";
            string replaceNumb = "CONST[$1]";
            string replaceVar = "VAR[$1]";
            Console.WriteLine("The original input is: \n\n{0}\n", input);   //eredmeny IF (VAR[a]==CONST[2]) {VAR[b]=CONST[6]}

            string result = Regex.Replace(input, patternNumb, replaceNumb);
            result = Regex.Replace(input, patternVar, replaceVar);
            Console.WriteLine(content);




            Console.ReadKey();
        }
    }
}
