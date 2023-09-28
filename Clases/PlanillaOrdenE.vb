Public Class PlanillaOrdenE


    Private mCodempresa As String
    Public Property Codempresa() As String
        Get
            Return mCodempresa
        End Get
        Set(ByVal value As String)
            mCodempresa = value
        End Set
    End Property


    Private mCDCOBRADOR As String
    Public Property CDCOBRADOR() As String
        Get
            Return mCDCOBRADOR
        End Get
        Set(ByVal value As String)
            mCDCOBRADOR = value
        End Set
    End Property

    Private mCODMONEDA As String
    Public Property CODMONEDA() As String
        Get
            Return mCODMONEDA
        End Get
        Set(ByVal value As String)
            mCODMONEDA = value
        End Set
    End Property


    Private mNroPlanilla As Integer
    Public Property NroPlanilla() As Integer
        Get
            Return mNroPlanilla
        End Get
        Set(ByVal value As Integer)
            mNroPlanilla = value
        End Set
    End Property


    Private mFecha As Date
    Public Property Fecha() As Date
        Get
            Return mFecha
        End Get
        Set(ByVal value As Date)
            mFecha = value
        End Set
    End Property

    Private mTotalBas As Double
    Public Property TotalBas() As Double
        Get
            Return mTotalBas
        End Get
        Set(ByVal value As Double)
            mTotalBas = value
        End Set
    End Property

    Private mTOTALEXT As Decimal
    Public Property TOTALEXT() As Decimal
        Get
            Return mTOTALEXT
        End Get
        Set(ByVal value As Decimal)
            mTOTALEXT = value
        End Set
    End Property

    Private mESTADO As String
    Public Property ESTADO() As String
        Get
            Return mESTADO
        End Get
        Set(ByVal value As String)
            mESTADO = value
        End Set
    End Property


    Private mOBSERVACION As String
    Public Property OBSERVACION() As String
        Get
            Return mOBSERVACION
        End Get
        Set(ByVal value As String)
            mOBSERVACION = value
        End Set
    End Property


    Private mUSUARIO As String
    Public Property CDUSUARIO() As String
        Get
            Return mUSUARIO
        End Get
        Set(ByVal value As String)
            mUSUARIO = value
        End Set
    End Property


    Private mCAMBIO As Decimal
    Public Property CAMBIO() As Decimal
        Get
            Return mCAMBIO
        End Get
        Set(ByVal value As Decimal)
            mCAMBIO = value
        End Set
    End Property



    Private mDetalle As List(Of PlanillaOrdenDetE)
    Public Property DETALLE() As List(Of PlanillaOrdenDetE)
        Get
            Return mDetalle
        End Get
        Set(ByVal value As List(Of PlanillaOrdenDetE))
            mDetalle = value
        End Set
    End Property


End Class
