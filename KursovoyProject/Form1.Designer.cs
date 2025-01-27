namespace KursovoyProject
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
            components = new System.ComponentModel.Container();
            numericUpDownBet = new NumericUpDown();
            lblBet = new Label();
            btnHit = new Button();
            btnStand = new Button();
            lblScore = new Label();
            lblResult = new Label();
            BtnStartGame = new Button();
            lblDealerScore = new Label();
            btnRules = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownBet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownBet
            // 
            numericUpDownBet.BackColor = Color.LightGray;
            numericUpDownBet.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            numericUpDownBet.Location = new Point(43, 199);
            numericUpDownBet.Name = "numericUpDownBet";
            numericUpDownBet.Size = new Size(115, 27);
            numericUpDownBet.TabIndex = 2;
            numericUpDownBet.Click += numericUpDownBet_ValueChanged;
            // 
            // lblBet
            // 
            lblBet.AutoSize = true;
            lblBet.BackColor = Color.RosyBrown;
            lblBet.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBet.ForeColor = SystemColors.ButtonHighlight;
            lblBet.Location = new Point(379, 137);
            lblBet.Name = "lblBet";
            lblBet.Size = new Size(20, 21);
            lblBet.TabIndex = 3;
            lblBet.Tag = "lblBet";
            lblBet.Text = "0";
            // 
            // btnHit
            // 
            btnHit.BackColor = Color.FromArgb(139, 122, 167);
            btnHit.FlatStyle = FlatStyle.Popup;
            btnHit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHit.ForeColor = Color.White;
            btnHit.Location = new Point(255, 338);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(104, 42);
            btnHit.TabIndex = 4;
            btnHit.Text = "ЕЩЁ";
            btnHit.UseVisualStyleBackColor = false;
            btnHit.Click += btnHit_Click;
            // 
            // btnStand
            // 
            btnStand.BackColor = Color.FromArgb(139, 122, 167);
            btnStand.FlatStyle = FlatStyle.Popup;
            btnStand.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnStand.ForeColor = Color.White;
            btnStand.Location = new Point(495, 338);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(105, 42);
            btnStand.TabIndex = 5;
            btnStand.Text = "СТОП";
            btnStand.UseVisualStyleBackColor = false;
            btnStand.Click += btnStand_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.RosyBrown;
            lblScore.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblScore.ForeColor = SystemColors.ControlLightLight;
            lblScore.Location = new Point(231, 199);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(20, 21);
            lblScore.TabIndex = 6;
            lblScore.Tag = "lblScore";
            lblScore.Text = "0";
            lblScore.Click += lblScore_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Transparent;
            lblResult.ForeColor = SystemColors.ControlLightLight;
            lblResult.Location = new Point(423, 413);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(13, 15);
            lblResult.TabIndex = 7;
            lblResult.Tag = "lblResult";
            lblResult.Text = "0";
            // 
            // BtnStartGame
            // 
            BtnStartGame.BackColor = Color.FromArgb(139, 122, 167);
            BtnStartGame.FlatStyle = FlatStyle.Popup;
            BtnStartGame.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            BtnStartGame.ForeColor = Color.White;
            BtnStartGame.Location = new Point(374, 338);
            BtnStartGame.Name = "BtnStartGame";
            BtnStartGame.Size = new Size(105, 42);
            BtnStartGame.TabIndex = 8;
            BtnStartGame.Text = "ИГРАТЬ";
            BtnStartGame.UseVisualStyleBackColor = false;
            BtnStartGame.Click += btnStartGame_Click;
            // 
            // lblDealerScore
            // 
            lblDealerScore.AutoSize = true;
            lblDealerScore.BackColor = Color.RosyBrown;
            lblDealerScore.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblDealerScore.ForeColor = SystemColors.ButtonHighlight;
            lblDealerScore.Location = new Point(231, 259);
            lblDealerScore.Name = "lblDealerScore";
            lblDealerScore.Size = new Size(20, 21);
            lblDealerScore.TabIndex = 9;
            lblDealerScore.Text = "0";
            // 
            // btnRules
            // 
            btnRules.BackColor = Color.FromArgb(139, 122, 167);
            btnRules.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnRules.ForeColor = Color.White;
            btnRules.Location = new Point(12, 12);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(86, 28);
            btnRules.TabIndex = 10;
            btnRules.Text = "ПРАВИЛА";
            btnRules.UseVisualStyleBackColor = false;
            btnRules.Click += btnRules_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(139, 122, 167);
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(702, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 33);
            btnExit.TabIndex = 11;
            btnExit.Text = "ВЫХОД";
            btnExit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(59, 59, 61);
            pictureBox1.Location = new Point(180, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 220);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(196, 168);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 13;
            label1.Text = "ВАША СТАВКА И ОЧКИ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.MintCream;
            label2.Location = new Point(379, 112);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 14;
            label2.Text = "СТАВКА";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.MintCream;
            label3.Location = new Point(208, 233);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 15;
            label3.Text = "ОЧКИ ДИЛЛЕРА";
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 59, 61);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnRules);
            Controls.Add(lblDealerScore);
            Controls.Add(BtnStartGame);
            Controls.Add(lblResult);
            Controls.Add(lblScore);
            Controls.Add(btnStand);
            Controls.Add(btnHit);
            Controls.Add(lblBet);
            Controls.Add(numericUpDownBet);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownBet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownBet;
        private Label lblBet;
        private Button btnHit;
        private Button btnStand;
        private Label lblScore;
        private Label lblResult;
        private Button BtnStartGame;
        private Label lblDealerScore;
        private Button btnRules;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
