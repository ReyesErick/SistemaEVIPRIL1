USE [EVIPRIL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarGuardiasAsignados]    Script Date: 28-Jul-17 12:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[Sp_MostrarGuardiasAsignados]
@IdContratoCliente int
AS	
	BEGIN
		set nocount ON
		Select x.NumIdentidad, e.Nombres + ' ' + e.Apellidos as 'Nombre Guardia'
		From EmpleadoXContratoCliente x inner join Empleado e
		on x.NumIdentidad = e.NumIdentidad 
		Where x.IdContratoCliente = @IdContratoCliente
	END