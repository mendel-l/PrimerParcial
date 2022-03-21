namespace PrimerParcial
{
    partial class DataFutbolistas
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
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPropietarioCuotaAlta = new System.Windows.Forms.Button();
            this.buttonOrdanarGoles = new System.Windows.Forms.Button();
            this.dataGridViewResultado = new System.Windows.Forms.DataGridView();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(453, 28);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(125, 50);
            this.buttonMostrar.TabIndex = 37;
            this.buttonMostrar.Text = "Mostrar Datos";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(508, 277);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(125, 41);
            this.buttonExit.TabIndex = 36;
            this.buttonExit.Text = "salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonPropietarioCuotaAlta
            // 
            this.buttonPropietarioCuotaAlta.Location = new System.Drawing.Point(508, 206);
            this.buttonPropietarioCuotaAlta.Name = "buttonPropietarioCuotaAlta";
            this.buttonPropietarioCuotaAlta.Size = new System.Drawing.Size(125, 50);
            this.buttonPropietarioCuotaAlta.TabIndex = 35;
            this.buttonPropietarioCuotaAlta.Text = "Promedio";
            this.buttonPropietarioCuotaAlta.UseVisualStyleBackColor = true;
            this.buttonPropietarioCuotaAlta.Click += new System.EventHandler(this.buttonPropietarioCuotaAlta_Click);
            // 
            // buttonOrdanarGoles
            // 
            this.buttonOrdanarGoles.Location = new System.Drawing.Point(508, 150);
            this.buttonOrdanarGoles.Name = "buttonOrdanarGoles";
            this.buttonOrdanarGoles.Size = new System.Drawing.Size(125, 50);
            this.buttonOrdanarGoles.TabIndex = 34;
            this.buttonOrdanarGoles.Text = "Ordenar Goles";
            this.buttonOrdanarGoles.UseVisualStyleBackColor = true;
            this.buttonOrdanarGoles.Click += new System.EventHandler(this.buttonOrdanarGoles_Click);
            // 
            // dataGridViewResultado
            // 
            this.dataGridViewResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultado.Location = new System.Drawing.Point(43, 98);
            this.dataGridViewResultado.Name = "dataGridViewResultado";
            this.dataGridViewResultado.Size = new System.Drawing.Size(450, 225);
            this.dataGridViewResultado.TabIndex = 32;
            // 
            // comboBoxName
            // 
            this.comboBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(260, 42);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(174, 24);
            this.comboBoxName.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nombre Futbolista";
            // 
            // DataFutbolistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 411);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPropietarioCuotaAlta);
            this.Controls.Add(this.buttonOrdanarGoles);
            this.Controls.Add(this.dataGridViewResultado);
            this.Name = "DataFutbolistas";
            this.Text = "DataFutbolistas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPropietarioCuotaAlta;
        private System.Windows.Forms.Button buttonOrdanarGoles;
        private System.Windows.Forms.DataGridView dataGridViewResultado;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.Label label2;
    }
}