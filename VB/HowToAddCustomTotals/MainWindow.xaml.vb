Imports System.Windows
Imports HowToBindToMDB.NwindDataSetTableAdapters

Namespace HowToBindToMDB

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Private salesPersonDataTable As NwindDataSet.SalesPersonDataTable = New NwindDataSet.SalesPersonDataTable()

        Private salesPersonDataAdapter As SalesPersonTableAdapter = New SalesPersonTableAdapter()

        Public Sub New()
            Me.InitializeComponent()
            salesPersonDataAdapter.Fill(salesPersonDataTable)
            Me.pivotGridControl1.DataSource = salesPersonDataTable
        End Sub
    End Class
End Namespace
