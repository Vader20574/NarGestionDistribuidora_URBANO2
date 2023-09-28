Public Class TipoDocE

    Private mCodigo As String
    Public Property CODIGO() As String
        Get
            Return mCodigo
        End Get
        Set(ByVal value As String)
            mCodigo = value
        End Set
    End Property


    Private mTIPODOCUMENTO As String
    Public Property TIPODOCUMENTO() As String
        Get
            Return mTIPODOCUMENTO
        End Get
        Set(ByVal value As String)
            mTIPODOCUMENTO = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return TIPODOCUMENTO.ToString()
    End Function
    Sub New(ByVal codigo As String, ByVal documento As String)
        Me.CODIGO = codigo
        Me.TIPODOCUMENTO = documento
    End Sub
    Sub New()

    End Sub
End Class
