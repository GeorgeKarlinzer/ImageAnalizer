namespace ImageAnalyzer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.reload = new System.Windows.Forms.Button();
            this.errorText = new System.Windows.Forms.Label();
            this.tag = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.customisesPos = new System.Windows.Forms.Label();
            this.customisePanel = new System.Windows.Forms.Panel();
            this.newItemPanel = new System.Windows.Forms.Panel();
            this.needToScroll = new System.Windows.Forms.Label();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.moves = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.customisePanel.SuspendLayout();
            this.newItemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(13, 13);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(152, 23);
            this.reload.TabIndex = 1;
            this.reload.Text = "Reload Image";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Location = new System.Drawing.Point(182, 22);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(29, 13);
            this.errorText.TabIndex = 2;
            this.errorText.Text = "Error";
            // 
            // tag
            // 
            this.tag.AutoSize = true;
            this.tag.Location = new System.Drawing.Point(531, 22);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(35, 13);
            this.tag.TabIndex = 3;
            this.tag.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PNG|*.png";
            // 
            // pictureBox
            // 
            this.pictureBox.ImageLocation = "";
            this.pictureBox.Location = new System.Drawing.Point(56, 58);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(960, 540);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            // 
            // customisesPos
            // 
            this.customisesPos.AutoSize = true;
            this.customisesPos.Location = new System.Drawing.Point(12, 12);
            this.customisesPos.Name = "customisesPos";
            this.customisesPos.Size = new System.Drawing.Size(47, 13);
            this.customisesPos.TabIndex = 4;
            this.customisesPos.Text = "Position:";
            // 
            // customisePanel
            // 
            this.customisePanel.Controls.Add(this.moves);
            this.customisePanel.Controls.Add(this.comboBox1);
            this.customisePanel.Controls.Add(this.label1);
            this.customisePanel.Controls.Add(this.customisesPos);
            this.customisePanel.Location = new System.Drawing.Point(1066, 46);
            this.customisePanel.Name = "customisePanel";
            this.customisePanel.Size = new System.Drawing.Size(151, 99);
            this.customisePanel.TabIndex = 5;
            // 
            // newItemPanel
            // 
            this.newItemPanel.Controls.Add(this.needToScroll);
            this.newItemPanel.Controls.Add(this.sectionLabel);
            this.newItemPanel.Location = new System.Drawing.Point(1066, 172);
            this.newItemPanel.Name = "newItemPanel";
            this.newItemPanel.Size = new System.Drawing.Size(151, 99);
            this.newItemPanel.TabIndex = 6;
            // 
            // needToScroll
            // 
            this.needToScroll.AutoSize = true;
            this.needToScroll.Location = new System.Drawing.Point(15, 36);
            this.needToScroll.Name = "needToScroll";
            this.needToScroll.Size = new System.Drawing.Size(35, 13);
            this.needToScroll.TabIndex = 1;
            this.needToScroll.Text = "label2";
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Location = new System.Drawing.Point(12, 12);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(77, 13);
            this.sectionLabel.TabIndex = 0;
            this.sectionLabel.Text = "Active section:";
            // 
            // moves
            // 
            this.moves.AutoSize = true;
            this.moves.Location = new System.Drawing.Point(18, 67);
            this.moves.Name = "moves";
            this.moves.Size = new System.Drawing.Size(0, 13);
            this.moves.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox1.Location = new System.Drawing.Point(80, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(39, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "To position:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 658);
            this.Controls.Add(this.newItemPanel);
            this.Controls.Add(this.customisePanel);
            this.Controls.Add(this.tag);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.customisePanel.ResumeLayout(false);
            this.customisePanel.PerformLayout();
            this.newItemPanel.ResumeLayout(false);
            this.newItemPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.Label tag;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label customisesPos;
        private System.Windows.Forms.Panel customisePanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label moves;
        private System.Windows.Forms.Panel newItemPanel;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Label needToScroll;
    }
}

