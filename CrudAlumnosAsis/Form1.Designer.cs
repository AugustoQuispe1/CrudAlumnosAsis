namespace CrudAlumnosAsis
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Modificar = new System.Windows.Forms.Button();
            this.Bt_Borrar = new System.Windows.Forms.Button();
            this.Bt_Cargar = new System.Windows.Forms.Button();
            this.Txt_DNI = new System.Windows.Forms.TextBox();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTime_fecha = new System.Windows.Forms.DateTimePicker();
            this.Bt_Modificar_Asis = new System.Windows.Forms.Button();
            this.Bt_Borrar_Asis = new System.Windows.Forms.Button();
            this.Bt_Cargar_Asis = new System.Windows.Forms.Button();
            this.rButton_Asis = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_DNI_Asis = new System.Windows.Forms.TextBox();
            this.dataasistencia = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataasistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(30, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGrid);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Bt_Modificar);
            this.tabPage1.Controls.Add(this.Bt_Borrar);
            this.tabPage1.Controls.Add(this.Bt_Cargar);
            this.tabPage1.Controls.Add(this.Txt_DNI);
            this.tabPage1.Controls.Add(this.Txt_Apellido);
            this.tabPage1.Controls.Add(this.Txt_Nombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(737, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alumnos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(283, 48);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(399, 282);
            this.dataGrid.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // Bt_Modificar
            // 
            this.Bt_Modificar.Location = new System.Drawing.Point(52, 307);
            this.Bt_Modificar.Name = "Bt_Modificar";
            this.Bt_Modificar.Size = new System.Drawing.Size(75, 23);
            this.Bt_Modificar.TabIndex = 5;
            this.Bt_Modificar.Text = "Modificar";
            this.Bt_Modificar.UseVisualStyleBackColor = true;
            this.Bt_Modificar.Click += new System.EventHandler(this.Bt_Modificar_Click);
            // 
            // Bt_Borrar
            // 
            this.Bt_Borrar.Location = new System.Drawing.Point(52, 262);
            this.Bt_Borrar.Name = "Bt_Borrar";
            this.Bt_Borrar.Size = new System.Drawing.Size(75, 23);
            this.Bt_Borrar.TabIndex = 4;
            this.Bt_Borrar.Text = "Borrar";
            this.Bt_Borrar.UseVisualStyleBackColor = true;
            this.Bt_Borrar.Click += new System.EventHandler(this.Bt_Borrar_Click);
            // 
            // Bt_Cargar
            // 
            this.Bt_Cargar.Location = new System.Drawing.Point(52, 223);
            this.Bt_Cargar.Name = "Bt_Cargar";
            this.Bt_Cargar.Size = new System.Drawing.Size(75, 23);
            this.Bt_Cargar.TabIndex = 3;
            this.Bt_Cargar.Text = "Cargar";
            this.Bt_Cargar.UseVisualStyleBackColor = true;
            this.Bt_Cargar.Click += new System.EventHandler(this.Bt_Cargar_Click);
            // 
            // Txt_DNI
            // 
            this.Txt_DNI.Location = new System.Drawing.Point(37, 176);
            this.Txt_DNI.Name = "Txt_DNI";
            this.Txt_DNI.Size = new System.Drawing.Size(100, 20);
            this.Txt_DNI.TabIndex = 2;
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Location = new System.Drawing.Point(37, 112);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.Txt_Apellido.TabIndex = 1;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(37, 48);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nombre.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dateTime_fecha);
            this.tabPage2.Controls.Add(this.Bt_Modificar_Asis);
            this.tabPage2.Controls.Add(this.Bt_Borrar_Asis);
            this.tabPage2.Controls.Add(this.Bt_Cargar_Asis);
            this.tabPage2.Controls.Add(this.rButton_Asis);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.Txt_DNI_Asis);
            this.tabPage2.Controls.Add(this.dataasistencia);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(737, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asistencias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha";
            // 
            // dateTime_fecha
            // 
            this.dateTime_fecha.Location = new System.Drawing.Point(14, 164);
            this.dateTime_fecha.Name = "dateTime_fecha";
            this.dateTime_fecha.Size = new System.Drawing.Size(200, 20);
            this.dateTime_fecha.TabIndex = 7;
            // 
            // Bt_Modificar_Asis
            // 
            this.Bt_Modificar_Asis.Location = new System.Drawing.Point(73, 275);
            this.Bt_Modificar_Asis.Name = "Bt_Modificar_Asis";
            this.Bt_Modificar_Asis.Size = new System.Drawing.Size(75, 23);
            this.Bt_Modificar_Asis.TabIndex = 6;
            this.Bt_Modificar_Asis.Text = "Modificar";
            this.Bt_Modificar_Asis.UseVisualStyleBackColor = true;
            this.Bt_Modificar_Asis.Click += new System.EventHandler(this.Bt_Modificar_Asis_Click);
            // 
            // Bt_Borrar_Asis
            // 
            this.Bt_Borrar_Asis.Location = new System.Drawing.Point(73, 246);
            this.Bt_Borrar_Asis.Name = "Bt_Borrar_Asis";
            this.Bt_Borrar_Asis.Size = new System.Drawing.Size(75, 23);
            this.Bt_Borrar_Asis.TabIndex = 5;
            this.Bt_Borrar_Asis.Text = "Borrar";
            this.Bt_Borrar_Asis.UseVisualStyleBackColor = true;
            this.Bt_Borrar_Asis.Click += new System.EventHandler(this.Bt_Borrar_Asis_Click);
            // 
            // Bt_Cargar_Asis
            // 
            this.Bt_Cargar_Asis.Location = new System.Drawing.Point(73, 217);
            this.Bt_Cargar_Asis.Name = "Bt_Cargar_Asis";
            this.Bt_Cargar_Asis.Size = new System.Drawing.Size(75, 23);
            this.Bt_Cargar_Asis.TabIndex = 4;
            this.Bt_Cargar_Asis.Text = "Cargar";
            this.Bt_Cargar_Asis.UseVisualStyleBackColor = true;
            this.Bt_Cargar_Asis.Click += new System.EventHandler(this.Bt_Cargar_Asis_Click);
            // 
            // rButton_Asis
            // 
            this.rButton_Asis.AutoSize = true;
            this.rButton_Asis.Location = new System.Drawing.Point(63, 130);
            this.rButton_Asis.Name = "rButton_Asis";
            this.rButton_Asis.Size = new System.Drawing.Size(61, 17);
            this.rButton_Asis.TabIndex = 3;
            this.rButton_Asis.TabStop = true;
            this.rButton_Asis.Text = "Asistió?";
            this.rButton_Asis.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "DNI";
            // 
            // Txt_DNI_Asis
            // 
            this.Txt_DNI_Asis.Location = new System.Drawing.Point(63, 92);
            this.Txt_DNI_Asis.Name = "Txt_DNI_Asis";
            this.Txt_DNI_Asis.Size = new System.Drawing.Size(100, 20);
            this.Txt_DNI_Asis.TabIndex = 1;
            // 
            // dataasistencia
            // 
            this.dataasistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataasistencia.Location = new System.Drawing.Point(290, 55);
            this.dataasistencia.Name = "dataasistencia";
            this.dataasistencia.Size = new System.Drawing.Size(347, 268);
            this.dataasistencia.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ColegioAsistencias";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataasistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Modificar;
        private System.Windows.Forms.Button Bt_Borrar;
        private System.Windows.Forms.Button Bt_Cargar;
        private System.Windows.Forms.TextBox Txt_DNI;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Button Bt_Modificar_Asis;
        private System.Windows.Forms.Button Bt_Borrar_Asis;
        private System.Windows.Forms.Button Bt_Cargar_Asis;
        private System.Windows.Forms.RadioButton rButton_Asis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_DNI_Asis;
        private System.Windows.Forms.DataGridView dataasistencia;
        private System.Windows.Forms.DateTimePicker dateTime_fecha;
        private System.Windows.Forms.Label label5;
    }
}

