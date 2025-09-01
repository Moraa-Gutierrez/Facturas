namespace Facturas
{
    partial class FrmAgregar
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
            SuspendLayout();
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombre.ForeColor = SystemColors.ButtonHighlight;
            LblNombre.Location = new Point(119, 125);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(89, 18);
            LblNombre.TabIndex = 0;
            LblNombre.Text = "NOMBRE:";
            // 
            // LblRelleno
            // 
            LblRelleno.AutoSize = true;
            LblRelleno.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblRelleno.ForeColor = SystemColors.ControlLightLight;
            LblRelleno.Location = new Point(329, 125);
            LblRelleno.Name = "LblRelleno";
            LblRelleno.Size = new Size(96, 18);
            LblRelleno.TabIndex = 1;
            LblRelleno.Text = "RELLENO:";
            // 
            // LblPrecio
            // 
            LblPrecio.AutoSize = true;
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
            TxtPrecio.Location = new Point(524, 143);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(100, 23);
            TxtPrecio.TabIndex = 4;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(119, 143);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(100, 23);
            TxtNombre.TabIndex = 5;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.DarkGray;
            BtnAgregar.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnAgregar.ForeColor = SystemColors.ControlLightLight;
            BtnAgregar.Location = new Point(296, 269);
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
            ChkRelleno.Location = new Point(319, 143);
            ChkRelleno.Name = "ChkRelleno";
            ChkRelleno.Size = new Size(117, 32);
            ChkRelleno.TabIndex = 7;
            ChkRelleno.Text = "Relleno?";
            ChkRelleno.UseVisualStyleBackColor = true;
            // 
            // FrmAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(ChkRelleno);
            Controls.Add(BtnAgregar);
            Controls.Add(TxtNombre);
            Controls.Add(TxtPrecio);
            Controls.Add(LblPrecio);
            Controls.Add(LblRelleno);
            Controls.Add(LblNombre);
            Name = "FrmAgregar";
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
    }
}