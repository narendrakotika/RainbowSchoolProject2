using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchoolProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                TeacherManager teacherManager = new TeacherManager();

                while (true)
                {
                    Console.WriteLine("1. Add Teacher");
                    Console.WriteLine("2. Update Teacher");
                    Console.WriteLine("3. Delete Teacher");
                    Console.WriteLine("4. View Teachers");
                    Console.WriteLine("5. Exit");

                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter teacher name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter class and section: ");
                            string classSection = Console.ReadLine();
                            teacherManager.AddTeacher(new Teacher { Name = name, ClassSection = classSection });
                            break;
                        case 2:
                            Console.Write("Enter teacher ID to update: ");
                            int updateId = int.Parse(Console.ReadLine());
                            Console.Write("Enter new name: ");
                            string updatedName = Console.ReadLine();
                            Console.Write("Enter new class and section: ");
                            string updatedClassSection = Console.ReadLine();
                            teacherManager.UpdateTeacher(updateId, new Teacher { Name = updatedName, ClassSection = updatedClassSection });
                            break;
                        case 3:
                            Console.Write("Enter teacher ID to delete: ");
                            int deleteId = int.Parse(Console.ReadLine());
                            teacherManager.DeleteTeacher(deleteId);
                            break;
                        case 4:
                            teacherManager.ViewTeachers();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                    Console.WriteLine();
                }
            }
        }

    }


