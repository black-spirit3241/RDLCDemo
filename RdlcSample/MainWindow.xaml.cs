using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RdlcSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _reportviewer.LocalReport.DataSources.Clear();
            _reportviewer.LocalReport.ReportPath = @"..\\..\\Reports\\CustomerReport.rdlc";

     
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id", typeof(int)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Email", typeof(string)));
            dt.Columns.Add(new DataColumn("Address", typeof(string)));
            dt.Columns.Add(new DataColumn("Phone", typeof(string)));

            DataRow dr = dt.NewRow();
            dr["Id"] = 1;
            dr["Name"] = "Galaxy";
            dr["Email"] = "gg@blfe.com";
            dr["Address"] = "ygn";
            dr["Phone"] = "8459348484";
            dt.Rows.Add(dr);

            DataRow dr1 = dt.NewRow();
            dr1["Id"] = 1;
            dr1["Name"] = "Galaxy";
            dr1["Email"] = "gg@blfe.com";
            dr1["Address"] = "ygn";
            dr1["Phone"] = "8459348484";
            dt.Rows.Add(dr1);


            ReportDataSource reportDataSource = new ReportDataSource("DataSet",dt);
            //reportDataSource.Name = "Customer";
            //reportDataSource.Value = dt;

            _reportviewer.LocalReport.DataSources.Add(reportDataSource);
            _reportviewer.LocalReport.ReportEmbeddedResource = "CustomerReport.rdlc";
            _reportviewer.RefreshReport();

            
        }
    }
}
    

