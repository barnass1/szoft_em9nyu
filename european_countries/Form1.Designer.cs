namespace european_countries
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            populationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            areaInSquareKmDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataBindingSource = new BindingSource(components);
            szerk = new Button();
            torles = new Button();
            megnyit = new Button();
            mentes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, populationDataGridViewTextBoxColumn, areaInSquareKmDataGridViewTextBoxColumn });
            dataGridView1.DataSource = countryDataBindingSource;
            dataGridView1.Location = new Point(12, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 303);
            dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // populationDataGridViewTextBoxColumn
            // 
            populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            populationDataGridViewTextBoxColumn.HeaderText = "Population";
            populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            // 
            // areaInSquareKmDataGridViewTextBoxColumn
            // 
            areaInSquareKmDataGridViewTextBoxColumn.DataPropertyName = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn.HeaderText = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn.Name = "areaInSquareKmDataGridViewTextBoxColumn";
            // 
            // countryDataBindingSource
            // 
            countryDataBindingSource.DataSource = typeof(CountryData);
            // 
            // szerk
            // 
            szerk.Location = new Point(713, 415);
            szerk.Name = "szerk";
            szerk.Size = new Size(75, 23);
            szerk.TabIndex = 1;
            szerk.Text = "Szerkesztés";
            szerk.UseVisualStyleBackColor = true;
            szerk.Click += button1_Click;
            // 
            // torles
            // 
            torles.Location = new Point(632, 415);
            torles.Name = "torles";
            torles.Size = new Size(75, 23);
            torles.TabIndex = 2;
            torles.Text = "Törlés";
            torles.UseVisualStyleBackColor = true;
            torles.Click += torles_Click;
            // 
            // megnyit
            // 
            megnyit.Location = new Point(713, 12);
            megnyit.Name = "megnyit";
            megnyit.Size = new Size(75, 23);
            megnyit.TabIndex = 3;
            megnyit.Text = "Megnyitás";
            megnyit.UseVisualStyleBackColor = true;
            megnyit.Click += megnyit_Click;
            // 
            // mentes
            // 
            mentes.Location = new Point(551, 415);
            mentes.Name = "mentes";
            mentes.Size = new Size(75, 23);
            mentes.TabIndex = 4;
            mentes.Text = "Mentés";
            mentes.UseVisualStyleBackColor = true;
            mentes.Click += mentes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mentes);
            Controls.Add(megnyit);
            Controls.Add(torles);
            Controls.Add(szerk);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button szerk;
        private Button torles;
        private Button megnyit;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaInSquareKmDataGridViewTextBoxColumn;
        private BindingSource countryDataBindingSource;
        private Button mentes;
    }
}