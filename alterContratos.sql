USE [EVIPRIL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarContratoEmpleado]    Script Date: 02/08/2017 10:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Sp_MostrarContratoEmpleado]
as
	BEGIN
		Set nocount on
		Select e.IdContratoEmpleado, e.FechaInicio, e.FechaFinal, e.SueldoBase, t.TipoEmpleado, c.TipoContrato, e.NumIdentidad,em.Nombres+' '+em.Apellidos as 'Nombre Completo'
		From ContratoEmpleado e inner join TipoEmpleado t
						on e.IdTipoEmpleado = t.IdTipoEmpleado
								inner join TipoContrato c
						on e.IdTipoContrato = c.IdTipoContrato
								inner join Empleado em
						on e.NumIdentidad = em.NumIdentidad
	END


	ALTER PROCEDURE [dbo].[Sp_MostrarContratoCliente]
as
	BEGIN
		Set nocount ON
		Select c.IdContratoCliente,c.FechaInicio,c.FechaFinal,c.MontoEstipulado,c.Observacion,cli.NombreCompañia
		From ContratoCliente c inner join Cliente cli
								on c.IdCliente = cli.IdCliente 
	END


	/*Nuevo procedimiento*/
	 
	create Procedure [dbo].[Sp_MostrarPlanillaReportes]
	as
		begin
			set nocount on
			select p.SueldoDiario,p.DiasTrabajados,p.SueldoQuincenal,p.Complemento,p.SubTotal,p.DeduccionSeguro,p.DeduccionUniforme,p.Rap,p.OtrasDeducciones,p.TotalDeducciones,p.NetoPagar,p.NumIdentidad,e.Nombres+' '+e.Apellidos as 'Nombre completo'
			from Planilla p inner join Empleado e
							on p.NumIdentidad = e.NumIdentidad
		end