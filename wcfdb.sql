USE [WcfPersona]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 17-07-2019 2:46:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](250) NULL,
	[Apellidos] [varchar](250) NULL,
	[Rut] [int] NULL,
	[DvRut] [char](1) NULL,
	[Edad] [int] NULL,
	[Direccion] [varchar](250) NULL,
	[Correo] [varchar](250) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarPersona]    Script Date: 17-07-2019 2:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ActualizarPersona]
	@Id as int,
	@nombres as varchar(250),
	@apellidos as varchar(250),
	@rut as int,
	@dvrut as char(1),
	@edad as int,
	@direccion as varchar(250),
	@correo as varchar(250)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   UPDATE [dbo].[Persona]
   SET [Nombre] = @nombres
      ,[Apellidos] = @apellidos
      ,[Rut] = @rut
      ,[DvRut] = @dvrut
      ,[Edad] = @edad
      ,[Direccion] = @direccion
      ,[Correo] = @correo
 WHERE Id = @Id



END
GO
/****** Object:  StoredProcedure [dbo].[EliminarPersona]    Script Date: 17-07-2019 2:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarPersona]
	@Id as int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    
	DELETE FROM [dbo].[Persona]  WHERE Id = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[InsertarPersona]    Script Date: 17-07-2019 2:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertarPersona] 
	@nombres as varchar(250),
	@apellidos as varchar(250),
	@rut as int,
	@dvrut as char(1),
	@edad as int,
	@direccion as varchar(250),
	@correo as varchar(250)
AS
BEGIN
	
	INSERT INTO [dbo].[Persona]
           ([Nombre]
           ,[Apellidos]
           ,[Rut]
           ,[DvRut]
           ,[Edad]
           ,[Direccion]
           ,[Correo])
     VALUES
           (@nombres
           ,@apellidos
           ,@rut
           ,@dvrut
           ,@edad
           ,@direccion
           ,@correo)


END
GO
