/********************************************* INICIO - CREACION ESQUEMA *******************************************/

USE GD1C2015;
GO
/*CREATE SCHEMA THE_ULTIMATES AUTHORIZATION gd

GO */

/********************************************* FIN - CREACION ESQUEMA **********************************************/

/******************************************** INICIO - CREACION DE TABLAS ******************************************/

create table THE_ULTIMATES.Rol( 
	rol_id tinyint PRIMARY KEY NOT NULL IDENTITY(1,1),
	rol_desc varchar(15),
	rol_activo bit DEFAULT 1  
	);

GO	

create table THE_ULTIMATES.Funcionalidad(
	func_id tinyint PRIMARY KEY NOT NULL IDENTITY(1,1),
	func_desc varchar(60)
	);

GO
	
create table THE_ULTIMATES.Funcionalidad_Rol(
	func_rol_id  tinyint PRIMARY KEY NOT NULL IDENTITY(1,1),
	func_rol_rol_id smallint  not null UNIQUE, /* FK  THE_ULTIMATES.Rol*/
	func_rol_func_id smallint not null UNIQUE /* FK  THE_ULTIMATES.Funcionalidad*/
	); 

GO

create table THE_ULTIMATES.Usuario(
	usu_id int PRIMARY KEY NOT NULL IDENTITY(1,1),
	usu_username varchar(20) not null UNIQUE,
	usu_password char(64) not null,
	usu_fecha_alta datetime not null,
	usu_fecha_mod datetime null,
	usu_pregunta varchar(50),
	usu_respuesta char(64),
	usu_activo bit DEFAULT 0,
	usu_intentos_fallidos tinyint not null,
	usu_clie_id int null
	 /* FK  THE_ULTIMATES.CLiente*/
	);

GO

create table THE_ULTIMATES.Rol_Usuario(
	rol_usu int PRIMARY KEY NOT NULL IDENTITY(1,1),
	rol_usu_rol_id smallint  not null UNIQUE, /* FK  THE_ULTIMATES.Rol*/
	rol_usu_usu_id smallint  not null UNIQUE  /* FK  THE_ULTIMATES.Usuario*/
	);
	
GO

create table THE_ULTIMATES.Acceso_Log(
	acc_id int PRIMARY KEY not null IDENTITY(1,1),
	acc_usu_id int  not null, /* FK  THE_ULTIMATES.Usuario*/
	acc_fecha datetime not null,
	acc_correcto bit not null,
	acc_intent_fallido tinyint not null
	);

GO
	
create table THE_ULTIMATES.Pais(
	pais_id smallint PRIMARY KEY not null IDENTITY(1,1),
	pais_desc varchar(50) not null
	);

GO

create table THE_ULTIMATES.Tipo_Doc(
	tipo_doc_id smallint PRIMARY KEY not null IDENTITY(1,1),
	tipo_doc_desc char(20) not null
	);

GO
	
create table THE_ULTIMATES.Cliente(
	clie_id int PRIMARY KEY not null IDENTITY(1,1),
	clie_nombre varchar(50) not null,
	clie_apellido varchar(50) not null,
	clie_nro_doc int not null unique, 
	clie_tipo_doc smallint not null, /* FK  THE_ULTIMATES.Tipo_Doc*/
	clie_mail varchar(50) not null unique,
	clie_activo bit not null,
	clie_dom_calle varchar(50) not null,
	clie_dom_numero int not null,
	clie_dom_piso smallint null,
	clie_dom_depto varchar(10),
	clie_fecha_nac datetime not null,
	clie_pais smallint not null /* FK  THE_ULTIMATES.Pais*/
	);

GO
	
create table THE_ULTIMATES.Cuenta(
	cuen_id int PRIMARY KEY not null IDENTITY(1,1),
	cuen_clie_id int not null, /* FK  THE_ULTIMATES.Cliente*/
	cuen_tipo_cuenta tinyint not null, /* FK  THE_ULTIMATES.Tipo_Cuenta*/
	cuen_fecha_creacion datetime not null,
	cuen_fecha_cierre datetime,
	cuen_estado_id tinyint not null, /* FK  THE_ULTIMATES.Estado_Cuenta*/
	cuen_pais_id smallint not null, /* FK  THE_ULTIMATES.Pais*/
	cuen_saldo numeric(18,2) not null,
	cuen_tipo_mon_id smallint not null /* FK  THE_ULTIMATES.Tipo_Moneda*/
	);

GO
	
create table THE_ULTIMATES.Tipo_Moneda(
	tipo_moneda_id smallint PRIMARY KEY not null IDENTITY(1,1),
	tipo_moneda_desc varchar(30) not null,
	tipo_moneda_cambio numeric(18,3)not null
	);

GO
	
create table THE_ULTIMATES.Estado_Cuenta(
	esta_cuenta_id tinyint PRIMARY KEY not null IDENTITY(1,1),
	esta_cuenta_desc varchar(30) not null
	);

GO

create table THE_ULTIMATES.Tipo_Cuenta(
	tipo_cuenta_id tinyint PRIMARY KEY not null IDENTITY(1,1),
	tipo_cuenta_desc varchar(30)not null,
	tipo_cuenta_duracion smallint not null,
	tipo_cuenta_costo numeric(18,2) not null
	);

GO

create table THE_ULTIMATES.Tarjeta(
	tarj_id int PRIMARY KEY not null IDENTITY(1,1),
	tarj_clie_id int not null,  /* FK  THE_ULTIMATES.Cliente*/
	tarj_numero char(64) not null UNIQUE,
	tarj_numero_preview char(4) not null,
	tarj_emisor_id tinyint not null, /* FK  THE_ULTIMATES.Emisor*/
	tarj_fecha_emision datetime not null,
	tarj_fecha_venc datetime not null,
	tarj_codigo_seg char(4),
	tarj_activa bit not null
	);

GO

create table THE_ULTIMATES.Emisor(
	emisor_id int PRIMARY KEY not null IDENTITY(1,1),
	emisor_desc varchar(30)
	); 
	
GO

create table THE_ULTIMATES.Deposito(
	depo_id int PRIMARY KEY NOT NULL IDENTITY(1,1),
	depo_fecha datetime not null,
	depo_importe numeric(18,2) not null,
	depo_cuenta_id int not null,  /* FK  THE_ULTIMATES.Cuenta*/
	depo_tarj_id int not null,  /* FK  THE_ULTIMATES.Tarjeta*/
	depo_tipo_moneda_id int not null /* FK  THE_ULTIMATES.Tipo_Moneda*/
	);
	
GO

create table THE_ULTIMATE.Cheque(
	cheque_id int PRIMARY KEY NOT NULL IDENTITY(1,1),
	cheque_fecha datetime not null,
	cheque_importe numeric(18,3)not null,
	cheque_banco_id int not null  /* FK  THE_ULTIMATES.Banco*/
	);
	
	
	
	
	
	
	
	


 