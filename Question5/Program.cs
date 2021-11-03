namespace Question5
{
    public class Student
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Class { get; set; }
        public string ToCSV()
        {
            string str;
            str = string.Format($"{ID},{FirstName},{LastName},{Class}");
            return str;
        }
    }
    public class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { ID = "7821", FirstName = "usama" });
            string str = "";
            foreach (var student in students)
            {
                str += student.ToCSV() + Environment.NewLine;
            }
            File.WriteAllText(@"C:\Users\u_050\Desktop\usama_project\IOFilesAndDirectories\studentsCSV.csv", str);
        }
    }
}