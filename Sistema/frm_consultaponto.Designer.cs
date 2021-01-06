namespace Sistema
{
    partial class frm_consultaponto
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
            this.CB_usuario = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.pontoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pontoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssUserConsulta = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pontoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pontoDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_usuario
            // 
            this.CB_usuario.DataSource = this.usuariosBindingSource;
            this.CB_usuario.DisplayMember = "Usuario";
            this.CB_usuario.FormattingEnabled = true;
            this.CB_usuario.Location = new System.Drawing.Point(255, 33);
            this.CB_usuario.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CB_usuario.Name = "CB_usuario";
            this.CB_usuario.Size = new System.Drawing.Size(356, 32);
            this.CB_usuario.TabIndex = 8;
            this.CB_usuario.ValueMember = "CodigoPessoa";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(sistema.DAL.Usuarios);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(149, 39);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(85, 25);
            this.lbl_usuario.TabIndex = 7;
            this.lbl_usuario.Text = "Usuário:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(477, 83);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(138, 42);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // pontoBindingSource
            // 
            this.pontoBindingSource.DataSource = typeof(sistema.DAL.Ponto);
            // 
            // pontoDataGridView
            // 
            this.pontoDataGridView.AllowUserToAddRows = false;
            this.pontoDataGridView.AllowUserToDeleteRows = false;
            this.pontoDataGridView.AutoGenerateColumns = false;
            this.pontoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pontoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pontoDataGridView.DataSource = this.pontoBindingSource;
            this.pontoDataGridView.Location = new System.Drawing.Point(22, 170);
            this.pontoDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pontoDataGridView.Name = "pontoDataGridView";
            this.pontoDataGridView.ReadOnly = true;
            this.pontoDataGridView.RowHeadersWidth = 72;
            this.pontoDataGridView.Size = new System.Drawing.Size(1001, 620);
            this.pontoDataGridView.TabIndex = 9;
            this.pontoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pontoDataGridView_CellContentClick);
            this.pontoDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.pontoDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Entrada";
            this.dataGridViewTextBoxColumn2.HeaderText = "Entrada";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Saida_almoco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Almoço";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Retorno_almoco";
            this.dataGridViewTextBoxColumn4.HeaderText = "Retorno";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 175;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Saida";
            this.dataGridViewTextBoxColumn5.HeaderText = "Saída";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 175;
            // 
            // dtp_Data
            // 
            this.dtp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Data.Location = new System.Drawing.Point(662, 35);
            this.dtp_Data.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(173, 29);
            this.dtp_Data.TabIndex = 10;
            this.dtp_Data.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssUserConsulta});
            this.statusStrip1.Location = new System.Drawing.Point(0, 797);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1045, 39);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssUserConsulta
            // 
            this.tssUserConsulta.Name = "tssUserConsulta";
            this.tssUserConsulta.Size = new System.Drawing.Size(62, 30);
            this.tssUserConsulta.Text = "USER";
            // 
            // frm_consultaponto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 836);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtp_Data);
            this.Controls.Add(this.pontoDataGridView);
            this.Controls.Add(this.CB_usuario);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.btn_buscar);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frm_consultaponto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamentos";
            this.Load += new System.EventHandler(this.frm_consultaponto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pontoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pontoDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.BindingSource pontoBindingSource;
        private System.Windows.Forms.DataGridView pontoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DateTimePicker dtp_Data;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssUserConsulta;
    }
}