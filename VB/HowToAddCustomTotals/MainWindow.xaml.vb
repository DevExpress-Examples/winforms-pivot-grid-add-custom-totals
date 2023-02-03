Imports System.Windows
Imports HowToBindToMDB.NwindDataSetTableAdapters
Imports System

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
            Me.pivotGridControl1.DataSource = salesPersonDataTable
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            salesPersonDataAdapter.Fill(salesPersonDataTable)
            Dim filter As Object() = New Object(14) {}
            Array.Copy(Me.fieldProductName.GetUniqueValues(), filter, filter.Length)
            Me.fieldProductName.FilterValues.ValuesIncluded = filter
        End Sub
    End Class
End Namespace
