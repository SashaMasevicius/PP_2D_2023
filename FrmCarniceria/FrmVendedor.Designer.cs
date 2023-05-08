namespace FrmCarniceria
{
    partial class FrmVendedor
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
            numericUpDownKilos = new NumericUpDown();
            labelKilos = new Label();
            comboBoxNuevoCorte = new ComboBox();
            comboBoxCortePrecio = new ComboBox();
            textBoxPrecio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            buttonClickIngresarMercaderia = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            groupBox4 = new GroupBox();
            buttonVenderListaDeClientes = new Button();
            label3 = new Label();
            numericUpDownKilosVenta = new NumericUpDown();
            comboBoxCortesVenta = new ComboBox();
            comboBoxRestaurante = new ComboBox();
            labelDetalles = new Label();
            dataGridView1 = new DataGridView();
            Column_Comprador = new DataGridViewTextBoxColumn();
            Column_CorteVendido = new DataGridViewTextBoxColumn();
            Column_KilosVendidos = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownKilos
            // 
            numericUpDownKilos.Location = new Point(83, 101);
            numericUpDownKilos.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownKilos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKilos.Name = "numericUpDownKilos";
            numericUpDownKilos.Size = new Size(48, 23);
            numericUpDownKilos.TabIndex = 1;
            numericUpDownKilos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelKilos
            // 
            labelKilos.AutoSize = true;
            labelKilos.Location = new Point(47, 100);
            labelKilos.Name = "labelKilos";
            labelKilos.Size = new Size(30, 15);
            labelKilos.TabIndex = 2;
            labelKilos.Text = "Kilos";
            // 
            // comboBoxNuevoCorte
            // 
            comboBoxNuevoCorte.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxNuevoCorte.FormattingEnabled = true;
            comboBoxNuevoCorte.Items.AddRange(new object[] { "Asado", "Vacio", "Matambre", "Chorizo" });
            comboBoxNuevoCorte.Location = new Point(47, 62);
            comboBoxNuevoCorte.Name = "comboBoxNuevoCorte";
            comboBoxNuevoCorte.Size = new Size(174, 23);
            comboBoxNuevoCorte.TabIndex = 3;
            comboBoxNuevoCorte.Text = "Selecciona corte";
            // 
            // comboBoxCortePrecio
            // 
            comboBoxCortePrecio.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxCortePrecio.FormattingEnabled = true;
            comboBoxCortePrecio.Items.AddRange(new object[] { "Asado", "Vacio", "Matambre", "Chorizo" });
            comboBoxCortePrecio.Location = new Point(23, 55);
            comboBoxCortePrecio.Name = "comboBoxCortePrecio";
            comboBoxCortePrecio.Size = new Size(156, 23);
            comboBoxCortePrecio.TabIndex = 4;
            comboBoxCortePrecio.Text = "Seleccionar corte";
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(23, 93);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PlaceholderText = "Seleccionar nuevo precio";
            textBoxPrecio.Size = new Size(156, 23);
            textBoxPrecio.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 26);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 6;
            label1.Text = "Ingresar mercaderia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 19);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 7;
            label2.Text = "Ingresar nuevos precios";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonClickIngresarMercaderia);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxNuevoCorte);
            groupBox1.Controls.Add(labelKilos);
            groupBox1.Controls.Add(numericUpDownKilos);
            groupBox1.Location = new Point(20, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 179);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // buttonClickIngresarMercaderia
            // 
            buttonClickIngresarMercaderia.Location = new Point(168, 135);
            buttonClickIngresarMercaderia.Name = "buttonClickIngresarMercaderia";
            buttonClickIngresarMercaderia.Size = new Size(75, 23);
            buttonClickIngresarMercaderia.TabIndex = 7;
            buttonClickIngresarMercaderia.Text = "Aceptar";
            buttonClickIngresarMercaderia.UseVisualStyleBackColor = true;
            buttonClickIngresarMercaderia.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(comboBoxCortePrecio);
            groupBox2.Controls.Add(textBoxPrecio);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(376, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(221, 163);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(130, 128);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonVenderListaDeClientes);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(numericUpDownKilosVenta);
            groupBox4.Controls.Add(comboBoxCortesVenta);
            groupBox4.Controls.Add(comboBoxRestaurante);
            groupBox4.Location = new Point(31, 232);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(245, 197);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Vender a  tu lista de clientes";
            // 
            // buttonVenderListaDeClientes
            // 
            buttonVenderListaDeClientes.Location = new Point(157, 156);
            buttonVenderListaDeClientes.Name = "buttonVenderListaDeClientes";
            buttonVenderListaDeClientes.Size = new Size(75, 23);
            buttonVenderListaDeClientes.TabIndex = 7;
            buttonVenderListaDeClientes.Text = "Aceptar";
            buttonVenderListaDeClientes.UseVisualStyleBackColor = true;
            buttonVenderListaDeClientes.Click += buttonVenderListaDeClientes_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 130);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Kilos";
            // 
            // numericUpDownKilosVenta
            // 
            numericUpDownKilosVenta.Location = new Point(95, 128);
            numericUpDownKilosVenta.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownKilosVenta.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKilosVenta.Name = "numericUpDownKilosVenta";
            numericUpDownKilosVenta.Size = new Size(48, 23);
            numericUpDownKilosVenta.TabIndex = 5;
            numericUpDownKilosVenta.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownKilosVenta.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // comboBoxCortesVenta
            // 
            comboBoxCortesVenta.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxCortesVenta.FormattingEnabled = true;
            comboBoxCortesVenta.Items.AddRange(new object[] { "Asado", "Vacio", "Matambre", "Chorizo" });
            comboBoxCortesVenta.Location = new Point(35, 87);
            comboBoxCortesVenta.Name = "comboBoxCortesVenta";
            comboBoxCortesVenta.Size = new Size(175, 23);
            comboBoxCortesVenta.TabIndex = 4;
            comboBoxCortesVenta.Text = "Ingresar corte a vender";
            // 
            // comboBoxRestaurante
            // 
            comboBoxRestaurante.FormattingEnabled = true;
            comboBoxRestaurante.Items.AddRange(new object[] { "Restaurante Madero", "Restaurante Aleman", "Restaurante Venezolano" });
            comboBoxRestaurante.Location = new Point(36, 52);
            comboBoxRestaurante.Name = "comboBoxRestaurante";
            comboBoxRestaurante.Size = new Size(174, 23);
            comboBoxRestaurante.TabIndex = 0;
            comboBoxRestaurante.Text = "Seleccionar restaurante";
            // 
            // labelDetalles
            // 
            labelDetalles.AutoSize = true;
            labelDetalles.Font = new Font("Segoe UI Light", 11F, FontStyle.Italic, GraphicsUnit.Point);
            labelDetalles.Location = new Point(446, 284);
            labelDetalles.Name = "labelDetalles";
            labelDetalles.Size = new Size(40, 20);
            labelDetalles.TabIndex = 17;
            labelDetalles.Text = "stock";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column_Comprador, Column_CorteVendido, Column_KilosVendidos });
            dataGridView1.Location = new Point(688, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(345, 391);
            dataGridView1.TabIndex = 19;
            // 
            // Column_Comprador
            // 
            Column_Comprador.HeaderText = "Comprador";
            Column_Comprador.Name = "Column_Comprador";
            // 
            // Column_CorteVendido
            // 
            Column_CorteVendido.HeaderText = "Corte";
            Column_CorteVendido.Name = "Column_CorteVendido";
            // 
            // Column_KilosVendidos
            // 
            Column_KilosVendidos.HeaderText = "Kilos Vendidos";
            Column_KilosVendidos.Name = "Column_KilosVendidos";
            // 
            // FrmVendedor
            // 
            AutoScaleDimensions = new SizeF(6F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1165, 450);
            Controls.Add(dataGridView1);
            Controls.Add(labelDetalles);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Name = "FrmVendedor";
            Load += FrmVendedor_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numericUpDownKilosVenta;
        private Label labelKilos;
        private ComboBox comboBoxCortesVenta;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button buttonVenderListaDeClientes;
        private GroupBox groupBox2;
        private Button button2;
        private ComboBox comboBoxNuevoCorte;
        private Button buttonClickIngresarMercaderia;
        private NumericUpDown numericUpDownKilos;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox3;
        private Label label7;
        private Button button3;
        private TextBox textBoxPrecio;
        private ComboBox comboBoxCortePrecio;
        private GroupBox groupBox4;
        private ComboBox comboBoxRestaurante;
        private Label labelDetalles;
        private Label labelDetallesDeVenta;
        private TextBox textBoxDetalles;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column_Comprador;
        private DataGridViewTextBoxColumn Column_CorteVendido;
        private DataGridViewTextBoxColumn Column_KilosVendidos;
    }
}