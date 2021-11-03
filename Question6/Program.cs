namespace Question6
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
            string filePath = @"C:\Users\u_050\Desktop\usama_project\IOFilesAndDirectories\studentsCSV.csv";
            StreamReader reader = null;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                List<string> lines = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    lines.Add(line);                    
                }

                foreach(string line in lines)
                {
                    var propreties = line.Split(',');
                    students.Add(new Student() 
                        { 
                            ID = propreties[0],
                            FirstName = propreties[1], 
                            LastName = propreties[2], 
                            Class = propreties[3] 
                        });
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }
    }
}