namespace WindowsFormsApplication1
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
            this.BarCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FNameTextBox = new System.Windows.Forms.TextBox();
            this.LNameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BarCodeTextBox
            // 
            this.BarCodeTextBox.Location = new System.Drawing.Point(96, 34);
            this.BarCodeTextBox.Name = "BarCodeTextBox";
            this.BarCodeTextBox.Size = new System.Drawing.Size(82, 20);
            this.BarCodeTextBox.TabIndex = 0;
            this.BarCodeTextBox.TextChanged += new System.EventHandler(this.BarCodeTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID Number:";
            // 
            // FNameTextBox
            // 
            this.FNameTextBox.Location = new System.Drawing.Point(96, 70);
            this.FNameTextBox.Name = "FNameTextBox";
            this.FNameTextBox.Size = new System.Drawing.Size(82, 20);
            this.FNameTextBox.TabIndex = 5;
            // 
            // LNameTextBox
            // 
            this.LNameTextBox.Location = new System.Drawing.Point(96, 105);
            this.LNameTextBox.Name = "LNameTextBox";
            this.LNameTextBox.Size = new System.Drawing.Size(82, 20);
            this.LNameTextBox.TabIndex = 6;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(96, 138);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(82, 20);
            this.IDTextBox.TabIndex = 7;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(12, 201);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(103, 201);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 236);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.LNameTextBox);
            this.Controls.Add(this.FNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarCodeTextBox);
            this.Name = "Form2";
            this.Text = "Submit Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox BarCodeTextBox;
        public System.Windows.Forms.TextBox FNameTextBox;
        public System.Windows.Forms.TextBox LNameTextBox;
        public System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
    }
}