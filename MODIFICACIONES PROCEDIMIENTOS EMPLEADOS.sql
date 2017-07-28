	-- AGREGAR EL ATRIBUTO ESTADO EN EMPLEADO

Alter table Empleado
add
	Estado bit not null
	Default 1

	-- INSERTAR EMPLEADO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Sp_InsertarEmpleado]
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
	@NumSeguro char(14),
	@Fotografia image,
	@Estado bit
as
	BEGIN
		Set nocount on
		Insert into Empleado
		Values(@NumIdentidad, @Nombres, @Apellidos, @Direccion, @Telefono, @Correo, @IdProfesion, @IdNacionalidad, @IdMunicipio, @IdBeneficiario, @IdEstadoCivil, @IdSexo, @Rtn, @Observacion, @NumSeguro, @Fotografia, @Estado)
	END

	-- MODIFICAR EMPLEADO

USE [EVIPRIL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_ModificarEmpleado]    Script Date: 27/7/2017 9:59:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Sp_ModificarEmpleado]
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
	@NumSeguro char(14),
	@Fotografia image,
	@Estado bit,
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
			NumSeguro = @NumSeguro,
			Fotografia = @Fotografia,
			Estado = @Estado
		Where NumIdentidad = @NumIdentidad
	END

	-- MOSTRAR TODOS LOS EMPLEADOS

USE [EVIPRIL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarEmpleado]    Script Date: 27/7/2017 10:03:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Sp_MostrarEmpleado]
as
	BEGIN
		Set nocount on
		Select e.NumIdentidad, e.Nombres,e.Apellidos, e.Direccion, e.Telefono, e.Correo, p.Profesion, n.Nacionalidad, m.Municipio,b.IdBeneficiario,b.Nombres +''+ b.Apellidos as 'NombreBeneficiario' , c.EstadoCivil, s.Sexo, Rtn, Observacion, e.NumSeguro, e.Fotografia, e.Estado
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

	-- MOSTRAR LOS EMPLEADOS EN EL GRID

USE [EVIPRIL]
GO
/****** Object:  StoredProcedure [dbo].[Sp_MostrarEmpleadoX]    Script Date: 27/7/2017 10:06:22 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Sp_MostrarEmpleadoX]
	@NumIDentidad char(13)
as
	BEGIN
		Set nocount on
		Select e.NumIdentidad, e.Nombres, e.Apellidos, e.Direccion, e.Telefono, e.Correo, p.Profesion, n.Nacionalidad, m.Municipio, e.IdBeneficiario, c.EstadoCivil, s.Sexo, Rtn, Observacion, e.NumSeguro, e.Estado
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

Create Procedure Sp_InsertarECC
	@NumIdentidad char(13),
	@IdContratoCliente INT
AS
	BEGIN
		Set nocount on
		Insert into EmpleadoXContratoCliente
		VALUES(@NumIdentidad, @IdContratoCliente)
	END

Create Procedure Sp_ModificarECC
	@NumIdentidad char(13),
	@IdContratoCliente INT,
	@NumIdentidadAct char(13),
	@IdContratoClienteAct INT
AS
	BEGIN
		Set nocount on
		Update EmpleadoXContratoCliente
		Set NumIdentidad = @NumIDentidad,
			IdContratoCliente = @IdContratoCliente
		Where NumIdentidad = @NumIdentidadAct and IdContratoCliente = @IdContratoClienteAct
	END


