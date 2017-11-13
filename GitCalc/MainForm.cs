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
        public MainForm()
        {
            LoadMatrix = false;
            InitializeComponent();
        }

        private void btn_loadMatrix_Click(object sender, EventArgs e)
        {
            LoadMatrix = true;
            this.Invalidate(true);
            //Matrix l = Matrix.Instance;
            //int[,] matrix = new int[l.Length, l.Width];


            //for (int i = 0; i < l.Length; i++)
            //{
            //    for (int j = 0; j < l.Width; j++)
            //    {
            //        matrix[i, j] = 1;
            //    }
            //}
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            Graphics g = e.Graphics;
            if(LoadMatrix)
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        RectangleGame item = new RectangleGame
                        {
                            Begin = new Point(10 * i, 10 * j),
                            End = new Point(10 * i+20, 10 * j+20)
                        };
                        matrix.Add(item);
                        g.DrawRectangle(new Pen(new SolidBrush(Color.Red)),
                            new Rectangle(new Point(10 * i, 10*j), new Size(20, 20)));
                    }
                }
            }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            foreach(var item in matrix)
            {
                //sender
            }
        }
    }

    public class Matrix
    {

        private static Matrix instance;

        private Matrix() { }

        public static Matrix Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Matrix();
                    instance.GetMatrixSize();
                }

                return instance;
            }
        }
        public int Width { get; set; }
        public int Length { get; set; }

        public void GetMatrixSize()
        {
            Width = 10;
            Length = 10;
        }

    }
}
