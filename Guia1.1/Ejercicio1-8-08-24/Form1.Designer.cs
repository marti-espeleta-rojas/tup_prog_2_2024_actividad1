namespace Ejercicio1_8_08_24
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
            this.btnClienteCrearCocina = new System.Windows.Forms.Button();
            this.btnClienteReponerIngredientes = new System.Windows.Forms.Button();
            this.textBoxReponerHarina = new System.Windows.Forms.TextBox();
            this.textBoxReponerFrutas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTomarFruta = new System.Windows.Forms.TextBox();
            this.textBoxTomarHarina = new System.Windows.Forms.TextBox();
            this.btnTomar = new System.Windows.Forms.Button();
            this.btnCocinar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClienteCrearCocina
            // 
            this.btnClienteCrearCocina.Location = new System.Drawing.Point(94, 59);
            this.btnClienteCrearCocina.Name = "btnClienteCrearCocina";
            this.btnClienteCrearCocina.Size = new System.Drawing.Size(120, 46);
            this.btnClienteCrearCocina.TabIndex = 0;
            this.btnClienteCrearCocina.Text = "Crear Cocina";
            this.btnClienteCrearCocina.UseVisualStyleBackColor = true;
            this.btnClienteCrearCocina.Click += new System.EventHandler(this.btnClienteCrearCocina_Click);
            // 
            // btnClienteReponerIngredientes
            // 
            this.btnClienteReponerIngredientes.Location = new System.Drawing.Point(229, 145);
            this.btnClienteReponerIngredientes.Name = "btnClienteReponerIngredientes";
            this.btnClienteReponerIngredientes.Size = new System.Drawing.Size(76, 46);
            this.btnClienteReponerIngredientes.TabIndex = 1;
            this.btnClienteReponerIngredientes.Text = "Reponer Ingrredientes";
            this.btnClienteReponerIngredientes.UseVisualStyleBackColor = true;
            this.btnClienteReponerIngredientes.Click += new System.EventHandler(this.btnClienteReponerIngredientes_Click);
            // 
            // textBoxReponerHarina
            // 
            this.textBoxReponerHarina.Location = new System.Drawing.Point(114, 145);
            this.textBoxReponerHarina.Name = "textBoxReponerHarina";
            this.textBoxReponerHarina.Size = new System.Drawing.Size(100, 20);
            this.textBoxReponerHarina.TabIndex = 2;
            // 
            // textBoxReponerFrutas
            // 
            this.textBoxReponerFrutas.Location = new System.Drawing.Point(114, 171);
            this.textBoxReponerFrutas.Name = "textBoxReponerFrutas";
            this.textBoxReponerFrutas.Size = new System.Drawing.Size(100, 20);
            this.textBoxReponerFrutas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Harina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fruta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fruta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Harina:";
            // 
            // textBoxTomarFruta
            // 
            this.textBoxTomarFruta.Location = new System.Drawing.Point(114, 293);
            this.textBoxTomarFruta.Name = "textBoxTomarFruta";
            this.textBoxTomarFruta.Size = new System.Drawing.Size(100, 20);
            this.textBoxTomarFruta.TabIndex = 8;
            // 
            // textBoxTomarHarina
            // 
            this.textBoxTomarHarina.Location = new System.Drawing.Point(114, 267);
            this.textBoxTomarHarina.Name = "textBoxTomarHarina";
            this.textBoxTomarHarina.Size = new System.Drawing.Size(100, 20);
            this.textBoxTomarHarina.TabIndex = 7;
            // 
            // btnTomar
            // 
            this.btnTomar.Location = new System.Drawing.Point(229, 267);
            this.btnTomar.Name = "btnTomar";
            this.btnTomar.Size = new System.Drawing.Size(76, 46);
            this.btnTomar.TabIndex = 6;
            this.btnTomar.Text = "Tomar Ingrredientes";
            this.btnTomar.UseVisualStyleBackColor = true;
            this.btnTomar.Click += new System.EventHandler(this.btnTomar_Click);
            // 
            // btnCocinar
            // 
            this.btnCocinar.Location = new System.Drawing.Point(229, 375);
            this.btnCocinar.Name = "btnCocinar";
            this.btnCocinar.Size = new System.Drawing.Size(75, 23);
            this.btnCocinar.TabIndex = 11;
            this.btnCocinar.Text = "Cocinar";
            this.btnCocinar.UseVisualStyleBackColor = true;
            this.btnCocinar.Click += new System.EventHandler(this.btnCocinar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCocinar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTomarFruta);
            this.Controls.Add(this.textBoxTomarHarina);
            this.Controls.Add(this.btnTomar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxReponerFrutas);
            this.Controls.Add(this.textBoxReponerHarina);
            this.Controls.Add(this.btnClienteReponerIngredientes);
            this.Controls.Add(this.btnClienteCrearCocina);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClienteCrearCocina;
        private System.Windows.Forms.Button btnClienteReponerIngredientes;
        private System.Windows.Forms.TextBox textBoxReponerHarina;
        private System.Windows.Forms.TextBox textBoxReponerFrutas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTomarFruta;
        private System.Windows.Forms.TextBox textBoxTomarHarina;
        private System.Windows.Forms.Button btnTomar;
        private System.Windows.Forms.Button btnCocinar;
    }
}

