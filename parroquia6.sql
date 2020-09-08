create database Parroquia6
go
use Parroquia6
go

create table tbltipo_sangre(
idtiposangre int Primary key identity(1,1),
descripcion varchar(10)
);
go
create table tbldireccion (
iddireccion int Primary Key identity(1,1),
calle_principal varchar(50),
calle_secundaria varchar(50),
numero_casa varchar(20),
referencia varchar(100),
sector varchar(50)
);
go
create table tblrepresentante(
idrepresentante int Primary Key identity(1,1),
nombrespadre varchar(50),
apellidopadre varchar(50),
ocupacionpadre varchar(50),
nombremadre varchar(50),
apellidomadre varchar(50),
ocupacionmadre varchar(50),
casoemergencia varchar(100),
parentesco varchar(50),
telefonorepre varchar(10),
celularrepre varchar(10)
); 
go

create table tblcatequizado_estudiante(
cedula_caes varchar(10) primary key,
nombre varchar(50),
apellidos varchar(50),
fecha_nacimiento date,
correo_cate varchar (50),
alergia varchar(100),
tipo_sangre int foreign Key references tbltipo_sangre(idtiposangre),

celulares varchar(10),
telefonoes varchar(10),
direccion int foreign Key references tbldireccion(iddireccion),
fortalezas varchar(50),
representante int foreign key references tblrepresentante(idrepresentante)); 
go
create table tbltalleres(
idtalleres int Primary Key identity(1,1),
descripcion varchar(100) 
);
go
create table tbltallerestudiante(
idtallerestudiante int Primary Key identity(1,1),
idestudiante varchar(10) Foreign Key references tblcatequizado_estudiante(cedula_caes),
idtalleres int Foreign Key references tbltalleres(idtalleres),
fecha date
);
alter table tbltallerestudiante add periodo varchar(100)
go 
create table tblsacramentos(
idsacramentos int Primary Key identity(1,1),
descripcion varchar(100)
);
go
create table tblsacramentoestudiante(
idsacramentoestudiante int Primary Key identity(1,1),
idestudiante varchar(10) Foreign Key references tblcatequizado_estudiante(cedula_caes),
idsacramentos int Foreign Key references tblsacramentos(idsacramentos),
periodo varchar(100),
fecha date
);
create table tblpadrinos(
idpadrino int Primary Key identity(1,1),
nombrespadrino1 varchar(50),
apellidospadrino1 varchar(50),
);
alter table tblpadrinos add correo varchar(150)
alter table tblpadrinos add celular varchar(10)
go
create table tblbautismo (
idbautismo int Primary Key identity(1,1),
cedula varchar(10) foreign key references tblcatequizado_estudiante(cedula_caes),
libro varchar(5),
fechainicio date,
fechafin date,
parroquia varchar(100),
aprueba int
);
go
create table tblpadrino_bautismo(
idpadrino_comunion int primary key identity(1,1),
idbautismo int foreign key references tblbautismo(idbautismo),
idpadrino int foreign key references tblpadrinos(idpadrino)
);
go
create table tblcomunion1(
idtblc1 int primary key identity(1,1),
cedula varchar(10) foreign key references tblcatequizado_estudiante(cedula_caes),
libro varchar(5),
fechainicio date,
fechafin date,
parroquia varchar(100),
aprueba int
);
go
create table tblcomunion2(
idtblc2 int primary key identity(1,1),
cedula varchar(10) foreign key references tblcatequizado_estudiante(cedula_caes),
libro varchar(5),
fechainicio date,
fechafin date,
parroquia varchar(100),
aprueba int
);
go
create table tblcomunionf(
idtblc int primary key identity(1,1),
cedula varchar(10) foreign key references tblcatequizado_estudiante(cedula_caes),
libro varchar(5),
fechainicio date,
fechafin date,
parroquia varchar(100),
aprueba int
);
go
create table tblpadrino_comunion(
idpadrino_comunion int primary key identity(1,1),
idtblc int foreign key references tblcomunionf(idtblc),
idpadrino int foreign key references tblpadrinos(idpadrino)
);
go
create table tblconfirmacion1(
idtblcf1 int primary key identity(1,1),
cedula varchar(10) foreign key references tblcatequizado_estudiante(cedula_caes),
libro varchar(5),
fechainicio date,
fechafin date,
parroquia varchar(100),
aprueba int
);
go
create table tblconfirmacion2(
idtblcf2 int primary key identity(1,1),
cedula varchar(10) foreign key references tblcatequizado_estudiante(cedula_caes),
libro varchar(5),
fechainicio date,
fechafin date,
parroquia varchar(100),
aprueba int
);
go
create table tblconfirmacionf(
idtblcf int primary key identity(1,1),
cedula varchar(10) foreign key references tblcatequizado_estudiante(cedula_caes),
libro varchar(5),
fechaconfirmacion date,
fechafin date,
parroquia varchar(100),
aprueba int
);
go
create table tblpadrino_confirmacion(
idpadrino_confirmacion int primary key identity(1,1),
idtblc int foreign key references tblconfirmacionf(idtblcf),
idpadrino int foreign key references tblpadrinos(idpadrino)
);
go
create table tblmatrimonio (
idmatrimonio int Primary Key identity(1,1),
fechamatrimonio date,
libromatrimonio varchar(10),
parroquiasegundonivelconfirmacion  varchar(100),
cedulanovio varchar(10) foreign key references tblcatequizado_estudiante(cedula_caes),
cedulanovia varchar(10) foreign key references tblcatequizado_estudiante(cedula_caes)
);
go
create table tblpadrino_matrimonio(
idpadrino_matrimonio int primary key identity(1,1),
idtblc int foreign key references tblmatrimonio(idmatrimonio),
idpadrino int foreign key references tblpadrinos(idpadrino)
);
go
create procedure Ingreso_Tipo_Sangre
@tipo varchar(50)
AS
begin
	begin try 
		begin transaction
			insert into tbltipo_sangre(descripcion )
			values(@tipo)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch

END

go
exec Ingreso_Tipo_Sangre '0+';
go
exec Ingreso_Tipo_Sangre '0-';
go
exec Ingreso_Tipo_Sangre 'A+';
go
exec Ingreso_Tipo_Sangre 'A-';
go
exec Ingreso_Tipo_Sangre 'B+';
go
exec Ingreso_Tipo_Sangre 'B-';
go
exec Ingreso_Tipo_Sangre 'AB+';
go
exec Ingreso_Tipo_Sangre 'AB-';
go
create view vw_TipoSangre
as
select * from tbltipo_sangre
go
------------------------------------------------------------------

create procedure Ingreso_Direccion
@calleP varchar(50),
@calleS varchar(50),
@numCasa varchar(20),
@ref varchar(100),
@sector varchar(50)
AS
begin
	begin try 
		begin transaction
			insert into tbldireccion(calle_principal,calle_secundaria,numero_casa,referencia,sector)
			values(@calleP,@calleS,@numCasa,@ref,@sector)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch

END
go
exec Ingreso_Direccion 'Juan Aleman', 'Jose Velda',  'N71-119','Cerca del parque ecologico Maria Urrutia' , 'Solanda';
go
exec Ingreso_Direccion 'Av. Solanda', 'Juan Barreiro','N76-118', ' A dos cuadras del mercado Solanda', 'Chillogallo';
go
exec Ingreso_Direccion 'Jose Arbudo', 'Juan nu%ez','S25-101','Frente a la escuela Eduardo Basquez Dodero', 'Solanda';
go
exec Ingreso_Direccion 'J Barrera','Cusubamba', 'G23-85', 'Cerca del parque ciudadela del comercio' ,'Chillogallo';
go
exec Ingreso_Direccion 'Apuela', 'Palmares', 'S26E','Frente a la unidad educativa Francisco Zurita Guayasamin','Gatazo ';
go
create view vw_Direccion
as
select * from tbldireccion
go
-----------------------------------------------------------------------------------------------------------------------------
create procedure Ingreso_Representante
@nombrespadre varchar(50),
@apellidopadre varchar(50),
@ocupacionpadre varchar(50),
@nombremadre varchar(50),
@apellidomadre varchar(50),
@ocupacionmadre varchar(50),
@casoemergencia varchar(100),
@parentesco varchar(50),
@telefonorepre varchar(10),
@celularrepre varchar(10)
AS
begin
	begin try 
		begin transaction
			insert into tblrepresentante(nombrespadre,apellidopadre ,ocupacionpadre, nombremadre,apellidomadre,ocupacionmadre,casoemergencia,parentesco,telefonorepre,celularrepre )
			values(@nombrespadre,@apellidopadre,@ocupacionpadre,@nombremadre,@apellidomadre,@ocupacionmadre,@casoemergencia,@parentesco,@telefonorepre,@celularrepre)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch

END
go
exec Ingreso_Representante'Juan','Morales','carpintero','María','Cruz','Ama de casa','Pedro Vasquez','tío','2494858','0996804425';
go
exec Ingreso_Representante 'Jaime','Peréz','albañil','Laura','Martinez','enfermera','Laura Matinez','mama','2412358','0912344425';
go
exec Ingreso_Representante 'Fernando','Oña','diseñador','Lorena','Muñoz','cocinera','Clemencia Delgado','abuela','4512358','0882344425';
go
exec Ingreso_Representante 'Cristofer','Carrion','electricista','Andrea','Bolivar','locutora','Andrea Bolivar','mama','2412536','0986223345';
go
exec Ingreso_Representante 'Medardo','Canencia','zapatero','Ibeth','Simbaña','mesera','Luis Simbaña','abuelo','45555558','0882498125';
go
exec Ingreso_Representante 'Miguel','Guitierrez','fotógrafo','Solange','Bastidas','dentista','Maribel Ordoñez','tía','45249458','0891238125';
go
create view vw_Representante
as
select * from tblrepresentante
go
---------------------------------------------------------------------------------------------------------------------------------
create procedure Ingreso_CateEstudiante
@cedula_caes varchar(10),
@nombre varchar(50),
@apellidos varchar(50),
@fecha_nacimiento date,
@correo_cate varchar (50),
@alergia varchar(100),
@tipo_sangre int ,

@celulares varchar(10),
@telefonoes varchar(10),
@direccion int ,
@fortalezas varchar(50),
@representante int 
AS
begin
	begin try 
		begin transaction
			insert into tblcatequizado_estudiante(cedula_caes,nombre, apellidos, fecha_nacimiento,correo_cate, alergia,tipo_sangre,celulares,telefonoes,direccion,fortalezas,representante)
			values(@cedula_caes,@nombre,@apellidos,@fecha_nacimiento,@correo_cate,@alergia,@tipo_sangre,@celulares,@telefonoes,@direccion,@fortalezas,@representante)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch

END
go
exec Ingreso_CateEstudiante '1751352651','Pablo','Hidalgo','17/08/2000','pablo_hida@outlook.com','Frío','1','0996847733','45249458','1','Fuerte','1';
go
exec Ingreso_CateEstudiante '0451322251','Alejandra','Flores','17/08/2005','ale_bonita69@outlook.com','Chocolate','2','092468733','4129458','1','Paciente','1';
go
exec Ingreso_CateEstudiante '1704921475','José','Pupiales','02/11/2005','jose.pupi@outlook.com','animales','3','092549833','4658741','2','Paciente','2';
go
exec Ingreso_CateEstudiante '1722979133','Adrian','Miño','05/10/2004','gordo_mino@outlook.com','café','4','095555553','4622222','3','Paciente','3';
go
exec Ingreso_CateEstudiante '1768689133','Monica','Delgado','10/09/2010','monadel@outlook.com','penicilina','5','095456253','4621232','4','Paciente','4';
GO
exec Ingreso_CateEstudiante '1761189133','José','Delgado','11/09/2011','josedel@outlook.com','penicilina','5','095456253','4621232','4','Paciente','4'
go
go
create view vw_CateEstudiante
as
select * from tblcatequizado_estudiante
go

--------------------------------------------------------------------------------------------------------------------------------------------------
create procedure Ingreso_Talleres
@taller varchar(100)
AS
begin
	begin try 
		begin transaction
			insert into tbltalleres(descripcion)
			values(@taller)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch

END
go
exec Ingreso_Talleres 'Matematica';
go
exec Ingreso_Talleres 'Fisica';
go
exec Ingreso_Talleres 'Ingles';
go
exec Ingreso_Talleres 'Artes';
go
exec Ingreso_Talleres 'Emprendimiento';
go
create view vw_Talleres
as
select * from tbltalleres
go
----------------------------------------------------------------------------------------------------------------------------

DROP procedure IngresoTallerEs
@estudiante int,
@taller int,
@fecha date
AS
begin
	begin try 
		begin transaction
			insert into tbltallerestudiante(idestudiante,idtalleres,fecha)
			values(@estudiante, @taller,@fecha)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch
END
go
exec IngresoTallerEs '1751352651','5','2020-08-29';
go
exec IngresoTallerEs '1768689133','4','2020-08-29';
go---ELIMINACION DE ESTE PROCESO
-------------------------------------------------------------------------------
CREATE procedure IngresoTallerEs
@estudiante int,
@taller int,
@periodo varchar(100),
@fecha date
AS
begin
	begin try 
		begin transaction
			insert into tbltallerestudiante(idestudiante,idtalleres,periodo,fecha)
			values(@estudiante, @taller,@periodo,@fecha)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch
END
go
exec IngresoTallerEs '1751352651','5','2020-A','2020-08-29';
go
exec IngresoTallerEs '1768689133','4','2020-B','2020-08-29';
go
exec IngresoTallerEs '1704921475','2','2020-A','2020-08-29';
go
select * from tbltallerestudiante
---------------------------------------------------------
GO
create procedure Ingreso_Sacramentos
@sacramento varchar(100)
AS
begin
	begin try 
		begin transaction
			insert into tblsacramentos(descripcion)
			values(@sacramento)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch
END
go
exec Ingreso_Sacramentos 'Bautismo';
go
exec Ingreso_Sacramentos 'Comunión 1';
go
exec Ingreso_Sacramentos 'Comunión 2';
go
exec Ingreso_Sacramentos 'Confirmación 1';
go
exec Ingreso_Sacramentos'Confirmación 2';
go
create view vw_Sacramentos
as
select * from tblsacramentos
go
--------------------------------------------------------
create procedure IngresoSacramentos
@estudiante int,
@sacramento int,
@periodo varchar(10),
@fecha date
AS
begin
	begin try 
		begin transaction
			insert into tblsacramentoestudiante(idestudiante,idsacramentos,periodo,fecha)
			values(@estudiante, @sacramento,@periodo,@fecha)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch
END
go
exec IngresoSacramentos '1761189133','1','2020-A','2020-08-29';
go
exec IngresoSacramentos '1704921475','2','2020-A','2020-08-29';
go

select * from tblsacramentoestudiante
go
----------------------------------------------------------------------------
go
alter procedure IngresoPadrinos
@nomb varchar(50),
@apelli varchar(50),
@correo varchar(150),
@celular varchar(10)
AS
begin
	begin try 
		begin transaction
			insert into tblpadrinos(nombrespadrino1,apellidospadrino1,correo,celular)
			values(@nomb, @apelli,@correo,@celular)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch
END
go
--exec IngresoPadrinos 'Lucrecia Maribel','Vizuete Remache'
--go
--exec IngresoPadrinos 'Julio Fernando','Santamria Oña'
--go
--exec IngresoPadrinos 'José Jefferson','Cueva Prieto'
--go
--exec IngresoPadrinos 'Luis Miguel','Quinatoa Moposita'
--go
--exec IngresoPadrinos 'Gabriel Eduardo','López Fonseca'
--go
----------------------------------------------------------------------------------
create procedure IngresoBautiso
@fechabautismo date,
@libro varchar(10),
@cedula varchar (10) 
AS
begin
	begin try 
		begin transaction
			insert into tblpadrinos
			values(@fechabautismo,@libro,@cedula)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch
END
go
exec Ingreso_Representante '15/11/2019','Libro 1','1'
go
exec Ingreso_Representante '05/02/2020','Libro 2','2'
go
exec Ingreso_Representante '22/06/2020','Libro 3','3'
go
----------------------------------------------------------------------------------------------
go

--------------------------------------------------------------------------------
go
alter view BusquedaFeligresesT
as
select a.cedula_caes as CEDULA , a.nombre as NOMBRE,a.apellidos as APELLIDOS,a.fecha_nacimiento as FECHA_NACIMIENTO,a.alergia , b.descripcion as TIPO_DE_SANGRE,a.celulares as CELULAR,a.telefonoes as TELEFONO, c.calle_principal as CALLE_PRINCIPAL, c.calle_secundaria as CALLE_SECUNDARIA,c.numero_casa as NUMCASA,c.sector as SECTOR, c.referencia as REFERENCIA, a.fortalezas as FORTALEZAS,
d.nombrespadre, d.apellidopadre ,d.ocupacionpadre, d.nombremadre ,d.apellidomadre,d.ocupacionmadre,d.casoemergencia,d.parentesco,d.telefonorepre,d.celularrepre
from tblcatequizado_estudiante a inner join tbltipo_sangre b on a.tipo_sangre = b.idtiposangre
inner join tbldireccion c
on a.direccion = c.iddireccion
inner join tblrepresentante d
on a.representante = d.idrepresentante
go
select * from BusquedaFeligresesT where CEDULA = '1704921475'

GO 
ALTER DATABASE Parroquia6 set TRUSTWORTHY ON; 
GO 
EXEC dbo.sp_changedbowner @loginame = N'sa', @map = false 
GO 
sp_configure 'show advanced options', 1; 
GO 
RECONFIGURE; 
GO 
sp_configure 'clr enabled', 1; 
GO 
RECONFIGURE; 
GO
-----------------------------------------------------------------------------------------------
create procedure Ingreso_bautizo
@cedula varchar(10),
@libro varchar(5),
@fechafin date,
@parroquia varchar(100)
AS
begin
	begin try 
		begin transaction
			insert into tblbautismo(cedula,libro,fechafin,parroquia)
			values(@cedula,@libro,@fechafin,@parroquia)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch
END
go
exec Ingreso_bautizo '1722979133','C','08/07/2020','San Ignacio'

exec Ingreso_bautizo '0451322251','A','08/07/2003','San Fernando'
exec Ingreso_bautizo '1704921475','B','10/07/2004','San Luis'
exec Ingreso_bautizo '1751352651','A','08/07/2003','San Ignacio'
exec Ingreso_bautizo '1768689133','B','10/07/2004','San Ignacio'

-------------------------------------------------------------------------------------------------
go
create procedure Ingreso_1comunion
@cedula varchar(10),
@libro varchar(5),
@fechainicio date,
@fechafin date,
@parroquia varchar(100)
AS
begin
	begin try 
		begin transaction
			insert into tblcomunion1(cedula,libro,fechainicio,fechafin,parroquia)
			values(@cedula,@libro,@fechainicio,@fechafin,@parroquia)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch
END
go
exec Ingreso_1comunion '0451322251','A','04/05/2008','08/07/2008','San vicente'
exec Ingreso_1comunion '1704921475','B','04/05/2008','06/07/2008','San Vicente '
exec Ingreso_1comunion '1751352651','A','10/05/2009','08/07/2009','San Ignacio'
exec Ingreso_1comunion '1768689133','B','12/04/2009','10/07/2009','San Ignacio'

----------------------------------------------------------------------------------
go
create procedure Ingreso_2comunion
@cedula varchar(10),
@libro varchar(5),
@fechainicio date,
@fechafin date,
@parroquia varchar(100)
AS
begin
	begin try 
		begin transaction
			insert into tblcomunion2(cedula,libro,fechainicio,fechafin,parroquia)
			values(@cedula,@libro,@fechainicio,@fechafin,@parroquia)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch
END
go
exec Ingreso_2comunion '0451322251','A','12/08/2008','15/10/2008','San Ignacio '
exec Ingreso_2comunion '1704921475','B','12/08/2008','12/10/2008','San Vicente '
exec Ingreso_2comunion '1751352651','A','10/07/2009','08/11/2009','San Ignacio'
exec Ingreso_2comunion '1768689133','B','12/07/2009','10/11/2009','San Ignacio'
------------------------------------------------------------------------------
go
create procedure Ingreso_1confirmacion
@cedula varchar(10),
@libro varchar(5),
@fechainicio date,
@fechafin date,
@parroquia varchar(100)
AS
begin
	begin try 
		begin transaction
			insert into tblconfirmacion1(cedula,libro,fechainicio,fechafin,parroquia)
			values(@cedula,@libro,@fechainicio,@fechafin,@parroquia)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch
END
go
exec Ingreso_1confirmacion '1704921475','B','12/08/2009','15/10/2009','San Ignacio '
exec Ingreso_1confirmacion '1751352651','A','10/11/2009','08/02/2010','San Ignacio'
exec Ingreso_1confirmacion '1768689133','B','12/11/2009','10/02/2010','San Ignacio'
---------------------------------------------------------------------------------------------
go
create procedure Ingreso_2confirmacion
@cedula varchar(10),
@libro varchar(5),
@fechainicio date,
@fechafin date,
@parroquia varchar(100)
AS
begin
	begin try 
		begin transaction
			insert into tblconfirmacion2(cedula,libro,fechainicio,fechafin,parroquia)
			values(@cedula,@libro,@fechainicio,@fechafin,@parroquia)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch
END
go
exec Ingreso_2confirmacion '1751352651','A','10/02/2010','08/05/2010','San Ignacio'
exec Ingreso_2confirmacion '1768689133','B','12/02/2010','10/05/2010','San Ignacio'
-------------------------------------------------------------------------------------
go
create procedure IngresoEBautizo
@cedula varchar(10),
@fechafin date
AS
begin
	begin try 
		begin transaction
			insert into tblbautismo(cedula,fechafin)
			values(@cedula,@fechafin)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch
END
go

create procedure IngresoPadriBautizo
@fkbautiso int,
@fkpadrino int
AS
begin
	begin try 
		begin transaction
			insert into tblpadrino_bautismo(idbautismo,idpadrino)
			values(@fkbautiso,@fkpadrino)
			commit transaction
		end try
	begin catch
		print 'No se puede ejecutar'
		rollback transaction
	end catch
END
go
select * from tblpadrinos
SELECT @@IDENTITY
SELECT * FROM tblpadrinos Where idpadrino =( SELECT max(idpadrino) FROM tblpadrinos)

---------------------------------------------------------------------------------------
go
create view BusquedaFeligreses
as
select a.nombre as NOMBRE,a.apellidos as APELLIDO,a.cedula_caes as CEDULA ,a.fecha_nacimiento AS FECHA_NACIMIENTO,a.correo_cate AS CORREO ,a.celulares as CELULAR  , b.descripcion as TIPO_SANGRE, c.sector as SECTOR
from tblcatequizado_estudiante a INNER join tbltipo_sangre b
on a.tipo_sangre = b.idtiposangre
INNER join tbldireccion c
on a.direccion = c.iddireccion
------------------------------------------------------------------------------------------
GO
CREATE view BusquedaTaller
as
select b.nombre,b.apellidos,c.descripcion,a.periodo
from tbltallerestudiante a INNER join tblcatequizado_estudiante b
on a.idestudiante =  b.cedula_caes
INNER join tbltalleres c
on a.idtalleres= c.idtalleres
-----------------------------------------------------------------------------------
GO
create view BusquedaSacramento
as
select b.nombre,b.apellidos,c.descripcion,a.periodo
from tblsacramentoestudiante a INNER join tblcatequizado_estudiante b
on a.idestudiante =  b.cedula_caes
INNER join tblsacramentos c
on a.idsacramentos= c.idsacramentos