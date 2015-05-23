USE GD1C2015;
GO

create table THE_ULTIMATES.Rol( 
	rol_id tinyint not null,
	rol_desc char(15) null,
	rol_activo bit not null);
	
create table THE_ULTIMATES.Funcionalidad_Rol(
 func_rol_rol_id smallint not null,
 func_rol_func_id smallint not null);
 
create table THE_ULTIMATES.Funcionalidad(
	func_id tinyint not null,
	func_desc char(20) null);
		
create table THE_ULTIMATES.Rol_Usuario(
	rol_usua_rol_id smallint not null,
	rol_usua_usua_id smallint not null);
	
create table THE_ULTIMATES.Usuario(
	usua_id int not null,
	usua_username char(20) not null unique,
	usua_password char(64) not null,
	usua_fecha_alta datetime not null,
	usua_fecha_mod datetime null,
	usua_pregunta varchar(50) not null,
	usua_respuesta char(64) not null,
	usua_activo bit not null,
	usua_intentos_fallidos tinyint not null);
	
create table THE_ULTIMATES.Acceso_Log(
	acce_id int not null,
	acce_usuario int not null,
	acce_fecha datetime not null,
	acce_correcto bit not null,
	acce_numero_fallido tinyint not null);
	
create table THE_ULTIMATES.Pais(
	pais_id smallint not null,
	pais_desc varchar(50) not null);

create table THE_ULTIMATES.Tipo_Doc(
	tipo_doc_id smallint not null,
	tipo_doc_desc char(20) not null);
	
create table THE_ULTIMATES.Cliente(
	clie_id int not null,
	clie_nombre varchar(50) not null,
	clie_apellido varchar(50) not null,
	clie_nro_doc int not null,
	clie_tipo_doc smallint not null,
	clie_mail varchar(50) not null unique,
	clie_activo bit not null,
	clie_dom_calle varchar(50) not null,
	clie_dom_numero int not null,
	clie_dom_piso smallint null,
	clie_dom_depto varchar(10) null,
	clie_fecha_nac datetime not null,
	clie_pais smallint not null);
	
create table THE_ULTIMATES.Cuenta(
	cuen_id int not null,
	cuen_cliente int not null,
	cuen_tipo_cuenta tinyint not null,
	cuen_fecha_creacion datetime not null,
	cuen_fecha_cierre datetime null,
	cuen_estado tinyint not null,
	cuen_pais smallint not null,
	cuen_saldo numeric(18,2) not null,
	cuen_tipo_moneda smallint not null);
	
create table THE_ULTIMATES.Tipo_Moneda(
	tipo_moneda_id smallint not null,
	tipo_moneda_desc char(15) not null,
	tipo_moneda_cambio numeric(18,3)not null);
	
create table THE_ULTIMATES.Estado_Cuenta(
	esta_cuenta_id tinyint not null,
	esta_cuenta_desc char(20) not null);

create table THE_ULTIMATES.Tipo_Cuenta(
	tipo_cuenta_id tinyint not null,
	tipo_cuenta_desc char(20)not null,
	tipo_cuenta_duracion smallint not null,
	tipo_cuenta_costo numeric(18,2) not null);

create table THE_ULTIMATES.Tarjeta(
	tarj_id int not null,
	tarj_cliente int not null,
	tarj_numero char(64) not null,
	tarj_numero_preview char(4) not null,
	tarj_emisor tinyint not null,
	tarj_fecha_emision datetime not null,
	tarj_fecha_vencimiento datetime not null,
	tarj_codigo_seguridad char(4),
	tarj_activa bit not null);


	
	
	
	
	
	
	
	


 