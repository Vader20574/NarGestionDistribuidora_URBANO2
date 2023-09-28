Public Class PreciosE

    Private mCODIGO As String
    Public Property CODIGO() As String
        Get
            Return mCODIGO
        End Get
        Set(ByVal value As String)
            mCODIGO = value
        End Set
    End Property


    Private nPRECIO As Decimal
    Public Property PRECIO() As Decimal
        Get
            Return nPRECIO
        End Get
        Set(ByVal value As Decimal)
            nPRECIO = value
        End Set
    End Property


End Class
