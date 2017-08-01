Alter table ContratoCliente add
	IdCliente int not null
	Constraint Fk_ContratoCliente_Cliente Foreign Key(IdCliente) References Cliente(IdCliente)

USE [EVIPRIL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarCliente]    Script Date: 31/7/2017 3:46:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Sp_InsertarCliente]
	@NombreCompañia nvarchar(50),
	@NombreContacto nvarchar(100),
	@Direccion nvarchar(300),
	@Telefono char(9),
	@EstadoCliente bit
as
	BEGIN
		Set nocount on
		Insert into Cliente
		Values(@NombreCompañia, @NombreContacto, @Direccion, @Telefono, @EstadoCliente)
	END


	USE [EVIPRIL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_ModificarCliente]    Script Date: 31/7/2017 3:47:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Sp_ModificarCliente]
	@IdCliente int,
	@NombreCompañia nvarchar(50),
	@NombreContacto nvarchar(100),
	@Direccion nvarchar(300),
	@Telefono char(9),
	@EstadoCliente bit
	
as
	BEGIN
		Set nocount on
		Update Cliente
		Set NombreCompañia = @NombreCompañia,
			NombreContacto = @NombreContacto,
			Direccion = @Direccion,
			Telefono = @Telefono,
			EstadoCliente = @EstadoCliente
		Where IdCliente = @IdCliente
	END


USE [EVIPRIL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarContratoCliente]    Script Date: 31/7/2017 3:54:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Sp_InsertarContratoCliente]
	@FechaInicio date,
	@FechaFinal date,
	@Monto money,
	@IdCliente int,
	@Observacion nvarchar(300)
as
	BEGIN
		Set nocount on
		Insert into ContratoCliente
		Values (@FechaInicio, @FechaFinal, @Monto, @IdCliente, @Observacion)
	END


Create Procedure Sp_MostrarArmas
as
	BEGIN
		Set nocount on
		Select ia.IdArma, ia.Serie, ia.Calibre, ma.Marca, m.Modelo, t.TipoArma, f.LugarFabricacion, ia.IdContratoCliente, ia.Estado
		From InventarioArmas ia inner join Modelo m
								on ia.IdModelo = m.IdModelo
								inner join Marca ma
								on m.IdMarca = ma.IdMarca
								inner join TipoArma t
								on ia.IdTipoArma = t.IdTipoArma
								inner join Fabricacion f
								on ia.IdFabricacion = f.IdFabricacion
	END