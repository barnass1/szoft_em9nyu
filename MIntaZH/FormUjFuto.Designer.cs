namespace MIntaZH
{
    partial class FormUjFuto
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
            components = new System.ComponentModel.Container();
            buttonOk = new Button();
            buttonMegse = new Button();
            textBox1 = new TextBox();
            futoBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)futoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(366, 756);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(150, 46);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonMegse
            // 
            buttonMegse.DialogResult = DialogResult.Cancel;
            buttonMegse.Location = new Point(210, 756);
            buttonMegse.Name = "buttonMegse";
            buttonMegse.Size = new Size(150, 46);
            buttonMegse.TabIndex = 1;
            buttonMegse.Text = "Mégse";
            buttonMegse.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", futoBindingSource, "Nev", true));
            textBox1.Location = new Point(12, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(504, 39);
            textBox1.TabIndex = 2;
            // 
            // futoBindingSource
            // 
            futoBindingSource.DataSource = typeof(futo);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", futoBindingSource, "VersenyzoID", true));
            textBox2.Location = new Point(12, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(504, 39);
            textBox2.TabIndex = 3;
            // 
            // FormUjFuto
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 814);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonMegse);
            Controls.Add(buttonOk);
            Name = "FormUjFuto";
            Text = "FormUjFuto";
            Load += FormUjFuto_Load;
            ((System.ComponentModel.ISupportInitialize)futoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonMegse;
        private TextBox textBox1;
        private BindingSource futoBindingSource;
        private TextBox textBox2;
    }
}