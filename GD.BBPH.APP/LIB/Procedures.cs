using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;
using GD.BBPH.LIB;

namespace GD.BBPH.APP.LIB
{
  public  class Procedures
    {
        private static Int32 timeout = 0;//1200;
        private static string ConnectionStringKeyName = LIB.SESSION_START.ConnectionStringKeyName;

        public static DataTable SELECT_TOP_MATHANGKHOHANG_BY_DMKHO_SYNC(string str_madmkho, int Trangthai, int Number_top)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madanhmuckho", SqlDbType.NVarChar, 500), str_madmkho);
            parameters.Add(new SqlParameter("@Trangthai", SqlDbType.Int, 0), Trangthai);
            parameters.Add(new SqlParameter("@Number_top", SqlDbType.Int, 0), Number_top);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "SELECT_TOP_MATHANGKHOHANG_BY_DMKHO_SYNC", "SELECT_TOP_MATHANGKHOHANG_BY_DMKHO_SYNC", myArr).Tables[0];
        }

        public static DataTable Loclenhsanxuatmanh(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Loclenhsanxuatmanh", "Loclenhsanxuatmanh", myArr).Tables[0];
        }
        public static DataTable Loclenhtrang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Loclenhtrang", "Loclenhtrang", myArr).Tables[0];
        }
        public static DataTable Loclenhin(DateTime Tungay, DateTime Denngay, string Mamanh, string Mauin)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Mamanh", SqlDbType.NVarChar, 0), Mamanh);
            parameters.Add(new SqlParameter("@Mauin", SqlDbType.NVarChar, 0), Mauin);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Loclenhin", "Loclenhin", myArr).Tables[0];
        }
        public static DataTable Loclenhsxsoi(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Loclenhsxsoi", "Loclenhsxsoi", myArr).Tables[0];
        }
        public static DataTable Loclenhhoanthien(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Loclenhhoanthien", "Loclenhhoanthien", myArr).Tables[0];
        }
        public static DataTable Loclenhpe(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Loclenhpe", "Loclenhpe", myArr).Tables[0];
        }
        public static DataTable Locdanhsachmaythuoclenhsanxuatmanh(DateTime Ngay, string Mamanh)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            parameters.Add(new SqlParameter("@Mamanh", SqlDbType.NVarChar, 0), Mamanh);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Locdanhsachmaythuoclenhsanxuatmanh", "Locdanhsachmaythuoclenhsanxuatmanh", myArr).Tables[0];
        }
        public static DataTable Lenhtrang(DateTime Ngaychay, string Mamaytrang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaychay", SqlDbType.Date, 0), Ngaychay);
            parameters.Add(new SqlParameter("@Mamaytrang", SqlDbType.NVarChar, 0), Mamaytrang);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Lenhtrang", "Lenhtrang", myArr).Tables[0];
        }
        public static DataTable Lenhin(DateTime Ngaychay, string Mamayin)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaychay", SqlDbType.Date, 0), Ngaychay);
            parameters.Add(new SqlParameter("@Mamayin", SqlDbType.NVarChar, 0), Mamayin);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Lenhin", "Lenhin", myArr).Tables[0];
        }
        public static DataTable Lenhsoi(DateTime Ngaychay, string Mamaysoi)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaychay", SqlDbType.Date, 0), Ngaychay);
            parameters.Add(new SqlParameter("@Mamaysoi", SqlDbType.NVarChar, 0), Mamaysoi);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Lenhsoi", "Lenhsoi", myArr).Tables[0];
        }
        public static DataTable Lenhhoanthien(DateTime Ngaychay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaychay", SqlDbType.Date, 0), Ngaychay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Lenhhoanthien", "Lenhhoanthien", myArr).Tables[0];
        }
        public static DataTable Lenhpe(DateTime Ngaychay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaychay", SqlDbType.Date, 0), Ngaychay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Lenhpe", "Lenhpe", myArr).Tables[0];
        }
        public static DataTable Lenhchaymayin(DateTime Ngaychay, string Mamayin)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaychay", SqlDbType.Date, 0), Ngaychay);
            parameters.Add(new SqlParameter("@Mamayin", SqlDbType.NVarChar, 0), Mamayin);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Lenhchaymayin", "Lenhchaymayin", myArr).Tables[0];
        }
        public static DataTable Danhsachmauin()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachmauin", "Danhsachmauin", myArr).Tables[0];
        }
        public static DataTable Danhsachcadet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachcadet", "Danhsachcadet", myArr).Tables[0];
        }
        public static DataTable Danhsachketquadet(DateTime Tungay, DateTime Denngay, string Macongnhan, string Mamanh)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Macongnhan", SqlDbType.NVarChar, 0), Macongnhan);
            parameters.Add(new SqlParameter("@Mamanh", SqlDbType.NVarChar, 0), Mamanh);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachketquadet", "Danhsachketquadet", myArr).Tables[0];
        }
        public static DataTable Danhsachcongnhandet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachcongnhandet", "Danhsachcongnhandet", myArr).Tables[0];
        }
        public static DataTable Danhsachmahanghoanthien(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachmahanghoanthien", "Danhsachmahanghoanthien", myArr).Tables[0];
        }
        public static DataTable Danhsachthanhphansoi()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachthanhphansoi", "Danhsachthanhphansoi", myArr).Tables[0];
        }
        public static DataTable Danhsachthanhphanpe()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachthanhphanpe", "Danhsachthanhphanpe", myArr).Tables[0];
        }
        public static DataTable Danhsachnguyenvatlieutrang()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnguyenvatlieutrang", "Danhsachnguyenvatlieutrang", myArr).Tables[0];
        }
        public static DataTable Danhsachcongdoan()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachcongdoan", "Danhsachcongdoan", myArr).Tables[0];
        }
        public static DataTable Danhsachketquasanxuatsoi(DateTime Tungay, DateTime Denngay, string Makhachhang, string Mamanh)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mamanh", SqlDbType.NVarChar, 0), Mamanh);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachketquasanxuatsoi", "Danhsachketquasanxuatsoi", myArr).Tables[0];
        }
        public static decimal Tinhkhoiluongphoitron(string Masoi, DateTime Ngayapdung)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Masoi", SqlDbType.NVarChar, 0), Masoi);
            parameters.Add(new SqlParameter("@Ngayapdung", SqlDbType.Date, 0), Ngayapdung);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);

            decimal gtri = Convert.ToDecimal(_SimpleStoredProcedure.ExecuteScalarSP("Tinhkhoiluongphoitron", myArr));
            return gtri;
        }
        public static DataTable Danhsachketquatrang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachketquatrang", "Danhsachketquatrang", myArr).Tables[0];
        }
        public static DataTable Danhsachdondathang(DateTime Tungay, DateTime Denngay, string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachdondathang", "Danhsachdondathang", myArr).Tables[0];
        }
        public static DataTable Danhsachdondathangchitiet(string Madondathang, DateTime Ngaylamviec)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madondathang", SqlDbType.NVarChar, 0), Madondathang);
            parameters.Add(new SqlParameter("@Ngaylamviec", SqlDbType.Date, 0), Ngaylamviec);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachdondathangchitiet", "Danhsachdondathangchitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachketquahoanthien(DateTime Tungay, DateTime Denngay, string Makhachhang, string Mahang, string Macongnhan, int Locsoluong, decimal Soluongmin, decimal Soluongmax)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            parameters.Add(new SqlParameter("@Macongnhan", SqlDbType.NVarChar, 0), Macongnhan);
            parameters.Add(new SqlParameter("@Locsoluong", SqlDbType.Int, 0), Locsoluong);
            parameters.Add(new SqlParameter("@Soluongmin", SqlDbType.Decimal, 0), Soluongmin);
            parameters.Add(new SqlParameter("@Soluongmax", SqlDbType.Decimal, 0), Soluongmax);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachketquahoanthien", "Danhsachketquahoanthien", myArr).Tables[0];
        }
        public static DataTable Danhsachmanhsudunghoanthien(string MAHIEU_PK, string Makhachhang, string Mahang, string Macongnhan, int Locsoluong, decimal Soluongmin, decimal Soluongmax)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Maketquahoanthien", SqlDbType.NVarChar, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            parameters.Add(new SqlParameter("@Macongnhan", SqlDbType.NVarChar, 0), Macongnhan);
            parameters.Add(new SqlParameter("@Locsoluong", SqlDbType.Int, 0), Locsoluong);
            parameters.Add(new SqlParameter("@Soluongmin", SqlDbType.Decimal, 0), Soluongmin);
            parameters.Add(new SqlParameter("@Soluongmax", SqlDbType.Decimal, 0), Soluongmax);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachmanhsudunghoanthien", "Danhsachmanhsudunghoanthien", myArr).Tables[0];
        }
        public static DataTable Danhsachketquahoanthiensaucat(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachketquahoanthiensaucat", "Danhsachketquahoanthiensaucat", myArr).Tables[0];
        }
        public static DataTable Danhsachcongthaykho()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachcongthaykho", "Danhsachcongthaykho", myArr).Tables[0];
        }
        public static DataTable Danhsachphecatong(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachphecatong", "Danhsachphecatong", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatmanh(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatmanh", "Danhsachxuatmanh", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapmanh(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapmanh", "Danhsachnhapmanh", myArr).Tables[0];
        }
        public static DataTable Danhsachdieuchuyenmanh(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachdieuchuyenmanh", "Danhsachdieuchuyenmanh", myArr).Tables[0];
        }
        public static DataTable Danhsachdieuchuyennguyenlieu(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachdieuchuyennguyenlieu", "Danhsachdieuchuyennguyenlieu", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapkhohoanthien(DateTime Tungay, DateTime Denngay, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapkhohoanthien", "Danhsachnhapkhohoanthien", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapkhohoanthienchitiet(DateTime MAHIEU_PK, string Mahang, string Makho)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaynhap", SqlDbType.DateTime, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Makho);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapkhohoanthienchitiet", "Danhsachnhapkhohoanthienchitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapkhomanhtrang(DateTime Tungay, DateTime Denngay, string Mamanh)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Mamanh", SqlDbType.NVarChar, 0), Mamanh);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapkhomanhtrang", "Danhsachnhapkhomanhtrang", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapkhomanhtrangchitiet(DateTime MAHIEU_PK, string Mamanh)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaynhap", SqlDbType.DateTime, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Mamanh", SqlDbType.NVarChar, 0), Mamanh);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapkhomanhtrangchitiet", "Danhsachnhapkhomanhtrangchitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapkhomang(DateTime Tungay, DateTime Denngay, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Mamang", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapkhomang", "Danhsachnhapkhomang", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapkhomangchitiet(DateTime MAHIEU_PK, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaynhap", SqlDbType.DateTime, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Mamang", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapkhomangchitiet", "Danhsachnhapkhomangchitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapkhonguyenlieu(DateTime Tungay, DateTime Denngay, string Makho)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Makho);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapkhonguyenlieu", "Danhsachnhapkhonguyenlieu", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapkhonguyenlieuchitiet(DateTime Ngaynhap, string Manguyenlieu, string Makho, string Malydo)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaynhap", SqlDbType.DateTime, 0), Ngaynhap);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Makho);
            parameters.Add(new SqlParameter("@Manguyenlieu", SqlDbType.NVarChar, 0), Manguyenlieu);
            parameters.Add(new SqlParameter("@Malydo", SqlDbType.NVarChar, 0), Malydo);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapkhonguyenlieuchitiet", "Danhsachnhapkhonguyenlieuchitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapkhovattuphu(DateTime Tungay, DateTime Denngay, string Mavattuphu)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Mavattuphu", SqlDbType.NVarChar, 0), Mavattuphu);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapkhovattuphu", "Danhsachnhapkhovattuphu", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapkhovattuphuchitiet(DateTime MAHIEU_PK, string Mavattuphu)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaynhap", SqlDbType.DateTime, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Mavattuphu", SqlDbType.NVarChar, 0), Mavattuphu);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapkhovattuphuchitiet", "Danhsachnhapkhovattuphuchitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapkhophe(DateTime Tungay, DateTime Denngay, string Maphe)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Maphe", SqlDbType.NVarChar, 0), Maphe);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapkhophe", "Danhsachnhapkhophe", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapkhophechitiet(DateTime MAHIEU_PK, string Maphe, string Makho)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaynhap", SqlDbType.DateTime, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Maphe", SqlDbType.NVarChar, 0), Maphe);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Makho);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapkhophechitiet", "Danhsachnhapkhophechitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapkhope(DateTime Tungay, DateTime Denngay, string Mape)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Mape", SqlDbType.NVarChar, 0), Mape);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapkhope", "Danhsachnhapkhope", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapkhopechitiet(DateTime MAHIEU_PK, string Mape, string Malydo)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaynhap", SqlDbType.DateTime, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Mape", SqlDbType.NVarChar, 0), Mape);
            parameters.Add(new SqlParameter("@Malydo", SqlDbType.NVarChar, 0), Malydo);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapkhopechitiet", "Danhsachnhapkhopechitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatkhomanhtrang(DateTime Tungay, DateTime Denngay, string Mamanh)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Mamanh", SqlDbType.NVarChar, 0), Mamanh);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatkhomanhtrang", "Danhsachxuatkhomanhtrang", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatkhomanhtrangchitiet(DateTime MAHIEU_PK, string Mamanh, string Malydo, string Lenhxuat)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngayxuat", SqlDbType.DateTime, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Mamanh", SqlDbType.NVarChar, 0), Mamanh);
            parameters.Add(new SqlParameter("@Malydo", SqlDbType.NVarChar, 0), Malydo);
            parameters.Add(new SqlParameter("@Lenhxuat", SqlDbType.NVarChar, 0), Lenhxuat);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatkhomanhtrangchitiet", "Danhsachxuatkhomanhtrangchitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatkhomang(DateTime Tungay, DateTime Denngay, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Mamang", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatkhomang", "Danhsachxuatkhomang", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatkhomangchitiet(DateTime MAHIEU_PK, string Mamang, string Malydo, string Lenhxuat)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngayxuat", SqlDbType.DateTime, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Mamang", SqlDbType.NVarChar, 0), Mamang);
            parameters.Add(new SqlParameter("@Malydo", SqlDbType.NVarChar, 0), Malydo);
            parameters.Add(new SqlParameter("@Lenhxuat", SqlDbType.NVarChar, 0), Lenhxuat);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatkhomangchitiet", "Danhsachxuatkhomangchitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatkhonguyenlieu(DateTime Tungay, DateTime Denngay, string Manguyenlieu)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Manguyenlieu", SqlDbType.NVarChar, 0), Manguyenlieu);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatkhonguyenlieu", "Danhsachxuatkhonguyenlieu", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatkhonguyenlieuchitiet(DateTime MAHIEU_PK, string Manguyenlieu, string Makho, string Mamay, string Lenh, string Malydo)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngayxuat", SqlDbType.DateTime, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Manguyenlieu", SqlDbType.NVarChar, 0), Manguyenlieu);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Makho);
            parameters.Add(new SqlParameter("@Mamay", SqlDbType.NVarChar, 0), Mamay);
            parameters.Add(new SqlParameter("@Lenh", SqlDbType.NVarChar, 0), Lenh);
            parameters.Add(new SqlParameter("@Malydo", SqlDbType.NVarChar, 0), Malydo);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatkhonguyenlieuchitiet", "Danhsachxuatkhonguyenlieuchitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatkhovattuphu(DateTime Tungay, DateTime Denngay, string Mavattuphu)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Mavattuphu", SqlDbType.NVarChar, 0), Mavattuphu);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatkhovattuphu", "Danhsachxuatkhovattuphu", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatkhovattuphuchitiet(DateTime MAHIEU_PK, string Mavattuphu)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngayxuat", SqlDbType.DateTime, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Mavattuphu", SqlDbType.NVarChar, 0), Mavattuphu);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatkhovattuphuchitiet", "Danhsachxuatkhovattuphuchitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatkhophe(DateTime Tungay, DateTime Denngay, string Maphe)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Maphe", SqlDbType.NVarChar, 0), Maphe);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatkhophe", "Danhsachxuatkhophe", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatkhophechitiet(DateTime MAHIEU_PK, string Maphe, string Makho)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngayxuat", SqlDbType.DateTime, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Maphe", SqlDbType.NVarChar, 0), Maphe);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Makho);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatkhophechitiet", "Danhsachxuatkhophechitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatkhope(DateTime Tungay, DateTime Denngay, string Mape)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Mape", SqlDbType.NVarChar, 0), Mape);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatkhope", "Danhsachxuatkhope", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatkhopechitiet(DateTime MAHIEU_PK, string Mape, string Malydo)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngayxuat", SqlDbType.DateTime, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Mape", SqlDbType.NVarChar, 0), Mape);
            parameters.Add(new SqlParameter("@Malydo", SqlDbType.NVarChar, 0), Malydo);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatkhopechitiet", "Danhsachxuatkhopechitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatkhohanghoa(DateTime Tungay, DateTime Denngay, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatkhohanghoa", "Danhsachxuatkhohanghoa", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatkhohanghoachitiet(DateTime MAHIEU_PK, string Mahang, string Makho)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngayxuat", SqlDbType.DateTime, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Makho);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatkhohanghoachitiet", "Danhsachxuatkhohanghoachitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachkhoiluongcuonmanh(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachkhoiluongcuonmanh", "Danhsachkhoiluongcuonmanh", myArr).Tables[0];
        }
        public static DataTable Danhsachkhoiluongcuonmanhchitiet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachkhoiluongcuonmanhchitiet", "Danhsachkhoiluongcuonmanhchitiet", myArr).Tables[0];
        }
        public static DataTable Danhsachthongtincuonmanhchitiet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachthongtincuonmanhchitiet", "Danhsachthongtincuonmanhchitiet", myArr).Tables[0];
        }
        public static DataTable Ngaysudungmaydetthang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Ngaysudungmaydetthang", "Ngaysudungmaydetthang", myArr).Tables[0];
        }
        public static DataTable Tinhcongsuatmaydet(string Mamanh)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mamanh", SqlDbType.NVarChar, 0), Mamanh);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Tinhcongsuatmaydet", "Tinhcongsuatmaydet", myArr).Tables[0];
        }
        public static DataTable Ngaysudungmaysoithang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Ngaysudungmaysoithang", "Ngaysudungmaysoithang", myArr).Tables[0];
        }
        public static DataTable Ngaysudungmaytrangthang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Ngaysudungmaytrangthang", "Ngaysudungmaytrangthang", myArr).Tables[0];
        }
        public static DataTable Ngaysudungmayinthang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Ngaysudungmayinthang", "Ngaysudungmayinthang", myArr).Tables[0];
        }
        public static DataTable Ngaysudungmayhoanthienthang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Ngaysudungmayhoanthienthang", "Ngaysudungmayhoanthienthang", myArr).Tables[0];
        }
        public static DataTable Tinhcongsuatmaysoi(string Masoi)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Masoi", SqlDbType.NVarChar, 0), Masoi);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Tinhcongsuatmaysoi", "Tinhcongsuatmaysoi", myArr).Tables[0];
        }        
        public static DataTable Nhucausoitheokehoachdet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Nhucausoitheokehoachdet", "Nhucausoitheokehoachdet", myArr).Tables[0];
        }
        public static DataTable Luykenhucausoitheokehoachdet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Luykenhucausoitheokehoachdet", "Luykenhucausoitheokehoachdet", myArr).Tables[0];
        }
        public static DataTable Congsuattungloaisoitheokehoachdet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Congsuattungloaisoitheokehoachdet", "Congsuattungloaisoitheokehoachdet", myArr).Tables[0];
        }        
        public static DataTable Congsuatmayinchotungmauin(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Congsuatmayinchotungmauin", "Congsuatmayinchotungmauin", myArr).Tables[0];
        }
        public static DataSet Congsuatmayhoanthienchotungmahang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Congsuatmayhoanthienchotungmahang", "Congsuatmayhoanthienchotungmahang", myArr);
        }
        public static DataTable Danhsachsoitheokehoachdetcuakhachhang(string Makhachhang, DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachsoitheokehoachdetcuakhachhang", "Danhsachsoitheokehoachdetcuakhachhang", myArr).Tables[0];
        }
        public static DataTable Nhucaumanhtheodonhang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Nhucaumanhtheodonhang", "Nhucaumanhtheodonhang", myArr).Tables[0];
        }
        public static DataTable Tonghopnhucaumanhtheothang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Tonghopnhucaumanhtheothang", "Tonghopnhucaumanhtheothang", myArr).Tables[0];
        }
        public static DataTable Tonghopnhucausoitheothang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Tonghopnhucausoitheothang", "Tonghopnhucausoitheothang", myArr).Tables[0];
        }
        public static DataTable Tonghopnhucautrangtheothang(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Tonghopnhucautrangtheothang", "Tonghopnhucautrangtheothang", myArr).Tables[0];
        }        
        public static DataTable Nhucautrangtheodonhangchitiet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Nhucautrangtheodonhangchitiet", "Nhucautrangtheodonhangchitiet", myArr).Tables[0];
        }
        public static DataTable Nhucauintheodondathangchitiet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Nhucauintheodondathangchitiet", "Nhucauintheodondathangchitiet", myArr).Tables[0];
        }
        public static DataTable Nhucaulapkehoachintheodondathangchitiet(DateTime Tungay, DateTime Denngay, bool Daphatlenh)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Daphatlenh", SqlDbType.Bit, 0), Daphatlenh);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Nhucaulapkehoachintheodondathangchitiet", "Nhucaulapkehoachintheodondathangchitiet", myArr).Tables[0];
        }
        public static DataTable Nhucauhoanthientheodondathangchitiet(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Nhucauhoanthientheodondathangchitiet", "Nhucauhoanthientheodondathangchitiet", myArr).Tables[0];
        }
        public static DataTable Nhucauhoanthien_Danhsach(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Nhucauhoanthien_Danhsach", "Nhucauhoanthien_Danhsach", myArr).Tables[0];
        }
        public static DataTable Kehoachhoanthientheocamay(DateTime Ngay, int Ca, string May)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            parameters.Add(new SqlParameter("@Ca", SqlDbType.Int, 0), Ca);
            parameters.Add(new SqlParameter("@May", SqlDbType.NVarChar, 0), May);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Kehoachhoanthientheocamay", "Kehoachhoanthientheocamay", myArr).Tables[0];
        }
        public static DataTable Kehoachintheocamay(DateTime Ngay, int Ca, string May)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            parameters.Add(new SqlParameter("@Ca", SqlDbType.Int, 0), Ca);
            parameters.Add(new SqlParameter("@May", SqlDbType.NVarChar, 0), May);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Kehoachintheocamay", "Kehoachintheocamay", myArr).Tables[0];
        }
        public static DataTable Kehoachtrangtheocamay(DateTime Ngay, int Ca, string May)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            parameters.Add(new SqlParameter("@Ca", SqlDbType.Int, 0), Ca);
            parameters.Add(new SqlParameter("@May", SqlDbType.NVarChar, 0), May);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Kehoachtrangtheocamay", "Kehoachtrangtheocamay", myArr).Tables[0];
        }
        public static void Lapkehoachsanxuatsoimanh(string Thang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.NVarChar, 0), Thang);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout,"Lapkehoachsanxuatsoimanh", "Lapkehoachsanxuatsoimanh", myArr);
        }
        public static void Lapkehoachsanxuatmanh(string Thang, string Madonhang, string Madonhangchitiet, DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.NVarChar, 0), Thang);
            parameters.Add(new SqlParameter("@Madonhang", SqlDbType.NVarChar, 0), Madonhang);
            parameters.Add(new SqlParameter("@Madonhangchitiet", SqlDbType.NVarChar, 0), Madonhangchitiet);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Lapkehoachsanxuatmanh", "Lapkehoachsanxuatmanh", myArr);
        }
        public static void Lapkehoachtrang(string Thang, string Madonhang, string Madonhangchitiet, string Madondathang, string Madondathangchitiet, DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.NVarChar, 0), Thang);
            parameters.Add(new SqlParameter("@Madonhang", SqlDbType.NVarChar, 0), Madonhang);
            parameters.Add(new SqlParameter("@Madonhangchitiet", SqlDbType.NVarChar, 0), Madonhangchitiet);
            parameters.Add(new SqlParameter("@Madondathang", SqlDbType.NVarChar, 0), Madondathang);
            parameters.Add(new SqlParameter("@Madondathangchitiet", SqlDbType.NVarChar, 0), Madondathangchitiet);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Lapkehoachtrang", "Lapkehoachtrang", myArr);
        }
        public static void Lapkehoachin(string Thang, string Madonhang, string Madonhangchitiet, DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.NVarChar, 0), Thang);
            parameters.Add(new SqlParameter("@Madonhang", SqlDbType.NVarChar, 0), Madonhang);
            parameters.Add(new SqlParameter("@Madonhangchitiet", SqlDbType.NVarChar, 0), Madonhangchitiet);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Lapkehoachin", "Lapkehoachin", myArr);
        }
        public static DataTable Kehoachindalap(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Kehoachindalap", "Kehoachindalap", myArr).Tables[0];
        }
        public static DataTable Kehoachtrangdalap(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Kehoachtrangdalap", "Kehoachtrangdalap", myArr).Tables[0];
        }
        public static DataTable Kehoachhoanthiendalap(DateTime Tungay, DateTime Denngay, string Macongdoan)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Macongdoan", SqlDbType.NVarChar, 0), Macongdoan);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Kehoachhoanthiendalap", "Kehoachhoanthiendalap", myArr).Tables[0];
        }
        public static DataTable Chayhamkhongbien(string Tenham)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, Tenham, Tenham, myArr).Tables[0];
        }
        public static void Xoakehoachsanxuatsoimanh(string Thang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.NVarChar, 0), Thang);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Xoakehoachsanxuatsoimanh", "Xoakehoachsanxuatsoimanh", myArr);
        }
        public static void Xoakehoachsanxuatmanh(string Thang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.NVarChar, 0), Thang);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Xoakehoachsanxuatmanh", "Xoakehoachsanxuatmanh", myArr);
        }
        public static void Xoakhsxloaimanhtheothang(string Mamanh, DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mamanh", SqlDbType.NVarChar, 0), Mamanh);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Xoakhsxloaimanhtheothang", "Xoakhsxloaimanhtheothang", myArr);
        }
        public static void Xoakhsxloaisoitheothang(string Masoi, DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Masoi", SqlDbType.NVarChar, 0), Masoi);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Xoakhsxloaisoitheothang", "Xoakhsxloaisoitheothang", myArr);
        }
        public static void Xoakehoachtrang(string Madonhangchitiet, DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonhangchitiet", SqlDbType.NVarChar, 0), Madonhangchitiet);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Xoakehoachtrang", "Xoakehoachtrang", myArr);
        }
        public static void Xoakehoachin(string Madonhangchitiet, DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madonhangchitiet", SqlDbType.NVarChar, 0), Madonhangchitiet);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Xoakehoachin", "Xoakehoachin", myArr);
        }
        public static void Xoakehoachhoanthien(string Madondathangchitiet, DateTime Tungay, DateTime Denngay, string Macongdoan)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Madondathangchitiet", SqlDbType.NVarChar, 0), Madondathangchitiet);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Macongdoan", SqlDbType.NVarChar, 0), Macongdoan);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Xoakehoachhoanthien", "Xoakehoachhoanthien", myArr);
        }
        public static void Xoakhsxmanhtheodonhang(string Thang, string Madonhang, string Madonhangchitiet, DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.NVarChar, 0), Thang);
            parameters.Add(new SqlParameter("@Madonhang", SqlDbType.NVarChar, 0), Madonhang);
            parameters.Add(new SqlParameter("@Madonhangchitiet", SqlDbType.NVarChar, 0), Madonhangchitiet);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Xoakhsxmanhtheodonhang", "Xoakhsxmanhtheodonhang", myArr);
        }
        public static void Xoakhsxsoidieuchinh(string Makehoachbanhang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makehoachbanhang", SqlDbType.NVarChar, 0), Makehoachbanhang);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Xoakhsxsoidieuchinh", "Xoakhsxsoidieuchinh", myArr);
        }
        public static void Tinhtrongluongmet()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Tinhtrongluongmet", "Tinhtrongluongmet", myArr);
        }

        public static void Capnhatmanhdaha(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Capnhatmanhdaha", "Capnhatmanhdaha", myArr);
        }
        public static void Updatecuonmanhdaha(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Updatecuonmanhdaha", "Updatecuonmanhdaha", myArr);
        }
        public static void Capnhatmanhdaha_Sometchuain(Int64 Id, DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt, 0), Id);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Capnhatmanhdaha_Sometchuain", "Capnhatmanhdaha_Sometchuain", myArr);
        }
        public static void Xoacuonmanhloi(DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Xoacuonmanhloi", "Xoacuonmanhloi", myArr);
        }
        public static void Xoacuonmanhxuattrung()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Xoacuonmanhxuattrung", "Xoacuonmanhxuattrung", myArr);
        }
        public static void Tinhluonghoanthien(int Thang, int Nam, string User, DateTime Ngaytinh)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Int, 0), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int, 0), Nam);
            parameters.Add(new SqlParameter("@User", SqlDbType.NVarChar, 0), User);
            parameters.Add(new SqlParameter("@Ngaytinh", SqlDbType.Date, 0), Ngaytinh);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Tinhluonghoanthien", "Tinhluonghoanthien", myArr);
        }
        public static void Xoaluonghoanthien(int Thang, int Nam)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Thang", SqlDbType.Int, 0), Thang);
            parameters.Add(new SqlParameter("@Nam", SqlDbType.Int, 0), Nam);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "Xoaluonghoanthien", "Xoaluonghoanthien", myArr);
        }

        public static string Laygiatrithamso(string Mathamso)
        {
            GD.BBPH.DAL.EntityClasses.ThamsoEntity _ThamsoEntity = new GD.BBPH.BLL.ThamsoManagerBase().SelectOne(Mathamso);
            return _ThamsoEntity.Giatri;
        }
        public static decimal Tinhtonmanh(DateTime Ngay, string Mamanh)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            parameters.Add(new SqlParameter("@Mamanh", SqlDbType.NVarChar, 0), Mamanh);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);

            decimal gtri = Convert.ToDecimal(_SimpleStoredProcedure.ExecuteScalarSP("Tinhtonmanh", myArr));
            return gtri;
        }
        public static decimal Tinhmanhtondabotri(string Mamanh, DateTime Tungay, DateTime Denngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Mamanh", SqlDbType.NVarChar, 0), Mamanh);
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);

            decimal gtri = Convert.ToDecimal(_SimpleStoredProcedure.ExecuteScalarSP("Tinhmanhtondabotri", myArr));
            return gtri;
        }
        public static decimal fCongsuatmayindasudung(DateTime Ngaychay, Int32 Ca, string Mamayin)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngaychay", SqlDbType.Date, 0), Ngaychay);
            parameters.Add(new SqlParameter("@Ca", SqlDbType.Int, 0), Ca);
            parameters.Add(new SqlParameter("@Mamayin", SqlDbType.NVarChar, 0), Mamayin);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);

            decimal gtri = Convert.ToDecimal(_SimpleStoredProcedure.ExecuteScalarSP("fCongsuatmayindasudung", myArr));
            return gtri;
        }
        public static bool fKiemtrakehoachhoanthien(DateTime Tungay, DateTime Denngay, string Macongdoan)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Macongdoan", SqlDbType.NVarChar, 0), Macongdoan);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);

            bool gtri = Convert.ToBoolean(_SimpleStoredProcedure.ExecuteScalarSP("fKiemtrakehoachhoanthien", myArr));
            return gtri;
        }
        public static DateTime fNgaykiemkesoi(DateTime Ngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            DateTime gtri = Convert.ToDateTime(_SimpleStoredProcedure.ExecuteScalarSP("fNgaykiemkesoi", myArr));
            return gtri;
        }
        public static DateTime fNgaykiemkemanh(DateTime Ngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            DateTime gtri = Convert.ToDateTime(_SimpleStoredProcedure.ExecuteScalarSP("fNgaykiemkemanh", myArr));
            return gtri;
        }
        public static DateTime fNgaykiemkehoanthien(DateTime Ngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            DateTime gtri = Convert.ToDateTime(_SimpleStoredProcedure.ExecuteScalarSP("fNgaykiemkehoanthien", myArr));
            return gtri;
        }
        public static DateTime fNgaykiemkemanhtrang(DateTime Ngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            DateTime gtri = Convert.ToDateTime(_SimpleStoredProcedure.ExecuteScalarSP("fNgaykiemkemanhtrang", myArr));
            return gtri;
        }
        public static DateTime fNgaykiemkepe(DateTime Ngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            DateTime gtri = Convert.ToDateTime(_SimpleStoredProcedure.ExecuteScalarSP("fNgaykiemkepe", myArr));
            return gtri;
        }
        public static DateTime fNgaykiemkevattuphu(DateTime Ngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            DateTime gtri = Convert.ToDateTime(_SimpleStoredProcedure.ExecuteScalarSP("fNgaykiemkevattuphu", myArr));
            return gtri;
        }
        public static DateTime fNgaykiemkephe(DateTime Ngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            DateTime gtri = Convert.ToDateTime(_SimpleStoredProcedure.ExecuteScalarSP("fNgaykiemkephe", myArr));
            return gtri;
        }
        public static DateTime fNgaykiemkenguyenlieu(DateTime Ngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            DateTime gtri = Convert.ToDateTime(_SimpleStoredProcedure.ExecuteScalarSP("fNgaykiemkenguyenlieu", myArr));
            return gtri;
        }
        public static DateTime fNgaykiemkehang(DateTime Ngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            DateTime gtri = Convert.ToDateTime(_SimpleStoredProcedure.ExecuteScalarSP("fNgaykiemkehang", myArr));
            return gtri;
        }
        public static DataTable Choncongthuctrang()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Choncongthuctrang", "Choncongthuctrang", myArr).Tables[0];
        }
        public static DataTable Danhmuccongdoantruoccat()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhmuccongdoantruoccat", "Danhmuccongdoantruoccat", myArr).Tables[0];
        }
        public static DataTable Danhmuccongdoansaucat()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhmuccongdoansaucat", "Danhmuccongdoansaucat", myArr).Tables[0];
        }
        public static DataTable Danhsachquycachspchitiet(string Macongdoan)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Macongdoan", SqlDbType.NVarChar, 0), Macongdoan);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachquycachspchitiet", "Danhsachquycachspchitiet", myArr).Tables[0];

        }
        public static DataTable LayIddanhsachcuonmanh()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "LayIddanhsachcuonmanh", "LayIddanhsachcuonmanh", myArr).Tables[0];
        }

        public static DataTable Danhsachkiemkesoi()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachkiemkesoi", "Danhsachkiemkesoi", myArr).Tables[0];
        }
        public static DataTable Danhsachkiemkemanh()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachkiemkemanh", "Danhsachkiemkemanh", myArr).Tables[0];
        }
        public static DataTable Danhsachkiemkehoanthien()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachkiemkehoanthien", "Danhsachkiemkehoanthien", myArr).Tables[0];
        }
        public static DataTable Danhsachkiemkemanhtrang()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachkiemkemanhtrang", "Danhsachkiemkemanhtrang", myArr).Tables[0];
        }
        public static DataTable Danhsachkiemkemang()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachkiemkemang", "Danhsachkiemkemang", myArr).Tables[0];
        }
        public static DataTable Danhsachkiemkepe()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachkiemkepe", "Danhsachkiemkepe", myArr).Tables[0];
        }
        public static DataTable Danhsachkiemkevattuphu()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachkiemkevattuphu", "Danhsachkiemkevattuphu", myArr).Tables[0];
        }
        public static DataTable Danhsachkiemkephe()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachkiemkephe", "Danhsachkiemkephe", myArr).Tables[0];
        }
        public static DataTable Danhsachkiemkenguyenlieu()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachkiemkenguyenlieu", "Danhsachkiemkenguyenlieu", myArr).Tables[0];
        }
        public static DataTable Danhsachkiemkehang()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachkiemkehang", "Danhsachkiemkehang", myArr).Tables[0];
        }

        public static DataTable Danhsachmaysudungnguyenlieu()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachmaysudungnguyenlieu", "Danhsachmaysudungnguyenlieu", myArr).Tables[0];
        }

        #region BBPH
        public static DataTable Danhsachctpt()
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachctpt", "Danhsachctpt", myArr).Tables[0];
        }
        public static DataTable Danhsachdonhang(DateTime Tungay, DateTime Denngay, string Madondathang, string Sobaogia, /*string SoPO,*/ string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Madondathang", SqlDbType.NVarChar, 0), Madondathang);
            parameters.Add(new SqlParameter("@Sobaogia", SqlDbType.NVarChar, 0), Sobaogia);
            //parameters.Add(new SqlParameter("@SoPO", SqlDbType.NVarChar, 0), SoPO);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachdonhang", "Danhsachdonhang", myArr).Tables[0];
        }
        public static DataTable Danhsachdonhangchitiet(DateTime Tungay, DateTime Denngay, string Madondathang, string Sobaogia, /*string SoPO,*/ string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Madondathang", SqlDbType.NVarChar, 0), Madondathang);
            parameters.Add(new SqlParameter("@Sobaogia", SqlDbType.NVarChar, 0), Sobaogia);
            //parameters.Add(new SqlParameter("@SoPO", SqlDbType.NVarChar, 0), SoPO);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachdonhangchitiet", "Danhsachdonhangchitiet", myArr).Tables[0];
        }

        public static DataTable Danhsachbaogiachon(string Sobaogia)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Sobaogia", SqlDbType.NVarChar, 0), Sobaogia);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachbaogiachon", "Danhsachbaogiachon", myArr).Tables[0];
        }


        public static DataTable Danhsachbaogia(DateTime Tungay, DateTime Denngay, string Sobaogia, /*string SoPO,*/ string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sobaogia", SqlDbType.NVarChar, 0), Sobaogia);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);

            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachbaogia", "Danhsachbaogia", myArr).Tables[0];
        }
        public static DataTable Danhsachbaogiachitiet(DateTime Tungay, DateTime Denngay, string Sobaogia, /*string SoPO,*/ string Makhachhang, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sobaogia", SqlDbType.NVarChar, 0), Sobaogia);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);

            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachbaogiachitiet", "Danhsachbaogiachitiet", myArr).Tables[0];
        }

        public static DataTable Danhsachphieugiaohang(DateTime Tungay, DateTime Denngay, string Sophieugiao, string Madonhang, string Makhachhang, string Mahang)

        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sophieugiao", SqlDbType.NVarChar, 0), Sophieugiao);
            parameters.Add(new SqlParameter("@Madonhang", SqlDbType.NVarChar, 0), Madonhang);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);

            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachphieugiaohang", "Danhsachphieugiaohang", myArr).Tables[0];
        }

        public static DataTable Danhsachphieugiaohangchitiet(DateTime Tungay, DateTime Denngay, string Sophieugiao, string Madonhang, string Makhachhang, string Mahang)

        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Sophieugiao", SqlDbType.NVarChar, 0), Sophieugiao);
            parameters.Add(new SqlParameter("@Madonhang", SqlDbType.NVarChar, 0), Madonhang);
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhachhang);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);

            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachphieugiaohangchitiet", "Danhsachphieugiaohangchitiet", myArr).Tables[0];
        }

        public static DataTable Danhsachhangchontronghoadon(string Makhach, DateTime Ngay)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhach", SqlDbType.NVarChar, 0), Makhach);
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachhangchontronghoadon", "Danhsachhangchontronghoadon", myArr).Tables[0];
        }

        public static DataTable Danhsachdondathangchitietkhongton(string Makhach, string Mahang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Makhachhang", SqlDbType.NVarChar, 0), Makhach);
            parameters.Add(new SqlParameter("@Mahang", SqlDbType.NVarChar, 0), Mahang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachdondathangchitietkhongton", "Danhsachdondathangchitietkhongton", myArr).Tables[0];
        }

        public static DataTable Danhsachketquathoi(DateTime Tungay, DateTime Denngay, int Ca, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Ca", SqlDbType.Int, 0), Ca);
            parameters.Add(new SqlParameter("@Mamang", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachketquathoi", "Danhsachketquathoi", myArr).Tables[0];
        }
        public static DataTable Danhsachketquathoichitiet(string MAHIEU_PK, int ca, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Maketquathoi", SqlDbType.NVarChar, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Ca", SqlDbType.Int, 0), ca);
            parameters.Add(new SqlParameter("@Mamang", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachketquathoichitiet", "Danhsachketquathoichitiet", myArr).Tables[0];
        }

        public static DataTable Danhsachketquachia(DateTime Tungay, DateTime Denngay, int Ca, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Ca", SqlDbType.Int, 0), Ca);
            parameters.Add(new SqlParameter("@Mamang", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachketquachia", "Danhsachketquachia", myArr).Tables[0];
        }
        public static DataTable Danhsachketquachiachitiet(string MAHIEU_PK, int ca, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Maketquathoi", SqlDbType.NVarChar, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Ca", SqlDbType.Int, 0), ca);
            parameters.Add(new SqlParameter("@Mamang", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachketquachiachitiet", "Danhsachketquachiachitiet", myArr).Tables[0];
        }

        public static DataTable Danhsachthongkenguyenlieu(DateTime Tungay, DateTime Denngay, string Manguyenlieu)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Manguyenlieu", SqlDbType.NVarChar, 0), Manguyenlieu);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader("Danhsachthongkenguyenlieu", "Danhsachthongkenguyenlieu", myArr).Tables[0];
        }

        public static DataTable Danhsachketquain(DateTime Tungay, DateTime Denngay, int Ca, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Ca", SqlDbType.Int, 0), Ca);
            parameters.Add(new SqlParameter("@Masp", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachketquain", "Danhsachketquain", myArr).Tables[0];
        }
        public static DataTable Danhsachketquainchitiet(string MAHIEU_PK, int Ca, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Maketquain", SqlDbType.NVarChar, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Ca", SqlDbType.Int, 0), Ca);
            parameters.Add(new SqlParameter("@Masp", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachketquainchitiet", "Danhsachketquainchitiet", myArr).Tables[0];
        }

        public static DataTable Danhsachnhapsanpham(DateTime Tungay, DateTime Denngay, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapsanpham", "Danhsachnhapsanpham", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapsanphamchitiet(string MAHIEU_PK, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhapkho", SqlDbType.NVarChar, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Masp", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapsanphamchitiet", "Danhsachnhapsanphamchitiet", myArr).Tables[0];
        }

        public static DataTable Danhsachxuatsanpham(DateTime Tungay, DateTime Denngay, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatsanpham", "Danhsachxuatsanpham", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatsanphamchitiet(string MAHIEU_PK, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhapkho", SqlDbType.NVarChar, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Masp", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatsanphamchitiet", "Danhsachxuatsanphamchitiet", myArr).Tables[0];
        }

        public static DataTable Danhsachkiemkesanpham(DateTime Tungay, DateTime Denngay, string Makho)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Makho);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachkiemkesanpham", "Danhsachkiemkesanpham", myArr).Tables[0];
        }

        public static DataTable Danhsachnhapmang(DateTime Tungay, DateTime Denngay, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapmang", "Danhsachnhapmang", myArr).Tables[0];
        }

        public static DataTable Danhsachkiemkemang(DateTime Tungay, DateTime Denngay, string Makho)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Makho);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachkiemkemang", "Danhsachkiemkemang", myArr).Tables[0];
        }

        public static DataTable Danhsachnhapmangchitiet(string MAHIEU_PK, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhapkho", SqlDbType.NVarChar, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Mamang", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapmangchitiet", "Danhsachnhapmangchitiet", myArr).Tables[0];
        }

        public static DataTable Danhsachnhapnguyenlieu(DateTime Tungay, DateTime Denngay, string Manguyenlieu)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Manguyenlieu);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapnguyenlieu", "Danhsachnhapnguyenlieu", myArr).Tables[0];
        }
        public static DataTable Danhsachnhapnguyenlieuchitiet(string MAHIEU_PK, string Manguyenlieu)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhapkho", SqlDbType.NVarChar, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Manguyenlieu", SqlDbType.NVarChar, 0), Manguyenlieu);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachnhapnguyenlieuchitiet", "Danhsachnhapnguyenlieuchitiet", myArr).Tables[0];
        }

        public static DataTable Danhsachketquatua(DateTime Tungay, DateTime Denngay, int Ca, string Lenhtua)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Ca", SqlDbType.Int, 0), Ca);
            parameters.Add(new SqlParameter("@Lenhtua", SqlDbType.NVarChar, 0), Lenhtua);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachketquatua", "Danhsachketquatua", myArr).Tables[0];
        }

        public static DataTable Danhsachketquatuachitiet(DateTime Ngay, int Ca, string Lenhtua, string Masanpham)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Ngay", SqlDbType.Date, 0), Ngay);
            parameters.Add(new SqlParameter("@Ca", SqlDbType.Int, 0), Ca);
            parameters.Add(new SqlParameter("@Lenhtua", SqlDbType.NVarChar, 0), Lenhtua);
            parameters.Add(new SqlParameter("@Masanpham", SqlDbType.NVarChar, 0), Masanpham);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachketquatuachitiet", "Danhsachketquatuachitiet", myArr).Tables[0];
        }

        public static DataTable Danhsachkiemkenguyenlieu(DateTime Tungay, DateTime Denngay, string Makho)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Makho);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachkiemkenguyenlieu", "Danhsachkiemkenguyenlieu", myArr).Tables[0];
        }

        public static DataTable Danhsachxuatmang(DateTime Tungay, DateTime Denngay, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatmang", "Danhsachxuatmang", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatmangchitiet(string MAHIEU_PK, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhapkho", SqlDbType.NVarChar, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Mamang", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatmangchitiet", "Danhsachxuatmangchitiet", myArr).Tables[0];
        }

        public static DataTable Danhsachxuatnguyenlieu(DateTime Tungay, DateTime Denngay, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Tungay", SqlDbType.Date, 0), Tungay);
            parameters.Add(new SqlParameter("@Denngay", SqlDbType.Date, 0), Denngay);
            parameters.Add(new SqlParameter("@Makho", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatnguyenlieu", "Danhsachxuatnguyenlieu", myArr).Tables[0];
        }
        public static DataTable Danhsachxuatnguyenlieuchitiet(string MAHIEU_PK, string Mamang)
        {
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(ConnectionStringKeyName);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@Manhapkho", SqlDbType.NVarChar, 0), MAHIEU_PK);
            parameters.Add(new SqlParameter("@Manguyenlieu", SqlDbType.NVarChar, 0), Mamang);
            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            return _SimpleStoredProcedure.ExecuteSPReader(timeout, "Danhsachxuatnguyenlieuchitiet", "Danhsachxuatnguyenlieuchitiet", myArr).Tables[0];
        }
        #endregion

        #region Khác
        public static void Saoluudulieu(string FileName)
        {
            int vt1 = ConnectionStringKeyName.IndexOf(";Initial Catalog");
            int vt2 = ConnectionStringKeyName.IndexOf(";User ID");
            string strRep = ConnectionStringKeyName.Substring(vt1, vt2 - vt1);
            string strMasterConnect = ConnectionStringKeyName.Replace(strRep, ";Initial Catalog=master");
            SimpleStoredProcedure _SimpleStoredProcedure = new SimpleStoredProcedure(strMasterConnect);
            ListDictionary parameters = new ListDictionary();
            parameters.Add(new SqlParameter("@FileName", SqlDbType.NVarChar, 0), FileName);

            DictionaryEntry[] myArr = new DictionaryEntry[parameters.Count];
            parameters.CopyTo(myArr, 0);
            _SimpleStoredProcedure.ExecuteSPReader(timeout, "BackupDataBBPH", "BackupDataBBPH", myArr);//.ExecuteScalarSP("BackupDataKTXPT", myArr);
        }
        #endregion

    }
}
