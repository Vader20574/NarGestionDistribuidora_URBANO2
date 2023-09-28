Public Class Arti
    Private mCODARTICULO As String
    Public Property CODARTICULO() As String
        Get
            Return mCODARTICULO
        End Get
        Set(ByVal value As String)
            mCODARTICULO = value
        End Set
    End Property

    Private mCODALMACEN As String
    Public Property CODALMACEN() As String
        Get
            Return mCODALMACEN
        End Get
        Set(ByVal value As String)
            mCODALMACEN = value
        End Set
    End Property

    Private mPRECIO1 As Decimal
    Public Property PRECIO1() As Decimal
        Get
            Return mPRECIO1
        End Get
        Set(ByVal value As Decimal)
            mPRECIO1 = value
        End Set
    End Property



    Private mULTING As Date
    Public Property ULTING() As Date
        Get
            Return mULTING
        End Get
        Set(ByVal value As Date)
            mULTING = value
        End Set
    End Property

    'Private mULTSAL As Date
    'Public Property ULTSAL() As Date
    '    Get
    '        Return mULTSAL
    '    End Get
    '    Set(ByVal value As Date)
    '        mULTSAL = value
    '    End Set
    'End Property

    'Private mNROING As String
    'Public Property NROING() As String
    '    Get
    '        Return mNROING
    '    End Get
    '    Set(ByVal value As String)
    '        mNROING = value
    '    End Set
    'End Property


    'Private mNROSAL As String
    'Public Property NROSAL() As String
    '    Get
    '        Return mNROSAL
    '    End Get
    '    Set(ByVal value As String)
    '        mNROSAL = value
    '    End Set
    'End Property

End Class
