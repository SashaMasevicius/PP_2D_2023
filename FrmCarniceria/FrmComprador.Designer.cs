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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComprador));
            textBoxDineroDisponible = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            buttonAceptarDineroDisponible = new Button();
            numericUpDownKilosAsado = new NumericUpDown();
            numericUpDownKilosVacio = new NumericUpDown();
            numericUpDownKilosMatambre = new NumericUpDown();
            numericUpDownKilosChorizo = new NumericUpDown();
            label2 = new Label();
            buttonComprar = new Button();
            radioButtonEfectivo = new RadioButton();
            radioButtonTarjeta = new RadioButton();
            groupBox3 = new GroupBox();
            label3 = new Label();
            groupBoxDineroIngresado = new GroupBox();
            labelpPrecioDisponibleIngresado = new Label();
            checkBoxAsado = new CheckBox();
            checkBoxVacio = new CheckBox();
            checkBoxMatambre = new CheckBox();
            checkBoxChorizo = new CheckBox();
            buttonMenuPrincipal = new Button();
            buttonAutoCompletDatos = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Peso = new DataGridViewTextBoxColumn();
            PrecioColumn = new DataGridViewTextBoxColumn();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosAsado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosVacio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosMatambre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosChorizo).BeginInit();
            groupBox3.SuspendLayout();
            groupBoxDineroIngresado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonAceptarDineroDisponible);
            groupBox1.Controls.Add(textBoxDineroDisponible);
            groupBox1.Location = new Point(50, 69);
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
            numericUpDownKilosAsado.Location = new Point(622, 279);
            numericUpDownKilosAsado.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownKilosAsado.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKilosAsado.Name = "numericUpDownKilosAsado";
            numericUpDownKilosAsado.Size = new Size(48, 23);
            numericUpDownKilosAsado.TabIndex = 17;
            numericUpDownKilosAsado.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownKilosVacio
            // 
            numericUpDownKilosVacio.Location = new Point(622, 307);
            numericUpDownKilosVacio.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownKilosVacio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKilosVacio.Name = "numericUpDownKilosVacio";
            numericUpDownKilosVacio.Size = new Size(48, 23);
            numericUpDownKilosVacio.TabIndex = 22;
            numericUpDownKilosVacio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownKilosMatambre
            // 
            numericUpDownKilosMatambre.Location = new Point(622, 336);
            numericUpDownKilosMatambre.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownKilosMatambre.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKilosMatambre.Name = "numericUpDownKilosMatambre";
            numericUpDownKilosMatambre.Size = new Size(48, 23);
            numericUpDownKilosMatambre.TabIndex = 23;
            numericUpDownKilosMatambre.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownKilosChorizo
            // 
            numericUpDownKilosChorizo.Location = new Point(622, 369);
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
            label2.Location = new Point(506, 243);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 25;
            label2.Text = "Seleccionar corte y kilos";
            // 
            // buttonComprar
            // 
            buttonComprar.Location = new Point(558, 407);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(81, 32);
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
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(radioButtonTarjeta);
            groupBox3.Controls.Add(radioButtonEfectivo);
            groupBox3.Location = new Point(506, 69);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(251, 117);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "MEDIOS DE PAGO";
            groupBox3.Enter += groupBox3_Enter;
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
            groupBoxDineroIngresado.Location = new Point(506, 192);
            groupBoxDineroIngresado.Name = "groupBoxDineroIngresado";
            groupBoxDineroIngresado.Size = new Size(198, 56);
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
            // checkBoxAsado
            // 
            checkBoxAsado.AutoSize = true;
            checkBoxAsado.Location = new Point(526, 279);
            checkBoxAsado.Name = "checkBoxAsado";
            checkBoxAsado.Size = new Size(59, 19);
            checkBoxAsado.TabIndex = 33;
            checkBoxAsado.Text = "Asado";
            checkBoxAsado.UseVisualStyleBackColor = true;
            // 
            // checkBoxVacio
            // 
            checkBoxVacio.AutoSize = true;
            checkBoxVacio.Location = new Point(527, 311);
            checkBoxVacio.Name = "checkBoxVacio";
            checkBoxVacio.Size = new Size(54, 19);
            checkBoxVacio.TabIndex = 34;
            checkBoxVacio.Text = "Vacio";
            checkBoxVacio.UseVisualStyleBackColor = true;
            // 
            // checkBoxMatambre
            // 
            checkBoxMatambre.AutoSize = true;
            checkBoxMatambre.Location = new Point(527, 340);
            checkBoxMatambre.Name = "checkBoxMatambre";
            checkBoxMatambre.Size = new Size(81, 19);
            checkBoxMatambre.TabIndex = 35;
            checkBoxMatambre.Text = "Matambre";
            checkBoxMatambre.UseVisualStyleBackColor = true;
            // 
            // checkBoxChorizo
            // 
            checkBoxChorizo.AutoSize = true;
            checkBoxChorizo.Location = new Point(527, 373);
            checkBoxChorizo.Name = "checkBoxChorizo";
            checkBoxChorizo.Size = new Size(67, 19);
            checkBoxChorizo.TabIndex = 36;
            checkBoxChorizo.Text = "Chorizo";
            checkBoxChorizo.UseVisualStyleBackColor = true;
            // 
            // buttonMenuPrincipal
            // 
            buttonMenuPrincipal.Location = new Point(688, 407);
            buttonMenuPrincipal.Name = "buttonMenuPrincipal";
            buttonMenuPrincipal.Size = new Size(106, 86);
            buttonMenuPrincipal.TabIndex = 37;
            buttonMenuPrincipal.Text = "Volver al menu principal";
            buttonMenuPrincipal.UseVisualStyleBackColor = true;
            buttonMenuPrincipal.Click += buttonMenuPrincipal_Click;
            // 
            // buttonAutoCompletDatos
            // 
            buttonAutoCompletDatos.Location = new Point(103, 12);
            buttonAutoCompletDatos.Name = "buttonAutoCompletDatos";
            buttonAutoCompletDatos.Size = new Size(137, 44);
            buttonAutoCompletDatos.TabIndex = 38;
            buttonAutoCompletDatos.Text = "AutoCompletarDatos";
            buttonAutoCompletDatos.UseVisualStyleBackColor = true;
            buttonAutoCompletDatos.Click += buttonAutoCompletDatos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CuentaDni;
            pictureBox1.Location = new Point(-4, 388);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PedidosYa;
            pictureBox2.Location = new Point(215, 385);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(208, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, Peso, PrecioColumn });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ButtonFace;
            dataGridView1.Location = new Point(23, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(333, 142);
            dataGridView1.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Cortes";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Peso
            // 
            Peso.HeaderText = "Peso";
            Peso.Name = "Peso";
            Peso.ReadOnly = true;
            // 
            // PrecioColumn
            // 
            PrecioColumn.HeaderText = "Precio";
            PrecioColumn.Name = "PrecioColumn";
            PrecioColumn.ReadOnly = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(347, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(110, 34);
            listBox1.TabIndex = 42;
            // 
            // FrmComprador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(794, 493);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonAutoCompletDatos);
            Controls.Add(buttonMenuPrincipal);
            Controls.Add(checkBoxChorizo);
            Controls.Add(checkBoxMatambre);
            Controls.Add(checkBoxVacio);
            Controls.Add(checkBoxAsado);
            Controls.Add(groupBoxDineroIngresado);
            Controls.Add(groupBox3);
            Controls.Add(buttonComprar);
            Controls.Add(label2);
            Controls.Add(numericUpDownKilosChorizo);
            Controls.Add(numericUpDownKilosMatambre);
            Controls.Add(numericUpDownKilosVacio);
            Controls.Add(numericUpDownKilosAsado);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmComprador";
            TopMost = true;
            Load += FrmComprador_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosAsado).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosVacio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosMatambre).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosChorizo).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBoxDineroIngresado.ResumeLayout(false);
            groupBoxDineroIngresado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3Asado;
        private TextBox textBoxDineroDisponible;
        private GroupBox groupBox1;
        private Button buttonAceptarDineroDisponible;
        private Label label1;
        private NumericUpDown numericUpDownKilosAsado;
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
        private GroupBox groupBoxMedioDePago;
        private Label labelMedioDePago;
        private Button buttonComprar;
        private CheckBox checkBoxAsado;
        private CheckBox checkBoxVacio;
        private CheckBox checkBoxMatambre;
        private CheckBox checkBoxChorizo;
        private Button buttonMenuPrincipal;
        private Button buttonAutoCompletDatos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn PrecioColumn;
        private ListBox listBox1;
    }
}