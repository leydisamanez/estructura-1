namespace estructura_1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvmascota = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdueño = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.registrarbtn = new System.Windows.Forms.Button();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.razacbo = new System.Windows.Forms.ComboBox();
            this.nombreanimaltxt = new System.Windows.Forms.TextBox();
            this.edadtxt = new System.Windows.Forms.TextBox();
            this.telefonotxt = new System.Windows.Forms.TextBox();
            this.direcciontxt = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.busquedabtn = new System.Windows.Forms.Button();
            this.dato1txt = new System.Windows.Forms.TextBox();
            this.Mostrar = new System.Windows.Forms.Button();
            this.mostrarmascota = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdueño)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 72);
            this.panel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvmascota);
            this.tabPage2.Controls.Add(this.dgvdueño);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvmascota
            // 
            this.dgvmascota.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.dgvmascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.dgvmascota.Location = new System.Drawing.Point(392, 57);
            this.dgvmascota.Name = "dgvmascota";
            this.dgvmascota.RowTemplate.Height = 25;
            this.dgvmascota.Size = new System.Drawing.Size(345, 304);
            this.dgvmascota.TabIndex = 1;
            this.dgvmascota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmascota_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Raza";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "edadtxt";
            this.dataGridViewTextBoxColumn2.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dgvdueño
            // 
            this.dgvdueño.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.dgvdueño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdueño.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Dirección,
            this.Column2});
            this.dgvdueño.Location = new System.Drawing.Point(24, 57);
            this.dgvdueño.Name = "dgvdueño";
            this.dgvdueño.RowTemplate.Height = 25;
            this.dgvdueño.Size = new System.Drawing.Size(342, 304);
            this.dgvdueño.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Dirección
            // 
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.Name = "Dirección";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Telefono";
            this.Column2.Name = "Column2";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.registrarbtn);
            this.tabPage1.Controls.Add(this.nombretxt);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.razacbo);
            this.tabPage1.Controls.Add(this.nombreanimaltxt);
            this.tabPage1.Controls.Add(this.edadtxt);
            this.tabPage1.Controls.Add(this.telefonotxt);
            this.tabPage1.Controls.Add(this.direcciontxt);
            this.tabPage1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // registrarbtn
            // 
            this.registrarbtn.FlatAppearance.BorderSize = 4;
            this.registrarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarbtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrarbtn.ForeColor = System.Drawing.Color.OliveDrab;
            this.registrarbtn.Location = new System.Drawing.Point(377, 329);
            this.registrarbtn.Name = "registrarbtn";
            this.registrarbtn.Size = new System.Drawing.Size(109, 39);
            this.registrarbtn.TabIndex = 18;
            this.registrarbtn.Text = "Registrar";
            this.registrarbtn.UseVisualStyleBackColor = true;
            this.registrarbtn.Click += new System.EventHandler(this.registrarbtn_Click);
            // 
            // nombretxt
            // 
            this.nombretxt.BackColor = System.Drawing.Color.OliveDrab;
            this.nombretxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombretxt.Location = new System.Drawing.Point(199, 113);
            this.nombretxt.Multiline = true;
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(145, 31);
            this.nombretxt.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "Datos de la mascota:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(452, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Datos del Dueño:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(452, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Raza:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(453, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(119, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre:";
            // 
            // razacbo
            // 
            this.razacbo.BackColor = System.Drawing.Color.OliveDrab;
            this.razacbo.FormattingEnabled = true;
            this.razacbo.Items.AddRange(new object[] {
            "Pequeño",
            "Mediano",
            "Grande"});
            this.razacbo.Location = new System.Drawing.Point(521, 190);
            this.razacbo.Name = "razacbo";
            this.razacbo.Size = new System.Drawing.Size(182, 22);
            this.razacbo.TabIndex = 9;
            // 
            // nombreanimaltxt
            // 
            this.nombreanimaltxt.BackColor = System.Drawing.Color.OliveDrab;
            this.nombreanimaltxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreanimaltxt.Location = new System.Drawing.Point(531, 101);
            this.nombreanimaltxt.Multiline = true;
            this.nombreanimaltxt.Name = "nombreanimaltxt";
            this.nombreanimaltxt.Size = new System.Drawing.Size(172, 31);
            this.nombreanimaltxt.TabIndex = 6;
            // 
            // edadtxt
            // 
            this.edadtxt.BackColor = System.Drawing.Color.OliveDrab;
            this.edadtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edadtxt.Location = new System.Drawing.Point(521, 275);
            this.edadtxt.Multiline = true;
            this.edadtxt.Name = "edadtxt";
            this.edadtxt.Size = new System.Drawing.Size(172, 31);
            this.edadtxt.TabIndex = 6;
            // 
            // telefonotxt
            // 
            this.telefonotxt.BackColor = System.Drawing.Color.OliveDrab;
            this.telefonotxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefonotxt.Location = new System.Drawing.Point(199, 182);
            this.telefonotxt.Multiline = true;
            this.telefonotxt.Name = "telefonotxt";
            this.telefonotxt.Size = new System.Drawing.Size(145, 31);
            this.telefonotxt.TabIndex = 7;
            // 
            // direcciontxt
            // 
            this.direcciontxt.BackColor = System.Drawing.Color.OliveDrab;
            this.direcciontxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.direcciontxt.Location = new System.Drawing.Point(199, 262);
            this.direcciontxt.Multiline = true;
            this.direcciontxt.Name = "direcciontxt";
            this.direcciontxt.Size = new System.Drawing.Size(145, 31);
            this.direcciontxt.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(200, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 416);
            this.tabControl1.TabIndex = 1;
            // 
            // busquedabtn
            // 
            this.busquedabtn.BackColor = System.Drawing.Color.White;
            this.busquedabtn.FlatAppearance.BorderSize = 4;
            this.busquedabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.busquedabtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.busquedabtn.ForeColor = System.Drawing.Color.OliveDrab;
            this.busquedabtn.Location = new System.Drawing.Point(45, 227);
            this.busquedabtn.Name = "busquedabtn";
            this.busquedabtn.Size = new System.Drawing.Size(120, 42);
            this.busquedabtn.TabIndex = 2;
            this.busquedabtn.Text = "Buscar";
            this.busquedabtn.UseVisualStyleBackColor = false;
            this.busquedabtn.Click += new System.EventHandler(this.busquedabtn_Click);
            // 
            // dato1txt
            // 
            this.dato1txt.BackColor = System.Drawing.Color.OliveDrab;
            this.dato1txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dato1txt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dato1txt.Location = new System.Drawing.Point(35, 307);
            this.dato1txt.Multiline = true;
            this.dato1txt.Name = "dato1txt";
            this.dato1txt.Size = new System.Drawing.Size(145, 31);
            this.dato1txt.TabIndex = 17;
            // 
            // Mostrar
            // 
            this.Mostrar.BackColor = System.Drawing.Color.White;
            this.Mostrar.FlatAppearance.BorderSize = 4;
            this.Mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mostrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mostrar.ForeColor = System.Drawing.Color.OliveDrab;
            this.Mostrar.Location = new System.Drawing.Point(45, 365);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(131, 51);
            this.Mostrar.TabIndex = 18;
            this.Mostrar.Text = "Mostrar datos Dueño";
            this.Mostrar.UseVisualStyleBackColor = false;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // mostrarmascota
            // 
            this.mostrarmascota.BackColor = System.Drawing.Color.White;
            this.mostrarmascota.FlatAppearance.BorderSize = 4;
            this.mostrarmascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mostrarmascota.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mostrarmascota.ForeColor = System.Drawing.Color.OliveDrab;
            this.mostrarmascota.Location = new System.Drawing.Point(45, 437);
            this.mostrarmascota.Name = "mostrarmascota";
            this.mostrarmascota.Size = new System.Drawing.Size(131, 51);
            this.mostrarmascota.TabIndex = 19;
            this.mostrarmascota.Text = "Mostrar Datos Mascota";
            this.mostrarmascota.UseVisualStyleBackColor = false;
            this.mostrarmascota.Click += new System.EventHandler(this.mostrarmascota_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(970, 565);
            this.Controls.Add(this.mostrarmascota);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.dato1txt);
            this.Controls.Add(this.busquedabtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdueño)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TabPage tabPage2;
        private DataGridView dgvmascota;
        private DataGridView dgvdueño;
        private TabPage tabPage1;
        private TextBox nombretxt;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox razacbo;
        private TextBox nombreanimaltxt;
        private TextBox edadtxt;
        private TextBox telefonotxt;
        private TextBox direcciontxt;
        private TabControl tabControl1;
        private Button busquedabtn;
        private TextBox dato1txt;
        private Button registrarbtn;
        private Button Mostrar;
        private Button mostrarmascota;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Dirección;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}