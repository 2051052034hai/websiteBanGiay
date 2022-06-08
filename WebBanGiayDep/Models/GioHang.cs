﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanGiayDep.Models
{
    public class GioHang
    {
        dbShopGiayDataContext data = new dbShopGiayDataContext();
        public int iMaGiay { set; get; }
        public int iSize { get; set; }
        public string sTenGiay { set; get; }
        public string sAnhBia { set; get; }
        public Double dGiaBan { set; get; }
        public int iSoLuong { set; get; }
        public Double dThanhTien
        {
            get { return iSoLuong * dGiaBan; }
        }
        public GioHang(int MaGiay)
        {
            iMaGiay = MaGiay;
            SANPHAM GIAY = data.SANPHAMs.Single(n => n.MaGiay == iMaGiay);
            sTenGiay = GIAY.TenGiay;
            sAnhBia = GIAY.AnhBia;
            iSize = GIAY.Size;
            dGiaBan = double.Parse(GIAY.GiaBan.ToString());
            iSoLuong = 1;
        }
    }
}