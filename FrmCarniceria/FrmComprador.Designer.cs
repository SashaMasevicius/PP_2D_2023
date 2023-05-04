namespace FrmCarniceria
{
    partial class FrmComprador
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
            labelBienvenido = new Label();
            textBoxDineroDisponible = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            buttonAceptarDineroDisponible = new Button();
            numericUpDownKilosAsado = new NumericUpDown();
            labelDatos = new Label();
            groupBox2 = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            numericUpDownKilosVacio = new NumericUpDown();
            numericUpDownKilosMatambre = new NumericUpDown();
            numericUpDownKilosChorizo = new NumericUpDown();
            label2 = new Label();
            button1 = new Button();
            radioButtonEfectivo = new RadioButton();
            radioButtonTarjeta = new RadioButton();
            groupBox3 = new GroupBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            label4pPrecioDisponibleIngresado = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosAsado).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosVacio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosMatambre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosChorizo).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // labelBienvenido
            // 
            labelBienvenido.AutoSize = true;
            labelBienvenido.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelBienvenido.Location = new Point(145, 9);
            labelBienvenido.Name = "labelBienvenido";
            labelBienvenido.Size = new Size(149, 37);
            labelBienvenido.TabIndex = 1;
            labelBienvenido.Text = "Bienvenido";
            labelBienvenido.Click += labelBienvenido_Click;
            // 
            // textBoxDineroDisponible
            // 
            textBoxDineroDisponible.BackColor = SystemColors.Window;
            textBoxDineroDisponible.Location = new Point(17, 42);
            textBoxDineroDisponible.Name = "textBoxDineroDisponible";
            textBoxDineroDisponible.PlaceholderText = "Ingresar solo numeros";
            textBoxDineroDisponible.ReadOnly = true;
            textBoxDineroDisponible.Size = new Size(191, 23);
            textBoxDineroDisponible.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonAceptarDineroDisponible);
            groupBox1.Controls.Add(textBoxDineroDisponible);
            groupBox1.Location = new Point(54, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 146);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar dinero disponible para comprar";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 73);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 4;
            label1.Text = "Min dinero para cargar: 1000";
            // 
            // buttonAceptarDineroDisponible
            // 
            buttonAceptarDineroDisponible.Location = new Point(165, 105);
            buttonAceptarDineroDisponible.Name = "buttonAceptarDineroDisponible";
            buttonAceptarDineroDisponible.Size = new Size(75, 23);
            buttonAceptarDineroDisponible.TabIndex = 3;
            buttonAceptarDineroDisponible.Text = "Agregar dinero";
            buttonAceptarDineroDisponible.UseVisualStyleBackColor = true;
            buttonAceptarDineroDisponible.Click += buttonAceptarDineroDisponible_Click;
            // 
            // numericUpDownKilosAsado
            // 
            numericUpDownKilosAsado.Location = new Point(544, 282);
            numericUpDownKilosAsado.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownKilosAsado.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKilosAsado.Name = "numericUpDownKilosAsado";
            numericUpDownKilosAsado.Size = new Size(48, 23);
            numericUpDownKilosAsado.TabIndex = 17;
            numericUpDownKilosAsado.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelDatos
            // 
            labelDatos.AutoSize = true;
            labelDatos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelDatos.Location = new Point(52, 42);
            labelDatos.Name = "labelDatos";
            labelDatos.Size = new Size(48, 20);
            labelDatos.TabIndex = 19;
            labelDatos.Text = "Datos";
            labelDatos.Click += labelDatos_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelDatos);
            groupBox2.Location = new Point(54, 243);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(249, 185);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stock de la carniceria";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.Menu;
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Asado", "Vacio", "Matambre", "Chorizo" });
            checkedListBox1.Location = new Point(403, 282);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(121, 104);
            checkedListBox1.TabIndex = 21;
            // 
            // numericUpDownKilosVacio
            // 
            numericUpDownKilosVacio.Location = new Point(544, 311);
            numericUpDownKilosVacio.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownKilosVacio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKilosVacio.Name = "numericUpDownKilosVacio";
            numericUpDownKilosVacio.Size = new Size(48, 23);
            numericUpDownKilosVacio.TabIndex = 22;
            numericUpDownKilosVacio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownKilosMatambre
            // 
            numericUpDownKilosMatambre.Location = new Point(544, 340);
            numericUpDownKilosMatambre.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownKilosMatambre.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKilosMatambre.Name = "numericUpDownKilosMatambre";
            numericUpDownKilosMatambre.Size = new Size(48, 23);
            numericUpDownKilosMatambre.TabIndex = 23;
            numericUpDownKilosMatambre.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownKilosChorizo
            // 
            numericUpDownKilosChorizo.Location = new Point(544, 369);
            numericUpDownKilosChorizo.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownKilosChorizo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKilosChorizo.Name = "numericUpDownKilosChorizo";
            numericUpDownKilosChorizo.Size = new Size(48, 23);
            numericUpDownKilosChorizo.TabIndex = 24;
            numericUpDownKilosChorizo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(464, 254);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 25;
            label2.Text = "Seleccionar corte y kilos";
            // 
            // button1
            // 
            button1.Location = new Point(578, 405);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 26;
            button1.Text = "Comprar";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButtonEfectivo
            // 
            radioButtonEfectivo.AutoSize = true;
            radioButtonEfectivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonEfectivo.Location = new Point(6, 53);
            radioButtonEfectivo.Name = "radioButtonEfectivo";
            radioButtonEfectivo.Size = new Size(82, 25);
            radioButtonEfectivo.TabIndex = 27;
            radioButtonEfectivo.TabStop = true;
            radioButtonEfectivo.Text = "Efectivo";
            radioButtonEfectivo.UseVisualStyleBackColor = true;
            radioButtonEfectivo.CheckedChanged += radioButtonEfectivo_CheckedChanged;
            // 
            // radioButtonTarjeta
            // 
            radioButtonTarjeta.AutoSize = true;
            radioButtonTarjeta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonTarjeta.Location = new Point(6, 22);
            radioButtonTarjeta.Name = "radioButtonTarjeta";
            radioButtonTarjeta.Size = new Size(73, 25);
            radioButtonTarjeta.TabIndex = 28;
            radioButtonTarjeta.TabStop = true;
            radioButtonTarjeta.Text = "Tarjeta";
            radioButtonTarjeta.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(radioButtonTarjeta);
            groupBox3.Controls.Add(radioButtonEfectivo);
            groupBox3.Location = new Point(425, 76);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(198, 88);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "MEDIOS DE PAGO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 29);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 29;
            label3.Text = "tarjeta 5% recargo";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4pPrecioDisponibleIngresado);
            groupBox4.Location = new Point(425, 181);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(155, 56);
            groupBox4.TabIndex = 31;
            groupBox4.TabStop = false;
            groupBox4.Text = "DINERO INGRESADO";
            // 
            // label4pPrecioDisponibleIngresado
            // 
            label4pPrecioDisponibleIngresado.AutoSize = true;
            label4pPrecioDisponibleIngresado.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4pPrecioDisponibleIngresado.Location = new Point(20, 19);
            label4pPrecioDisponibleIngresado.Name = "label4pPrecioDisponibleIngresado";
            label4pPrecioDisponibleIngresado.Size = new Size(67, 28);
            label4pPrecioDisponibleIngresado.TabIndex = 32;
            label4pPrecioDisponibleIngresado.Text = "00000";
            // 
            // FrmComprador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(numericUpDownKilosChorizo);
            Controls.Add(numericUpDownKilosMatambre);
            Controls.Add(numericUpDownKilosVacio);
            Controls.Add(checkedListBox1);
            Controls.Add(numericUpDownKilosAsado);
            Controls.Add(groupBox1);
            Controls.Add(labelBienvenido);
            Name = "FrmComprador";
            Text = "FrmComprador";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosAsado).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosVacio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosMatambre).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosChorizo).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3Asado;
        private Label labelBienvenido;
        private TextBox textBoxDineroDisponible;
        private GroupBox groupBox1;
        private Button buttonAceptarDineroDisponible;
        private Label label1;
        private NumericUpDown numericUpDownKilosAsado;
        private Label labelDatos;
        private GroupBox groupBox2;
        private CheckedListBox checkedListBox1;
        private NumericUpDown numericUpDownKilosVacio;
        private NumericUpDown numericUpDownKilosMatambre;
        private NumericUpDown numericUpDownKilosChorizo;
        private Label label2;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButtonEfectivo;
        private RadioButton radioButtonTarjeta;
        private GroupBox groupBox3;
        private Label label3;
        private GroupBox groupBox4;
        private Label label4pPrecioDisponibleIngresado;
    }
}