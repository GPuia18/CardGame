using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace JocCarti
{
    public partial class TabClasament : Form
    {
        private SqlConnection conn;
        public TabClasament()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\ClasamentBazaDeDate.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
        }

        private void TabClasament_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clasamentBazaDeDateDataSet.TabelaClasament' table. You can move, or remove it, as needed.
            this.tabelaClasamentTableAdapter.Fill(this.clasamentBazaDeDateDataSet.TabelaClasament);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_4(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
