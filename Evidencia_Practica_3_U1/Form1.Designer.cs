
namespace Evidencia_Practica_3_U1
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
            this.btnEjemplo = new System.Windows.Forms.Button();
            this.btnColombia = new System.Windows.Forms.Button();
            this.btnSomalia = new System.Windows.Forms.Button();
            this.btnTrinidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEjemplo
            // 
            this.btnEjemplo.Location = new System.Drawing.Point(33, 28);
            this.btnEjemplo.Name = "btnEjemplo";
            this.btnEjemplo.Size = new System.Drawing.Size(108, 23);
            this.btnEjemplo.TabIndex = 0;
            this.btnEjemplo.Text = "Ejemplo";
            this.btnEjemplo.UseVisualStyleBackColor = true;
            this.btnEjemplo.Click += new System.EventHandler(this.btnEjemplo_Click);
            // 
            // btnColombia
            // 
            this.btnColombia.Location = new System.Drawing.Point(33, 104);
            this.btnColombia.Name = "btnColombia";
            this.btnColombia.Size = new System.Drawing.Size(108, 23);
            this.btnColombia.TabIndex = 1;
            this.btnColombia.Text = "Colombia";
            this.btnColombia.UseVisualStyleBackColor = true;
            this.btnColombia.Click += new System.EventHandler(this.btnColombia_Click);
            // 
            // btnSomalia
            // 
            this.btnSomalia.Location = new System.Drawing.Point(33, 133);
            this.btnSomalia.Name = "btnSomalia";
            this.btnSomalia.Size = new System.Drawing.Size(108, 31);
            this.btnSomalia.TabIndex = 2;
            this.btnSomalia.Text = "Somalia";
            this.btnSomalia.UseVisualStyleBackColor = true;
            this.btnSomalia.Click += new System.EventHandler(this.btnSomalia_Click);
            // 
            // btnTrinidad
            // 
            this.btnTrinidad.Location = new System.Drawing.Point(33, 57);
            this.btnTrinidad.Name = "btnTrinidad";
            this.btnTrinidad.Size = new System.Drawing.Size(108, 41);
            this.btnTrinidad.TabIndex = 3;
            this.btnTrinidad.Text = "Trinidad y Tobago";
            this.btnTrinidad.UseVisualStyleBackColor = true;
            this.btnTrinidad.Click += new System.EventHandler(this.btnTrinidad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 221);
            this.Controls.Add(this.btnTrinidad);
            this.Controls.Add(this.btnSomalia);
            this.Controls.Add(this.btnColombia);
            this.Controls.Add(this.btnEjemplo);
            this.Name = "Form1";
            this.Text = "Programa Banderas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEjemplo;
        private System.Windows.Forms.Button btnColombia;
        private System.Windows.Forms.Button btnSomalia;
        private System.Windows.Forms.Button btnTrinidad;
    }
}

