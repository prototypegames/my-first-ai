namespace my_first_ai
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
            this.highBlockButton = new System.Windows.Forms.Button();
            this.jumpButton = new System.Windows.Forms.Button();
            this.highPunchButton = new System.Windows.Forms.Button();
            this.sweepButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.playerPointLabel = new System.Windows.Forms.Label();
            this.aiPointLabel = new System.Windows.Forms.Label();
            this.playerAttackLabel = new System.Windows.Forms.Label();
            this.aiAttackLabel = new System.Windows.Forms.Label();
            this.playerResultLabel = new System.Windows.Forms.Label();
            this.aiResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // highBlockButton
            // 
            this.highBlockButton.Location = new System.Drawing.Point(281, 175);
            this.highBlockButton.Name = "highBlockButton";
            this.highBlockButton.Size = new System.Drawing.Size(75, 23);
            this.highBlockButton.TabIndex = 0;
            this.highBlockButton.Text = "Block";
            this.highBlockButton.UseVisualStyleBackColor = true;
            this.highBlockButton.Click += new System.EventHandler(this.highBlockButton_Click);
            // 
            // jumpButton
            // 
            this.jumpButton.Location = new System.Drawing.Point(281, 204);
            this.jumpButton.Name = "jumpButton";
            this.jumpButton.Size = new System.Drawing.Size(75, 23);
            this.jumpButton.TabIndex = 1;
            this.jumpButton.Text = "Jump";
            this.jumpButton.UseVisualStyleBackColor = true;
            this.jumpButton.Click += new System.EventHandler(this.jumpButton_Click);
            // 
            // highPunchButton
            // 
            this.highPunchButton.Location = new System.Drawing.Point(362, 175);
            this.highPunchButton.Name = "highPunchButton";
            this.highPunchButton.Size = new System.Drawing.Size(75, 23);
            this.highPunchButton.TabIndex = 2;
            this.highPunchButton.Text = "Punch";
            this.highPunchButton.UseVisualStyleBackColor = true;
            this.highPunchButton.Click += new System.EventHandler(this.highPunchButton_Click);
            // 
            // sweepButton
            // 
            this.sweepButton.Location = new System.Drawing.Point(362, 204);
            this.sweepButton.Name = "sweepButton";
            this.sweepButton.Size = new System.Drawing.Size(75, 23);
            this.sweepButton.TabIndex = 3;
            this.sweepButton.Text = "Sweep";
            this.sweepButton.UseVisualStyleBackColor = true;
            this.sweepButton.Click += new System.EventHandler(this.sweepButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 233);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 109);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Block beats Punch \r\nPunch beats Jump\r\nJump beats Sweep\r\nSweep beats Punch\r\nSweep " +
    "beats Block\r\n\r\nEverything else is draw\r\n\r\n\r\n";
            // 
            // playerPointLabel
            // 
            this.playerPointLabel.AutoSize = true;
            this.playerPointLabel.Location = new System.Drawing.Point(88, 249);
            this.playerPointLabel.Name = "playerPointLabel";
            this.playerPointLabel.Size = new System.Drawing.Size(39, 13);
            this.playerPointLabel.TabIndex = 5;
            this.playerPointLabel.Text = "Points:";
            // 
            // aiPointLabel
            // 
            this.aiPointLabel.AutoSize = true;
            this.aiPointLabel.Location = new System.Drawing.Point(491, 249);
            this.aiPointLabel.Name = "aiPointLabel";
            this.aiPointLabel.Size = new System.Drawing.Size(39, 13);
            this.aiPointLabel.TabIndex = 6;
            this.aiPointLabel.Text = "Points:";
            // 
            // playerAttackLabel
            // 
            this.playerAttackLabel.AutoSize = true;
            this.playerAttackLabel.Location = new System.Drawing.Point(88, 144);
            this.playerAttackLabel.Name = "playerAttackLabel";
            this.playerAttackLabel.Size = new System.Drawing.Size(41, 13);
            this.playerAttackLabel.TabIndex = 7;
            this.playerAttackLabel.Text = "Attack:";
            // 
            // aiAttackLabel
            // 
            this.aiAttackLabel.AutoSize = true;
            this.aiAttackLabel.Location = new System.Drawing.Point(491, 144);
            this.aiAttackLabel.Name = "aiAttackLabel";
            this.aiAttackLabel.Size = new System.Drawing.Size(41, 13);
            this.aiAttackLabel.TabIndex = 8;
            this.aiAttackLabel.Text = "Attack:";
            // 
            // playerResultLabel
            // 
            this.playerResultLabel.AutoSize = true;
            this.playerResultLabel.Location = new System.Drawing.Point(167, 248);
            this.playerResultLabel.Name = "playerResultLabel";
            this.playerResultLabel.Size = new System.Drawing.Size(35, 13);
            this.playerResultLabel.TabIndex = 9;
            this.playerResultLabel.Text = "result:";
            // 
            // aiResultLabel
            // 
            this.aiResultLabel.AutoSize = true;
            this.aiResultLabel.Location = new System.Drawing.Point(566, 248);
            this.aiResultLabel.Name = "aiResultLabel";
            this.aiResultLabel.Size = new System.Drawing.Size(35, 13);
            this.aiResultLabel.TabIndex = 10;
            this.aiResultLabel.Text = "result:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "You";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "AI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "My First AI made By Hunter and Legend";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 370);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aiResultLabel);
            this.Controls.Add(this.playerResultLabel);
            this.Controls.Add(this.aiAttackLabel);
            this.Controls.Add(this.playerAttackLabel);
            this.Controls.Add(this.aiPointLabel);
            this.Controls.Add(this.playerPointLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sweepButton);
            this.Controls.Add(this.highPunchButton);
            this.Controls.Add(this.jumpButton);
            this.Controls.Add(this.highBlockButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button highBlockButton;
        private System.Windows.Forms.Button jumpButton;
        private System.Windows.Forms.Button highPunchButton;
        private System.Windows.Forms.Button sweepButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label playerPointLabel;
        private System.Windows.Forms.Label aiPointLabel;
        private System.Windows.Forms.Label playerAttackLabel;
        private System.Windows.Forms.Label aiAttackLabel;
        private System.Windows.Forms.Label playerResultLabel;
        private System.Windows.Forms.Label aiResultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

