namespace FrmCarniceria
{
    partial class FrmCliente
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
            textBoxDinero = new TextBox();
            buttonDineroDisponible = new Button();
            radioButtonTarjeta = new RadioButton();
            radioButtonEfectivo = new RadioButton();
            label1 = new Label();
            checkBoxAsado = new CheckBox();
            checkBoxVacio = new CheckBox();
            checkBoxMatambre = new CheckBox();
            checkBoxChorizo = new CheckBox();
            numericUpDownAsado = new NumericUpDown();
            numericUpDownVacio = new NumericUpDown();
            numericUpDownMatambre = new NumericUpDown();
            numericUpDownChorizo = new NumericUpDown();
            buttonComprar = new Button();
            dataGridView12 = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Peso = new DataGridViewTextBoxColumn();
            PrecioColumn = new DataGridViewTextBoxColumn();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAsado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVacio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMatambre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChorizo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // textBoxDinero
            // 
            textBoxDinero.Location = new Point(18, 29);
            textBoxDinero.Name = "textBoxDinero";
            textBoxDinero.PlaceholderText = "Minimo $1000";
            textBoxDinero.Size = new Size(155, 23);
            textBoxDinero.TabIndex = 0;
            // 
            // buttonDineroDisponible
            // 
            buttonDineroDisponible.Location = new Point(50, 71);
            buttonDineroDisponible.Name = "buttonDineroDisponible";
            buttonDineroDisponible.Size = new Size(75, 23);
            buttonDineroDisponible.TabIndex = 1;
            buttonDineroDisponible.Text = "Agregar";
            buttonDineroDisponible.UseVisualStyleBackColor = true;
            buttonDineroDisponible.Click += buttonDineroDisponible_Click;
            // 
            // radioButtonTarjeta
            // 
            radioButtonTarjeta.AutoSize = true;
            radioButtonTarjeta.Location = new Point(8, 33);
            radioButtonTarjeta.Name = "radioButtonTarjeta";
            radioButtonTarjeta.Size = new Size(59, 19);
            radioButtonTarjeta.TabIndex = 2;
            radioButtonTarjeta.TabStop = true;
            radioButtonTarjeta.Text = "Tarjeta";
            radioButtonTarjeta.UseVisualStyleBackColor = true;
            // 
            // radioButtonEfectivo
            // 
            radioButtonEfectivo.AutoSize = true;
            radioButtonEfectivo.Location = new Point(8, 58);
            radioButtonEfectivo.Name = "radioButtonEfectivo";
            radioButtonEfectivo.Size = new Size(67, 19);
            radioButtonEfectivo.TabIndex = 3;
            radioButtonEfectivo.TabStop = true;
            radioButtonEfectivo.Text = "Efectivo";
            radioButtonEfectivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(541, 164);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // checkBoxAsado
            // 
            checkBoxAsado.AutoSize = true;
            checkBoxAsado.Location = new Point(32, 61);
            checkBoxAsado.Name = "checkBoxAsado";
            checkBoxAsado.Size = new Size(59, 19);
            checkBoxAsado.TabIndex = 6;
            checkBoxAsado.Text = "Asado";
            checkBoxAsado.UseVisualStyleBackColor = true;
            // 
            // checkBoxVacio
            // 
            checkBoxVacio.AutoSize = true;
            checkBoxVacio.Location = new Point(32, 89);
            checkBoxVacio.Name = "checkBoxVacio";
            checkBoxVacio.Size = new Size(54, 19);
            checkBoxVacio.TabIndex = 7;
            checkBoxVacio.Text = "Vacio";
            checkBoxVacio.UseVisualStyleBackColor = true;
            // 
            // checkBoxMatambre
            // 
            checkBoxMatambre.AutoSize = true;
            checkBoxMatambre.Location = new Point(32, 117);
            checkBoxMatambre.Name = "checkBoxMatambre";
            checkBoxMatambre.Size = new Size(81, 19);
            checkBoxMatambre.TabIndex = 8;
            checkBoxMatambre.Text = "Matambre";
            checkBoxMatambre.UseVisualStyleBackColor = true;
            // 
            // checkBoxChorizo
            // 
            checkBoxChorizo.AutoSize = true;
            checkBoxChorizo.Location = new Point(32, 146);
            checkBoxChorizo.Name = "checkBoxChorizo";
            checkBoxChorizo.Size = new Size(67, 19);
            checkBoxChorizo.TabIndex = 9;
            checkBoxChorizo.Text = "Chorizo";
            checkBoxChorizo.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAsado
            // 
            numericUpDownAsado.Location = new Point(121, 57);
            numericUpDownAsado.Name = "numericUpDownAsado";
            numericUpDownAsado.Size = new Size(35, 23);
            numericUpDownAsado.TabIndex = 10;
            // 
            // numericUpDownVacio
            // 
            numericUpDownVacio.Location = new Point(121, 84);
            numericUpDownVacio.Name = "numericUpDownVacio";
            numericUpDownVacio.Size = new Size(35, 23);
            numericUpDownVacio.TabIndex = 11;
            // 
            // numericUpDownMatambre
            // 
            numericUpDownMatambre.Location = new Point(121, 113);
            numericUpDownMatambre.Name = "numericUpDownMatambre";
            numericUpDownMatambre.Size = new Size(35, 23);
            numericUpDownMatambre.TabIndex = 12;
            // 
            // numericUpDownChorizo
            // 
            numericUpDownChorizo.Location = new Point(121, 142);
            numericUpDownChorizo.Name = "numericUpDownChorizo";
            numericUpDownChorizo.Size = new Size(35, 23);
            numericUpDownChorizo.TabIndex = 13;
            // 
            // buttonComprar
            // 
            buttonComprar.Location = new Point(81, 183);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(75, 23);
            buttonComprar.TabIndex = 14;
            buttonComprar.Text = "Comprar";
            buttonComprar.UseVisualStyleBackColor = true;
            buttonComprar.Click += buttonComprar_Click;
            // 
            // dataGridView12
            // 
            dataGridView12.BackgroundColor = Color.LightCoral;
            dataGridView12.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView12.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, Peso, PrecioColumn });
            dataGridView12.EnableHeadersVisualStyles = false;
            dataGridView12.GridColor = Color.LightCoral;
            dataGridView12.Location = new Point(43, 186);
            dataGridView12.Name = "dataGridView12";
            dataGridView12.RowTemplate.Height = 25;
            dataGridView12.Size = new Size(333, 142);
            dataGridView12.TabIndex = 42;
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PedidosYa;
            pictureBox2.Location = new Point(222, 345);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(208, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CuentaDni;
            pictureBox1.Location = new Point(-3, 345);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxDinero);
            groupBox1.Controls.Add(buttonDineroDisponible);
            groupBox1.Cursor = Cursors.Hand;
            groupBox1.Location = new Point(397, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(185, 108);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar Dinero";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(radioButtonTarjeta);
            groupBox2.Controls.Add(radioButtonEfectivo);
            groupBox2.Cursor = Cursors.Hand;
            groupBox2.Location = new Point(411, 201);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(171, 100);
            groupBox2.TabIndex = 47;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medios De Pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(89, 35);
            label2.Name = "label2";
            label2.Size = new Size(67, 13);
            label2.TabIndex = 48;
            label2.Text = "5% Recargo";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonComprar);
            groupBox3.Controls.Add(numericUpDownChorizo);
            groupBox3.Controls.Add(numericUpDownMatambre);
            groupBox3.Controls.Add(numericUpDownVacio);
            groupBox3.Controls.Add(numericUpDownAsado);
            groupBox3.Controls.Add(checkBoxChorizo);
            groupBox3.Controls.Add(checkBoxMatambre);
            groupBox3.Controls.Add(checkBoxVacio);
            groupBox3.Controls.Add(checkBoxAsado);
            groupBox3.Cursor = Cursors.Hand;
            groupBox3.Location = new Point(617, 61);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(171, 240);
            groupBox3.TabIndex = 48;
            groupBox3.TabStop = false;
            groupBox3.Text = "Selecciona corte y Kg";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(725, 377);
            button1.Name = "button1";
            button1.Size = new Size(75, 73);
            button1.TabIndex = 49;
            button1.Text = "Volver al menu principal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(488, 12);
            button2.Name = "button2";
            button2.Size = new Size(157, 38);
            button2.TabIndex = 50;
            button2.Text = "AutoCompletarDatos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Carniceria222;
            pictureBox3.Location = new Point(43, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(333, 157);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 51;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.cortesAsado;
            pictureBox4.Location = new Point(447, 310);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(266, 143);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 52;
            pictureBox4.TabStop = false;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridView12);
            Controls.Add(label1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAsado).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVacio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMatambre).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChorizo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDinero;
        private Button buttonDineroDisponible;
        private RadioButton radioButtonTarjeta;
        private RadioButton radioButtonEfectivo;
        private Label label1;
        private CheckBox checkBoxAsado;
        private CheckBox checkBoxVacio;
        private CheckBox checkBoxMatambre;
        private CheckBox checkBoxChorizo;
        private NumericUpDown numericUpDownAsado;
        private NumericUpDown numericUpDownVacio;
        private NumericUpDown numericUpDownMatambre;
        private NumericUpDown numericUpDownChorizo;
        private Button buttonComprar;
        private DataGridView dataGridView12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn PrecioColumn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private GroupBox groupBox3;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}