namespace PSaula4ex
{
    partial class frmEscolha
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscolha));
            this.pictureCadastrar = new System.Windows.Forms.PictureBox();
            this.pictureConsulta = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCadastrar
            // 
            this.pictureCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureCadastrar.Image")));
            this.pictureCadastrar.Location = new System.Drawing.Point(226, 50);
            this.pictureCadastrar.Name = "pictureCadastrar";
            this.pictureCadastrar.Size = new System.Drawing.Size(136, 102);
            this.pictureCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCadastrar.TabIndex = 1;
            this.pictureCadastrar.TabStop = false;
            this.pictureCadastrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureConsulta
            // 
            this.pictureConsulta.Image = ((System.Drawing.Image)(resources.GetObject("pictureConsulta.Image")));
            this.pictureConsulta.Location = new System.Drawing.Point(12, 50);
            this.pictureConsulta.Name = "pictureConsulta";
            this.pictureConsulta.Size = new System.Drawing.Size(136, 102);
            this.pictureConsulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureConsulta.TabIndex = 2;
            this.pictureConsulta.TabStop = false;
            this.pictureConsulta.Click += new System.EventHandler(this.pictureConsulta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cadastrar";
            // 
            // frmEscolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 201);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureConsulta);
            this.Controls.Add(this.pictureCadastrar);
            this.Name = "frmEscolha";
            this.Text = "Escolha";
            this.Controls.SetChildIndex(this.pictureCadastrar, 0);
            this.Controls.SetChildIndex(this.pictureConsulta, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCadastrar;
        private System.Windows.Forms.PictureBox pictureConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

