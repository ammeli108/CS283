﻿namespace WindowsFormsApp1
{
    partial class Form2
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
            this.MyFoodPocketGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MyFoodPocketGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MyFoodPocketGrid
            // 
            this.MyFoodPocketGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyFoodPocketGrid.Location = new System.Drawing.Point(0, -1);
            this.MyFoodPocketGrid.Name = "MyFoodPocketGrid";
            this.MyFoodPocketGrid.RowTemplate.Height = 24;
            this.MyFoodPocketGrid.Size = new System.Drawing.Size(717, 375);
            this.MyFoodPocketGrid.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 374);
            this.Controls.Add(this.MyFoodPocketGrid);
            this.Name = "Form2";
            this.Text = "你的口袋有這麼深";
            ((System.ComponentModel.ISupportInitialize)(this.MyFoodPocketGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MyFoodPocketGrid;
    }
}