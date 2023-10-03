#nullable enable
using System;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace MvcDemo.PL.Helper
{
    public static class DocumentSetting
    {
        public static string UploadFile(IFormFile file, string folderName)
        {
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files", folderName);
            var fileName =$"{Guid.NewGuid()} {Path.GetFileName(file.FileName)}";
            var filePath = Path.Combine(folderPath, fileName);
            using var fileStream = new FileStream(filePath, FileMode.Create);
            file.CopyTo(fileStream);
            return fileName;
        }

        public static void DeleteFile(string fileName, string folderName)
        {
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files", folderName);
            //if (!string.IsNullOrEmpty(folderPath))
            //{
            var filePath = Path.Combine(folderPath, fileName);
            // rest of the code
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            //}

        }
    }
}
