
namespace CheckBoxTest
{
    partial class CheckBoxTestForm
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
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Location = new System.Drawing.Point(151, 127);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(50, 19);
            this.boldCheckBox.TabIndex = 0;
            this.boldCheckBox.Text = "Bold";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.boldCheckBox_CheckedChanged);
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Location = new System.Drawing.Point(346, 127);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(51, 19);
            this.italicCheckBox.TabIndex = 1;
            this.italicCheckBox.Text = "Italic";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.italicCheckBox_CheckedChanged);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputLabel.Location = new System.Drawing.Point(151, 56);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(246, 25);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Watch the font style change";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.italicCheckBox);
            this.Controls.Add(this.boldCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.Label outputLabel;
    }
}

