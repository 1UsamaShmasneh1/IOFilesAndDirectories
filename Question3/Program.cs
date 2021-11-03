using Newtonsoft.Json;
using System.Text;

namespace Question3
{
    public class Student
    {
        public string ID {  get; set; }
        public string FirstName {  get; set; }
        public string LastName {  get; set; }
        public string Class {  get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { ID = "7821", FirstName = "usama" });
            var stringStudentJson = JsonConvert.SerializeObject(students);
            File.WriteAllText(@"C:\Users\u_050\Desktop\usama_project\IOFilesAndDirectories\MyFile.json", stringStudentJson);
        }
    }
}