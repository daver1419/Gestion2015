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

create procedure THE_ULTIMATES.SP_crearUsuario
@usu_username varchar(25),
@usu_password char(64),
@usu_pregunta varchar(50),
@usu_respuesta char(64),
@rol_id int,
@code int output,
@msg varchar(100) output
as 
begin
	
	if exists (select 1 from Usuario where usu_username = @usu_username)
	begin
		set @code = 3
		set @msg = 'El usuario ya existe'
		return;
	end
	
	begin try
	
		insert into Usuario values (@usu_username,
									@usu_password,
									GETDATE(),
									GETDATE(),
									@usu_pregunta,
									@usu_respuesta,
									0,
									0)
									
		insert into Rol_Usuario values (@rol_id, scope_identity())
		set @code = 1;
		set @msg = 'Se ha creado el usuario '
	end try
	begin catch
		set @code = 0;
		set @msg = 'Error al crear el usuario'
		rollback;
	end catch
		
	return;
end
go

/*declare @code int, 
		@msg varchar(100)
exec  THE_ULTIMATES.SP_crearUsuario  "hola5","E6B87050BFCB8143FCB8DB170A4DC9ED0D904DDD3E2A4AD1B1E8DCFDC9BE7   ",
"mierda","E6B87050BFCB8143FCB8DB170A4DC9ED0D904DDD3E2A4AD1B1E8DCFDC9BE7   ",2,  @code = @code OUTPUT, @msg = @msg output

SELECT	'Return Value' = @code
select 'Mensaje' = @msg*/

CREATE TYPE Funcionalidades AS TABLE 
(func_id int);
go

create procedure THE_ULTIMATES.SP_crearRol
@rol_descripcion varchar(15),
@funcionalidades Funcionalidades readonly,
@estado bit,
@code int output,
@msg varchar(100) output
as
begin
	if exists (select 1 from Rol where rol_desc = @rol_descripcion)
	begin
		set @code = 3
		set @msg = 'El rol ya existe'
		return;
	end
	
	begin try
	
		insert into Rol values (@rol_descripcion, @estado)
		declare @rol_id int = scope_identity();
		
		declare @func_id int
		
		declare cursor_func cursor for select * from @funcionalidades
		open cursor_func
		
		fetch next from cursor_func into @func_id
		
		while(@@FETCH_STATUS = 0)
		begin
			insert into Funcionalidad_Rol values (@rol_id, @func_id)
			fetch next from cursor_func into @func_id
		end
		
		set @code = 1;
		set @msg = 'Se ha creado el rol '
	end try
	begin catch
		set @code = 0;
		set @msg = 'Error al crear el rol '
		RollBack;
	end catch
		
	return;
end