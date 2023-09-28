Public Class ArtiComision
    Private mCODARTICULO As String
    Public Property CODARTICULO() As String
        Get
            Return mCODARTICULO
        End Get
        Set(ByVal value As String)
            mCODARTICULO = value
        End Set
    End Property

    Private mCDTIPOCOM As String
    Public Property CDTIPOCOM() As String
        Get
            Return mCDTIPOCOM
        End Get
        Set(ByVal value As String)
            mCDTIPOCOM = value
        End Set
    End Property

    Private mPORC_COM As Decimal
    Public Property PORC_COM() As Decimal
        Get
            Return mPORC_COM
        End Get
        Set(ByVal value As Decimal)
            mPORC_COM = value
        End Set
    End Property



    Private mFECINI As Date
    Public Property FECINI() As Date
        Get
            Return mFECINI
        End Get
        Set(ByVal value As Date)
            mFECINI = value
        End Set
    End Property



    Private mFECFINAL As Date
    Public Property FECFINAL() As Date
        Get
            Return mFECFINAL
        End Get
        Set(ByVal value As Date)
            mFECFINAL = value
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
