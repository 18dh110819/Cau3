using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau3
{
    public class CompositeNuoc : INuocGiaiKhat
    {
        List<INuocGiaiKhat> dsNuoc = new List<INuocGiaiKhat>();
        public string TenHang { get; set; }
        public string Loai { get; set; }

        public string DisplayDetail()
        {
            string result = "";
            foreach (INuocGiaiKhat e in dsNuoc)
            {
                result += e.DisplayDetail();
            }
            return $"{Loai}\n{result}";
        }
        public void AddNuoc(INuocGiaiKhat nuoc)
        {
            dsNuoc.Add(nuoc);
        }
        public void RemoveNuoc(INuocGiaiKhat nuoc, string ten)
        {
            dsNuoc.Remove(nuoc);
        }
    }
}
