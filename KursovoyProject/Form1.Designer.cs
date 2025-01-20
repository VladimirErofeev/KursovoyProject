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
            numericUpDownBet = new NumericUpDown();
            lblBet = new Label();
            btnHit = new Button();
            btnStand = new Button();
            lblScore = new Label();
            lblResult = new Label();
            BtnStartGame = new Button();
            lblDealerScore = new Label();
            btnRules = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBet).BeginInit();
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
            lblBet.BackColor = Color.Transparent;
            lblBet.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBet.ForeColor = SystemColors.ButtonHighlight;
            lblBet.Location = new Point(475, 112);
            lblBet.Name = "lblBet";
            lblBet.Size = new Size(20, 21);
            lblBet.TabIndex = 3;
            lblBet.Tag = "lblBet";
            lblBet.Text = "0";
            // 
            // btnHit
            // 
            btnHit.BackColor = Color.Lime;
            btnHit.FlatStyle = FlatStyle.Popup;
            btnHit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHit.ForeColor = SystemColors.ControlDarkDark;
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
            btnStand.BackColor = Color.Crimson;
            btnStand.FlatStyle = FlatStyle.Popup;
            btnStand.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
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
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblScore.ForeColor = SystemColors.ControlLightLight;
            lblScore.Location = new Point(313, 164);
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
            BtnStartGame.BackColor = Color.DarkGreen;
            BtnStartGame.FlatStyle = FlatStyle.Popup;
            BtnStartGame.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            BtnStartGame.ForeColor = SystemColors.ButtonHighlight;
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
            lblDealerScore.BackColor = Color.Transparent;
            lblDealerScore.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblDealerScore.ForeColor = SystemColors.ButtonHighlight;
            lblDealerScore.Location = new Point(636, 164);
            lblDealerScore.Name = "lblDealerScore";
            lblDealerScore.Size = new Size(20, 21);
            lblDealerScore.TabIndex = 9;
            lblDealerScore.Text = "0";
            // 
            // btnRules
            // 
            btnRules.BackColor = Color.Transparent;
            btnRules.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            btnRules.Location = new Point(690, 31);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(86, 28);
            btnRules.TabIndex = 10;
            btnRules.Text = "ПРАВИЛА";
            btnRules.UseVisualStyleBackColor = false;
            btnRules.Click += btnRules_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            BackgroundImage = Properties.Resources.orig;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRules);
            Controls.Add(lblDealerScore);
            Controls.Add(BtnStartGame);
            Controls.Add(lblResult);
            Controls.Add(lblScore);
            Controls.Add(btnStand);
            Controls.Add(btnHit);
            Controls.Add(lblBet);
            Controls.Add(numericUpDownBet);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownBet).EndInit();
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
    }
}
