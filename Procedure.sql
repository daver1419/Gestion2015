CREATE PROCEDURE [THE_ULTIMATES].[Lista_Func_Rol]
@id numeric(18,0)=null
AS
BEGIN
	SET NOCOUNT ON;

SELECT func_desc DESCRIPCION FROM THE_ULTIMATES.Funcionalidad func ,THE_ULTIMATES.Funcionalidad_Rol funcRol 
WHERE funcRol.func_rol_rol_id = @id and func.func_id = func_rol_func_id;
END

GO

CREATE PROCEDURE [THE_ULTIMATES].[Lista_Pais]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT pais_id ID , pais_desc DESCRIPCION
	FROM [THE_ULTIMATES].Pais 
END

GO

CREATE PROCEDURE [THE_ULTIMATES].[Lista_Rol]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM [THE_ULTIMATES].Rol 
END

GO
CREATE PROCEDURE [THE_ULTIMATES].[Lista_Tipo_Cuenta]
AS
BEGIN
	SET NOCOUNT ON;

SELECT tipo_cuenta_id  ID , tipo_cuenta_desc  DESCRIPCION   FROM THE_ULTIMATES.Tipo_Cuenta;
END

GO

create function THE_ULTIMATES.getClienteByTipoYNumeroDoc(
@tipo_doc_id numeric(18,0),
@numero_doc numeric(18,0))
returns TABLE
as
	return (select * 
			from THE_ULTIMATES.Cliente 
			where clie_tipo_doc_id = @tipo_doc_id and clie_nro_doc = @numero_doc)
go

create function THE_ULTIMATES.getCuentasByClieId(@cliente_id int)
returns TABLE
as
return (select * from THE_ULTIMATES.Cuenta where cuen_clie_id = @cliente_id)
go

create function THE_ULTIMATES.getSaldoByCuenta(@cuenta_id numeric(18,0))
returns numeric(18,2)
as
begin
	return (select cuen_saldo
			from THE_ULTIMATES.Cuenta
			where @cuenta_id = cuen_id)
end
go

create function THE_ULTIMATES.getUltimos5Depositos(@cuenta_id numeric(18,0))
returns TABLE
as
	return (select top 5 *
			from THE_ULTIMATES.Deposito
			where depo_cuen_id = @cuenta_id
			order by depo_id desc)
go

create function THE_ULTIMATES.getUltimas5Extracciones(@cuenta_id numeric(18,0))
returns TABLE
as
	return (select top 5 *
			from THE_ULTIMATES.Extraccion
			where extrac_cuenta_id = @cuenta_id
			order by extrac_id desc)
go

create function THE_ULTIMATES.getUltimas10Transferencias(@cuenta_id numeric(18,0))
returns TABLE
as
	return (select top 10 *
			from THE_ULTIMATES.Transferencia
			where transf_cuenta_origen = @cuenta_id
			order by transf_id desc)
go



CREATE PROCEDURE [THE_ULTIMATES].[Lista_Tipo_Doc]
AS
BEGIN
	SET NOCOUNT ON;

SELECT tipo_doc_id ID , tipo_doc_desc DESCRIPCION  FROM THE_ULTIMATES.Tipo_Doc
END


GO

CREATE PROCEDURE [THE_ULTIMATES].[Lista_Tipo_Moneda]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT tipo_moneda_id ID , tipo_moneda_desc DESCRIPCION
	FROM [THE_ULTIMATES].Tipo_Moneda
END



GO

CREATE procedure [THE_ULTIMATES].[login]
@usuario varchar (25),
@password varchar(64)

AS 

BEGIN 
  DECLARE @id_usuario int 
  DECLARE @login_fallidos int 
 
  select @id_usuario = (select  usu_id from THE_ULTIMATES.Usuario  usuario   where  usu_username = @usuario ); 
  if @id_usuario is null
  BEGIN 
     RETURN  
  END
  ELSE 
  BEGIN 
    DECLARE @password_db varchar(64) 
    select @password_db = (select usu_password  from THE_ULTIMATES.Usuario where usu_username=@usuario)
    IF @password_db <> @password
    BEGIN 
  		
  		update THE_ULTIMATES.Usuario set usu_intentos_fallidos =  (usu_intentos_fallidos  + 1) where usu_id = @id_usuario
		
		select @login_fallidos = (select usu_intentos_fallidos from THE_ULTIMATES.Usuario where usu_id=@id_usuario)
		insert into THE_ULTIMATES.Acceso_Log (acc_usu_id, acc_fecha , acc_correcto , acc_intent_fallido) values (@id_usuario, GETDATE() ,0 , @login_fallidos) 
		
		
		if @login_fallidos >= 3
		BEGIN
			update THE_ULTIMATES.Usuario set usu_activo=1 where usu_username=@usuario
		END	
      RETURN 
   END 
   ELSE 
   BEGIN
     select @login_fallidos = (select usu_intentos_fallidos from THE_ULTIMATES.Usuario where usu_id=@id_usuario)
     insert into THE_ULTIMATES.Acceso_Log (acc_usu_id, acc_fecha , acc_correcto , acc_intent_fallido) values (@id_usuario, GETDATE() ,1 , @login_fallidos) 
     select usu_id , usu_username ,usu_activo,rol_usu_rol_id from THE_ULTIMATES.Usuario  usuario , THE_ULTIMATES.Rol_Usuario  where  usuario.usu_username = @usuario and usuario.usu_password = @password
  
   END 
  
   END
 
END





GO


CREATE procedure  [THE_ULTIMATES].[SP_Crear_usu_posible]

@usuname varchar (25),
@pass char (64),
@fecha datetime= null 
 
 
as 
 begin 
	 set nocount on;
	 insert into THE_ULTIMATES.Usuario (usu_username, usu_password , usu_fecha_alta , usu_fecha_mod ,usu_pregunta , usu_respuesta , usu_activo , usu_intentos_fallidos)
     values (@usuname, @pass , @fecha, null , null , null , 0 , 0);
 end 


GO


create function THE_ULTIMATES.getClienteByUsuario(@idUsuario int)
returns TABLE
as
return (select * from THE_ULTIMATES.Cliente where clie_usu_id = @idUsuario)
go