using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImpulsDATAbase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void programsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.programsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iMPULSDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iMPULSDataSet1.Programs' table. You can move, or remove it, as needed.
            this.programsTableAdapter.Fill(this.iMPULSDataSet1.Programs);

        }
    }
}
