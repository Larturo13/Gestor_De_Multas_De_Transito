
namespace Gestor_De_Multas_De_Transito.Grafico.Vehiculos
{
    partial class AsignarVehiculos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_DPI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nroPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Asigna = new System.Windows.Forms.DataGridView();
            this.btn_Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Asigna)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_DPI
            // 
            this.txt_DPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_DPI.Location = new System.Drawing.Point(188, 103);
            this.txt_DPI.Name = "txt_DPI";
            this.txt_DPI.Size = new System.Drawing.Size(309, 24);
            this.txt_DPI.TabIndex = 28;
            this.txt_DPI.Enter += new System.EventHandler(this.txt_DPI_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(61, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "DPI:";
            // 
            // txt_nroPlaca
            // 
            this.txt_nroPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_nroPlaca.Location = new System.Drawing.Point(188, 54);
            this.txt_nroPlaca.Name = "txt_nroPlaca";
            this.txt_nroPlaca.Size = new System.Drawing.Size(309, 24);
            this.txt_nroPlaca.TabIndex = 30;
            this.txt_nroPlaca.Enter += new System.EventHandler(this.txt_nroPlaca_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(61, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Placa:";
            // 
            // dgv_Asigna
            // 
            this.dgv_Asigna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Asigna.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Asigna.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Asigna.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Asigna.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Asigna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Asigna.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Asigna.Location = new System.Drawing.Point(12, 193);
            this.dgv_Asigna.Name = "dgv_Asigna";
            this.dgv_Asigna.ReadOnly = true;
            this.dgv_Asigna.Size = new System.Drawing.Size(521, 263);
            this.dgv_Asigna.TabIndex = 54;
            this.dgv_Asigna.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Asigna_CellMouseDoubleClick);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(360, 150);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(137, 26);
            this.btn_Guardar.TabIndex = 55;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // AsignarVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(545, 468);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.dgv_Asigna);
            this.Controls.Add(this.txt_nroPlaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_DPI);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AsignarVehiculos";
            this.Text = "AsignarVehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Asigna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DPI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nroPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Asigna;
        private System.Windows.Forms.Button btn_Guardar;
    }
}