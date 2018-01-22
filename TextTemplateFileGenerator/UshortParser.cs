using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TextTemplateFileGenerator
{
    public class UshortParser
    {
        // source: https://msdn.microsoft.com/en-us/library/byy2946e(v=vs.110).aspx
        public static List<ushort> Parse(string line)
        {
            const int AMOUNT_lIMIT = 4;
            //there is a parser for string format like: "12222.5858.668.25"
            string splitPattern = "[.]";
            string[] splitResult = Regex.Split(line, splitPattern);
            List<ushort> parseResult = new List<ushort>();

            foreach (var item in splitResult)
            {
                ushort parsedValue;
                bool isParsed = ushort.TryParse(item, out parsedValue);
                if (!isParsed)
                {
                    throw new ArgumentException($"Icorrect value \"{item}\"! This value have to be from scope <{ushort.MinValue},{ushort.MaxValue}>.");
                }
                parseResult.Add(parsedValue);
            }

            if (parseResult.Count != 4)
            {
                throw new ArgumentOutOfRangeException($"Icorrect amount of values! The limit is: {AMOUNT_lIMIT}");
            }

            return parseResult;
        }
    }
}
