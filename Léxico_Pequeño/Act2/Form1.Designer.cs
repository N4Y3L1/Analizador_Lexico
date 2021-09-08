
namespace Act2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.original = new System.Windows.Forms.TextBox();
            this.copia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // original
            // 
            this.original.Location = new System.Drawing.Point(47, 24);
            this.original.Multiline = true;
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(197, 116);
            this.original.TabIndex = 0;
            // 
            // copia
            // 
            this.copia.Location = new System.Drawing.Point(355, 24);
            this.copia.Multiline = true;
            this.copia.Name = "copia";
            this.copia.Size = new System.Drawing.Size(197, 116);
            this.copia.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(27, 162);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(542, 150);
            this.tabla.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 335);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.copia);
            this.Controls.Add(this.original);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox original;
        private System.Windows.Forms.TextBox copia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tabla;
    }
}

