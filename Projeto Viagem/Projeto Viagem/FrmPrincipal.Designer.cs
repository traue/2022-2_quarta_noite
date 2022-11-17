namespace Projeto_Viagem
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.lblPedagio = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblKml = new System.Windows.Forms.Label();
            this.nudDistancia = new System.Windows.Forms.NumericUpDown();
            this.nudConsumo = new System.Windows.Forms.NumericUpDown();
            this.nudCombustivel = new System.Windows.Forms.NumericUpDown();
            this.nudPedagio = new System.Windows.Forms.NumericUpDown();
            this.chkGastoPedagio = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCombustivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPedagio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(83, 35);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(160, 20);
            this.lblDistancia.TabIndex = 0;
            this.lblDistancia.Text = "Distância a percorrer:";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumo.Location = new System.Drawing.Point(41, 80);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(202, 20);
            this.lblConsumo.TabIndex = 1;
            this.lblConsumo.Text = "Consumo médio do veículo:";
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustivel.Location = new System.Drawing.Point(12, 125);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(231, 20);
            this.lblCombustivel.TabIndex = 2;
            this.lblCombustivel.Text = "Valor médio do combustível: R$";
            // 
            // lblPedagio
            // 
            this.lblPedagio.AutoSize = true;
            this.lblPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedagio.Location = new System.Drawing.Point(11, 219);
            this.lblPedagio.Name = "lblPedagio";
            this.lblPedagio.Size = new System.Drawing.Size(232, 20);
            this.lblPedagio.TabIndex = 3;
            this.lblPedagio.Text = "Valor gasto com pedágio(s): R$";
            this.lblPedagio.Visible = false;
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(357, 35);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(32, 20);
            this.lblKm.TabIndex = 4;
            this.lblKm.Text = "Km";
            // 
            // lblKml
            // 
            this.lblKml.AutoSize = true;
            this.lblKml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKml.Location = new System.Drawing.Point(357, 80);
            this.lblKml.Name = "lblKml";
            this.lblKml.Size = new System.Drawing.Size(45, 20);
            this.lblKml.TabIndex = 5;
            this.lblKml.Text = "Km/L";
            // 
            // nudDistancia
            // 
            this.nudDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDistancia.Location = new System.Drawing.Point(249, 33);
            this.nudDistancia.Maximum = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            this.nudDistancia.Name = "nudDistancia";
            this.nudDistancia.Size = new System.Drawing.Size(102, 26);
            this.nudDistancia.TabIndex = 7;
            // 
            // nudConsumo
            // 
            this.nudConsumo.DecimalPlaces = 2;
            this.nudConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudConsumo.Location = new System.Drawing.Point(249, 78);
            this.nudConsumo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudConsumo.Name = "nudConsumo";
            this.nudConsumo.Size = new System.Drawing.Size(102, 26);
            this.nudConsumo.TabIndex = 8;
            // 
            // nudCombustivel
            // 
            this.nudCombustivel.DecimalPlaces = 2;
            this.nudCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCombustivel.Location = new System.Drawing.Point(249, 123);
            this.nudCombustivel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCombustivel.Name = "nudCombustivel";
            this.nudCombustivel.Size = new System.Drawing.Size(102, 26);
            this.nudCombustivel.TabIndex = 9;
            // 
            // nudPedagio
            // 
            this.nudPedagio.DecimalPlaces = 2;
            this.nudPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPedagio.Location = new System.Drawing.Point(249, 217);
            this.nudPedagio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPedagio.Name = "nudPedagio";
            this.nudPedagio.Size = new System.Drawing.Size(102, 26);
            this.nudPedagio.TabIndex = 10;
            this.nudPedagio.Visible = false;
            // 
            // chkGastoPedagio
            // 
            this.chkGastoPedagio.AutoSize = true;
            this.chkGastoPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGastoPedagio.Location = new System.Drawing.Point(16, 170);
            this.chkGastoPedagio.Name = "chkGastoPedagio";
            this.chkGastoPedagio.Size = new System.Drawing.Size(217, 24);
            this.chkGastoPedagio.TabIndex = 11;
            this.chkGastoPedagio.Text = "Incluir gastos com pedágio";
            this.chkGastoPedagio.UseVisualStyleBackColor = true;
            this.chkGastoPedagio.CheckedChanged += new System.EventHandler(this.chkGastoPedagio_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 258);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(414, 49);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 341);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.chkGastoPedagio);
            this.Controls.Add(this.nudPedagio);
            this.Controls.Add(this.nudCombustivel);
            this.Controls.Add(this.nudConsumo);
            this.Controls.Add(this.nudDistancia);
            this.Controls.Add(this.lblKml);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblPedagio);
            this.Controls.Add(this.lblCombustivel);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblDistancia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Calculadora da Viagem";
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCombustivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPedagio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Label lblPedagio;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblKml;
        private System.Windows.Forms.NumericUpDown nudDistancia;
        private System.Windows.Forms.NumericUpDown nudConsumo;
        private System.Windows.Forms.NumericUpDown nudCombustivel;
        private System.Windows.Forms.NumericUpDown nudPedagio;
        private System.Windows.Forms.CheckBox chkGastoPedagio;
        private System.Windows.Forms.Button btnCalcular;
    }
}

