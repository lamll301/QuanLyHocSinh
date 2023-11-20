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
insert into HocSinh(HoTen, NgaySinh, DiaChi, Email, DienThoai, MaLop) values(N'Nguyễn Văn Bình', '2003/7/20', N'Hải Dương', 'binhnv@gmail.com', '0211111111', '1')
insert into HocSinh(HoTen, NgaySinh, DiaChi, Email, DienThoai, MaLop) values(N'Nguyễn Văn Cường', '2003/7/21', N'HCM', 'cuongnv@gmail.com', '0311111111', '2')
insert into HocSinh(HoTen, NgaySinh, DiaChi, Email, DienThoai, MaLop) values(N'Nguyễn Văn Đức', '2003/8/20', N'Hà Nội', 'ducnv@gmail.com', '0411111111', '3')


ALTER TABLE HocSinh ADD MaLop INT;
ALTER TABLE HocSinh ADD CONSTRAINT FK_HocSinh_Lop FOREIGN KEY (MaLop) REFERENCES Lop(MaLop);

select * from HocSinh
select MaHocSinh,HoTen,NgaySinh,DiaChi,Email,DienThoai,TenLop from HocSinh inner join Lop on HocSinh.MaLop = Lop.MaLop
