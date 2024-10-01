using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class TienthuongNgoaigio : ITienthuong
    {
        public double tinhTienThuong(double luongCB)
        {
            // logic code ..............
            return luongCB * 0.10;
        }
    }
}
