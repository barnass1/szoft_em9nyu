namespace csillagterkep
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
            buttonRajz = new Button();
            SuspendLayout();
            // 
            // buttonRajz
            // 
            buttonRajz.Location = new Point(12, 12);
            buttonRajz.Name = "buttonRajz";
            buttonRajz.Size = new Size(75, 23);
            buttonRajz.TabIndex = 0;
            buttonRajz.Text = "Rajzolás";
            buttonRajz.UseVisualStyleBackColor = true;
            buttonRajz.Click += buttonRajz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRajz);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRajz;
    }
}