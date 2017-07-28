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