namespace TravelSellerProblem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTamPop = new System.Windows.Forms.TextBox();
            this.txtTaxaCrossover = new System.Windows.Forms.TextBox();
            this.txtTaxaMutacao = new System.Windows.Forms.TextBox();
            this.txtEvolucao = new System.Windows.Forms.TextBox();
            this.chElitismo = new System.Windows.Forms.CheckBox();
            this.txtQtdeElitismo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtdeTorneio = new System.Windows.Forms.TextBox();
            this.gBMutacao = new System.Windows.Forms.GroupBox();
            this.rBNovoIndividuo = new System.Windows.Forms.RadioButton();
            this.rBPopulacao = new System.Windows.Forms.RadioButton();
            this.rBGenesPop = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnCriarPop = new System.Windows.Forms.Button();
            this.lbEvolucoes = new System.Windows.Forms.Label();
            this.lbMenorDistancia = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.lbQtdeCidades = new System.Windows.Forms.Label();
            this.lblComplex = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gBMutacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.zedGraphControl1);
            this.panel1.Controls.Add(this.lbMenorDistancia);
            this.panel1.Controls.Add(this.lbEvolucoes);
            this.panel1.Controls.Add(this.btnCriarPop);
            this.panel1.Controls.Add(this.gBMutacao);
            this.panel1.Controls.Add(this.btnExecutar);
            this.panel1.Controls.Add(this.txtQtdeTorneio);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtQtdeElitismo);
            this.panel1.Controls.Add(this.chElitismo);
            this.panel1.Controls.Add(this.txtEvolucao);
            this.panel1.Controls.Add(this.txtTaxaMutacao);
            this.panel1.Controls.Add(this.txtTaxaCrossover);
            this.panel1.Controls.Add(this.txtTamPop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 739);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamanho pop:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taxa de crossover:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taxa de mutação:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Evoluções:";
            // 
            // txtTamPop
            // 
            this.txtTamPop.Location = new System.Drawing.Point(173, 12);
            this.txtTamPop.Name = "txtTamPop";
            this.txtTamPop.Size = new System.Drawing.Size(146, 22);
            this.txtTamPop.TabIndex = 4;
            this.txtTamPop.Text = "50";
            // 
            // txtTaxaCrossover
            // 
            this.txtTaxaCrossover.Location = new System.Drawing.Point(173, 64);
            this.txtTaxaCrossover.Name = "txtTaxaCrossover";
            this.txtTaxaCrossover.Size = new System.Drawing.Size(146, 22);
            this.txtTaxaCrossover.TabIndex = 5;
            this.txtTaxaCrossover.Text = "0.6";
            // 
            // txtTaxaMutacao
            // 
            this.txtTaxaMutacao.Location = new System.Drawing.Point(173, 116);
            this.txtTaxaMutacao.Name = "txtTaxaMutacao";
            this.txtTaxaMutacao.Size = new System.Drawing.Size(146, 22);
            this.txtTaxaMutacao.TabIndex = 6;
            this.txtTaxaMutacao.Text = "0.01";
            // 
            // txtEvolucao
            // 
            this.txtEvolucao.Location = new System.Drawing.Point(173, 166);
            this.txtEvolucao.Name = "txtEvolucao";
            this.txtEvolucao.Size = new System.Drawing.Size(146, 22);
            this.txtEvolucao.TabIndex = 7;
            this.txtEvolucao.Text = "100";
            // 
            // chElitismo
            // 
            this.chElitismo.AutoSize = true;
            this.chElitismo.Location = new System.Drawing.Point(362, 205);
            this.chElitismo.Name = "chElitismo";
            this.chElitismo.Size = new System.Drawing.Size(78, 21);
            this.chElitismo.TabIndex = 8;
            this.chElitismo.Text = "Elitismo";
            this.chElitismo.UseVisualStyleBackColor = true;
            // 
            // txtQtdeElitismo
            // 
            this.txtQtdeElitismo.Location = new System.Drawing.Point(447, 204);
            this.txtQtdeElitismo.Name = "txtQtdeElitismo";
            this.txtQtdeElitismo.Size = new System.Drawing.Size(49, 22);
            this.txtQtdeElitismo.TabIndex = 9;
            this.txtQtdeElitismo.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Torneio:";
            // 
            // txtQtdeTorneio
            // 
            this.txtQtdeTorneio.Location = new System.Drawing.Point(447, 284);
            this.txtQtdeTorneio.Name = "txtQtdeTorneio";
            this.txtQtdeTorneio.Size = new System.Drawing.Size(49, 22);
            this.txtQtdeTorneio.TabIndex = 11;
            this.txtQtdeTorneio.Text = "4";
            // 
            // gBMutacao
            // 
            this.gBMutacao.Controls.Add(this.rBGenesPop);
            this.gBMutacao.Controls.Add(this.rBPopulacao);
            this.gBMutacao.Controls.Add(this.rBNovoIndividuo);
            this.gBMutacao.Location = new System.Drawing.Point(16, 194);
            this.gBMutacao.Name = "gBMutacao";
            this.gBMutacao.Size = new System.Drawing.Size(303, 112);
            this.gBMutacao.TabIndex = 12;
            this.gBMutacao.TabStop = false;
            this.gBMutacao.Text = "Mutação";
            // 
            // rBNovoIndividuo
            // 
            this.rBNovoIndividuo.AutoSize = true;
            this.rBNovoIndividuo.Checked = true;
            this.rBNovoIndividuo.Location = new System.Drawing.Point(9, 21);
            this.rBNovoIndividuo.Name = "rBNovoIndividuo";
            this.rBNovoIndividuo.Size = new System.Drawing.Size(122, 21);
            this.rBNovoIndividuo.TabIndex = 0;
            this.rBNovoIndividuo.TabStop = true;
            this.rBNovoIndividuo.Text = "Novo indivíduo";
            this.rBNovoIndividuo.UseVisualStyleBackColor = true;
            // 
            // rBPopulacao
            // 
            this.rBPopulacao.AutoSize = true;
            this.rBPopulacao.Location = new System.Drawing.Point(9, 48);
            this.rBPopulacao.Name = "rBPopulacao";
            this.rBPopulacao.Size = new System.Drawing.Size(127, 21);
            this.rBPopulacao.TabIndex = 1;
            this.rBPopulacao.Text = "Polulaçao geral";
            this.rBPopulacao.UseVisualStyleBackColor = true;
            // 
            // rBGenesPop
            // 
            this.rBGenesPop.AutoSize = true;
            this.rBGenesPop.Location = new System.Drawing.Point(9, 75);
            this.rBGenesPop.Name = "rBGenesPop";
            this.rBGenesPop.Size = new System.Drawing.Size(141, 21);
            this.rBGenesPop.TabIndex = 2;
            this.rBGenesPop.Text = "Genes população";
            this.rBGenesPop.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Location = new System.Drawing.Point(362, 137);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 42);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(362, 72);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(150, 42);
            this.btnExecutar.TabIndex = 14;
            this.btnExecutar.Text = "Executar/Continuar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            // 
            // btnCriarPop
            // 
            this.btnCriarPop.Enabled = false;
            this.btnCriarPop.Location = new System.Drawing.Point(362, 12);
            this.btnCriarPop.Name = "btnCriarPop";
            this.btnCriarPop.Size = new System.Drawing.Size(150, 42);
            this.btnCriarPop.TabIndex = 15;
            this.btnCriarPop.Text = "Criar população";
            this.btnCriarPop.UseVisualStyleBackColor = true;
            // 
            // lbEvolucoes
            // 
            this.lbEvolucoes.AutoSize = true;
            this.lbEvolucoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvolucoes.Location = new System.Drawing.Point(22, 309);
            this.lbEvolucoes.Name = "lbEvolucoes";
            this.lbEvolucoes.Size = new System.Drawing.Size(87, 17);
            this.lbEvolucoes.TabIndex = 16;
            this.lbEvolucoes.Text = "Evoluções:";
            // 
            // lbMenorDistancia
            // 
            this.lbMenorDistancia.AutoSize = true;
            this.lbMenorDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenorDistancia.Location = new System.Drawing.Point(22, 326);
            this.lbMenorDistancia.Name = "lbMenorDistancia";
            this.lbMenorDistancia.Size = new System.Drawing.Size(128, 17);
            this.lbMenorDistancia.TabIndex = 17;
            this.lbMenorDistancia.Text = "Menor distância:";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.Location = new System.Drawing.Point(15, 347);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(532, 388);
            this.zedGraphControl1.TabIndex = 18;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // lbQtdeCidades
            // 
            this.lbQtdeCidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbQtdeCidades.AutoSize = true;
            this.lbQtdeCidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdeCidades.Location = new System.Drawing.Point(569, 12);
            this.lbQtdeCidades.Name = "lbQtdeCidades";
            this.lbQtdeCidades.Size = new System.Drawing.Size(185, 20);
            this.lbQtdeCidades.TabIndex = 1;
            this.lbQtdeCidades.Text = "Quantidade de cidades:";
            // 
            // lblComplex
            // 
            this.lblComplex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblComplex.AutoSize = true;
            this.lblComplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplex.Location = new System.Drawing.Point(569, 731);
            this.lblComplex.Name = "lblComplex";
            this.lblComplex.Size = new System.Drawing.Size(119, 20);
            this.lblComplex.TabIndex = 2;
            this.lblComplex.Text = "Complexidade:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 763);
            this.Controls.Add(this.lblComplex);
            this.Controls.Add(this.lbQtdeCidades);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Travel Seller Solver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBMutacao.ResumeLayout(false);
            this.gBMutacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEvolucao;
        private System.Windows.Forms.TextBox txtTaxaMutacao;
        private System.Windows.Forms.TextBox txtTaxaCrossover;
        private System.Windows.Forms.TextBox txtTamPop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chElitismo;
        private System.Windows.Forms.TextBox txtQtdeTorneio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtdeElitismo;
        private System.Windows.Forms.GroupBox gBMutacao;
        private System.Windows.Forms.RadioButton rBGenesPop;
        private System.Windows.Forms.RadioButton rBPopulacao;
        private System.Windows.Forms.RadioButton rBNovoIndividuo;
        private System.Windows.Forms.Button btnCriarPop;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnLimpar;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label lbMenorDistancia;
        private System.Windows.Forms.Label lbEvolucoes;
        private System.Windows.Forms.Label lbQtdeCidades;
        private System.Windows.Forms.Label lblComplex;
    }
}

