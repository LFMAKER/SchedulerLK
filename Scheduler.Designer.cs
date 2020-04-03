namespace SchedulerLK
{
    partial class Scheduler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTipoProcesso = new System.Windows.Forms.Label();
            this.lblTempoUCP = new System.Windows.Forms.Label();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.btnCriarProcesso = new System.Windows.Forms.Button();
            this.TempoUCP = new System.Windows.Forms.NumericUpDown();
            this.Prioridade = new System.Windows.Forms.NumericUpDown();
            this.TipoProcesso = new System.Windows.Forms.ComboBox();
            this.GridProcessos = new System.Windows.Forms.DataGridView();
            this.PIDGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrioridadeGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoUCPGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProcessoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblGridCore1 = new System.Windows.Forms.Label();
            this.GridCore4 = new System.Windows.Forms.DataGridView();
            this.GridCore3 = new System.Windows.Forms.DataGridView();
            this.GridCore2 = new System.Windows.Forms.DataGridView();
            this.GridCore1 = new System.Windows.Forms.DataGridView();
            this.PIDGridCore1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoGridCore1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQtdProcessorCores = new System.Windows.Forms.Label();
            this.txtQtdProcesorCores = new System.Windows.Forms.TextBox();
            this.lblProcessorName = new System.Windows.Forms.Label();
            this.txtProcessorName = new System.Windows.Forms.TextBox();
            this.lblProcessTx = new System.Windows.Forms.Label();
            this.txtProcessTx = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PIDGridCore2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoGridCore2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIDGridCore3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoGridCore3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PIDGridCore4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoGridCore4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGridCore2 = new System.Windows.Forms.Label();
            this.lblGridCore3 = new System.Windows.Forms.Label();
            this.lblGridCore4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempoUCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prioridade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcessos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 534);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.lblTipoProcesso);
            this.tabPage1.Controls.Add(this.lblTempoUCP);
            this.tabPage1.Controls.Add(this.lblPrioridade);
            this.tabPage1.Controls.Add(this.btnCriarProcesso);
            this.tabPage1.Controls.Add(this.TempoUCP);
            this.tabPage1.Controls.Add(this.Prioridade);
            this.tabPage1.Controls.Add(this.TipoProcesso);
            this.tabPage1.Controls.Add(this.GridProcessos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scheduler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTipoProcesso
            // 
            this.lblTipoProcesso.AutoSize = true;
            this.lblTipoProcesso.Location = new System.Drawing.Point(215, 67);
            this.lblTipoProcesso.Name = "lblTipoProcesso";
            this.lblTipoProcesso.Size = new System.Drawing.Size(90, 13);
            this.lblTipoProcesso.TabIndex = 7;
            this.lblTipoProcesso.Text = "Tipo de Processo";
            // 
            // lblTempoUCP
            // 
            this.lblTempoUCP.AutoSize = true;
            this.lblTempoUCP.Location = new System.Drawing.Point(116, 67);
            this.lblTempoUCP.Name = "lblTempoUCP";
            this.lblTempoUCP.Size = new System.Drawing.Size(65, 13);
            this.lblTempoUCP.TabIndex = 6;
            this.lblTempoUCP.Text = "Tempo UCP";
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Location = new System.Drawing.Point(17, 68);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(54, 13);
            this.lblPrioridade.TabIndex = 5;
            this.lblPrioridade.Text = "Prioridade";
            // 
            // btnCriarProcesso
            // 
            this.btnCriarProcesso.Location = new System.Drawing.Point(347, 80);
            this.btnCriarProcesso.Name = "btnCriarProcesso";
            this.btnCriarProcesso.Size = new System.Drawing.Size(85, 31);
            this.btnCriarProcesso.TabIndex = 4;
            this.btnCriarProcesso.Text = "Criar Processo";
            this.btnCriarProcesso.UseVisualStyleBackColor = true;
            this.btnCriarProcesso.Click += new System.EventHandler(this.btnCriarProcesso_Click);
            // 
            // TempoUCP
            // 
            this.TempoUCP.Location = new System.Drawing.Point(116, 86);
            this.TempoUCP.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TempoUCP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TempoUCP.Name = "TempoUCP";
            this.TempoUCP.Size = new System.Drawing.Size(74, 20);
            this.TempoUCP.TabIndex = 3;
            this.TempoUCP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Prioridade
            // 
            this.Prioridade.Location = new System.Drawing.Point(17, 87);
            this.Prioridade.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Prioridade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Prioridade.Name = "Prioridade";
            this.Prioridade.Size = new System.Drawing.Size(72, 20);
            this.Prioridade.TabIndex = 2;
            this.Prioridade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TipoProcesso
            // 
            this.TipoProcesso.FormattingEnabled = true;
            this.TipoProcesso.Location = new System.Drawing.Point(218, 85);
            this.TipoProcesso.Name = "TipoProcesso";
            this.TipoProcesso.Size = new System.Drawing.Size(113, 21);
            this.TipoProcesso.TabIndex = 1;
            this.TipoProcesso.SelectedIndexChanged += new System.EventHandler(this.TipoProcesso_SelectedIndexChanged);
            // 
            // GridProcessos
            // 
            this.GridProcessos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.GridProcessos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProcessos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PIDGrid,
            this.PrioridadeGrid,
            this.EstadoGrid,
            this.TempoUCPGrid,
            this.TipoProcessoGrid});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProcessos.DefaultCellStyle = dataGridViewCellStyle1;
            this.GridProcessos.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.GridProcessos.Location = new System.Drawing.Point(17, 173);
            this.GridProcessos.Name = "GridProcessos";
            this.GridProcessos.ReadOnly = true;
            this.GridProcessos.Size = new System.Drawing.Size(523, 271);
            this.GridProcessos.TabIndex = 0;
            // 
            // PIDGrid
            // 
            this.PIDGrid.HeaderText = "PID";
            this.PIDGrid.Name = "PIDGrid";
            this.PIDGrid.ReadOnly = true;
            // 
            // PrioridadeGrid
            // 
            this.PrioridadeGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PrioridadeGrid.FillWeight = 50F;
            this.PrioridadeGrid.HeaderText = "Prioridade";
            this.PrioridadeGrid.Name = "PrioridadeGrid";
            this.PrioridadeGrid.ReadOnly = true;
            this.PrioridadeGrid.Width = 79;
            // 
            // EstadoGrid
            // 
            this.EstadoGrid.HeaderText = "Estado";
            this.EstadoGrid.Name = "EstadoGrid";
            this.EstadoGrid.ReadOnly = true;
            // 
            // TempoUCPGrid
            // 
            this.TempoUCPGrid.HeaderText = "Tempo UCP";
            this.TempoUCPGrid.Name = "TempoUCPGrid";
            this.TempoUCPGrid.ReadOnly = true;
            // 
            // TipoProcessoGrid
            // 
            this.TipoProcessoGrid.HeaderText = "Tipo Processo";
            this.TipoProcessoGrid.Name = "TipoProcessoGrid";
            this.TipoProcessoGrid.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblGridCore4);
            this.tabPage2.Controls.Add(this.lblGridCore3);
            this.tabPage2.Controls.Add(this.lblGridCore2);
            this.tabPage2.Controls.Add(this.lblGridCore1);
            this.tabPage2.Controls.Add(this.GridCore4);
            this.tabPage2.Controls.Add(this.GridCore3);
            this.tabPage2.Controls.Add(this.GridCore2);
            this.tabPage2.Controls.Add(this.GridCore1);
            this.tabPage2.Controls.Add(this.lblQtdProcessorCores);
            this.tabPage2.Controls.Add(this.txtQtdProcesorCores);
            this.tabPage2.Controls.Add(this.lblProcessorName);
            this.tabPage2.Controls.Add(this.txtProcessorName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Processador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblGridCore1
            // 
            this.lblGridCore1.AutoSize = true;
            this.lblGridCore1.Location = new System.Drawing.Point(126, 130);
            this.lblGridCore1.Name = "lblGridCore1";
            this.lblGridCore1.Size = new System.Drawing.Size(38, 13);
            this.lblGridCore1.TabIndex = 8;
            this.lblGridCore1.Text = "Core 1";
            // 
            // GridCore4
            // 
            this.GridCore4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCore4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PIDGridCore4,
            this.EstadoGridCore4});
            this.GridCore4.Location = new System.Drawing.Point(320, 338);
            this.GridCore4.Name = "GridCore4";
            this.GridCore4.ReadOnly = true;
            this.GridCore4.Size = new System.Drawing.Size(251, 150);
            this.GridCore4.TabIndex = 7;
            // 
            // GridCore3
            // 
            this.GridCore3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCore3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PIDGridCore3,
            this.EstadoGridCore3});
            this.GridCore3.Location = new System.Drawing.Point(611, 143);
            this.GridCore3.Name = "GridCore3";
            this.GridCore3.ReadOnly = true;
            this.GridCore3.Size = new System.Drawing.Size(247, 150);
            this.GridCore3.TabIndex = 6;
            // 
            // GridCore2
            // 
            this.GridCore2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCore2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PIDGridCore2,
            this.EstadoGridCore2});
            this.GridCore2.Location = new System.Drawing.Point(320, 143);
            this.GridCore2.Name = "GridCore2";
            this.GridCore2.ReadOnly = true;
            this.GridCore2.Size = new System.Drawing.Size(248, 150);
            this.GridCore2.TabIndex = 5;
            // 
            // GridCore1
            // 
            this.GridCore1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCore1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PIDGridCore1,
            this.EstadoGridCore1});
            this.GridCore1.Location = new System.Drawing.Point(23, 146);
            this.GridCore1.Name = "GridCore1";
            this.GridCore1.ReadOnly = true;
            this.GridCore1.Size = new System.Drawing.Size(244, 147);
            this.GridCore1.TabIndex = 4;
            // 
            // PIDGridCore1
            // 
            this.PIDGridCore1.HeaderText = "PID";
            this.PIDGridCore1.Name = "PIDGridCore1";
            this.PIDGridCore1.ReadOnly = true;
            // 
            // EstadoGridCore1
            // 
            this.EstadoGridCore1.HeaderText = "Estado";
            this.EstadoGridCore1.Name = "EstadoGridCore1";
            this.EstadoGridCore1.ReadOnly = true;
            // 
            // lblQtdProcessorCores
            // 
            this.lblQtdProcessorCores.AutoSize = true;
            this.lblQtdProcessorCores.Location = new System.Drawing.Point(328, 46);
            this.lblQtdProcessorCores.Name = "lblQtdProcessorCores";
            this.lblQtdProcessorCores.Size = new System.Drawing.Size(107, 13);
            this.lblQtdProcessorCores.TabIndex = 3;
            this.lblQtdProcessorCores.Text = "Quantidade de Cores";
            // 
            // txtQtdProcesorCores
            // 
            this.txtQtdProcesorCores.Location = new System.Drawing.Point(328, 65);
            this.txtQtdProcesorCores.Name = "txtQtdProcesorCores";
            this.txtQtdProcesorCores.ReadOnly = true;
            this.txtQtdProcesorCores.Size = new System.Drawing.Size(158, 20);
            this.txtQtdProcesorCores.TabIndex = 2;
            // 
            // lblProcessorName
            // 
            this.lblProcessorName.AutoSize = true;
            this.lblProcessorName.Location = new System.Drawing.Point(23, 46);
            this.lblProcessorName.Name = "lblProcessorName";
            this.lblProcessorName.Size = new System.Drawing.Size(66, 13);
            this.lblProcessorName.TabIndex = 1;
            this.lblProcessorName.Text = "Processador";
            // 
            // txtProcessorName
            // 
            this.txtProcessorName.Location = new System.Drawing.Point(23, 65);
            this.txtProcessorName.Name = "txtProcessorName";
            this.txtProcessorName.ReadOnly = true;
            this.txtProcessorName.Size = new System.Drawing.Size(262, 20);
            this.txtProcessorName.TabIndex = 0;
            // 
            // lblProcessTx
            // 
            this.lblProcessTx.AutoSize = true;
            this.lblProcessTx.Location = new System.Drawing.Point(781, 555);
            this.lblProcessTx.Name = "lblProcessTx";
            this.lblProcessTx.Size = new System.Drawing.Size(60, 13);
            this.lblProcessTx.TabIndex = 1;
            this.lblProcessTx.Text = "Process Tx";
            // 
            // txtProcessTx
            // 
            this.txtProcessTx.Location = new System.Drawing.Point(847, 552);
            this.txtProcessTx.Name = "txtProcessTx";
            this.txtProcessTx.ReadOnly = true;
            this.txtProcessTx.Size = new System.Drawing.Size(65, 20);
            this.txtProcessTx.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // PIDGridCore2
            // 
            this.PIDGridCore2.HeaderText = "PID";
            this.PIDGridCore2.Name = "PIDGridCore2";
            this.PIDGridCore2.ReadOnly = true;
            // 
            // EstadoGridCore2
            // 
            this.EstadoGridCore2.HeaderText = "Estado";
            this.EstadoGridCore2.Name = "EstadoGridCore2";
            this.EstadoGridCore2.ReadOnly = true;
            // 
            // PIDGridCore3
            // 
            this.PIDGridCore3.HeaderText = "PID";
            this.PIDGridCore3.Name = "PIDGridCore3";
            this.PIDGridCore3.ReadOnly = true;
            // 
            // EstadoGridCore3
            // 
            this.EstadoGridCore3.HeaderText = "Estado";
            this.EstadoGridCore3.Name = "EstadoGridCore3";
            this.EstadoGridCore3.ReadOnly = true;
            // 
            // PIDGridCore4
            // 
            this.PIDGridCore4.HeaderText = "PID";
            this.PIDGridCore4.Name = "PIDGridCore4";
            this.PIDGridCore4.ReadOnly = true;
            // 
            // EstadoGridCore4
            // 
            this.EstadoGridCore4.HeaderText = "Estado";
            this.EstadoGridCore4.Name = "EstadoGridCore4";
            this.EstadoGridCore4.ReadOnly = true;
            // 
            // lblGridCore2
            // 
            this.lblGridCore2.AutoSize = true;
            this.lblGridCore2.Location = new System.Drawing.Point(399, 124);
            this.lblGridCore2.Name = "lblGridCore2";
            this.lblGridCore2.Size = new System.Drawing.Size(38, 13);
            this.lblGridCore2.TabIndex = 9;
            this.lblGridCore2.Text = "Core 2";
            // 
            // lblGridCore3
            // 
            this.lblGridCore3.AutoSize = true;
            this.lblGridCore3.Location = new System.Drawing.Point(709, 123);
            this.lblGridCore3.Name = "lblGridCore3";
            this.lblGridCore3.Size = new System.Drawing.Size(38, 13);
            this.lblGridCore3.TabIndex = 10;
            this.lblGridCore3.Text = "Core 3";
            // 
            // lblGridCore4
            // 
            this.lblGridCore4.AutoSize = true;
            this.lblGridCore4.Location = new System.Drawing.Point(401, 319);
            this.lblGridCore4.Name = "lblGridCore4";
            this.lblGridCore4.Size = new System.Drawing.Size(38, 13);
            this.lblGridCore4.TabIndex = 11;
            this.lblGridCore4.Text = "Core 4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(598, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(269, 377);
            this.dataGridView1.TabIndex = 8;
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 584);
            this.Controls.Add(this.txtProcessTx);
            this.Controls.Add(this.lblProcessTx);
            this.Controls.Add(this.tabControl1);
            this.Name = "Scheduler";
            this.Text = "SchedulerLK";
            this.Load += new System.EventHandler(this.Scheduler_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempoUCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prioridade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcessos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown TempoUCP;
        private System.Windows.Forms.NumericUpDown Prioridade;
        private System.Windows.Forms.ComboBox TipoProcesso;
        private System.Windows.Forms.DataGridView GridProcessos;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.Button btnCriarProcesso;
        private System.Windows.Forms.Label lblTipoProcesso;
        private System.Windows.Forms.Label lblTempoUCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIDGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrioridadeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoUCPGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProcessoGrid;
        private System.Windows.Forms.Label lblProcessorName;
        private System.Windows.Forms.TextBox txtProcessorName;
        private System.Windows.Forms.Label lblQtdProcessorCores;
        private System.Windows.Forms.TextBox txtQtdProcesorCores;
        private System.Windows.Forms.Label lblProcessTx;
        private System.Windows.Forms.TextBox txtProcessTx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView GridCore4;
        private System.Windows.Forms.DataGridView GridCore3;
        private System.Windows.Forms.DataGridView GridCore2;
        private System.Windows.Forms.DataGridView GridCore1;
        private System.Windows.Forms.Label lblGridCore1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIDGridCore1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoGridCore1;
        private System.Windows.Forms.Label lblGridCore4;
        private System.Windows.Forms.Label lblGridCore3;
        private System.Windows.Forms.Label lblGridCore2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIDGridCore4;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoGridCore4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIDGridCore3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoGridCore3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIDGridCore2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoGridCore2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

