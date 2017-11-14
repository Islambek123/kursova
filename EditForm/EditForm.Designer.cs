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
            this.pBoxStart = new System.Windows.Forms.PictureBox();
            this.pBoxFinish = new System.Windows.Forms.PictureBox();
            this.pBoxTower = new System.Windows.Forms.PictureBox();
            this.pBoxEnemyRoad = new System.Windows.Forms.PictureBox();
            this.pBoxTowerPlace = new System.Windows.Forms.PictureBox();
            this.lbl_road = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEnemyRoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTowerPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(877, 616);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 4;
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
            this.txtBox_Width.TabIndex = 0;
            this.txtBox_Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Width_KeyPress);
            // 
            // txtBox_Length
            // 
            this.txtBox_Length.Location = new System.Drawing.Point(125, 54);
            this.txtBox_Length.Name = "txtBox_Length";
            this.txtBox_Length.Size = new System.Drawing.Size(52, 20);
            this.txtBox_Length.TabIndex = 1;
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
            // 
            // pBoxStart
            // 
            this.pBoxStart.Location = new System.Drawing.Point(265, 24);
            this.pBoxStart.Name = "pBoxStart";
            this.pBoxStart.Size = new System.Drawing.Size(52, 20);
            this.pBoxStart.TabIndex = 5;
            this.pBoxStart.TabStop = false;
            // 
            // pBoxFinish
            // 
            this.pBoxFinish.Location = new System.Drawing.Point(323, 24);
            this.pBoxFinish.Name = "pBoxFinish";
            this.pBoxFinish.Size = new System.Drawing.Size(52, 20);
            this.pBoxFinish.TabIndex = 5;
            this.pBoxFinish.TabStop = false;
            // 
            // pBoxTower
            // 
            this.pBoxTower.Location = new System.Drawing.Point(381, 24);
            this.pBoxTower.Name = "pBoxTower";
            this.pBoxTower.Size = new System.Drawing.Size(52, 20);
            this.pBoxTower.TabIndex = 5;
            this.pBoxTower.TabStop = false;
            // 
            // pBoxEnemyRoad
            // 
            this.pBoxEnemyRoad.Image = global::EditForm.Properties.Resources.images;
            this.pBoxEnemyRoad.Location = new System.Drawing.Point(439, 24);
            this.pBoxEnemyRoad.Name = "pBoxEnemyRoad";
            this.pBoxEnemyRoad.Size = new System.Drawing.Size(30, 30);
            this.pBoxEnemyRoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxEnemyRoad.TabIndex = 5;
            this.pBoxEnemyRoad.TabStop = false;
            // 
            // pBoxTowerPlace
            // 
            this.pBoxTowerPlace.Location = new System.Drawing.Point(497, 24);
            this.pBoxTowerPlace.Name = "pBoxTowerPlace";
            this.pBoxTowerPlace.Size = new System.Drawing.Size(52, 20);
            this.pBoxTowerPlace.TabIndex = 5;
            this.pBoxTowerPlace.TabStop = false;
            // 
            // lbl_road
            // 
            this.lbl_road.AutoSize = true;
            this.lbl_road.Location = new System.Drawing.Point(436, 9);
            this.lbl_road.Name = "lbl_road";
            this.lbl_road.Size = new System.Drawing.Size(33, 13);
            this.lbl_road.TabIndex = 6;
            this.lbl_road.Text = "Road";
            // 
            // EditMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 651);
            this.Controls.Add(this.lbl_road);
            this.Controls.Add(this.pBoxFinish);
            this.Controls.Add(this.pBoxTowerPlace);
            this.Controls.Add(this.pBoxEnemyRoad);
            this.Controls.Add(this.pBoxTower);
            this.Controls.Add(this.pBoxStart);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txtBox_Length);
            this.Controls.Add(this.txtBox_Width);
            this.Controls.Add(this.lbl_Length);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.btn_edit);
            this.Name = "EditMatrix";
            this.Text = "Edit Matrix";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EditMatrix_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEnemyRoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTowerPlace)).EndInit();
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
        private System.Windows.Forms.PictureBox pBoxStart;
        private System.Windows.Forms.PictureBox pBoxFinish;
        private System.Windows.Forms.PictureBox pBoxTower;
        private System.Windows.Forms.PictureBox pBoxEnemyRoad;
        private System.Windows.Forms.PictureBox pBoxTowerPlace;
        private System.Windows.Forms.Label lbl_road;
    }
}

