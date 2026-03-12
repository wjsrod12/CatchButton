namespace CatchButton
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
            target = new Button();
            SuspendLayout();
            // 
            // target
            // 
            target.BackColor = Color.DarkKhaki;
            target.ForeColor = SystemColors.ControlText;
            target.Location = new Point(594, 233);
            target.Name = "target";
            target.Size = new Size(160, 100);
            target.TabIndex = 0;
            target.Text = "XD";
            target.UseVisualStyleBackColor = false;
            target.LocationChanged += target_LocationChanged;
            target.Click += target_Click;
            target.MouseEnter += target_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 443);
            Controls.Add(target);
            Name = "Form1";
            Text = "Catch the button version 1";
            ResumeLayout(false);
        }

        #endregion

        private Button target;
    }
}
