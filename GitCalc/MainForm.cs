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
        private RectangleGame obj;
        Graphics g;

        public MainForm()
        {
            LoadMatrix = false;
            InitializeComponent();
            matrix = new List<RectangleGame>();
            obj = new RectangleGame();
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
                drawMatrixClass.DrawRectangles(g);
            }
        }
        

        

        private void MainForm_Click(object sender, EventArgs e)
        {
            foreach(var item in matrix)
            {
                
            }
        }
    }

    //public class Matrix : RectangleGame
    //{

    //    private static Matrix instance;

    //    private Matrix() { }

    //    public static Matrix Instance
    //    {
    //        get
    //        {
    //            if (instance == null)
    //            {
    //                instance = new Matrix();
    //                instance.GetMatrixSize();
    //            }

    //            return instance;
    //        }
    //    }
    //    public int Width { get; set; }
    //    public int Length { get; set; }

    //    public void GetMatrixSize()
    //    {
    //        Width = 10;
    //        Length = 10;

    //        for (int i = 0; i < Length; i++)
    //        {
    //            for (int j = 0; j < Width; j++)
    //            {
    //                if (instance.Width % 2 == 0)
    //                {
                        
    //                }
    //            }
    //        }
    //    }

    //}
}
