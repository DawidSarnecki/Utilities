using System;
using System.IO;

namespace TextTemplateFileGenerator
{
    public class FileManager
    {
        public static string ReadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Given file: \"{filePath}\" does not exist!");
            }

            using (StreamReader streamReader = new StreamReader(filePath))
            {
                string line = streamReader.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    throw new FileLoadException($"Given file:\"{filePath}\" is empty or interrupted!");
                }

                return line;
            }
        }

        // source https://msdn.microsoft.com/pl-pl/library/system.io.streamwriter(v=vs.110).aspx
        public static void WriteToFileExample()
        {
            // Get the directories currently on the C drive.
            DirectoryInfo[] directories = new DirectoryInfo(@"c:\").GetDirectories();

            // Write name of each directory to a specific file.
            using (StreamWriter streamWriter = new StreamWriter("MyExampleFile.txt"))
            {
                foreach (DirectoryInfo dir in directories)
                {
                    streamWriter.WriteLine(dir.FullName);
                }
            }
        }

        // source https://msdn.microsoft.com/pl-pl/library/system.io.streamwriter(v=vs.110).aspx
        public static void ReadFromFileExample()
        {
            using (StreamReader streamReader = new StreamReader("MyExampleFile.txt"))
            {
                while (!streamReader.EndOfStream)
                {
                    Console.WriteLine(streamReader.ReadLine());
                }
            }

            // alternative version
            using (StreamReader streamReader = new StreamReader("MyExampleFile.txt"))
            {
                string line = string.Empty;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
