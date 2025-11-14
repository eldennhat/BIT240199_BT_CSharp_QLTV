namespace QuanLyNhanVien;

using System;
using System.Collections.Generic;

public static class Database {
    public static List<NhanVien> DanhsachNhanVien { get; private set; }

    static Database ()
    {
        DanhsachNhanVien = new List<NhanVien>();
        DanhsachNhanVien.Add(new NhanVien {
            ID = "A01",
            FullName = "Đinh Nguyên Hoàng",
            Birthday = new DateTime(2006, 7, 23),
            Gender = "Male",
            SDT = "0987654321",
            Motahoancanh = "Giau vaix l",
            ChucVu = ChucVu.TroLy,
            ChuyenMon = "IT",
            Status = true,
            Salary = 5000000
        });
        
        DanhsachNhanVien.Add(new NhanVien {
            ID = "A00",
            FullName = "Triệu Hồng Quân",
            Birthday = new DateTime(2006, 10, 12),
            Gender = "Male",
            SDT = "0987654123",
            Motahoancanh = "Cũng Cũng",
            ChucVu = ChucVu.TruongPhong,
            ChuyenMon = "DevOps",
            Status = false,
            Salary = 20000000
        });

        DanhsachNhanVien.Add(new NhanVien {
            ID = "A02",
            FullName = "Nguyễn Thành An",
            Birthday = new DateTime(2006, 8, 15),
            Gender = "Male",
            SDT = "0984123647",
            Motahoancanh = "Rich",
            ChucVu = ChucVu.NhanVien,
            ChuyenMon = "Cloud",
            Status = true,
            Salary = 3500000
        });

        DanhsachNhanVien.Add(new NhanVien {
            ID = "A03",
            FullName = "Khuất Thuỳ Linh",
            Birthday = new DateTime(2006, 9, 17),
            Gender = "Female",
            SDT = "0986555647",
            Motahoancanh = "Normal",
            ChucVu = ChucVu.TroLy,
            ChuyenMon = "Marketing",
            Status = true,
            Salary = 1000000
        });
    }
}