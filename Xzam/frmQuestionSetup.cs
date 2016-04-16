using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xzam
{
    public partial class frmQuestionSetup : Form
    {
        public frmQuestionSetup()
        {
            InitializeComponent();
        }

        private void btnAddOption_Click(object sender, EventArgs e)
        {
            ListViewItem litem = new ListViewItem(txtCode.Text);
            litem.SubItems.Add(txtText.Text);
            lvwOptions.Items.Add(litem);
        }
    }
}
