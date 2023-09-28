Public Class RetencProvDetE

    Private mTIPODOC As TipoDocE
    Public Property TIPODOC() As TipoDocE
        Get
            Return mTIPODOC
        End Get
        Set(ByVal value As TipoDocE)
            mTIPODOC = value
        End Set
    End Property


    Private mSERIE As String
    Public Property SERIE() As String
        Get
            Return mSERIE
        End Get
        Set(ByVal value As String)
            mSERIE = value
        End Set
    End Property


    Private mCORRELATIVO As String
    Public Property CORRELATIVO() As String
        Get
            Return mCORRELATIVO
        End Get
        Set(ByVal value As String)
            mCORRELATIVO = value
        End Set
    End Property


    Private mFECHAEMISION As Date
    Public Property FECHAEMISION() As Date
        Get
            Return mFECHAEMISION
        End Get
        Set(ByVal value As Date)
            mFECHAEMISION = value
        End Set
    End Property


    Private mMONTOPAGO As Decimal
    Public Property MONTOPAGO() As Decimal
        Get
            Return mMONTOPAGO
        End Get
        Set(ByVal value As Decimal)
            mMONTOPAGO = value
        End Set
    End Property


    Private mMONTOPEXT As Decimal
    Public Property MONTOPEXT() As Decimal
        Get
            Return mMONTOPEXT
        End Get
        Set(ByVal value As Decimal)
            mMONTOPEXT = value
        End Set
    End Property



    Private mIMPORTERETENIDO As Decimal
    Public Property IMPORTERETENIDO() As Decimal
        Get
            Return mIMPORTERETENIDO
        End Get
        Set(ByVal value As Decimal)
            mIMPORTERETENIDO = value
        End Set
    End Property


    Private mIMPORTEREEXT As Decimal
    Public Property IMPORTEREEXT() As Decimal
        Get
            Return mIMPORTEREEXT
        End Get
        Set(ByVal value As Decimal)
            mIMPORTEREEXT = value
        End Set
    End Property

End Class
