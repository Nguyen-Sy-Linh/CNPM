using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class TienthuongNgoaitinh : ITienthuong
    {
        public double tinhTienThuong(double luongCB)
        {
            return luongCB * 0.15;
        }
    }
}
