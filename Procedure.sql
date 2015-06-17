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

create procedure THE_ULTIMATES.SP_getClienteByTipoYNumeroDoc
@tipo_doc_id numeric(18,0),
@numero_doc numeric(18,0)
as
begin
	set nocount on;
	select * from THE_ULTIMATES.Cliente where clie_tipo_doc_id = @tipo_doc_id and clie_nro_doc = @numero_doc
end
go

create function THE_ULTIMATES.SP_getCuentasByClieId(@cliente_id int)
returns TABLE
as
return (select * from THE_ULTIMATES.Cuenta where cuen_clie_id = @cliente_id)

go
