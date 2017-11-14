using DrawMatrixDLL;
using GitCalc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditForm
{
    public partial class EditMatrix : Form
    {
        private bool IsEnabled { get; set; }
        private List<RectangleGame> list;
        RectangleGame matrix;

        
        Graphics g;

        public EditMatrix()
        {
            InitializeComponent();
            IsEnabled = false;
            list = new List<RectangleGame>();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

             
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            IsEnabled = true;
            
            try
            {
                if (!string.IsNullOrEmpty(txtBox_Width.Text) && !string.IsNullOrEmpty(txtBox_Length.Text))
                {
                    matrix = new RectangleGame();

                    if (int.Parse(txtBox_Length.Text) >= 100 && int.Parse(txtBox_Width.Text) >= 100) //якщо матриця >= (100, 100) -> матриця (100, 100)
                    {
                        matrix.Length = 100;
                        matrix.Width = 100;
                    }
                    else if (int.Parse(txtBox_Length.Text) >= 100) // якщо Length вимір матриці >= 100
                    {
                        matrix.Length = 100;
                        matrix.Width = int.Parse(txtBox_Width.Text);
                    }
                    else if (int.Parse(txtBox_Width.Text) >= 100) //якщо Width вимір матриці >= 100
                    {
                        matrix.Width = 100;
                        matrix.Length = int.Parse(txtBox_Length.Text);
                    }
                    else //якщо все нормас
                    {
                        matrix.Length = int.Parse(txtBox_Length.Text);
                        matrix.Width = int.Parse(txtBox_Width.Text);
                    }

                    txtBox_Length.Text = matrix.Length.ToString();
                    txtBox_Width.Text = matrix.Width.ToString();

                    this.Invalidate(true);
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void txtBox_Width_KeyPress(object sender, KeyPressEventArgs e) // перевірка, чи користувач вводить цифру
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtBox_Length_KeyPress(object sender, KeyPressEventArgs e) // та сама перевірка
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void EditMatrix_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            if (IsEnabled)
            {
                DrawMatrixClass drawMatrixClass = new DrawMatrixClass();
                list = drawMatrixClass.DrawRectangles(g, matrix.Width, matrix.Length);
            }
        }

        private void EditMatrix_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i - 1].Begin.X + (i * 30) <= e.X && list[i - 1].Begin.Y + (i * 30) <= e.Y 
                    && (((list[i - 1].End.X * 4) + 30) >= e.X && ((list[i - 1].End.Y * 4) + 30) >= e.Y))
                {
                    MessageBox.Show(list[i].Begin.X.ToString() + list[i].Begin.Y); 
                }
            }
        }

        private void EditMatrix_Load(object sender, EventArgs e)
        {

        }
    }
}
