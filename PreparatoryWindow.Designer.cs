
namespace Dictionary
{
    partial class PreparatoryWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreparatoryWindow));
            this.successLoad = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityWords = new System.Windows.Forms.Label();
            this.modeTestLabel = new System.Windows.Forms.Label();
            this.modeTest = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // successLoad
            // 
            this.successLoad.AutoSize = true;
            this.successLoad.Location = new System.Drawing.Point(65, 9);
            this.successLoad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.successLoad.Name = "successLoad";
            this.successLoad.Size = new System.Drawing.Size(178, 19);
            this.successLoad.TabIndex = 0;
            this.successLoad.Text = "Файл успешно загружен!";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(13, 41);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(131, 19);
            this.quantityLabel.TabIndex = 1;
            this.quantityLabel.Text = "Количество слов: ";
            // 
            // quantityWords
            // 
            this.quantityWords.AutoSize = true;
            this.quantityWords.Location = new System.Drawing.Point(140, 42);
            this.quantityWords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityWords.Name = "quantityWords";
            this.quantityWords.Size = new System.Drawing.Size(15, 19);
            this.quantityWords.TabIndex = 2;
            this.quantityWords.Text = "-";
            // 
            // modeTestLabel
            // 
            this.modeTestLabel.AutoSize = true;
            this.modeTestLabel.Location = new System.Drawing.Point(13, 83);
            this.modeTestLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modeTestLabel.Name = "modeTestLabel";
            this.modeTestLabel.Size = new System.Drawing.Size(101, 19);
            this.modeTestLabel.TabIndex = 3;
            this.modeTestLabel.Text = "Режим теста: ";
            // 
            // modeTest
            // 
            this.modeTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeTest.FormattingEnabled = true;
            this.modeTest.Items.AddRange(new object[] {
            "en-ru",
            "ru-en"});
            this.modeTest.Location = new System.Drawing.Point(121, 75);
            this.modeTest.Name = "modeTest";
            this.modeTest.Size = new System.Drawing.Size(121, 27);
            this.modeTest.TabIndex = 4;
            this.modeTest.SelectedIndexChanged += new System.EventHandler(this.modeTest_SelectedIndexChanged);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(28, 129);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(97, 25);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelButton.Location = new System.Drawing.Point(167, 129);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 25);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PreparatoryWindow
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 176);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.modeTest);
            this.Controls.Add(this.modeTestLabel);
            this.Controls.Add(this.quantityWords);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.successLoad);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PreparatoryWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Подготовка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label successLoad;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label quantityWords;
        private System.Windows.Forms.Label modeTestLabel;
        private System.Windows.Forms.ComboBox modeTest;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cancelButton;
    }
}