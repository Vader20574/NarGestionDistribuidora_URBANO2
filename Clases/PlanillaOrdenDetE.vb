Public Class PlanillaOrdenDetE

    Private mTIPODOC As TipoDocE
    Public Property TIPODOC() As TipoDocE
        Get
            Return mTIPODOC
        End Get
        Set(ByVal value As TipoDocE)
            mTIPODOC = value
        End Set
    End Property

    Private mNRODOCU As Integer
    Public Property NRODOCU() As Integer
        Get
            Return mNRODOCU
        End Get
        Set(ByVal value As Integer)
            mNRODOCU = value
        End Set
    End Property

    Private mCODCLIENTE As String
    Public Property CODCLIENTE() As String
        Get
            Return mCODCLIENTE
        End Get
        Set(ByVal value As String)
            mCODCLIENTE = value
        End Set
    End Property


    Private mDESCLIENTE As String
    Public Property DESCLIENTE() As String
        Get
            Return mDESCLIENTE
        End Get
        Set(ByVal value As String)
            mDESCLIENTE = value
        End Set
    End Property


    Private mFECDOCUM As Date
    Public Property FECDOCUM() As Date
        Get
            Return mFECDOCUM
        End Get
        Set(ByVal value As Date)
            mFECDOCUM = value
        End Set
    End Property


    Private mTOTCREDBAS As Decimal
    Public Property TOTCREDBAS() As Decimal
        Get
            Return mTOTCREDBAS
        End Get
        Set(ByVal value As Decimal)
            mTOTCREDBAS = value
        End Set
    End Property


    Private mTOTCREDEXT As Decimal
    Public Property TOTCREDEXT() As Decimal
        Get
            Return mTOTCREDEXT
        End Get
        Set(ByVal value As Decimal)
            mTOTCREDEXT = value
        End Set
    End Property


    Private mSALDOBAS As Decimal
    Public Property SALDOBAS() As Decimal
        Get
            Return mSALDOBAS
        End Get
        Set(ByVal value As Decimal)
            mSALDOBAS = value
        End Set
    End Property

    Private mSALDOEXT As Decimal
    Public Property SALDOEXT() As Decimal
        Get
            Return mSALDOEXT
        End Get
        Set(ByVal value As Decimal)
            mSALDOEXT = value
        End Set
    End Property


    Private mPAGCREDBAS As Decimal
    Public Property PAGCREDBAS() As Decimal
        Get
            Return mPAGCREDBAS
        End Get
        Set(ByVal value As Decimal)
            mPAGCREDBAS = value
        End Set
    End Property

    Private mPAGCREDEXT As Decimal
    Public Property PAGCREDEXT() As Decimal
        Get
            Return mPAGCREDEXT
        End Get
        Set(ByVal value As Decimal)
            mPAGCREDEXT = value
        End Set
    End Property


    Private mCLIDEP As String
    Public Property CLIDEP() As String
        Get
            Return mCLIDEP
        End Get
        Set(ByVal value As String)
            mCLIDEP = value
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

    Private mDESCUENTO As Decimal
    Public Property DESCUENTO() As Decimal
        Get
            Return mDESCUENTO
        End Get
        Set(ByVal value As Decimal)
            mDESCUENTO = value
        End Set
    End Property

    Private mDESC_AUTORIZADO As Decimal
    Public Property DESC_AUTORIZADO() As Decimal
        Get
            Return mDESC_AUTORIZADO
        End Get
        Set(ByVal value As Decimal)
            mDESC_AUTORIZADO = value
        End Set
    End Property


    Private mCANCELARD As Boolean
    Public Property CANCELARD() As Boolean
        Get
            Return mCANCELARD
        End Get
        Set(ByVal value As Boolean)
            mCANCELARD = value
        End Set
    End Property



    Private mTIPOPAGO As TipoPagE
    Public Property TIPOPAGO() As TipoPagE
        Get
            Return mTIPOPAGO
        End Get
        Set(ByVal value As TipoPagE)
            mTIPOPAGO = value
        End Set
    End Property


End Class
