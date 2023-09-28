Public Class TransProductTodo

    Private mCORREL As String
    Public Property CORREL() As String
        Get
            Return mCORREL
        End Get
        Set(ByVal value As String)
            mCORREL = value
        End Set
    End Property

    Private mCODARTICULO As String
    Public Property CODARTICULO() As String
        Get
            Return mCODARTICULO
        End Get
        Set(ByVal value As String)
            mCODARTICULO = value
        End Set
    End Property


    Private mNOMBARTICULO As String
    Public Property NOMBARTICULO() As String
        Get
            Return mNOMBARTICULO
        End Get
        Set(ByVal value As String)
            mNOMBARTICULO = value
        End Set
    End Property



    Private mPRESENTACION As String
    Public Property PRESENTACION() As String
        Get
            Return mPRESENTACION
        End Get
        Set(ByVal value As String)
            mPRESENTACION = value
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


    Private mCANTIDAD As Decimal
    Public Property CANTIDAD() As Decimal
        Get
            Return mCANTIDAD
        End Get
        Set(ByVal value As Decimal)
            mCANTIDAD = value
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




    Private mVENDEDOR As String
    Public Property VENDEDOR() As String
        Get
            Return mVENDEDOR
        End Get
        Set(ByVal value As String)
            mVENDEDOR = value
        End Set
    End Property

    Private mCODVENDEDOR As String
    Public Property CODVENDEDOR() As String
        Get
            Return mCODVENDEDOR
        End Get
        Set(ByVal value As String)
            mCODVENDEDOR = value
        End Set
    End Property




End Class
