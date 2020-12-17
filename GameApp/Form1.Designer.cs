namespace GameApp
{
    partial class form1
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
            this.labelScore = new System.Windows.Forms.Label();
            this.maca = new System.Windows.Forms.PictureBox();
            this.pikachu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.maca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pikachu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(23, 21);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(59, 64);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "0";
            // 
            // maca
            // 
            this.maca.Image = global::GameApp.Properties.Resources.maca;
            this.maca.Location = new System.Drawing.Point(473, 188);
            this.maca.Name = "maca";
            this.maca.Size = new System.Drawing.Size(136, 136);
            this.maca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maca.TabIndex = 2;
            this.maca.TabStop = false;
            // 
            // pikachu
            // 
            this.pikachu.Image = global::GameApp.Properties.Resources.pikachu;
            this.pikachu.Location = new System.Drawing.Point(22, 321);
            this.pikachu.Name = "pikachu";
            this.pikachu.Size = new System.Drawing.Size(204, 192);
            this.pikachu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pikachu.TabIndex = 0;
            this.pikachu.TabStop = false;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 534);
            this.Controls.Add(this.pikachu);
            this.Controls.Add(this.maca);
            this.Controls.Add(this.labelScore);
            this.Name = "form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.maca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pikachu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pikachu;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox maca;
    }
}

