namespace GuessTheWord
{
    partial class Play
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
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBoxShowHint = new System.Windows.Forms.PictureBox();
            this.pictureBoxNewWord = new System.Windows.Forms.PictureBox();
            this.labelSynonyms = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.labelWordToGuess = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewWord)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerName.Location = new System.Drawing.Point(84, 33);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(164, 16);
            this.labelPlayerName.TabIndex = 0;
            this.labelPlayerName.Text = "label1";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Tan;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBack.Location = new System.Drawing.Point(587, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(128, 30);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 78);
            this.panel1.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Wheat;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.labelTimer);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(292, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(137, 78);
            this.panel6.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "SECONDS LEFT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(45, 16);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(46, 24);
            this.labelTimer.TabIndex = 0;
            this.labelTimer.Text = "300";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.Controls.Add(this.labelScore);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(429, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 78);
            this.panel3.TabIndex = 2;
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(224, 34);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(50, 16);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "label3";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "SCORE:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelPlayerName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 78);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLAYER:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonBack);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 477);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(715, 30);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel5.Controls.Add(this.pictureBoxShowHint);
            this.panel5.Controls.Add(this.pictureBoxNewWord);
            this.panel5.Controls.Add(this.labelSynonyms);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.buttonSubmit);
            this.panel5.Controls.Add(this.textBoxAnswer);
            this.panel5.Controls.Add(this.labelWordToGuess);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(715, 399);
            this.panel5.TabIndex = 4;
            // 
            // pictureBoxShowHint
            // 
            this.pictureBoxShowHint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShowHint.Image = global::GuessTheWord.Properties.Resources.lightbulb;
            this.pictureBoxShowHint.Location = new System.Drawing.Point(114, 160);
            this.pictureBoxShowHint.Name = "pictureBoxShowHint";
            this.pictureBoxShowHint.Size = new System.Drawing.Size(54, 38);
            this.pictureBoxShowHint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShowHint.TabIndex = 11;
            this.pictureBoxShowHint.TabStop = false;
            this.pictureBoxShowHint.Click += new System.EventHandler(this.pictureBoxShowHint_Click);
            // 
            // pictureBoxNewWord
            // 
            this.pictureBoxNewWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNewWord.Image = global::GuessTheWord.Properties.Resources.refresh_page_option;
            this.pictureBoxNewWord.Location = new System.Drawing.Point(565, 160);
            this.pictureBoxNewWord.Name = "pictureBoxNewWord";
            this.pictureBoxNewWord.Size = new System.Drawing.Size(42, 38);
            this.pictureBoxNewWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNewWord.TabIndex = 10;
            this.pictureBoxNewWord.TabStop = false;
            this.pictureBoxNewWord.Click += new System.EventHandler(this.pictureBoxNewWord_Click);
            // 
            // labelSynonyms
            // 
            this.labelSynonyms.AutoSize = true;
            this.labelSynonyms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSynonyms.Location = new System.Drawing.Point(266, 226);
            this.labelSynonyms.Name = "labelSynonyms";
            this.labelSynonyms.Size = new System.Drawing.Size(44, 16);
            this.labelSynonyms.TabIndex = 4;
            this.labelSynonyms.Text = "label5";
            this.labelSynonyms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "SYNONYMS:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.White;
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSubmit.FlatAppearance.BorderSize = 2;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(289, 275);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(140, 35);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(181, 160);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(367, 38);
            this.textBoxAnswer.TabIndex = 1;
            this.textBoxAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAnswer_KeyDown);
            // 
            // labelWordToGuess
            // 
            this.labelWordToGuess.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelWordToGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordToGuess.Location = new System.Drawing.Point(15, 39);
            this.labelWordToGuess.Name = "labelWordToGuess";
            this.labelWordToGuess.Size = new System.Drawing.Size(688, 69);
            this.labelWordToGuess.TabIndex = 0;
            this.labelWordToGuess.Text = "_ _ _";
            this.labelWordToGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(715, 507);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(731, 546);
            this.MinimumSize = new System.Drawing.Size(731, 546);
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play";
            this.Load += new System.EventHandler(this.Play_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewWord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label labelWordToGuess;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelSynonyms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxNewWord;
        private System.Windows.Forms.PictureBox pictureBoxShowHint;
    }
}