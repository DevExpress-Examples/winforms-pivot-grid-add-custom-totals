using System.Data;
using System.Data.OleDb;
using System.Windows;
using DevExpress.Xpf.PivotGrid;
using HowToBindToMDB.NwindDataSetTableAdapters;
using System;

namespace HowToBindToMDB {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        NwindDataSet.SalesPersonDataTable salesPersonDataTable = new NwindDataSet.SalesPersonDataTable();
        SalesPersonTableAdapter salesPersonDataAdapter = new SalesPersonTableAdapter();

        public MainWindow() {
            InitializeComponent();
            salesPersonDataAdapter.Fill(salesPersonDataTable);
            pivotGridControl1.DataSource = salesPersonDataTable;
        }

    }
}
