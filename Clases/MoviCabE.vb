Public Class MoviCabE

    Private mNroMovi As Decimal
    Public Property Nromovi() As Decimal
        Get
            Return mNroMovi
        End Get
        Set(ByVal value As Decimal)
            mNroMovi = value
        End Set
    End Property

    Private mCDALMACEN As String
    Public Property CDALMACEN() As String
        Get
            Return mCDALMACEN
        End Get
        Set(ByVal value As String)
            mCDALMACEN = value
        End Set
    End Property


    Private mCDTIPOMOV As String
    Public Property CDTIPOMOV() As String
        Get
            Return mCDTIPOMOV
        End Get
        Set(ByVal value As String)
            mCDTIPOMOV = value
        End Set
    End Property


    Private mCDPROVEE As String
    Public Property CDPROVEE() As String
        Get
            Return mCDPROVEE
        End Get
        Set(ByVal value As String)
            mCDPROVEE = value
        End Set
    End Property



    Private mCDTIPODOC As String
    Public Property FrmPlanillaPago_Provee() As String
        Get
            Return mCDTIPODOC
        End Get
        Set(ByVal value As String)
            mCDTIPODOC = value
        End Set
    End Property

    Private mINOUT As Boolean
    Public Property INOUT() As Boolean
        Get
            Return mINOUT
        End Get
        Set(ByVal value As Boolean)
            mINOUT = value
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


    Private mFECDOCUM As Date
    Public Property FECDOCUM() As Date
        Get
            Return mFECDOCUM
        End Get
        Set(ByVal value As Date)
            mFECDOCUM = value
        End Set
    End Property

    Private mFECPROCESO As Date
    Public Property NewProperty() As Date
        Get
            Return mFECPROCESO
        End Get
        Set(ByVal value As Date)
            mFECPROCESO = value
        End Set
    End Property


    Private mESTADO As String
    Public Property ESTADO() As String
        Get
            Return mESTADO
        End Get
        Set(ByVal value As String)
            mESTADO = value
        End Set
    End Property


    Private mCDMONEDA As String
    Public Property CDMONEDA() As String
        Get
            Return mCDMONEDA
        End Get
        Set(ByVal value As String)
            mCDMONEDA = value
        End Set
    End Property


    Private mSUBTOTBAS As Decimal
    Public Property SUBTOTBAS() As Decimal
        Get
            Return mSUBTOTBAS
        End Get
        Set(ByVal value As Decimal)
            mSUBTOTBAS = value
        End Set
    End Property

    Private mSUBTOTEXT As Decimal
    Public Property SUBTOTEXT() As Decimal
        Get
            Return mSUBTOTEXT
        End Get
        Set(ByVal value As Decimal)
            mSUBTOTEXT = value
        End Set
    End Property


    Private mCAMBIO As Decimal
    Public Property CAMBIO() As Decimal
        Get
            Return mCAMBIO
        End Get
        Set(ByVal value As Decimal)
            mCAMBIO = value
        End Set
    End Property


    Private mIGVBAS As Decimal
    Public Property IGVBAS() As Decimal
        Get
            Return mIGVBAS
        End Get
        Set(ByVal value As Decimal)
            mIGVBAS = value
        End Set
    End Property

    Private mIGVEXT As Decimal
    Public Property IGVEXT() As Decimal
        Get
            Return mIGVEXT
        End Get
        Set(ByVal value As Decimal)
            mIGVEXT = value
        End Set
    End Property


    Private mTOTBAS As Decimal
    Public Property TOTBAS() As Decimal
        Get
            Return mTOTBAS
        End Get
        Set(ByVal value As Decimal)
            mTOTBAS = value
        End Set
    End Property


    Private mTOTEXT As Decimal
    Public Property TOTEXT() As Decimal
        Get
            Return mTOTEXT
        End Get
        Set(ByVal value As Decimal)
            mTOTEXT = value
        End Set
    End Property


    Private mPORCENDESC As Decimal
    Public Property PORCENDESC() As Decimal
        Get
            Return mPORCENDESC
        End Get
        Set(ByVal value As Decimal)
            mPORCENDESC = value
        End Set
    End Property

    Private mMONTODESCBAS As Decimal
    Public Property MONTODESCBAS() As Decimal
        Get
            Return mMONTODESCBAS
        End Get
        Set(ByVal value As Decimal)
            mMONTODESCBAS = value
        End Set
    End Property

    Private mMONTODESCEXT As Decimal
    Public Property MONTODESCEXT() As Decimal
        Get
            Return mMONTODESCEXT
        End Get
        Set(ByVal value As Decimal)
            mMONTODESCEXT = value
        End Set
    End Property


    Private mALMATRAN As String
    Public Property ALMATRAN() As String
        Get
            Return mALMATRAN
        End Get
        Set(ByVal value As String)
            mALMATRAN = value
        End Set
    End Property


    Private mUSERID As String
    Public Property USERID() As String
        Get
            Return mUSERID
        End Get
        Set(ByVal value As String)
            mUSERID = value
        End Set
    End Property

    Private mPERIODO As String
    Public Property PERIODO() As String
        Get
            Return mPERIODO
        End Get
        Set(ByVal value As String)
            mPERIODO = value
        End Set
    End Property

    Private mEJERCICIO As String
    Public Property EJERCICIO() As String
        Get
            Return mEJERCICIO
        End Get
        Set(ByVal value As String)
            mEJERCICIO = value
        End Set
    End Property

    Private mDATETRANS As Date
    Public Property DATETRANS() As Date
        Get
            Return mDATETRANS
        End Get
        Set(ByVal value As Date)
            mDATETRANS = value
        End Set
    End Property


    Private mOBS As String
    Public Property OBS() As String
        Get
            Return mOBS
        End Get
        Set(ByVal value As String)
            mOBS = value
        End Set
    End Property

    Private mCRED As Boolean
    Public Property CRED() As Boolean
        Get
            Return mCRED
        End Get
        Set(ByVal value As Boolean)
            mCRED = value
        End Set
    End Property

    Private mtipocred As String
    Public Property tipocred() As String
        Get
            Return mtipocred
        End Get
        Set(ByVal value As String)
            mtipocred = value
        End Set
    End Property

    Private mPTOVTA As String
    Public Property PTOVTA() As String
        Get
            Return mPTOVTA
        End Get
        Set(ByVal value As String)
            mPTOVTA = value
        End Set
    End Property

    Private mFLETE As Decimal
    Public Property FLETE() As Decimal
        Get
            Return mFLETE
        End Get
        Set(ByVal value As Decimal)
            mFLETE = value
        End Set
    End Property

    Private mPERCEPCION As Decimal
    Public Property PERCEPCION() As Decimal
        Get
            Return mPERCEPCION
        End Get
        Set(ByVal value As Decimal)
            mPERCEPCION = value
        End Set
    End Property

    Private mDETRACCION As Decimal
    Public Property DETRACCION() As Decimal
        Get
            Return mDETRACCION
        End Get
        Set(ByVal value As Decimal)
            mDETRACCION = value
        End Set
    End Property


    Private mFECHARECEPC As Date
    Public Property FECHARECEPC() As Date
        Get
            Return mFECHARECEPC
        End Get
        Set(ByVal value As Date)
            mFECHARECEPC = value
        End Set
    End Property


    Private mDSALMACEN As String
    Public Property DSALMACEN() As String
        Get
            Return mDSALMACEN
        End Get
        Set(ByVal value As String)
            mDSALMACEN = value
        End Set
    End Property


    Private mDSTIPOMOV As String
    Public Property DSTIPOMOV() As String
        Get
            Return mDSTIPOMOV
        End Get
        Set(ByVal value As String)
            mDSTIPOMOV = value
        End Set
    End Property


    Private mTabla As String
    Public Property TABLACAB() As String
        Get
            Return mTabla
        End Get
        Set(ByVal value As String)
            mTabla = value
        End Set
    End Property


    Private mTABLADET As String
    Public Property TABLADET() As String
        Get
            Return mTABLADET
        End Get
        Set(ByVal value As String)
            mTABLADET = value
        End Set
    End Property

End Class
