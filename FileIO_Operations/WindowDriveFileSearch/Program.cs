using System;
using System.IO;

namespace WindowDriveFileSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.DriveType != DriveType.Network)
                    {
                       // Console.WriteLine($"{drive.Name}");
                        var driveName = drive.Name;
                       // DriveInfo info= new DriveInfo("D");
                        DirectoryInfo directory = new DirectoryInfo(driveName);
                        foreach (DirectoryInfo directoryInfo in directory.GetDirectories())
                        {
                            //Console.WriteLine($"\t{directoryInfo.Name}");
                            foreach (FileInfo file in directoryInfo.GetFiles())
                            {
                                //Console.WriteLine($"\t\t{file.Name}");
                                if (file.Extension == ".txt")
                                {
                                    Console.WriteLine($"\t{file.Name}");
                                }
                                                               }
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
