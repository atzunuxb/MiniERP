
--**********************************************--
--      Creacion de Procedimientos Almacenados  --


--******************************************************************
--- 1 Datos Pesonas---
create or replace procedure insert_persona (nom in nvarchar2,ape nvarchar2, gen in nvarchar2,
Dire in nvarchar2, Muni in nvarchar2, Ciudad in nvarchar2,Tele in nvarchar2 )
as
begin
    insert into Personas (nombres,apellidos,genero,direccion_persona,municipio_persona,ciudad_persona,telefono_persona) 
    values (nom, ape,gen,Dire,Muni,Ciudad,Tele);
    end;
    

 
create or REPLACE PROCEDURE select_persona (registros out SYS_REFCURSOR)
as
begin
open registros for select * from personas;
end;


create or REPLACE procedure Update_Persona(id_per integer, nom in nvarchar2,ape nvarchar2, gen in nvarchar2,
Dire in nvarchar2, Muni in nvarchar2, Ciudad in nvarchar2,Tele in nvarchar2)
as
vIdPerson integer := id_per;
vNombre nvarchar2 (50) :=nom;
vApellido NVARCHAR2(50) := ape;
vGenero NVARCHAR2(15) := gen;
vDire NVARCHAR2 (100):= Dire;
vMuni NVARCHAR2 (50) := Muni;
vCiudad NVARCHAR2 (50):= Ciudad;
vTele NVARCHAR2 (25):= tele;
begin
update Personas set nombres = vnombre, apellidos = vapellido,genero = vGenero,
direccion_persona=vdire,municipio_persona=vmuni, ciudad_persona=vciudad,telefono_persona=vTele
where id_persona = vidperson;
exception
WHEN NO_DATA_FOUND then null;
when others then raise;
End 
Update_Persona;




create or REPLACE procedure delete_Personas(Id_Pers in integer)
as
vIdPersona integer := Id_Pers;
begin 
delete from Personas where id_persona = vidpersona;
end;



--******************************************************************
--******************************************************************
--- 2 Datos Empleados---
create or replace procedure insert_Empleados (dpi_E in nvarchar2,fechaNacimiento in date,
FechaContrato nvarchar2,FechaRegistro in date,id_per in integer, id_hora in integer,id_cargo in integer, id_depa in integer )
as
begin
    insert into Empleados (DPI,fechanacimiento,fechacontrato_empleado,fecharegistro_empleado,
    id_persona,id_horario,id_cargo, id_departamento) 
    values (dpi_E ,fechaNacimiento,
FechaContrato,SYSDATE,id_per, id_hora ,id_cargo, id_depa);
    end;
    

 
create or REPLACE PROCEDURE select_Empleados (registros out SYS_REFCURSOR)
as
begin
open registros for select * from Empleados;
end;



create or REPLACE procedure Update_Empleados(id_Emple integer, dpi_E in nvarchar2, fechaNacimiento date,
FechaContrato nvarchar2,FechaRegistro in date,id_per in integer, id_hora in integer,id_cargo in integer, id_depa in integer)
as
vIdEm integer := id_Emple;
vDpi nvarchar2 (20) :=dpi_E;
vFechaNaci date := fechaNacimiento;
vFechaContra NVARCHAR2(50) := FechaContrato;
vFechaRegis date := FechaRegistro;
vId_Per integer :=id_per ;
vId_Hora integer := id_hora;
vId_Cargo integer := id_cargo;
vId_depa integer :=id_depa;
begin
update Empleados set dpi = vdpi, fechanacimiento = vfechanaci,fechacontrato_empleado = vfechacontra,
fecharegistro_empleado=vfecharegis, id_persona=vId_Per,id_horario=vId_Hora,
id_cargo=vId_Cargo,id_departamento=vid_depa where id_empleado = videm;
exception
WHEN NO_DATA_FOUND then null;
when others then raise;
End 
Update_Empleados;




create or REPLACE procedure delete_Empleados(Id_Emple in integer)
as
vIdEmpleado integer := Id_Emple;
begin 
delete from Empleados where Id_Empleado = vIdEmpleado;
end;




---**************************************************************************++++++++++++++
---***************************************************************************+++++++++++++
-------------3 CLIENTES_______________

create or replace procedure insert_Cliente (Tipo_C in NVARCHAR2,Descripcion nvarchar2, feRegistro in date,Id_pers integer)
as
begin
    insert into Clientes(tipo_cliente,descripcion_cliente,fecharegistro_cliente,id_persona) 
    values (tipo_c,descripcion,feRegistro, id_pers);
    end;
    

--execute insert_Cliente  (Sysdate,3);
--select * from clientes

 
create or REPLACE PROCEDURE select_clientes (registros out SYS_REFCURSOR)
as
begin
open registros for select * from Clientes;
end;


create or REPLACE procedure Update_Clientes(Id_clie integer, Tipo_C in NVARCHAR2,Descripcion nvarchar2, feRegistro in date,Id_pers integer)
as
vIdCli integer := Id_clie;
vTipo NVARCHAR2(50):=tipo_c;
vDescrip NVARCHAR2(50):=descripcion;
vFechaRegis date := feRegistro;
vIdPers integer := id_pers;
begin
update clientes set tipo_cliente=vTipo,descripcion_cliente=vDescrip, fecharegistro_cliente = vfecharegis, id_persona = vidpers where id_cliente = vidcli;
exception
WHEN NO_DATA_FOUND then null;
when others then raise;
End 
Update_Clientes;




create or REPLACE procedure delete_Clientes(Id_Clie in integer)
as
vIdClie integer := Id_Clie;
begin 
delete from Clientes where id_cliente = vidclie;
end;




--++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
---4  Horario---
create or replace procedure insert_Horario (Hora in nvarchar2,TipoHora nvarchar2)
as
begin
    insert into horario(horario,tipohorario) values (hora, tipohora);
    end;
    
 
create or REPLACE PROCEDURE select_Horario (registros out SYS_REFCURSOR)
as
begin
open registros for select * from horario;
end;


create or REPLACE procedure Update_Horario(Id_Hora integer, Hora  nvarchar2, TipoHora  nvarchar2)
as
vIdHora integer := Id_Hora;
vHora NVARCHAR2(25) := hora;
vTipoHora NVARCHAR2(50) := TipoHora;
begin
update horario set horario = vhora, tipohorario = vtipohora where id_horario = vidhora;
exception
WHEN NO_DATA_FOUND then null;
when others then raise;
End 
Update_Horario;




create or REPLACE procedure delete_Horario(Id_Hora in integer)
as
vIdHora integer := Id_Hora;
begin 
delete from horario where id_horario = vidhora;
end;




--++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
--- 5 CARGOS---
create or replace procedure insert_Cargos (NomCargo in nvarchar2,SalCargo decimal)
as
begin
    insert into Cargos (nombrecargo,salariocargo) values (nomcargo, salcargo);
    end;
    

 
create or REPLACE PROCEDURE select_Cargos (registros out SYS_REFCURSOR)
as
begin
open registros for select * from Cargos;
end;


create or REPLACE procedure Update_Cargos(Id_Car integer, NomCargo in nvarchar2,SalCargo decimal)
as
vIdCargo integer := Id_Car;
vNomCargo NVARCHAR2(50) := nomcargo;
vSalCargo decimal(15,2) := salcargo;
begin
update cargos set nombrecargo = vnomcargo, salariocargo = vsalcargo where id_cargo = vidcargo;
exception
WHEN NO_DATA_FOUND then null;
when others then raise;
End 
Update_Cargos;




create or REPLACE procedure delete_Cargos (Id_Car in integer)
as
vIdCar integer := Id_Car;
begin 
delete from Cargos where id_cargo = vidcar;
end;




--++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
--- 6 DEPARTAMENTOS---
create or replace procedure insert_Departamentos (Departa in nvarchar2,DescripDepa nvarchar2)
as
begin
    insert into departamentos (departamento, descripciondepa) values (departa, descripdepa);
    end;
    

 
create or REPLACE PROCEDURE select_Departamentos (registros out SYS_REFCURSOR)
as
begin
open registros for select * from departamentos;
end;


create or REPLACE procedure Update_Departamentos(Id_Depa integer, depa in nvarchar2,descdepa nvarchar2)
as
vIdDepa integer := Id_Depa;
vDepa NVARCHAR2(50) := depa;
vDescdepa NVARCHAR2(50) := descdepa;
begin
update departamentos set departamento = vdepa, descripciondepa = vdescdepa where id_departamento = viddepa;
exception
WHEN NO_DATA_FOUND then null;
when others then raise;
End 
Update_Departamentos;




create or REPLACE procedure delete_Departamentos (Id_depa in integer)
as
vIdDepa integer := Id_depa;
begin 
delete from departamentos where id_departamento = viddepa;
end;


----+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
--- 7 Horas Extras---
create or replace procedure insert_HorasExtras (HoraEx in nvarchar2,DiaHoEx in nvarchar2, fechaHoEx in nvarchar2,
fechaRegisHE in date, IdEmple in integer)
as
begin
    insert into horasextras (horarioextra,dia_horaextra,fecha_horaextra,fecharegistro_he,id_empleado) values 
    (horaex,diahoex,fechahoex,fecharegishe,idemple);
    end;
    

 
create or REPLACE PROCEDURE select_HorasExtras (registros out SYS_REFCURSOR)
as
begin
open registros for select * from horasextras;
end;


create or REPLACE procedure Update_HorasExtras(Id_HoraEx integer, HoraEx in nvarchar2,DiaHoEx nvarchar2,
fechaHoEx nvarchar2,fechaRegisHE date, IdEmple integer)
as
vId_HoraEx integer := id_horaex;
vHoraEx NVARCHAR2(25) := horaex;
vDiaHoEx NVARCHAR2(15) := diahoex;
vFechaHoEx nvarchar2(20):=fechaHoEx;
vFechaRegisHoEx date := fechaRegisHE;
vId_Emple integer := IdEmple;
begin
update horasextras set horarioextra = vhoraex, dia_horaextra =vdiahoex,fecha_horaextra=vfechahoex,
fecharegistro_he=vfecharegishoex,id_empleado=vid_emple  where id_horasextras = vid_horaex;
exception
WHEN NO_DATA_FOUND then null;
when others then raise;
End 
Update_HorasExtras;




create or REPLACE procedure delete_HorasExtras (Id_HoraEx in integer)
as
vIdHoraEx integer := id_horaex;
begin 
delete from horasextras where id_horasextras = vidhoraex;
end;



----+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
--- 8 PROVEEDORES---
create or replace procedure insert_Proveedores (NomCompania in nvarchar2,Direc in nvarchar2,
Muni in NVARCHAR2,Ciudad in NVARCHAR2,Tele in NVARCHAR2,fechaRegisProvee in date)
as
begin
    insert into proveedores (nombrecompania,"DIRECCION_COMPAÑIA","MUNICIPIO_COMPAÑIA",
    "CIUDAD_COMPAÑIA","TELEFONO_COMPAÑIA",fecharegistro_proveedor) 
    values (nomcompania,direc,muni,ciudad,tele,fecharegisprovee);
    end;
    

 
create or REPLACE PROCEDURE select_Proveedores (registros out SYS_REFCURSOR)
as
begin
open registros for select * from proveedores;
end;


create or REPLACE procedure Update_Proveedores(Id_Provee integer, nomcomp in nvarchar2,Direc in nvarchar2,
Muni in NVARCHAR2,Ciudad in NVARCHAR2,Tele in NVARCHAR2,fechaRegisProvee in date)
as
vId_Provee integer := id_provee;
vNomComp NVARCHAR2(100) := nomcomp;
vDireccion NVARCHAR2(100) :=direc;
vMuni NVARCHAR2 (50):=muni;
vCiudad NVARCHAR2(50):=Ciudad;
vTele nvarchar2(25):=Tele;
vFechaRegisProv date := fechaRegisProvee;
begin
update proveedores set nombrecompania = vnomcomp,Direccion_Compañia=vDireccion,Municipio_Compañia=vMuni,
Ciudad_Compañia=vCiudad,Telefono_Compañia = vTele,fecharegistro_proveedor =vfecharegisprov
 where id_proveedor = vid_provee;
exception
WHEN NO_DATA_FOUND then null;
when others then raise;
End 
Update_Proveedores;


create or REPLACE procedure delete_Proveedores (Id_Provee in integer)
as
vIdProvee integer := id_provee;
begin 
delete from Proveedores where id_proveedor = vidprovee;
end;




----+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
--- 9 USUARIOS---
create or replace procedure insert_Usuarios (NomUser in nvarchar2,contra in nvarchar2,fechaRegisUser in date,IdEmp in integer)
as
begin
    insert into usuarios (nombreusuario,Contraseña,fecharegistro_usuario,id_empleados) values 
    (nomuser,contra,fecharegisuser,idemp);
    end;
    

 
create or REPLACE PROCEDURE select_Usuarios (registros out SYS_REFCURSOR)
as
begin
open registros for select * from Usuarios;
end;


create or REPLACE procedure Update_Usuarios(Id_User integer, NomUser in nvarchar2,contra in nvarchar2,fechaRegisUser in date,IdEmp in integer)
as
vId_User integer := id_user;
vNomuser NVARCHAR2(50) := nomuser;
vContra nvarchar2 (25):= contra;
vFechaRegisUser date := fecharegisuser;
vId_Emp integer := idemp;
begin
update Usuarios set nombreusuario = vnomuser, Contraseña=vcontra, fecharegistro_usuario=vfecharegisuser,
id_empleados=vId_Emp where id_usuario = vid_user;
exception
WHEN NO_DATA_FOUND then null;
when others then raise;
End 
Update_Usuarios;


create or REPLACE procedure delete_Usuarios (Id_User in integer)
as
vIduser integer := id_user;
begin 
delete from usuarios where id_usuario = viduser;
end;



--++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
-----10  Productos-------------------

create or replace procedure insert_Productos (nomProd in nvarchar2,TipoP in NVARCHAR2,precioComp in decimal,PrecioVen in decimal,NumStock in integer, fechaRegProd in date)
as
begin
    insert into productos (nombreproducto,tipo_producto, preciocompra, precioventa,numero_stock,fecharegistro_producto)
    values 
    (nomprod,tipop,preciocomp,precioven,numstock,fecharegprod);
    end;
    

 
create or REPLACE PROCEDURE select_Productos (registros out SYS_REFCURSOR)
as
begin
open registros for select * from productos;
end;


create or REPLACE procedure Update_Productos(Id_Product integer, NomProd in nvarchar2,TipoP in NVARCHAR2,precioComp in decimal,PrecioVen in decimal,NumStock in integer, fechaRegProd in date)
as
vId_Produ integer := id_product;
vNomProd NVARCHAR2(50) := nomprod;
vTipoP nvarchar2(50) := tipop;
vPrecioComp decimal(15,2):= preciocomp;
vPrecioVen decimal(15,2):= precioven;
vNumStock integer := numstock;
vFechaRegProd date := fecharegprod;
begin
update productos set nombreproducto = vnomprod,Tipo_Producto=vtipop,preciocompra=preciocomp,precioventa=vprecioven,
numero_stock=vnumstock,fecharegistro_producto=vfecharegprod
where id_producto = vid_produ;
exception
WHEN NO_DATA_FOUND then null;
when others then raise;
End 
Update_Productos;


create or REPLACE procedure delete_Productos (Id_Prod in integer)
as
vIdProd integer := id_prod;
begin 
delete from productos where id_producto = vidprod;
end;



--+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
----11 TIPO PAGO---
create or replace procedure insert_TipoPago (descripcion in nvarchar2)
as
begin
    insert into tipopago (descripcion_tipopago) values 
    (descripcion);
    end;
    

 
create or REPLACE PROCEDURE select_TipoPago (registros out SYS_REFCURSOR)
as
begin
open registros for select * from tipopago;
end;


create or REPLACE procedure Update_TipoPago(Id_TipPag integer, descripTipoPag in nvarchar2)
as
vId_TipPag integer := id_tippag;
vDescripTipPag NVARCHAR2(50) := descriptipopag;
begin
update tipopago set descripcion_tipopago = vdescriptippag where id_tipopago = vid_tippag;
exception
WHEN NO_DATA_FOUND then null;
when others then raise;
End 
Update_TipoPago;


create or REPLACE procedure delete_TipoPago (Id_TipPag in integer)
as
vIdTipPag integer := id_tippag;
begin 
delete from tipopago where id_tipopago = vidtippag;
end;



---++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
-----12 Compras

create or replace procedure insert_Compras (cantProd in integer,costou in decimal,Precioto in decimal,
fechaRegComp in date,IdProdu in integer, IdProvee in integer,IdEmple in integer, IdTipPag in integer)
as
begin
    insert into Compras (cantidadproducto,costounitario,preciototal,fecharegistro_compras,id_producto,id_proveedor,id_empleado,id_tipopago)
    values 
    (cantprod,costou,precioto,fecharegcomp,idprodu,idprovee,idemple,idtippag);
    end;
    

 
create or REPLACE PROCEDURE select_Compras (registros out SYS_REFCURSOR)
as
begin
open registros for select * from Compras;
end;


create or REPLACE procedure Update_Compras(Id_Comp in integer, cantProd in integer,costou in decimal,Precioto in decimal,
fechaRegComp in date,IdProdu in integer, IdProvee in integer,IdEmple in integer, IdTipPag in integer)
as
vId_Comp integer := id_comp;
vCantProd integer :=cantprod ;
vCostU decimal(15,2):= costou;
vPreTotal decimal(15,2):= precioto;
vFechaRegComp date := fecharegcomp;
vIdProd integer := idprodu;
vIdProv integer := idprovee;
vIdEmple integer:=idemple;
vIdTipPag integer :=idtippag;
begin
update Compras set cantidadproducto= vcantProd,costounitario=vCostU,preciototal=vPreTotal,
fecharegistro_compras= vfechaRegComp,id_producto=vIdProd,id_proveedor=vIdProv,id_empleado=vIdEmple,
id_tipopago=vidtippag
where id_compra = vid_comp;
exception
WHEN NO_DATA_FOUND then null;
when others then raise;
End 
Update_Compras;



create or REPLACE procedure delete_Compras (Id_Comp in integer)
as
vIdComp integer := id_comp;
begin 
delete from Compras where id_compra = vidcomp;
end;




--+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
----13 ventas-----

create or replace procedure insert_Ventas (cantProd in integer,costou in decimal,Precioto in decimal,
fechaRegven in date,IdProdu in integer,IdEmple in integer,IdCliente in integer, IdTipPag in integer)
as
begin
    insert into Ventas (cantidad_producto,preciounitario,costototal,fecharegistro_ventas,id_producto,id_empleado,id_cliente,id_tipopago)
    values 
    (cantprod,costou,precioto,fecharegven,idprodu,idemple,idcliente,idtippag);
    end;
    
select * FROm TipoPago
 
create or REPLACE PROCEDURE select_Ventas (registros out SYS_REFCURSOR)
as
begin
open registros for select * from ventas;
end;


create or REPLACE procedure Update_Ventas(Id_ven in integer, cantProd in integer,costou in decimal,Precioto in decimal,
fechaRegven in date,IdProdu in integer, IdEmple in integer,Idclien in integer, IdTipPag in integer)
as
vId_ven integer := id_ven;
vCantProd integer :=cantprod ;
vCostU decimal(15,2):= costou;
vPreTotal decimal(15,2):= precioto;
vFechaRegVen date := fecharegven;
vIdProd integer := idprodu;
vIdEmple integer:=idemple;
vIdclien integer := idclien;
vIdTipPag integer :=idtippag;
begin
update Ventas set cantidad_producto= vcantProd,preciounitario=vCostU,costototal=vPreTotal,
fecharegistro_ventas= vfecharegven,id_producto=vIdProd,id_empleado=vIdEmple,Id_Cliente=vIdclien,
id_tipopago=vidtippag
where id_venta = vid_ven;
exception
WHEN NO_DATA_FOUND then null;
when others then raise;
End 
Update_Ventas;



create or REPLACE procedure delete_Ventas (Id_ven in integer)
as
vIdven integer := id_ven;
begin 
delete from Ventas where id_venta = vidven;
end;












