
Public Class Amigo

#Region "atributos"
    Private mid As Integer
    Private mnombre As String
    Private mfechaNascimiento As Date
#End Region


#Region "propiedades"




    Public Property Nombre() As String
        Get
            Return mnombre
        End Get
        Set(ByVal value As String)
            mnombre = value
        End Set
    End Property


    Public Property FechaNascimiento() As Date
        Get
            Return mfechaNascimiento
        End Get
        Set(ByVal value As Date)
            mfechaNascimiento = value
        End Set
    End Property




    Public Property Id() As Integer
        Get
            Return mid
        End Get
        Set(ByVal value As Integer)
            mid = value
        End Set
    End Property



#End Region

#Region "constructores"


    Sub New()
        ' TODO: Complete member initialization 
    End Sub


    Sub New(ByVal pid As Integer, ByVal pnombre As String, ByVal pfechaNascimiento As Date)
        Id = pid
        Nombre = pnombre
        FechaNascimiento = pfechaNascimiento
    End Sub


    Sub New(ByVal pnombre As String, ByVal pfechaNascimiento As Date)
        Nombre = pnombre
        FechaNascimiento = pfechaNascimiento
    End Sub
#End Region

End Class
