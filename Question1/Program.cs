namespace Question1
{
    public class Program
    {
        public static void Main()
        {
            // Get the first 10 files
            DriveInfo driveInfo = new DriveInfo(@"C:\");
            DirectoryInfo directoryInfo = driveInfo.RootDirectory;
            var nameOfFirst10Files = directoryInfo.GetFiles().
                Select(file => file.Name).Take(10);
            foreach (var fileName in nameOfFirst10Files)
            {
                Console.WriteLine(fileName);
            }


            // Get the first 10 folders
            var dir = new DirectoryInfo(@"C:\");
            var folders = dir.GetDirectories()
                .Select(folder => folder.Name.ToString()).Take(10); //Directory.GetDirectories(@"C:\").Take(10);
            foreach (var folder in folders)
            {
                Console.WriteLine(folder);
            }
        }
    }
}