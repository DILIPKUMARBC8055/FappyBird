﻿namespace fappybird_game
{
    partial class fappygame
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
            this.pipeup = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipedown = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeup
            // 
            this.pipeup.Image = global::fappybird_game.Properties.Resources.pipedown;
            this.pipeup.Location = new System.Drawing.Point(588, -17);
            this.pipeup.Name = "pipeup";
            this.pipeup.Size = new System.Drawing.Size(105, 171);
            this.pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeup.TabIndex = 0;
            this.pipeup.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::fappybird_game.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(206, 152);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(88, 76);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            this.bird.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pipedown
            // 
            this.pipedown.Image = global::fappybird_game.Properties.Resources.pipe;
            this.pipedown.Location = new System.Drawing.Point(370, 302);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(105, 191);
            this.pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown.TabIndex = 2;
            this.pipedown.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::fappybird_game.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(1, 427);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(811, 94);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Yellow;
            this.score.Font = new System.Drawing.Font("Segoe UI Historic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.score.Location = new System.Drawing.Point(425, 457);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(130, 45);
            this.score.TabIndex = 4;
            this.score.Text = "Score:0";
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // fappygame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.score);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipedown);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pipeup);
            this.Name = "fappygame";
            this.Text = "fappygame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.birdIsUp);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.birdIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pipeup;
        private PictureBox bird;
        private PictureBox pipedown;
        private PictureBox ground;
        private Label score;
        private System.Windows.Forms.Timer gametimer;
    }
}