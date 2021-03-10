using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Extentions
{
    public static class Extention
    {
        public static bool IsSelectedType(this IFormFile file,string fileType)
        {
            return file.ContentType.Contains(fileType);
        }

        public static bool CheckMaxLenght(this IFormFile file,int kb)
        {
            return file.Length/1024 >= kb;
        }

        public async static Task<string> SaveImageAsync(this IFormFile file,string root,string folder)
        {
            string path = Path.Combine(root, folder);
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            string result = Path.Combine(path, fileName);

            using (FileStream fileStream = new FileStream(result, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return fileName;
        }
    }
}
