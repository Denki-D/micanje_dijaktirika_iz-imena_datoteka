using System;
using System.IO;


namespace dedijakritizacija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(@"D:\nazivi"); // u zagradama zamijeniti putanju direktorija
                FileInfo[] infos = d.GetFiles();
                foreach (FileInfo f in infos)
                {
                    File.Move(f.FullName, f.FullName
                      .Replace("č", "c").Replace("ć", "c").Replace("đ", "dj").Replace("š", "s").Replace("ž", "z")
                      .Replace("Č", "C").Replace("Ć", "C").Replace("Đ", "Dj").Replace("Š", "S").Replace("Ž", "Z")
                      .Replace(" ", "_"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}