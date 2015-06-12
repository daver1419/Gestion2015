USE GD1C2015
GO


alter table THE_ULTIMATES.Funcionalidad_Rol drop constraint FK_func_ron_rol_id;
alter table THE_ULTIMATES.Funcionalidad_Rol drop constraint FK_func_ron_func_id;
alter table THE_ULTIMATES.Rol_Usuario drop constraint FK_rol_usu_rol_id;
alter table THE_ULTIMATES.Rol_Usuario drop constraint FK_rol_usu_usu_id;
alter table THE_ULTIMATES.Acceso_Log drop constraint FK_acc_usu_id;
alter table THE_ULTIMATES.Cliente drop constraint FK_clie_tipo_doc_id;
alter table THE_ULTIMATES.Cliente drop constraint FK_clie_pais_id;
alter table THE_ULTIMATES.Cuenta drop constraint FK_cuen_clie_id;
alter table THE_ULTIMATES.Cuenta drop constraint FK_cuen_tipo_cuenta_id;
alter table THE_ULTIMATES.Cuenta drop constraint FK_cuen_estado_id;
alter table THE_ULTIMATES.Cuenta drop constraint FK_cuen_pais_id;
alter table THE_ULTIMATES.Cuenta drop constraint FK_cuen_tipo_mon_id;
alter table THE_ULTIMATES.Tarjeta drop constraint FK_tarj_clie_id;
alter table THE_ULTIMATES.Tarjeta drop constraint FK_tarj_emisor_id;
alter table THE_ULTIMATES.Deposito drop constraint FK_depo_cuen_id;
alter table THE_ULTIMATES.Deposito drop constraint FK_depo_tarj_id;
alter table THE_ULTIMATES.Deposito drop constraint FK_depo_tipo_moneda_id;
alter table THE_ULTIMATES.Cheque drop constraint FK_cheque_banco_id;
alter table THE_ULTIMATES.Transferencia drop constraint FK_transf_cuenta_origen;
alter table THE_ULTIMATES.Transferencia drop constraint FK_transf_cuenta_destino;
alter table THE_ULTIMATES.Transaccion drop constraint FK_transac_tipo_transac_id;
alter table THE_ULTIMATES.Transaccion drop constraint FK_transac_cuen_id;
alter table THE_ULTIMATES.Extraccion drop constraint FK_extrac_cuenta_id;
alter table THE_ULTIMATES.Extraccion drop constraint FK_extrac_cheque_numero;
alter table THE_ULTIMATES.Factura drop constraint FK_fact_clie_id;
alter table THE_ULTIMATES.Item_Factura drop constraint FK_item_fact_num;
/*alter table THE_ULTIMATES.Item_Factura drop constraint FK_item_fact_transac_id;*/

drop table THE_ULTIMATES.Acceso_Log;
drop table THE_ULTIMATES.Cliente;
drop table THE_ULTIMATES.Cuenta;
drop table THE_ULTIMATES.Estado_Cuenta;
drop table THE_ULTIMATES.Funcionalidad;
drop table THE_ULTIMATES.Funcionalidad_Rol;
drop table THE_ULTIMATES.Pais;
drop table THE_ULTIMATES.Rol;
drop table THE_ULTIMATES.Rol_Usuario;
drop table THE_ULTIMATES.Tarjeta;
drop table THE_ULTIMATES.Tipo_Cuenta;
drop table THE_ULTIMATES.Tipo_Doc;
drop table THE_ULTIMATES.Tipo_Moneda;
drop table THE_ULTIMATES.Usuario;
drop table THE_ULTIMATES.Banco;
drop table THE_ULTIMATES.Cheque;
drop table THE_ULTIMATES.Deposito;
drop table THE_ULTIMATES.Emisor;
drop table THE_ULTIMATES.Extraccion;
drop table THE_ULTIMATES.Factura;
drop table THE_ULTIMATES.Item_Factura;
drop table THE_ULTIMATES.Tipo_Transaccion;
drop table THE_ULTIMATES.Transaccion;
drop table THE_ULTIMATES.Transferencia;

drop function THE_ULTIMATES.GenerarUsuario;
drop function THE_ULTIMATES.RemoverTildes;
drop function THE_ULTIMATES.esDelMismoCliente;
drop function THE_ULTIMATES.esDelMismoCliente2;
drop procedure THE_ULTIMATES.SP_CargarCuentas;
drop procedure THE_ULTIMATES.SP_CargarTransferencias;
drop procedure THE_ULTIMATES.SP_CargarTransferencias2;
drop procedure THE_ULTIMATES.SP_CargarBancos;
drop procedure THE_ULTIMATES.SP_CargarCheques;