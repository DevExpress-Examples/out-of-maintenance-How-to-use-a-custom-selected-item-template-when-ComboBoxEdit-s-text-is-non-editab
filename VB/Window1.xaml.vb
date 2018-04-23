Imports System.Collections.Generic
Imports System.Windows

Namespace TextEdit_EditNonEditableTemplate
    Partial Public Class Window1
        Inherits Window

        Public Sub New()
            InitializeComponent()
            Dim data As New List(Of Employee)()
            data.Add(New Employee With { _
                .Name = "Steven", _
                .CardColor = "Red" _
            })
            data.Add(New Employee With { _
                .Name = "Mary", _
                .CardColor = "Green" _
            })
            data.Add(New Employee With { _
                .Name = "John", _
                .CardColor = "Blue" _
            })
            data.Add(New Employee With { _
                .Name = "Claudia", _
                .CardColor = "Red" _
            })
            gridControl1.ItemsSource = data
        End Sub
    End Class
    Public Class Employee
        Public Property Name() As String
        Public Property CardColor() As String
    End Class
End Namespace