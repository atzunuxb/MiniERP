

--*************************************************--
-------------CREACION DE TABLAS----------------------
--*************************************************--

 
 --*************************************************--
--TABLA 1 PERSONAS--
create table Personas
(
Id_Persona integer,  
Nombres nvarchar2(50) not null,
Apellidos nvarchar2(50) not null,
Genero Nvarchar2 (15)not null,
Direccion_Persona nvarchar2(100),
Municipio_Persona nvarchar2(50),
Ciudad_Persona nvarchar2(50),
Telefono_Persona nvarchar2(25),
primary key (Id_Persona)
);

select * from Personas;
create SEQUENCE IdPersona 
START WITH 1
INCREMENT BY 1;

CREATE TRIGGER Trig_IdPersona
BEFORE INSERT ON Personas
for EACH ROW
BEGIN
SELECT IdPersona.NEXTVAL INTO  :NEW.Id_Persona  from DUAL ;
END;


insert into Telefonos (Telefono, CompaniaTelefonica) values( '00502465432','Tigo');
insert into Telefonos (Telefono, CompaniaTelefonica) values( '00502489564','Claro');

select*from telefonos;


--*************************************************--
--TABLA 2 PREOVEEDORES--

create table Proveedores
(
Id_Proveedor integer ,
NombreCompania nvarchar2 (100) Not null,
Direccion_Compañia NVARCHAR2(100),
Municipio_Compañia Nvarchar2(50),
Ciudad_Compañia Nvarchar2(50),
Telefono_Compañia Nvarchar2(25),
FechaRegistro_Proveedor date not null ,
primary key (Id_Proveedor)
);


select * from proveedores;
create SEQUENCE IdProveedor 
START WITH 1
INCREMENT BY 1;

CREATE TRIGGER Trig_IdProveedor
BEFORE INSERT ON Proveedores
for EACH ROW
BEGIN
SELECT IdProveedor.NEXTVAL INTO  :NEW.Id_Proveedor  from DUAL ;
END;




--*************************************************--
--TABLA 3 HORARIO--

create table Horario
(
Id_Horario integer ,
Horario nvarchar2(25) not null,
TipoHorario nvarchar2 (50) not null,
primary key (Id_Horario)
);

create SEQUENCE IdHorario 
START WITH 1
INCREMENT BY 1;

CREATE TRIGGER TrigId_Horario
BEFORE INSERT ON Horario
for EACH ROW
BEGIN
SELECT IdHorario.NEXTVAL INTO  :NEW.Id_Horario  from DUAL ;
END;



--*************************************************--
--TABLA 4 CARGOS--

create table Cargos
(
Id_Cargo integer   ,
NombreCargo NVARCHAR2(50)not null,
SalarioCargo decimal(15,2)not null,
primary key (Id_Cargo)
);

Select* from Personas;
create SEQUENCE IdCargos 
START WITH 1
INCREMENT BY 1;

CREATE TRIGGER Trig_IdCargos
BEFORE INSERT ON Cargos
for EACH ROW
BEGIN
SELECT IdCargos.NEXTVAL INTO  :NEW.Id_Cargo  from DUAL ;
END;



--*************************************************--
--TABLA 5 DEPARTAMENTOS--

create table Departamentos
(
Id_Departamento integer  ,
Departamento NVARCHAR2(50)not null,
DescripcionDepa nvarchar2(50) null,
primary key (Id_Departamento)
);

create SEQUENCE IdDepartamentos 
START WITH 1
INCREMENT BY 1;

CREATE TRIGGER Trig_IdDepartamentos
BEFORE INSERT ON Departamentos
for EACH ROW
BEGIN
SELECT IdDepartamentos.NEXTVAL INTO  :NEW.Id_Departamento  from DUAL ;
END;



--*************************************************--
--TABLA 6 EMPLEADOS--

create table Empleados
(
Id_Empleado integer  ,
DPI NVARCHAR2(20)not null,
FechaNacimiento date not null,
FechaContrato_Empleado Nvarchar2 (50),
FechaRegistro_Empleado date not null,
Id_Persona integer,
Id_Horario integer,
Id_Cargo   integer,
Id_Departamento integer,
primary key (Id_Empleado),
constraint FK_Persona foreign key (Id_Persona) references Personas(Id_Persona),
constraint FK_Horario foreign key (Id_Horario) references Horario(Id_Horario),
constraint FK_Cargo foreign key (Id_Cargo) references Cargos(Id_Cargo),
constraint FK_Departamento foreign key (Id_Departamento) references Departamentos(Id_Departamento)
);


create SEQUENCE IdEmpleados 
START WITH 1
INCREMENT BY 1;

CREATE TRIGGER Trig_IdEmpleados
BEFORE INSERT ON Empleados
for EACH ROW
BEGIN
SELECT IdEmpleados.NEXTVAL INTO  :NEW.Id_Empleado  from DUAL ;
END;



--*************************************************--
--TABLA 7 HORASEXTRAS--
create table HorasExtras
(
Id_HorasExtras integer ,
HorarioExtra nvarchar2(25)not null,
Dia_HoraExtra nvarchar2 (15) not null,
Fecha_HoraExtra nvarchar2(20) not null,
FechaRegistro_HE date,
Id_Empleado integer,
primary key (Id_HorasExtras),
constraint FK_Empleados foreign key (Id_Empleado) references Empleados(Id_Empleado)
);

create SEQUENCE IdHorasExtras 
START WITH 1
INCREMENT BY 1;

CREATE TRIGGER Trig_IdHoras_Extras
BEFORE INSERT ON HorasExtras
for EACH ROW
BEGIN
SELECT IdHorasExtras.NEXTVAL INTO  :NEW.Id_HorasExtras  from DUAL ;
END;



--*************************************************--
--TABLA 8 CLIENTES--

create table Clientes
(
Id_Cliente integer ,
Tipo_Cliente Nvarchar2(50),
Descripcion_Cliente Nvarchar2(100),
FechaRegistro_Cliente date not null,
Id_Persona integer,
primary key (Id_Cliente),
constraint FK_Persona1 foreign key (Id_Persona) references Personas(Id_Persona)
);
select *from proveedores;
Select * from empleados;
create SEQUENCE IdClientes 
START WITH 1
INCREMENT BY 1;

CREATE TRIGGER Trig_IdClientes
BEFORE INSERT ON Clientes
for EACH ROW
BEGIN
SELECT IdClientes.NEXTVAL INTO  :NEW.Id_Cliente  from DUAL ;
END;

--*************************************************--
--TABLA 9 USUARIOS--

create table Usuarios (
Id_Usuario integer ,
NombreUsuario nvarchar2 (50)not null,
Contraseña nvarchar2 (25) not null,
FechaRegistro_Usuario date,
Id_Empleados integer,
primary key (Id_Usuario),
constraint FK_Empleado foreign key (Id_Empleados) references Empleados(Id_Empleado)
);


create SEQUENCE IdUsuarios 
START WITH 1
INCREMENT BY 1;

CREATE TRIGGER Trig_IdUsuarios
BEFORE INSERT ON Usuarios
for EACH ROW
BEGIN
SELECT IdUsuarios.NEXTVAL INTO  :NEW.Id_Usuario  from DUAL ;
END;



--*************************************************--
--TABLA 10 PRODUCTOS--

create table Productos (
Id_Producto  integer ,
NombreProducto nvarchar2 (50) not null,
Tipo_Producto NVARCHAR2(50) not null,
PrecioCompra decimal(15,2) not null,
PrecioVenta decimal (15,2) not null,
Numero_Stock integer null,
FechaRegistro_Producto date not null,
primary key (Id_Producto)
);

create SEQUENCE Id_Producto 
START WITH 1
INCREMENT BY 1;

CREATE TRIGGER Trig_IdProductos
BEFORE INSERT ON Productos
for EACH ROW
BEGIN
SELECT Id_Producto.NEXTVAL INTO  :NEW.Id_Producto  from DUAL ;
END;

--*************************************************--
--TABLA 11 TIPO PAGO--

create table TipoPago
(
Id_TipoPago integer,
Descripcion_TipoPago nvarchar2 (50),
primary key (Id_TipoPago)
);

create SEQUENCE Id_TipoPago 
START WITH 1
INCREMENT BY 1;

CREATE TRIGGER Trig_IdTipo_Pago
BEFORE INSERT ON TipoPago
for EACH ROW
BEGIN
SELECT Id_TipoPago.NEXTVAL INTO  :NEW.Id_TipoPago  from DUAL ;
END;




--*************************************************--
--TABLA 12 VENTAS--

create table Ventas  (
Id_Venta  integer ,
Cantidad_Producto decimal (15,2) not null,
PrecioUnitario decimal (15,2) not null,
CostoTotal decimal(15,2) not null,
FechaRegistro_Ventas date not null,
Id_Producto integer,
Id_Empleado integer,
Id_Cliente integer,
Id_TipoPago integer,
primary key (Id_Venta),
constraint FK_Producto foreign key (Id_Producto) references Productos(Id_Producto),
constraint FK_EmpleadoV foreign key (Id_Empleado) references Empleados(Id_Empleado),
constraint FK_Cliente foreign key (Id_Cliente) references Clientes(Id_Cliente),
constraint FK_TipoPago foreign key (Id_TipoPago) references TipoPago(Id_TipoPago)
);

create SEQUENCE Id_Ventas 
START WITH 1
INCREMENT BY 1;

CREATE TRIGGER Trig_IdVentas
BEFORE INSERT ON Ventas
for EACH ROW
BEGIN
SELECT Id_Ventas.NEXTVAL INTO  :NEW.Id_Venta  from DUAL ;
END;


--*************************************************--
--TABLA 13 COMPRAS--

create table Compras (
Id_Compra  integer ,
CantidadProducto integer not null,
CostoUnitario decimal (15,2) not null,
PrecioTotal decimal(15,2) not null, 
FechaRegistro_Compras date not null,
Id_Producto integer,
Id_Proveedor integer,
Id_Empleado integer,
Id_TipoPago integer,
primary key (Id_Compra),
constraint FK_ProductoC foreign key (Id_Producto) references Productos(Id_Producto),
constraint FK_Proveedor foreign key (Id_Proveedor) references Proveedores(Id_Proveedor),
constraint FK_EmpleadoC foreign key (Id_Empleado) references Empleados(Id_Empleado),
constraint FK_TipoPagoC foreign key (Id_TipoPago) references TipoPago(Id_TipoPago)
);

create SEQUENCE Id_Compras 
START WITH 1
INCREMENT BY 1;

CREATE TRIGGER Trig_IdCompras
BEFORE INSERT ON Compras
for EACH ROW
BEGIN
SELECT Id_Compras.NEXTVAL INTO  :NEW.Id_Compra  from DUAL ;
END;



