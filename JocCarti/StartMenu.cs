using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocCarti
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void StartGame_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadGame(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen();
            gameWindow.Show();
            
        }

        private void LoadClasament(object sender, EventArgs e)
        {
            TabClasament clasamentWindow = new TabClasament();
            clasamentWindow.Show();
        }

        private void Gradient(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.LightBlue, Color.LightSeaGreen, 90F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        private void StartP(object sender, PaintEventArgs e)
        {
        }

        private void ClasamentP(object sender, PaintEventArgs e)
        {

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

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
