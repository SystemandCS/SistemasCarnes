USE [URIEN]
GO

/****** Object:  StoredProcedure [dbo].[_BUSCAR_EN_TABLA]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


 --Here is the complete stored procedure code: 
 
 
 --  _BUSCAR_EN_TABLA

CREATE PROC [dbo].[_BUSCAR_EN_TABLA]
(
	@SearchStr nvarchar(100)
)
AS
BEGIN

	-- Copyright © 2002 Narayana Vyas Kondreddi. All rights reserved.
	-- Purpose: To search all columns of all tables for a given search string
	-- Written by: Narayana Vyas Kondreddi
	-- Site: http://vyaskn.tripod.com
	-- Tested on: SQL Server 7.0 and SQL Server 2000
	-- Date modified: 28th July 2002 22:50 GMT


	CREATE TABLE #Results (ColumnName nvarchar(370), ColumnValue nvarchar(3630))

	SET NOCOUNT ON

	DECLARE @TableName nvarchar(256), @ColumnName nvarchar(128), @SearchStr2 nvarchar(110)
	SET  @TableName = ''
	SET @SearchStr2 = QUOTENAME('%' + @SearchStr + '%','''')

	WHILE @TableName IS NOT NULL
	BEGIN
		SET @ColumnName = ''
		SET @TableName = 
		(
			SELECT MIN(QUOTENAME(TABLE_SCHEMA) + '.' + QUOTENAME(TABLE_NAME))
			FROM 	INFORMATION_SCHEMA.TABLES
			WHERE 		TABLE_TYPE = 'BASE TABLE'
				AND	QUOTENAME(TABLE_SCHEMA) + '.' + QUOTENAME(TABLE_NAME) > @TableName
				AND	OBJECTPROPERTY(
						OBJECT_ID(
							QUOTENAME(TABLE_SCHEMA) + '.' + QUOTENAME(TABLE_NAME)
							 ), 'IsMSShipped'
						       ) = 0
		)

		WHILE (@TableName IS NOT NULL) AND (@ColumnName IS NOT NULL)
		BEGIN
			SET @ColumnName =
			(
				SELECT MIN(QUOTENAME(COLUMN_NAME))
				FROM 	INFORMATION_SCHEMA.COLUMNS
				WHERE 		TABLE_SCHEMA	= PARSENAME(@TableName, 2)
					AND	TABLE_NAME	= PARSENAME(@TableName, 1)
					AND	DATA_TYPE IN ('char', 'varchar', 'nchar', 'nvarchar')
					AND	QUOTENAME(COLUMN_NAME) > @ColumnName
			)
	
			IF @ColumnName IS NOT NULL
			BEGIN
				INSERT INTO #Results
				EXEC
				(
					'SELECT ''' + @TableName + '.' + @ColumnName + ''', LEFT(' + @ColumnName + ', 3630) 
					FROM ' + @TableName + ' (NOLOCK) ' +
					' WHERE ' + @ColumnName + ' LIKE ' + @SearchStr2
				)
			END
		END	
	END

	SELECT ColumnName AS COLUMNA, ColumnValue AS VALOR FROM #Results
END


/*
SELECT ROUTINE_NAME, ROUTINE_DEFINITION
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_DEFINITION LIKE '% @SearchStr %' AND ROUTINE_TYPE = 'PROCEDURE'*/
GO

/****** Object:  StoredProcedure [dbo].[_BUSCAR_EN_SP]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[_BUSCAR_EN_SP]

@search nvarchar(100)

AS

--declare @search varchar(50)
--SET @search = 'SCO_DESARROLLO'

SELECT 
ROUTINE_NAME
,ROUTINE_DEFINITION
FROM 
INFORMATION_SCHEMA.ROUTINES
WHERE 
ROUTINE_DEFINITION LIKE '%' + @search + '%'
AND ROUTINE_TYPE ='PROCEDURE'
ORDER BY
ROUTINE_NAME

-- _BUSCAR_EN_SP 'inscripto'
GO

/****** Object:  StoredProcedure [dbo].[Gen_Proveedor_OU]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- Gen_Proveedor_OU 1725


CREATE Procedure [dbo].[Gen_Proveedor_OU]
@idProveedor int

AS

set nocount on




begin
				select 
				idProveedor ,
				provNro ,
				isnull(razonSocial,' ') razonSocial ,
				isnull(CUIT,' ') cuit ,
				isnull(condIva,0) condiva ,
				isnull(calle,' ') calle,
				isnull(numero,' ') numero,
				isnull(piso,' ') piso,
				isnull(idLocalidad,0) idLocalidad,
				isnull(idprovincia,0) idprovincia,
				isnull(idPais,0) idPais,
				isnull(telPart,' ') telPart ,
				isnull(telfax ,' ') telfax,
				isnull(telCel,' ') telCel,
				isnull(cpostal, ' ') cpostal,
				isnull(RSComercial,' ' ) RSComercial,
				isnull(DomiciCom, ' ' ) DomiciCom,
				isnull(idLocaCom, 0) idLocaCom,
				isnull(TelCom, ' ') TelCom,
				isnull(TelFaxCom, ' ') TelFaxCom,
				isnull(cPostalCom, ' ') cPostalCom,
				isnull(Comision, 0) Comision,
				isnull(ImpSellos, 0) ImpSellos,
				isnull(DerRegistro, 0) DerRegistro,
				isnull(mbs, 0) mbs,
				isnull(Rec, 0) Rec,
				isnull(Comision2, 0) Comision2,
				isnull(FGarantia, 0) FGarantia,
				isnull(GastoFrigor, 0) GastoFrigor,
				isnull(Guia, 0) Guia,
				isnull(Otros, 0) Otros,
				isnull(Flete, 0) Flete,
				isnull(IngBrutos, ' ') IngBrutos,
				isnull(Procedencia, ' ') Procedencia,
				isnull(Ganancias, ' ') Ganancias,
				isnull(IBPorcen, 0) IBPorcen,
				isnull(observacion1,' ') observacion1,
				isnull(observacion2,' ') observacion2,
				isnull(email1,' ') email1,
				isnull(email2 ,' ') email2 
				, isnull(tipoCaracter,3) tipoCaracter
				, isnull(puntoVenta,16) puntoVenta
from grl_proveedor
where bajalogica is null AND 
idProveedor = @idProveedor

order by razonSocial
end


set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[Gen_Proveedor_Consul]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

alter Procedure [dbo].[Gen_Proveedor_Consul]
@idProveedor int = null,
@RazSoc varchar(100)=null,
@CUIt varchar(100)=null
AS


--Gen_Proveedor_Consul 0,'',''
set nocount on

if @idProveedor = 0 or @idProveedor is null
begin
     select 
					idProveedor ,
					provNro ,
					isnull(razonSocial,' ') razonSocial ,
					isnull(CUIT,' ') cuit ,
					isnull(condIva,0) condiva ,
					isnull(calle,' ') calle,
					isnull(numero,' ') numero,
					isnull(piso,' ') piso,
					isnull(idLocalidad,0) idLocalidad,
					isnull(idprovincia,0) idprovincia,
					isnull(idPais,0) idPais,
					isnull(telPart,' ') telPart ,
					isnull(telfax ,' ') telfax,
					isnull(telCel,' ') telCel,
					isnull(cpostal, ' ') cpostal,
					isnull(RSComercial,' ' ) RSComercial,
					isnull(DomiciCom, ' ' ) DomiciCom,
					isnull(idLocaCom, 0) idLocaCom,
					isnull(TelCom, ' ') TelCom,
					isnull(TelFaxCom, ' ') TelFaxCom,
					isnull(cPostalCom, ' ') cPostalCom,
					isnull(Comision, 0) Comision,
					isnull(ImpSellos, 0) ImpSellos,
					isnull(DerRegistro, 0) DerRegistro,
					isnull(mbs, 0) mbs,
					isnull(Rec, 0) Rec,
					isnull(Comision2, 0) Comision2,
					isnull(FGarantia, 0) FGarantia,
					isnull(GastoFrigor, 0) GastoFrigor,
					isnull(Guia, 0) Guia,
					isnull(Otros, 0) Otros,
					isnull(Flete, 0) Flete,
					isnull(IngBrutos, ' ') IngBrutos,
					isnull(Procedencia, ' ') Procedencia,
					isnull(Ganancias, ' ') Ganancias,
					isnull(IBPorcen, 0) IBPorcen,
					isnull(observacion1,' ') observacion1,
					isnull(observacion2,' ') observacion2,
					isnull(email1,' ') email1,
					isnull(email2 ,' ') email2 ,
					isnull(ruca,'') ruca,
					isnull(renspa,'') renspa
					, isnull(tipoCaracter,3) tipoCaracter
					, isnull(puntoVenta,16) puntoVenta
from grl_proveedor
where bajalogica is null
and (razonsocial like @RazSoc +'%' or @RazSoc ='' or @RazSoc is null) 
and (CUIT like @CUIT +'%' or @CUIT ='' or @CUIT is null) 
order by razonSocial
end
else
begin
					 select 
				idProveedor ,
				provNro ,
				isnull(razonSocial,' ') razonSocial ,
				isnull(CUIT,' ') cuit ,
				isnull(condIva,0) condiva ,
				isnull(calle,' ') calle,
				isnull(numero,' ') numero,
				isnull(piso,' ') piso,
				isnull(idLocalidad,0) idLocalidad,
				isnull(idprovincia,0) idprovincia,
				isnull(idPais,0) idPais,
				isnull(telPart,' ') telPart ,
				isnull(telfax ,' ') telfax,
				isnull(telCel,' ') telCel,
				isnull(cpostal, ' ') cpostal,
				isnull(RSComercial,' ' ) RSComercial,
				isnull(DomiciCom, ' ' ) DomiciCom,
				isnull(idLocaCom, 0) idLocaCom,
				isnull(TelCom, ' ') TelCom,
				isnull(TelFaxCom, ' ') TelFaxCom,
				isnull(cPostalCom, ' ') cPostalCom,
				isnull(Comision, 0) Comision,
				isnull(ImpSellos, 0) ImpSellos,
				isnull(DerRegistro, 0) DerRegistro,
				isnull(mbs, 0) mbs,
				isnull(Rec, 0) Rec,
				isnull(Comision2, 0) Comision2,
				isnull(FGarantia, 0) FGarantia,
				isnull(GastoFrigor, 0) GastoFrigor,
				isnull(Guia, 0) Guia,
				isnull(Otros, 0) Otros,
				isnull(Flete, 0) Flete,
				isnull(IngBrutos, ' ') IngBrutos,
				isnull(Procedencia, ' ') Procedencia,
				isnull(Ganancias, ' ') Ganancias,
				isnull(IBPorcen, 0) IBPorcen,
				isnull(observacion1,' ') observacion1,
				isnull(observacion2,' ') observacion2,
				isnull(email1,' ') email1,
				isnull(email2 ,' ') email2 
				, isnull(tipoCaracter,3) tipoCaracter
				, isnull(puntoVenta,16) puntoVenta
from grl_proveedor
where bajalogica is null AND 
idProveedor = @idProveedor
and (razonsocial like @RazSoc +'%' or @RazSoc ='' or @RazSoc is null) 
and (CUIT like @CUIT +'%' or @CUIT ='' or @CUIT is null) 
order by razonSocial
end


set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

/****** Object:  StoredProcedure [dbo].[Gen_Proveedor_Abm]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





alter Procedure [dbo].[Gen_Proveedor_Abm]
			@idproveedor int = null ,
			@provNro int = NULL ,
			@razonSocial varchar (100) = null ,
			@CUIT varchar (20) = NULL ,
			@condIva int = NULL ,
			@calle varchar (100) = NULL ,
			@numero varchar (5) = NULL ,
			@piso varchar (5) = NULL ,
			@idLocalidad int = NULL ,
			@idprovincia int = NULL ,
			@idPais int = NULL ,
			@telPart varchar (50) = null ,
			@telfax varchar (50) = null ,
			@telCel varchar (50) = null ,
			@cpostal varchar(12)=null,
			@RSComercial varchar(100) = null,
			@DomiciCom varchar (100) = NULL ,
			@idLocaCom int = NULL ,
			@TelCom varchar (50) = null ,
			@TelFaxCom varchar (50) = null ,
			@cPostalCom varchar(12)=null,
			@Comision decimal(15,2)=null,
			@ImpSellos decimal(15,2)=null,
			@DerRegistro decimal(15,2)=null,
			@mbs decimal(15,2)=null,
			@Rec decimal(15,2)=null,
			@Comision2 decimal(15,2)=null,
			@FGarantia decimal(15,2)=null,
			@GastoFrigor decimal(15,2)=null,
			@Guia decimal(15,2)=null,
			@Otros decimal(15,2)=null,
			@Flete decimal(15,2)=null,
			@IngBrutos char(1)=null,
			@Procedencia varchar(100)=null,
			@Ganancias char(1)=null,
			@IBPorcen decimal(9,3)=null,
			@observacion1 nvarchar (50) = NULL ,
			@observacion2 nvarchar (50) = NULL ,
			@email1 varchar (50) = NULL ,
			@email2 varchar (50) = NULL ,
			@usuario varchar(20) ,
			@Modo char(1),
			@todosReg int=null,
			@todosSell int=null,
			@ruca varchar(50)=null,
			@renspa varchar(50)=null,
			@tipoCaracter int=3,
			@puntoVenta int=16

AS
/*
select * from grl_proveedor
Gen_Proveedor_Abm '1','2','el prove2','dss',0,'fdsfd','32','323',2,3,2,
'fsdf','fsdf','fsdf','fsdf','fsdf','fsdf','fsdf','guest2','A'
*/

set nocount on

Declare @idproveedor_max int
Declare @proveedor_dupl int

set @idproveedor_max = 0
SET @proveedor_dupl = 0


if @modo = 'A'
begin
/* si el cuit existe no es un alta sino modificacion entonces sobreescribo el modo y el idproveedor y entra en el proximo if */
/* si el provNro existe no es un alta sino una modificacion del proveedor con dicho nro, sobreescribo el modo y entra en el proximo if*/
SET @proveedor_dupl = (SELECT TOP 1 idProveedor FROM GRL_PROVEEDOR WHERE CUIT = @CUIT or provNro = @provNro)
IF (@proveedor_dupl IS NULL OR @proveedor_dupl =0) 
BEGIN
INSERT INTO GRL_PROVEEDOR 
(
			provNro,
			razonSocial,
			CUIT,
			condIva,
			calle,
			numero,
			piso,
			idLocalidad,
			idprovincia,
			idPais,
			telPart,
			telfax,
			telCel,
			cpostal,
			RSComercial,
			DomiciCom,
			idLocaCom,
			TelCom,
			TelFaxCom,
			cPostalCom,
			Comision,
			ImpSellos,
			DerRegistro,
			mbs,
			Rec,
			Comision2,
			FGarantia,
			GastoFrigor,
			Guia,
			Otros,
			Flete,
			IngBrutos,
			Procedencia,
			Ganancias,
			IBPorcen,
			observacion1,
			observacion2,
			email1,
			email2,
			bajaLogica,
			fechaModificacion,
			usuarioModificacion,
			fechaCreacion,
			usuarioCreacion,
			ruca,
			renspa, 
			tipoCaracter,
			puntoVenta
)VALUES
(
			@provNro,
			@razonSocial,
			@CUIT,
			@condIva,
			@calle,
			@numero,
			@piso,
			@idLocalidad,
			@idprovincia,
			@idPais,
			@telPart,
			@telfax,
			@telCel,
			@cpostal,
			@RSComercial,
			@DomiciCom,
			@idLocaCom,
			@TelCom,
			@TelFaxCom,
			@cPostalCom,
			@Comision,
			@ImpSellos,
			@DerRegistro,
			@mbs,
			@Rec,
			@Comision2,
			@FGarantia,
			@GastoFrigor,
			@Guia,
			@Otros,
			@Flete,
			@IngBrutos,
			@Procedencia,
			@Ganancias,
			@IBPorcen,
			@observacion1,
			@observacion2,
			@email1,
			@email2,
			null, 
			null, 
			null, 
			getdate(), 
			@usuario,
			@ruca,
			@renspa,
			@tipoCaracter,
			@puntoVenta)

set @idproveedor_max = SCOPE_IDENTITY()
select @idproveedor_max
END
ELSE
BEGIN
SET @modo = 'M'
END
end

if @modo = 'B'
begin
			UPDATE grl_proveedor 
			set Bajalogica = getdate(),
			UsuarioModificacion = @usuario, 
			Fechamodificacion = getdate()
			WHERE idproveedor = @idproveedor 
end
select @idproveedor

if @modo = 'M'
begin
UPDATE GRL_PROVEEDOR
SET
			provNro = @provNro,
			razonSocial = @razonSocial,
			CUIT = @CUIT,
			condIva = @condIva,
			calle = @calle,
			numero = @numero,
			piso = @piso,
			idLocalidad = @idLocalidad,
			idprovincia = @idprovincia,
			idPais = @idPais,
			telPart = @telPart,
			telfax = @telfax,
			telCel = @telCel,
			cpostal = @cpostal,
			RSComercial = @RSComercial,
			DomiciCom = @DomiciCom,
			idLocaCom = @idLocaCom,
			TelCom = @TelCom,
			TelFaxCom = @TelFaxCom,
			cPostalCom = @cPostalCom,
			Comision = @Comision,
			ImpSellos = @ImpSellos,
			DerRegistro = @DerRegistro,
			mbs = @mbs,
			Rec = @Rec,
			Comision2 = @Comision2,
			FGarantia = @FGarantia,
			GastoFrigor = @GastoFrigor,
			Guia = @Guia,
			Otros = @Otros,
			Flete = @Flete,
			IngBrutos = @IngBrutos,
			Procedencia = @Procedencia,
			Ganancias = @Ganancias,
			IBPorcen = @IBPorcen,
			observacion1 = @observacion1,
			observacion2 = @observacion2,
			email1 = @email1,
			email2 = @email2,
			fechaModificacion = getdate(),
			usuarioModificacion = @usuario,
			ruca=@ruca,
			renspa=@renspa,
			tipoCaracter=@tipoCaracter,
			puntoVenta=@puntoVenta
WHERE idproveedor = @idproveedor 
select @idproveedor
if @todosSell=1 
UPDATE GRL_PROVEEDOR SET 
ImpSellos = @ImpSellos,
fechaModificacion = getdate(),
usuarioModificacion = @usuario

if @todosReg=1
UPDATE GRL_PROVEEDOR SET 
DerRegistro = @DerRegistro,
fechaModificacion = getdate(),
usuarioModificacion = @usuario

end



set nocount off



GO

/****** Object:  StoredProcedure [dbo].[UL_spIUD_Usuariomodulo]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO







-- UL_spIUD_Usuariomodulo 16,1,0,'EURIEN',1,'D'


alter    Procedure [dbo].[UL_spIUD_Usuariomodulo]

@IDUsuario int,
@Idmodulo int,
@idpuesto    int = null,
@Usuario as varchar(20),
@idJerarquia as int,
@Modo varchar(1)
 
AS

Begin 
set nocount on

Declare @IdusuarioModulo_max as integer

set @IdusuarioModulo_max = 0

If @Modo = 'A' --Nuevo
Begin
  INSERT  grl_usuario_modulo 
  VALUES (@IDUsuario, @Idmodulo, @idpuesto, @idJerarquia, null, null, null, getdate(), @Usuario)
  set @IdusuarioModulo_max = SCOPE_IDENTITY()

End
Else
  Begin
  If @Modo = 'D' and @IDUsuario <> 0 --Delete
     Begin
       UPDATE grl_usuario_modulo  set Bajalogica=getdate(),UsuarioModificacion = @Usuario, Fechamodificacion= getdate()
       WHERE IDUsuario = @IDUsuario and idmodulo=@idmodulo
     End
  End 

select @IdusuarioModulo_max

end

















GO

/****** Object:  StoredProcedure [dbo].[UL_spC_ModuloXUsuario]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER OFF
GO








alter    Procedure [dbo].[UL_spC_ModuloXUsuario]
@IDUsuario smallint
--@Modo as varchar(1) = Null
AS

--If  @Modo is null
   select 
			b.idmodulo as codigo,
			b.nombre,
			a.idusuario,
			a.jerarquia,
			--idTipoDato,
			tipoDato + ' ' + descripcion as Acceso
			
  from grl_usuario_modulo  a 
      inner join grl_modulo b on 		a.idmodulo=b.idmodulo
	  inner join GRL_TIPODATO C ON A.jerarquia=C.idTipoDato
  where a.idUsuario = @IDUsuario
       and b.Bajalogica is null
       and a.Bajalogica is null

	   /*
Else

 select	b.idmodulo as codigo,
        b.nombre
  from  grl_modulo b
  where b.BajaLogica is null
  and not exists (select 1 from grl_usuario_modulo a
                  where a.IdUsuario = @IDUsuario
                 and  a.idmodulo=b.idmodulo
                  and a.Bajalogica is null)
*/

--- UL_spC_ModuloXUsuario 16,

--  UL_spC_ModuloXUsuario 16,"B"










GO

/****** Object:  StoredProcedure [dbo].[GRL_TIPODATO_OF_CODIGO]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GRL_TIPODATO_OF_CODIGO]

@CODIGO VARCHAR(20)

AS

select idTipoDato, tipoDato + ' ' + descripcion as descripcion from GRL_TIPODATO
where codigo=@CODIGO

 --GRL_TIPODATO_OF_CODIGO 'jera'
GO

/****** Object:  StoredProcedure [dbo].[GRL_MODULO_ot]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure  [dbo].[GRL_MODULO_ot]

as


select idModulo as codigo, nombre from GRL_MODULO
GO

/****** Object:  StoredProcedure [dbo].[GRL_USUARIOS_OBTENER_MENUES]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure ProveedorTipo_Ot

as 

select 0 as IdcondIva , '-Sin Especificar-' Descripcion
union all
select 1 , 'Inscripto'
union all
select 2 ,'No inscripto'
union all
select 3 ,'Exento'




create procedure condiv_ot

as

select 0 as IdcondIva , '-Sin Especificar-' Descripcion
union all
select 1 , 'Inscripto'
union all
select 2 ,'No inscripto'
union all
select 3 ,'Exento'
union all
select 4 , 'Consumidor Final'
union all
select 5 , 'Monotributo'






alter PROCEDURE [dbo].[GRL_USUARIOS_OBTENER_MENUES]
@idUsuario  int
 AS
Select distinct menu,tipodato
   from grl_usuario_modulo a 
	join grl_modulo b on a.idModulo=b.idmodulo
	join  grl_tipodato c on idtipodato=jerarquia 

where idusuario=@idusuario
and a.bajalogica is null 
and b.bajalogica is null


 -- GRL_USUARIOS_OBTENER_MENUES 16
GO

/****** Object:  StoredProcedure [dbo].[_AdmDiccionarioDatos_Todos]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





create procedure [dbo].[_AdmDiccionarioDatos_Todos]

-- AdmDiccionarioDatos 'Presupuesto'


--@tabla varchar(50)


as




select 
	-- d.object_id,
	a.name [Tabla], -- identificara la Tabla
	b.name [Columna], -- identificara la columna
	c.name [Tipo], -- identificara el Tipo
	CASE-- recibe el tipo de columna
	  --cuando c es   numerico  o   c es     decimal   o  c es      Float   entonces se precisa el numero
		WHEN c.name = 'int' OR  c.name = 'decimal' OR c.name = 'float'  THEN b.precision
		ELSE null
	END [Precision], 
--  recibe maximo tama?o de b
	b.max_length as Longitud, 
	CASE -- recibe si la columna acepta nulos
		WHEN b.is_nullable = 0 THEN 'NO'
		ELSE 'SI'
	END [Permite_Nulo],
	CASE -- recibe si la columna es identity (autoincrementable)
		WHEN b.is_identity = 0 THEN 'NO'
		ELSE 'SI'
	END [Es Autonumerico],	
	ep.value [Descripcion],-- recibe la descripcion de la columna(si la hay)
	f.ForeignKey, -- recibe si es llave foranea
	f.ReferenceTableName, -- recibe la referencia de la tabla
	f.ReferenceColumnName -- recibe la referencia de la columna
from sys.tables a   
      --          //    Seleciona y muestra toda la informacion   \\          --
	inner join sys.columns b on a.object_id= b.object_id 
	inner join sys.systypes c on b.system_type_id= c.xtype 
	inner join sys.objects d on a.object_id= d.object_id 
	LEFT JOIN sys.extended_properties ep ON d.object_id = ep.major_id AND b.column_Id = ep.minor_id
	LEFT JOIN (SELECT 
				f.name AS ForeignKey,
				OBJECT_NAME(f.parent_object_id) AS TableName,
				COL_NAME(fc.parent_object_id,fc.parent_column_id) AS ColumnName,
				OBJECT_NAME (f.referenced_object_id) AS ReferenceTableName,
				COL_NAME(fc.referenced_object_id,fc.referenced_column_id) AS ReferenceColumnName
				FROM sys.foreign_keys AS f
				INNER JOIN sys.foreign_key_columns AS fc ON f.OBJECT_ID = fc.constraint_object_id)
				f ON f.TableName =a.name AND f.ColumnName =b.name

WHERE a.name <> 'sysname' and  c.name  <> 'sysname' 
--and
--ltrim(rtrim(a.name))= @tabla
ORDER BY a.name,b.column_Id

-- AdmDiccionarioDatos 'chequera'
GO

/****** Object:  StoredProcedure [dbo].[GRL_USUARIO_IN]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO









---UL_spIUD_Usuarios null,'nome','ape','pepe','loco',1,	1,'guest2','N'
CREATE    Procedure [dbo].[GRL_USUARIO_IN]

		@IDUsuario smallint = null,
		@Nombre varchar(30) = Null, 
		@Apellido varchar(30) = Null,
		@login varchar(20),
		@Pwd varchar(30) = Null,
		@jera int = null,
		@superior smallint =  null,
		@usuario varchar(20),
		@Modo varchar(1),
		@idFrigorifico int
AS

Begin 
set nocount on
Declare @IDUsuarioMax smallint

set @IDUsuarioMax = @IDUsuario


Begin
  INSERT  grl_usuario 
  VALUES (@login, @Nombre, @Apellido, rtrim(@Pwd), @superior,@idfrigorifico,null,null,null,getdate(),@Usuario)
  set @IDUsuarioMax = SCOPE_IDENTITY()
End


set @IDUsuario =@@IDENTITY
select @IDUsuario as IDUsuario

end
GO

/****** Object:  StoredProcedure [dbo].[GRL_USUARIO_OF_LISTA]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- grl_usuarios_of_lista 7

CREATE Procedure [dbo].[GRL_USUARIO_OF_LISTA]

@idusuario as int

AS
set nocount on
                

	select  a.idusuario idUsuario,
			a.login  Usuario,
			a.nombre Nombre,
			a.apellido Apellido,
			isnull(b.login,'---') as Superior,			
			isnull(c.nombre,'---') as Frigorifico,
			isnull(a.idfrigorifico,0) as idfrigorifico,
			isnull(a.idSuperior,0) as idSuperior
			from 

			 GRL_USUARIO a 
			left join GRL_USUARIO  B ON A.idSuperior=B.idUsuario
			left join GRL_Tipo C  on a.idfrigorifico=c.IdTipo

			 where a.idUsuario in (select idUsuario from GRL_USUARIOS_DEPENDENCIA(7))
			       and a.bajaLogica is null
			 
	
set nocount off


-- 
GO

/****** Object:  StoredProcedure [dbo].[GRL_USUARIO_EL]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO









---UL_spIUD_Usuarios null,'nome','ape','pepe','loco',1,	1,'guest2','N'
CREATE    Procedure [dbo].[GRL_USUARIO_EL]
@IDUsuario smallint = null,
@usuario varchar(20)

AS

Begin 
set nocount on
Declare @IDUsuarioMax smallint

set @IDUsuarioMax = @IDUsuario



     Begin
       UPDATE  grl_usuario set Bajalogica = getdate(), 
	           UsuarioModificacion= @usuariO

       WHERE IDUsuario = @IDUsuario

       UPDATE GRL_USUARIO_MODULO set
					   Bajalogica=getdate(),
					   usuarioModificacion= @Usuario,
					   fechaModificacion= getdate()
       WHERE IDUsuario = @IDUsuario

       UPDATE  grl_usuario set
				idsuperior = null ,
				UsuarioModificacion= @Usuario
       WHERE IDsuperior = @IDUsuario
     End
 


set @IDUsuario =@IDUsuarioMax
select @IDUsuario as IDUsuario

end
GO

/****** Object:  StoredProcedure [dbo].[GRL_USUARIO_OU]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- GRL_USUARIO_OU 7

CREATE Procedure [dbo].[GRL_USUARIO_OU]

@idusuario as int

AS
set nocount on
                

	select  a.idusuario idUsuario,
			a.login  Usuario,
			a.nombre Nombre,
			a.apellido Apellido,
			isnull(b.login,'---') as Superior,			
			isnull(c.nombre,'---') as Frigorifico,
			isnull(a.idfrigorifico,0) as idfrigorifico,
			isnull(a.idSuperior,0) as idSuperior,
			a.password as Password

			
			from 

			 GRL_USUARIO a 
			left join GRL_USUARIO  B ON A.idSuperior=B.idUsuario
			left join GRL_Tipo C  on a.idfrigorifico=c.IdTipo
			 where a.idUsuario =@idusuario
			 
	
set nocount off


-- 
GO

/****** Object:  StoredProcedure [dbo].[GRL_USUARIO_OT]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- GRL_USUARIO_OU 7

create Procedure [dbo].[GRL_USUARIO_OT]


AS
set nocount on
                

	select  a.idusuario idUsuario,
			a.login  Usuario,
			a.nombre Nombre,
			a.apellido Apellido,
			isnull(b.login,'---') as Superior,			
			isnull(c.nombre,'---') as Frigorifico,
			isnull(a.idfrigorifico,0) as idfrigorifico,
			isnull(a.idSuperior,0) as idSuperior,
			a.password as Password

			
			from 

			 GRL_USUARIO a 
			left join GRL_USUARIO  B ON A.idSuperior=B.idUsuario
			left join GRL_Tipo C  on a.idfrigorifico=c.IdTipo
			
			 
	
set nocount off


-- 
GO

/****** Object:  StoredProcedure [dbo].[GRL_USUARIO_Ac]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO









---  GRL_USUARIOS_Ac 1,'nome','ape','pepe','loquito',1,	1,'guest2','N',1

CREATE    Procedure [dbo].[GRL_USUARIO_Ac]
@IDUsuario smallint = null,
@Nombre varchar(30) = Null, 
@Apellido varchar(30) = Null,
@login varchar(20),
@Pwd varchar(30) = Null,
@jera int = null,
@superior smallint =  null,
@usuario varchar(20),
@Modo varchar(1),
@idFrigorifico int
AS

Begin 
set nocount on
Declare @IDUsuarioMax smallint

set @IDUsuarioMax = @IDUsuario

begin
        UPDATE  grl_usuario
	    set 
		Nombre = @Nombre, 
		    Apellido= @Apellido,
	   	    login=@login, 
		    Password=rtrim(@Pwd),
		    idSuperior=@superior,
	    	UsuarioModificacion=@Usuario , 
            FechaModificacion=getdate(),
	        idFrigorifico=@idFrigorifico
        WHERE IDUsuario = @IDUsuario
  End 
end


 --if @@error = 0

  set @IDUsuario =@IDUsuarioMax
  select @IDUsuario as IDUsuario




GO

/****** Object:  StoredProcedure [dbo].[GRL_TIPO_OF_TIPO]    Script Date: 12/4/2021 22:51:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GRL_TIPO_OF_TIPO]

@IDTIPODATOS INT

AS


select * from GRL_Tipo
where idTipoDato=@IDTIPODATOS
     AND bajaLogica is not null

-- GRL_TIPO_OF_TIPO 1
GO




create procedure [dbo].[ProveedorTipo_Ot]

as 

select 0 as IdProveedorTipo  , '-Sin Especificar-' Descripcion
union all
select 1 , 'Productor/Criador'
union all
select 2 ,'Feed Lot'
union all
select 3 ,'Invernador'


create procedure [dbo].[condiva_ot]

as

select 0 as IdcondIva , '-Sin Especificar-' Descripcion
union all
select 1 , 'Inscripto'
union all
select 2 ,'No inscripto'
union all
select 3 ,'Exento'
union all
select 4 , 'Consumidor Final'
union all
select 5 , 'Monotributo'



create FUNCTION GRL_USUARIOS_DEPENDENCIA
(	
	@idUsuario INT
)
RETURNS TABLE 
AS
RETURN 
(
	/*SELECT ID, NOMBRE + ' - ' + DESCRIPCION AS NOMBRE,DESCRIPCION,ID_SGO_GEN_ELEMENTO_GN_PADRE,ES_UNIDAD,PREFIJO,EMAIL,FLAG_MOSTRAR,IDTX,ULTIMA_MODIFICACION,USUARIO 
	FROM SGO_GEN_ELEMENTO_GN 
	WHERE	( ID = @ID_SGO_GEN_ELEMENTO_GN OR 
			PADRES LIKE '%' + LTRIM(STR(@ID_SGO_GEN_ELEMENTO_GN)) + '%' ) AND
			FLAG_MOSTRAR= 0 
			*/
	WITH ELEMENTOS (idUsuario,  nombre,apellido,idsuperior)
AS
(

    SELECT idUsuario,  nombre,apellido,idsuperior 

		FROM GRL_USUARIO
		WHERE IDUSUARIO =@idUsuario

	UNION ALL
--RECURSIVIDAD
	--SELECT e.ID, e.Nombre, e.DESCRIPCION, e.ID_SGO_GEN_ELEMENTO_GN_PADRE
	SELECT E.idUsuario, E.NOMBRE,e.apellido ,E.idsuperior

		FROM GRL_USUARIO AS e JOIN ELEMENTOS AS m
			ON e.idsuperior = m.idUsuario
)
-- Desplegar ResultSet
SELECT * FROM ELEMENTOS
)


--FCN_CELULA_DEPENDENCIA 11


create  Procedure [dbo].[Gen_Tipos_ou]
@idtipo int


as

                select
                        IdTipo,
                        idTipodato,
                        nombre,
                        codigo,
                        isnull(atributo,' ') as atributo,
                        isnull(defaultTipo,' ') as defaulttipo,
                        fechaModificacion,
                        usuarioModificacion,
                        fechaCreacion,
                        usuarioCreacion,
                        codigoAfip,
                        descrAfip
                from grl_tipo
                where idtipo = @idtipo and
                                bajalogica is null