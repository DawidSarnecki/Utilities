
namespace JsonSerializer
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            Data foo = new Data
            {
                Names = new List<string>
                {
                    "test1",
                    "test2"
                },
                Persons = new List<string>
                {
                    "test",
                    "rrrrrrrrrrrrr"
                },
                Proffession = new List<string>
                {
                   "eeeeeeeeeeeee",
                   "eeeeeeeeeee"
                },
                Roles = new List<string>
                {
                    "test1",
                    "test2"
                }
            };

            Data fooFoo = new Data {
                Datas = new List<Data>()
                {
                    foo,
                    foo,
                    foo
   
                },
                Names = new List<string>
                {
                    "test1",
                    "test2"
                },
                Persons = new List<string>
                {
                    "test",
                    "rrrrrrrrrrrrr"
                },
                Proffession = new List<string>
                {
                   "eeeeeeeeeeeee",
                   "eeeeeeeeeee"
                },
                Roles = new List<string>
                {
                    "test1",
                    "test2"
                }
            };

            string result = JsonConvert.SerializeObject(fooFoo, Formatting.Indented);
            Console.WriteLine(result);
            string path = @"output.json";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(result);
            }
        }
    }
}
