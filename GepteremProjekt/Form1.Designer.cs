namespace GepteremProjekt
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gtPic = new System.Windows.Forms.PictureBox();
            this.jobbnyil = new System.Windows.Forms.PictureBox();
            this.balnyil = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gtPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobbnyil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balnyil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(336, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 450);
            this.panel1.TabIndex = 0;
            // 
            // gtPic
            // 
            this.gtPic.BackgroundImage = global::GepteremProjekt.Properties.Resources.Neumann;
            this.gtPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gtPic.Location = new System.Drawing.Point(74, 12);
            this.gtPic.Name = "gtPic";
            this.gtPic.Size = new System.Drawing.Size(129, 154);
            this.gtPic.TabIndex = 4;
            this.gtPic.TabStop = false;
            // 
            // jobbnyil
            // 
            this.jobbnyil.BackgroundImage = global::GepteremProjekt.Properties.Resources.jobb;
            this.jobbnyil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.jobbnyil.Location = new System.Drawing.Point(209, 12);
            this.jobbnyil.Name = "jobbnyil";
            this.jobbnyil.Size = new System.Drawing.Size(58, 154);
            this.jobbnyil.TabIndex = 5;
            this.jobbnyil.TabStop = false;
            this.jobbnyil.Click += new System.EventHandler(this.jobbnyil_Click);
            // 
            // balnyil
            // 
            this.balnyil.BackgroundImage = global::GepteremProjekt.Properties.Resources.bal;
            this.balnyil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.balnyil.Location = new System.Drawing.Point(12, 12);
            this.balnyil.Name = "balnyil";
            this.balnyil.Size = new System.Drawing.Size(56, 154);
            this.balnyil.TabIndex = 6;
            this.balnyil.TabStop = false;
            this.balnyil.Click += new System.EventHandler(this.balnyil_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::GepteremProjekt.Properties.Resources.ment;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(74, 172);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(129, 50);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.balnyil);
            this.Controls.Add(this.jobbnyil);
            this.Controls.Add(this.gtPic);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gtPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobbnyil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balnyil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox gtPic;
        private System.Windows.Forms.PictureBox jobbnyil;
        private System.Windows.Forms.PictureBox balnyil;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

