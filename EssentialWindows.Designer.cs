
namespace Dictionary
{
    partial class EssentialWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EssentialWindows));
            this.wordNumLabel = new System.Windows.Forms.Label();
            this.wordNum = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.currentWord = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.accept = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.skip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordNumLabel
            // 
            this.wordNumLabel.AutoSize = true;
            this.wordNumLabel.Location = new System.Drawing.Point(31, 22);
            this.wordNumLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.wordNumLabel.Name = "wordNumLabel";
            this.wordNumLabel.Size = new System.Drawing.Size(28, 21);
            this.wordNumLabel.TabIndex = 0;
            this.wordNumLabel.Text = "№";
            // 
            // wordNum
            // 
            this.wordNum.AutoSize = true;
            this.wordNum.Location = new System.Drawing.Point(69, 22);
            this.wordNum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.wordNum.Name = "wordNum";
            this.wordNum.Size = new System.Drawing.Size(16, 21);
            this.wordNum.TabIndex = 1;
            this.wordNum.Text = "-";
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(31, 56);
            this.wordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(65, 21);
            this.wordLabel.TabIndex = 2;
            this.wordLabel.Text = "Слово:";
            // 
            // currentWord
            // 
            this.currentWord.Cursor = System.Windows.Forms.Cursors.No;
            this.currentWord.Location = new System.Drawing.Point(104, 53);
            this.currentWord.Name = "currentWord";
            this.currentWord.ReadOnly = true;
            this.currentWord.Size = new System.Drawing.Size(256, 29);
            this.currentWord.TabIndex = 3;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(31, 104);
            this.answerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(61, 21);
            this.answerLabel.TabIndex = 4;
            this.answerLabel.Text = "Ответ:";
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(104, 101);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(256, 29);
            this.answer.TabIndex = 5;
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.accept.Location = new System.Drawing.Point(48, 163);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(94, 34);
            this.accept.TabIndex = 6;
            this.accept.Text = "Принять";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.close.Location = new System.Drawing.Point(317, 163);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(94, 34);
            this.close.TabIndex = 7;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // skip
            // 
            this.skip.BackColor = System.Drawing.Color.Silver;
            this.skip.Location = new System.Drawing.Point(165, 163);
            this.skip.Name = "skip";
            this.skip.Size = new System.Drawing.Size(122, 34);
            this.skip.TabIndex = 8;
            this.skip.Text = "Пропустить";
            this.skip.UseVisualStyleBackColor = false;
            this.skip.Click += new System.EventHandler(this.skip_Click);
            // 
            // EssentialWindows
            // 
            this.AcceptButton = this.accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 223);
            this.Controls.Add(this.skip);
            this.Controls.Add(this.close);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.currentWord);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.wordNum);
            this.Controls.Add(this.wordNumLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EssentialWindows";
            this.Text = "Тестирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordNumLabel;
        private System.Windows.Forms.Label wordNum;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.TextBox currentWord;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button skip;
    }
}