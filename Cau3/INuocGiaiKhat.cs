using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau3
{
    public interface INuocGiaiKhat
    {
        string TenHang { get; set; }
        string Loai { get; set; }
        string DisplayDetail();
    }
}
