using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchoolProject2
{
    internal class TeacherManager
    {
        private List<Teacher> teachers;

        public TeacherManager()
        {
            teachers = FileHandler.ReadTeachersFromFile();
        }

        public void AddTeacher(Teacher teacher)
        {
            teacher.ID = teachers.Count + 1;
            teachers.Add(teacher);
            FileHandler.WriteTeachersToFile(teachers);
            Console.WriteLine("Teacher added successfully.");
        }

        public void UpdateTeacher(int id, Teacher updatedTeacher)
        {
            var teacherToUpdate = teachers.Find(t => t.ID == id);

            if (teacherToUpdate != null)
            {
                teacherToUpdate.Name = updatedTeacher.Name;
                teacherToUpdate.ClassSection = updatedTeacher.ClassSection;
                FileHandler.WriteTeachersToFile(teachers);
                Console.WriteLine("Teacher updated successfully.");
            }
            else
            {
                Console.WriteLine($"Teacher with ID {id} not found.");
            }
        }

        public void DeleteTeacher(int id)
        {
            var teacherToDelete = teachers.Find(t => t.ID == id);

            if (teacherToDelete != null)
            {
                teachers.Remove(teacherToDelete);
                FileHandler.WriteTeachersToFile(teachers);
                Console.WriteLine("Teacher deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Teacher with ID {id} not found.");
            }
        }

        public void ViewTeachers()
        {
            Console.WriteLine("Teacher List:");
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"{teacher.ID} - {teacher.Name} - {teacher.ClassSection}");
            }
        }
    }
}
