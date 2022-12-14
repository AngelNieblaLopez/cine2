
namespace UI.WinForm.Forms.Sells
{
    partial class FormMainSells
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxCantBoletos = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtBoxRoom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxAsientosSeleccionados = new System.Windows.Forms.TextBox();
            this.comboBoxSeats = new System.Windows.Forms.ComboBox();
            this.btnAddSeat = new System.Windows.Forms.Button();
            this.comboBoxSchedule = new System.Windows.Forms.ComboBox();
            this.comboBoxBillboard = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta de boletos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cartelera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad boletos";
            // 
            // txtBoxCantBoletos
            // 
            this.txtBoxCantBoletos.Location = new System.Drawing.Point(5, 187);
            this.txtBoxCantBoletos.Name = "txtBoxCantBoletos";
            this.txtBoxCantBoletos.Size = new System.Drawing.Size(175, 20);
            this.txtBoxCantBoletos.TabIndex = 7;
            this.txtBoxCantBoletos.TextChanged += new System.EventHandler(this.txtBoxCantBoletos_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(406, 337);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(141, 55);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtBoxRoom
            // 
            this.txtBoxRoom.Enabled = false;
            this.txtBoxRoom.Location = new System.Drawing.Point(5, 142);
            this.txtBoxRoom.Name = "txtBoxRoom";
            this.txtBoxRoom.Size = new System.Drawing.Size(175, 20);
            this.txtBoxRoom.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sala";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "$0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "$0.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Costo unitario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(16, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 71);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Acientos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxAsientosSeleccionados);
            this.groupBox2.Controls.Add(this.comboBoxSeats);
            this.groupBox2.Controls.Add(this.btnAddSeat);
            this.groupBox2.Controls.Add(this.comboBoxSchedule);
            this.groupBox2.Controls.Add(this.comboBoxBillboard);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBoxRoom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBoxCantBoletos);
            this.groupBox2.Location = new System.Drawing.Point(16, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 327);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtBoxAsientosSeleccionados
            // 
            this.txtBoxAsientosSeleccionados.Enabled = false;
            this.txtBoxAsientosSeleccionados.Location = new System.Drawing.Point(5, 300);
            this.txtBoxAsientosSeleccionados.Name = "txtBoxAsientosSeleccionados";
            this.txtBoxAsientosSeleccionados.Size = new System.Drawing.Size(180, 20);
            this.txtBoxAsientosSeleccionados.TabIndex = 22;
            // 
            // comboBoxSeats
            // 
            this.comboBoxSeats.FormattingEnabled = true;
            this.comboBoxSeats.Location = new System.Drawing.Point(5, 247);
            this.comboBoxSeats.Name = "comboBoxSeats";
            this.comboBoxSeats.Size = new System.Drawing.Size(180, 21);
            this.comboBoxSeats.TabIndex = 19;
            // 
            // btnAddSeat
            // 
            this.btnAddSeat.Location = new System.Drawing.Point(84, 271);
            this.btnAddSeat.Name = "btnAddSeat";
            this.btnAddSeat.Size = new System.Drawing.Size(101, 23);
            this.btnAddSeat.TabIndex = 21;
            this.btnAddSeat.Text = "Añadir / Eliminar";
            this.btnAddSeat.UseVisualStyleBackColor = true;
            this.btnAddSeat.Click += new System.EventHandler(this.btnAddSeat_Click);
            // 
            // comboBoxSchedule
            // 
            this.comboBoxSchedule.FormattingEnabled = true;
            this.comboBoxSchedule.Location = new System.Drawing.Point(5, 86);
            this.comboBoxSchedule.Name = "comboBoxSchedule";
            this.comboBoxSchedule.Size = new System.Drawing.Size(175, 21);
            this.comboBoxSchedule.TabIndex = 20;
            this.comboBoxSchedule.SelectedIndexChanged += new System.EventHandler(this.comboBoxSchedule_SelectedIndexChanged);
            // 
            // comboBoxBillboard
            // 
            this.comboBoxBillboard.FormattingEnabled = true;
            this.comboBoxBillboard.Location = new System.Drawing.Point(5, 32);
            this.comboBoxBillboard.Name = "comboBoxBillboard";
            this.comboBoxBillboard.Size = new System.Drawing.Size(175, 21);
            this.comboBoxBillboard.TabIndex = 19;
            this.comboBoxBillboard.SelectedIndexChanged += new System.EventHandler(this.comboBoxBillboard_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(503, 103);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 20;
            // 
            // FormMainSells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Name = "FormMainSells";
            this.Text = "FormMainSells";
            this.Load += new System.EventHandler(this.FormMainSells_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxCantBoletos;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtBoxRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxBillboard;
        private System.Windows.Forms.ComboBox comboBoxSchedule;
        private System.Windows.Forms.ComboBox comboBoxSeats;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox txtBoxAsientosSeleccionados;
        private System.Windows.Forms.Button btnAddSeat;
    }
}