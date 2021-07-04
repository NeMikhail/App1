using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            string output;
            string input = "1234,fr.yhb ewyy";
            Service.PrintToFile("P:/C#_Prj/repos/App1/", "Test", input);
            output = Service.ReadFromFile("P:/C#_Prj/repos/App1/", "Test");
            Console.WriteLine(output);
            char[] chars = new char[3];
            chars[0] = ',';
            chars[1] = '.';
            chars[2] = ' ';
            string[] spl;
            spl = Service.Splitter(input, chars);
            Service.PrintArray(spl);

            output = Service.Uniter(spl);
            Console.WriteLine(output);
            Service.Pause();

        }
    }
}
