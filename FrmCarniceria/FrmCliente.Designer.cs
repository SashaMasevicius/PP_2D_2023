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
            ((System.ComponentModel.ISupportInitialize)numericUpDownAsado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVacio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMatambre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChorizo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView12).BeginInit();
            SuspendLayout();
            // 
            // textBoxDinero
            // 
            textBoxDinero.Location = new Point(121, 58);
            textBoxDinero.Name = "textBoxDinero";
            textBoxDinero.Size = new Size(100, 23);
            textBoxDinero.TabIndex = 0;
            // 
            // buttonDineroDisponible
            // 
            buttonDineroDisponible.Location = new Point(131, 99);
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
            radioButtonTarjeta.Location = new Point(448, 72);
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
            radioButtonEfectivo.Location = new Point(448, 97);
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
            checkBoxAsado.Location = new Point(488, 235);
            checkBoxAsado.Name = "checkBoxAsado";
            checkBoxAsado.Size = new Size(59, 19);
            checkBoxAsado.TabIndex = 6;
            checkBoxAsado.Text = "Asado";
            checkBoxAsado.UseVisualStyleBackColor = true;
            // 
            // checkBoxVacio
            // 
            checkBoxVacio.AutoSize = true;
            checkBoxVacio.Location = new Point(488, 263);
            checkBoxVacio.Name = "checkBoxVacio";
            checkBoxVacio.Size = new Size(54, 19);
            checkBoxVacio.TabIndex = 7;
            checkBoxVacio.Text = "Vacio";
            checkBoxVacio.UseVisualStyleBackColor = true;
            // 
            // checkBoxMatambre
            // 
            checkBoxMatambre.AutoSize = true;
            checkBoxMatambre.Location = new Point(488, 291);
            checkBoxMatambre.Name = "checkBoxMatambre";
            checkBoxMatambre.Size = new Size(81, 19);
            checkBoxMatambre.TabIndex = 8;
            checkBoxMatambre.Text = "Matambre";
            checkBoxMatambre.UseVisualStyleBackColor = true;
            // 
            // checkBoxChorizo
            // 
            checkBoxChorizo.AutoSize = true;
            checkBoxChorizo.Location = new Point(488, 320);
            checkBoxChorizo.Name = "checkBoxChorizo";
            checkBoxChorizo.Size = new Size(67, 19);
            checkBoxChorizo.TabIndex = 9;
            checkBoxChorizo.Text = "Chorizo";
            checkBoxChorizo.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAsado
            // 
            numericUpDownAsado.Location = new Point(577, 231);
            numericUpDownAsado.Name = "numericUpDownAsado";
            numericUpDownAsado.Size = new Size(35, 23);
            numericUpDownAsado.TabIndex = 10;
            // 
            // numericUpDownVacio
            // 
            numericUpDownVacio.Location = new Point(577, 258);
            numericUpDownVacio.Name = "numericUpDownVacio";
            numericUpDownVacio.Size = new Size(35, 23);
            numericUpDownVacio.TabIndex = 11;
            // 
            // numericUpDownMatambre
            // 
            numericUpDownMatambre.Location = new Point(577, 287);
            numericUpDownMatambre.Name = "numericUpDownMatambre";
            numericUpDownMatambre.Size = new Size(35, 23);
            numericUpDownMatambre.TabIndex = 12;
            // 
            // numericUpDownChorizo
            // 
            numericUpDownChorizo.Location = new Point(577, 316);
            numericUpDownChorizo.Name = "numericUpDownChorizo";
            numericUpDownChorizo.Size = new Size(35, 23);
            numericUpDownChorizo.TabIndex = 13;
            // 
            // buttonComprar
            // 
            buttonComprar.Location = new Point(537, 357);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(75, 23);
            buttonComprar.TabIndex = 14;
            buttonComprar.Text = "Comprar";
            buttonComprar.UseVisualStyleBackColor = true;
            buttonComprar.Click += buttonComprar_Click;
            // 
            // dataGridView12
            // 
            dataGridView12.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView12.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView12.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, Peso, PrecioColumn });
            dataGridView12.EnableHeadersVisualStyles = false;
            dataGridView12.GridColor = SystemColors.ButtonFace;
            dataGridView12.Location = new Point(72, 197);
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
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView12);
            Controls.Add(buttonComprar);
            Controls.Add(numericUpDownChorizo);
            Controls.Add(numericUpDownMatambre);
            Controls.Add(numericUpDownVacio);
            Controls.Add(numericUpDownAsado);
            Controls.Add(checkBoxChorizo);
            Controls.Add(checkBoxMatambre);
            Controls.Add(checkBoxVacio);
            Controls.Add(checkBoxAsado);
            Controls.Add(label1);
            Controls.Add(radioButtonEfectivo);
            Controls.Add(radioButtonTarjeta);
            Controls.Add(buttonDineroDisponible);
            Controls.Add(textBoxDinero);
            Name = "FrmCliente";
            Text = "FrmCliente";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAsado).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVacio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMatambre).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownChorizo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView12).EndInit();
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
    }
}