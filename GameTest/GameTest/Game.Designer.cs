namespace GameTest
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.panel1 = new System.Windows.Forms.Panel();
            this.winner = new System.Windows.Forms.PictureBox();
            this.Explosion = new System.Windows.Forms.PictureBox();
            this.Word1 = new System.Windows.Forms.PictureBox();
            this.Word2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.Road2 = new System.Windows.Forms.PictureBox();
            this.Road1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.HealthPanel = new System.Windows.Forms.Panel();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerWord = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Word1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Word2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road1)).BeginInit();
            this.HealthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.winner);
            this.panel1.Controls.Add(this.Explosion);
            this.panel1.Controls.Add(this.Word1);
            this.panel1.Controls.Add(this.Word2);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.Road2);
            this.panel1.Controls.Add(this.Road1);
            this.panel1.Location = new System.Drawing.Point(2, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 436);
            this.panel1.TabIndex = 0;
            // 
            // winner
            // 
            this.winner.Image = ((System.Drawing.Image)(resources.GetObject("winner.Image")));
            this.winner.Location = new System.Drawing.Point(112, 145);
            this.winner.Margin = new System.Windows.Forms.Padding(2);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(234, 125);
            this.winner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.winner.TabIndex = 6;
            this.winner.TabStop = false;
            // 
            // Explosion
            // 
            this.Explosion.Image = global::GameTest.Properties.Resources.explosion;
            this.Explosion.Location = new System.Drawing.Point(36, 264);
            this.Explosion.Margin = new System.Windows.Forms.Padding(2);
            this.Explosion.Name = "Explosion";
            this.Explosion.Size = new System.Drawing.Size(64, 64);
            this.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Explosion.TabIndex = 5;
            this.Explosion.TabStop = false;
            // 
            // Word1
            // 
            this.Word1.Image = ((System.Drawing.Image)(resources.GetObject("Word1.Image")));
            this.Word1.Location = new System.Drawing.Point(112, 24);
            this.Word1.Margin = new System.Windows.Forms.Padding(2);
            this.Word1.Name = "Word1";
            this.Word1.Size = new System.Drawing.Size(49, 43);
            this.Word1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Word1.TabIndex = 4;
            this.Word1.TabStop = false;
            this.Word1.Tag = "wordLeft";
            // 
            // Word2
            // 
            this.Word2.Image = ((System.Drawing.Image)(resources.GetObject("Word2.Image")));
            this.Word2.Location = new System.Drawing.Point(347, 24);
            this.Word2.Margin = new System.Windows.Forms.Padding(2);
            this.Word2.Name = "Word2";
            this.Word2.Size = new System.Drawing.Size(49, 43);
            this.Word2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Word2.TabIndex = 3;
            this.Word2.TabStop = false;
            this.Word2.Tag = "wordRight";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.player.Image = global::GameTest.Properties.Resources.carPink;
            this.player.Location = new System.Drawing.Point(212, 332);
            this.player.Margin = new System.Windows.Forms.Padding(2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // Road2
            // 
            this.Road2.Image = global::GameTest.Properties.Resources.roadTrack;
            this.Road2.Location = new System.Drawing.Point(0, 0);
            this.Road2.Margin = new System.Windows.Forms.Padding(2);
            this.Road2.Name = "Road2";
            this.Road2.Size = new System.Drawing.Size(433, 436);
            this.Road2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Road2.TabIndex = 1;
            this.Road2.TabStop = false;
            // 
            // Road1
            // 
            this.Road1.Image = global::GameTest.Properties.Resources.roadTrack;
            this.Road1.Location = new System.Drawing.Point(0, -520);
            this.Road1.Margin = new System.Windows.Forms.Padding(2);
            this.Road1.Name = "Road1";
            this.Road1.Size = new System.Drawing.Size(433, 436);
            this.Road1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Road1.TabIndex = 0;
            this.Road1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(62, 448);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(70, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.RestartGame);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(157, 448);
            this.txtScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(120, 24);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // HealthPanel
            // 
            this.HealthPanel.Controls.Add(this.heart3);
            this.HealthPanel.Controls.Add(this.heart2);
            this.HealthPanel.Controls.Add(this.heart1);
            this.HealthPanel.Controls.Add(this.label2);
            this.HealthPanel.Location = new System.Drawing.Point(280, 448);
            this.HealthPanel.Margin = new System.Windows.Forms.Padding(2);
            this.HealthPanel.Name = "HealthPanel";
            this.HealthPanel.Size = new System.Drawing.Size(154, 28);
            this.HealthPanel.TabIndex = 3;
            // 
            // heart3
            // 
            this.heart3.Image = ((System.Drawing.Image)(resources.GetObject("heart3.Image")));
            this.heart3.Location = new System.Drawing.Point(128, 2);
            this.heart3.Margin = new System.Windows.Forms.Padding(2);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(26, 26);
            this.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart3.TabIndex = 9;
            this.heart3.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.Image = ((System.Drawing.Image)(resources.GetObject("heart2.Image")));
            this.heart2.Location = new System.Drawing.Point(98, 2);
            this.heart2.Margin = new System.Windows.Forms.Padding(2);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(26, 26);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 8;
            this.heart2.TabStop = false;
            // 
            // heart1
            // 
            this.heart1.Image = ((System.Drawing.Image)(resources.GetObject("heart1.Image")));
            this.heart1.Location = new System.Drawing.Point(68, 2);
            this.heart1.Margin = new System.Windows.Forms.Padding(2);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(26, 26);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 7;
            this.heart1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Health";
            // 
            // timerWord
            // 
            this.timerWord.Interval = 5;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(437, 483);
            this.Controls.Add(this.HealthPanel);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.Text = "Word Racer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Word1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Word2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road1)).EndInit();
            this.HealthPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox Road1;
        private System.Windows.Forms.PictureBox winner;
        private System.Windows.Forms.PictureBox Explosion;
        private System.Windows.Forms.PictureBox Word2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Road2;
        private System.Windows.Forms.PictureBox Word1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel HealthPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.Timer timerWord;
    }
}