Public Class Efectividad




    Private mCATEGORIA As String
    Public Property CATEGORIA() As String
        Get
            Return mCATEGORIA
        End Get
        Set(ByVal value As String)
            mCATEGORIA = value
        End Set
    End Property


    Private mSUBCATEGORIA As String
    Public Property SUBCATEGORIA() As String
        Get
            Return mSUBCATEGORIA
        End Get
        Set(ByVal value As String)
            mSUBCATEGORIA = value
        End Set
    End Property


    Private mPRODUCTO As String
    Public Property PRODUCTO() As String
        Get
            Return mPRODUCTO
        End Get
        Set(ByVal value As String)
            mPRODUCTO = value
        End Set
    End Property


    Private mPTOS As Integer
    Public Property PTOS() As Integer
        Get
            Return mPTOS
        End Get
        Set(ByVal value As Integer)
            mPTOS = value
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

    Private mDESVEND As String
    Public Property DESVEND() As String
        Get
            Return mDESVEND
        End Get
        Set(ByVal value As String)
            mDESVEND = value
        End Set
    End Property


    Private mCORREL As String
    Public Property CORREL() As String
        Get
            Return mCORREL
        End Get
        Set(ByVal value As String)
            mCORREL = value
        End Set
    End Property


End Class
