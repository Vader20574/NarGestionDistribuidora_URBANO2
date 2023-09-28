Public Class RetencProvCabE

    Private mCODIGO As String
    Public Property CODIGO() As String
        Get
            Return mCODIGO
        End Get
        Set(ByVal value As String)
            mCODIGO = value
        End Set
    End Property


    Private mCODPROV As String
    Public Property CODPROV() As String
        Get
            Return mCODPROV
        End Get
        Set(ByVal value As String)
            mCODPROV = value
        End Set
    End Property

    Private mFECHA As Date
    Public Property FECHA() As Date
        Get
            Return mFECHA
        End Get
        Set(ByVal value As Date)
            mFECHA = value
        End Set
    End Property


    Private mDETALLE As List(Of RetencProvDetE)
    Public Property DETALLE() As List(Of RetencProvDetE)
        Get
            Return mDETALLE
        End Get
        Set(ByVal value As List(Of RetencProvDetE))
            mDETALLE = value
        End Set
    End Property

End Class
