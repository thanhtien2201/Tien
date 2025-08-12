using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLXM
{
    public partial class frmRPPNH : Form
    {
        public frmRPPNH()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSPhieuNhap.Phieu_Nhap_Hang' table. You can move, or remove it, as needed.
            this.Phieu_Nhap_HangTableAdapter.Fill(this.DSPhieuNhap.Phieu_Nhap_Hang);

            this.reportViewer1.RefreshReport();
        }
    }
}
