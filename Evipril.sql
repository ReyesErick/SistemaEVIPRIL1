use master
GO
/****** Object:  Database [EVIPRIL]    Script Date: 25-Jul-17 10:25:02 PM ******/
CREATE DATABASE [EVIPRIL]

GO
ALTER DATABASE [EVIPRIL] SET ANSI_NULL_DEFAULT OFF 
GO
GO
ALTER DATABASE [EVIPRIL] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EVIPRIL] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EVIPRIL] SET ARITHABORT OFF 
GO
ALTER DATABASE [EVIPRIL] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [EVIPRIL] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EVIPRIL] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EVIPRIL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EVIPRIL] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EVIPRIL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EVIPRIL] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EVIPRIL] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EVIPRIL] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EVIPRIL] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EVIPRIL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EVIPRIL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EVIPRIL] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EVIPRIL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EVIPRIL] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EVIPRIL] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EVIPRIL] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EVIPRIL] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EVIPRIL] SET  MULTI_USER 
GO
ALTER DATABASE [EVIPRIL] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EVIPRIL] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EVIPRIL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EVIPRIL] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [EVIPRIL] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EVIPRIL] SET QUERY_STORE = OFF
GO
USE [EVIPRIL]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [EVIPRIL]
GO
/****** Object:  Schema [Sch_EVIPRIL]    Script Date: 25-Jul-17 10:25:02 PM ******/
CREATE SCHEMA [Sch_EVIPRIL]
GO
/****** Object:  Table [dbo].[Beneficiario]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Beneficiario](
	[IdBeneficiario] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [nvarchar](100) NOT NULL,
	[Apellidos] [nvarchar](100) NOT NULL,
	[Direccion] [nvarchar](300) NOT NULL,
	[Telefono] [char](9) NOT NULL,
	[TelefonoAuxiliar] [char](9) NULL,
	[NumIdentidad] [char](13) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdBeneficiario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[NombreCompañia] [nvarchar](50) NOT NULL,
	[NombreContacto] [nvarchar](100) NOT NULL,
	[Direccion] [nvarchar](300) NOT NULL,
	[Telefono] [char](9) NOT NULL,
	[IdContratoCliente] [int] NOT NULL,
	[EstadoCliente] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NombreCompañia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContratoCliente]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContratoCliente](
	[IdContratoCliente] [int] IDENTITY(1,1) NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFinal] [date] NOT NULL,
	[MontoEstipulado] [money] NOT NULL,
	[Observacion] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdContratoCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContratoEmpleado]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContratoEmpleado](
	[IdContratoEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFinal] [date] NULL,
	[SueldoBase] [money] NOT NULL,
	[IdTipoEmpleado] [int] NOT NULL,
	[IdTipoContrato] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdContratoEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamento](
	[IdDepto] [int] IDENTITY(1,1) NOT NULL,
	[Departamento] [nvarchar](50) NOT NULL,
	[IdPais] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[NumIdentidad] [char](13) NOT NULL,
	[Nombres] [nvarchar](100) NOT NULL,
	[Apellidos] [nvarchar](100) NOT NULL,
	[Direccion] [nvarchar](300) NOT NULL,
	[Telefono] [char](9) NOT NULL,
	[Correo] [nvarchar](50) NULL,
	[IdProfesion] [int] NOT NULL,
	[IdNacionalidad] [int] NOT NULL,
	[IdMunicipio] [int] NOT NULL,
	[IdBeneficiario] [int] NOT NULL,
	[IdEstadoCivil] [int] NOT NULL,
	[IdSexo] [int] NOT NULL,
	[Rtn] [char](14) NULL,
	[Observacion] [nvarchar](300) NULL,
	[IdContratoEmpleado] [int] NOT NULL,
	[NumSeguro] [char](14) NULL,
	[Fotografia] [image] NULL,
	[IdContratoCliente] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[NumIdentidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoCivil]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoCivil](
	[IdEstadoCivil] [int] IDENTITY(1,1) NOT NULL,
	[EstadoCivil] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEstadoCivil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[EstadoCivil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fabricacion]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fabricacion](
	[IdFabricacion] [int] IDENTITY(1,1) NOT NULL,
	[LugarFabricacion] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFabricacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[LugarFabricacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InventarioArmas]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventarioArmas](
	[IdArma] [int] IDENTITY(1,1) NOT NULL,
	[Serie] [nvarchar](50) NOT NULL,
	[Calibre] [int] NOT NULL,
	[IdModelo] [int] NOT NULL,
	[IdTipoArma] [int] NOT NULL,
	[IdFabricacion] [int] NOT NULL,
	[IdContratoCliente] [int] NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdArma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogAuditoria]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogAuditoria](
	[IdLogAuditoria] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](300) NOT NULL,
	[IdUsuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLogAuditoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[IdMarca] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modelo]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modelo](
	[IdModelo] [int] IDENTITY(1,1) NOT NULL,
	[Modelo] [nvarchar](50) NOT NULL,
	[IdMarca] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdModelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Modelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Municipio]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Municipio](
	[IdMunicipio] [int] IDENTITY(1,1) NOT NULL,
	[Municipio] [nvarchar](50) NOT NULL,
	[IdDepto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMunicipio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Municipio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nacionalidad]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nacionalidad](
	[IdNacionalidad] [int] IDENTITY(1,1) NOT NULL,
	[Nacionalidad] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdNacionalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Nacionalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pais](
	[IdPais] [int] IDENTITY(1,1) NOT NULL,
	[Pais] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Planilla]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planilla](
	[IdPlanilla] [int] IDENTITY(1,1) NOT NULL,
	[SueldoDiario] [money] NOT NULL,
	[DiasTrabajados] [int] NOT NULL,
	[SueldoQuincenal] [money] NOT NULL,
	[Complemento] [money] NOT NULL,
	[SubTotal] [money] NOT NULL,
	[DeduccionSeguro] [money] NOT NULL,
	[DeduccionUniforme] [money] NOT NULL,
	[Rap] [money] NOT NULL,
	[OtrasDeducciones] [money] NOT NULL,
	[TotalDeducciones] [money] NOT NULL,
	[NetoPagar] [money] NOT NULL,
	[NumIdentidad] [char](13) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPlanilla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prestaciones]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prestaciones](
	[IdPrestaciones] [int] IDENTITY(1,1) NOT NULL,
	[NumIdentidad] [char](13) NOT NULL,
	[PreAviso] [money] NOT NULL,
	[Vacaciones] [money] NOT NULL,
	[DecimoTercerMes] [money] NOT NULL,
	[DecimoCuartoMes] [money] NOT NULL,
	[Cesantia] [money] NOT NULL,
	[VacacionesProporcionales] [money] NOT NULL,
	[CesantiaProporcionales] [money] NOT NULL,
	[SubtotalPrestaciones] [money] NOT NULL,
	[TotalPrestaciones] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPrestaciones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesion]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesion](
	[IdProfesion] [int] IDENTITY(1,1) NOT NULL,
	[Profesion] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProfesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Profesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sexo](
	[IdSexo] [int] IDENTITY(1,1) NOT NULL,
	[Sexo] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Sexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoArma]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoArma](
	[IdTipoArma] [int] IDENTITY(1,1) NOT NULL,
	[TipoArma] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoArma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TipoArma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoContrato]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoContrato](
	[IdTipoContrato] [int] IDENTITY(1,1) NOT NULL,
	[TipoContrato] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoContrato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TipoContrato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoEmpleado]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoEmpleado](
	[IdTipoEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[TipoEmpleado] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TipoEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[NumIdentidad] [char](13) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[InventarioArmas] ADD  DEFAULT ((0)) FOR [Estado]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [Fk_Cliente_ContratoCliente] FOREIGN KEY([IdContratoCliente])
REFERENCES [dbo].[ContratoCliente] ([IdContratoCliente])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [Fk_Cliente_ContratoCliente]
GO
ALTER TABLE [dbo].[ContratoEmpleado]  WITH CHECK ADD  CONSTRAINT [Fk_ContratoEmpleado_TipoContrato] FOREIGN KEY([IdTipoContrato])
REFERENCES [dbo].[TipoContrato] ([IdTipoContrato])
GO
ALTER TABLE [dbo].[ContratoEmpleado] CHECK CONSTRAINT [Fk_ContratoEmpleado_TipoContrato]
GO
ALTER TABLE [dbo].[ContratoEmpleado]  WITH CHECK ADD  CONSTRAINT [Fk_ContratoEmpleado_TipoEmpleado] FOREIGN KEY([IdTipoEmpleado])
REFERENCES [dbo].[TipoEmpleado] ([IdTipoEmpleado])
GO
ALTER TABLE [dbo].[ContratoEmpleado] CHECK CONSTRAINT [Fk_ContratoEmpleado_TipoEmpleado]
GO
ALTER TABLE [dbo].[Departamento]  WITH CHECK ADD  CONSTRAINT [Fk_Departamento_Pais] FOREIGN KEY([IdPais])
REFERENCES [dbo].[Pais] ([IdPais])
GO
ALTER TABLE [dbo].[Departamento] CHECK CONSTRAINT [Fk_Departamento_Pais]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [Fk_Empleado_Beneficiario] FOREIGN KEY([IdBeneficiario])
REFERENCES [dbo].[Beneficiario] ([IdBeneficiario])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [Fk_Empleado_Beneficiario]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [Fk_Empleado_ContratoCliente] FOREIGN KEY([IdContratoCliente])
REFERENCES [dbo].[ContratoCliente] ([IdContratoCliente])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [Fk_Empleado_ContratoCliente]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [Fk_Empleado_ContratoEmpleado] FOREIGN KEY([IdContratoEmpleado])
REFERENCES [dbo].[ContratoEmpleado] ([IdContratoEmpleado])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [Fk_Empleado_ContratoEmpleado]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [Fk_Empleado_EstadoCivil] FOREIGN KEY([IdEstadoCivil])
REFERENCES [dbo].[EstadoCivil] ([IdEstadoCivil])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [Fk_Empleado_EstadoCivil]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [Fk_Empleado_Municipio] FOREIGN KEY([IdMunicipio])
REFERENCES [dbo].[Municipio] ([IdMunicipio])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [Fk_Empleado_Municipio]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [Fk_Empleado_Nacionalidad] FOREIGN KEY([IdNacionalidad])
REFERENCES [dbo].[Nacionalidad] ([IdNacionalidad])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [Fk_Empleado_Nacionalidad]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [Fk_Empleado_Profesion] FOREIGN KEY([IdProfesion])
REFERENCES [dbo].[Profesion] ([IdProfesion])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [Fk_Empleado_Profesion]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [Fk_Empleado_Sexo] FOREIGN KEY([IdSexo])
REFERENCES [dbo].[Sexo] ([IdSexo])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [Fk_Empleado_Sexo]
GO
ALTER TABLE [dbo].[InventarioArmas]  WITH CHECK ADD  CONSTRAINT [Fk_InventarioArmas_ContratoCliente] FOREIGN KEY([IdContratoCliente])
REFERENCES [dbo].[ContratoCliente] ([IdContratoCliente])
GO
ALTER TABLE [dbo].[InventarioArmas] CHECK CONSTRAINT [Fk_InventarioArmas_ContratoCliente]
GO
ALTER TABLE [dbo].[InventarioArmas]  WITH CHECK ADD  CONSTRAINT [Fk_InventarioArmas_Fabricacion] FOREIGN KEY([IdFabricacion])
REFERENCES [dbo].[Fabricacion] ([IdFabricacion])
GO
ALTER TABLE [dbo].[InventarioArmas] CHECK CONSTRAINT [Fk_InventarioArmas_Fabricacion]
GO
ALTER TABLE [dbo].[InventarioArmas]  WITH CHECK ADD  CONSTRAINT [Fk_InventarioArmas_Modelo] FOREIGN KEY([IdModelo])
REFERENCES [dbo].[Modelo] ([IdModelo])
GO
ALTER TABLE [dbo].[InventarioArmas] CHECK CONSTRAINT [Fk_InventarioArmas_Modelo]
GO
ALTER TABLE [dbo].[InventarioArmas]  WITH CHECK ADD  CONSTRAINT [Fk_InventarioArmas_TipoArma] FOREIGN KEY([IdTipoArma])
REFERENCES [dbo].[TipoArma] ([IdTipoArma])
GO
ALTER TABLE [dbo].[InventarioArmas] CHECK CONSTRAINT [Fk_InventarioArmas_TipoArma]
GO
ALTER TABLE [dbo].[LogAuditoria]  WITH CHECK ADD  CONSTRAINT [Fk_LogAuditoria_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[LogAuditoria] CHECK CONSTRAINT [Fk_LogAuditoria_Usuario]
GO
ALTER TABLE [dbo].[Modelo]  WITH CHECK ADD  CONSTRAINT [Fk_Modelo_Marca] FOREIGN KEY([IdMarca])
REFERENCES [dbo].[Marca] ([IdMarca])
GO
ALTER TABLE [dbo].[Modelo] CHECK CONSTRAINT [Fk_Modelo_Marca]
GO
ALTER TABLE [dbo].[Municipio]  WITH CHECK ADD  CONSTRAINT [Fk_Municipio_Departamento] FOREIGN KEY([IdDepto])
REFERENCES [dbo].[Departamento] ([IdDepto])
GO
ALTER TABLE [dbo].[Municipio] CHECK CONSTRAINT [Fk_Municipio_Departamento]
GO
ALTER TABLE [dbo].[Planilla]  WITH CHECK ADD  CONSTRAINT [Fk_Planilla_Empleado] FOREIGN KEY([NumIdentidad])
REFERENCES [dbo].[Empleado] ([NumIdentidad])
GO
ALTER TABLE [dbo].[Planilla] CHECK CONSTRAINT [Fk_Planilla_Empleado]
GO
ALTER TABLE [dbo].[Prestaciones]  WITH CHECK ADD  CONSTRAINT [Fk_Prestaciones_Empleado] FOREIGN KEY([NumIdentidad])
REFERENCES [dbo].[Empleado] ([NumIdentidad])
GO
ALTER TABLE [dbo].[Prestaciones] CHECK CONSTRAINT [Fk_Prestaciones_Empleado]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [Fk_Usuario_Empleado] FOREIGN KEY([NumIdentidad])
REFERENCES [dbo].[Empleado] ([NumIdentidad])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [Fk_Usuario_Empleado]
GO
/****** Object:  StoredProcedure [dbo].[Sp_ActualizarUsuario]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[Sp_ActualizarUsuario]
	@UserName nvarchar(40),
	@Password nvarchar (40),
	@Activo bit,
	@IdEmpleado char(13),
	@IdUsuario int
as
	Begin 
	set nocount on
	update Usuario set Usuario=@UserName,Contraseña=@Password,Estado=@Activo,NumIdentidad= @IdEmpleado
	where IdUsuario=@IdUsuario
End
GO
/****** Object:  StoredProcedure [dbo].[Sp_CargarPais]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_CargarPais]
as
	begin
		set nocount on
		select *
		from Pais
	end	
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarArma]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_EliminarArma]
	@IdArma int
as
	BEGIN
		Set nocount on
		Delete
		From InventarioArmas
		Where IdArma = @IdArma
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarBeneficiario]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[Sp_EliminarBeneficiario]
	@IdBeneficiario int
as
	BEGIN
		Set nocount on
		Delete
		From Beneficiario
		Where IdBeneficiario = @IdBeneficiario
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarDepartamento]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_EliminarDepartamento]
	 @IdDepto int
as
	BEGIN
		Set nocount on
		Delete
		From Departamento
		Where IdDepto = @IdDepto
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarEmpleado]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_EliminarEmpleado]
	@NumIdentidad char(13)
as
	BEGIN
		Set nocount on
		Delete
		From Empleado
		Where NumIdentidad = @NumIdentidad
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarEstadoCivil]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_EliminarEstadoCivil]
	@IdEstadoCivil int
as
	BEGIN
		Set nocount on
		Delete
		From EstadoCivil
		Where IdEstadoCivil = @IdEstadoCivil
	END

GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarFabricacion]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_EliminarFabricacion]
	@IdFabricacion int
as
	BEGIN
		Set nocount on
		Delete
		From Fabricacion
		Where IdFabricacion = @IdFabricacion
	END

GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarUsuario]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_EliminarUsuario]
	@IdUsuario int
as
	Begin 
	set nocount on
	delete Usuario where IdUsuario=@IdUsuario
End
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarArma]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_InsertarArma]
	@Serie nvarchar(50),
	@Calibre int,
	@IdModelo int,
	@IdTipoArma int,
	@IdFabricacion int,
	@IdContratoCliente int,
	@Estado bit
as
	BEGIN
		Set nocount on
		Insert into InventarioArmas
		Values(@serie, @Calibre, @IdModelo, @IdTipoArma, @IdFabricacion, @IdContratoCliente, @Estado)
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarBeneficiario]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[Sp_InsertarBeneficiario]
	@Nombres nvarchar(100),
	@Apellidos nvarchar(100),
	@Direccion nvarchar(300),
	@Telefono char(9),
	@TelefonoAuxiliar char(9),
	@NumIdentidad char(13)
as
	BEGIN
		Set nocount on
		Insert into Beneficiario
		Values(@Nombres, @Apellidos, @Direccion, @Telefono, @TelefonoAuxiliar, @Nombres)
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarCliente]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_InsertarCliente]
	@NombreCompañia nvarchar(50),
	@NombreContacto nvarchar(100),
	@Direccion nvarchar(300),
	@Telefono char(9),
	@idContratoCliente int,
	@EstadoCliente bit
as
	BEGIN
		Set nocount on
		Insert into Cliente
		Values(@NombreCompañia, @NombreContacto, @Direccion, @Telefono, @idContratoCliente, @EstadoCliente)
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarContratoCliente]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_InsertarContratoCliente]
	@FechaInicio date,
	@FechaFinal date,
	@Monto money,
	@Observacion nvarchar(300)
as
	BEGIN
		Set nocount on
		Insert into ContratoCliente
		Values (@FechaInicio, @FechaFinal, @Monto, @Observacion)
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarContratoEmpleado]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_InsertarContratoEmpleado]
	@FechaInicio date,
	@FechaFinal date,
	@SueldoBase money,
	@IdTipoEmpleado int,
	@IdTipoContrato int
as
	BEGIN
		Set nocount on
		Insert into ContratoEmpleado
		Values (@FechaInicio, @FechaFinal, @SueldoBase, @IdTipoEmpleado, @IdTipoContrato)
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarDepartamento]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_InsertarDepartamento]
	@Departamento nvarchar(50),
	@IdPais int
as
	BEGIN
		Set nocount on
		Insert into Departamento
		values(@Departamento, @IdPais)
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarEmpleado]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_InsertarEmpleado]
	@NumIdentidad char(13),
	@Nombres nvarchar(100),
	@Apellidos nvarchar(100),
	@Direccion nvarchar(100),
	@Telefono char(9),
	@Correo nvarchar(50),
	@IdProfesion int,
	@IdNacionalidad int,
	@IdMunicipio int,
	@IdBeneficiario int,
	@IdEstadoCivil int,
	@IdSexo int,
	@Rtn char(14),
	@Observacion nvarchar(300),
	@IdContratoEmpleado int,
	@NumSeguro char(14),
	@Fotografia image,
	@IdContratoCliente int
as
	BEGIN
		Set nocount on
		Insert into Empleado
		Values(@NumIdentidad, @Nombres, @Apellidos, @Direccion, @Telefono, @Correo, @IdProfesion, @IdNacionalidad, @IdMunicipio, @IdBeneficiario, @IdEstadoCivil, @IdSexo, @Rtn, @Observacion, @IdContratoEmpleado, @NumSeguro, @Fotografia, @IdContratoCliente)
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarEstadoCivil]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_InsertarEstadoCivil]
	@EstadoCivil nvarchar(50)
as
	BEGIN
		Set nocount on
		Insert into EstadoCivil
		Values(@EstadoCivil)
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarFabricacion]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[Sp_InsertarFabricacion]
	@LugarFabricacion nvarchar(50)
as
	BEGIN
		Set nocount on
		Insert into Fabricacion
		Values(@LugarFabricacion)
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarPlanilla]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_InsertarPlanilla]
	@SueldoDiario money,
	@DiasTrabajados int,
	@SueldoQuincenal money,
	@Complemento money,
	@SubTotal money,
	@DeduccionSeguro money,
	@DeduccionUniforme money,
	@Rap money,
	@OtrasDeducciones money,
	@TotalDeducciones money,
	@NetoPagar money,
	@NumIdentidad char(13)
as
	BEGIN
		Set nocount on
		Insert into Planilla
		Values(@SueldoDiario, @DiasTrabajados, @SueldoQuincenal, @Complemento, @SubTotal, @DeduccionSeguro, @DeduccionUniforme, @Rap, @OtrasDeducciones, @TotalDeducciones, @NetoPagar, @NumIdentidad)
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarUsuario]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_InsertarUsuario]
	@UserName nvarchar(40),
	@Password nvarchar (40),
	@Activo bit,
	@IdEmpleado char(13)
as
	Begin 
	set nocount on
	insert into Usuario values(	@UserName,@Password ,@IdEmpleado,@Activo) 
End
GO
/****** Object:  StoredProcedure [dbo].[Sp_ListarUsuario]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_ListarUsuario]
@var varchar(30)
as
	Begin 
		set nocount on 
		select U.IdUsuario ,U.Usuario ,U.Contraseña ,  U.Estado, E.Nombres + ' ' + E.Apellidos as 'Nombre Completo',E.NumIdentidad
		from Usuario U
		inner join Empleado E on E.NumIdentidad = U.NumIdentidad
		where E.Nombres + ' ' + E.Apellidos  Like @var + '%' or U.IdUsuario Like @var + '%'
	End
GO
/****** Object:  StoredProcedure [dbo].[Sp_Login]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_Login]
@UserName nvarchar(40),
@pass nvarchar(40)
As
Begin
	Set nocount on
	Select U.IdUsuario, U.Usuario, E.Nombres, E.Apellidos,U.Estado
	from Usuario U Inner Join Empleado E
	On U.NumIdentidad = E.NumIdentidad
	where U.Usuario = @UserName And U.Contraseña = @pass And U.Estado = 1
End
GO
/****** Object:  StoredProcedure [dbo].[Sp_ModificarArma]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_ModificarArma]
	@Serie nvarchar(50),
	@Calibre int,
	@IdModelo int,
	@IdTipoArma int,
	@IdFabricacion int,
	@IdContratoCliente int,
	@Estado bit,
	@IdArma int
as
	BEGIN
		Set nocount on
		Update InventarioArmas
		Set Serie = @Serie,
			Calibre = @Calibre,
			IdModelo = @IdModelo,
			IdTipoArma = @IdTipoArma,
			IdFabricacion = @IdFabricacion,
			IdContratoCliente = @IdContratoCliente,
			Estado = @Estado
		Where IdArma = @IdArma
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_ModificarBeneficiario]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_ModificarBeneficiario]
	@Nombres nvarchar(100),
	@Apellidos nvarchar(100),
	@Direccion nvarchar(300),
	@Telefono char(9),
	@TelefonoAuxiliar char(9),
	@IdBeneficiario int
as
	BEGIN
		Set nocount on
		Update Beneficiario
		set Nombres = @Nombres,
			Apellidos = @Apellidos,
			Direccion = @Direccion,
			Telefono = @Telefono,
			TelefonoAuxiliar = @TelefonoAuxiliar
		Where IdBeneficiario = @IdBeneficiario
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_ModificarCliente]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_ModificarCliente]
	@IdCliente int,
	@NombreCompañia nvarchar(50),
	@NombreContacto nvarchar(100),
	@Direccion nvarchar(300),
	@Telefono char(9),
	@idContratoCliente int,
	@EstadoCliente bit
	
as
	BEGIN
		Set nocount on
		Update Cliente
		Set NombreCompañia = @NombreCompañia,
			NombreContacto = @NombreContacto,
			Direccion = @Direccion,
			Telefono = @Telefono,
			IdContratoCliente = @idContratoCliente,
			EstadoCliente = @EstadoCliente
		Where IdCliente = @IdCliente
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_ModificarContratoEmpleado]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_ModificarContratoEmpleado]
	@FechaInicio date,
	@FechaFinal date,
	@SueldoBase money,
	@IdTipoEmpleado int,
	@IdTipoContrato int,
	@IdContratoEmpleado int
as
	BEGIN
		Set nocount on
		Update ContratoEmpleado
		set FechaInicio = @FechaInicio,
			FechaFinal = @FechaFinal,
			SueldoBase = @SueldoBase,
			IdTipoEmpleado = @IdTipoEmpleado,
			IdTipoContrato = @IdTipoContrato
		Where IdContratoEmpleado = @IdContratoEmpleado
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_ModificarDepartamento]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_ModificarDepartamento]
	@Departamento nvarchar(50),
	@IdPais int,
	@IdDepto int
as
	BEGIN
		Set nocount on
		Update Departamento
		set Departamento = @Departamento,
			IdPais = @IdPais
		Where IdDepto = @IdDepto
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_ModificarEmpleado]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_ModificarEmpleado]
	@Nombres nvarchar(100),
	@Apellidos nvarchar(100),
	@Direccion nvarchar(100),
	@Telefono char(9),
	@Correo nvarchar(50),
	@IdProfesion int,
	@IdNacionalidad int,
	@IdMunicipio int,
	@IdBeneficiario int,
	@IdEstadoCivil int,
	@IdSexo int,
	@Rtn char(14),
	@Observacion nvarchar(300),
	@IdContratoEmpleado int,
	@NumSeguro char(14),
	@Fotografia image,
	@NumIdentidad char(13)
as
	BEGIN
		Set nocount on
		Update Empleado
		Set Nombres = @Nombres,
			Apellidos = @Apellidos,
			Direccion = @Direccion,
			Telefono = @Telefono,
			Correo = @Correo,
			IdProfesion = @IdProfesion,
			IdNacionalidad = @IdNacionalidad,
			IdMunicipio = @IdMunicipio,
			IdBeneficiario = @IdBeneficiario,
			IdEstadoCivil = @IdEstadoCivil,
			IdSexo = @IdSexo,
			Rtn = @Rtn,
			Observacion = @Observacion,
			IdContratoEmpleado = @IdContratoEmpleado,
			NumSeguro = @NumSeguro,
			Fotografia = @Fotografia
		Where NumIdentidad = @NumIdentidad
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_ModificarEstadoCivil]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_ModificarEstadoCivil]
	@EstadoCivil nvarchar(50),
	@IdEstadoCivil int
as
	BEGIN
		Set nocount on
		Update EstadoCivil
		Set EstadoCivil = @EstadoCivil
		Where IdEstadoCivil = @IdEstadoCivil
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_ModificarFabricacion]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_ModificarFabricacion]
	@LugarFabricacion nvarchar(50),
	@IdFabricacion int
as
	BEGIN
		Set nocount on
		Update Fabricacion
		Set LugarFabricacion = @LugarFabricacion
		Where IdFabricacion = @IdFabricacion
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarArmas]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_MostrarArmas]
as 
	begin
		set nocount on
		select	i.IdArma,i.Serie,i.Calibre,m.Modelo,t.TipoArma,f.LugarFabricacion,i.IdContratoCliente, i.Estado
		from InventarioArmas i inner join Modelo m
								on i.IdModelo = m.IdModelo
							   inner join TipoArma t
								on i.IdTipoArma = t.IdTipoArma
							   inner join Fabricacion f
								on i.IdFabricacion = f.IdFabricacion
	end
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarBeneficiario]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_MostrarBeneficiario]
as
	BEGIN
		Set nocount on
		Select IdBeneficiario,Nombres+' '+Apellidos as 'Nombre'
		From Beneficiario
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarBeneficiarioX]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_MostrarBeneficiarioX]
	@IdBeneficiario int
as
	BEGIN
		Set nocount on
		Select *
		From Beneficiario
		Where IdBeneficiario = @IdBeneficiario
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarCliente]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_MostrarCliente]
as
	BEGIN
		Set nocount on
		Select *
		From Cliente
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarClienteX]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[Sp_MostrarClienteX]
	@IdCliente int
as
	BEGIN
		Set nocount on
		Select *
		From Cliente
		Where IdCliente = @IdCliente
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarContrato]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_MostrarContrato]
As
	begin
		set nocount on
		select IdContratoCliente
		from ContratoCliente
	end
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarContratoEmpleado]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_MostrarContratoEmpleado]
as
	BEGIN
		Set nocount on
		Select e.IdContratoEmpleado, e.FechaInicio, e.FechaFinal, e.SueldoBase, t.TipoEmpleado, c.TipoContrato
		From ContratoEmpleado e inner join TipoEmpleado t
						on e.IdTipoEmpleado = t.IdTipoEmpleado
								inner join TipoContrato c
						on e.IdTipoContrato = c.IdTipoContrato
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarContratoEmpleadoX]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_MostrarContratoEmpleadoX]
	@IdContratoEmpleado int
as
	BEGIN
		Set nocount on
		Select e.IdContratoEmpleado, e.FechaInicio, e.FechaFinal, e.SueldoBase, t.TipoEmpleado, c.TipoContrato
		From ContratoEmpleado e inner join TipoEmpleado t
						on e.IdTipoEmpleado = t.IdTipoEmpleado
								inner join TipoContrato c
						on e.IdTipoContrato = c.IdTipoContrato
		Where IdContratoEmpleado = @IdContratoEmpleado
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarDepartamento]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_MostrarDepartamento]
as
	BEGIN
		Select d.IdDepto, d.Departamento, p.Pais
		From Departamento d inner join pais p
							on d.IdPais = p.IdPais
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarDepartamentoX]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_MostrarDepartamentoX]
	@IdDepto int
as
	BEGIN
		Select d.IdDepto, d.Departamento, p.Pais
		From Departamento d inner join pais p
							on d.IdPais = p.IdPais
		Where d.IdDepto = @IdDepto
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarEmpleado]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_MostrarEmpleado]
as
	BEGIN
		Set nocount on
		Select e.NumIdentidad, e.Nombres,e.Apellidos, e.Direccion, e.Telefono, e.Correo, p.Profesion, n.Nacionalidad, m.Municipio,b.IdBeneficiario,b.Nombres +''+ b.Apellidos as 'NombreBeneficiario' , c.EstadoCivil, s.Sexo, Rtn, Observacion, e.IdContratoEmpleado, NumSeguro,Fotografia
		From Empleado e inner join Profesion p
						on e.IdProfesion = p.IdProfesion
						inner join Nacionalidad n
						on e.IdNacionalidad = n.IdNacionalidad
						inner join Municipio m
						on e.IdMunicipio = m.IdMunicipio
						inner join EstadoCivil c
						on e.IdEstadoCivil = c.IdEstadoCivil
						inner join Sexo s
						on e.IdSexo = s.IdSexo
						inner join Beneficiario b
						on e.IdBeneficiario = b.IdBeneficiario
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarEmpleadoX]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_MostrarEmpleadoX]
	@NumIDentidad char(13)
as
	BEGIN
		Set nocount on
		Select e.NumIdentidad, e.Nombres, e.Apellidos, e.Direccion, e.Telefono, e.Correo, p.Profesion, n.Nacionalidad, m.Municipio, e.IdBeneficiario, c.EstadoCivil, s.Sexo, Rtn, Observacion, e.IdContratoEmpleado, NumSeguro
		From Empleado e inner join Profesion p
						on e.IdProfesion = p.IdProfesion
						inner join Nacionalidad n
						on e.IdNacionalidad = n.IdNacionalidad
						inner join Municipio m
						on e.IdMunicipio = m.IdMunicipio
						inner join EstadoCivil c
						on e.IdEstadoCivil = c.IdEstadoCivil
						inner join Sexo s
						on e.IdSexo = s.IdSexo
		Where e.NumIdentidad = @NumIDentidad
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarEmpleadoX1]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_MostrarEmpleadoX1]
	@NumIDentidad char(13)
as
	BEGIN
		Set nocount on
		Select e.NumIdentidad, e.Nombres+' '+e.Apellidos as 'NombreEmpleado', e.Direccion, e.Telefono, e.Correo, p.Profesion, n.Nacionalidad, m.Municipio,d.Departamento,pa.Pais, b.Nombres+' '+b.Apellidos as 'Beneficiario', c.EstadoCivil, s.Sexo,e.Rtn, Observacion, con.FechaInicio,con.FechaFinal,con.SueldoBase,t.TipoEmpleado,ti.TipoContrato,e.NumSeguro,e.Fotografia
		From Empleado e inner join Profesion p
						on e.IdProfesion = p.IdProfesion
						inner join Nacionalidad n
						on e.IdNacionalidad = n.IdNacionalidad
						inner join Municipio m
						on e.IdMunicipio = m.IdMunicipio
						inner join EstadoCivil c
						on e.IdEstadoCivil = c.IdEstadoCivil
						inner join Sexo s
						on e.IdSexo = s.IdSexo
						inner join Beneficiario b
						on e.IdBeneficiario = b.IdBeneficiario
						inner join ContratoEmpleado con
						on e.IdContratoEmpleado = con.IdContratoEmpleado
						inner join TipoEmpleado t
						on con.IdTipoEmpleado = t.IdTipoEmpleado
						inner join TipoContrato ti
						on con.IdTipoContrato = ti.IdTipoContrato
						inner join Departamento d
						on m.IdDepto = d.IdDepto
						inner join Pais pa
						on d.IdPais = pa.IdPais
		Where e.NumIdentidad = @NumIDentidad
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarEstadoCivil]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_MostrarEstadoCivil]
as
	BEGIN
		Set nocount on
		Select *
		From EstadoCivil
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarEstadoCivilX]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_MostrarEstadoCivilX]
	@IdEstadoCivil int
as
	BEGIN
		Set nocount on
		Select *
		From EstadoCivil
		Where IdEstadoCivil = @IdEstadoCivil
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarFabricacion]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_MostrarFabricacion]
as
	BEGIN
		Set nocount on
		Select *
		From Fabricacion
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarFabricacionX]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_MostrarFabricacionX]
	@IdFabricacion int
as
	BEGIN
		Set nocount on
		Select *
		From Fabricacion
		Where IdFabricacion = @IdFabricacion
	END

GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarModelo]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_MostrarModelo]
as
	BEGIN
		Set nocount on
		Select *
		From Modelo
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarMunicipio]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_MostrarMunicipio]
As
	begin
		set nocount on
		select IdMunicipio,Municipio
		from Municipio
	end
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarNacionalidad]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_MostrarNacionalidad]
As
	begin
		set nocount on
		select *
		from Nacionalidad
	end
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarPlanilla]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_MostrarPlanilla]
	as
		begin
			set nocount on
			select *
			from Planilla
		end
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarProfesion]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_MostrarProfesion]
As
	begin
		set nocount on
		select *
		from Profesion
	end
GO
/****** Object:  StoredProcedure [dbo].[Sp_Mostrarsexo]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_Mostrarsexo]
As
	begin
		set nocount on
		select *
		from Sexo
	end
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarTipoArma]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_MostrarTipoArma]
as
	BEGIN
		Set nocount on
		Select *
		From TipoArma
	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarTipoContrato]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Sp_MostrarTipoContrato]
As
	begin
		set nocount on
		select *
		from TipoContrato
	end
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarTipoEmpleado]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_MostrarTipoEmpleado]
As
	begin
		set nocount on
		select *
		from TipoEmpleado
	end
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarUsuario]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure  [dbo].[Sp_MostrarUsuario]
as
	begin
		set nocount on
		select *
		from Usuario
	end
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostraUsuario]    Script Date: 25-Jul-17 10:25:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Sp_MostraUsuario]
as
	Begin 
		set nocount on 
		select U.IdUsuario ,U.Usuario ,U.Contraseña ,  U.Estado, E.Nombres + ' ' + E.Apellidos as 'Nombre Completo',E.NumIdentidad
		from Usuario U
		inner join Empleado E on E.NumIdentidad = U.NumIdentidad

	End
GO
USE [master]
GO
ALTER DATABASE [EVIPRIL] SET  READ_WRITE 
GO
