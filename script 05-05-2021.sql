USE [URIEN]
GO

/****** Object:  StoredProcedure [dbo].[Gen_Tipos_Abm]    Script Date: 4/5/2021 14:05:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO








CREATE     Procedure [dbo].[Gen_Tipos_Abm]

@idTipo                 int = null,
@idTipodato              int = null,
@codigo                 varchar(20) = null,
@nombre                 varchar(50) = null,
@atributo               varchar(100) = null,
@defaultTipo             char(2) = null,
@usuario                varchar(20) = null,
@Modo                   char(1),
@codigoAfip             varchar(50)='',
@descrAfip              varchar(50)=''

AS

set nocount on

Declare @Idtipo_max as integer

set @Idtipo_max = 0

if @modo = 'A'
        begin
                INSERT  grl_tipo
                VALUES (@idtipodato,@nombre, @codigo, @atributo, @defaultTipo, null,
null, null, getdate(), @Usuario,@codigoAfip,@descrAfip)
                set @Idtipo_max = SCOPE_IDENTITY()
                if @idTipodato  =15 or @idTipodato      =20
                        insert iva_cortes values(@Idtipo_max,1.105,null,null,null,null)
                select @idTipo_max

        end
if @modo = 'B'
        begin
                UPDATE grl_tipo
                        set Bajalogica = getdate(),
                                UsuarioModificacion = @Usuario,
                                Fechamodificacion = getdate()
            WHERE IDtipo = @IDtipo
                select @idTipo
        end
if @modo = 'M'
        begin
                UPDATE grl_tipo
                        set nombre      =       @nombre,
                                codigo  =       @codigo,
                                atributo        = @atributo,
                                defaultTipo = @defaultTipo,
                                Fechamodificacion= getdate(),
                                usuarioModificacion = @usuario,
                                codigoAfip=@codigoAfip,
                                descrAfip=@descrAfip
            WHERE IDtipo = @IDtipo
                select @idTipo
        end



set nocount off




/*
Gen_Tipos_Abm '26','11','11','jerarquia','jera',0,'guest2','B'
select * from grl_tipo
*/


GO

/****** Object:  StoredProcedure [dbo].[UL_spC_ModuloXUsuario]    Script Date: 4/5/2021 14:05:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER OFF
GO









CREATE    Procedure [dbo].[UL_spC_ModuloXUsuario]
@IDUsuario smallint,
@Modo as varchar(1) = Null
AS

If  len(@Modo)=0 -- is null
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

	  
Else

 select	b.idmodulo as codigo,
        b.nombre
  from  grl_modulo b
  where b.BajaLogica is null
  and not exists (select 1 from grl_usuario_modulo a
                  where a.IdUsuario = @IDUsuario
                 and  a.idmodulo=b.idmodulo
                  and a.Bajalogica is null)


--- UL_spC_ModuloXUsuario 16,

--  UL_spC_ModuloXUsuario 16,"B"










GO

/****** Object:  StoredProcedure [dbo].[UL_spC_Usuario_Modulo]    Script Date: 4/5/2021 14:05:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[UL_spC_Usuario_Modulo]

-- UL_spC_Usuario_Modulo '',1


@login as varchar(20) = Null,
@modulo int

AS
set nocount on
                
If len(@login) = 0 -- is  null  
  select b.IDUsuario ,
	b.Nombre  ,
	b.Apellido  ,
	b.login,
	b.Password ,
/*	b.jerarquia as idJerarquia,
        descrip_Jerarquia=isnull((select rtrim(tipodato) + ' - '+rtrim(descripcion)
			from grl_tipodato where idtipodato=b.jerarquia), ' ') ,*/
	jerarquia = isnull((select top 1 a.jerarquia from grl_usuario_modulo a
				where b.idusuario=a.idusuario and 
				a.bajalogica is null and a.idmodulo=@Modulo),0) ,
	descrip_jerarquia = isnull((select top 1  tipodato+ ' - ' + c.descripcion from grl_usuario_modulo a
				inner join grl_tipodato c on a.jerarquia=c.idtipodato
				where a.idusuario=b.idusuario and 
				a.bajalogica is null and a.idmodulo=@Modulo),' ') ,
	b.idsuperior,
	superior= isnull((select top 1 rtrim(a.nombre)+' '+rtrim(a.apellido)
			from grl_usuario a where b.idsuperior=a.idusuario), ' ') ,
	b.bajalogica, isnull(idfrigorifico,0) as idfrigorifico
  from grl_usuario b
  where b.Bajalogica is null
  order by 2,1
else
  select b.IDUsuario ,
	b.Nombre  ,
	b.Apellido  ,
	b.login,
	b.Password ,
	jerarquia = case when login='CSCH' and @modulo =10 then 14 else isnull((select top 1 a.jerarquia from grl_usuario_modulo a
				where b.idusuario=a.idusuario and 
				a.bajalogica is null and a.idmodulo=1),0) end  ,
	descrip_jerarquia = isnull((select  top 1 tipodato+ ' - ' + c.descripcion from grl_usuario_modulo a
				inner join grl_tipodato c on a.jerarquia=c.idtipodato
				where a.idusuario=b.idusuario and 
				a.bajalogica is null and a.idmodulo=@Modulo),' ') ,
	b.idsuperior,
	superior= isnull((select  top 1 rtrim(a.nombre)+' '+rtrim(a.apellido)
			from grl_usuario a where b.idsuperior=a.idusuario), ' ') ,
	b.bajalogica,isnull(idfrigorifico,0) as idfrigorifico
        /*   orden = (select  orden from grl_tipodato where idtipodato=b.jerarquia)*/
  from grl_usuario b
  where b.login= @login


set nocount off
GO

/****** Object:  StoredProcedure [dbo].[UL_spC_Usuario]    Script Date: 4/5/2021 14:05:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- UL_spC_Usuario 'URIEN'

CREATE Procedure [dbo].[UL_spC_Usuario]
@login as varchar(20) = Null

AS
set nocount on
                
If Len(@login) =0 -- is  null  
  select b.IDUsuario ,
	b.Nombre  ,
	b.Apellido  ,
	b.login,
	b.Password ,
/*	b.jerarquia as idJerarquia,
        descrip_Jerarquia=isnull((select rtrim(tipodato) + ' - '+rtrim(descripcion)
			from grl_tipodato where idtipodato=b.jerarquia), ' ') ,*/
	jerarquia = isnull((select a.jerarquia from grl_usuario_modulo a
				where b.idusuario=a.idusuario and 
				a.bajalogica is null and a.idmodulo=1),0) ,
	descrip_jerarquia = isnull((select tipodato+ ' - ' + c.descripcion from grl_usuario_modulo a
				inner join grl_tipodato c on a.jerarquia=c.idtipodato
				where a.idusuario=b.idusuario and 
				a.bajalogica is null and a.idmodulo=1),' ') ,
	b.idsuperior,
	superior= isnull((select rtrim(a.nombre)+' '+rtrim(a.apellido)
			from grl_usuario a where b.idsuperior=a.idusuario), ' ') ,
	b.bajalogica, isnull(idfrigorifico,0) as idfrigorifico
  from grl_usuario b
  where b.Bajalogica is null
  order by 2,1
else
  select b.IDUsuario ,
	b.Nombre  ,
	b.Apellido  ,
	b.login,
	b.Password ,
	jerarquia = isnull((select a.jerarquia from grl_usuario_modulo a
				where b.idusuario=a.idusuario and 
				a.bajalogica is null and a.idmodulo=1),0) ,
	descrip_jerarquia = isnull((select tipodato+ ' - ' + c.descripcion from grl_usuario_modulo a
				inner join grl_tipodato c on a.jerarquia=c.idtipodato
				where a.idusuario=b.idusuario and 
				a.bajalogica is null and a.idmodulo=1),' ') ,
	b.idsuperior,
	superior= isnull((select rtrim(a.nombre)+' '+rtrim(a.apellido)
			from grl_usuario a where b.idsuperior=a.idusuario), ' ') ,
	b.bajalogica,isnull(idfrigorifico,0) as idfrigorifico
        /*   orden = (select  orden from grl_tipodato where idtipodato=b.jerarquia)*/
  from grl_usuario b
  where b.login= @login



set nocount off
GO

/****** Object:  StoredProcedure [dbo].[GRL_USUARIO_OT]    Script Date: 4/5/2021 14:05:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[GRL_USUARIO_OT]
as 

select 0 idusuario , '- Sin Descripcion - ' Usuario

union all

select  a.idusuario idUsuario,
			a.login  Usuario
						
			from 

			 GRL_USUARIO a 
			left join GRL_USUARIO  B ON A.idSuperior=B.idUsuario
			left join GRL_Tipo C  on a.idfrigorifico=c.IdTipo
			where a.bajalogica is null and b.bajalogica is null


GO

/****** Object:  StoredProcedure [dbo].[obtener_usuarios_cajas]    Script Date: 4/5/2021 14:05:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE  procedure [dbo].[obtener_usuarios_cajas]
as 
select a.idusuario, a.nombre+' '+a.apellido descripcion 
from GRL_USUARIO a
join GRL_USUARIO_MODULO b on a.idusuario=b.idusuario
join grl_modulo c on c.idmodulo=b.idmodulo
where a.bajalogica is null and b.bajalogica is null
and c.nombre = 'Caja'
GO

/****** Object:  StoredProcedure [dbo].[obtener_usuarios_cajas_]    Script Date: 4/5/2021 14:05:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create  procedure [dbo].[obtener_usuarios_cajas_]
as 

select 0 idusuario , '- Sin Descripcion - '



select  a.idusuario idUsuario,
			a.login  Usuario
						
			from 

			 GRL_USUARIO a 
			left join GRL_USUARIO  B ON A.idSuperior=B.idUsuario
			left join GRL_Tipo C  on a.idfrigorifico=c.IdTipo
			where a.bajalogica is null and b.bajalogica is null

select 

a.idusuario, 
a.nombre+' '+a.apellido descripcion 
from GRL_USUARIO a
join GRL_USUARIO_MODULO b on a.idusuario=b.idusuario
join grl_modulo c on c.idmodulo=b.idmodulo
where a.bajalogica is null and b.bajalogica is null

GO

/****** Object:  StoredProcedure [dbo].[GRL_TIPODATO_OF_CODIGO]    Script Date: 4/5/2021 14:05:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[GRL_TIPODATO_OF_CODIGO]

@CODIGO VARCHAR(20)

AS

/*
select 0 idTipoDato,'- Sin Especificar -' descripcion
union all 
*/
select idTipoDato, tipoDato + ' ' + descripcion as descripcion from GRL_TIPODATO
where codigo=@CODIGO

 --  GRL_TIPODATO_OF_CODIGO 'jera'
GO

/****** Object:  StoredProcedure [dbo].[GRL_TIPO_OF_TIPO]    Script Date: 4/5/2021 14:05:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[GRL_TIPO_OF_TIPO]

@IDTIPODATOS INT

AS

select 0 IdTipo,'- Sin Especificar -' nombre
union all 

select IdTipo, nombre from GRL_Tipo
where idTipoDato=@IDTIPODATOS
     AND bajaLogica is not null

-- GRL_TIPO_OF_TIPO 1
GO


