Imports Microsoft.VisualBasic
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
		Private salesPersonDataTable As New NwindDataSet.SalesPersonDataTable()
		Private salesPersonDataAdapter As New SalesPersonTableAdapter()

		Public Sub New()
			InitializeComponent()
			salesPersonDataAdapter.Fill(salesPersonDataTable)
			pivotGridControl1.DataSource = salesPersonDataTable
		End Sub

	End Class
End Namespace
