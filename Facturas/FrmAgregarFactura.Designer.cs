namespace Facturas
{
    partial class FrmAgregarFactura
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
            LblNombre = new Label();
            LblRelleno = new Label();
            LblPrecio = new Label();
            TxtPrecio = new TextBox();
            TxtNombre = new TextBox();
            BtnAgregar = new Button();
            ChkRelleno = new CheckBox();
            BtnVolver = new Button();
            SuspendLayout();
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.BackColor = Color.LightSlateGray;
            LblNombre.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombre.ForeColor = SystemColors.ControlLightLight;
            LblNombre.Location = new Point(119, 125);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(89, 18);
            LblNombre.TabIndex = 0;
            LblNombre.Text = "NOMBRE:";
            // 
            // LblRelleno
            // 
            LblRelleno.AutoSize = true;
            LblRelleno.BackColor = Color.Gray;
            LblRelleno.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblRelleno.ForeColor = SystemColors.ControlLightLight;
            LblRelleno.Location = new Point(340, 125);
            LblRelleno.Name = "LblRelleno";
            LblRelleno.Size = new Size(96, 18);
            LblRelleno.TabIndex = 1;
            LblRelleno.Text = "RELLENO:";
            // 
            // LblPrecio
            // 
            LblPrecio.AutoSize = true;
            LblPrecio.BackColor = Color.LightSlateGray;
            LblPrecio.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPrecio.ForeColor = SystemColors.ControlLightLight;
            LblPrecio.Location = new Point(524, 125);
            LblPrecio.Name = "LblPrecio";
            LblPrecio.Size = new Size(80, 18);
            LblPrecio.TabIndex = 2;
            LblPrecio.Text = "PRECIO:";
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(524, 160);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(126, 23);
            TxtPrecio.TabIndex = 4;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(119, 160);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(126, 23);
            TxtNombre.TabIndex = 5;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.DarkGray;
            BtnAgregar.Font = new Font("MV Boli", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnAgregar.ForeColor = SystemColors.ControlLightLight;
            BtnAgregar.Location = new Point(505, 269);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(145, 43);
            BtnAgregar.TabIndex = 6;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // ChkRelleno
            // 
            ChkRelleno.AutoSize = true;
            ChkRelleno.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ChkRelleno.Location = new Point(340, 152);
            ChkRelleno.Name = "ChkRelleno";
            ChkRelleno.Size = new Size(117, 32);
            ChkRelleno.TabIndex = 7;
            ChkRelleno.Text = "Relleno?";
            ChkRelleno.UseVisualStyleBackColor = true;
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.DarkGray;
            BtnVolver.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnVolver.ForeColor = SystemColors.ControlLightLight;
            BtnVolver.Location = new Point(187, 269);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(145, 43);
            BtnVolver.TabIndex = 8;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // FrmAgregarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnVolver);
            Controls.Add(ChkRelleno);
            Controls.Add(BtnAgregar);
            Controls.Add(TxtNombre);
            Controls.Add(TxtPrecio);
            Controls.Add(LblPrecio);
            Controls.Add(LblRelleno);
            Controls.Add(LblNombre);
            Name = "FrmAgregarFactura";
            Text = "FormAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNombre;
        private Label LblRelleno;
        private Label LblPrecio;
        private TextBox TxtPrecio;
        private TextBox TxtNombre;
        private Button BtnAgregar;
        private CheckBox ChkRelleno;
        private Button BtnVolver;
    }
}