Public Class TipoPagE

    Private mCODTIPOPAGO As String
    Public Property CODTIPOPAGO() As String
        Get
            Return mCODTIPOPAGO
        End Get
        Set(ByVal value As String)
            mCODTIPOPAGO = value
        End Set
    End Property


    Private mDSTIPOPAGO As String
    Public Property DSTIPOPAGO() As String
        Get
            Return mDSTIPOPAGO
        End Get
        Set(ByVal value As String)
            mDSTIPOPAGO = value
        End Set
    End Property


End Class
