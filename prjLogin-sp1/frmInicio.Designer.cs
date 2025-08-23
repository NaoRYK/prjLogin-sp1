namespace prjLogin_sp1
{
    partial class frmInicio
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
            btnAceptar_inicio = new Button();
            lblSaludo = new Label();
            SuspendLayout();
            // 
            // btnAceptar_inicio
            // 
            btnAceptar_inicio.Font = new Font("Segoe UI", 24F);
            btnAceptar_inicio.Location = new Point(157, 226);
            btnAceptar_inicio.Name = "btnAceptar_inicio";
            btnAceptar_inicio.Size = new Size(195, 68);
            btnAceptar_inicio.TabIndex = 0;
            btnAceptar_inicio.Text = "Aceptar";
            btnAceptar_inicio.UseVisualStyleBackColor = true;
            btnAceptar_inicio.Click += btnAceptar_inicio_Click;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.BorderStyle = BorderStyle.Fixed3D;
            lblSaludo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblSaludo.Location = new Point(97, 81);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(346, 47);
            lblSaludo.TabIndex = 1;
            lblSaludo.Text = "Bienvenido al sistema";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 353);
            Controls.Add(lblSaludo);
            Controls.Add(btnAceptar_inicio);
            Name = "frmInicio";
            Text = "frmInicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar_inicio;
        private Label lblSaludo;
    }
}