namespace SistemaVGTechInfo.Tela.Atendimento
{
    partial class AddAtendimento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAtendimento));
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_equipamento = new System.Windows.Forms.TextBox();
            this.text_preco = new System.Windows.Forms.TextBox();
            this.CheckServicos = new System.Windows.Forms.ComboBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_nome
            // 
            this.text_nome.BackColor = System.Drawing.Color.Silver;
            this.text_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nome.Location = new System.Drawing.Point(254, 241);
            this.text_nome.Multiline = true;
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(211, 25);
            this.text_nome.TabIndex = 0;
            // 
            // text_equipamento
            // 
            this.text_equipamento.BackColor = System.Drawing.Color.Silver;
            this.text_equipamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_equipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_equipamento.Location = new System.Drawing.Point(568, 241);
            this.text_equipamento.Multiline = true;
            this.text_equipamento.Name = "text_equipamento";
            this.text_equipamento.Size = new System.Drawing.Size(205, 25);
            this.text_equipamento.TabIndex = 1;
            // 
            // text_preco
            // 
            this.text_preco.BackColor = System.Drawing.Color.Silver;
            this.text_preco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_preco.Location = new System.Drawing.Point(568, 344);
            this.text_preco.Multiline = true;
            this.text_preco.Name = "text_preco";
            this.text_preco.Size = new System.Drawing.Size(211, 25);
            this.text_preco.TabIndex = 2;
            this.text_preco.TextChanged += new System.EventHandler(this.text_preco_TextChanged);
            // 
            // CheckServicos
            // 
            this.CheckServicos.FormattingEnabled = true;
            this.CheckServicos.Location = new System.Drawing.Point(254, 344);
            this.CheckServicos.Name = "CheckServicos";
            this.CheckServicos.Size = new System.Drawing.Size(211, 21);
            this.CheckServicos.TabIndex = 3;
            this.CheckServicos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(403, 455);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(213, 41);
            this.materialRaisedButton1.TabIndex = 4;
            this.materialRaisedButton1.Text = "Cadastrar Atendimento";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(305, 381);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(86, 23);
            this.materialRaisedButton2.TabIndex = 6;
            this.materialRaisedButton2.Text = "Pesquisar";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(187, 426);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(671, 5);
            this.materialDivider1.TabIndex = 7;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // AddAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1069, 710);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.CheckServicos);
            this.Controls.Add(this.text_preco);
            this.Controls.Add(this.text_equipamento);
            this.Controls.Add(this.text_nome);
            this.Name = "AddAtendimento";
            this.Text = "AddAtendimento";
            this.Load += new System.EventHandler(this.AddAtendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_equipamento;
        private System.Windows.Forms.TextBox text_preco;
        private System.Windows.Forms.ComboBox CheckServicos;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}