CREATE TABLE Customer (
    id INT PRIMARY KEY AUTO_INCREMENT,
    ten VARCHAR(255),
    gioi_tinh VARCHAR(10),
    dia_chi VARCHAR(255),
    cmnd VARCHAR(20),
    ngay_thang_nam_sinh DATE,
    phone VARCHAR(15),
    email VARCHAR(255)
);



INSERT INTO HocSinh (Ten, Diachi, Cmnd, NgayThangNam)
VALUES ('nva', 'hcm', '123', '2024-01-18');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, NgayThangNam)
VALUES ('nva2', 'hcm', '123', '2024-01-18');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, NgayThangNam)
VALUES ('nva3', 'hcm', '123', '2024-01-18');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, NgayThangNam)
VALUES ('nva4', 'hcm', '123', '2024-01-18');
INSERT INTO HocSinh (Ten, Diachi, Cmnd, NgayThangNam)
VALUES ('nva5', 'hcm', '123', '2024-01-18');


select * from HocSinh

DELETE HocSinh