namespace Flappy_Bird_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::Flappy_Bird_WF.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(148, 202);
            this.flappyBird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(74, 43);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Flappy_Bird_WF.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(318, -12);
            this.pipeTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(88, 184);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::Flappy_Bird_WF.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(472, 308);
            this.pipeBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(89, 174);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird_WF.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(1, 466);
            this.ground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(837, 106);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Yellow;
            this.scoreText.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(250, 512);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(111, 29);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            this.scoreText.Click += new System.EventHandler(this.scoreText_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(838, 571);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.flappyBird);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox flappyBird;
        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}