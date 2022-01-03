using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau3
{
    public class NuocGiaiKhat : INuocGiaiKhat
    {
        public string TenHang { get; set; }
        public string Loai { get; set; }

        public string DisplayDetail()
        {
            return $"\t Ten: {TenHang} Loai: {Loai}\n";
        }
    }
}
