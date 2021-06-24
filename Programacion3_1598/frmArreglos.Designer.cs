
namespace Programacion3_1598
{
    partial class frmArreglos
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
            this.listboxArreglo = new System.Windows.Forms.ListBox();
            this.btn_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.OrdenarArreglo = new System.Windows.Forms.ListBox();
            this.btn_ordenar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listboxArreglo
            // 
            this.listboxArreglo.FormattingEnabled = true;
            this.listboxArreglo.Location = new System.Drawing.Point(124, 162);
            this.listboxArreglo.Name = "listboxArreglo";
            this.listboxArreglo.Size = new System.Drawing.Size(188, 199);
            this.listboxArreglo.TabIndex = 0;
            // 
            // btn_button
            // 
            this.btn_button.Location = new System.Drawing.Point(145, 26);
            this.btn_button.Name = "btn_button";
            this.btn_button.Size = new System.Drawing.Size(182, 86);
            this.btn_button.TabIndex = 1;
            this.btn_button.Text = "Ejecutar";
            this.btn_button.UseVisualStyleBackColor = true;
            this.btn_button.Click += new System.EventHandler(this.btn_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(354, 162);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 199);
            this.listBox1.TabIndex = 2;
            // 
            // OrdenarArreglo
            // 
            this.OrdenarArreglo.FormattingEnabled = true;
            this.OrdenarArreglo.Location = new System.Drawing.Point(555, 162);
            this.OrdenarArreglo.Name = "OrdenarArreglo";
            this.OrdenarArreglo.Size = new System.Drawing.Size(182, 199);
            this.OrdenarArreglo.TabIndex = 3;
            // 
            // btn_ordenar
            // 
            this.btn_ordenar.Location = new System.Drawing.Point(354, 26);
            this.btn_ordenar.Name = "btn_ordenar";
            this.btn_ordenar.Size = new System.Drawing.Size(156, 86);
            this.btn_ordenar.TabIndex = 4;
            this.btn_ordenar.Text = "Ordenar";
            this.btn_ordenar.UseVisualStyleBackColor = true;
            this.btn_ordenar.Click += new System.EventHandler(this.btn_ordenar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 86);
            this.button1.TabIndex = 5;
            this.button1.Text = "maximo o minimo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmArreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ordenar);
            this.Controls.Add(this.OrdenarArreglo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_button);
            this.Controls.Add(this.listboxArreglo);
            this.Name = "frmArreglos";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listboxArreglo;
        private System.Windows.Forms.Button btn_button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox OrdenarArreglo;
        private System.Windows.Forms.Button btn_ordenar;
        private System.Windows.Forms.Button button1;
    }
}

