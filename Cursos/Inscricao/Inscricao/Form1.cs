using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscricao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inscricaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inscricaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inscriçaoDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inscriçaoDataSet.Inscricao' table. You can move, or remove it, as needed.
            this.inscricaoTableAdapter.Fill(this.inscriçaoDataSet.Inscricao);

        }
    }
}
