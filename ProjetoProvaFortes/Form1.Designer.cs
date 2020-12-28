
namespace ProjetoProvaFortes
{
    partial class btnJson
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
            this.btnLeitorTxt = new System.Windows.Forms.Button();
            this.btnJason = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeitorTxt
            // 
            this.btnLeitorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeitorTxt.Location = new System.Drawing.Point(52, 87);
            this.btnLeitorTxt.Name = "btnLeitorTxt";
            this.btnLeitorTxt.Size = new System.Drawing.Size(180, 140);
            this.btnLeitorTxt.TabIndex = 0;
            this.btnLeitorTxt.Text = "Leitor de .Txt";
            this.btnLeitorTxt.UseVisualStyleBackColor = true;
            this.btnLeitorTxt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnJason
            // 
            this.btnJason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJason.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnJason.Location = new System.Drawing.Point(300, 87);
            this.btnJason.Name = "btnJason";
            this.btnJason.Size = new System.Drawing.Size(180, 140);
            this.btnJason.TabIndex = 1;
            this.btnJason.Text = "Gerador  .Json";
            this.btnJason.UseVisualStyleBackColor = true;
            this.btnJason.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnXML
            // 
            this.btnXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXML.Location = new System.Drawing.Point(548, 87);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(180, 140);
            this.btnXML.TabIndex = 2;
            this.btnXML.Text = "Gerador .XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 306);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnJason);
            this.Controls.Add(this.btnLeitorTxt);
            this.Name = "btnJson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeitorTxt;
        private System.Windows.Forms.Button btnJason;
        private System.Windows.Forms.Button btnXML;
    }
}

