namespace CharacterCreator
{
    partial class Form2
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
            this.hpBox = new System.Windows.Forms.TextBox();
            this.hpGrowthBox = new System.Windows.Forms.TextBox();
            this.maxHpBox = new System.Windows.Forms.TextBox();
            this.SaveStat_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.maxStrBox = new System.Windows.Forms.TextBox();
            this.strGrowthBox = new System.Windows.Forms.TextBox();
            this.strBox = new System.Windows.Forms.TextBox();
            this.maxMagBox = new System.Windows.Forms.TextBox();
            this.magGrowthBox = new System.Windows.Forms.TextBox();
            this.magBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // hpBox
            // 
            this.hpBox.Location = new System.Drawing.Point(107, 43);
            this.hpBox.Name = "hpBox";
            this.hpBox.Size = new System.Drawing.Size(46, 20);
            this.hpBox.TabIndex = 0;
            this.hpBox.TextChanged += new System.EventHandler(this.hpBox_TextChanged);
            // 
            // hpGrowthBox
            // 
            this.hpGrowthBox.Location = new System.Drawing.Point(159, 43);
            this.hpGrowthBox.Name = "hpGrowthBox";
            this.hpGrowthBox.Size = new System.Drawing.Size(46, 20);
            this.hpGrowthBox.TabIndex = 1;
            // 
            // maxHpBox
            // 
            this.maxHpBox.Location = new System.Drawing.Point(213, 43);
            this.maxHpBox.Name = "maxHpBox";
            this.maxHpBox.Size = new System.Drawing.Size(46, 20);
            this.maxHpBox.TabIndex = 2;
            // 
            // SaveStat_button
            // 
            this.SaveStat_button.Location = new System.Drawing.Point(28, 162);
            this.SaveStat_button.Name = "SaveStat_button";
            this.SaveStat_button.Size = new System.Drawing.Size(100, 50);
            this.SaveStat_button.TabIndex = 3;
            this.SaveStat_button.Text = "refresh";
            this.SaveStat_button.UseVisualStyleBackColor = true;
            this.SaveStat_button.Click += new System.EventHandler(this.SaveStat_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maxStrBox
            // 
            this.maxStrBox.Location = new System.Drawing.Point(213, 69);
            this.maxStrBox.Name = "maxStrBox";
            this.maxStrBox.Size = new System.Drawing.Size(46, 20);
            this.maxStrBox.TabIndex = 7;
            // 
            // strGrowthBox
            // 
            this.strGrowthBox.Location = new System.Drawing.Point(159, 69);
            this.strGrowthBox.Name = "strGrowthBox";
            this.strGrowthBox.Size = new System.Drawing.Size(46, 20);
            this.strGrowthBox.TabIndex = 6;
            // 
            // strBox
            // 
            this.strBox.Location = new System.Drawing.Point(107, 69);
            this.strBox.Name = "strBox";
            this.strBox.Size = new System.Drawing.Size(46, 20);
            this.strBox.TabIndex = 5;
            // 
            // maxMagBox
            // 
            this.maxMagBox.Location = new System.Drawing.Point(213, 95);
            this.maxMagBox.Name = "maxMagBox";
            this.maxMagBox.Size = new System.Drawing.Size(46, 20);
            this.maxMagBox.TabIndex = 10;
            // 
            // magGrowthBox
            // 
            this.magGrowthBox.Location = new System.Drawing.Point(159, 95);
            this.magGrowthBox.Name = "magGrowthBox";
            this.magGrowthBox.Size = new System.Drawing.Size(46, 20);
            this.magGrowthBox.TabIndex = 9;
            // 
            // magBox
            // 
            this.magBox.Location = new System.Drawing.Point(107, 95);
            this.magBox.Name = "magBox";
            this.magBox.Size = new System.Drawing.Size(46, 20);
            this.magBox.TabIndex = 8;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(28, 348);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(45, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(79, 348);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(46, 23);
            this.nextButton.TabIndex = 14;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 247);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 95);
            this.listBox1.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 488);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.maxMagBox);
            this.Controls.Add(this.magGrowthBox);
            this.Controls.Add(this.magBox);
            this.Controls.Add(this.maxStrBox);
            this.Controls.Add(this.strGrowthBox);
            this.Controls.Add(this.strBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveStat_button);
            this.Controls.Add(this.maxHpBox);
            this.Controls.Add(this.hpGrowthBox);
            this.Controls.Add(this.hpBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hpBox;
        private System.Windows.Forms.TextBox hpGrowthBox;
        private System.Windows.Forms.TextBox maxHpBox;
        private Character currentCharacter;
        private System.Windows.Forms.Button SaveStat_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox maxStrBox;
        private System.Windows.Forms.TextBox strGrowthBox;
        private System.Windows.Forms.TextBox strBox;
        private System.Windows.Forms.TextBox maxMagBox;
        private System.Windows.Forms.TextBox magGrowthBox;
        private System.Windows.Forms.TextBox magBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}