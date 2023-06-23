namespace FrmCarniceria
{
    partial class FrmCrearUsuario
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
            textBox_Usuario = new TextBox();
            textBoxContrasena = new TextBox();
            comboBox1 = new ComboBox();
            buttonCrearUsuario = new Button();
            SuspendLayout();
            // 
            // textBox_Usuario
            // 
            textBox_Usuario.Location = new Point(40, 59);
            textBox_Usuario.Name = "textBox_Usuario";
            textBox_Usuario.PlaceholderText = "Ingrese su usuario";
            textBox_Usuario.Size = new Size(205, 23);
            textBox_Usuario.TabIndex = 0;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Location = new Point(40, 100);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.PasswordChar = '*';
            textBoxContrasena.PlaceholderText = "Ingrese su contrasena";
            textBoxContrasena.Size = new Size(205, 23);
            textBoxContrasena.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Comprador", "Vendedor" });
            comboBox1.Location = new Point(40, 143);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 23);
            comboBox1.TabIndex = 2;
            // 
            // buttonCrearUsuario
            // 
            buttonCrearUsuario.Location = new Point(71, 184);
            buttonCrearUsuario.Name = "buttonCrearUsuario";
            buttonCrearUsuario.Size = new Size(118, 32);
            buttonCrearUsuario.TabIndex = 3;
            buttonCrearUsuario.Text = "Crear Usuario";
            buttonCrearUsuario.UseVisualStyleBackColor = true;
            buttonCrearUsuario.Click += buttonCrearUsuario_Click;
            // 
            // FrmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 228);
            Controls.Add(buttonCrearUsuario);
            Controls.Add(comboBox1);
            Controls.Add(textBoxContrasena);
            Controls.Add(textBox_Usuario);
            Name = "FrmCrearUsuario";
            Text = "FrmCrearUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Usuario;
        private TextBox textBoxContrasena;
        private ComboBox comboBox1;
        private Button buttonCrearUsuario;
    }
}