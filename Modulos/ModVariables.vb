Imports System.Data.SqlClient

Module ModVariables


#Region "cadena de coneccion configurado por el XMl"
    Public servidor, bd, usuariodb, passworddb, rutareporte, RutaRptInv, servidor2, bd2, usuariodb2, passworddb2 As String 'variables del ini
    Public cadenac, STRCN, STRCN2 As String

#End Region

    Public CodUsuario As String
    Public DesUsuario As String
    Public UsuNivel As String
    Public codempresa As String
    Public DesEmpresa As String
    Public ds As DataSet
    Public AobjARRAYAYUDA(,) As Object

    'Public Obj As New ClsInterface
    Public CAyuda As New ClsAyuda



    Public IDIMPIGV As String
    Public IDIMPISC As String
    Public CDTICKET As String
    Public CDFACTURA As String
    Public CDBOLETA As String
    Public CDNTACREDP As String
    Public CDNTAPEDIDO As String
    Public CDGUIAVTA As String
    Public ITEMDEGUIA As String
    Public NTACRED_INS_CUENTA_CLIE As String
    Public DURACION_PEDIDO As String
    Public ITEMDEFACT As Integer
    Public ITEMDEBOLETA As Integer
    Public ITEMDENOTACRED As Integer
    Public ITEMDENTAPEDIDO As Integer
    Public CDMONBASE As String
    Public DECICANT As String
    Public DECICOST As String
    Public DECIPREC As String
    Public DECIRESU As String
    Public FECHAPROC As String
    Public PORCIGV As String
    Public NROPTOVTA As String
    Public CDZONA As String
    Public CDTIPOPRE1 As String
    Public CODFECTIVO As String
    Public CODDEPBAN As String
    Public CODCHEQUE As String
    Public CODCHEQUEDIF As String
    Public CODTRAN As String
    Public FECHA_INV As String
    Public ACTIVABD As Boolean
    Public ACTIVACAJA As Boolean
    Public LIMCREDITO As Integer
    Public PPPUNTOVENTA As Boolean
    Public PPFUERZVENTA As Boolean
    Public VCODINGCOMP As String
    Public CDSALNTACRED As String

    Public RUTAPRN As String


    Public RucEmpresa As String





    Public TIPOOPERACION As String
    Public DOMICILIOFISCAL As String
    Public RUTAARCHIVO As String
    Public EMIELECTRONIC As String

    Public FACTPTOVTA As Boolean
    Public FACTLINEA As Boolean
    Public FACTSUBEMP As Boolean

    Public FACTSUBEMPHU As Boolean
    Public FACTSUPERVHU As Boolean

    Public RESOLUCION As String
    Public URL As String
    Public CODCASH As String
    Public UBIGUEO As String
    Public CHECKPROMO As Double
    Public CORREO As String
    Public CANT_F As String
    Public COEFICIENT As Double


    Public PREC_BOLETA As Double
    Public PREC_FACTURA As Double
    Public PREC_NOTAPEDIDO As Double
    Public PORCDESC As Double
    Public TIPODESC As Boolean
    Public CANT_DIAS_ADE As Integer



    Public VCambioVta As Double
    Public VCambioCompra As Double
    Public VCorrelVta As Double
    Public VCorrelInv As Double
    Public VNroDespacho As Double
    Public VCdPagEfectivo As String
    Public VCdPagCredito As String
    Public VNroDoc As Double
    Public TipoDoc As String


    Public VCdTipoDoc As String
    Public VCodRuta As String
    Public VPtoLLegada As String
    Public VCodTiPrecioClie As String
    Public VCodDep As String
    Public VRuc As String
    Public VItemDoc As Integer
    Public vcdAlmacen As String
    Public VClieDep As String
    Public VUsarNotaPedido As Boolean
    Public VPrecio As Double
    Public VCantidad As Double
    Public VPrecioVta As Double
    Public VPorcenDesc As Double

    Public MARGENDESC As Double
    Public MARGENDESC_PORC As Double
    Public NOSERIE As String



    Public VFecDespacho As Date
    Public VCodCliente As String
    Public VCdTipoAnula As String
    Public VCdLiquidador As String
    Public VCdRepartidor As String
    Public VCdTipoRechazo As String

    Public VObserv As String
    Public VDescTotbas As Double
    Public VDescliente As String
    Public VDireccion As String
    Public VFecDocum As Date
    Public VTotBas As Double
    Public VTotExt As Double
    Public VCodVended As String
    Public VCodVended2 As String
    Public VCodArti As String
    Public VTipoMedida As String
    Public VCODRETENCION As String
    Public VCODPERCEPCION As String
    Public VCODNEXTEL As String

    Public FACT_xITEM As Integer
    Public FACT_tipom As Integer
    Public codtipopre As String
    Public NroGuiaDir As String
    Public GstrItemGuia As String
    Public Codigo_SalidaxTransferencia As String
    Public NroMovi As String
    Public Reos As Byte
    Public CONFIGGRID As String
    Public PROCESO1 As String
    Public FACT_CDMONEDA As String
    Public FACT_SIMBOLOMON As String
    Public FACT_SIMBOLOMONEXTR As String
    Public FilasAyudaG As Integer
    Public VAR1 As String
    Public VAR2 As String
    Public VAR3 As String
    Public VAR4 As String
    Public VAR5 As String
    Public VAR6 As String
    Public VAR7 As String
    Public VAR8 As String
    Public VAR9 As String
    Public VAR10 As String
    Public VAR11 As String
    Public VAR12 As String
    Public VAR13 As String
    Public VAR14 As String
    Public VAR15 As String
    Public VAR17 As String


    Public VAR18 As String
    Public VAR19 As String
    Public VAR20 As String
    Public VAR21 As String
    Public VAR22 As String
    Public VAR23 As String
    Public VAR24 As String
    Public VAR25 As String
    Public VAR26 As String
    Public VAR27 As String
    Public VAR28 As String
    Public VAR29 As String
    Public VAR30 As String
    Public VAR31 As String
    Public VAR32 As String
    Public VAR33 As String
    Public VAR34 As String
    Public VAR35 As String
    Public VAR36 As Integer
    Public VAR37 As String
    Public VAR38 As Integer
    Public VAR39 As String
    Public VAR40 As Integer
    Public VAR41 As String
    Public VAR42 As String
    Public VAR43 As String
    Public VAR44 As String

    Public VAR27TALMA As String

    Public VARTIPO As Boolean
    Public MARCA As String
    Public Venta As String
    Public Jostin As Boolean
    Public FACT_CODMONARTI As String
    Public FACT_EDITPRECIO As Boolean
    Public fact_editnumero As Boolean
    Public VEEIDTFECHA As Boolean
    Public FACT_GUIA As Boolean
    Public Tabla As String
    Public TablaDet As String
    Public DigitosDNI As String
    Public DigitosRuc As Integer = 11
    Public ZonaVenta As String
    Public fact_title As String
    Public FOCOVENTANA As String
    Public TIPO_PTOVTA As Integer = 1
    Public FACT_NUMEROTRANSACCION As Integer
    Public FACT_CONTROLAIGV As Boolean
    Public codgenerado As String
    Public importado As Boolean
    Public otros As Boolean
    Public AboolCargarValor As Boolean
    Public vFechaActual As Date


    Public MULT_NTACRED_X_NROREF As Boolean

    Public CLIENTEPTOVTA As String
    Public CHECKCLIPTOVTA As Boolean

    Public nroguia As String
    Public IMP As Boolean
    Public CODLOCAL As String


End Module
