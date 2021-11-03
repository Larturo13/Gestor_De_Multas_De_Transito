
namespace Gestor_De_Multas_De_Transito.Grafico.AjustarMultas
{
    partial class ActualizarMulta
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
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Actualiza = new System.Windows.Forms.DataGridView();
            this.btn_Buscardenuevo = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Actualiza)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_valor.Location = new System.Drawing.Point(186, 100);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(309, 24);
            this.txt_valor.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(59, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Valor:";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_Codigo.Location = new System.Drawing.Point(186, 55);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(309, 24);
            this.txt_Codigo.TabIndex = 19;
            this.txt_Codigo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Codigo_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(59, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Codigo:";
            // 
            // dgv_Actualiza
            // 
            this.dgv_Actualiza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Actualiza.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Actualiza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Actualiza.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Actualiza.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Actualiza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Actualiza.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Actualiza.Location = new System.Drawing.Point(12, 197);
            this.dgv_Actualiza.Name = "dgv_Actualiza";
            this.dgv_Actualiza.ReadOnly = true;
            this.dgv_Actualiza.Size = new System.Drawing.Size(521, 259);
            this.dgv_Actualiza.TabIndex = 24;
            this.dgv_Actualiza.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Actualiza_CellMouseDoubleClick);
            // 
            // btn_Buscardenuevo
            // 
            this.btn_Buscardenuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscardenuevo.Location = new System.Drawing.Point(186, 145);
            this.btn_Buscardenuevo.Name = "btn_Buscardenuevo";
            this.btn_Buscardenuevo.Size = new System.Drawing.Size(166, 26);
            this.btn_Buscardenuevo.TabIndex = 26;
            this.btn_Buscardenuevo.Text = "Actualizar otra multa";
            this.btn_Buscardenuevo.UseVisualStyleBackColor = true;
            this.btn_Buscardenuevo.Click += new System.EventHandler(this.btn_Buscardenuevo_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(358, 145);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(137, 26);
            this.btn_Guardar.TabIndex = 25;
            this.btn_Guardar.Text = "Actualizar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click_1);
            // 
            // ActualizarMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(545, 468);
            this.Controls.Add(this.btn_Buscardenuevo);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.dgv_Actualiza);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizarMulta";
            this.Text = "ActualizarMulta";
            this.Load += new System.EventHandler(this.ActualizarMulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Actualiza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Actualiza;
        private System.Windows.Forms.Button btn_Buscardenuevo;
        private System.Windows.Forms.Button btn_Guardar;
    }
}