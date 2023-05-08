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
            numericUpDownKilosVacio = new NumericUpDown();
            numericUpDownKilosMatambre = new NumericUpDown();
            numericUpDownKilosChorizo = new NumericUpDown();
            label2 = new Label();
            buttonComprar = new Button();
            radioButtonEfectivo = new RadioButton();
            radioButtonTarjeta = new RadioButton();
            groupBox3 = new GroupBox();
            buttonAgregarMedioDePago = new Button();
            label3 = new Label();
            groupBoxDineroIngresado = new GroupBox();
            labelpPrecioDisponibleIngresado = new Label();
            groupBoxMedioDePago = new GroupBox();
            labelMedioDePago = new Label();
            checkBoxAsado = new CheckBox();
            checkBoxVacio = new CheckBox();
            checkBoxMatambre = new CheckBox();
            checkBoxChorizo = new CheckBox();
            buttonMenuPrincipal = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosAsado).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosVacio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosMatambre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosChorizo).BeginInit();
            groupBox3.SuspendLayout();
            groupBoxDineroIngresado.SuspendLayout();
            groupBoxMedioDePago.SuspendLayout();
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
            // buttonComprar
            // 
            buttonComprar.Location = new Point(454, 405);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(75, 23);
            buttonComprar.TabIndex = 26;
            buttonComprar.Text = "Comprar";
            buttonComprar.UseVisualStyleBackColor = true;
            buttonComprar.Click += button1_Click;
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
            radioButtonTarjeta.BackColor = Color.LightSalmon;
            radioButtonTarjeta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonTarjeta.Location = new Point(6, 22);
            radioButtonTarjeta.Name = "radioButtonTarjeta";
            radioButtonTarjeta.Size = new Size(73, 25);
            radioButtonTarjeta.TabIndex = 28;
            radioButtonTarjeta.TabStop = true;
            radioButtonTarjeta.Text = "Tarjeta";
            radioButtonTarjeta.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonAgregarMedioDePago);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(radioButtonTarjeta);
            groupBox3.Controls.Add(radioButtonEfectivo);
            groupBox3.Location = new Point(425, 47);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(198, 117);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "MEDIOS DE PAGO";
            // 
            // buttonAgregarMedioDePago
            // 
            buttonAgregarMedioDePago.Location = new Point(18, 78);
            buttonAgregarMedioDePago.Name = "buttonAgregarMedioDePago";
            buttonAgregarMedioDePago.Size = new Size(169, 23);
            buttonAgregarMedioDePago.TabIndex = 30;
            buttonAgregarMedioDePago.Text = "Agregar medio de pago";
            buttonAgregarMedioDePago.UseVisualStyleBackColor = true;
            buttonAgregarMedioDePago.Click += buttonAgregarMedioDePago_Click;
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
            // groupBoxDineroIngresado
            // 
            groupBoxDineroIngresado.Controls.Add(labelpPrecioDisponibleIngresado);
            groupBoxDineroIngresado.Location = new Point(394, 181);
            groupBoxDineroIngresado.Name = "groupBoxDineroIngresado";
            groupBoxDineroIngresado.Size = new Size(164, 56);
            groupBoxDineroIngresado.TabIndex = 31;
            groupBoxDineroIngresado.TabStop = false;
            groupBoxDineroIngresado.Text = "DINERO INGRESADO";
            // 
            // labelpPrecioDisponibleIngresado
            // 
            labelpPrecioDisponibleIngresado.AutoSize = true;
            labelpPrecioDisponibleIngresado.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelpPrecioDisponibleIngresado.Location = new Point(9, 19);
            labelpPrecioDisponibleIngresado.Name = "labelpPrecioDisponibleIngresado";
            labelpPrecioDisponibleIngresado.Size = new Size(157, 28);
            labelpPrecioDisponibleIngresado.TabIndex = 32;
            labelpPrecioDisponibleIngresado.Text = "No ha ingresado";
            // 
            // groupBoxMedioDePago
            // 
            groupBoxMedioDePago.Controls.Add(labelMedioDePago);
            groupBoxMedioDePago.Location = new Point(564, 181);
            groupBoxMedioDePago.Name = "groupBoxMedioDePago";
            groupBoxMedioDePago.Size = new Size(166, 56);
            groupBoxMedioDePago.TabIndex = 32;
            groupBoxMedioDePago.TabStop = false;
            groupBoxMedioDePago.Text = "MEDIO DE PAGO";
            // 
            // labelMedioDePago
            // 
            labelMedioDePago.AutoSize = true;
            labelMedioDePago.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelMedioDePago.Location = new Point(0, 19);
            labelMedioDePago.Name = "labelMedioDePago";
            labelMedioDePago.Size = new Size(167, 25);
            labelMedioDePago.TabIndex = 32;
            labelMedioDePago.Text = "No ha seleccionado";
            // 
            // checkBoxAsado
            // 
            checkBoxAsado.AutoSize = true;
            checkBoxAsado.Location = new Point(415, 283);
            checkBoxAsado.Name = "checkBoxAsado";
            checkBoxAsado.Size = new Size(59, 19);
            checkBoxAsado.TabIndex = 33;
            checkBoxAsado.Text = "Asado";
            checkBoxAsado.UseVisualStyleBackColor = true;
            // 
            // checkBoxVacio
            // 
            checkBoxVacio.AutoSize = true;
            checkBoxVacio.Location = new Point(415, 311);
            checkBoxVacio.Name = "checkBoxVacio";
            checkBoxVacio.Size = new Size(54, 19);
            checkBoxVacio.TabIndex = 34;
            checkBoxVacio.Text = "Vacio";
            checkBoxVacio.UseVisualStyleBackColor = true;
            // 
            // checkBoxMatambre
            // 
            checkBoxMatambre.AutoSize = true;
            checkBoxMatambre.Location = new Point(415, 341);
            checkBoxMatambre.Name = "checkBoxMatambre";
            checkBoxMatambre.Size = new Size(81, 19);
            checkBoxMatambre.TabIndex = 35;
            checkBoxMatambre.Text = "Matambre";
            checkBoxMatambre.UseVisualStyleBackColor = true;
            // 
            // checkBoxChorizo
            // 
            checkBoxChorizo.AutoSize = true;
            checkBoxChorizo.Location = new Point(415, 369);
            checkBoxChorizo.Name = "checkBoxChorizo";
            checkBoxChorizo.Size = new Size(67, 19);
            checkBoxChorizo.TabIndex = 36;
            checkBoxChorizo.Text = "Chorizo";
            checkBoxChorizo.UseVisualStyleBackColor = true;
            // 
            // buttonMenuPrincipal
            // 
            buttonMenuPrincipal.Location = new Point(650, 379);
            buttonMenuPrincipal.Name = "buttonMenuPrincipal";
            buttonMenuPrincipal.Size = new Size(94, 59);
            buttonMenuPrincipal.TabIndex = 37;
            buttonMenuPrincipal.Text = "Volver al menu principal";
            buttonMenuPrincipal.UseVisualStyleBackColor = true;
            buttonMenuPrincipal.Click += buttonMenuPrincipal_Click;
            // 
            // FrmComprador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(756, 450);
            Controls.Add(buttonMenuPrincipal);
            Controls.Add(checkBoxChorizo);
            Controls.Add(checkBoxMatambre);
            Controls.Add(checkBoxVacio);
            Controls.Add(checkBoxAsado);
            Controls.Add(groupBoxMedioDePago);
            Controls.Add(groupBoxDineroIngresado);
            Controls.Add(groupBox3);
            Controls.Add(buttonComprar);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(numericUpDownKilosChorizo);
            Controls.Add(numericUpDownKilosMatambre);
            Controls.Add(numericUpDownKilosVacio);
            Controls.Add(numericUpDownKilosAsado);
            Controls.Add(groupBox1);
            Controls.Add(labelBienvenido);
            Name = "FrmComprador";
            Load += FrmComprador_Load;
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
            groupBoxDineroIngresado.ResumeLayout(false);
            groupBoxDineroIngresado.PerformLayout();
            groupBoxMedioDePago.ResumeLayout(false);
            groupBoxMedioDePago.PerformLayout();
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
        private GroupBox groupBoxDineroIngresado;
        private Label labelpPrecioDisponibleIngresado;
        private Button buttonAgregarMedioDePago;
        private GroupBox groupBoxMedioDePago;
        private Label labelMedioDePago;
        private Button buttonComprar;
        private CheckBox checkBoxAsado;
        private CheckBox checkBoxVacio;
        private CheckBox checkBoxMatambre;
        private CheckBox checkBoxChorizo;
        private Button buttonMenuPrincipal;
    }
}