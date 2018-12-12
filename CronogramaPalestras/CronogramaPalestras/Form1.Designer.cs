namespace CronogramaPalestras
{
    partial class FormCronograma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTrilhaUm = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTrilhaDois = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTrilhaUm);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(428, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trilha 1";
            // 
            // txtTrilhaUm
            // 
            this.txtTrilhaUm.Location = new System.Drawing.Point(8, 23);
            this.txtTrilhaUm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTrilhaUm.Multiline = true;
            this.txtTrilhaUm.Name = "txtTrilhaUm";
            this.txtTrilhaUm.ReadOnly = true;
            this.txtTrilhaUm.Size = new System.Drawing.Size(411, 235);
            this.txtTrilhaUm.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTrilhaDois);
            this.groupBox2.Location = new System.Drawing.Point(452, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(428, 279);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trilha 2";
            // 
            // txtTrilhaDois
            // 
            this.txtTrilhaDois.Location = new System.Drawing.Point(8, 23);
            this.txtTrilhaDois.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTrilhaDois.Multiline = true;
            this.txtTrilhaDois.Name = "txtTrilhaDois";
            this.txtTrilhaDois.ReadOnly = true;
            this.txtTrilhaDois.Size = new System.Drawing.Size(411, 235);
            this.txtTrilhaDois.TabIndex = 0;
            // 
            // FormCronograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 308);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCronograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronograma das palestras";
            this.Load += new System.EventHandler(this.FormCronograma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtTrilhaUm;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtTrilhaDois;
	}
}

