namespace SistemaVGTechInfo.Tela.Inicio
{
    partial class InicioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            this.data_db = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.text_cod = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            this.data_db.Location = new System.Drawing.Point(27, 244);
            this.data_db.Name = "data_db";
            this.data_db.ReadOnly = true;
            this.data_db.RowHeadersWidth = 4;
            this.data_db.Size = new System.Drawing.Size(1026, 439);
            this.data_db.TabIndex = 5;
            this.data_db.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_db_CellContentClick);
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
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(591, 135);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(78, 23);
            this.materialRaisedButton2.TabIndex = 7;
            this.materialRaisedButton2.Text = "Fechar";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // text_cod
            // 
            this.text_cod.Depth = 0;
            this.text_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_cod.Hint = "Codigo Atendimento";
            this.text_cod.Location = new System.Drawing.Point(397, 135);
            this.text_cod.MouseState = MaterialSkin.MouseState.HOVER;
            this.text_cod.Name = "text_cod";
            this.text_cod.PasswordChar = '\0';
            this.text_cod.SelectedText = "";
            this.text_cod.SelectionLength = 0;
            this.text_cod.SelectionStart = 0;
            this.text_cod.Size = new System.Drawing.Size(179, 23);
            this.text_cod.TabIndex = 8;
            this.text_cod.UseSystemPasswordChar = false;
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1091, 713);
            this.Controls.Add(this.text_cod);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.data_db);
            this.Name = "InicioForm";
            this.Text = "InicioForm";
            this.Load += new System.EventHandler(this.InicioForm_Load);
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
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField text_cod;
    }
}