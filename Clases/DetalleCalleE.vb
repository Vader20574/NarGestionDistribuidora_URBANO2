Imports System.Collections
Public Class DetalleCalleE
    Private m_Codigo As String
    Private m_Descripcion As String

    Public Property Codigo() As String
        Get
            Return m_Codigo
        End Get
        Set(ByVal Value As String)
            m_Codigo = Value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return m_Descripcion
        End Get
        Set(ByVal Value As String)
            m_Descripcion = Value
        End Set
    End Property
End Class
