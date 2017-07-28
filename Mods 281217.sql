Alter table ContratoEmpleado
add NumIdentidad char(13)
Constraint Fk_ContratoEmpleado_Empleado Foreign Key(NumIdentidad) References Empleado(NumIdentidad)

Create Table EmpleadoXContratoCliente
(
	NumIdentidad char(13) not null,
	IdContratoCliente int not null

	Constraint Pk_EmpleadoXContratoCliente Primary Key(NumIdentidad, IdContratoCliente)
	Constraint Fk_EmpleadoXContratoCliente_Empleado Foreign Key(NumIdentidad) References Empleado(NumIdentidad),
	Constraint Fk_EmpleadoXContratoCliente_ContratoCliente Foreign Key(IdContratoCliente) References ContratoCliente(IdContratoCliente)
)

USE [EVIPRIL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarContratoEmpleado]    Script Date: 28-Jul-17 10:57:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Sp_InsertarContratoEmpleado]
	@FechaInicio date,
	@FechaFinal date,
	@SueldoBase money,
	@IdTipoEmpleado int,
	@IdTipoContrato int,
	@NumIdentidad char(13)
as
	BEGIN
		Set nocount on
		Insert into ContratoEmpleado
		Values (@FechaInicio, @FechaFinal, @SueldoBase, @IdTipoEmpleado, @IdTipoContrato, @NumIdentidad)
	END

USE [EVIPRIL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_ModificarContratoEmpleado]    Script Date: 28-Jul-17 10:59:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Sp_ModificarContratoEmpleado]
	@FechaInicio date,
	@FechaFinal date,
	@SueldoBase money,
	@IdTipoEmpleado int,
	@IdTipoContrato int,
	@NumIdentidad char(13),
	@IdContratoEmpleado int
as
	BEGIN
		Set nocount on
		Update ContratoEmpleado
		set FechaInicio = @FechaInicio,
			FechaFinal = @FechaFinal,
			SueldoBase = @SueldoBase,
			IdTipoEmpleado = @IdTipoEmpleado,
			IdTipoContrato = @IdTipoContrato,
			NumIdentidad = @NumIdentidad
		Where IdContratoEmpleado = @IdContratoEmpleado
	END

ALTER PROCEDURE Sp_MostrarContratoCliente
as
	BEGIN
		Set nocount ON
		Select IdContratoCliente
		From ContratoCliente
	END

Create Procedure Sp_MostrarGuardiasAsignados
AS	
	BEGIN
		set nocount ON
		Select x.NumIdentidad, e.Nombres + ' ' + e.Apellidos as 'Nombre Guardia'
		From EmpleadoXContratoCliente x inner join Empleado e
			on x.NumIdentidad = e.NumIdentidad and x.IdContratoCliente = x.IdContratoCliente
	END