﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace CMU.Module.BusinessObjects.ORMDataModel1
{

    [DefaultProperty("Hoten")]
    public partial class Nhanvien : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fHoten;
        public string Hoten
        {
            get { return fHoten; }
            set { SetPropertyValue<string>(nameof(Hoten), ref fHoten, value); }
        }
        string fDienthoai;
        public string Dienthoai
        {
            get { return fDienthoai; }
            set { SetPropertyValue<string>(nameof(Dienthoai), ref fDienthoai, value); }
        }
        double fMucluong;
        public double Mucluong
        {
            get { return fMucluong; }
            set { SetPropertyValue<double>(nameof(Mucluong), ref fMucluong, value); }
        }
        [Association(@"ChamcongReferencesNhanvien"), Aggregated]
        public XPCollection<Chamcong> Chamcongs { get { return GetCollection<Chamcong>(nameof(Chamcongs)); } }
        [Association(@"HoadonReferencesNhanvien"), Aggregated]
        public XPCollection<Hoadon> Hoadons { get { return GetCollection<Hoadon>(nameof(Hoadons)); } }
        [Association(@"BangluongReferencesNhanvien"), Aggregated]
        public XPCollection<Bangluong> Bangluongs { get { return GetCollection<Bangluong>(nameof(Bangluongs)); } }
        [Association(@"PhieuchiReferencesNhanvien"), Aggregated]
        public XPCollection<Phieuchi> Phieuchis { get { return GetCollection<Phieuchi>(nameof(Phieuchis)); } }
        [Association(@"PhieunhapReferencesNhanvien"), Aggregated]
        public XPCollection<Phieunhap> Phieunhaps { get { return GetCollection<Phieunhap>(nameof(Phieunhaps)); } }
    }

}
