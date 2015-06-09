/********************************************* INICIO - CREACION ESQUEMA *******************************************/

USE GD1C2015;
GO
/*CREATE SCHEMA THE_ULTIMATES AUTHORIZATION gd

GO */

/********************************************* FIN - CREACION ESQUEMA **********************************************/

/******************************************** INICIO - CREACION DE TABLAS ******************************************/

create table THE_ULTIMATES.Rol( 
	rol_id int CONSTRAINT PK_rol_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	rol_desc varchar(15),
	rol_activo bit DEFAULT 1  
);

GO	

create table THE_ULTIMATES.Funcionalidad(
	func_id int CONSTRAINT PK_func_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	func_desc varchar(60)
);

GO
	
create table THE_ULTIMATES.Funcionalidad_Rol(
	func_rol_rol_id int  not null, /* FK  THE_ULTIMATES.Rol*/
	func_rol_func_id int not null,/* FK  THE_ULTIMATES.Funcionalidad*/
	CONSTRAINT PK_funcionalidad_rol PRIMARY KEY (func_rol_rol_id, func_rol_func_id)
); 

GO

create table THE_ULTIMATES.Usuario(
	usu_id int CONSTRAINT PK_usu_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	usu_username varchar(25) not null UNIQUE,
	usu_password char(64) not null,
	usu_fecha_alta datetime not null,
	usu_fecha_mod datetime null,
	usu_pregunta varchar(50),
	usu_respuesta char(64),
	usu_activo bit DEFAULT 0,
	usu_intentos_fallidos int not null,
);

GO

create table THE_ULTIMATES.Rol_Usuario(
	rol_usu_rol_id int  not null, /* FK  THE_ULTIMATES.Rol*/
	rol_usu_usu_id int  not null,  /* FK  THE_ULTIMATES.Usuario*/
	CONSTRAINT PK_rol_usuario PRIMARY KEY (rol_usu_rol_id, rol_usu_usu_id)
);
	
GO

create table THE_ULTIMATES.Acceso_Log(
	acc_id int CONSTRAINT PK_acc_id PRIMARY KEY not null IDENTITY(1,1),
	acc_usu_id int  not null, /* FK  THE_ULTIMATES.Usuario*/
	acc_fecha datetime not null,
	acc_correcto bit not null,
	acc_intent_fallido int not null
);

GO
	
create table THE_ULTIMATES.Pais(
	pais_id numeric(18,0) CONSTRAINT PK_pais_id PRIMARY KEY not null IDENTITY(1,1),
	pais_desc varchar(250) not null
);

GO

create table THE_ULTIMATES.Tipo_Doc(
	tipo_doc_id numeric(18,0) CONSTRAINT PK_tipo_doc_id PRIMARY KEY not null IDENTITY(1,1),
	tipo_doc_desc varchar(255) not null
);

GO
	
create table THE_ULTIMATES.Cliente(
	clie_id int CONSTRAINT PK_clie_id PRIMARY KEY not null IDENTITY(1,1),
	clie_nombre varchar(255) not null,
	clie_apellido varchar(255) not null,
	clie_nro_doc numeric(18,0) not null unique, 
	clie_tipo_doc_id numeric(18,0) not null, /* FK  THE_ULTIMATES.Tipo_Doc*/
	clie_mail varchar(255) not null unique,
	clie_activo bit not null,
	clie_dom_calle varchar(255) not null,
	clie_dom_numero numeric(18,0) not null,
	clie_dom_piso numeric(18,0) null,
	clie_dom_depto varchar(10),
	clie_fecha_nac datetime not null,
	clie_pais_id numeric(18,0) not null, /* FK  THE_ULTIMATES.Pais*/
	clie_usu_id int
);

GO
	
create table THE_ULTIMATES.Cuenta(
	cuen_id numeric(18,0) CONSTRAINT PK_cuen_id PRIMARY KEY not null IDENTITY(1,1),
	cuen_clie_id int not null, /* FK  THE_ULTIMATES.Cliente*/
	cuen_tipo_cuenta_id int not null, /* FK  THE_ULTIMATES.Tipo_Cuenta*/
	cuen_fecha_creacion datetime not null,
	cuen_fecha_cierre datetime,
	cuen_estado_id int not null, /* FK  THE_ULTIMATES.Estado_Cuenta*/
	cuen_pais_id numeric(18,0) not null, /* FK  THE_ULTIMATES.Pais*/
	cuen_saldo numeric(18,2) not null,
	cuen_tipo_mon_id int not null /* FK  THE_ULTIMATES.Tipo_Moneda*/
);

GO
	
create table THE_ULTIMATES.Tipo_Moneda(
	tipo_moneda_id int CONSTRAINT PK_tipo_moneda_id PRIMARY KEY not null IDENTITY(1,1),
	tipo_moneda_desc varchar(30) not null,
	tipo_moneda_codigo char(3) not null unique, 
	tipo_moneda_cambio numeric(18,3)not null
);

GO
	
create table THE_ULTIMATES.Estado_Cuenta(
	esta_cuenta_id int CONSTRAINT PK_esta_cuenta_id PRIMARY KEY not null IDENTITY(1,1),
	esta_cuenta_desc varchar(255) not null
);

GO

create table THE_ULTIMATES.Tipo_Cuenta(
	tipo_cuenta_id int CONSTRAINT PK_tipo_cuenta_id PRIMARY KEY not null IDENTITY(1,1),
	tipo_cuenta_desc varchar(30)not null,
	tipo_cuenta_duracion int not null,
	tipo_cuenta_costo numeric(18,2) not null
);

GO

create table THE_ULTIMATES.Tarjeta(
	tarj_id int CONSTRAINT PK_tarj_id PRIMARY KEY not null IDENTITY(1,1),
	tarj_clie_id int not null,  /* FK  THE_ULTIMATES.Cliente*/
	tarj_numero char(64) not null UNIQUE,
	tarj_numero_preview char(4) not null,
	tarj_emisor_id int not null, /* FK  THE_ULTIMATES.Emisor*/
	tarj_fecha_emision datetime not null,
	tarj_fecha_venc datetime not null,
	tarj_codigo_seg char(4),
	tarj_activa bit not null
);

GO

create table THE_ULTIMATES.Emisor(
	emisor_id int CONSTRAINT PK_emisor_id PRIMARY KEY not null IDENTITY(1,1),
	emisor_desc varchar(30)
); 
	
GO

create table THE_ULTIMATES.Deposito(
	depo_id int CONSTRAINT PK_depo_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	depo_fecha datetime not null,
	depo_importe numeric(18,2) not null,
	depo_cuen_id numeric(18,0) not null,  /* FK  THE_ULTIMATES.Cuenta*/
	depo_tarj_id int not null,  /* FK  THE_ULTIMATES.Tarjeta*/
	depo_tipo_moneda_id int not null /* FK  THE_ULTIMATES.Tipo_Moneda*/
);
	
GO

create table THE_ULTIMATES.Cheque(
	cheque_id int CONSTRAINT PK_cheque_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	cheque_fecha datetime not null,
	cheque_importe numeric(18,3)not null,
	cheque_banco_id int not null  /* FK  THE_ULTIMATES.Banco*/
);
	
GO

create table THE_ULTIMATES.Transferencia(
	transf_id int CONSTRAINT PK_transf_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	transf_fecha datetime not null,
	transf_cuenta_origen numeric(18,0) not null, /* FK  THE_ULTIMATES.Cuenta*/
	transf_cuenta_destino numeric(18,0) not null, /* FK  THE_ULTIMATES.Cuenta*/
	transf_importe numeric(18,3)not null,
	transf_costo_transf numeric(18,3)not null,
	transf_cuenta_propia bit null 
);

GO

create table THE_ULTIMATES.Transaccion(
	transac_id int CONSTRAINT PK_transac_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	transac_fecha datetime not null,
	transac_cuen_id numeric(18,0) not null, /* FK  THE_ULTIMATES.Cuenta*/
	transac_tipo_transac_id int not null, /* FK  THE_ULTIMATES.Tipo_Transaccion*/
	transac_importe_comision numeric(18,3)not null,
	transac_pendiente bit not null	
);

GO

create table THE_ULTIMATES.Tipo_Transaccion(
	tipo_transac_id int CONSTRAINT PK_tipo_transac_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	tipo_transac_desc varchar(50) not null,
	tipo_transac_facturable bit not null
);

GO

create table THE_ULTIMATES.Extraccion(
	extrac_id int CONSTRAINT PK_extrac_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	extrac_cuenta_id numeric(18,0) not null, /* FK  THE_ULTIMATES.Cuenta*/
	extrac_cheque_id int not null /* FK  THE_ULTIMATES.Cheque*/
);

GO

create table THE_ULTIMATES.Banco(
	banco_id int CONSTRAINT PK_banco_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	banco_nombre varchar(50) not null,
	banco_direc varchar(50) not null
);

GO

create table THE_ULTIMATES.Factura(
	fact_num int CONSTRAINT PK_fact_num PRIMARY KEY NOT NULL IDENTITY(1,1),
	fact_fecha datetime not null,
	fact_clie_id int not null, /* FK  THE_ULTIMATES.Cliente*/
);

GO 

create table THE_ULTIMATES.Item_Factura(
	item_fact_id int CONSTRAINT PK_item_fact_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	item_fact_num int not null, /* FK  THE_ULTIMATES.Factura*/
	item_fact_desc varchar(250) not null,
	item_fact_precio numeric(18,3)not null
);


/*create table THE_ULTIMATES.Item_Factura(
	item_fact_num int not null, /* FK  THE_ULTIMATES.Factura*/
	item_fact_transac_id int not null,  /* FK  THE_ULTIMATES.Transaccion*/
	item_fact_cantidad int not null,
	CONSTRAINT PK_item_factura PRIMARY KEY (item_fact_num, item_fact_transac_id)
);
*/

GO

/******************************************** FIN - CREACION DE TABLAS *********************************************/


/******************************************** INICIO - FOREING KEY *************************************************/

alter table THE_ULTIMATES.Funcionalidad_Rol
add constraint FK_func_ron_rol_id foreign key (func_rol_rol_id) references THE_ULTIMATES.Rol(rol_id),
	constraint FK_func_ron_func_id foreign key (func_rol_func_id) references THE_ULTIMATES.Funcionalidad(func_id);

GO

alter table THE_ULTIMATES.Rol_Usuario
add constraint FK_rol_usu_rol_id foreign key (rol_usu_rol_id) references THE_ULTIMATES.Rol(rol_id),
	constraint FK_rol_usu_usu_id foreign key (rol_usu_usu_id) references THE_ULTIMATES.Usuario(usu_id);
	
go

alter table THE_ULTIMATES.Acceso_Log
add constraint FK_acc_usu_id foreign key (acc_usu_id) references THE_ULTIMATES.Usuario(usu_id);

go

alter table THE_ULTIMATES.Cliente
add constraint FK_clie_tipo_doc_id foreign key (clie_tipo_doc_id) references THE_ULTIMATES.Tipo_Doc(tipo_doc_id),
	constraint FK_clie_pais_id foreign key (clie_pais_id) references THE_ULTIMATES.Pais(pais_id),
	constraint FK_clie_usu_id foreign key (clie_usu_id) references THE_ULTIMATES.Usuario(usu_id);

go

alter table THE_ULTIMATES.Cuenta
add constraint FK_cuen_clie_id foreign key (cuen_clie_id) references THE_ULTIMATES.Cliente(clie_id),
	constraint FK_cuen_tipo_cuenta_id foreign key (cuen_tipo_cuenta_id) references THE_ULTIMATES.Tipo_Cuenta(tipo_cuenta_id),
	constraint FK_cuen_estado_id foreign key (cuen_estado_id) references THE_ULTIMATES.Estado_cuenta(esta_cuenta_id),
	constraint FK_cuen_pais_id foreign key (cuen_pais_id) references THE_ULTIMATES.Pais(pais_id),
	constraint FK_cuen_tipo_mon_id foreign key (cuen_tipo_mon_id) references THE_ULTIMATES.Tipo_Moneda(tipo_moneda_id);
	
go

alter table THE_ULTIMATES.Tarjeta
add constraint FK_tarj_clie_id foreign key (tarj_clie_id) references THE_ULTIMATES.Cliente(clie_id),
	constraint FK_tarj_emisor_id foreign key (tarj_emisor_id) references THE_ULTIMATES.Emisor(emisor_id);
	
go

alter table THE_ULTIMATES.Deposito
add constraint FK_depo_cuen_id foreign key (depo_cuen_id) references THE_ULTIMATES.Cuenta(cuen_id),
	constraint FK_depo_tarj_id foreign key (depo_tarj_id) references THE_ULTIMATES.Tarjeta(tarj_id),
	constraint FK_depo_tipo_moneda_id foreign key (depo_tipo_moneda_id) references THE_ULTIMATES.Tipo_Moneda(tipo_moneda_id);

go

alter table THE_ULTIMATES.Cheque
add constraint FK_cheque_banco_id foreign key (cheque_banco_id) references THE_ULTIMATES.Banco(banco_id);

go

alter table THE_ULTIMATES.Transferencia
add constraint FK_transf_cuenta_origen foreign key (transf_cuenta_origen) references THE_ULTIMATES.Cuenta(cuen_id),
	constraint FK_transf_cuenta_destino foreign key (transf_cuenta_destino) references THE_ULTIMATES.Cuenta(cuen_id);

go

alter table THE_ULTIMATES.Transaccion
add constraint FK_transac_cuen_id foreign key (transac_cuen_id) references THE_ULTIMATES.Cuenta(cuen_id),
	constraint FK_transac_tipo_transac_id foreign key (transac_tipo_transac_id) references THE_ULTIMATES.Tipo_Transaccion(tipo_transac_id);

go

alter table THE_ULTIMATES.Extraccion
add constraint FK_extrac_cuenta_id foreign key (extrac_cuenta_id) references THE_ULTIMATES.Cuenta(cuen_id),
	constraint FK_extrac_cheque_id foreign key (extrac_cheque_id) references THE_ULTIMATES.Cheque(cheque_id);
	
go

alter table THE_ULTIMATES.Factura
add constraint FK_fact_clie_id foreign key (fact_clie_id) references THE_ULTIMATES.Cliente(clie_id);

go

alter table THE_ULTIMATES.Item_Factura
add constraint FK_item_fact_num foreign key(item_fact_num) references THE_ULTIMATES.Factura(fact_num);/*,
	constraint FK_item_fact_transac_id foreign key(item_fact_transac_id) references THE_ULTIMATES.Transaccion(transac_id)*/

go

/******************************************** FIN - FOREING KEY ****************************************************/


/******************************************** INICIO - CREACION DE INDICES *****************************************/
/******************************************** FIN - CREACION DE INDICES *****************************************/
/******************************************** INICIO - CREACION DE STORED PROCEDURES, FUNCIONES Y VISTAS *************/
go

CREATE FUNCTION THE_ULTIMATES.RemoverTildes(@Cadena VARCHAR(25))
RETURNS VARCHAR(25)
AS BEGIN
    RETURN REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(@Cadena, ' ', ''), 'á', 'a'), 'é','e'), 'í', 'i'), 'ó', 'o'), 'ú','u')
END
go

CREATE FUNCTION THE_ULTIMATES.GenerarUsuario(@nombre varchar(255), @apellido varchar(255))
RETURNS VARCHAR(25)
AS BEGIN	
	RETURN THE_ULTIMATES.RemoverTildes(lower(SUBSTRING(@nombre, 1,19) + '.' + SUBSTRING(@apellido, 1,19)))
END
go

create procedure THE_ULTIMATES.SP_CargarCuentas 
as 
begin

set identity_insert THE_ULTIMATES.Cuenta on;

insert into THE_ULTIMATES.Cuenta (cuen_id, cuen_clie_id, cuen_tipo_cuenta_id,
	cuen_fecha_creacion, cuen_fecha_cierre, cuen_estado_id, cuen_pais_id, 
	cuen_saldo, cuen_tipo_mon_id)
	select distinct Cuenta_Numero, 
		(select clie_id from THE_ULTIMATES.Cliente 
		where clie_tipo_doc_id = Cli_Tipo_Doc_Cod and clie_nro_doc = Cli_Nro_Doc),
		4, Cuenta_Fecha_Creacion, null, 5, Cuenta_Pais_Codigo, 0.00, 1
	from gd_esquema.Maestra
	where Cuenta_Numero is not null;

set identity_insert THE_ULTIMATES.Cuenta off;

end
go

/*create procedure THE_ULTIMATES.SP_CargarTransferencias
as
begin
insert into THE_ULTIMATES.Transferencia (transf_cuenta_origen, transf_cuenta_destino, transf_fecha,
	transf_importe, transf_costo_transf, transf_cuenta_propia)
	select Cuenta_Numero, Cuenta_Dest_Numero, Transf_Fecha, Trans_Importe, Trans_Costo_Trans, 0
	from gd_esquema.Maestra
	where Cuenta_Dest_Numero is not null 
	
update THE_ULTIMATES.Transferencia set transf_cuenta_propia = 1
where transf_cuenta_destino in (select cuen_id from THE_ULTIMATES.Cuenta );
end				
go*/
/******************************************** FIN - CREACION DE STORED PROCEDURES, FUNCIONES Y VISTAS *************/


/******************************************** INICIO - LLENADO DE TABLAS *********************************************/

--ROL
insert into THE_ULTIMATES.Rol values ('Administrador', 1);
go
insert into THE_ULTIMATES.Rol values ('Cliente', 1);
go

--FUNCIONALIDAD
insert into THE_ULTIMATES.Funcionalidad values ('Deposito');
go
insert into THE_ULTIMATES.Funcionalidad values ('Extraccion');
go
insert into THE_ULTIMATES.Funcionalidad values ('Transferencia');
go
insert into THE_ULTIMATES.Funcionalidad values ('Facturacion');
go
insert into THE_ULTIMATES.Funcionalidad values ('Consulta de Saldo');
go
insert into THE_ULTIMATES.Funcionalidad values ('Listado Estadistico');
go

--ESTADO_CUENTA
insert into THE_ULTIMATES.Estado_Cuenta values ('Pendiente de Activacion');
go
insert into THE_ULTIMATES.Estado_Cuenta values ('Cerrada');
go
insert into THE_ULTIMATES.Estado_Cuenta values ('Inhabilitada');
go
insert into THE_ULTIMATES.Estado_Cuenta values ('Habilitada');
go

--TIPO_CUENTA
insert into THE_ULTIMATES.Tipo_Cuenta values ('Oro', 1, 3.00);
go
insert into THE_ULTIMATES.Tipo_Cuenta values ('Plata', 1, 2.00);
go
insert into THE_ULTIMATES.Tipo_Cuenta values ('Bronce', 1, 1.00);
go
insert into THE_ULTIMATES.Tipo_Cuenta values ('Gratuita', 1, 0.00);
go

--TIPO_MONEDA
insert into THE_ULTIMATES.Tipo_Moneda values ('Dolar','USD', 1.000);
go

--TIPO_DOC
set identity_insert THE_ULTIMATES.Tipo_Doc on;
go
insert into THE_ULTIMATES.Tipo_Doc(tipo_doc_id,tipo_doc_desc)
select distinct Cli_Tipo_Doc_Cod,Cli_Tipo_Doc_Desc
from gd_esquema.Maestra;
go
set identity_insert THE_ULTIMATES.Tipo_Doc off;
go

--PAIS
set identity_insert THE_ULTIMATES.Pais on;
go
insert into THE_ULTIMATES.Pais(pais_id,pais_desc)
select distinct Cli_Pais_Codigo,Cli_Pais_Desc from gd_esquema.Maestra 
union
select distinct Cuenta_Dest_Pais_Codigo,Cuenta_Dest_Pais_Desc from gd_esquema.Maestra where Cuenta_Dest_Pais_Codigo is not null;
go
set identity_insert THE_ULTIMATES.Pais off;
go

--CLIENTE,USUARIO
DECLARE @usu_id int
DECLARE @username varchar(25);

DECLARE @cli_pais_codigo numeric (18,0), 
		@cli_nombre varchar(255),
		@cli_apellido varchar(255), 
		@cli_tipo_doc_cod numeric(18,0), 
		@cli_nro_doc numeric(18,0),
		@cli_tipo_doc_desc varchar(255), 
		@cli_dom_calle varchar(255), 
		@cli_dom_nro numeric(18,0),
		@cli_dom_piso numeric(18,0), 
		@cli_dom_depto varchar(10), 
		@cli_fecha_nac datetime, 
		@cli_mail varchar(255)
		
DECLARE cursor_carga_cliente_usuario CURSOR FOR 
	select distinct Cli_Pais_Codigo, 
					Cli_Nombre, 
					Cli_Apellido, 
					Cli_Tipo_Doc_Cod,
					Cli_Nro_Doc, 
					Cli_Tipo_Doc_Desc, 
					Cli_Dom_Calle, 
					Cli_Dom_Nro, 
					Cli_Dom_Piso, 
					Cli_Dom_Depto,
					Cli_Fecha_Nac, 
					Cli_Mail
					
	from gd_esquema.Maestra

OPEN cursor_carga_cliente_usuario;

FETCH NEXT FROM cursor_carga_cliente_usuario 
INTO	@cli_pais_codigo , 
		@cli_nombre , 
		@cli_apellido, 
		@cli_tipo_doc_cod, 
		@cli_nro_doc, 
		@cli_tipo_doc_desc, 
		@cli_dom_calle, 
		@cli_dom_nro, 
		@cli_dom_piso, 
		@cli_dom_depto, 
		@cli_fecha_nac, 
		@cli_mail
		

BEGIN TRANSACTION transaction_maestra;
WHILE @@FETCH_STATUS = 0
BEGIN
	
	IF not exists(select 1 from THE_ULTIMATES.Cliente where clie_nro_doc = @cli_nro_doc and clie_tipo_doc_id = @cli_tipo_doc_cod)  
	BEGIN
	
	set @username = THE_ULTIMATES.GenerarUsuario(@cli_nombre,@cli_apellido);
	
		INSERT INTO THE_ULTIMATES.Usuario(	[usu_username],
											[usu_password],
											[usu_fecha_alta],
											[usu_fecha_mod],
											[usu_pregunta],
											[usu_respuesta],
											[usu_activo],
											[usu_intentos_fallidos])
		VALUES (@username, 
				@username, -- Por unica vez se le asigna el usuario como password, 
						   -- luego el cliente tendra que cambiarla cuando ingrese por primera vez al sistema.
				GETDATE(), 
				GETDATE(), 
				NULL, 
				NULL, 
				1, 
				0)
			
		SET @usu_id = SCOPE_IDENTITY()	
		INSERT INTO THE_ULTIMATES.Cliente(	[clie_nombre],
											[clie_apellido],
											[clie_nro_doc],
											[clie_tipo_doc_id],
											[clie_mail],
											[clie_activo],
											[clie_dom_calle],
											[clie_dom_numero],
											[clie_dom_piso],
											[clie_dom_depto],
											[clie_fecha_nac],
											[clie_pais_id],
											[clie_usu_id])
		values(	@cli_nombre, 
				@cli_apellido, 
				@cli_nro_doc, 
				@cli_tipo_doc_cod, 
				@cli_mail, 
				1,
				@cli_dom_calle, 
				@cli_dom_nro, 
				@cli_dom_piso, 
				@cli_dom_depto, 
				@cli_fecha_nac, 
				@cli_pais_codigo, 
				@usu_id)
	END
		
	FETCH NEXT FROM cursor_carga_cliente_usuario 
	INTO	@cli_pais_codigo , 
			@cli_nombre , 
			@cli_apellido, 
			@cli_tipo_doc_cod, 
			@cli_nro_doc, 
			@cli_tipo_doc_desc, 
			@cli_dom_calle, 
			@cli_dom_nro, 
			@cli_dom_piso, 
			@cli_dom_depto, 
			@cli_fecha_nac, 
			@cli_mail
			
END 
CLOSE cursor_carga_cliente_usuario;
DEALLOCATE cursor_carga_cliente_usuario;
COMMIT TRANSACTION transaction_maestra;
go

--CUENTA
set identity_insert THE_ULTIMATES.Cuenta on;

insert into THE_ULTIMATES.Cuenta (cuen_id, 
								cuen_clie_id, 
								cuen_tipo_cuenta_id,
								cuen_fecha_creacion, 
								cuen_fecha_cierre, 
								cuen_estado_id, 
								cuen_pais_id, 
								cuen_saldo, 
								cuen_tipo_mon_id)
	select distinct Cuenta_Numero, 
					(select clie_id from THE_ULTIMATES.Cliente where clie_tipo_doc_id = Cli_Tipo_Doc_Cod and clie_nro_doc = Cli_Nro_Doc),
					4, 
					Cuenta_Fecha_Creacion, 
					null, 
					4, 
					Cuenta_Pais_Codigo, 
					0.00, 
					1
	from gd_esquema.Maestra
	where Cuenta_Numero is not null;

set identity_insert THE_ULTIMATES.Cuenta off;
/******************************************** FIN - LLENADO DE TABLAS *********************************************/

/******************************************** INICIO - TRIGGERS *****************************************/

/*create trigger THE_ULTIMATES.Trigger_ControlCuentas on THE_ULTIMATES.Transaccion after insert
as

declare cursor_controlCuentas cursor for select i.transac_cuen_id from inserted i
*/



/******************************************** FIN - TRIGGERS *****************************************/
