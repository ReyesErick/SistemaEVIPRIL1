Create table AudiLog
(
	IdAudiLog int primary key identity,
	Descripcion nvarchar(300) not null,
	Usuario nvarchar(50) not null
)

Create Procedure Sp_MostrarAudiLog
as
	BEGIN
		Set nocount on
		Select Descripcion, Usuario
		from AudiLog
	END