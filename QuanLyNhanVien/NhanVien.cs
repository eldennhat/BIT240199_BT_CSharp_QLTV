namespace QuanLyNhanVien;

using System;

public class NhanVien {
    public string ID { get; set; }
    public string FullName { get; set; }
    public DateTime Birthday { get; set; }
    public string Gender { get; set; }
    public string SDT { get; set; }
    public string Motahoancanh { get; set; }
    public ChucVu ChucVu { get; set; }
    public string ChuyenMon { get; set; }
    public bool Status { get; set; }
    public decimal Salary { get; set; }

    public NhanVien()
    {
        Birthday = DateTime.Now;
        Status = true; // default la dang lam viec
    }
    
}