namespace Generadordecontrasenas
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.numericLongitud = new System.Windows.Forms.NumericUpDown();
            this.numericIteraciones = new System.Windows.Forms.NumericUpDown();
            this.labelLongitud = new System.Windows.Forms.Label();
            this.labelIteraciones = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericLongitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIteraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(191, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Generador de contraseñas";
            // 
            // numericLongitud
            // 
            this.numericLongitud.Location = new System.Drawing.Point(16, 55);
            this.numericLongitud.Maximum = new decimal(new int[] {
            129,
            0,
            0,
            0});
            this.numericLongitud.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericLongitud.Name = "numericLongitud";
            this.numericLongitud.Size = new System.Drawing.Size(120, 20);
            this.numericLongitud.TabIndex = 1;
            this.numericLongitud.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericIteraciones
            // 
            this.numericIteraciones.Location = new System.Drawing.Point(16, 105);
            this.numericIteraciones.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericIteraciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericIteraciones.Name = "numericIteraciones";
            this.numericIteraciones.Size = new System.Drawing.Size(120, 20);
            this.numericIteraciones.TabIndex = 2;
            this.numericIteraciones.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // labelLongitud
            // 
            this.labelLongitud.AutoSize = true;
            this.labelLongitud.Location = new System.Drawing.Point(13, 39);
            this.labelLongitud.Name = "labelLongitud";
            this.labelLongitud.Size = new System.Drawing.Size(97, 13);
            this.labelLongitud.TabIndex = 3;
            this.labelLongitud.Text = "Longitud de la contraseña:";
            // 
            // labelIteraciones
            // 
            this.labelIteraciones.AutoSize = true;
            this.labelIteraciones.Location = new System.Drawing.Point(13, 89);
            this.labelIteraciones.Name = "labelIteraciones";
            this.labelIteraciones.Size = new System.Drawing.Size(123, 13);
            this.labelIteraciones.TabIndex = 4;
            this.labelIteraciones.Text = "Número de iteraciones:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(16, 131);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(120, 23);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar Contraseña";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(16, 160);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.ReadOnly = true;
            this.txtContrasena.Size = new System.Drawing.Size(256, 20);
            this.txtContrasena.TabIndex = 6;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(197, 186);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 7;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.labelIteraciones);
            this.Controls.Add(this.labelLongitud);
            this.Controls.Add(this.numericIteraciones);
            this.Controls.Add(this.numericLongitud);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Generador de contraseñas";
            ((System.ComponentModel.ISupportInitialize)(this.numericLongitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIteraciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.NumericUpDown numericLongitud;
        private System.Windows.Forms.NumericUpDown numericIteraciones;
        private System.Windows.Forms.Label labelLongitud;
        private System.Windows.Forms.Label labelIteraciones;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnCopiar;
    }
}