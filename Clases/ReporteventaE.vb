Public Class ReporteVentaE
    Implements IComparable


    Private mCODIGO As String
    Public Property CODIGO() As String
        Get
            Return mCODIGO
        End Get
        Set(ByVal value As String)
            mCODIGO = value
        End Set
    End Property

    Private mCODSUBLINE As String
    Public Property CODSUBLINE() As String
        Get
            Return mCODSUBLINE
        End Get
        Set(ByVal value As String)
            mCODSUBLINE = value
        End Set
    End Property


    Private mDESCRIPCION As String
    Public Property DESCRIPCION() As String
        Get
            Return mDESCRIPCION
        End Get
        Set(ByVal value As String)
            mDESCRIPCION = value
        End Set
    End Property

    Private mTOTAL As Decimal
    Public Property TOTAL() As Decimal
        Get
            Return mTOTAL
        End Get
        Set(ByVal value As Decimal)
            mTOTAL = value
        End Set
    End Property

    Private mMONTOCUOTA As Decimal
    Public Property MONTOCUOTA() As Decimal
        Get
            Return mMONTOCUOTA
        End Get
        Set(ByVal value As Decimal)
            mMONTOCUOTA = value
        End Set
    End Property



    Private mCUOTA As Decimal
    Public Property CUOTA() As Decimal
        Get
            Return mCUOTA
        End Get
        Set(ByVal value As Decimal)
            mCUOTA = value
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

    Private mFZAVENTA As String
    Public Property FZAVENTA() As String
        Get
            Return mFZAVENTA
        End Get
        Set(ByVal value As String)
            mFZAVENTA = value
        End Set
    End Property



    Public Overrides Function ToString() As String
        Return DESCRIPCION.ToString
    End Function

    Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
        Return CType(obj, ReporteVentaE).CODIGO.CompareTo(CODIGO)
    End Function
End Class
