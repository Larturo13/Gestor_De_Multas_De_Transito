
namespace Gestor_De_Multas_De_Transito.Grafico.Personas
{
    partial class ActualizarPersonas
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
            this.txt_NomApell = new System.Windows.Forms.TextBox();
            this.txt_DPI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Buscardenuevo = new System.Windows.Forms.Button();
            this.dgv_Actualiza = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Actualiza)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NomApell
            // 
            this.txt_NomApell.Enabled = false;
            this.txt_NomApell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_NomApell.Location = new System.Drawing.Point(174, 96);
            this.txt_NomApell.Name = "txt_NomApell";
            this.txt_NomApell.Size = new System.Drawing.Size(309, 24);
            this.txt_NomApell.TabIndex = 13;
            // 
            // txt_DPI
            // 
            this.txt_DPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_DPI.Location = new System.Drawing.Point(174, 46);
            this.txt_DPI.Name = "txt_DPI";
            this.txt_DPI.Size = new System.Drawing.Size(309, 24);
            this.txt_DPI.TabIndex = 12;
            this.txt_DPI.Validating += new System.ComponentModel.CancelEventHandler(this.txt_DPI_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(47, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "DPI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(47, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre Apellido:";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(346, 236);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(137, 26);
            this.btn_Guardar.TabIndex = 19;
            this.btn_Guardar.Text = "Actualizar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_Telefono.Location = new System.Drawing.Point(174, 196);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(309, 24);
            this.txt_Telefono.TabIndex = 18;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_Direccion.Location = new System.Drawing.Point(174, 146);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(309, 24);
            this.txt_Direccion.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(47, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(47, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Direccion:";
            // 
            // btn_Buscardenuevo
            // 
            this.btn_Buscardenuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscardenuevo.Location = new System.Drawing.Point(174, 236);
            this.btn_Buscardenuevo.Name = "btn_Buscardenuevo";
            this.btn_Buscardenuevo.Size = new System.Drawing.Size(166, 26);
            this.btn_Buscardenuevo.TabIndex = 21;
            this.btn_Buscardenuevo.Text = "Buscar otra persona\r\n";
            this.btn_Buscardenuevo.UseVisualStyleBackColor = true;
            this.btn_Buscardenuevo.Click += new System.EventHandler(this.btn_Buscardenuevo_Click);
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
            this.dgv_Actualiza.Location = new System.Drawing.Point(12, 288);
            this.dgv_Actualiza.Name = "dgv_Actualiza";
            this.dgv_Actualiza.ReadOnly = true;
            this.dgv_Actualiza.Size = new System.Drawing.Size(521, 168);
            this.dgv_Actualiza.TabIndex = 23;
            this.dgv_Actualiza.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Actualiza_CellMouseDoubleClick);
            // 
            // ActualizarPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(545, 468);
            this.Controls.Add(this.dgv_Actualiza);
            this.Controls.Add(this.btn_Buscardenuevo);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NomApell);
            this.Controls.Add(this.txt_DPI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizarPersonas";
            this.Text = "ActualizarPersonas";
            this.Load += new System.EventHandler(this.ActualizarPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Actualiza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NomApell;
        private System.Windows.Forms.TextBox txt_DPI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Buscardenuevo;
        private System.Windows.Forms.DataGridView dgv_Actualiza;
    }
}