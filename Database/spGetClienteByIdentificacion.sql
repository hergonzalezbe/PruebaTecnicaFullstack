use DBClientes
go

CREATE PROCEDURE spGetClienteByIdentificacion
    @identificacion NVARCHAR(20)
AS
BEGIN
    SELECT IdCliente
	,Identificacion
	,Nombre
	,Apellido
	,Email
	,FechaCreacion
	,FechaActualizacion
    FROM Clientes
    WHERE Identificacion = @identificacion
END;
