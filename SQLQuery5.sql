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
