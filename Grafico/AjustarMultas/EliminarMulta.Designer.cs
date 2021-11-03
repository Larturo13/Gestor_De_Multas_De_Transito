
namespace Gestor_De_Multas_De_Transito.Grafico.AjustarMultas
{
    partial class EliminarMulta
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
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.dgv_Elimina = new System.Windows.Forms.DataGridView();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Elimina)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(353, 93);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(137, 26);
            this.btn_Guardar.TabIndex = 40;
            this.btn_Guardar.Text = "Eliminar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // dgv_Elimina
            // 
            this.dgv_Elimina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Elimina.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Elimina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Elimina.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Elimina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Elimina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Elimina.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Elimina.Location = new System.Drawing.Point(12, 143);
            this.dgv_Elimina.Name = "dgv_Elimina";
            this.dgv_Elimina.ReadOnly = true;
            this.dgv_Elimina.Size = new System.Drawing.Size(521, 313);
            this.dgv_Elimina.TabIndex = 39;
            this.dgv_Elimina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Elimina_CellDoubleClick);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_Codigo.Location = new System.Drawing.Point(181, 44);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(309, 24);
            this.txt_Codigo.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(54, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Codigo:";
            // 
            // EliminarMulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(545, 468);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.dgv_Elimina);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarMulta";
            this.Text = "EliminarMulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Elimina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridView dgv_Elimina;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label4;
    }
}