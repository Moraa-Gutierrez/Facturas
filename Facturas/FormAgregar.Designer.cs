namespace Facturas
{
    partial class FormAgregar
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
            TxtRelleno = new TextBox();
            TxtPrecio = new TextBox();
            TxtNombre = new TextBox();
            BtnAgregar = new Button();
            SuspendLayout();
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombre.ForeColor = SystemColors.ButtonHighlight;
            LblNombre.Location = new Point(162, 129);
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
            LblRelleno.Location = new Point(372, 129);
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
            LblPrecio.Location = new Point(567, 129);
            LblPrecio.Name = "LblPrecio";
            LblPrecio.Size = new Size(80, 18);
            LblPrecio.TabIndex = 2;
            LblPrecio.Text = "PRECIO:";
            // 
            // TxtRelleno
            // 
            TxtRelleno.Location = new Point(372, 147);
            TxtRelleno.Name = "TxtRelleno";
            TxtRelleno.Size = new Size(100, 23);
            TxtRelleno.TabIndex = 3;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(567, 147);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(100, 23);
            TxtPrecio.TabIndex = 4;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(162, 147);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(100, 23);
            TxtNombre.TabIndex = 5;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.DarkGray;
            BtnAgregar.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnAgregar.ForeColor = SystemColors.ControlLightLight;
            BtnAgregar.Location = new Point(346, 274);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(145, 43);
            BtnAgregar.TabIndex = 6;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAgregar);
            Controls.Add(TxtNombre);
            Controls.Add(TxtPrecio);
            Controls.Add(TxtRelleno);
            Controls.Add(LblPrecio);
            Controls.Add(LblRelleno);
            Controls.Add(LblNombre);
            Name = "FormAgregar";
            Text = "FormAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNombre;
        private Label LblRelleno;
        private Label LblPrecio;
        private TextBox TxtRelleno;
        private TextBox TxtPrecio;
        private TextBox TxtNombre;
        private Button BtnAgregar;
    }
}