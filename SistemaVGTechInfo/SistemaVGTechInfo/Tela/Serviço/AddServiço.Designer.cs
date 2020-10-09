namespace SistemaVGTechInfo.Tela.Serviço
{
    partial class AddServiço
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServiço));
            this.Text_nomeservico = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Text_precoservico = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.text_deletar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.data_db = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_db)).BeginInit();
            this.SuspendLayout();
            // 
            // Text_nomeservico
            // 
            this.Text_nomeservico.Depth = 0;
            this.Text_nomeservico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_nomeservico.Hint = "Nome do Serviço";
            this.Text_nomeservico.Location = new System.Drawing.Point(182, 149);
            this.Text_nomeservico.MouseState = MaterialSkin.MouseState.HOVER;
            this.Text_nomeservico.Name = "Text_nomeservico";
            this.Text_nomeservico.PasswordChar = '\0';
            this.Text_nomeservico.SelectedText = "";
            this.Text_nomeservico.SelectionLength = 0;
            this.Text_nomeservico.SelectionStart = 0;
            this.Text_nomeservico.Size = new System.Drawing.Size(211, 23);
            this.Text_nomeservico.TabIndex = 0;
            this.Text_nomeservico.UseSystemPasswordChar = false;
            // 
            // Text_precoservico
            // 
            this.Text_precoservico.Depth = 0;
            this.Text_precoservico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_precoservico.Hint = "Preço";
            this.Text_precoservico.Location = new System.Drawing.Point(445, 149);
            this.Text_precoservico.MouseState = MaterialSkin.MouseState.HOVER;
            this.Text_precoservico.Name = "Text_precoservico";
            this.Text_precoservico.PasswordChar = '\0';
            this.Text_precoservico.SelectedText = "";
            this.Text_precoservico.SelectionLength = 0;
            this.Text_precoservico.SelectionStart = 0;
            this.Text_precoservico.Size = new System.Drawing.Size(211, 23);
            this.Text_precoservico.TabIndex = 1;
            this.Text_precoservico.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton1.Location = new System.Drawing.Point(697, 149);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(167, 23);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Cadastrar Serviço";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(584, 313);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(167, 23);
            this.materialRaisedButton2.TabIndex = 4;
            this.materialRaisedButton2.Text = "Excluir";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // text_deletar
            // 
            this.text_deletar.Depth = 0;
            this.text_deletar.Hint = "Id do Serviço";
            this.text_deletar.Location = new System.Drawing.Point(332, 313);
            this.text_deletar.MouseState = MaterialSkin.MouseState.HOVER;
            this.text_deletar.Name = "text_deletar";
            this.text_deletar.PasswordChar = '\0';
            this.text_deletar.SelectedText = "";
            this.text_deletar.SelectionLength = 0;
            this.text_deletar.SelectionStart = 0;
            this.text_deletar.Size = new System.Drawing.Size(211, 23);
            this.text_deletar.TabIndex = 3;
            this.text_deletar.UseSystemPasswordChar = false;
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
            this.equipamento});
            this.data_db.Location = new System.Drawing.Point(162, 456);
            this.data_db.Name = "data_db";
            this.data_db.ReadOnly = true;
            this.data_db.RowHeadersWidth = 4;
            this.data_db.Size = new System.Drawing.Size(746, 208);
            this.data_db.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "VGTI_IDSERVICOS";
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 275;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "VGTI_NOMEDOSERVICOS";
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 335;
            // 
            // equipamento
            // 
            this.equipamento.DataPropertyName = "VGTI_PRECO";
            this.equipamento.HeaderText = "equipamento";
            this.equipamento.Name = "equipamento";
            this.equipamento.ReadOnly = true;
            this.equipamento.Width = 130;
            // 
            // AddServiço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1088, 696);
            this.Controls.Add(this.data_db);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.text_deletar);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.Text_precoservico);
            this.Controls.Add(this.Text_nomeservico);
            this.Name = "AddServiço";
            this.Text = "AddServiço";
            this.Load += new System.EventHandler(this.AddServiço_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_db)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Text_nomeservico;
        private MaterialSkin.Controls.MaterialSingleLineTextField Text_precoservico;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField text_deletar;
        private System.Windows.Forms.DataGridView data_db;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipamento;
    }
}