create table gd_esquema.Rol( 
	rol_id tinyint not null,
	rol_desc char(15) null,
	rol_activo bit not null);
	
create table gd_esquema.Funcionalidad_Rol(
 func_rol_rol_id smallint not null,
 func_rol_func_id smallint not null);
 
create table gd_esquema.Funcionalidad(
	func_id tinyint not null,
	func_desc char(20) null);
		
create table gd_esquema.Rol_Usuario(
	rol_usua_rol_id smallint not null,
	rol_usua_usua_id smallint not null);
	
create table gd_esquema.Usuario(
	usua_id int not null,
	usua_username char(20) not null unique,
	usua_password char(64) not null,
	usua_fecha_alta datetime not null,
	usua_fecha_mod datetime null,
	usua_pregunta varchar(50) not null,
	usua_respuesta char(64) not null,
	usua_activo bit not null,
	usua_intentos_fallidos tinyint not null);
	
create table gd_esquema.Acceso_Log(
	acce_id int not null,
	acce_usuario int not null,
	acce_fecha datetime not null,
	acce_correcto bit not null,
	acce_numero_fallido tinyint not null);
	
create table gd_esquema.Pais(
	pais_id smallint not null,
	pais_desc varchar(50) not null);

create table gd_esquema.Tipo_Doc(
	tipo_doc_id smallint not null,
	tipo_doc_desc char(20) not null);
	
create table gd_esquema.Cliente(
	clie_id int not null,
	clie_nombre varchar(50) not null,
	clie_apellido varchar(50) not null,
	clie_nro_doc int not null,
	clie_tipo_doc smallint not null,
	clie_mail varchar(50) not null,
	clie_dom_calle varchar(50) not null,
	clie_dom_numero int not null,
	clie_dom_piso smallint null,
	clie_dom_depto varchar(10) null,
	clie_fecha_nac datetime not null);
	



 