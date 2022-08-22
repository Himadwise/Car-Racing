namespace Car_Racing_Project
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.A2 = new System.Windows.Forms.PictureBox();
            this.A1 = new System.Windows.Forms.PictureBox();
            this.roadTruck2 = new System.Windows.Forms.PictureBox();
            this.roadTruck1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.textScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTruck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTruck1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.Player);
            this.panel1.Controls.Add(this.A2);
            this.panel1.Controls.Add(this.A1);
            this.panel1.Controls.Add(this.roadTruck2);
            this.panel1.Controls.Add(this.roadTruck1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 519);
            this.panel1.TabIndex = 0;
            // 
            // explosion
            // 
            this.explosion.Image = global::Car_Racing_Project.Properties.Resources.explosion_removebg_preview;
            this.explosion.Location = new System.Drawing.Point(51, 356);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(100, 50);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion.TabIndex = 6;
            this.explosion.TabStop = false;
            // 
            // award
            // 
            this.award.Image = global::Car_Racing_Project.Properties.Resources.award;
            this.award.Location = new System.Drawing.Point(140, 226);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(169, 65);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 5;
            this.award.TabStop = false;
            // 
            // Player
            // 
            this.Player.Image = global::Car_Racing_Project.Properties.Resources.A2_removebg_preview;
            this.Player.Location = new System.Drawing.Point(198, 390);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(51, 100);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 4;
            this.Player.TabStop = false;
            // 
            // A2
            // 
            this.A2.Image = global::Car_Racing_Project.Properties.Resources.A5_removebg_preview;
            this.A2.Location = new System.Drawing.Point(249, 85);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(65, 124);
            this.A2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A2.TabIndex = 3;
            this.A2.TabStop = false;
            this.A2.Tag = "carRight";
            // 
            // A1
            // 
            this.A1.Image = global::Car_Racing_Project.Properties.Resources.A6_removebg_preview;
            this.A1.Location = new System.Drawing.Point(66, 19);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(51, 100);
            this.A1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A1.TabIndex = 2;
            this.A1.TabStop = false;
            this.A1.Tag = "carLeft";
            // 
            // roadTruck2
            // 
            this.roadTruck2.Image = global::Car_Racing_Project.Properties.Resources.car_road;
            this.roadTruck2.Location = new System.Drawing.Point(0, 0);
            this.roadTruck2.Name = "roadTruck2";
            this.roadTruck2.Size = new System.Drawing.Size(471, 519);
            this.roadTruck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTruck2.TabIndex = 1;
            this.roadTruck2.TabStop = false;
            // 
            // roadTruck1
            // 
            this.roadTruck1.Location = new System.Drawing.Point(0, -519);
            this.roadTruck1.Name = "roadTruck1";
            this.roadTruck1.Size = new System.Drawing.Size(475, 519);
            this.roadTruck1.TabIndex = 0;
            this.roadTruck1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(141, 607);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 38);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.Location = new System.Drawing.Point(159, 544);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(105, 28);
            this.textScore.TabIndex = 2;
            this.textScore.Text = "Score :0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(476, 657);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Racing Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTruck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTruck1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.PictureBox roadTruck1;
        private System.Windows.Forms.PictureBox A1;
        private System.Windows.Forms.PictureBox roadTruck2;
        private System.Windows.Forms.PictureBox A2;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.Timer gameTimer;
    }
}

