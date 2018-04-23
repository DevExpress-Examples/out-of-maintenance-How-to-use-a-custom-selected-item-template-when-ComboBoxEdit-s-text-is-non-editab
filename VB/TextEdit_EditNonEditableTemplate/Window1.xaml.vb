Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows

Namespace TextEdit_EditNonEditableTemplate
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub gridControl1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim data As New List(Of Employee)()
			data.Add(New Employee With {.Name = "Steven", .CardColor = "Red"})
			data.Add(New Employee With {.Name = "Mary", .CardColor = "Green"})
			data.Add(New Employee With {.Name = "John", .CardColor = "Blue"})
			data.Add(New Employee With {.Name = "Claudia", .CardColor = "Red"})

			gridControl1.DataSource = data
		End Sub
	End Class
	Public Class Employee
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateCardColor As String
		Public Property CardColor() As String
			Get
				Return privateCardColor
			End Get
			Set(ByVal value As String)
				privateCardColor = value
			End Set
		End Property
	End Class
End Namespace
