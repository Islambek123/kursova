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
            g = e.Graphics;

            if(LoadMatrix)
            {
                for (int i = 1; i <= obj.Length; i++)
                {
                    for (int j = 1; j <= obj.Width; j++)
                    {
                        RectangleGame item = new RectangleGame
                        {
                            Begin = new Point(10 * i, 10 * j),
                            End = new Point(10 * i + 20, 10 * j + 20)
                        };

                        InitializeMatrix(item, i, j);
                        matrix.Add(item);
                        
                        switch (item.Type)
                        {
                            case 0:
                                    Fill(Color.Gray, g, i, j); // 0 - земля
                                break;
                            case 1:
                                    Fill(Color.Blue, g, i, j); // 1 - місця для будівлі веж
                                break;
                            case 2:
                                Fill(Color.Green, g, i, j); // 2 - точка спавна
                                break;
                            case 3:
                                Fill(Color.Red, g, i, j); // 3 - фініш
                                break;
                            case 4:
                                Fill(Color.Brown, g, i, j); // 4 - клітина ходьби юніта
                                break;
                            default:
                                break;
                        }

                    }
                }
            }
        }
        private void Fill(Color color, Graphics g, int i, int j)
        {
            Brush b = new SolidBrush(color); // ініцалізація кісті
            g.DrawRectangle(new Pen(new SolidBrush(color)),
                            new Rectangle(new Point(40 * i, 40 * j), new Size(30, 30))); // малювання "кордонів" елемента матриці
   
            g.FillRectangle(b, 40 * i, 40 * j, 30, 30); // заповнення кольорем елеметна матриці
        }

        private void InitializeMatrix(RectangleGame rectangleGame, int i, int j)
        {
            if (i % 2 == 0 && j % 3 == 0)
            {
                rectangleGame.Type = 1;
            }
            else if (i == 0 && j == 0)
            {
                rectangleGame.Type = 2;
            }
            else if (i == obj.Width && j == obj.Length)
            {
                rectangleGame.Type = 3;
            }
            else if (i == j)
            {
                rectangleGame.Type = 4;
            }
            else
            {
                rectangleGame.Type = 0;
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
