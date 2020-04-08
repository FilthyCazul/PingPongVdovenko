namespace PingPongVdovenko
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
            this.background = new System.Windows.Forms.Panel();
            this.GamePanel = new System.Windows.Forms.PictureBox();
            this.gameBall = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Controls.Add(this.gameBall);
            this.background.Controls.Add(this.GamePanel);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(800, 450);
            this.background.TabIndex = 0;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Red;
            this.GamePanel.Location = new System.Drawing.Point(207, 373);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(300, 32);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.TabStop = false;
            // 
            // gameBall
            // 
            this.gameBall.BackColor = System.Drawing.Color.Blue;
            this.gameBall.Location = new System.Drawing.Point(207, 184);
            this.gameBall.Name = "gameBall";
            this.gameBall.Size = new System.Drawing.Size(50, 50);
            this.gameBall.TabIndex = 1;
            this.gameBall.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";

            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox gameBall;
        private System.Windows.Forms.PictureBox GamePanel;
        private System.Windows.Forms.Timer timer;
    }
}

