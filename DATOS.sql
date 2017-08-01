USE [EVIPRIL]
GO
SET IDENTITY_INSERT [dbo].[Beneficiario] ON 

GO
INSERT [dbo].[Beneficiario] ([IdBeneficiario], [Nombres], [Apellidos], [Direccion], [Telefono], [TelefonoAuxiliar], [NumIdentidad]) VALUES (1, N'Myriam', N'Ordoñez', N'HOLA', N'9898-9898', N'    -    ', N'Myriam       ')
GO
SET IDENTITY_INSERT [dbo].[Beneficiario] OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoCivil] ON 

GO
INSERT [dbo].[EstadoCivil] ([IdEstadoCivil], [EstadoCivil]) VALUES (2, N'Casado (a)')
GO
INSERT [dbo].[EstadoCivil] ([IdEstadoCivil], [EstadoCivil]) VALUES (3, N'Divorciado (a)')
GO
INSERT [dbo].[EstadoCivil] ([IdEstadoCivil], [EstadoCivil]) VALUES (1, N'Soltero (a)')
GO
INSERT [dbo].[EstadoCivil] ([IdEstadoCivil], [EstadoCivil]) VALUES (5, N'Unión Libre')
GO
INSERT [dbo].[EstadoCivil] ([IdEstadoCivil], [EstadoCivil]) VALUES (4, N'Viudo (a)')
GO
SET IDENTITY_INSERT [dbo].[EstadoCivil] OFF
GO
SET IDENTITY_INSERT [dbo].[Pais] ON 

GO
INSERT [dbo].[Pais] ([IdPais], [Pais]) VALUES (4, N'Costa Rica')
GO
INSERT [dbo].[Pais] ([IdPais], [Pais]) VALUES (2, N'El Salvador')
GO
INSERT [dbo].[Pais] ([IdPais], [Pais]) VALUES (1, N'Honduras')
GO
INSERT [dbo].[Pais] ([IdPais], [Pais]) VALUES (3, N'Nicaragua')
GO
SET IDENTITY_INSERT [dbo].[Pais] OFF
GO
SET IDENTITY_INSERT [dbo].[Departamento] ON 

GO
INSERT [dbo].[Departamento] ([IdDepto], [Departamento], [IdPais]) VALUES (1, N'Choluteca', 1)
GO
INSERT [dbo].[Departamento] ([IdDepto], [Departamento], [IdPais]) VALUES (2, N'Francisco Morazán', 1)
GO
INSERT [dbo].[Departamento] ([IdDepto], [Departamento], [IdPais]) VALUES (3, N'San Pedro Sula', 1)
GO
SET IDENTITY_INSERT [dbo].[Departamento] OFF
GO
SET IDENTITY_INSERT [dbo].[Municipio] ON 

GO
INSERT [dbo].[Municipio] ([IdMunicipio], [Municipio], [IdDepto]) VALUES (1, N'Choluteca', 1)
GO
INSERT [dbo].[Municipio] ([IdMunicipio], [Municipio], [IdDepto]) VALUES (2, N'El Corpus', 1)
GO
INSERT [dbo].[Municipio] ([IdMunicipio], [Municipio], [IdDepto]) VALUES (3, N'San Marcos de Colón', 1)
GO
INSERT [dbo].[Municipio] ([IdMunicipio], [Municipio], [IdDepto]) VALUES (4, N'Tegucigalpa', 2)
GO
SET IDENTITY_INSERT [dbo].[Municipio] OFF
GO
SET IDENTITY_INSERT [dbo].[Nacionalidad] ON 

GO
INSERT [dbo].[Nacionalidad] ([IdNacionalidad], [Nacionalidad]) VALUES (1, N'Hondureña')
GO
INSERT [dbo].[Nacionalidad] ([IdNacionalidad], [Nacionalidad]) VALUES (2, N'Nicaragüense')
GO
INSERT [dbo].[Nacionalidad] ([IdNacionalidad], [Nacionalidad]) VALUES (3, N'Salvadoreña')
GO
SET IDENTITY_INSERT [dbo].[Nacionalidad] OFF
GO
SET IDENTITY_INSERT [dbo].[Profesion] ON 

GO
INSERT [dbo].[Profesion] ([IdProfesion], [Profesion]) VALUES (2, N'Ingeniero en Ciencias de la Computacion')
GO
INSERT [dbo].[Profesion] ([IdProfesion], [Profesion]) VALUES (3, N'Licenciatura en Administracion')
GO
INSERT [dbo].[Profesion] ([IdProfesion], [Profesion]) VALUES (1, N'Licenciatura en Finanzas')
GO
SET IDENTITY_INSERT [dbo].[Profesion] OFF
GO
SET IDENTITY_INSERT [dbo].[Sexo] ON 

GO
INSERT [dbo].[Sexo] ([IdSexo], [Sexo]) VALUES (1, N'Femenino')
GO
INSERT [dbo].[Sexo] ([IdSexo], [Sexo]) VALUES (2, N'Masculino')
GO
SET IDENTITY_INSERT [dbo].[Sexo] OFF
GO
INSERT [dbo].[Empleado] ([NumIdentidad], [Nombres], [Apellidos], [Direccion], [Telefono], [Correo], [IdProfesion], [IdNacionalidad], [IdMunicipio], [IdBeneficiario], [IdEstadoCivil], [IdSexo], [Rtn], [Observacion], [NumSeguro], [Fotografia], [Estado]) VALUES (N'0601199601487', N'Erick', N'Reyes', N'UNICAH', N'9655-1361', N'', 2, 1, 1, 1, 1, 2, N'              ', N'', N'              ', NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

GO
INSERT [dbo].[Cliente] ([IdCliente], [NombreCompañia], [NombreContacto], [Direccion], [Telefono], [EstadoCliente]) VALUES (1, N'SO Microsystem', N'Edwin Ordoñez', N'UNICAH', N'9999-9999', 1)
GO
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[ContratoCliente] ON 

GO
INSERT [dbo].[ContratoCliente] ([IdContratoCliente], [FechaInicio], [FechaFinal], [MontoEstipulado], [Observacion], [IdCliente]) VALUES (1, CAST(N'2017-07-31' AS Date), CAST(N'2018-07-31' AS Date), 5000.0000, NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[ContratoCliente] OFF
GO
INSERT [dbo].[EmpleadoXContratoCliente] ([NumIdentidad], [IdContratoCliente]) VALUES (N'0601199601487', 1)
GO
SET IDENTITY_INSERT [dbo].[Fabricacion] ON 

GO
INSERT [dbo].[Fabricacion] ([IdFabricacion], [LugarFabricacion]) VALUES (1, N'Alemania')
GO
INSERT [dbo].[Fabricacion] ([IdFabricacion], [LugarFabricacion]) VALUES (2, N'China')
GO
INSERT [dbo].[Fabricacion] ([IdFabricacion], [LugarFabricacion]) VALUES (4, N'Estados Unidos')
GO
INSERT [dbo].[Fabricacion] ([IdFabricacion], [LugarFabricacion]) VALUES (3, N'Europa')
GO
SET IDENTITY_INSERT [dbo].[Fabricacion] OFF
GO
SET IDENTITY_INSERT [dbo].[Marca] ON 

GO
INSERT [dbo].[Marca] ([IdMarca], [Marca]) VALUES (1, N'Beretta')
GO
INSERT [dbo].[Marca] ([IdMarca], [Marca]) VALUES (2, N'Desert Eagle')
GO
INSERT [dbo].[Marca] ([IdMarca], [Marca]) VALUES (4, N'Remington')
GO
INSERT [dbo].[Marca] ([IdMarca], [Marca]) VALUES (3, N'Winchester')
GO
SET IDENTITY_INSERT [dbo].[Marca] OFF
GO
SET IDENTITY_INSERT [dbo].[Modelo] ON 

GO
INSERT [dbo].[Modelo] ([IdModelo], [Modelo], [IdMarca]) VALUES (1, N'92 fs', 1)
GO
INSERT [dbo].[Modelo] ([IdModelo], [Modelo], [IdMarca]) VALUES (2, N'357 Magnum', 2)
GO
INSERT [dbo].[Modelo] ([IdModelo], [Modelo], [IdMarca]) VALUES (3, N'41 MAgnum', 2)
GO
INSERT [dbo].[Modelo] ([IdModelo], [Modelo], [IdMarca]) VALUES (4, N'1912', 3)
GO
INSERT [dbo].[Modelo] ([IdModelo], [Modelo], [IdMarca]) VALUES (5, N'870', 4)
GO
SET IDENTITY_INSERT [dbo].[Modelo] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoArma] ON 

GO
INSERT [dbo].[TipoArma] ([IdTipoArma], [TipoArma]) VALUES (1, N'Escopeta')
GO
INSERT [dbo].[TipoArma] ([IdTipoArma], [TipoArma]) VALUES (3, N'Escuadra')
GO
INSERT [dbo].[TipoArma] ([IdTipoArma], [TipoArma]) VALUES (2, N'Revolver')
GO
SET IDENTITY_INSERT [dbo].[TipoArma] OFF
GO
SET IDENTITY_INSERT [dbo].[InventarioArmas] ON 

GO
INSERT [dbo].[InventarioArmas] ([IdArma], [Serie], [Calibre], [IdModelo], [IdTipoArma], [IdFabricacion], [IdContratoCliente], [Estado]) VALUES (1, N'968541', 9, 2, 2, 1, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[InventarioArmas] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoContrato] ON 

GO
INSERT [dbo].[TipoContrato] ([IdTipoContrato], [TipoContrato]) VALUES (1, N'Permanente')
GO
INSERT [dbo].[TipoContrato] ([IdTipoContrato], [TipoContrato]) VALUES (2, N'Temporal')
GO
SET IDENTITY_INSERT [dbo].[TipoContrato] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoEmpleado] ON 

GO
INSERT [dbo].[TipoEmpleado] ([IdTipoEmpleado], [TipoEmpleado]) VALUES (2, N'Administracion')
GO
INSERT [dbo].[TipoEmpleado] ([IdTipoEmpleado], [TipoEmpleado]) VALUES (1, N'Guardia de Seguridad')
GO
SET IDENTITY_INSERT [dbo].[TipoEmpleado] OFF
GO
SET IDENTITY_INSERT [dbo].[ContratoEmpleado] ON 

GO
INSERT [dbo].[ContratoEmpleado] ([IdContratoEmpleado], [FechaInicio], [FechaFinal], [SueldoBase], [IdTipoEmpleado], [IdTipoContrato], [NumIdentidad]) VALUES (1, CAST(N'2017-07-31' AS Date), CAST(N'2018-07-31' AS Date), 20000.0000, 2, 2, N'0601199601487')
GO
SET IDENTITY_INSERT [dbo].[ContratoEmpleado] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

GO
INSERT [dbo].[Usuario] ([IdUsuario], [Usuario], [Contraseña], [NumIdentidad], [Estado]) VALUES (1, N'ReyesErick', N'7110eda4d09e062aa5e4a390b0a572ac0d2c0220', N'0601199601487', 1)
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
