namespace PingPong
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
            this.p1 = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.Panel();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.scoretext = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Label();
            this.btext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.White;
            this.p1.Location = new System.Drawing.Point(12, 174);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(10, 100);
            this.p1.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.White;
            this.p2.Location = new System.Drawing.Point(461, 174);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(10, 100);
            this.p2.TabIndex = 1;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(236, 226);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(10, 10);
            this.ball.TabIndex = 2;
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Interval = 50;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.BackColor = System.Drawing.Color.Transparent;
            this.scoretext.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.ForeColor = System.Drawing.Color.White;
            this.scoretext.Location = new System.Drawing.Point(222, 9);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(24, 28);
            this.scoretext.TabIndex = 3;
            this.scoretext.Text = "0";
            // 
            // pause
            // 
            this.pause.AutoSize = true;
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.ForeColor = System.Drawing.Color.White;
            this.pause.Location = new System.Drawing.Point(181, 211);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(111, 35);
            this.pause.TabIndex = 4;
            this.pause.Text = "PAUSED";
            // 
            // btext
            // 
            this.btext.AutoSize = true;
            this.btext.BackColor = System.Drawing.Color.Transparent;
            this.btext.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btext.ForeColor = System.Drawing.Color.White;
            this.btext.Location = new System.Drawing.Point(12, 437);
            this.btext.Name = "btext";
            this.btext.Size = new System.Drawing.Size(361, 15);
            this.btext.TabIndex = 5;
            this.btext.Text = "Made by Dismal, use space to pause - P1: W+S, P2: UP + DOWN\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btext);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel ball;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Label pause;
        private System.Windows.Forms.Label btext;
    }
}

