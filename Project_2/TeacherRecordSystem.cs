using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
    
namespace Project_2
{
    public class TeacherRecordSystem
    {
        private const string FileName = "teacher_records.txt";

        public List<Teacher> Teachers { get; set; }

        public TeacherRecordSystem()
        {
            Teachers = new List<Teacher>();
            LoadData();
        }

        public void AddTeacher(Teacher teacher)
        {
            teacher.ID = Teachers.Count + 1;
            Teachers.Add(teacher);
            SaveData();
        }

        public Teacher GetTeacherById(int id)
        {
            return Teachers.FirstOrDefault(t => t.ID == id);
        }

        private void LoadData()
        {
            if (File.Exists(FileName))
            {
                var lines = File.ReadAllLines(FileName);
                Teachers = lines.Select(line =>
                {
                    var parts = line.Split(',');
                    return new Teacher
                    {
                        ID = int.Parse(parts[0]),
                        Name = parts[1],
                        ClassAndSection = parts[2]
                    };
                }).ToList();
            }
        }

        private void SaveData()
        {
            var lines = Teachers.Select(teacher => teacher.ToString());
            File.WriteAllLines(FileName, lines);
        }
    }

}
