
namespace Tareas_U_1
{
    partial class FunciondeParImparPrimo
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
            this.IngresarLabel = new System.Windows.Forms.Label();
            this.IngresarTextBox = new System.Windows.Forms.TextBox();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.Resultado2TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IngresarLabel
            // 
            this.IngresarLabel.AutoSize = true;
            this.IngresarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarLabel.Location = new System.Drawing.Point(60, 43);
            this.IngresarLabel.Name = "IngresarLabel";
            this.IngresarLabel.Size = new System.Drawing.Size(164, 17);
            this.IngresarLabel.TabIndex = 0;
            this.IngresarLabel.Text = "Ingresar Numero Entero:";
            // 
            // IngresarTextBox
            // 
            this.IngresarTextBox.Location = new System.Drawing.Point(247, 40);
            this.IngresarTextBox.Name = "IngresarTextBox";
            this.IngresarTextBox.Size = new System.Drawing.Size(77, 22);
            this.IngresarTextBox.TabIndex = 1;
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ResultadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ResultadoTextBox.Location = new System.Drawing.Point(247, 97);
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.ReadOnly = true;
            this.ResultadoTextBox.Size = new System.Drawing.Size(332, 22);
            this.ResultadoTextBox.TabIndex = 3;
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoLabel.Location = new System.Drawing.Point(73, 100);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(163, 17);
            this.ResultadoLabel.TabIndex = 2;
            this.ResultadoLabel.Text = "Resultado (Par e Impar):";
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EjecutarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EjecutarButton.Location = new System.Drawing.Point(114, 192);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(110, 46);
            this.EjecutarButton.TabIndex = 4;
            this.EjecutarButton.Text = "EJECUTAR";
            this.EjecutarButton.UseVisualStyleBackColor = false;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LimpiarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LimpiarButton.Location = new System.Drawing.Point(350, 192);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(110, 46);
            this.LimpiarButton.TabIndex = 5;
            this.LimpiarButton.Text = "LIMPIAR";
            this.LimpiarButton.UseVisualStyleBackColor = false;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // Resultado2TextBox
            // 
            this.Resultado2TextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Resultado2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado2TextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Resultado2TextBox.Location = new System.Drawing.Point(247, 140);
            this.Resultado2TextBox.Name = "Resultado2TextBox";
            this.Resultado2TextBox.ReadOnly = true;
            this.Resultado2TextBox.Size = new System.Drawing.Size(332, 22);
            this.Resultado2TextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resultado (Es Primo o No Primo):";
            // 
            // FunciondeParImparPrimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 285);
            this.Controls.Add(this.Resultado2TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.ResultadoLabel);
            this.Controls.Add(this.IngresarTextBox);
            this.Controls.Add(this.IngresarLabel);
            this.Name = "FunciondeParImparPrimo";
            this.Text = "Funcion de par, Impar y Primo";
            this.Load += new System.EventHandler(this.FunciondeParImparPrimo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IngresarLabel;
        private System.Windows.Forms.TextBox IngresarTextBox;
        private System.Windows.Forms.TextBox ResultadoTextBox;
        private System.Windows.Forms.Label ResultadoLabel;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.TextBox Resultado2TextBox;
        private System.Windows.Forms.Label label1;
    }
}

