namespace WindowsFormsApplication2
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
            this.button1 = new System.Windows.Forms.Button();
            this.CB_IMC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_ActFisica = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CHB_AbueloPaDiab = new System.Windows.Forms.CheckBox();
            this.CHB_MaDiab = new System.Windows.Forms.CheckBox();
            this.CHB_AbueloMaDiab = new System.Windows.Forms.CheckBox();
            this.CHB_PaDiab = new System.Windows.Forms.CheckBox();
            this.CHB_AbuelaMaDiab = new System.Windows.Forms.CheckBox();
            this.CHB_AbuelaPaDiab = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Sexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Azucar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.button1.Location = new System.Drawing.Point(307, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "¿Soy propenso?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CB_IMC
            // 
            this.CB_IMC.FormattingEnabled = true;
            this.CB_IMC.Items.AddRange(new object[] {
            "IMC Menor a 18.5",
            "IMC Mayor o igual  a 18.5 Y Menor o igual a 24.9",
            "IMC Mayor o igual  a 25 Y Menor o igual a 29.9",
            "IMC Mayor a 30"});
            this.CB_IMC.Location = new System.Drawing.Point(261, 93);
            this.CB_IMC.Name = "CB_IMC";
            this.CB_IMC.Size = new System.Drawing.Size(140, 21);
            this.CB_IMC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona tu nivel de IMC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecciona tu nivel de Actividad Física";
            // 
            // CB_ActFisica
            // 
            this.CB_ActFisica.FormattingEnabled = true;
            this.CB_ActFisica.Items.AddRange(new object[] {
            "Actividad Física Baja",
            "Actividad Física Media",
            "Actividad Física Alta"});
            this.CB_ActFisica.Location = new System.Drawing.Point(261, 145);
            this.CB_ActFisica.Name = "CB_ActFisica";
            this.CB_ActFisica.Size = new System.Drawing.Size(140, 21);
            this.CB_ActFisica.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CHB_AbueloPaDiab);
            this.groupBox1.Controls.Add(this.CHB_MaDiab);
            this.groupBox1.Controls.Add(this.CHB_AbueloMaDiab);
            this.groupBox1.Controls.Add(this.CHB_PaDiab);
            this.groupBox1.Controls.Add(this.CHB_AbuelaMaDiab);
            this.groupBox1.Controls.Add(this.CHB_AbuelaPaDiab);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 168);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona aquellos familiares que presenten diabetes en tu familia";
            // 
            // CHB_AbueloPaDiab
            // 
            this.CHB_AbueloPaDiab.AutoSize = true;
            this.CHB_AbueloPaDiab.Location = new System.Drawing.Point(450, 108);
            this.CHB_AbueloPaDiab.Name = "CHB_AbueloPaDiab";
            this.CHB_AbueloPaDiab.Size = new System.Drawing.Size(125, 21);
            this.CHB_AbueloPaDiab.TabIndex = 25;
            this.CHB_AbueloPaDiab.Text = "Abuelo Paterno";
            this.CHB_AbueloPaDiab.UseVisualStyleBackColor = true;
            // 
            // CHB_MaDiab
            // 
            this.CHB_MaDiab.AutoSize = true;
            this.CHB_MaDiab.Location = new System.Drawing.Point(36, 47);
            this.CHB_MaDiab.Name = "CHB_MaDiab";
            this.CHB_MaDiab.Size = new System.Drawing.Size(71, 21);
            this.CHB_MaDiab.TabIndex = 20;
            this.CHB_MaDiab.Text = "Madre ";
            this.CHB_MaDiab.UseVisualStyleBackColor = true;
            // 
            // CHB_AbueloMaDiab
            // 
            this.CHB_AbueloMaDiab.AutoSize = true;
            this.CHB_AbueloMaDiab.Location = new System.Drawing.Point(222, 108);
            this.CHB_AbueloMaDiab.Name = "CHB_AbueloMaDiab";
            this.CHB_AbueloMaDiab.Size = new System.Drawing.Size(127, 21);
            this.CHB_AbueloMaDiab.TabIndex = 22;
            this.CHB_AbueloMaDiab.Text = "Abuelo Materno";
            this.CHB_AbueloMaDiab.UseVisualStyleBackColor = true;
            // 
            // CHB_PaDiab
            // 
            this.CHB_PaDiab.AutoSize = true;
            this.CHB_PaDiab.Location = new System.Drawing.Point(36, 108);
            this.CHB_PaDiab.Name = "CHB_PaDiab";
            this.CHB_PaDiab.Size = new System.Drawing.Size(69, 21);
            this.CHB_PaDiab.TabIndex = 24;
            this.CHB_PaDiab.Text = "Padre ";
            this.CHB_PaDiab.UseVisualStyleBackColor = true;
            // 
            // CHB_AbuelaMaDiab
            // 
            this.CHB_AbuelaMaDiab.AutoSize = true;
            this.CHB_AbuelaMaDiab.Location = new System.Drawing.Point(222, 47);
            this.CHB_AbuelaMaDiab.Name = "CHB_AbuelaMaDiab";
            this.CHB_AbuelaMaDiab.Size = new System.Drawing.Size(131, 21);
            this.CHB_AbuelaMaDiab.TabIndex = 21;
            this.CHB_AbuelaMaDiab.Text = "Abuela Materna ";
            this.CHB_AbuelaMaDiab.UseVisualStyleBackColor = true;
            // 
            // CHB_AbuelaPaDiab
            // 
            this.CHB_AbuelaPaDiab.AutoSize = true;
            this.CHB_AbuelaPaDiab.Location = new System.Drawing.Point(450, 47);
            this.CHB_AbuelaPaDiab.Name = "CHB_AbuelaPaDiab";
            this.CHB_AbuelaPaDiab.Size = new System.Drawing.Size(125, 21);
            this.CHB_AbuelaPaDiab.TabIndex = 23;
            this.CHB_AbuelaPaDiab.Text = "Abuela Paterna";
            this.CHB_AbuelaPaDiab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selecciona tu Sexo";
            // 
            // CB_Sexo
            // 
            this.CB_Sexo.FormattingEnabled = true;
            this.CB_Sexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.CB_Sexo.Location = new System.Drawing.Point(579, 96);
            this.CB_Sexo.Name = "CB_Sexo";
            this.CB_Sexo.Size = new System.Drawing.Size(140, 21);
            this.CB_Sexo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ingresa tu nivel de Azúcar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(474, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nota importante: Si no conces tu nivel de  Azúcar entonces debes ar Ingresar el v" +
    "alor normal de 95";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TB_Azucar
            // 
            this.TB_Azucar.Location = new System.Drawing.Point(250, 390);
            this.TB_Azucar.Name = "TB_Azucar";
            this.TB_Azucar.Size = new System.Drawing.Size(140, 20);
            this.TB_Azucar.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(808, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingresa todos los datos necesarios y posteriormente presiona el botón para conoce" +
    "r si eres propenso o no a padecer diabetes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(910, 581);
            this.Controls.Add(this.TB_Azucar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_Sexo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_ActFisica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_IMC);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Diabetómetro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CB_IMC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_ActFisica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_Sexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Azucar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CHB_MaDiab;
        private System.Windows.Forms.CheckBox CHB_AbuelaMaDiab;
        private System.Windows.Forms.CheckBox CHB_AbueloMaDiab;
        private System.Windows.Forms.CheckBox CHB_AbuelaPaDiab;
        private System.Windows.Forms.CheckBox CHB_PaDiab;
        private System.Windows.Forms.CheckBox CHB_AbueloPaDiab;
    }
}

