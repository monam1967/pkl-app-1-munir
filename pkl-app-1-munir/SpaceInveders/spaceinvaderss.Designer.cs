
namespace pkl_app_1_munir.SpaceInveders
{
    partial class spaceinvaderss
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
            this.EnemyTimer = new System.Windows.Forms.Timer(this.components);
            this.ActorTimer = new System.Windows.Forms.Timer(this.components);
            this.PeluruActorTimer = new System.Windows.Forms.Timer(this.components);
            this.PeluruEnemyTembakTimer = new System.Windows.Forms.Timer(this.components);
            this.PeluruEnemyTimer = new System.Windows.Forms.Timer(this.components);
            this.PeluruEnemy = new System.Windows.Forms.PictureBox();
            this.Board = new System.Windows.Forms.PictureBox();
            this.ExplosionPic = new System.Windows.Forms.PictureBox();
            this.PeluruPic = new System.Windows.Forms.PictureBox();
            this.ActorPic = new System.Windows.Forms.PictureBox();
            this.Enemy3Pic = new System.Windows.Forms.PictureBox();
            this.Enemy2Pic = new System.Windows.Forms.PictureBox();
            this.Enemy1Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PeluruEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplosionPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeluruPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // EnemyTimer
            // 
            this.EnemyTimer.Enabled = true;
            this.EnemyTimer.Interval = 500;
            this.EnemyTimer.Tick += new System.EventHandler(this.EnemyTimer_Tick);
            // 
            // ActorTimer
            // 
            this.ActorTimer.Enabled = true;
            this.ActorTimer.Interval = 50;
            this.ActorTimer.Tick += new System.EventHandler(this.ActorTimer_Tick);
            // 
            // PeluruActorTimer
            // 
            this.PeluruActorTimer.Enabled = true;
            this.PeluruActorTimer.Interval = 1;
            this.PeluruActorTimer.Tick += new System.EventHandler(this.PeluruActorTimer_Tick);
            // 
            // PeluruEnemyTembakTimer
            // 
            this.PeluruEnemyTembakTimer.Enabled = true;
            this.PeluruEnemyTembakTimer.Interval = 4000;
            this.PeluruEnemyTembakTimer.Tick += new System.EventHandler(this.PeluruEnemyTembakTimer_Tick);
            // 
            // PeluruEnemyTimer
            // 
            this.PeluruEnemyTimer.Enabled = true;
            this.PeluruEnemyTimer.Interval = 150;
            this.PeluruEnemyTimer.Tick += new System.EventHandler(this.PeluruEnemyTimer_Tick);
            // 
            // PeluruEnemy
            // 
            this.PeluruEnemy.Image = global::pkl_app_1_munir.Properties.Resources.photo1687330867;
            this.PeluruEnemy.Location = new System.Drawing.Point(309, 454);
            this.PeluruEnemy.Name = "PeluruEnemy";
            this.PeluruEnemy.Size = new System.Drawing.Size(18, 34);
            this.PeluruEnemy.TabIndex = 7;
            this.PeluruEnemy.TabStop = false;
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.Color.DarkGreen;
            this.Board.Location = new System.Drawing.Point(12, 12);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(845, 423);
            this.Board.TabIndex = 0;
            this.Board.TabStop = false;
            this.Board.Paint += new System.Windows.Forms.PaintEventHandler(this.Board_Paint);
            // 
            // ExplosionPic
            // 
            this.ExplosionPic.Image = global::pkl_app_1_munir.Properties.Resources.Explosion48;
            this.ExplosionPic.Location = new System.Drawing.Point(255, 453);
            this.ExplosionPic.Name = "ExplosionPic";
            this.ExplosionPic.Size = new System.Drawing.Size(48, 47);
            this.ExplosionPic.TabIndex = 6;
            this.ExplosionPic.TabStop = false;
            // 
            // PeluruPic
            // 
            this.PeluruPic.Image = global::pkl_app_1_munir.Properties.Resources.Bullet1;
            this.PeluruPic.Location = new System.Drawing.Point(231, 454);
            this.PeluruPic.Name = "PeluruPic";
            this.PeluruPic.Size = new System.Drawing.Size(18, 34);
            this.PeluruPic.TabIndex = 5;
            this.PeluruPic.TabStop = false;
            // 
            // ActorPic
            // 
            this.ActorPic.Image = global::pkl_app_1_munir.Properties.Resources.PlayerBlue;
            this.ActorPic.Location = new System.Drawing.Point(163, 454);
            this.ActorPic.Name = "ActorPic";
            this.ActorPic.Size = new System.Drawing.Size(62, 34);
            this.ActorPic.TabIndex = 4;
            this.ActorPic.TabStop = false;
            // 
            // Enemy3Pic
            // 
            this.Enemy3Pic.Image = global::pkl_app_1_munir.Properties.Resources.Enemy3Yellow;
            this.Enemy3Pic.Location = new System.Drawing.Point(112, 454);
            this.Enemy3Pic.Name = "Enemy3Pic";
            this.Enemy3Pic.Size = new System.Drawing.Size(45, 34);
            this.Enemy3Pic.TabIndex = 3;
            this.Enemy3Pic.TabStop = false;
            // 
            // Enemy2Pic
            // 
            this.Enemy2Pic.Image = global::pkl_app_1_munir.Properties.Resources.Enemy2Green;
            this.Enemy2Pic.Location = new System.Drawing.Point(62, 454);
            this.Enemy2Pic.Name = "Enemy2Pic";
            this.Enemy2Pic.Size = new System.Drawing.Size(44, 34);
            this.Enemy2Pic.TabIndex = 2;
            this.Enemy2Pic.TabStop = false;
            // 
            // Enemy1Pic
            // 
            this.Enemy1Pic.Image = global::pkl_app_1_munir.Properties.Resources.Enemy1Red;
            this.Enemy1Pic.Location = new System.Drawing.Point(12, 454);
            this.Enemy1Pic.Name = "Enemy1Pic";
            this.Enemy1Pic.Size = new System.Drawing.Size(44, 34);
            this.Enemy1Pic.TabIndex = 1;
            this.Enemy1Pic.TabStop = false;
            // 
            // spaceinvaderss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 508);
            this.Controls.Add(this.PeluruEnemy);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.ExplosionPic);
            this.Controls.Add(this.PeluruPic);
            this.Controls.Add(this.ActorPic);
            this.Controls.Add(this.Enemy3Pic);
            this.Controls.Add(this.Enemy2Pic);
            this.Controls.Add(this.Enemy1Pic);
            this.Name = "spaceinvaderss";
            this.Text = "spaceinvaders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceInvadersForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpaceInvadersForm_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SpaceInvadersForm_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PeluruEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplosionPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeluruPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Board;
        private System.Windows.Forms.PictureBox Enemy1Pic;
        private System.Windows.Forms.PictureBox Enemy2Pic;
        private System.Windows.Forms.PictureBox Enemy3Pic;
        private System.Windows.Forms.PictureBox ActorPic;
        private System.Windows.Forms.PictureBox PeluruPic;
        private System.Windows.Forms.PictureBox ExplosionPic;
        private System.Windows.Forms.Timer EnemyTimer;
        private System.Windows.Forms.Timer ActorTimer;
        private System.Windows.Forms.Timer PeluruActorTimer;
        private System.Windows.Forms.PictureBox PeluruEnemy;
        private System.Windows.Forms.Timer PeluruEnemyTembakTimer;
        private System.Windows.Forms.Timer PeluruEnemyTimer;
    }
}