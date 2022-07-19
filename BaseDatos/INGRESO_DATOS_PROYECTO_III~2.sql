--++++++++++++++++++++++++++++++++++++++++++++++++++
-----Ingreso de datos previos---------
------Horario-----
execute insert_Horario  ('8:00 - 16:00 Horas', 'Completo');
execute insert_Horario  ('8:00 - 12:00 Horas', 'Medio Tiempo');
execute insert_Horario  ('12:00 - 16:00 Horas', 'Medio Tiempo');

select * from Horario;



-----Cargos----
execute insert_Cargos  ('Administrador', 10000);
execute update_Cargos  (2,'Cajero', 4000);
execute insert_Cargos  ('Repartidor', 4000);

select * from cargos;



-----Departamentos
execute insert_Departamentos  ('Produccion','Ubicacion, sotano');
execute insert_Departamentos  ('Ventas','servicio personalizado');
execute insert_Departamentos  ('Contabilidad',' ');

select * from Departamentos;




-----Tipo Pago

execute insert_TipoPago  ('Efectivo');
execute insert_TipoPago  ('Con Tarjeta');
execute insert_TipoPago  ('Con cheque');


select * from tipopago;





