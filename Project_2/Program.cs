using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            TeacherRecordSystem recordSystem = new TeacherRecordSystem();

            
            Teacher newTeacher = new Teacher
            {
                Name = "John Doe",
                ClassAndSection = "ClassA"
            };
            recordSystem.AddTeacher(newTeacher);

            
            int teacherIdToRetrieve = 1;
            Teacher retrievedTeacher = recordSystem.GetTeacherById(teacherIdToRetrieve);

            if (retrievedTeacher != null)
            {
                Console.WriteLine($"Retrieved Teacher: {retrievedTeacher.Name}, {retrievedTeacher.ClassAndSection}");
            }
            else
            {
                Console.WriteLine($"Teacher with ID {teacherIdToRetrieve} not found.");
            }
        }
    }
}
