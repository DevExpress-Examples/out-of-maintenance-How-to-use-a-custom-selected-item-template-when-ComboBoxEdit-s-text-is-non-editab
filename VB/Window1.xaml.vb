Imports System.Collections.ObjectModel
Imports System.Windows

Namespace TextEdit_EditNonEditableTemplate

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class ViewModel

        Public Property Data As ObservableCollection(Of Employee)

        Public Sub New()
            Data = New ObservableCollection(Of Employee)()
            Data.Add(New Employee With {.Name = "Steven", .CardColor = "Red"})
            Data.Add(New Employee With {.Name = "Mary", .CardColor = "Green"})
            Data.Add(New Employee With {.Name = "John", .CardColor = "Blue"})
            Data.Add(New Employee With {.Name = "Claudia", .CardColor = "Red"})
        End Sub
    End Class

    Public Class Employee

        Public Property Name As String

        Public Property CardColor As String
    End Class
End Namespace
