namespace SistemaVGTechInfo.Tela.Fechados
{
    partial class chamadosFechados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chamadosFechados));
            this.data_db = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_db)).BeginInit();
            this.SuspendLayout();
            // 
            // data_db
            // 
            this.data_db.AllowUserToDeleteRows = false;
            this.data_db.BackgroundColor = System.Drawing.Color.White;
            this.data_db.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_db.ColumnHeadersVisible = false;
            this.data_db.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nome,
            this.equipamento,
            this.servico,
            this.preco});
            this.data_db.Location = new System.Drawing.Point(52, 150);
            this.data_db.Name = "data_db";
            this.data_db.ReadOnly = true;
            this.data_db.RowHeadersWidth = 4;
            this.data_db.Size = new System.Drawing.Size(979, 439);
            this.data_db.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "VGTI_IDATENDIMENTO";
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "VGTI_NOME";
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 200;
            // 
            // equipamento
            // 
            this.equipamento.DataPropertyName = "VGTI_EQUIPAMENTO";
            this.equipamento.HeaderText = "equipamento";
            this.equipamento.Name = "equipamento";
            this.equipamento.ReadOnly = true;
            this.equipamento.Width = 235;
            // 
            // servico
            // 
            this.servico.DataPropertyName = "VGTI_SERVICO";
            this.servico.HeaderText = "servico";
            this.servico.Name = "servico";
            this.servico.ReadOnly = true;
            this.servico.Width = 230;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "VGTI_PRECO";
            this.preco.HeaderText = "preco";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Width = 225;
            // 
            // chamadosFechados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1068, 693);
            this.Controls.Add(this.data_db);
            this.Name = "chamadosFechados";
            this.Text = "chamadosFechados";
            this.Load += new System.EventHandler(this.chamadosFechados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_db)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_db;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn servico;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
    }
}