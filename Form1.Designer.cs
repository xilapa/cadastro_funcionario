namespace cadastro_funcionario
{
    partial class cad_func
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_main = new System.Windows.Forms.Label();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_dn = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.txtbx_matricula = new System.Windows.Forms.TextBox();
            this.txtbx_cpf = new System.Windows.Forms.TextBox();
            this.txtbx_nome = new System.Windows.Forms.TextBox();
            this.txtbx_dn = new System.Windows.Forms.MaskedTextBox();
            this.txtbx_endereco = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.dataGridViewFuncionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_main
            // 
            this.lbl_main.AutoSize = true;
            this.lbl_main.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_main.Location = new System.Drawing.Point(12, 9);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(180, 38);
            this.lbl_main.TabIndex = 0;
            this.lbl_main.Text = "Informações";
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_matricula.Location = new System.Drawing.Point(12, 75);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(94, 28);
            this.lbl_matricula.TabIndex = 1;
            this.lbl_matricula.Text = "Matrícula";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cpf.Location = new System.Drawing.Point(12, 113);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(45, 28);
            this.lbl_cpf.TabIndex = 1;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nome.Location = new System.Drawing.Point(12, 151);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(66, 28);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_dn
            // 
            this.lbl_dn.AutoSize = true;
            this.lbl_dn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dn.Location = new System.Drawing.Point(12, 189);
            this.lbl_dn.Name = "lbl_dn";
            this.lbl_dn.Size = new System.Drawing.Size(185, 28);
            this.lbl_dn.TabIndex = 1;
            this.lbl_dn.Text = "Data de nascimento";
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_endereco.Location = new System.Drawing.Point(12, 227);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(93, 28);
            this.lbl_endereco.TabIndex = 1;
            this.lbl_endereco.Text = "Endereço";
            // 
            // txtbx_matricula
            // 
            this.txtbx_matricula.Location = new System.Drawing.Point(220, 80);
            this.txtbx_matricula.Name = "txtbx_matricula";
            this.txtbx_matricula.ReadOnly = true;
            this.txtbx_matricula.Size = new System.Drawing.Size(100, 23);
            this.txtbx_matricula.TabIndex = 2;
            this.txtbx_matricula.TabStop = false;
            // 
            // txtbx_cpf
            // 
            this.txtbx_cpf.Location = new System.Drawing.Point(220, 118);
            this.txtbx_cpf.Name = "txtbx_cpf";
            this.txtbx_cpf.Size = new System.Drawing.Size(100, 23);
            this.txtbx_cpf.TabIndex = 1;
            // 
            // txtbx_nome
            // 
            this.txtbx_nome.Location = new System.Drawing.Point(220, 156);
            this.txtbx_nome.Name = "txtbx_nome";
            this.txtbx_nome.Size = new System.Drawing.Size(425, 23);
            this.txtbx_nome.TabIndex = 2;
            // 
            // txtbx_dn
            // 
            this.txtbx_dn.Location = new System.Drawing.Point(220, 194);
            this.txtbx_dn.Mask = "00/00/0000";
            this.txtbx_dn.Name = "txtbx_dn";
            this.txtbx_dn.Size = new System.Drawing.Size(100, 23);
            this.txtbx_dn.TabIndex = 3;
            // 
            // txtbx_endereco
            // 
            this.txtbx_endereco.Location = new System.Drawing.Point(220, 232);
            this.txtbx_endereco.Name = "txtbx_endereco";
            this.txtbx_endereco.Size = new System.Drawing.Size(425, 23);
            this.txtbx_endereco.TabIndex = 4;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(663, 128);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(125, 27);
            this.btn_pesquisar.TabIndex = 3;
            this.btn_pesquisar.TabStop = false;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(663, 161);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(125, 27);
            this.btn_salvar.TabIndex = 3;
            this.btn_salvar.TabStop = false;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(663, 194);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(125, 27);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.TabStop = false;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(663, 228);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(125, 27);
            this.btn_limpar.TabIndex = 3;
            this.btn_limpar.TabStop = false;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // dataGridViewFuncionarios
            // 
            this.dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionarios.Location = new System.Drawing.Point(18, 275);
            this.dataGridViewFuncionarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            this.dataGridViewFuncionarios.Size = new System.Drawing.Size(764, 165);
            this.dataGridViewFuncionarios.TabIndex = 0;
            this.dataGridViewFuncionarios.TabStop = false;
            this.dataGridViewFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFuncionarios_CellContentClick);
            // 
            // cad_func
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbx_dn);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.txtbx_endereco);
            this.Controls.Add(this.txtbx_nome);
            this.Controls.Add(this.txtbx_cpf);
            this.Controls.Add(this.txtbx_matricula);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.lbl_dn);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_matricula);
            this.Controls.Add(this.lbl_main);
            this.Controls.Add(this.dataGridViewFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cad_func";
            this.Text = "Cadastro de Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_main;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_dn;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.TextBox txtbx_matricula;
        private System.Windows.Forms.TextBox txtbx_cpf;
        private System.Windows.Forms.TextBox txtbx_nome;
        private System.Windows.Forms.TextBox txtbx_endereco;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.DataGridView dataGridViewFuncionarios; //data grid
        private System.Windows.Forms.MaskedTextBox txtbx_dn;
    }
}

