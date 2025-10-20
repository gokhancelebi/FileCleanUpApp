
using System.Data;

namespace FileCleanupApp.src
{
    class FileCleanupAppCommand
    {
        public FileCleanupAppCommand(string folderPath, int dayLimit)
        {
            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("Belirtilen klasör bulunamadı");
                return;
            }

            Console.WriteLine($"Klasör taranıyor: {folderPath}");
            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                try
                {
                    DateTime lastWriteTime = File.GetLastWriteTime(file);
                    if (lastWriteTime < (DateTime.Now.AddDays(-dayLimit)))
                    {
                        File.Delete(file);
                        Console.WriteLine($"Silindi {file}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Dosya silinemedi {file}");
                    Console.WriteLine($"Hata: {ex.Message}");
                }
            }

            Console.WriteLine("Temizlik tamamlandı.");
        }
    }
}