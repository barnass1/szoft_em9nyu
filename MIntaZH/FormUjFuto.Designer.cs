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
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)futoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(366, 474);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(150, 46);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonMegse
            // 
            buttonMegse.DialogResult = DialogResult.Cancel;
            buttonMegse.Location = new Point(210, 474);
            buttonMegse.Name = "buttonMegse";
            buttonMegse.Size = new Size(150, 46);
            buttonMegse.TabIndex = 1;
            buttonMegse.Text = "Mégse";
            buttonMegse.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", futoBindingSource, "Nev", true));
            textBox1.Location = new Point(12, 142);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(42, 32);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(62, 32);
            label2.TabIndex = 5;
            label2.Text = "Név:";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", futoBindingSource, "Kategoria", true));
            textBox3.Location = new Point(12, 373);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(504, 39);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", futoBindingSource, "Nemzetiseg", true));
            textBox4.Location = new Point(12, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(504, 39);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", futoBindingSource, "EredmenyPerc", true));
            textBox5.Location = new Point(12, 296);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(504, 39);
            textBox5.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(146, 32);
            label3.TabIndex = 9;
            label3.Text = "Nemzetiség:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 261);
            label4.Name = "label4";
            label4.Size = new Size(193, 32);
            label4.TabIndex = 10;
            label4.Text = "Eredmény (perc):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 338);
            label5.Name = "label5";
            label5.Size = new Size(120, 32);
            label5.TabIndex = 11;
            label5.Text = "Kategória:";
            // 
            // FormUjFuto
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 535);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}