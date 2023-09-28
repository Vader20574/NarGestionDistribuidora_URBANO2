Public Class TransPrecios3

    Private mcodCliente As String
    Public Property CODCLIENTE() As String
        Get
            Return mcodCliente
        End Get
        Set(ByVal value As String)
            mcodCliente = value
        End Set
    End Property


    Private mTipoDoc As String

    Public Property TIPODOC() As String
        Get
            Return mTipoDoc
        End Get
        Set(ByVal value As String)
            mTipoDoc = value
        End Set
    End Property


    Private mNRODOC As String
    Public Property NRODOC() As String
        Get
            Return mNRODOC
        End Get
        Set(ByVal value As String)
            mNRODOC = value
        End Set
    End Property


    Private mCODVEND As String
    Public Property CODVEND() As String
        Get
            Return mCODVEND
        End Get
        Set(ByVal value As String)
            mCODVEND = value
        End Set
    End Property


End Class
