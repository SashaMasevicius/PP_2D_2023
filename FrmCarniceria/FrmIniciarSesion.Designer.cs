namespace FrmCarniceria
{
    partial class FrmIniciarSesion
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
            buttonIniciarSesion = new Button();
            textBoxEmail = new TextBox();
            textBoxContrasena = new TextBox();
            button1 = new Button();
            buttonCompletarVendedor = new Button();
            SuspendLayout();
            // 
            // buttonIniciarSesion
            // 
            buttonIniciarSesion.BackColor = Color.White;
            buttonIniciarSesion.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonIniciarSesion.ForeColor = SystemColors.ActiveCaptionText;
            buttonIniciarSesion.Location = new Point(159, 203);
            buttonIniciarSesion.Name = "buttonIniciarSesion";
            buttonIniciarSesion.Size = new Size(100, 67);
            buttonIniciarSesion.TabIndex = 0;
            buttonIniciarSesion.Text = "Iniciar Sesion";
            buttonIniciarSesion.UseVisualStyleBackColor = false;
            buttonIniciarSesion.Click += button1_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.White;
            textBoxEmail.ForeColor = SystemColors.WindowText;
            textBoxEmail.Location = new Point(49, 91);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Ingresar E-mail";
            textBoxEmail.Size = new Size(331, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.BackColor = Color.White;
            textBoxContrasena.Location = new Point(49, 155);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.PasswordChar = '*';
            textBoxContrasena.PlaceholderText = "Ingresar contrasena";
            textBoxContrasena.Size = new Size(331, 23);
            textBoxContrasena.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(561, 56);
            button1.Name = "button1";
            button1.Size = new Size(135, 91);
            button1.TabIndex = 5;
            button1.Text = "Generar usuario invitado para ingreso como comprador\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // buttonCompletarVendedor
            // 
            buttonCompletarVendedor.BackColor = SystemColors.ButtonHighlight;
            buttonCompletarVendedor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCompletarVendedor.Location = new Point(561, 167);
            buttonCompletarVendedor.Name = "buttonCompletarVendedor";
            buttonCompletarVendedor.Size = new Size(135, 103);
            buttonCompletarVendedor.TabIndex = 6;
            buttonCompletarVendedor.Text = "Generar usuario invitado para ingreso como vendedor\r\n";
            buttonCompletarVendedor.UseVisualStyleBackColor = false;
            buttonCompletarVendedor.Click += buttonCompletarVendedor_Click;
            // 
            // FrmIniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCompletarVendedor);
            Controls.Add(button1);
            Controls.Add(textBoxContrasena);
            Controls.Add(textBoxEmail);
            Controls.Add(buttonIniciarSesion);
            Name = "FrmIniciarSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonIniciarSesion;
        private TextBox textBoxEmail;
        private TextBox textBoxContrasena;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button buttonCompletarVendedor;
    }
}