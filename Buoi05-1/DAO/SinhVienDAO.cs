﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi05_1.DAO
{
    class SinhVienDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        DataProvider kn = new DataProvider();
        public SinhVienDAO()
        {
            conn = kn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        //	Truy vấn và trả về DataTable(Nhiều mẫu tin)
        public DataTable getlist(int? makhoa = null)

        {

            string sql = null;
            if (makhoa == null)
            {
                sql = "SELECT SinhVien.MaSV, SinhVien.HoTen, SinhVien.DiemTB, Khoa.TenKhoa ";
                sql += "FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa = SinhVien.MaKhoa";


            }
            else
            {

                sql = "SELECT SinhVien.MaSV, SinhVien.HoTen, SinhVien.DiemTB, Khoa.TenKhoa ";

                sql += "FROM SinhVien INNER JOIN Khoa ON Khoa.MaKhoa=SinhVien.MaKhoa WHERE SinhVien.MaKhoa='" + makhoa + "'";

            }

            cmd = new SqlCommand(sql, conn);

            apt = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            apt.Fill(dt);

            return dt;

        }
        //	Truy vấn và trả về số lượng
        public int getCount()
        {
            string sql = "SELECT COUNT(SinhVien.MaSV) FROM SinhVien INNER JOIN Khoa ON Khoa. Makhoa=SinhVien.MaKhoa";
            cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();
            return count;
        }
        //	Truy vấn và trả về DataRow(Một mẫu tin)
        public DataRow getRow(string masv)
        {
            string sql = "SELECT SinhVien.MaSV, SinhVien.HoTen, SinhVien.DiemTB, Khoa. Tenkhoa ";

            sql += "FROM SinhVien INNER JOIN Khoa ON Khoa.Makhoa=SinhVien.MaKhoa WHERE SinhVien.MaSV='" + masv + "'";

            cmd = new SqlCommand(sql, conn);

            apt = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            apt.Fill(dt);
            DataRow row = dt.Rows[0];

            return row;
        }
        //	Thêm mẫu tin
        public void InsertTwo(SinhVien sv)
        {

            string sql = "INSERT INTO Sinhvien (MaSV, HoTen, Makhoa, DiemTB) VALUES (@MASV, @HOTEN, @MAKHOA, @DIEMTB)"; 
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MASV", sv.MaSV); 
            cmd.Parameters.AddWithValue("@HOTEN", sv.HoTen); 
            cmd.Parameters.AddWithValue("@DIEMTB", sv.DiemTB);
            cmd.Parameters.AddWithValue("@MAKHOA", sv.MaKhoa); 
            cmd.ExecuteNonQuery();
        }
        //	Cập nhật mẫu tin
        public void UpdateTwo(SinhVien sv)

        {

            string sql = "UPDATE Sinhvien SET HoTen=@HOTEN, MaKhoa-@MAKHOA, DiemTB=@DIEMTB ";

            sql += "WHERE MaSV=@MASV";

            cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MASV", sv.MaSV);

            cmd.Parameters.AddWithValue("@HOTEN", sv.HoTen); cmd.Parameters.AddWithValue("@DIEMTB", sv.DiemTB);

            cmd.Parameters.AddWithValue("@MAKHOA", sv.MaKhoa); cmd.ExecuteNonQuery();

        }
        //	Xóa một mẫu tin
        public void DeleteTwo(string masv)

        {

            string sql = "DELETE FROM SinhVien WHERE MaSV=@MASV";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MASV", masv);
            cmd.ExecuteNonQuery();

        }
    }

}
