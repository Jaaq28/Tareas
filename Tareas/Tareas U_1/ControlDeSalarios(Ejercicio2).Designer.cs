
namespace Tareas_U_1
{
    partial class ControlDeSalarios
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
            this.components = new System.ComponentModel.Container();
            this.FechaTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.IngresarValorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IngresarAñosTextBox = new System.Windows.Forms.TextBox();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SalarioAumentoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SalarioDelEmpleadoTexbox = new System.Windows.Forms.TextBox();
            this.HoraLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.EdadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FechaTimePicker
            // 
            this.FechaTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaTimePicker.Location = new System.Drawing.Point(400, 28);
            this.FechaTimePicker.Name = "FechaTimePicker";
            this.FechaTimePicker.Size = new System.Drawing.Size(304, 24);
            this.FechaTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar Fecha de Nacimiento del Empleado:";
            // 
            // IngresarValorTextBox
            // 
            this.IngresarValorTextBox.Location = new System.Drawing.Point(315, 148);
            this.IngresarValorTextBox.Name = "IngresarValorTextBox";
            this.IngresarValorTextBox.Size = new System.Drawing.Size(72, 22);
            this.IngresarValorTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar Valor de Venta Prom.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingresar Años de Antiguedad:";
            // 
            // IngresarAñosTextBox
            // 
            this.IngresarAñosTextBox.Location = new System.Drawing.Point(301, 199);
            this.IngresarAñosTextBox.Name = "IngresarAñosTextBox";
            this.IngresarAñosTextBox.Size = new System.Drawing.Size(72, 22);
            this.IngresarAñosTextBox.TabIndex = 4;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Location = new System.Drawing.Point(184, 379);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(99, 37);
            this.EjecutarButton.TabIndex = 6;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(391, 379);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(99, 37);
            this.LimpiarButton.TabIndex = 7;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Edad del Empleado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "salario Con el Aumento:";
            // 
            // SalarioAumentoTextBox
            // 
            this.SalarioAumentoTextBox.Location = new System.Drawing.Point(260, 303);
            this.SalarioAumentoTextBox.Name = "SalarioAumentoTextBox";
            this.SalarioAumentoTextBox.ReadOnly = true;
            this.SalarioAumentoTextBox.Size = new System.Drawing.Size(72, 22);
            this.SalarioAumentoTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Salario del Empleado:";
            // 
            // SalarioDelEmpleadoTexbox
            // 
            this.SalarioDelEmpleadoTexbox.Location = new System.Drawing.Point(245, 105);
            this.SalarioDelEmpleadoTexbox.Name = "SalarioDelEmpleadoTexbox";
            this.SalarioDelEmpleadoTexbox.Size = new System.Drawing.Size(72, 22);
            this.SalarioDelEmpleadoTexbox.TabIndex = 16;
            // 
            // HoraLabel
            // 
            this.HoraLabel.AutoSize = true;
            this.HoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraLabel.Location = new System.Drawing.Point(587, 101);
            this.HoraLabel.Name = "HoraLabel";
            this.HoraLabel.Size = new System.Drawing.Size(55, 24);
            this.HoraLabel.TabIndex = 18;
            this.HoraLabel.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EdadLabel
            // 
            this.EdadLabel.AutoSize = true;
            this.EdadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdadLabel.Location = new System.Drawing.Point(222, 250);
            this.EdadLabel.Name = "EdadLabel";
            this.EdadLabel.Size = new System.Drawing.Size(64, 25);
            this.EdadLabel.TabIndex = 19;
            this.EdadLabel.Text = "Edad";
            // 
            // ControlDeSalarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 467);
            this.Controls.Add(this.EdadLabel);
            this.Controls.Add(this.HoraLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SalarioDelEmpleadoTexbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SalarioAumentoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IngresarAñosTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IngresarValorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaTimePicker);
            this.Name = "ControlDeSalarios";
            this.Text = "Control_De_Salarios";
            this.Load += new System.EventHandler(this.ControlDeSalarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IngresarValorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IngresarAñosTextBox;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SalarioAumentoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SalarioDelEmpleadoTexbox;
        private System.Windows.Forms.Label HoraLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label EdadLabel;
    }
}