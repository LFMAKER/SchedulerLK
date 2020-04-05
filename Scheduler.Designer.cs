using System;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scheduler));
            this.TipoProcesso = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GridProcessos = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.PidGridProcessos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrioridadeGridProcessos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoGridProcessos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempoUCPGridProcessos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProcessoGridProcessos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgoraGridProcessos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LKPagesPrincipal = new Bunifu.UI.WinForms.BunifuPages();
            this.SchedulerPage = new System.Windows.Forms.TabPage();
            this.TempoUCP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTipoProcesso = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblPrioridadeValor = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblPrioridade = new Bunifu.UI.WinForms.BunifuLabel();
            this.SliderPrioridade = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btnCriarProcesso = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ProcessadorPage = new System.Windows.Forms.TabPage();
            this.lblCore4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblCore3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblCore2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblCore1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.GridCore4 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Pid4Core = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado4Core = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCore3 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Pid3Core = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado3Core = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCore2 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.PID2Core = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado2Core = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCore1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Grid1Core = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado1Core = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SobrePage = new System.Windows.Forms.TabPage();
            this.btnSobreUsar = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblSobreNome = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnScheduler = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnProcessador = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ProgressTx = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lblTx = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnFechar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSobre = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblTempUCP = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridProcessos)).BeginInit();
            this.LKPagesPrincipal.SuspendLayout();
            this.SchedulerPage.SuspendLayout();
            this.ProcessadorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore1)).BeginInit();
            this.SobrePage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TipoProcesso
            // 
            this.TipoProcesso.DropDownHeight = 150;
            this.TipoProcesso.DropDownWidth = 150;
            this.TipoProcesso.FormattingEnabled = true;
            this.TipoProcesso.IntegralHeight = false;
            this.TipoProcesso.Location = new System.Drawing.Point(511, 118);
            this.TipoProcesso.Name = "TipoProcesso";
            this.TipoProcesso.Size = new System.Drawing.Size(113, 21);
            this.TipoProcesso.TabIndex = 1;
            this.TipoProcesso.SelectedIndexChanged += new System.EventHandler(this.TipoProcesso_SelectedIndexChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // GridProcessos
            // 
            this.GridProcessos.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.GridProcessos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridProcessos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridProcessos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.GridProcessos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridProcessos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridProcessos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridProcessos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridProcessos.ColumnHeadersHeight = 40;
            this.GridProcessos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PidGridProcessos,
            this.PrioridadeGridProcessos,
            this.EstadoGridProcessos,
            this.TempoUCPGridProcessos,
            this.TipoProcessoGridProcessos,
            this.AgoraGridProcessos});
            this.GridProcessos.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.GridProcessos.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridProcessos.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridProcessos.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.GridProcessos.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.GridProcessos.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.GridProcessos.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.GridProcessos.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.GridProcessos.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.GridProcessos.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridProcessos.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.GridProcessos.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridProcessos.CurrentTheme.Name = null;
            this.GridProcessos.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridProcessos.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridProcessos.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridProcessos.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.GridProcessos.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridProcessos.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridProcessos.EnableHeadersVisualStyles = false;
            this.GridProcessos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.GridProcessos.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.GridProcessos.HeaderBgColor = System.Drawing.Color.Empty;
            this.GridProcessos.HeaderForeColor = System.Drawing.Color.White;
            this.GridProcessos.Location = new System.Drawing.Point(27, 167);
            this.GridProcessos.Name = "GridProcessos";
            this.GridProcessos.RowHeadersVisible = false;
            this.GridProcessos.RowTemplate.Height = 40;
            this.GridProcessos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProcessos.Size = new System.Drawing.Size(1071, 292);
            this.GridProcessos.TabIndex = 8;
            this.GridProcessos.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // PidGridProcessos
            // 
            this.PidGridProcessos.HeaderText = "PID";
            this.PidGridProcessos.Name = "PidGridProcessos";
            // 
            // PrioridadeGridProcessos
            // 
            this.PrioridadeGridProcessos.HeaderText = "Prioridade";
            this.PrioridadeGridProcessos.Name = "PrioridadeGridProcessos";
            // 
            // EstadoGridProcessos
            // 
            this.EstadoGridProcessos.HeaderText = "Estado";
            this.EstadoGridProcessos.Name = "EstadoGridProcessos";
            // 
            // TempoUCPGridProcessos
            // 
            this.TempoUCPGridProcessos.HeaderText = "Tempo UCP";
            this.TempoUCPGridProcessos.Name = "TempoUCPGridProcessos";
            // 
            // TipoProcessoGridProcessos
            // 
            this.TipoProcessoGridProcessos.HeaderText = "Tipo Processo";
            this.TipoProcessoGridProcessos.Name = "TipoProcessoGridProcessos";
            // 
            // AgoraGridProcessos
            // 
            this.AgoraGridProcessos.HeaderText = "Agora";
            this.AgoraGridProcessos.Name = "AgoraGridProcessos";
            // 
            // LKPagesPrincipal
            // 
            this.LKPagesPrincipal.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.LKPagesPrincipal.AllowTransitions = true;
            this.LKPagesPrincipal.Controls.Add(this.SchedulerPage);
            this.LKPagesPrincipal.Controls.Add(this.ProcessadorPage);
            this.LKPagesPrincipal.Controls.Add(this.SobrePage);
            this.LKPagesPrincipal.Location = new System.Drawing.Point(12, 77);
            this.LKPagesPrincipal.Multiline = true;
            this.LKPagesPrincipal.Name = "LKPagesPrincipal";
            this.LKPagesPrincipal.Page = this.SchedulerPage;
            this.LKPagesPrincipal.PageIndex = 0;
            this.LKPagesPrincipal.PageName = "SchedulerPage";
            this.LKPagesPrincipal.PageTitle = "Scheduler";
            this.LKPagesPrincipal.SelectedIndex = 0;
            this.LKPagesPrincipal.Size = new System.Drawing.Size(1131, 504);
            this.LKPagesPrincipal.TabIndex = 3;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.LKPagesPrincipal.Transition = animation1;
            this.LKPagesPrincipal.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // SchedulerPage
            // 
            this.SchedulerPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.SchedulerPage.Controls.Add(this.lblTempUCP);
            this.SchedulerPage.Controls.Add(this.TempoUCP);
            this.SchedulerPage.Controls.Add(this.lblTipoProcesso);
            this.SchedulerPage.Controls.Add(this.lblPrioridadeValor);
            this.SchedulerPage.Controls.Add(this.lblPrioridade);
            this.SchedulerPage.Controls.Add(this.SliderPrioridade);
            this.SchedulerPage.Controls.Add(this.btnCriarProcesso);
            this.SchedulerPage.Controls.Add(this.GridProcessos);
            this.SchedulerPage.Controls.Add(this.TipoProcesso);
            this.SchedulerPage.Location = new System.Drawing.Point(4, 4);
            this.SchedulerPage.Name = "SchedulerPage";
            this.SchedulerPage.Padding = new System.Windows.Forms.Padding(3);
            this.SchedulerPage.Size = new System.Drawing.Size(1123, 478);
            this.SchedulerPage.TabIndex = 0;
            this.SchedulerPage.Text = "Scheduler";
            // 
            // TempoUCP
            // 
            this.TempoUCP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TempoUCP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TempoUCP.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TempoUCP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TempoUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempoUCP.ForeColor = System.Drawing.Color.White;
            this.TempoUCP.HintForeColor = System.Drawing.Color.Empty;
            this.TempoUCP.HintText = "";
            this.TempoUCP.isPassword = false;
            this.TempoUCP.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.TempoUCP.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.TempoUCP.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.TempoUCP.LineThickness = 4;
            this.TempoUCP.Location = new System.Drawing.Point(310, 103);
            this.TempoUCP.Margin = new System.Windows.Forms.Padding(4);
            this.TempoUCP.MaxLength = 32767;
            this.TempoUCP.Name = "TempoUCP";
            this.TempoUCP.Size = new System.Drawing.Size(155, 36);
            this.TempoUCP.TabIndex = 14;
            this.TempoUCP.Text = "1";
            this.TempoUCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TempoUCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TempoUCP_KeyPress);
            // 
            // lblTipoProcesso
            // 
            this.lblTipoProcesso.AutoEllipsis = false;
            this.lblTipoProcesso.CursorType = null;
            this.lblTipoProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProcesso.ForeColor = System.Drawing.Color.White;
            this.lblTipoProcesso.Location = new System.Drawing.Point(511, 70);
            this.lblTipoProcesso.Name = "lblTipoProcesso";
            this.lblTipoProcesso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTipoProcesso.Size = new System.Drawing.Size(125, 22);
            this.lblTipoProcesso.TabIndex = 13;
            this.lblTipoProcesso.Text = "Tipo de Processo";
            this.lblTipoProcesso.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTipoProcesso.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblPrioridadeValor
            // 
            this.lblPrioridadeValor.AutoEllipsis = false;
            this.lblPrioridadeValor.CursorType = null;
            this.lblPrioridadeValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridadeValor.ForeColor = System.Drawing.Color.White;
            this.lblPrioridadeValor.Location = new System.Drawing.Point(249, 118);
            this.lblPrioridadeValor.Name = "lblPrioridadeValor";
            this.lblPrioridadeValor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrioridadeValor.Size = new System.Drawing.Size(12, 22);
            this.lblPrioridadeValor.TabIndex = 12;
            this.lblPrioridadeValor.Text = "1";
            this.lblPrioridadeValor.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrioridadeValor.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoEllipsis = false;
            this.lblPrioridade.CursorType = null;
            this.lblPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridade.ForeColor = System.Drawing.Color.White;
            this.lblPrioridade.Location = new System.Drawing.Point(140, 70);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrioridade.Size = new System.Drawing.Size(74, 22);
            this.lblPrioridade.TabIndex = 11;
            this.lblPrioridade.Text = "Prioridade";
            this.lblPrioridade.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPrioridade.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SliderPrioridade
            // 
            this.SliderPrioridade.AllowCursorChanges = true;
            this.SliderPrioridade.AllowHomeEndKeysDetection = false;
            this.SliderPrioridade.AllowIncrementalClickMoves = true;
            this.SliderPrioridade.AllowMouseDownEffects = false;
            this.SliderPrioridade.AllowMouseHoverEffects = false;
            this.SliderPrioridade.AllowScrollingAnimations = true;
            this.SliderPrioridade.AllowScrollKeysDetection = true;
            this.SliderPrioridade.AllowScrollOptionsMenu = true;
            this.SliderPrioridade.AllowShrinkingOnFocusLost = false;
            this.SliderPrioridade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SliderPrioridade.BackgroundImage")));
            this.SliderPrioridade.BindingContainer = null;
            this.SliderPrioridade.BorderRadius = 2;
            this.SliderPrioridade.BorderThickness = 1;
            this.SliderPrioridade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SliderPrioridade.DrawThickBorder = false;
            this.SliderPrioridade.DurationBeforeShrink = 2000;
            this.SliderPrioridade.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.SliderPrioridade.LargeChange = 1;
            this.SliderPrioridade.Location = new System.Drawing.Point(102, 111);
            this.SliderPrioridade.Maximum = 10;
            this.SliderPrioridade.Minimum = 1;
            this.SliderPrioridade.MinimumSize = new System.Drawing.Size(0, 31);
            this.SliderPrioridade.MinimumThumbLength = 18;
            this.SliderPrioridade.Name = "SliderPrioridade";
            this.SliderPrioridade.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.SliderPrioridade.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.SliderPrioridade.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.SliderPrioridade.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.SliderPrioridade.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.SliderPrioridade.ShrinkSizeLimit = 3;
            this.SliderPrioridade.Size = new System.Drawing.Size(141, 31);
            this.SliderPrioridade.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.SliderPrioridade.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.SliderPrioridade.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.SliderPrioridade.SmallChange = 1;
            this.SliderPrioridade.TabIndex = 10;
            this.SliderPrioridade.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.SliderPrioridade.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.SliderPrioridade.ThumbLength = 18;
            this.SliderPrioridade.ThumbMargin = 1;
            this.SliderPrioridade.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.SliderPrioridade.Value = 1;
            this.SliderPrioridade.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.SliderPrioridade_Scroll);
            // 
            // btnCriarProcesso
            // 
            this.btnCriarProcesso.AllowToggling = false;
            this.btnCriarProcesso.AnimationSpeed = 200;
            this.btnCriarProcesso.AutoGenerateColors = false;
            this.btnCriarProcesso.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarProcesso.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnCriarProcesso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCriarProcesso.BackgroundImage")));
            this.btnCriarProcesso.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCriarProcesso.ButtonText = "Criar Processo";
            this.btnCriarProcesso.ButtonTextMarginLeft = 0;
            this.btnCriarProcesso.ColorContrastOnClick = 45;
            this.btnCriarProcesso.ColorContrastOnHover = 45;
            this.btnCriarProcesso.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCriarProcesso.CustomizableEdges = borderEdges1;
            this.btnCriarProcesso.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCriarProcesso.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnCriarProcesso.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCriarProcesso.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCriarProcesso.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCriarProcesso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCriarProcesso.ForeColor = System.Drawing.Color.White;
            this.btnCriarProcesso.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCriarProcesso.IconMarginLeft = 11;
            this.btnCriarProcesso.IconPadding = 10;
            this.btnCriarProcesso.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCriarProcesso.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnCriarProcesso.IdleBorderRadius = 1;
            this.btnCriarProcesso.IdleBorderThickness = 1;
            this.btnCriarProcesso.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnCriarProcesso.IdleIconLeftImage = null;
            this.btnCriarProcesso.IdleIconRightImage = null;
            this.btnCriarProcesso.IndicateFocus = false;
            this.btnCriarProcesso.Location = new System.Drawing.Point(728, 103);
            this.btnCriarProcesso.Name = "btnCriarProcesso";
            this.btnCriarProcesso.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnCriarProcesso.onHoverState.BorderRadius = 1;
            this.btnCriarProcesso.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCriarProcesso.onHoverState.BorderThickness = 1;
            this.btnCriarProcesso.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnCriarProcesso.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCriarProcesso.onHoverState.IconLeftImage = null;
            this.btnCriarProcesso.onHoverState.IconRightImage = null;
            this.btnCriarProcesso.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnCriarProcesso.OnIdleState.BorderRadius = 1;
            this.btnCriarProcesso.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCriarProcesso.OnIdleState.BorderThickness = 1;
            this.btnCriarProcesso.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnCriarProcesso.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCriarProcesso.OnIdleState.IconLeftImage = null;
            this.btnCriarProcesso.OnIdleState.IconRightImage = null;
            this.btnCriarProcesso.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnCriarProcesso.OnPressedState.BorderRadius = 1;
            this.btnCriarProcesso.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCriarProcesso.OnPressedState.BorderThickness = 1;
            this.btnCriarProcesso.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnCriarProcesso.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCriarProcesso.OnPressedState.IconLeftImage = null;
            this.btnCriarProcesso.OnPressedState.IconRightImage = null;
            this.btnCriarProcesso.Size = new System.Drawing.Size(150, 39);
            this.btnCriarProcesso.TabIndex = 9;
            this.btnCriarProcesso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCriarProcesso.TextMarginLeft = 0;
            this.btnCriarProcesso.UseDefaultRadiusAndThickness = true;
            this.btnCriarProcesso.Click += new System.EventHandler(this.btnCriarProcesso_Click_1);
            // 
            // ProcessadorPage
            // 
            this.ProcessadorPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.ProcessadorPage.Controls.Add(this.lblCore4);
            this.ProcessadorPage.Controls.Add(this.lblCore3);
            this.ProcessadorPage.Controls.Add(this.lblCore2);
            this.ProcessadorPage.Controls.Add(this.lblCore1);
            this.ProcessadorPage.Controls.Add(this.GridCore4);
            this.ProcessadorPage.Controls.Add(this.GridCore3);
            this.ProcessadorPage.Controls.Add(this.GridCore2);
            this.ProcessadorPage.Controls.Add(this.GridCore1);
            this.ProcessadorPage.Location = new System.Drawing.Point(4, 4);
            this.ProcessadorPage.Name = "ProcessadorPage";
            this.ProcessadorPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProcessadorPage.Size = new System.Drawing.Size(1123, 478);
            this.ProcessadorPage.TabIndex = 1;
            this.ProcessadorPage.Text = "Processador";
            // 
            // lblCore4
            // 
            this.lblCore4.AutoEllipsis = false;
            this.lblCore4.CursorType = null;
            this.lblCore4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCore4.ForeColor = System.Drawing.Color.White;
            this.lblCore4.Location = new System.Drawing.Point(939, 167);
            this.lblCore4.Name = "lblCore4";
            this.lblCore4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCore4.Size = new System.Drawing.Size(59, 26);
            this.lblCore4.TabIndex = 14;
            this.lblCore4.Text = "Core 4";
            this.lblCore4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCore4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblCore3
            // 
            this.lblCore3.AutoEllipsis = false;
            this.lblCore3.CursorType = null;
            this.lblCore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCore3.ForeColor = System.Drawing.Color.White;
            this.lblCore3.Location = new System.Drawing.Point(665, 167);
            this.lblCore3.Name = "lblCore3";
            this.lblCore3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCore3.Size = new System.Drawing.Size(59, 26);
            this.lblCore3.TabIndex = 13;
            this.lblCore3.Text = "Core 3";
            this.lblCore3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCore3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblCore2
            // 
            this.lblCore2.AutoEllipsis = false;
            this.lblCore2.CursorType = null;
            this.lblCore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCore2.ForeColor = System.Drawing.Color.White;
            this.lblCore2.Location = new System.Drawing.Point(400, 167);
            this.lblCore2.Name = "lblCore2";
            this.lblCore2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCore2.Size = new System.Drawing.Size(59, 26);
            this.lblCore2.TabIndex = 12;
            this.lblCore2.Text = "Core 2";
            this.lblCore2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCore2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblCore1
            // 
            this.lblCore1.AutoEllipsis = false;
            this.lblCore1.CursorType = null;
            this.lblCore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCore1.ForeColor = System.Drawing.Color.White;
            this.lblCore1.Location = new System.Drawing.Point(122, 167);
            this.lblCore1.Name = "lblCore1";
            this.lblCore1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCore1.Size = new System.Drawing.Size(59, 26);
            this.lblCore1.TabIndex = 11;
            this.lblCore1.Text = "Core 1";
            this.lblCore1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCore1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // GridCore4
            // 
            this.GridCore4.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.GridCore4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridCore4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCore4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.GridCore4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridCore4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridCore4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCore4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridCore4.ColumnHeadersHeight = 40;
            this.GridCore4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pid4Core,
            this.Estado4Core});
            this.GridCore4.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.GridCore4.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridCore4.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridCore4.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.GridCore4.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.GridCore4.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.GridCore4.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.GridCore4.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.GridCore4.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.GridCore4.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridCore4.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.GridCore4.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridCore4.CurrentTheme.Name = null;
            this.GridCore4.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridCore4.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridCore4.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridCore4.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.GridCore4.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCore4.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridCore4.EnableHeadersVisualStyles = false;
            this.GridCore4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.GridCore4.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.GridCore4.HeaderBgColor = System.Drawing.Color.Empty;
            this.GridCore4.HeaderForeColor = System.Drawing.Color.White;
            this.GridCore4.Location = new System.Drawing.Point(849, 205);
            this.GridCore4.Name = "GridCore4";
            this.GridCore4.ReadOnly = true;
            this.GridCore4.RowHeadersVisible = false;
            this.GridCore4.RowTemplate.Height = 40;
            this.GridCore4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCore4.Size = new System.Drawing.Size(252, 250);
            this.GridCore4.TabIndex = 10;
            this.GridCore4.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Pid4Core
            // 
            this.Pid4Core.HeaderText = "PID";
            this.Pid4Core.Name = "Pid4Core";
            this.Pid4Core.ReadOnly = true;
            // 
            // Estado4Core
            // 
            this.Estado4Core.HeaderText = "Estado";
            this.Estado4Core.Name = "Estado4Core";
            this.Estado4Core.ReadOnly = true;
            // 
            // GridCore3
            // 
            this.GridCore3.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.GridCore3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.GridCore3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCore3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.GridCore3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridCore3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridCore3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCore3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.GridCore3.ColumnHeadersHeight = 40;
            this.GridCore3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pid3Core,
            this.Estado3Core});
            this.GridCore3.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.GridCore3.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridCore3.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridCore3.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.GridCore3.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.GridCore3.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.GridCore3.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.GridCore3.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.GridCore3.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.GridCore3.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridCore3.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.GridCore3.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridCore3.CurrentTheme.Name = null;
            this.GridCore3.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridCore3.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridCore3.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridCore3.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.GridCore3.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCore3.DefaultCellStyle = dataGridViewCellStyle9;
            this.GridCore3.EnableHeadersVisualStyles = false;
            this.GridCore3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.GridCore3.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.GridCore3.HeaderBgColor = System.Drawing.Color.Empty;
            this.GridCore3.HeaderForeColor = System.Drawing.Color.White;
            this.GridCore3.Location = new System.Drawing.Point(579, 205);
            this.GridCore3.Name = "GridCore3";
            this.GridCore3.ReadOnly = true;
            this.GridCore3.RowHeadersVisible = false;
            this.GridCore3.RowTemplate.Height = 40;
            this.GridCore3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCore3.Size = new System.Drawing.Size(229, 250);
            this.GridCore3.TabIndex = 9;
            this.GridCore3.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Pid3Core
            // 
            this.Pid3Core.HeaderText = "PID";
            this.Pid3Core.Name = "Pid3Core";
            this.Pid3Core.ReadOnly = true;
            // 
            // Estado3Core
            // 
            this.Estado3Core.HeaderText = "Estado";
            this.Estado3Core.Name = "Estado3Core";
            this.Estado3Core.ReadOnly = true;
            // 
            // GridCore2
            // 
            this.GridCore2.AllowCustomTheming = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.GridCore2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.GridCore2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCore2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.GridCore2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridCore2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridCore2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCore2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.GridCore2.ColumnHeadersHeight = 40;
            this.GridCore2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID2Core,
            this.Estado2Core});
            this.GridCore2.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.GridCore2.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridCore2.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridCore2.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.GridCore2.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.GridCore2.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.GridCore2.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.GridCore2.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.GridCore2.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.GridCore2.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridCore2.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.GridCore2.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridCore2.CurrentTheme.Name = null;
            this.GridCore2.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridCore2.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridCore2.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridCore2.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.GridCore2.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCore2.DefaultCellStyle = dataGridViewCellStyle12;
            this.GridCore2.EnableHeadersVisualStyles = false;
            this.GridCore2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.GridCore2.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.GridCore2.HeaderBgColor = System.Drawing.Color.Empty;
            this.GridCore2.HeaderForeColor = System.Drawing.Color.White;
            this.GridCore2.Location = new System.Drawing.Point(313, 205);
            this.GridCore2.Name = "GridCore2";
            this.GridCore2.ReadOnly = true;
            this.GridCore2.RowHeadersVisible = false;
            this.GridCore2.RowTemplate.Height = 40;
            this.GridCore2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCore2.Size = new System.Drawing.Size(230, 250);
            this.GridCore2.TabIndex = 8;
            this.GridCore2.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // PID2Core
            // 
            this.PID2Core.HeaderText = "PID";
            this.PID2Core.Name = "PID2Core";
            this.PID2Core.ReadOnly = true;
            // 
            // Estado2Core
            // 
            this.Estado2Core.HeaderText = "Estado";
            this.Estado2Core.Name = "Estado2Core";
            this.Estado2Core.ReadOnly = true;
            // 
            // GridCore1
            // 
            this.GridCore1.AllowCustomTheming = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            this.GridCore1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.GridCore1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCore1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.GridCore1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridCore1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridCore1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCore1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.GridCore1.ColumnHeadersHeight = 40;
            this.GridCore1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grid1Core,
            this.Estado1Core});
            this.GridCore1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.GridCore1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridCore1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridCore1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.GridCore1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.GridCore1.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.GridCore1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.GridCore1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.GridCore1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.GridCore1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridCore1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.GridCore1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridCore1.CurrentTheme.Name = null;
            this.GridCore1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GridCore1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridCore1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.GridCore1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.GridCore1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCore1.DefaultCellStyle = dataGridViewCellStyle15;
            this.GridCore1.EnableHeadersVisualStyles = false;
            this.GridCore1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.GridCore1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.GridCore1.HeaderBgColor = System.Drawing.Color.Empty;
            this.GridCore1.HeaderForeColor = System.Drawing.Color.White;
            this.GridCore1.Location = new System.Drawing.Point(40, 205);
            this.GridCore1.Name = "GridCore1";
            this.GridCore1.ReadOnly = true;
            this.GridCore1.RowHeadersVisible = false;
            this.GridCore1.RowTemplate.Height = 40;
            this.GridCore1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCore1.Size = new System.Drawing.Size(228, 250);
            this.GridCore1.TabIndex = 2;
            this.GridCore1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Grid1Core
            // 
            this.Grid1Core.HeaderText = "PID";
            this.Grid1Core.Name = "Grid1Core";
            this.Grid1Core.ReadOnly = true;
            // 
            // Estado1Core
            // 
            this.Estado1Core.HeaderText = "Estado";
            this.Estado1Core.Name = "Estado1Core";
            this.Estado1Core.ReadOnly = true;
            // 
            // SobrePage
            // 
            this.SobrePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.SobrePage.Controls.Add(this.btnSobreUsar);
            this.SobrePage.Controls.Add(this.lblSobreNome);
            this.SobrePage.Controls.Add(this.bunifuLabel1);
            this.SobrePage.Location = new System.Drawing.Point(4, 4);
            this.SobrePage.Name = "SobrePage";
            this.SobrePage.Padding = new System.Windows.Forms.Padding(3);
            this.SobrePage.Size = new System.Drawing.Size(1123, 478);
            this.SobrePage.TabIndex = 2;
            this.SobrePage.Text = "Sobre";
            // 
            // btnSobreUsar
            // 
            this.btnSobreUsar.AutoEllipsis = false;
            this.btnSobreUsar.CursorType = null;
            this.btnSobreUsar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobreUsar.ForeColor = System.Drawing.Color.White;
            this.btnSobreUsar.Location = new System.Drawing.Point(103, 140);
            this.btnSobreUsar.Name = "btnSobreUsar";
            this.btnSobreUsar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSobreUsar.Size = new System.Drawing.Size(913, 18);
            this.btnSobreUsar.TabIndex = 2;
            this.btnSobreUsar.Text = "Para utilizar o LKScheduler será necessário criar um processo, o mesmo será aloca" +
    "do em um core. Cada core só poderá alocar no máximo 5 processos.";
            this.btnSobreUsar.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.btnSobreUsar.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblSobreNome
            // 
            this.lblSobreNome.AutoEllipsis = false;
            this.lblSobreNome.CursorType = null;
            this.lblSobreNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobreNome.ForeColor = System.Drawing.Color.White;
            this.lblSobreNome.Location = new System.Drawing.Point(450, 17);
            this.lblSobreNome.Name = "lblSobreNome";
            this.lblSobreNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSobreNome.Size = new System.Drawing.Size(190, 40);
            this.lblSobreNome.TabIndex = 1;
            this.lblSobreNome.Text = "LKScheduler";
            this.lblSobreNome.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblSobreNome.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(203, 268);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(675, 22);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "O escalador de processos LKScheduler foi desenvolvido por Leonardo Oliveira e Kal" +
    "leo Leandro";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnScheduler
            // 
            this.btnScheduler.AllowToggling = false;
            this.btnScheduler.AnimationSpeed = 200;
            this.btnScheduler.AutoGenerateColors = false;
            this.btnScheduler.BackColor = System.Drawing.Color.Transparent;
            this.btnScheduler.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnScheduler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScheduler.BackgroundImage")));
            this.btnScheduler.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnScheduler.ButtonText = "Scheduler";
            this.btnScheduler.ButtonTextMarginLeft = 0;
            this.btnScheduler.ColorContrastOnClick = 45;
            this.btnScheduler.ColorContrastOnHover = 45;
            this.btnScheduler.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnScheduler.CustomizableEdges = borderEdges2;
            this.btnScheduler.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnScheduler.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnScheduler.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnScheduler.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnScheduler.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnScheduler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnScheduler.ForeColor = System.Drawing.Color.White;
            this.btnScheduler.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnScheduler.IconMarginLeft = 11;
            this.btnScheduler.IconPadding = 10;
            this.btnScheduler.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnScheduler.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnScheduler.IdleBorderRadius = 1;
            this.btnScheduler.IdleBorderThickness = 1;
            this.btnScheduler.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnScheduler.IdleIconLeftImage = null;
            this.btnScheduler.IdleIconRightImage = null;
            this.btnScheduler.IndicateFocus = false;
            this.btnScheduler.Location = new System.Drawing.Point(12, 39);
            this.btnScheduler.Name = "btnScheduler";
            this.btnScheduler.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnScheduler.onHoverState.BorderRadius = 1;
            this.btnScheduler.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnScheduler.onHoverState.BorderThickness = 1;
            this.btnScheduler.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnScheduler.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnScheduler.onHoverState.IconLeftImage = null;
            this.btnScheduler.onHoverState.IconRightImage = null;
            this.btnScheduler.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnScheduler.OnIdleState.BorderRadius = 1;
            this.btnScheduler.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnScheduler.OnIdleState.BorderThickness = 1;
            this.btnScheduler.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnScheduler.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnScheduler.OnIdleState.IconLeftImage = null;
            this.btnScheduler.OnIdleState.IconRightImage = null;
            this.btnScheduler.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnScheduler.OnPressedState.BorderRadius = 1;
            this.btnScheduler.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnScheduler.OnPressedState.BorderThickness = 1;
            this.btnScheduler.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnScheduler.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnScheduler.OnPressedState.IconLeftImage = null;
            this.btnScheduler.OnPressedState.IconRightImage = null;
            this.btnScheduler.Size = new System.Drawing.Size(121, 32);
            this.btnScheduler.TabIndex = 4;
            this.btnScheduler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnScheduler.TextMarginLeft = 0;
            this.btnScheduler.UseDefaultRadiusAndThickness = true;
            this.btnScheduler.Click += new System.EventHandler(this.btnScheduler_Click);
            // 
            // btnProcessador
            // 
            this.btnProcessador.AllowToggling = false;
            this.btnProcessador.AnimationSpeed = 200;
            this.btnProcessador.AutoGenerateColors = false;
            this.btnProcessador.BackColor = System.Drawing.Color.Transparent;
            this.btnProcessador.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnProcessador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProcessador.BackgroundImage")));
            this.btnProcessador.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProcessador.ButtonText = "Processador";
            this.btnProcessador.ButtonTextMarginLeft = 0;
            this.btnProcessador.ColorContrastOnClick = 45;
            this.btnProcessador.ColorContrastOnHover = 45;
            this.btnProcessador.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnProcessador.CustomizableEdges = borderEdges3;
            this.btnProcessador.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProcessador.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnProcessador.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnProcessador.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnProcessador.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnProcessador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProcessador.ForeColor = System.Drawing.Color.White;
            this.btnProcessador.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnProcessador.IconMarginLeft = 11;
            this.btnProcessador.IconPadding = 10;
            this.btnProcessador.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnProcessador.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnProcessador.IdleBorderRadius = 1;
            this.btnProcessador.IdleBorderThickness = 1;
            this.btnProcessador.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnProcessador.IdleIconLeftImage = null;
            this.btnProcessador.IdleIconRightImage = null;
            this.btnProcessador.IndicateFocus = false;
            this.btnProcessador.Location = new System.Drawing.Point(138, 39);
            this.btnProcessador.Name = "btnProcessador";
            this.btnProcessador.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnProcessador.onHoverState.BorderRadius = 1;
            this.btnProcessador.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProcessador.onHoverState.BorderThickness = 1;
            this.btnProcessador.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnProcessador.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnProcessador.onHoverState.IconLeftImage = null;
            this.btnProcessador.onHoverState.IconRightImage = null;
            this.btnProcessador.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnProcessador.OnIdleState.BorderRadius = 1;
            this.btnProcessador.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProcessador.OnIdleState.BorderThickness = 1;
            this.btnProcessador.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnProcessador.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnProcessador.OnIdleState.IconLeftImage = null;
            this.btnProcessador.OnIdleState.IconRightImage = null;
            this.btnProcessador.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnProcessador.OnPressedState.BorderRadius = 1;
            this.btnProcessador.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnProcessador.OnPressedState.BorderThickness = 1;
            this.btnProcessador.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnProcessador.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnProcessador.OnPressedState.IconLeftImage = null;
            this.btnProcessador.OnPressedState.IconRightImage = null;
            this.btnProcessador.Size = new System.Drawing.Size(121, 32);
            this.btnProcessador.TabIndex = 5;
            this.btnProcessador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProcessador.TextMarginLeft = 0;
            this.btnProcessador.UseDefaultRadiusAndThickness = true;
            this.btnProcessador.Click += new System.EventHandler(this.btnProcessador_Click);
            // 
            // ProgressTx
            // 
            this.ProgressTx.BackColor = System.Drawing.Color.Silver;
            this.ProgressTx.BorderRadius = 5;
            this.ProgressTx.Location = new System.Drawing.Point(1100, 571);
            this.ProgressTx.MaximumValue = 5;
            this.ProgressTx.Name = "ProgressTx";
            this.ProgressTx.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ProgressTx.Size = new System.Drawing.Size(53, 10);
            this.ProgressTx.TabIndex = 10;
            this.ProgressTx.Value = 0;
            // 
            // lblTx
            // 
            this.lblTx.AutoEllipsis = false;
            this.lblTx.CursorType = null;
            this.lblTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTx.ForeColor = System.Drawing.Color.White;
            this.lblTx.Location = new System.Drawing.Point(1078, 564);
            this.lblTx.Name = "lblTx";
            this.lblTx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTx.Size = new System.Drawing.Size(16, 17);
            this.lblTx.TabIndex = 11;
            this.lblTx.Text = "Tx";
            this.lblTx.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTx.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 34);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.AllowToggling = false;
            this.btnMinimizar.AnimationSpeed = 200;
            this.btnMinimizar.AutoGenerateColors = false;
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMinimizar.ButtonText = "–";
            this.btnMinimizar.ButtonTextMarginLeft = 0;
            this.btnMinimizar.ColorContrastOnClick = 45;
            this.btnMinimizar.ColorContrastOnHover = 45;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnMinimizar.CustomizableEdges = borderEdges4;
            this.btnMinimizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimizar.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnMinimizar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMinimizar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnMinimizar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMinimizar.IconMarginLeft = 11;
            this.btnMinimizar.IconPadding = 10;
            this.btnMinimizar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMinimizar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnMinimizar.IdleBorderRadius = 1;
            this.btnMinimizar.IdleBorderThickness = 1;
            this.btnMinimizar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnMinimizar.IdleIconLeftImage = null;
            this.btnMinimizar.IdleIconRightImage = null;
            this.btnMinimizar.IndicateFocus = false;
            this.btnMinimizar.Location = new System.Drawing.Point(1064, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnMinimizar.onHoverState.BorderRadius = 1;
            this.btnMinimizar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMinimizar.onHoverState.BorderThickness = 1;
            this.btnMinimizar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnMinimizar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.onHoverState.IconLeftImage = null;
            this.btnMinimizar.onHoverState.IconRightImage = null;
            this.btnMinimizar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnMinimizar.OnIdleState.BorderRadius = 1;
            this.btnMinimizar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMinimizar.OnIdleState.BorderThickness = 1;
            this.btnMinimizar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnMinimizar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.OnIdleState.IconLeftImage = null;
            this.btnMinimizar.OnIdleState.IconRightImage = null;
            this.btnMinimizar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnMinimizar.OnPressedState.BorderRadius = 1;
            this.btnMinimizar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMinimizar.OnPressedState.BorderThickness = 1;
            this.btnMinimizar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnMinimizar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.OnPressedState.IconLeftImage = null;
            this.btnMinimizar.OnPressedState.IconRightImage = null;
            this.btnMinimizar.Size = new System.Drawing.Size(42, 27);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimizar.TextMarginLeft = 0;
            this.btnMinimizar.UseDefaultRadiusAndThickness = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.AllowToggling = false;
            this.btnFechar.AnimationSpeed = 200;
            this.btnFechar.AutoGenerateColors = false;
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFechar.ButtonText = "X";
            this.btnFechar.ButtonTextMarginLeft = 0;
            this.btnFechar.ColorContrastOnClick = 45;
            this.btnFechar.ColorContrastOnHover = 45;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnFechar.CustomizableEdges = borderEdges5;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFechar.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnFechar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFechar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFechar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFechar.IconMarginLeft = 11;
            this.btnFechar.IconPadding = 10;
            this.btnFechar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFechar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnFechar.IdleBorderRadius = 1;
            this.btnFechar.IdleBorderThickness = 1;
            this.btnFechar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnFechar.IdleIconLeftImage = null;
            this.btnFechar.IdleIconRightImage = null;
            this.btnFechar.IndicateFocus = false;
            this.btnFechar.Location = new System.Drawing.Point(1112, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnFechar.onHoverState.BorderRadius = 1;
            this.btnFechar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFechar.onHoverState.BorderThickness = 1;
            this.btnFechar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnFechar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFechar.onHoverState.IconLeftImage = null;
            this.btnFechar.onHoverState.IconRightImage = null;
            this.btnFechar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnFechar.OnIdleState.BorderRadius = 1;
            this.btnFechar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFechar.OnIdleState.BorderThickness = 1;
            this.btnFechar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnFechar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFechar.OnIdleState.IconLeftImage = null;
            this.btnFechar.OnIdleState.IconRightImage = null;
            this.btnFechar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnFechar.OnPressedState.BorderRadius = 1;
            this.btnFechar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFechar.OnPressedState.BorderThickness = 1;
            this.btnFechar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnFechar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFechar.OnPressedState.IconLeftImage = null;
            this.btnFechar.OnPressedState.IconRightImage = null;
            this.btnFechar.Size = new System.Drawing.Size(42, 28);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFechar.TextMarginLeft = 0;
            this.btnFechar.UseDefaultRadiusAndThickness = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.AllowToggling = false;
            this.btnSobre.AnimationSpeed = 200;
            this.btnSobre.AutoGenerateColors = false;
            this.btnSobre.BackColor = System.Drawing.Color.Transparent;
            this.btnSobre.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnSobre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSobre.BackgroundImage")));
            this.btnSobre.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSobre.ButtonText = "Sobre";
            this.btnSobre.ButtonTextMarginLeft = 0;
            this.btnSobre.ColorContrastOnClick = 45;
            this.btnSobre.ColorContrastOnHover = 45;
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnSobre.CustomizableEdges = borderEdges6;
            this.btnSobre.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSobre.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnSobre.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSobre.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSobre.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSobre.IconMarginLeft = 11;
            this.btnSobre.IconPadding = 10;
            this.btnSobre.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSobre.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnSobre.IdleBorderRadius = 1;
            this.btnSobre.IdleBorderThickness = 1;
            this.btnSobre.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnSobre.IdleIconLeftImage = null;
            this.btnSobre.IdleIconRightImage = null;
            this.btnSobre.IndicateFocus = false;
            this.btnSobre.Location = new System.Drawing.Point(265, 39);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSobre.onHoverState.BorderRadius = 1;
            this.btnSobre.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSobre.onHoverState.BorderThickness = 1;
            this.btnSobre.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSobre.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSobre.onHoverState.IconLeftImage = null;
            this.btnSobre.onHoverState.IconRightImage = null;
            this.btnSobre.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnSobre.OnIdleState.BorderRadius = 1;
            this.btnSobre.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSobre.OnIdleState.BorderThickness = 1;
            this.btnSobre.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnSobre.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSobre.OnIdleState.IconLeftImage = null;
            this.btnSobre.OnIdleState.IconRightImage = null;
            this.btnSobre.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSobre.OnPressedState.BorderRadius = 1;
            this.btnSobre.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSobre.OnPressedState.BorderThickness = 1;
            this.btnSobre.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnSobre.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSobre.OnPressedState.IconLeftImage = null;
            this.btnSobre.OnPressedState.IconRightImage = null;
            this.btnSobre.Size = new System.Drawing.Size(120, 32);
            this.btnSobre.TabIndex = 13;
            this.btnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSobre.TextMarginLeft = 0;
            this.btnSobre.UseDefaultRadiusAndThickness = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // lblTempUCP
            // 
            this.lblTempUCP.AutoEllipsis = false;
            this.lblTempUCP.CursorType = null;
            this.lblTempUCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempUCP.ForeColor = System.Drawing.Color.White;
            this.lblTempUCP.Location = new System.Drawing.Point(335, 70);
            this.lblTempUCP.Name = "lblTempUCP";
            this.lblTempUCP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTempUCP.Size = new System.Drawing.Size(89, 22);
            this.lblTempUCP.TabIndex = 15;
            this.lblTempUCP.Text = "Tempo UCP";
            this.lblTempUCP.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTempUCP.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1155, 584);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTx);
            this.Controls.Add(this.ProgressTx);
            this.Controls.Add(this.btnProcessador);
            this.Controls.Add(this.btnScheduler);
            this.Controls.Add(this.LKPagesPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Scheduler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchedulerLK";
            this.Load += new System.EventHandler(this.Scheduler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProcessos)).EndInit();
            this.LKPagesPrincipal.ResumeLayout(false);
            this.SchedulerPage.ResumeLayout(false);
            this.SchedulerPage.PerformLayout();
            this.ProcessadorPage.ResumeLayout(false);
            this.ProcessadorPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCore1)).EndInit();
            this.SobrePage.ResumeLayout(false);
            this.SobrePage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.ComboBox TipoProcesso;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.UI.WinForms.BunifuDataGridView GridProcessos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PidGridProcessos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrioridadeGridProcessos;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoGridProcessos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempoUCPGridProcessos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProcessoGridProcessos;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgoraGridProcessos;
        private Bunifu.UI.WinForms.BunifuPages LKPagesPrincipal;
        private System.Windows.Forms.TabPage SchedulerPage;
        private System.Windows.Forms.TabPage ProcessadorPage;
        private Bunifu.UI.WinForms.BunifuDataGridView GridCore1;
        private Bunifu.UI.WinForms.BunifuDataGridView GridCore2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID2Core;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado2Core;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid1Core;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado1Core;
        private Bunifu.UI.WinForms.BunifuDataGridView GridCore3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pid3Core;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado3Core;
        private Bunifu.UI.WinForms.BunifuLabel lblCore4;
        private Bunifu.UI.WinForms.BunifuLabel lblCore3;
        private Bunifu.UI.WinForms.BunifuLabel lblCore2;
        private Bunifu.UI.WinForms.BunifuLabel lblCore1;
        private Bunifu.UI.WinForms.BunifuDataGridView GridCore4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pid4Core;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado4Core;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnScheduler;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnProcessador;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCriarProcesso;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressTx;
        private Bunifu.UI.WinForms.BunifuLabel lblTx;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFechar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMinimizar;
        private Bunifu.UI.WinForms.BunifuLabel lblPrioridadeValor;
        private Bunifu.UI.WinForms.BunifuLabel lblPrioridade;
        private Bunifu.UI.WinForms.BunifuHSlider SliderPrioridade;
        private System.Windows.Forms.TabPage SobrePage;
        private Bunifu.UI.WinForms.BunifuLabel lblTipoProcesso;
        private Bunifu.UI.WinForms.BunifuLabel btnSobreUsar;
        private Bunifu.UI.WinForms.BunifuLabel lblSobreNome;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TempoUCP;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSobre;
        private Bunifu.UI.WinForms.BunifuLabel lblTempUCP;
    }
}

