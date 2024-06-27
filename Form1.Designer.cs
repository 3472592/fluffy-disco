namespace Ch2WinFormsApp3
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
            this.enableCheckbox = new System.Windows.Forms.CheckBox();
            this.ChangeText = new System.Windows.Forms.Button();
            this.labelToChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enableCheckbox
            // 
            this.enableCheckbox.AutoSize = true;
            this.enableCheckbox.Location = new System.Drawing.Point(318, 12);
            this.enableCheckbox.Name = "enableCheckbox";
            this.enableCheckbox.Size = new System.Drawing.Size(152, 24);
            this.enableCheckbox.TabIndex = 0;
            this.enableCheckbox.Text = "Change Label Text";
            this.enableCheckbox.UseVisualStyleBackColor = true;
            // 
            // ChangeText
            // 
            this.ChangeText.Location = new System.Drawing.Point(12, 9);
            this.ChangeText.Name = "ChangeText";
            this.ChangeText.Size = new System.Drawing.Size(214, 29);
            this.ChangeText.TabIndex = 1;
            this.ChangeText.Text = "Change Label if Checked";
            this.ChangeText.UseVisualStyleBackColor = true;
            this.ChangeText.Click += new System.EventHandler(this.ChangeText_Click);
            // 
            // labelToChange
            // 
            this.labelToChange.Location = new System.Drawing.Point(12, 54);
            this.labelToChange.Name = "labelToChange";
            this.labelToChange.Size = new System.Drawing.Size(458, 25);
            this.labelToChange.TabIndex = 2;
            this.labelToChange.Text = "Press Btn to Change Text";
            this.labelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 83);
            this.Controls.Add(this.labelToChange);
            this.Controls.Add(this.ChangeText);
            this.Controls.Add(this.enableCheckbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox enableCheckbox;
        private Button ChangeText;
        private Label labelToChange;
    }
}