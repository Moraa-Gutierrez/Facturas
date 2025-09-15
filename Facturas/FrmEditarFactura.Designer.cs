namespace Facturas
{
    partial class FrmEditarFactura
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
            LblEditarNombre = new Label();
            TxtNombreEditar = new TextBox();
            LblEditarRelleno = new Label();
            TxtPrecioEditar = new TextBox();
            LblEditarPrecio = new Label();
            ChkEditarRelleno = new CheckBox();
            BtnCancelar = new Button();
            BtnAceptar = new Button();
            SuspendLayout();
            // 
            // LblEditarNombre
            // 
            LblEditarNombre.AutoSize = true;
            LblEditarNombre.BackColor = Color.FromArgb(224, 224, 224);
            LblEditarNombre.Font = new Font("Georgia", 12F, FontStyle.Bold);
            LblEditarNombre.Location = new Point(55, 167);
            LblEditarNombre.Name = "LblEditarNombre";
            LblEditarNombre.Size = new Size(131, 18);
            LblEditarNombre.TabIndex = 0;
            LblEditarNombre.Text = "Editar Nombre";
            // 
            // TxtNombreEditar
            // 
            TxtNombreEditar.Location = new Point(55, 202);
            TxtNombreEditar.Name = "TxtNombreEditar";
            TxtNombreEditar.Size = new Size(134, 23);
            TxtNombreEditar.TabIndex = 1;
            // 
            // LblEditarRelleno
            // 
            LblEditarRelleno.AutoSize = true;
            LblEditarRelleno.BackColor = Color.FromArgb(224, 224, 224);
            LblEditarRelleno.Font = new Font("Georgia", 12F, FontStyle.Bold);
            LblEditarRelleno.Location = new Point(277, 167);
            LblEditarRelleno.Name = "LblEditarRelleno";
            LblEditarRelleno.Size = new Size(128, 18);
            LblEditarRelleno.TabIndex = 2;
            LblEditarRelleno.Text = "Editar Relleno";
            // 
            // TxtPrecioEditar
            // 
            TxtPrecioEditar.Location = new Point(490, 202);
            TxtPrecioEditar.Name = "TxtPrecioEditar";
            TxtPrecioEditar.Size = new Size(134, 23);
            TxtPrecioEditar.TabIndex = 3;
            // 
            // LblEditarPrecio
            // 
            LblEditarPrecio.AutoSize = true;
            LblEditarPrecio.BackColor = Color.FromArgb(224, 224, 224);
            LblEditarPrecio.Font = new Font("Georgia", 12F, FontStyle.Bold);
            LblEditarPrecio.Location = new Point(490, 167);
            LblEditarPrecio.Name = "LblEditarPrecio";
            LblEditarPrecio.Size = new Size(118, 18);
            LblEditarPrecio.TabIndex = 4;
            LblEditarPrecio.Text = "Editar Precio";
            // 
            // ChkEditarRelleno
            // 
            ChkEditarRelleno.AutoSize = true;
            ChkEditarRelleno.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold | FontStyle.Italic);
            ChkEditarRelleno.Location = new Point(277, 206);
            ChkEditarRelleno.Name = "ChkEditarRelleno";
            ChkEditarRelleno.Size = new Size(117, 32);
            ChkEditarRelleno.TabIndex = 5;
            ChkEditarRelleno.Text = "Relleno?";
            ChkEditarRelleno.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = SystemColors.ActiveBorder;
            BtnCancelar.Font = new Font("MV Boli", 14.25F, FontStyle.Bold);
            BtnCancelar.Location = new Point(208, 302);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(110, 46);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAceptar
            // 
            BtnAceptar.BackColor = SystemColors.ActiveBorder;
            BtnAceptar.Font = new Font("MV Boli", 14.25F, FontStyle.Bold);
            BtnAceptar.Location = new Point(399, 302);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(110, 46);
            BtnAceptar.TabIndex = 7;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = false;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // FrmEditarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(686, 377);
            Controls.Add(BtnAceptar);
            Controls.Add(BtnCancelar);
            Controls.Add(ChkEditarRelleno);
            Controls.Add(LblEditarPrecio);
            Controls.Add(TxtPrecioEditar);
            Controls.Add(LblEditarRelleno);
            Controls.Add(TxtNombreEditar);
            Controls.Add(LblEditarNombre);
            Name = "FrmEditarFactura";
            Text = "FrmEditarFactura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblEditarNombre;
        private TextBox TxtNombreEditar;
        private Label LblEditarRelleno;
        private TextBox TxtPrecioEditar;
        private Label LblEditarPrecio;
        private CheckBox ChkEditarRelleno;
        private Button BtnCancelar;
        private Button BtnAceptar;
    }
}