using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Class
{
    public static class Constant
    {
        public static int CompanyID ;
        public static int ApplicantID;
        public static string  appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
    }
}
