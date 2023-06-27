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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendedor));
            comboBoxCortePrecio = new ComboBox();
            textBoxPrecio = new TextBox();
            label2 = new Label();
            button2 = new Button();
            groupBox4 = new GroupBox();
            buttonVenderListaDeClientes = new Button();
            label3 = new Label();
            numericUpDownKilosVenta = new NumericUpDown();
            comboBoxCortesVenta = new ComboBox();
            comboBoxRestaurante = new ComboBox();
            buttonRetornarMenuPrincipal = new Button();
            buttonAutocompletar = new Button();
            dataGridView2 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            COMPRADOR = new DataGridViewTextBoxColumn();
            CORTE = new DataGridViewTextBoxColumn();
            KILOS = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            button_Leer = new Button();
            buttonBorrar = new Button();
            CORTECARNE = new DataGridViewTextBoxColumn();
            KG = new DataGridViewTextBoxColumn();
            Prec = new DataGridViewTextBoxColumn();
            numericUpDownKilos = new NumericUpDown();
            labelKilos = new Label();
            comboBoxNuevoCorte = new ComboBox();
            label1 = new Label();
            buttonClickIngresarMercaderia = new Button();
            buttonActualizarStock = new Button();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Peso = new DataGridViewTextBoxColumn();
            PrecioColumn = new DataGridViewTextBoxColumn();
            radioButtonAgregarCarne = new RadioButton();
            radioButtonQuitarCarne = new RadioButton();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxCortePrecio
            // 
            comboBoxCortePrecio.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxCortePrecio.FormattingEnabled = true;
            comboBoxCortePrecio.Items.AddRange(new object[] { "Asado", "Vacio", "Matambre", "Chorizo" });
            comboBoxCortePrecio.Location = new Point(70, 245);
            comboBoxCortePrecio.Name = "comboBoxCortePrecio";
            comboBoxCortePrecio.Size = new Size(156, 23);
            comboBoxCortePrecio.TabIndex = 4;
            comboBoxCortePrecio.Text = "Seleccionar corte";
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(70, 285);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PlaceholderText = "Seleccionar nuevo precio";
            textBoxPrecio.Size = new Size(156, 23);
            textBoxPrecio.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(66, 206);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 7;
            label2.Text = "Ingresar nuevos precios";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(150, 333);
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
            groupBox4.Location = new Point(352, 20);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(245, 183);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Vender a  tu lista de clientes";
            // 
            // buttonVenderListaDeClientes
            // 
            buttonVenderListaDeClientes.Cursor = Cursors.Hand;
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
            // buttonRetornarMenuPrincipal
            // 
            buttonRetornarMenuPrincipal.Location = new Point(1174, 409);
            buttonRetornarMenuPrincipal.Name = "buttonRetornarMenuPrincipal";
            buttonRetornarMenuPrincipal.Size = new Size(107, 54);
            buttonRetornarMenuPrincipal.TabIndex = 20;
            buttonRetornarMenuPrincipal.Text = "Volver al menu principal";
            buttonRetornarMenuPrincipal.UseVisualStyleBackColor = true;
            buttonRetornarMenuPrincipal.Click += buttonRetornarMenuPrincipal_Click;
            // 
            // buttonAutocompletar
            // 
            buttonAutocompletar.Cursor = Cursors.Hand;
            buttonAutocompletar.Location = new Point(70, 5);
            buttonAutocompletar.Name = "buttonAutocompletar";
            buttonAutocompletar.Size = new Size(150, 23);
            buttonAutocompletar.TabIndex = 21;
            buttonAutocompletar.Text = "AutoCompletarCampos";
            buttonAutocompletar.UseVisualStyleBackColor = true;
            buttonAutocompletar.Click += buttonAutocompletar_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ID, COMPRADOR, CORTE, KILOS, PRECIO });
            dataGridView2.Location = new Point(714, 20);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(542, 262);
            dataGridView2.TabIndex = 22;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // COMPRADOR
            // 
            COMPRADOR.HeaderText = "COMPRADOR";
            COMPRADOR.Name = "COMPRADOR";
            COMPRADOR.ReadOnly = true;
            // 
            // CORTE
            // 
            CORTE.HeaderText = "CORTE";
            CORTE.Name = "CORTE";
            CORTE.ReadOnly = true;
            // 
            // KILOS
            // 
            KILOS.HeaderText = "KILOS";
            KILOS.Name = "KILOS";
            KILOS.ReadOnly = true;
            // 
            // PRECIO
            // 
            PRECIO.HeaderText = "PRECIO";
            PRECIO.Name = "PRECIO";
            PRECIO.ReadOnly = true;
            // 
            // button_Leer
            // 
            button_Leer.Cursor = Cursors.Hand;
            button_Leer.Location = new Point(785, 302);
            button_Leer.Name = "button_Leer";
            button_Leer.Size = new Size(123, 54);
            button_Leer.TabIndex = 24;
            button_Leer.Text = "Ver Listado";
            button_Leer.UseVisualStyleBackColor = true;
            button_Leer.Click += button_Leer_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(955, 302);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(121, 54);
            buttonBorrar.TabIndex = 28;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // CORTECARNE
            // 
            CORTECARNE.HeaderText = "CORTE";
            CORTECARNE.Name = "CORTECARNE";
            CORTECARNE.ReadOnly = true;
            // 
            // KG
            // 
            KG.HeaderText = "KG";
            KG.Name = "KG";
            KG.ReadOnly = true;
            // 
            // Prec
            // 
            Prec.HeaderText = "PRECIO";
            Prec.Name = "Prec";
            Prec.ReadOnly = true;
            // 
            // numericUpDownKilos
            // 
            numericUpDownKilos.Location = new Point(178, 117);
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
            labelKilos.Location = new Point(131, 125);
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
            comboBoxNuevoCorte.Location = new Point(52, 72);
            comboBoxNuevoCorte.Name = "comboBoxNuevoCorte";
            comboBoxNuevoCorte.Size = new Size(174, 23);
            comboBoxNuevoCorte.TabIndex = 3;
            comboBoxNuevoCorte.Text = "Selecciona corte";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 49);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 6;
            label1.Text = "Ingresar/Quitar mercaderia";
            // 
            // buttonClickIngresarMercaderia
            // 
            buttonClickIngresarMercaderia.Cursor = Cursors.Hand;
            buttonClickIngresarMercaderia.Location = new Point(150, 159);
            buttonClickIngresarMercaderia.Name = "buttonClickIngresarMercaderia";
            buttonClickIngresarMercaderia.Size = new Size(75, 23);
            buttonClickIngresarMercaderia.TabIndex = 7;
            buttonClickIngresarMercaderia.Text = "Aceptar";
            buttonClickIngresarMercaderia.UseVisualStyleBackColor = true;
            buttonClickIngresarMercaderia.Click += button1_Click;
            // 
            // buttonActualizarStock
            // 
            buttonActualizarStock.Cursor = Cursors.Hand;
            buttonActualizarStock.Location = new Point(509, 408);
            buttonActualizarStock.Name = "buttonActualizarStock";
            buttonActualizarStock.Size = new Size(104, 55);
            buttonActualizarStock.TabIndex = 31;
            buttonActualizarStock.Text = "Actualizar Stock";
            buttonActualizarStock.UseVisualStyleBackColor = true;
            buttonActualizarStock.Click += buttonActualizarStock_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, Peso, PrecioColumn });
            dataGridView1.Location = new Point(286, 245);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(344, 145);
            dataGridView1.TabIndex = 32;
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
            // radioButtonAgregarCarne
            // 
            radioButtonAgregarCarne.AutoSize = true;
            radioButtonAgregarCarne.Location = new Point(26, 113);
            radioButtonAgregarCarne.Name = "radioButtonAgregarCarne";
            radioButtonAgregarCarne.Size = new Size(64, 19);
            radioButtonAgregarCarne.TabIndex = 33;
            radioButtonAgregarCarne.TabStop = true;
            radioButtonAgregarCarne.Text = "Agregar";
            radioButtonAgregarCarne.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuitarCarne
            // 
            radioButtonQuitarCarne.AutoSize = true;
            radioButtonQuitarCarne.Location = new Point(26, 138);
            radioButtonQuitarCarne.Name = "radioButtonQuitarCarne";
            radioButtonQuitarCarne.Size = new Size(57, 19);
            radioButtonQuitarCarne.TabIndex = 34;
            radioButtonQuitarCarne.TabStop = true;
            radioButtonQuitarCarne.Text = "Quitar";
            radioButtonQuitarCarne.UseVisualStyleBackColor = true;
            // 
            // FrmVendedor
            // 
            AutoScaleDimensions = new SizeF(6F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1279, 462);
            Controls.Add(radioButtonQuitarCarne);
            Controls.Add(radioButtonAgregarCarne);
            Controls.Add(dataGridView1);
            Controls.Add(buttonActualizarStock);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(buttonAutocompletar);
            Controls.Add(textBoxPrecio);
            Controls.Add(comboBoxCortePrecio);
            Controls.Add(buttonClickIngresarMercaderia);
            Controls.Add(label2);
            Controls.Add(buttonBorrar);
            Controls.Add(labelKilos);
            Controls.Add(comboBoxNuevoCorte);
            Controls.Add(numericUpDownKilos);
            Controls.Add(button_Leer);
            Controls.Add(dataGridView2);
            Controls.Add(buttonRetornarMenuPrincipal);
            Controls.Add(groupBox4);
            Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmVendedor";
            Load += FrmVendedor_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilosVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKilos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numericUpDownKilosVenta;
        private ComboBox comboBoxCortesVenta;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label2;
        private Button buttonVenderListaDeClientes;
        private Button button2;
        private Label label3;
        private Label label6;
        private GroupBox groupBox3;
        private Label label7;
        private Button button3;
        private TextBox textBoxPrecio;
        private ComboBox comboBoxCortePrecio;
        private GroupBox groupBox4;
        private ComboBox comboBoxRestaurante;
        private Label labelDetallesDeVenta;
        private TextBox textBoxDetalles;
        private Button buttonRetornarMenuPrincipal;
        private Button buttonAutocompletar;
        private DataGridView dataGridView2;
        private Button button_Leer;
        private DataGridView dataGridViewStock;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn COMPRADOR;
        private DataGridViewTextBoxColumn CORTE;
        private DataGridViewTextBoxColumn KILOS;
        private DataGridViewTextBoxColumn PRECIO;
        private Button buttonBorrar;
        private DataGridViewTextBoxColumn CORTECARNE;
        private DataGridViewTextBoxColumn KG;
        private DataGridViewTextBoxColumn Prec;
        private DataGridView dataGridViewStock_;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Kilos_;
        private DataGridViewTextBoxColumn PRECIO_;
        private DataGridView dataGridStock;
        private DataGridViewTextBoxColumn CorteCarne2;
        private DataGridViewTextBoxColumn Kilos2;
        private DataGridViewTextBoxColumn PRECIO2;
        private NumericUpDown numericUpDownKilos;
        private Label labelKilos;
        private ComboBox comboBoxNuevoCorte;
        private Label label1;
        private Button buttonClickIngresarMercaderia;
        private Button buttonActualizarStock;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn PrecioColumn;
        private RadioButton radioButtonAgregarCarne;
        private RadioButton radioButtonQuitarCarne;
    }
}