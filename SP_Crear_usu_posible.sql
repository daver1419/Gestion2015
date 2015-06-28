USE [GD1C2015]
GO

/****** Object:  StoredProcedure [THE_ULTIMATES].[SP_Crear_usu_posible]    Script Date: 06/27/2015 23:03:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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