Public Class VentaCabE

    Private mCODTIPODOC As String
    Public Property CODTIPODOC() As String
        Get
            Return mCODTIPODOC
        End Get
        Set(ByVal value As String)
            mCODTIPODOC = value
        End Set
    End Property


    Private mDSTIPODOC As String
    Public Property DSTIPODOC() As String
        Get
            Return mDSTIPODOC
        End Get
        Set(ByVal value As String)
            mDSTIPODOC = value
        End Set
    End Property

    Private mNRODOCU As Double
    Public Property NRODOCU() As Double
        Get
            Return mNRODOCU
        End Get
        Set(ByVal value As Double)
            mNRODOCU = value
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


    Private mCODMON As String
    Public Property CODMON() As String
        Get
            Return mCODMON
        End Get
        Set(ByVal value As String)
            mCODMON = value
        End Set
    End Property

    Private mEstado As String
    Public Property ESTADO() As String
        Get
            Return mEstado
        End Get
        Set(ByVal value As String)
            mEstado = value
        End Set
    End Property


    Private mVENTACAB As String
    Public Property VENTACAB() As String
        Get
            Return mVENTACAB
        End Get
        Set(ByVal value As String)
            mVENTACAB = value
        End Set
    End Property

    Private mMOVIDET As String
    Public Property MOVIDET() As String
        Get
            Return mMOVIDET
        End Get
        Set(ByVal value As String)
            mMOVIDET = value
        End Set
    End Property


End Class
