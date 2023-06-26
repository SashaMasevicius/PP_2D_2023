namespace FrmCarniceria
{
    partial class Ticket
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
            buttonAceptarCompra = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonAceptarCompra
            // 
            buttonAceptarCompra.Location = new Point(96, 191);
            buttonAceptarCompra.Name = "buttonAceptarCompra";
            buttonAceptarCompra.Size = new Size(92, 43);
            buttonAceptarCompra.TabIndex = 0;
            buttonAceptarCompra.Text = "ACEPTAR";
            buttonAceptarCompra.UseVisualStyleBackColor = true;
            buttonAceptarCompra.Click += buttonAceptarCompra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(71, 43);
            label1.Name = "label1";
            label1.Size = new Size(0, 16);
            label1.TabIndex = 2;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 246);
            Controls.Add(label1);
            Controls.Add(buttonAceptarCompra);
            Name = "Ticket";
            Text = "Ticket";
            TopMost = true;
            Load += Ticket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAceptarCompra;
        private Button buttonCancelarCompra;
        private Label label1;
    }
}