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
    public partial class RPBanXe : Form
    {
        public RPBanXe()
        {
            InitializeComponent();
        }

        private void RPBanXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RPXE.RPBanXe' table. You can move, or remove it, as needed.
            this.RPBanXeTableAdapter.Fill(this.RPXE.RPBanXe);

            this.reportViewer1.RefreshReport();
        }
    }
}
