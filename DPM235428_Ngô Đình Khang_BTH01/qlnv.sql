-- Tạo Database
CREATE DATABASE QLNV;
GO

USE QLNV;
GO

-- Bảng chucvu
CREATE TABLE chucvu (
    macv VARCHAR(10) PRIMARY KEY,
    tencv NVARCHAR(50),
    hspc FLOAT
);

-- Bảng nhanvien
CREATE TABLE nhanvien (
    manv VARCHAR(10) PRIMARY KEY,
    holot NVARCHAR(50),
    tennv NVARCHAR(50),
    phai NVARCHAR(10),
    ngaysinh DATE,
    macv VARCHAR(10),
    FOREIGN KEY (macv) REFERENCES chucvu(macv)
);

-- Bảng quatrinhlong
CREATE TABLE quatrinhluong (
    manv VARCHAR(10),
    ngaybd DATE,
    hsluong FLOAT,
    ghichu NVARCHAR(100),
    PRIMARY KEY (manv, ngaybd),
    FOREIGN KEY (manv) REFERENCES nhanvien(manv)
);

-- Dữ liệu bảng chucvu
INSERT INTO chucvu VALUES(N'TP',N'Trưởng phòng',0.5);
INSERT INTO chucvu VALUES(N'PP',N'Phó trưởng phòng',0.45);
INSERT INTO chucvu VALUES(N'CV',N'Chuyên viên',0.3);
INSERT INTO chucvu VALUES(N'KT',N'Kế toán',0.25);
INSERT INTO chucvu VALUES(N'LX',N'Lái xe cơ quan',0.25);

-- Dữ liệu bảng nhanvien 
INSERT INTO nhanvien VALUES(N'NV001',N'Nguyễn Phước Minh',N'Tân',N'Nam','1975-04-19',N'TP');
INSERT INTO nhanvien VALUES(N'NV002',N'Hà Thị Thanh',N'Nhàn',N'Nữ','1964-03-09',N'PP');
INSERT INTO nhanvien VALUES(N'NV003',N'Văn Minh',N'Tú',N'Nam','1960-02-15',N'CV');
INSERT INTO nhanvien VALUES(N'NV004',N'Lý Văn',N'Sang',N'Nam','1970-12-21',N'CV');
INSERT INTO nhanvien VALUES(N'NV005',N'Nguyễn Thị Thu',N'An',N'Nữ','1981-08-22',N'PP');
INSERT INTO nhanvien VALUES(N'NV006',N'Nguyễn Thanh',N'Tùng',N'Nam','1977-07-07',N'LX');
INSERT INTO nhanvien VALUES(N'NV007',N'Trần Văn',N'Sơn',N'Nam','1979-07-08',N'CV');
INSERT INTO nhanvien VALUES(N'NV008',N'Cao Thị Ngọc',N'Nhung',N'Nữ','1980-06-19',N'KT');
INSERT INTO nhanvien VALUES(N'NV009',N'Lê Thành',N'Tấn',N'Nam','1984-12-05',N'CV');
INSERT INTO nhanvien VALUES(N'NV010',N'Phan Thị Thủy',N'Tiên',N'Nữ','1987-10-25',N'KT');
GO

-- Dữ liệu bảng qtluong
INSERT INTO quatrinhluong VALUES(N'NV003','2001/01/01',2.34,0);
INSERT INTO quatrinhluong VALUES(N'NV001','2001/01/01',4.4,0);
INSERT INTO quatrinhluong VALUES(N'NV002','2001/01/01',4.4,0);
INSERT INTO quatrinhluong VALUES(N'NV008','2001/01/01',1.86,0);
INSERT INTO quatrinhluong VALUES(N'NV004','2002/06/01',2.34,0);
INSERT INTO quatrinhluong VALUES(N'NV008','2003/01/01',2.06,0);
INSERT INTO quatrinhluong VALUES(N'NV003','2004/01/01',2.67,0);

select * from chucvu;
select * from nhanvien;
select * from quatrinhluong;
--e. Nhân viên có mã chức vụ là “CV”
SELECT *
FROM nhanvien
WHERE macv = 'CV';

--. Nhân viên có tên chứa ký tự “t”
SELECT *
FROM nhanvien
WHERE tennv LIKE N'%t%';

--g. Nhân viên sinh trong tháng 8
SELECT *
FROM nhanvien
WHERE MONTH(ngaysinh) = 8;

--h. Nhân viên có hệ số lương dưới 3.00
SELECT DISTINCT nv.*
FROM nhanvien nv
JOIN quatrinhluong ql ON nv.manv = ql.manv
WHERE ql.hsluong < 3.00;

--i.Nhân viên hiện nay không còn công tác nữa
SELECT DISTINCT nv.*
FROM nhanvien nv
JOIN quatrinhluong ql ON nv.manv = ql.manv
WHERE ql.ghichu = N'Nghỉ việc';

--j. Nhân viên được nâng lương trong các năm 2009, 2010
SELECT 
    nv.holot + ' ' + nv.tennv AS Hoten,
    ql.hsluong,
    FORMAT(ql.ngaybd, 'MM-yyyy') AS ThangNamNangLuong
FROM nhanvien nv
JOIN quatrinhluong ql ON nv.manv = ql.manv
WHERE YEAR(ql.ngaybd) IN (2009, 2010);