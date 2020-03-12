namespace racingGame
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
            this.t3 = new System.Windows.Forms.PictureBox();
            this.t2 = new System.Windows.Forms.PictureBox();
            this.t1 = new System.Windows.Forms.PictureBox();
            this.score_txt = new System.Windows.Forms.Label();
            this.over_text = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.e3 = new System.Windows.Forms.PictureBox();
            this.e1 = new System.Windows.Forms.PictureBox();
            this.e2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_speed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e2)).BeginInit();
            this.SuspendLayout();
            // 
            // t3
            // 
            this.t3.BackColor = System.Drawing.Color.Green;
            this.t3.Location = new System.Drawing.Point(224, 40);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(21, 83);
            this.t3.TabIndex = 0;
            this.t3.TabStop = false;
            // 
            // t2
            // 
            this.t2.BackColor = System.Drawing.Color.Yellow;
            this.t2.Location = new System.Drawing.Point(224, 264);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(21, 83);
            this.t2.TabIndex = 1;
            this.t2.TabStop = false;
            // 
            // t1
            // 
            this.t1.BackColor = System.Drawing.Color.Red;
            this.t1.Location = new System.Drawing.Point(224, 468);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(21, 83);
            this.t1.TabIndex = 2;
            this.t1.TabStop = false;
            // 
            // score_txt
            // 
            this.score_txt.AutoSize = true;
            this.score_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_txt.Location = new System.Drawing.Point(12, 18);
            this.score_txt.Name = "score_txt";
            this.score_txt.Size = new System.Drawing.Size(49, 16);
            this.score_txt.TabIndex = 3;
            this.score_txt.Text = "Score";
            this.score_txt.Click += new System.EventHandler(this.label1_Click);
            // 
            // over_text
            // 
            this.over_text.AutoSize = true;
            this.over_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over_text.Location = new System.Drawing.Point(174, 302);
            this.over_text.Name = "over_text";
            this.over_text.Size = new System.Drawing.Size(130, 25);
            this.over_text.TabIndex = 4;
            this.over_text.Text = "Game Over";
            this.over_text.Click += new System.EventHandler(this.label2_Click);
            // 
            // player1
            // 
            this.player1.Image = ((System.Drawing.Image)(resources.GetObject("player1.Image")));
            this.player1.Location = new System.Drawing.Point(202, 515);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(53, 78);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1.TabIndex = 5;
            this.player1.TabStop = false;
            // 
            // e3
            // 
            this.e3.Image = ((System.Drawing.Image)(resources.GetObject("e3.Image")));
            this.e3.Location = new System.Drawing.Point(305, 40);
            this.e3.Name = "e3";
            this.e3.Size = new System.Drawing.Size(52, 74);
            this.e3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e3.TabIndex = 6;
            this.e3.TabStop = false;
            // 
            // e1
            // 
            this.e1.Image = ((System.Drawing.Image)(resources.GetObject("e1.Image")));
            this.e1.Location = new System.Drawing.Point(104, 166);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(60, 83);
            this.e1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e1.TabIndex = 8;
            this.e1.TabStop = false;
            // 
            // e2
            // 
            this.e2.Image = ((System.Drawing.Image)(resources.GetObject("e2.Image")));
            this.e2.Location = new System.Drawing.Point(305, 352);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(52, 82);
            this.e2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e2.TabIndex = 7;
            this.e2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Location = new System.Drawing.Point(431, 13);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(35, 13);
            this.lbl_speed.TabIndex = 9;
            this.lbl_speed.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.over_text);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.e3);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.score_txt);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t3);
            this.Name = "Form1";
            this.Text = "Car Racing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.t3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox t3;
        private System.Windows.Forms.PictureBox t2;
        private System.Windows.Forms.PictureBox t1;
        private System.Windows.Forms.Label score_txt;
        private System.Windows.Forms.Label over_text;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox e3;
        private System.Windows.Forms.PictureBox e1;
        private System.Windows.Forms.PictureBox e2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_speed;
    }
}

