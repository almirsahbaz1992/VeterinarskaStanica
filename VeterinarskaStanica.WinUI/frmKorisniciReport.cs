using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinarskaStanica.WinUI
{
    public partial class frmKorisniciReport : Form
    {
        public frmKorisniciReport()
        {
            InitializeComponent();
        }

        private void frmKorisniciReport_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "VeterinarskaStanica.WinUI.KorisniciReport.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
