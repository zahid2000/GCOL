namespace GCOL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlaneLeft2 = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.PlaneLeft1 = new System.Windows.Forms.PictureBox();
            this.PlaneUp = new System.Windows.Forms.PictureBox();
            this.PlaneDown = new System.Windows.Forms.PictureBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.Fire = new System.Windows.Forms.PictureBox();
            this.PlaneDown1 = new System.Windows.Forms.PictureBox();
            this.TurnLeft = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.PlaneRight = new System.Windows.Forms.PictureBox();
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneLeft2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneLeft1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneRight)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(989, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PlaneLeft2
            // 
            this.PlaneLeft2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlaneLeft2.BackgroundImage")));
            this.PlaneLeft2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlaneLeft2.Location = new System.Drawing.Point(277, 173);
            this.PlaneLeft2.Name = "PlaneLeft2";
            this.PlaneLeft2.Size = new System.Drawing.Size(53, 40);
            this.PlaneLeft2.TabIndex = 2;
            this.PlaneLeft2.TabStop = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.OldLace;
            this.Start.Location = new System.Drawing.Point(1051, 24);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(168, 52);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // PlaneLeft1
            // 
            this.PlaneLeft1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlaneLeft1.BackgroundImage")));
            this.PlaneLeft1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlaneLeft1.Location = new System.Drawing.Point(71, 24);
            this.PlaneLeft1.Name = "PlaneLeft1";
            this.PlaneLeft1.Size = new System.Drawing.Size(52, 43);
            this.PlaneLeft1.TabIndex = 5;
            this.PlaneLeft1.TabStop = false;
            // 
            // PlaneUp
            // 
            this.PlaneUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlaneUp.BackgroundImage")));
            this.PlaneUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlaneUp.Location = new System.Drawing.Point(877, 173);
            this.PlaneUp.Name = "PlaneUp";
            this.PlaneUp.Size = new System.Drawing.Size(44, 40);
            this.PlaneUp.TabIndex = 6;
            this.PlaneUp.TabStop = false;
            this.PlaneUp.Visible = false;
            // 
            // PlaneDown
            // 
            this.PlaneDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlaneDown.BackgroundImage")));
            this.PlaneDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlaneDown.Location = new System.Drawing.Point(877, 24);
            this.PlaneDown.Name = "PlaneDown";
            this.PlaneDown.Size = new System.Drawing.Size(43, 43);
            this.PlaneDown.TabIndex = 7;
            this.PlaneDown.TabStop = false;
            this.PlaneDown.Visible = false;
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Fire
            // 
            this.Fire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fire.BackgroundImage")));
            this.Fire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fire.Location = new System.Drawing.Point(877, 116);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(44, 51);
            this.Fire.TabIndex = 8;
            this.Fire.TabStop = false;
            this.Fire.Visible = false;
            // 
            // PlaneDown1
            // 
            this.PlaneDown1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlaneDown1.BackgroundImage")));
            this.PlaneDown1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlaneDown1.Location = new System.Drawing.Point(759, 184);
            this.PlaneDown1.Name = "PlaneDown1";
            this.PlaneDown1.Size = new System.Drawing.Size(43, 43);
            this.PlaneDown1.TabIndex = 9;
            this.PlaneDown1.TabStop = false;
            this.PlaneDown1.Visible = false;
            // 
            // TurnLeft
            // 
            this.TurnLeft.BackColor = System.Drawing.Color.Red;
            this.TurnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnLeft.ForeColor = System.Drawing.Color.OldLace;
            this.TurnLeft.Location = new System.Drawing.Point(997, 116);
            this.TurnLeft.Name = "TurnLeft";
            this.TurnLeft.Size = new System.Drawing.Size(148, 43);
            this.TurnLeft.TabIndex = 10;
            this.TurnLeft.Text = "Turn Right";
            this.TurnLeft.UseVisualStyleBackColor = false;
            this.TurnLeft.Visible = false;
            this.TurnLeft.Click += new System.EventHandler(this.TurnLeft_Click);
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.Color.Red;
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.Color.OldLace;
            this.Continue.Location = new System.Drawing.Point(1151, 116);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(132, 43);
            this.Continue.TabIndex = 11;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Visible = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click_1);
            // 
            // PlaneRight
            // 
            this.PlaneRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlaneRight.BackgroundImage")));
            this.PlaneRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlaneRight.Location = new System.Drawing.Point(877, 173);
            this.PlaneRight.Name = "PlaneRight";
            this.PlaneRight.Size = new System.Drawing.Size(44, 40);
            this.PlaneRight.TabIndex = 12;
            this.PlaneRight.TabStop = false;
            this.PlaneRight.Visible = false;
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1287, 526);
            this.Controls.Add(this.PlaneRight);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.TurnLeft);
            this.Controls.Add(this.PlaneDown1);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.PlaneDown);
            this.Controls.Add(this.PlaneUp);
            this.Controls.Add(this.PlaneLeft1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.PlaneLeft2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneLeft2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneLeft1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PlaneLeft2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox PlaneLeft1;
        private System.Windows.Forms.PictureBox PlaneUp;
        private System.Windows.Forms.PictureBox PlaneDown;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.PictureBox Fire;
        private System.Windows.Forms.PictureBox PlaneDown1;
        private System.Windows.Forms.Button TurnLeft;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.PictureBox PlaneRight;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
    }
}

