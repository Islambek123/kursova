namespace EditForm
{
    partial class EditMatrix
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.txtBox_Width = new System.Windows.Forms.TextBox();
            this.txtBox_Length = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(877, 616);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 0;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(24, 31);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(87, 13);
            this.lbl_Width.TabIndex = 1;
            this.lbl_Width.Text = "Width(max=100):";
            // 
            // lbl_Length
            // 
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Location = new System.Drawing.Point(24, 57);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(95, 13);
            this.lbl_Length.TabIndex = 1;
            this.lbl_Length.Text = "Length(max=100): ";
            // 
            // txtBox_Width
            // 
            this.txtBox_Width.Location = new System.Drawing.Point(125, 24);
            this.txtBox_Width.Name = "txtBox_Width";
            this.txtBox_Width.Size = new System.Drawing.Size(52, 20);
            this.txtBox_Width.TabIndex = 2;
            this.txtBox_Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Width_KeyPress);
            // 
            // txtBox_Length
            // 
            this.txtBox_Length.Location = new System.Drawing.Point(125, 54);
            this.txtBox_Length.Name = "txtBox_Length";
            this.txtBox_Length.Size = new System.Drawing.Size(52, 20);
            this.txtBox_Length.TabIndex = 2;
            this.txtBox_Length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Length_KeyPress);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(77, 80);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(100, 23);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "Create Matrix";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            this.btn_create.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_create_Paint);
            // 
            // EditMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 651);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txtBox_Length);
            this.Controls.Add(this.txtBox_Width);
            this.Controls.Add(this.lbl_Length);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.btn_edit);
            this.Name = "EditMatrix";
            this.Text = "Edit Matrix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.TextBox txtBox_Width;
        private System.Windows.Forms.TextBox txtBox_Length;
        private System.Windows.Forms.Button btn_create;
    }
}

