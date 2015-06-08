namespace WindowsFormsApplication1
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
            this.checkinButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkinButton
            // 
            this.checkinButton.Location = new System.Drawing.Point(12, 166);
            this.checkinButton.Name = "checkinButton";
            this.checkinButton.Size = new System.Drawing.Size(75, 23);
            this.checkinButton.TabIndex = 0;
            this.checkinButton.Text = "Check-in";
            this.checkinButton.UseVisualStyleBackColor = true;
            this.checkinButton.Click += new System.EventHandler(this.checkinButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(228, 165);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(73, 24);
            this.checkoutButton.TabIndex = 1;
            this.checkoutButton.Text = "Check-out";
            this.checkoutButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "All Equipment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add New Equipment";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remove Equipment";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 205);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.checkinButton);
            this.Name = "Form1";
            this.Text = "DePauw SDS Equipment Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkinButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

