CREATE PROCEDURE MigrarDatos
AS
BEGIN

/*Carga_Credito != NULL --> Cargas + Trigger a Cliente
Cli_Dest != NULL --> Giftcard
Groupon_Codigo != NULL --> INSERT IF NOT EXISTS Grupos
Groupon_fecha_compra != NULL AND Groupon_entregado_fecha = NULL AND Factura_Fecha = NULL --> INSERT IF NOT EXISTS Trigger de Cupones y Trigger de Grupos, Trigger de Clientes (saldo). Subif: Groupon_Entregado_Fecha != NULL  Trigger Cupones
Groupon_Devolucion_Fecha != NULL --> Devoluciones + Trigger Cupones (estados) + Trigger Grupos (stock) + Trigger Cliente (saldo)
Factura_Fecha != NULL --> Facturas */

	DECLARE migrarCursor CURSOR FOR (SELECT * FROM Maestra)
	DECLARE @clienteNombre nvarchar(255), @clienteApellido nvarchar(255), @clienteDni numeric(18), 
			@clienteDireccion nvarchar(255), @clienteTelefono numeric(18), @clienteMail nvarchar(255),
			@clienteFechaNac datetime, @clienteCiudad nvarchar(255)
	DECLARE @cargaCredito numeric(18,2), @cargaFecha datetime, @tipoPago nvarchar(100)
	DECLARE @clienteDestNombre nvarchar(255), @clienteDestApellido nvarchar(255), @clienteDestDni numeric(18,0),
			@clienteDestDireccion nvarchar(255), @clienteDestTelefono numeric(18,0), @clienteDestMail nvarchar(255),
			@clienteDestFechaNac datetime, @clienteDestCiudad nvarchar(255)
	DECLARE @giftcardFecha datetime, @giftcardMonto numeric(18,2)
	DECLARE @proveedorRS nvarchar(100), @proveedorDireccion nvarchar(100), @proveedorCiudad nvarchar(255),
			@proveedorTelefono numeric(18,0), @proveedorCUIT nvarchar(20), @proveedorRubro nvarchar(100)
	DECLARE @grouponPrecio numeric(18,2), @grouponPrecioFicticio numeric(18,2), @grouponFecha datetime,
			@grouponFechaVencimiento datetime, @grouponCantidad numeric(18,0), @grouponDescripcion nvarchar(255),
			@grouponFechaCompra datetime, @grouponCodigo nvarchar(50), @grouponDevolucionFecha datetime,
			@grouponEntregadoFecha datetime
	DECLARE @facturaNro numeric(18,0), @facturaFecha datetime
	
	OPEN migrarCursor
	
	FETCH migrarCursor INTO @clienteNombre, @clienteApellido, @clienteDni, @clienteDireccion, @clienteTelefono, @clienteMail,
							@clienteFechaNac, @clienteCiudad, @cargaCredito, @cargaFecha, @tipoPago, @clienteDestNombre,
							@clienteDestApellido, @clienteDestDni, @clienteDestDireccion, @clienteDestTelefono,
							@clienteDestMail, @clienteDestFechaNac, @clienteDestCiudad, @giftcardFecha, @giftcardMonto,
							@proveedorRS, @proveedorDireccion, @proveedorCiudad, @proveedorTelefono, @proveedorCUIT,
							@proveedorRubro, @grouponPrecio, @grouponPrecioFicticio, @grouponFecha, @grouponFechaVencimiento,
							@grouponCantidad, @grouponDescripcion, @grouponFechaCompra, @grouponCodigo, @grouponDevolucionFecha,
							@grouponEntregadoFechtime, @facturaNro, @facturaFecha
	
	WHILE @@FETCH_STATUS = 0
	
		BEGIN
		
		--ACA VAN LOS IFS PRINCIPALES QUE LLAMAN A LOS PROCEDURES
		
		FETCH migrarCursor INTO @clienteNombre, @clienteApellido, @clienteDni, @clienteDireccion, @clienteTelefono, @clienteMail,
							@clienteFechaNac, @clienteCiudad, @cargaCredito, @cargaFecha, @tipoPago, @clienteDestNombre,
							@clienteDestApellido, @clienteDestDni, @clienteDestDireccion, @clienteDestTelefono,
							@clienteDestMail, @clienteDestFechaNac, @clienteDestCiudad, @giftcardFecha, @giftcardMonto,
							@proveedorRS, @proveedorDireccion, @proveedorCiudad, @proveedorTelefono, @proveedorCUIT,
							@proveedorRubro, @grouponPrecio, @grouponPrecioFicticio, @grouponFecha, @grouponFechaVencimiento,
							@grouponCantidad, @grouponDescripcion, @grouponFechaCompra, @grouponCodigo, @grouponDevolucionFecha,
							@grouponEntregadoFechtime, @facturaNro, @facturaFecha
		
		END

		

END