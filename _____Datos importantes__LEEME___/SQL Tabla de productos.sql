if OBJECT_ID ('Productos') is not null
Drop table Productos
Create table Productos(

Codigo int primary key not null,
Nombre Varchar (20) not null,
Detalles Varchar (40) not null,
Marca Varchar (30) not null,
Cantidad Varchar (30),
Precio Varchar (9) not null, 
);

Insert into Productos(Codigo, Nombre, Detalles, Marca, Cantidad, Precio) values 
('63','Licuadora','Aluminium / Original','Oster','8','2450'),
('299','Alicate','Mecanico 8','Total','29','260'),
('100','Clavo','Dulce 11-2','FLD','500','2'),
('209','Barrena','5/16 HSS','Truper','200','68'); 


Select * from Productos
