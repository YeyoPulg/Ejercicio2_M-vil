namespace Ejercicio2_Móvil
{
    partial class pnlPyR
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
            this.btnAyuda1 = new System.Windows.Forms.Button();
            this.btnAyuda2 = new System.Windows.Forms.Button();
            this.btnAyuda3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Opcion1 = new System.Windows.Forms.RadioButton();
            this.Opcion2 = new System.Windows.Forms.RadioButton();
            this.Opcion3 = new System.Windows.Forms.RadioButton();
            this.Opcion4 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.txtRespuesta1 = new System.Windows.Forms.TextBox();
            this.txtRespuesta2 = new System.Windows.Forms.TextBox();
            this.txtRespuesta3 = new System.Windows.Forms.TextBox();
            this.txtRespuesta4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAyuda1
            // 
            this.btnAyuda1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAyuda1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAyuda1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAyuda1.Location = new System.Drawing.Point(258, 391);
            this.btnAyuda1.Name = "btnAyuda1";
            this.btnAyuda1.Size = new System.Drawing.Size(141, 32);
            this.btnAyuda1.TabIndex = 0;
            this.btnAyuda1.Text = "Cambiar Pregunta";
            this.btnAyuda1.UseVisualStyleBackColor = false;
            // 
            // btnAyuda2
            // 
            this.btnAyuda2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAyuda2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAyuda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda2.Location = new System.Drawing.Point(427, 391);
            this.btnAyuda2.Name = "btnAyuda2";
            this.btnAyuda2.Size = new System.Drawing.Size(59, 32);
            this.btnAyuda2.TabIndex = 1;
            this.btnAyuda2.Text = "50/50";
            this.btnAyuda2.UseVisualStyleBackColor = false;
            // 
            // btnAyuda3
            // 
            this.btnAyuda3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAyuda3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAyuda3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda3.Location = new System.Drawing.Point(513, 391);
            this.btnAyuda3.Name = "btnAyuda3";
            this.btnAyuda3.Size = new System.Drawing.Size(100, 32);
            this.btnAyuda3.TabIndex = 2;
            this.btnAyuda3.Text = "Llamar Amigo";
            this.btnAyuda3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "PREGUNTA MILLONARIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSiguente
            // 
            this.btnSiguente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSiguente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguente.Location = new System.Drawing.Point(62, 391);
            this.btnSiguente.Name = "btnSiguente";
            this.btnSiguente.Size = new System.Drawing.Size(82, 32);
            this.btnSiguente.TabIndex = 4;
            this.btnSiguente.Text = "Siguiente";
            this.btnSiguente.UseVisualStyleBackColor = false;
            this.btnSiguente.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(685, 391);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 32);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Opcion1
            // 
            this.Opcion1.AutoSize = true;
            this.Opcion1.BackColor = System.Drawing.Color.Transparent;
            this.Opcion1.ForeColor = System.Drawing.Color.White;
            this.Opcion1.Location = new System.Drawing.Point(31, 139);
            this.Opcion1.Name = "Opcion1";
            this.Opcion1.Size = new System.Drawing.Size(38, 17);
            this.Opcion1.TabIndex = 6;
            this.Opcion1.TabStop = true;
            this.Opcion1.Text = "A. ";
            this.Opcion1.UseVisualStyleBackColor = false;
            // 
            // Opcion2
            // 
            this.Opcion2.AutoSize = true;
            this.Opcion2.BackColor = System.Drawing.Color.Transparent;
            this.Opcion2.ForeColor = System.Drawing.Color.White;
            this.Opcion2.Location = new System.Drawing.Point(31, 205);
            this.Opcion2.Name = "Opcion2";
            this.Opcion2.Size = new System.Drawing.Size(38, 17);
            this.Opcion2.TabIndex = 7;
            this.Opcion2.TabStop = true;
            this.Opcion2.Text = "B. ";
            this.Opcion2.UseVisualStyleBackColor = false;
            // 
            // Opcion3
            // 
            this.Opcion3.AutoSize = true;
            this.Opcion3.BackColor = System.Drawing.Color.Transparent;
            this.Opcion3.ForeColor = System.Drawing.Color.White;
            this.Opcion3.Location = new System.Drawing.Point(31, 265);
            this.Opcion3.Name = "Opcion3";
            this.Opcion3.Size = new System.Drawing.Size(38, 17);
            this.Opcion3.TabIndex = 8;
            this.Opcion3.TabStop = true;
            this.Opcion3.Text = "C. ";
            this.Opcion3.UseVisualStyleBackColor = false;
            // 
            // Opcion4
            // 
            this.Opcion4.AutoSize = true;
            this.Opcion4.BackColor = System.Drawing.Color.Transparent;
            this.Opcion4.ForeColor = System.Drawing.Color.White;
            this.Opcion4.Location = new System.Drawing.Point(31, 325);
            this.Opcion4.Name = "Opcion4";
            this.Opcion4.Size = new System.Drawing.Size(39, 17);
            this.Opcion4.TabIndex = 9;
            this.Opcion4.TabStop = true;
            this.Opcion4.Text = "D. ";
            this.Opcion4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seleccione la Respuesta";
            // 
            // txtPregunta
            // 
            this.txtPregunta.BackColor = System.Drawing.Color.DimGray;
            this.txtPregunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPregunta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtPregunta.Location = new System.Drawing.Point(31, 70);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(674, 53);
            this.txtPregunta.TabIndex = 18;
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta1.Location = new System.Drawing.Point(75, 139);
            this.txtRespuesta1.Multiline = true;
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.Size = new System.Drawing.Size(600, 49);
            this.txtRespuesta1.TabIndex = 19;
            // 
            // txtRespuesta2
            // 
            this.txtRespuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta2.Location = new System.Drawing.Point(75, 205);
            this.txtRespuesta2.Multiline = true;
            this.txtRespuesta2.Name = "txtRespuesta2";
            this.txtRespuesta2.Size = new System.Drawing.Size(600, 44);
            this.txtRespuesta2.TabIndex = 20;
            // 
            // txtRespuesta3
            // 
            this.txtRespuesta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta3.Location = new System.Drawing.Point(75, 265);
            this.txtRespuesta3.Multiline = true;
            this.txtRespuesta3.Name = "txtRespuesta3";
            this.txtRespuesta3.Size = new System.Drawing.Size(600, 43);
            this.txtRespuesta3.TabIndex = 21;
            // 
            // txtRespuesta4
            // 
            this.txtRespuesta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta4.Location = new System.Drawing.Point(75, 325);
            this.txtRespuesta4.Multiline = true;
            this.txtRespuesta4.Name = "txtRespuesta4";
            this.txtRespuesta4.Size = new System.Drawing.Size(600, 46);
            this.txtRespuesta4.TabIndex = 22;
            // 
            // pnlPyR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejercicio2_Móvil.Properties.Resources.Wallpaper;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRespuesta4);
            this.Controls.Add(this.txtRespuesta3);
            this.Controls.Add(this.txtRespuesta2);
            this.Controls.Add(this.txtRespuesta1);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Opcion4);
            this.Controls.Add(this.Opcion3);
            this.Controls.Add(this.Opcion2);
            this.Controls.Add(this.Opcion1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSiguente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAyuda3);
            this.Controls.Add(this.btnAyuda2);
            this.Controls.Add(this.btnAyuda1);
            this.Name = "pnlPyR";
            this.Text = "P & R";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAyuda1;
        private System.Windows.Forms.Button btnAyuda2;
        private System.Windows.Forms.Button btnAyuda3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton Opcion1;
        private System.Windows.Forms.RadioButton Opcion2;
        private System.Windows.Forms.RadioButton Opcion3;
        private System.Windows.Forms.RadioButton Opcion4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.TextBox txtRespuesta1;
        private System.Windows.Forms.TextBox txtRespuesta2;
        private System.Windows.Forms.TextBox txtRespuesta3;
        private System.Windows.Forms.TextBox txtRespuesta4;
    }
}