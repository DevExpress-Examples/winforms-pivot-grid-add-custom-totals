Imports System.Data
Imports System.Data.OleDb
Imports System.Windows
Imports DevExpress.Xpf.PivotGrid
Imports HowToBindToMDB.NwindDataSetTableAdapters
Imports System

Namespace HowToBindToMDB
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

'INSTANT VB NOTE: The variable salesPersonDataTable was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Private salesPersonDataTable_Conflict As New NwindDataSet.SalesPersonDataTable()
		Private salesPersonDataAdapter As New SalesPersonTableAdapter()

		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = salesPersonDataTable_Conflict
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			salesPersonDataAdapter.Fill(salesPersonDataTable_Conflict)
			Dim filter(14) As Object
			Array.Copy(fieldProductName.GetUniqueValues(), filter, filter.Length)
			fieldProductName.FilterValues.ValuesIncluded = filter
		End Sub
	End Class
End Namespace
