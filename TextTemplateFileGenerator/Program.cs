using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextTemplateFileGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "injectedVersionNumber.txt";

            try
            {
                string readLine = FileManager.ReadFromFile(test);
                Console.WriteLine(readLine);
                List<ushort> parsedValues = UshortParser.Parse(readLine);
                Console.WriteLine($"{parsedValues[0]}.{parsedValues[1]}.{parsedValues[3]}");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
            catch (FileLoadException e)
            {
                Console.WriteLine(e);
            }
            catch (ArgumentException e )
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
