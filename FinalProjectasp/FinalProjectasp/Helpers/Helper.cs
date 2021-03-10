using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.Helpers
{
    public static class Helper
    {
        public static bool DeleteImage(string root,string folder,string fileName)
        {
            string deletedPath = Path.Combine(root, folder, fileName);
            if (System.IO.File.Exists(deletedPath))
            {
                System.IO.File.Delete(deletedPath);
                return true;
            }
            return false;
        }
    }

    public enum Roles
    {
        Admin,
        Member
    }
}
