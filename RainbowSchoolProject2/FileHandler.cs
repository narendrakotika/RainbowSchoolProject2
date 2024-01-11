using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace RainbowSchoolProject2
{
    internal class FileHandler
    {
    

        private const string FilePath = "teachers.txt";

        public static List<Teacher> ReadTeachersFromFile()
        {
            List<Teacher> teachers = new List<Teacher>();

            if (File.Exists(FilePath))
            {
                string[] lines = File.ReadAllLines(FilePath);

                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        teachers.Add(new Teacher
                        {
                            ID = int.Parse(parts[0]),
                            Name = parts[1],
                            ClassSection = parts[2]
                        });
                    }
                }
            }

            return teachers;
        }

        public static void WriteTeachersToFile(List<Teacher> teachers)
        {
            List<string> lines = new List<string>();

            foreach (var teacher in teachers)
            {
                lines.Add($"{teacher.ID},{teacher.Name},{teacher.ClassSection}");
            }

            File.WriteAllLines(FilePath, lines);
        }
    }

}
       
    

