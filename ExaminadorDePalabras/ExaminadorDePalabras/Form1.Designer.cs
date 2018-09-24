namespace ExaminadorDePalabras {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.btnBuscarRuta = new System.Windows.Forms.Button();
            this.OpenFile1 = new System.Windows.Forms.OpenFileDialog();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.txtContenidoTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPalabras = new System.Windows.Forms.Label();
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.lblEspBlancos = new System.Windows.Forms.Label();
            this.lblTabs = new System.Windows.Forms.Label();
            this.lblLineas = new System.Windows.Forms.Label();
            this.lblVocales = new System.Windows.Forms.Label();
            this.lblConsonantes = new System.Windows.Forms.Label();
            this.cmbQuitar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.saveFile1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnBuscarRuta
            // 
            this.btnBuscarRuta.Location = new System.Drawing.Point(315, 20);
            this.btnBuscarRuta.Name = "btnBuscarRuta";
            this.btnBuscarRuta.Size = new System.Drawing.Size(153, 23);
            this.btnBuscarRuta.TabIndex = 0;
            this.btnBuscarRuta.Text = "Examinar";
            this.btnBuscarRuta.UseVisualStyleBackColor = true;
            this.btnBuscarRuta.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenFile1
            // 
            this.OpenFile1.FileName = "OpenFile1";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(12, 22);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(297, 20);
            this.txtRuta.TabIndex = 1;
            // 
            // txtContenidoTexto
            // 
            this.txtContenidoTexto.AcceptsReturn = true;
            this.txtContenidoTexto.AcceptsTab = true;
            this.txtContenidoTexto.Location = new System.Drawing.Point(12, 49);
            this.txtContenidoTexto.Multiline = true;
            this.txtContenidoTexto.Name = "txtContenidoTexto";
            this.txtContenidoTexto.Size = new System.Drawing.Size(456, 328);
            this.txtContenidoTexto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Palabras :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Caracteres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Espacios en blanco :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tabuladores :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Líneas :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vocales :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Consonantes :";
            // 
            // lblPalabras
            // 
            this.lblPalabras.AutoSize = true;
            this.lblPalabras.Location = new System.Drawing.Point(631, 52);
            this.lblPalabras.Name = "lblPalabras";
            this.lblPalabras.Size = new System.Drawing.Size(16, 13);
            this.lblPalabras.TabIndex = 10;
            this.lblPalabras.Text = "---";
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.Location = new System.Drawing.Point(631, 75);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(16, 13);
            this.lblCaracteres.TabIndex = 11;
            this.lblCaracteres.Text = "---";
            // 
            // lblEspBlancos
            // 
            this.lblEspBlancos.AutoSize = true;
            this.lblEspBlancos.Location = new System.Drawing.Point(631, 98);
            this.lblEspBlancos.Name = "lblEspBlancos";
            this.lblEspBlancos.Size = new System.Drawing.Size(16, 13);
            this.lblEspBlancos.TabIndex = 12;
            this.lblEspBlancos.Text = "---";
            // 
            // lblTabs
            // 
            this.lblTabs.AutoSize = true;
            this.lblTabs.Location = new System.Drawing.Point(631, 121);
            this.lblTabs.Name = "lblTabs";
            this.lblTabs.Size = new System.Drawing.Size(16, 13);
            this.lblTabs.TabIndex = 13;
            this.lblTabs.Text = "---";
            // 
            // lblLineas
            // 
            this.lblLineas.AutoSize = true;
            this.lblLineas.Location = new System.Drawing.Point(631, 145);
            this.lblLineas.Name = "lblLineas";
            this.lblLineas.Size = new System.Drawing.Size(16, 13);
            this.lblLineas.TabIndex = 14;
            this.lblLineas.Text = "---";
            // 
            // lblVocales
            // 
            this.lblVocales.AutoSize = true;
            this.lblVocales.Location = new System.Drawing.Point(631, 171);
            this.lblVocales.Name = "lblVocales";
            this.lblVocales.Size = new System.Drawing.Size(16, 13);
            this.lblVocales.TabIndex = 15;
            this.lblVocales.Text = "---";
            // 
            // lblConsonantes
            // 
            this.lblConsonantes.AutoSize = true;
            this.lblConsonantes.Location = new System.Drawing.Point(631, 193);
            this.lblConsonantes.Name = "lblConsonantes";
            this.lblConsonantes.Size = new System.Drawing.Size(16, 13);
            this.lblConsonantes.TabIndex = 16;
            this.lblConsonantes.Text = "---";
            // 
            // cmbQuitar
            // 
            this.cmbQuitar.FormattingEnabled = true;
            this.cmbQuitar.Items.AddRange(new object[] {
            "Espacios en blanco",
            "Vocales",
            "Consonantes"});
            this.cmbQuitar.Location = new System.Drawing.Point(521, 278);
            this.cmbQuitar.Name = "cmbQuitar";
            this.cmbQuitar.Size = new System.Drawing.Size(183, 21);
            this.cmbQuitar.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quitar :";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(710, 276);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(110, 23);
            this.btnProcesar.TabIndex = 19;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(521, 401);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(255, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar Como..";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbQuitar);
            this.Controls.Add(this.lblConsonantes);
            this.Controls.Add(this.lblVocales);
            this.Controls.Add(this.lblLineas);
            this.Controls.Add(this.lblTabs);
            this.Controls.Add(this.lblEspBlancos);
            this.Controls.Add(this.lblCaracteres);
            this.Controls.Add(this.lblPalabras);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContenidoTexto);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnBuscarRuta);
            this.Name = "Form1";
            this.Text = "Examinador de Palabras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarRuta;
        private System.Windows.Forms.OpenFileDialog OpenFile1;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.TextBox txtContenidoTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPalabras;
        private System.Windows.Forms.Label lblCaracteres;
        private System.Windows.Forms.Label lblEspBlancos;
        private System.Windows.Forms.Label lblTabs;
        private System.Windows.Forms.Label lblLineas;
        private System.Windows.Forms.Label lblVocales;
        private System.Windows.Forms.Label lblConsonantes;
        private System.Windows.Forms.ComboBox cmbQuitar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.SaveFileDialog saveFile1;
    }
}

