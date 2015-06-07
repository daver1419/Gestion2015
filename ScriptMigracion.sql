/********************************************* INICIO - CREACION ESQUEMA *******************************************/

USE GD1C2015;
GO
/*CREATE SCHEMA THE_ULTIMATES AUTHORIZATION gd

GO */

/********************************************* FIN - CREACION ESQUEMA **********************************************/

/******************************************** INICIO - CREACION DE TABLAS ******************************************/

create table THE_ULTIMATES.Rol( 
	rol_id tinyint CONSTRAINT PK_rol_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	rol_desc varchar(15),
	rol_activo bit DEFAULT 1  
);

GO	

create table THE_ULTIMATES.Funcionalidad(
	func_id tinyint CONSTRAINT PK_func_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	func_desc varchar(60)
);

GO
	
create table THE_ULTIMATES.Funcionalidad_Rol(
	func_rol_rol_id tinyint  not null, /* FK  THE_ULTIMATES.Rol*/
	func_rol_func_id tinyint not null,/* FK  THE_ULTIMATES.Funcionalidad*/
	CONSTRAINT PK_funcionalidad_rol PRIMARY KEY (func_rol_rol_id, func_rol_func_id)
); 

GO

create table THE_ULTIMATES.Usuario(
	usu_id int CONSTRAINT PK_usu_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	usu_username varchar(20) not null UNIQUE,
	usu_password char(64) not null,
	usu_fecha_alta datetime not null,
	usu_fecha_mod datetime null,
	usu_pregunta varchar(50),
	usu_respuesta char(64),
	usu_activo bit DEFAULT 0,
	usu_intentos_fallidos tinyint not null,
	usu_clie_id int null /* FK  THE_ULTIMATES.Cliente*/
);

GO

create table THE_ULTIMATES.Rol_Usuario(
	rol_usu_rol_id tinyint  not null, /* FK  THE_ULTIMATES.Rol*/
	rol_usu_usu_id int  not null,  /* FK  THE_ULTIMATES.Usuario*/
	CONSTRAINT PK_rol_usuario PRIMARY KEY (rol_usu_rol_id, rol_usu_usu_id)
);
	
GO

create table THE_ULTIMATES.Acceso_Log(
	acc_id int CONSTRAINT PK_acc_id PRIMARY KEY not null IDENTITY(1,1),
	acc_usu_id int  not null, /* FK  THE_ULTIMATES.Usuario*/
	acc_fecha datetime not null,
	acc_correcto bit not null,
	acc_intent_fallido tinyint not null
);

GO
	
create table THE_ULTIMATES.Pais(
	pais_id smallint CONSTRAINT PK_pais_id PRIMARY KEY not null IDENTITY(1,1),
	pais_desc varchar(50) not null
);

GO

create table THE_ULTIMATES.Tipo_Doc(
	tipo_doc_id smallint CONSTRAINT PK_tipo_doc_id PRIMARY KEY not null IDENTITY(1,1),
	tipo_doc_desc char(20) not null
);

GO
	
create table THE_ULTIMATES.Cliente(
	clie_id int CONSTRAINT PK_clie_id PRIMARY KEY not null IDENTITY(1,1),
	clie_nombre varchar(50) not null,
	clie_apellido varchar(50) not null,
	clie_nro_doc int not null unique, 
	clie_tipo_doc_id smallint not null, /* FK  THE_ULTIMATES.Tipo_Doc*/
	clie_mail varchar(50) not null unique,
	clie_activo bit not null,
	clie_dom_calle varchar(50) not null,
	clie_dom_numero int not null,
	clie_dom_piso smallint null,
	clie_dom_depto varchar(10),
	clie_fecha_nac datetime not null,
	clie_pais_id smallint not null /* FK  THE_ULTIMATES.Pais*/
);

GO
	
create table THE_ULTIMATES.Cuenta(
	cuen_id int CONSTRAINT PK_cuen_id PRIMARY KEY not null IDENTITY(1,1),
	cuen_clie_id int not null, /* FK  THE_ULTIMATES.Cliente*/
	cuen_tipo_cuenta_id tinyint not null, /* FK  THE_ULTIMATES.Tipo_Cuenta*/
	cuen_fecha_creacion datetime not null,
	cuen_fecha_cierre datetime,
	cuen_estado_id tinyint not null, /* FK  THE_ULTIMATES.Estado_Cuenta*/
	cuen_pais_id smallint not null, /* FK  THE_ULTIMATES.Pais*/
	cuen_saldo numeric(18,2) not null,
	cuen_tipo_mon_id smallint not null /* FK  THE_ULTIMATES.Tipo_Moneda*/
);

GO
	
create table THE_ULTIMATES.Tipo_Moneda(
	tipo_moneda_id smallint CONSTRAINT PK_tipo_moneda_id PRIMARY KEY not null IDENTITY(1,1),
	tipo_moneda_desc varchar(30) not null,
	tipo_moneda_codigo char(3) not null unique, 
	tipo_moneda_cambio numeric(18,3)not null
);

GO
	
create table THE_ULTIMATES.Estado_Cuenta(
	esta_cuenta_id tinyint CONSTRAINT PK_esta_cuenta_id PRIMARY KEY not null IDENTITY(1,1),
	esta_cuenta_desc varchar(30) not null
);

GO

create table THE_ULTIMATES.Tipo_Cuenta(
	tipo_cuenta_id tinyint CONSTRAINT PK_tipo_cuenta_id PRIMARY KEY not null IDENTITY(1,1),
	tipo_cuenta_desc varchar(30)not null,
	tipo_cuenta_duracion smallint not null,
	tipo_cuenta_costo numeric(18,2) not null
);

GO

create table THE_ULTIMATES.Tarjeta(
	tarj_id int CONSTRAINT PK_tarj_id PRIMARY KEY not null IDENTITY(1,1),
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
	emisor_id tinyint CONSTRAINT PK_emisor_id PRIMARY KEY not null IDENTITY(1,1),
	emisor_desc varchar(30)
); 
	
GO

create table THE_ULTIMATES.Deposito(
	depo_id int CONSTRAINT PK_depo_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	depo_fecha datetime not null,
	depo_importe numeric(18,2) not null,
	depo_cuen_id int not null,  /* FK  THE_ULTIMATES.Cuenta*/
	depo_tarj_id int not null,  /* FK  THE_ULTIMATES.Tarjeta*/
	depo_tipo_moneda_id smallint not null /* FK  THE_ULTIMATES.Tipo_Moneda*/
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
	transf_cuenta_origen int not null, /* FK  THE_ULTIMATES.Cuenta*/
	transf_cuenta_destino int not null, /* FK  THE_ULTIMATES.Cuenta*/
	transf_importe numeric(18,3)not null,
	transf_costo_transf numeric(18,3)not null,
	transf_cuenta_propia bit not null 
);

GO

create table THE_ULTIMATES.Transaccion(
	transac_id int CONSTRAINT PK_transac_id PRIMARY KEY NOT NULL IDENTITY(1,1),
	transac_fecha datetime not null,
	transac_tipo_transac_id int not null, /* FK  THE_ULTIMATES.Cuenta*/
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
	extrac_cuenta_id int not null, /* FK  THE_ULTIMATES.Cuenta*/
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

alter table THE_ULTIMATES.Usuario
add constraint FK_usu_clie_id foreign key (usu_clie_id) references THE_ULTIMATES.Cliente(clie_id);

go

alter table THE_ULTIMATES.Rol_Usuario
add constraint FK_rol_usu_rol_id foreign key (rol_usu_rol_id) references THE_ULTIMATES.Rol(rol_id),
	constraint FK_rol_usu_usu_id foreign key (rol_usu_usu_id) references THE_ULTIMATES.Usuario(usu_id);
	
go

alter table THE_ULTIMATES.Acceso_Log
add constraint FK_acc_usu_id foreign key (acc_usu_id) references THE_ULTIMATES.Usuario(usu_id);

go

alter table THE_ULTIMATES.Cliente
add constraint FK_clie_tipo_doc_id foreign key (clie_tipo_doc_id) references THE_ULTIMATES.Tipo_Doc(tipo_doc_id),
	constraint FK_clie_pais_id foreign key (clie_pais_id) references THE_ULTIMATES.Pais(pais_id);

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
add constraint FK_transac_tipo_transac_id foreign key (transac_tipo_transac_id) references THE_ULTIMATES.Tipo_Transaccion(tipo_transac_id);

go

alter table THE_ULTIMATES.Extraccion
add constraint FK_extrac_cuenta_id foreign key (extrac_cuenta_id) references THE_ULTIMATES.Cuenta(cuen_id),
	constraint FK_extrac_cheque_id foreign key (extrac_cheque_id) references THE_ULTIMATES.Cheque(cheque_id);
	
go

alter table THE_ULTIMATES.Factura
add constraint FK_fact_clie_id foreign key (fact_clie_id) references THE_ULTIMATES.Cliente(clie_id);

go

alter table THE_ULTIMATES.Item_Factura
add constraint FK_item_fact_num foreign key(item_fact_num) references THE_ULTIMATES.Factura(fact_num)/*,
	constraint FK_item_fact_transac_id foreign key(item_fact_transac_id) references THE_ULTIMATES.Transaccion(transac_id)*/

go


	





/******************************************** FIN - FOREING KEY ****************************************************/


/******************************************** INICIO - CREACION DE INDICES *****************************************/
/******************************************** FIN - CREACION DE INDICES *****************************************/

/******************************************** INICIO - LLENADO DE TABLAS *********************************************/

insert into THE_ULTIMATES.Rol
values ('Administrador', 1);
go

insert into THE_ULTIMATES.Rol
values ('Cliente', 1);
go

insert into THE_ULTIMATES.Funcionalidad
values ('Deposito');
go

insert into THE_ULTIMATES.Funcionalidad
values ('Extraccion');
go

insert into THE_ULTIMATES.Funcionalidad
values ('Transferencia');
go

insert into THE_ULTIMATES.Funcionalidad
values ('Facturacion');
go

insert into THE_ULTIMATES.Funcionalidad
values ('Consulta de Saldo');
go

insert into THE_ULTIMATES.Funcionalidad
values ('Listado Estadistico');
go



insert into THE_ULTIMATES.Estado_Cuenta
values ('Pendiente de Activacion');
go

insert into THE_ULTIMATES.Estado_Cuenta
values ('Cerrada');
go

insert into THE_ULTIMATES.Estado_Cuenta
values ('Inhabilitada');
go

insert into THE_ULTIMATES.Estado_Cuenta
values ('Habilitada');
go



insert into THE_ULTIMATES.Tipo_Cuenta
values ('Oro', 1, 3.00);
go

insert into THE_ULTIMATES.Tipo_Cuenta
values ('Plata', 1, 2.00);
go

insert into THE_ULTIMATES.Tipo_Cuenta
values ('Bronce', 1, 1.00);
go

insert into THE_ULTIMATES.Tipo_Cuenta
values ('Gratuita', 1, 0.00);
go


insert into THE_ULTIMATES.Tipo_Moneda
values ('Dolar','USD', 1.000);
go


/******************************************** FIN - LLENADO DE TABLAS *********************************************/

/******************************************** INICIO - CREACION DE STORED PROCEDURES, FUNCIONES Y VISTAS *************/

create procedure THE_ULTIMATES.Cargar_Cuentas 
as

set identity_insert THE_ULTIMATES.Cuenta on;
go

insert into THE_ULTIMATES.Cuenta 
select Cuenta_Numero, 
	(select clie_id from THE_ULTIMATES.Cliente 
	where clie_tipo_doc_id = Cli_Tipo_Doc_Cod and clie_nro_doc = Cli_Nro_Doc),
	4, Cuenta_Fecha_Creacion, null, 5, Cuenta_Pais_Codigo, 0.00, 1
from gd_esquema.Maestra
where Cuenta_Numero is not null;
go

set identity_insert THE_ULTIMATES.Cuenta off;

end

/******************************************** FIN - CREACION DE STORED PROCEDURES, FUNCIONES Y VISTAS *************/

/******************************************** INICIO - TRIGGERS *****************************************/
/******************************************** FIN - TRIGGERS *****************************************/






	
	
	
	
	
	
	


 