using DrawMatrixDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitCalc
{
    public partial class MainForm : Form
    {
        public bool LoadMatrix { get; set; }
        private List<RectangleGame> matrix;
        Graphics g;

        public MainForm()
        {
            LoadMatrix = false;
            InitializeComponent();
            matrix = new List<RectangleGame>();
        }

        private void btn_loadMatrix_Click(object sender, EventArgs e)
        {
            LoadMatrix = true;
            this.Invalidate(true);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            g = e.Graphics;

            if(LoadMatrix)
            {
                DrawMatrixClass drawMatrixClass = new DrawMatrixClass();
                matrix = drawMatrixClass.DrawRectangles(g, 10, 10);
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.X >= 60 && e.Y <=80)
            {
                MessageBox.Show("lol");
            }
            foreach (var item in matrix)
            {

            }
        }
    }

    
}
