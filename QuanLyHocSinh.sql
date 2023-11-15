create database QuanLyHocSinh
go 

use QuanLyHocSinh
go

create table Lop(
	MaLop int identity(1,1) primary key not null,
	TenLop varchar(7) unique not null,
)
create table HocSinh(
	MaHocSinh int identity(1,1) primary key not null,
	HoTen nvarchar(35) not null,
	NgaySinh date not null,
	DiaChi nvarchar(100) not null,
	Email varchar(50),
	DienThoai varchar(10),
)
insert into Lop(TenLop) values('CNT')
insert into HocSinh(HoTen, NgaySinh, DiaChi, Email, DienThoai) values(N'Nguyễn Văn An', '2003/6/20', N'Hải Phòng', 'annv@gmail.com', '0111111111')

select * from HocSinh
