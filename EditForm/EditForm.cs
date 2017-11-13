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
        Matrix matrix;
        bool isEnabled;


        public EditMatrix()
        {
            InitializeComponent();
            isEnabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (isEnabled)
            {
                isEnabled = true;
                this.Invalidate(true);
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {   
            try
            {
                if (!string.IsNullOrEmpty(txtBox_Width.Text) && !string.IsNullOrEmpty(txtBox_Length.Text))
                {
                    matrix = new Matrix();

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

                    txtBox_Length.Enabled = false;
                    txtBox_Width.Enabled = false;
                    btn_create.Enabled = false;

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

        private void btn_create_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
