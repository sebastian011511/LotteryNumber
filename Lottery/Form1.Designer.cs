namespace Lottery
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelNumbers = new System.Windows.Forms.Label();
            this.buttonShowNum = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxNumbersDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Yellow;
            this.richTextBox1.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(64, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(331, 58);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "Welcome to the Lottery";
            // 
            // labelNumbers
            // 
            this.labelNumbers.AutoSize = true;
            this.labelNumbers.Location = new System.Drawing.Point(59, 124);
            this.labelNumbers.Name = "labelNumbers";
            this.labelNumbers.Size = new System.Drawing.Size(144, 17);
            this.labelNumbers.TabIndex = 1;
            this.labelNumbers.Text = "Your Lottery Number:";
            // 
            // buttonShowNum
            // 
            this.buttonShowNum.Location = new System.Drawing.Point(62, 187);
            this.buttonShowNum.Name = "buttonShowNum";
            this.buttonShowNum.Size = new System.Drawing.Size(128, 33);
            this.buttonShowNum.TabIndex = 0;
            this.buttonShowNum.Text = "Show Numbers";
            this.buttonShowNum.UseVisualStyleBackColor = true;
            this.buttonShowNum.Click += new System.EventHandler(this.buttonShowNum_Click);
            this.buttonShowNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(284, 187);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(99, 33);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxNumbersDisplay
            // 
            this.textBoxNumbersDisplay.Location = new System.Drawing.Point(209, 119);
            this.textBoxNumbersDisplay.Name = "textBoxNumbersDisplay";
            this.textBoxNumbersDisplay.ReadOnly = true;
            this.textBoxNumbersDisplay.Size = new System.Drawing.Size(174, 22);
            this.textBoxNumbersDisplay.TabIndex = 4;
            this.textBoxNumbersDisplay.TabStop = false;
            this.textBoxNumbersDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonShowNum;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 313);
            this.Controls.Add(this.textBoxNumbersDisplay);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonShowNum);
            this.Controls.Add(this.labelNumbers);
            this.Controls.Add(this.richTextBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelNumbers;
        private System.Windows.Forms.Button buttonShowNum;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxNumbersDisplay;
    }
}

