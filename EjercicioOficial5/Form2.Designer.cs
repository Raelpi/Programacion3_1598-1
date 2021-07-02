
namespace EjercicioOficial5
{
    partial class Form2
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
            this.txt_Filas = new System.Windows.Forms.TextBox();
            this.txt_Columnas = new System.Windows.Forms.TextBox();
            this.btn_Matriz = new System.Windows.Forms.Button();
            this.dgv_Matriz = new System.Windows.Forms.DataGridView();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Matriz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "filas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Columnas";
            // 
            // txt_Filas
            // 
            this.txt_Filas.Location = new System.Drawing.Point(143, 33);
            this.txt_Filas.Name = "txt_Filas";
            this.txt_Filas.Size = new System.Drawing.Size(336, 20);
            this.txt_Filas.TabIndex = 2;
            // 
            // txt_Columnas
            // 
            this.txt_Columnas.Location = new System.Drawing.Point(143, 82);
            this.txt_Columnas.Name = "txt_Columnas";
            this.txt_Columnas.Size = new System.Drawing.Size(336, 20);
            this.txt_Columnas.TabIndex = 3;
            // 
            // btn_Matriz
            // 
            this.btn_Matriz.Location = new System.Drawing.Point(515, 33);
            this.btn_Matriz.Name = "btn_Matriz";
            this.btn_Matriz.Size = new System.Drawing.Size(102, 69);
            this.btn_Matriz.TabIndex = 4;
            this.btn_Matriz.Text = "Ejecutar";
            this.btn_Matriz.UseVisualStyleBackColor = true;
            this.btn_Matriz.Click += new System.EventHandler(this.btn_Matriz_Click);
            // 
            // dgv_Matriz
            // 
            this.dgv_Matriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Matriz.Location = new System.Drawing.Point(41, 158);
            this.dgv_Matriz.Name = "dgv_Matriz";
            this.dgv_Matriz.Size = new System.Drawing.Size(414, 267);
            this.dgv_Matriz.TabIndex = 5;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(515, 123);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(102, 69);
            this.btn_Limpiar.TabIndex = 6;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.dgv_Matriz);
            this.Controls.Add(this.btn_Matriz);
            this.Controls.Add(this.txt_Columnas);
            this.Controls.Add(this.txt_Filas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Matriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Filas;
        private System.Windows.Forms.TextBox txt_Columnas;
        private System.Windows.Forms.Button btn_Matriz;
        private System.Windows.Forms.DataGridView dgv_Matriz;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}