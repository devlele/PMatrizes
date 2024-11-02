namespace PMatrizes
{
    partial class frmEercicio5
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lstbxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(28, 46);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(171, 128);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Verificar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lstbxResultado
            // 
            this.lstbxResultado.FormattingEnabled = true;
            this.lstbxResultado.ItemHeight = 16;
            this.lstbxResultado.Location = new System.Drawing.Point(256, 23);
            this.lstbxResultado.Name = "lstbxResultado";
            this.lstbxResultado.Size = new System.Drawing.Size(505, 388);
            this.lstbxResultado.TabIndex = 1;
            // 
            // frmEercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbxResultado);
            this.Controls.Add(this.btnExecutar);
            this.Name = "frmEercicio5";
            this.Text = "frmEercicio5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.ListBox lstbxResultado;
    }
}