namespace Question2
{
    public class Program
    {
        public static void Main()
        {
            PrintBigestFiles("Desktop");
        }
        public static void PrintBigestFiles(string str)
        {           
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\u_050\" + str);
            var bigest3Files = directoryInfo.GetFiles().
                OrderByDescending(s => s.Length).Take(3);
            foreach(var file in bigest3Files)
            {
                Console.WriteLine($"{file.Name}, Last Change: {file.LastWriteTime}");
            }
        }
    }
}