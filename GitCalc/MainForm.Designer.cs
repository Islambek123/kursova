﻿namespace GitCalc
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_loadMatrix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_loadMatrix
            // 
            this.btn_loadMatrix.Location = new System.Drawing.Point(661, 574);
            this.btn_loadMatrix.Name = "btn_loadMatrix";
            this.btn_loadMatrix.Size = new System.Drawing.Size(75, 23);
            this.btn_loadMatrix.TabIndex = 0;
            this.btn_loadMatrix.Text = "Load Matrix";
            this.btn_loadMatrix.UseVisualStyleBackColor = true;
            this.btn_loadMatrix.Click += new System.EventHandler(this.btn_loadMatrix_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 609);
            this.Controls.Add(this.btn_loadMatrix);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_loadMatrix;
    }
}

