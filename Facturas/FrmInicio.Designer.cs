namespace Facturas
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblTitulo = new Label();
            BtnAñadir = new Button();
            BtnAgregar = new Button();
            DgvFactura = new DataGridView();
            Id_Factura = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Relleno = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            BtnEditar = new Button();
            BtnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvFactura).BeginInit();
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
            // BtnAñadir
            // 
            BtnAñadir.Location = new Point(430, 402);
            BtnAñadir.Name = "BtnAñadir";
            BtnAñadir.Size = new Size(149, 23);
            BtnAñadir.TabIndex = 2;
            BtnAñadir.Text = "Añadir Factura";
            BtnAñadir.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Silver;
            BtnAgregar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregar.Location = new Point(272, 285);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(143, 34);
            BtnAgregar.TabIndex = 0;
            BtnAgregar.Text = "Agregar Factura";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // DgvFactura
            // 
            DgvFactura.AllowUserToAddRows = false;
            DgvFactura.AllowUserToDeleteRows = false;
            DgvFactura.BackgroundColor = SystemColors.Info;
            DgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvFactura.Columns.AddRange(new DataGridViewColumn[] { Id_Factura, Nombre, Relleno, Precio });
            DgvFactura.Location = new Point(173, 84);
            DgvFactura.Name = "DgvFactura";
            DgvFactura.ReadOnly = true;
            DgvFactura.Size = new Size(343, 150);
            DgvFactura.TabIndex = 1;
            // 
            // Id_Factura
            // 
            Id_Factura.HeaderText = "Id Factura";
            Id_Factura.Name = "Id_Factura";
            Id_Factura.ReadOnly = true;
            Id_Factura.Visible = false;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Relleno
            // 
            Relleno.HeaderText = "Relleno";
            Relleno.Name = "Relleno";
            Relleno.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.Silver;
            BtnEditar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.Location = new Point(476, 285);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(143, 34);
            BtnEditar.TabIndex = 2;
            BtnEditar.Text = "Editar Factura";
            BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.Silver;
            BtnEliminar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.Location = new Point(75, 285);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(143, 34);
            BtnEliminar.TabIndex = 3;
            BtnEliminar.Text = "Eliminar Factura";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // FrmInicio
            // 
            BackColor = Color.GhostWhite;
            ClientSize = new Size(712, 460);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditar);
            Controls.Add(DgvFactura);
            Controls.Add(BtnAgregar);
            Name = "FrmInicio";
            ((System.ComponentModel.ISupportInitialize)DgvFactura).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Label LblTitulo;
        private Button BtnAñadir;
        private Button BtnAgregar;
        private DataGridView DgvFactura;
        private DataGridViewTextBoxColumn Id_Factura;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Relleno;
        private DataGridViewTextBoxColumn Precio;
        private Button BtnEditar;
        private Button BtnEliminar;
    }
}
