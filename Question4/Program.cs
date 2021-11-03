using System.Collections;
using System.Data;

namespace Question4
{
    public class Student
    {
        public string ID { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
    }
    public class Program
    {
        public static void Main()
        {
            ArrayList students = new ArrayList();
            students.Add(new Student() { ID = "7821", FirstName = "usama" });
            string txt = string.Empty;
            DataTable studentsDT = new DataTable("Students");
            foreach(Student student in students)
            {
                studentsDT.Rows.Add($"{student.ID}", $"{student.FirstName}", $"{student.LastName}", $"{student.Class}");
            }
            string filepath = @"C:\Users\u_050\Desktop\usama_project\IOFilesAndDirectories\StudentsDT.txt";
            using (StreamWriter sw = new StreamWriter(filepath, false))
            {
                foreach (DataRow row in studentsDT.Rows)
                {
                    sw.WriteLine("{0,-9}{1,-10}{2,-8}{3}{4,-10}", row.ItemArray);
                }
            }


        }
    }
}