namespace Facturas
{
    partial class FrmMain
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
            LblTitulo = new Label();
            Dgv = new DataGridView();
            Id_Factura = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Relleno = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            BtnAñadir = new Button();
            ((System.ComponentModel.ISupportInitialize)Dgv).BeginInit();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(430, 34);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(82, 24);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Facturas\r\n";
            // 
            // Dgv
            // 
            Dgv.AllowUserToAddRows = false;
            Dgv.AllowUserToDeleteRows = false;
            Dgv.AllowUserToResizeColumns = false;
            Dgv.BackgroundColor = Color.FromArgb(192, 255, 192);
            Dgv.BorderStyle = BorderStyle.Fixed3D;
            Dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv.Columns.AddRange(new DataGridViewColumn[] { Id_Factura, Nombre, Relleno, Precio });
            Dgv.EditMode = DataGridViewEditMode.EditOnF2;
            Dgv.Enabled = false;
            Dgv.Location = new Point(272, 82);
            Dgv.Name = "Dgv";
            Dgv.Size = new Size(444, 275);
            Dgv.TabIndex = 1;
            // 
            // Id_Factura
            // 
            Id_Factura.HeaderText = "Id_Factura";
            Id_Factura.Name = "Id_Factura";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Relleno
            // 
            Relleno.HeaderText = "Relleno";
            Relleno.Name = "Relleno";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // BtnAñadir
            // 
            BtnAñadir.Location = new Point(430, 402);
            BtnAñadir.Name = "BtnAñadir";
            BtnAñadir.Size = new Size(149, 23);
            BtnAñadir.TabIndex = 2;
            BtnAñadir.Text = "Añadir Factura";
            BtnAñadir.UseVisualStyleBackColor = true;
            BtnAñadir.Click += BtnAñadir_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 563);
            Controls.Add(BtnAñadir);
            Controls.Add(Dgv);
            Controls.Add(LblTitulo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private DataGridView Dgv;
        private DataGridViewTextBoxColumn Id_Factura;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Relleno;
        private DataGridViewTextBoxColumn Precio;
        private Button BtnAñadir;
    }
}
