namespace nsga2win {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.acercaDeBtn = new System.Windows.Forms.Button();
            this.comenzarBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.algRunningLbl = new System.Windows.Forms.Label();
            this.workingPbx = new System.Windows.Forms.PictureBox();
            this.detenerBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.zedGraphControl4 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.bestZgc = new ZedGraph.ZedGraphControl();
            this.mainTbp = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bestIndividualTxt = new System.Windows.Forms.TextBox();
            this.bestChromosomeTbx = new System.Windows.Forms.TextBox();
            this.betFitnessTxt = new System.Windows.Forms.TextBox();
            this.populationZgc = new ZedGraph.ZedGraphControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.borrarGraficasBtn = new System.Windows.Forms.Button();
            this.borrarGráficasCbx = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.superponerGeneracionesCbx = new System.Windows.Forms.CheckBox();
            this.monitorizaGraficasCbx = new System.Windows.Forms.CheckBox();
            this.monitorizaEstadisticasCbx = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.duracionIteracionTbx = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mutationsIterTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.durationTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.iterationsSecTxt = new System.Windows.Forms.TextBox();
            this.crossesSecTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.crossesTxt = new System.Windows.Forms.TextBox();
            this.mutationsSecTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.generationTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mutationsTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.multiThreadCbx = new System.Windows.Forms.CheckBox();
            this.numberOfThreadsTbx = new System.Windows.Forms.TextBox();
            this.popSizeTxt = new System.Windows.Forms.TextBox();
            this.popSizeLbl = new System.Windows.Forms.Label();
            this.maxIterationsTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.propParentsTxt = new System.Windows.Forms.TextBox();
            this.probMutationTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainTbc = new System.Windows.Forms.TabControl();
            this.procCoreInfoLbl = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.paretoZgc = new ZedGraph.ZedGraphControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workingPbx)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.mainTbp.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mainTbc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPTIMIZACIÓN DE LA DISTRIBUCIÓN EN PLANTA DE INSTALACIONES INDUSTRIALES MEDIANTE " +
                "ALGORITMOS GENÉTICOS";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.acercaDeBtn);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 24);
            this.panel1.TabIndex = 3;
            // 
            // acercaDeBtn
            // 
            this.acercaDeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.acercaDeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.acercaDeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acercaDeBtn.Location = new System.Drawing.Point(697, 0);
            this.acercaDeBtn.Name = "acercaDeBtn";
            this.acercaDeBtn.Size = new System.Drawing.Size(75, 22);
            this.acercaDeBtn.TabIndex = 6;
            this.acercaDeBtn.Text = "Acerca de...";
            this.acercaDeBtn.UseVisualStyleBackColor = true;
            this.acercaDeBtn.Click += new System.EventHandler(this.acercaDeBtn_Click);
            // 
            // comenzarBtn
            // 
            this.comenzarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comenzarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comenzarBtn.Location = new System.Drawing.Point(534, 520);
            this.comenzarBtn.Name = "comenzarBtn";
            this.comenzarBtn.Size = new System.Drawing.Size(97, 27);
            this.comenzarBtn.TabIndex = 5;
            this.comenzarBtn.Text = "Comenzar";
            this.comenzarBtn.UseVisualStyleBackColor = true;
            this.comenzarBtn.Click += new System.EventHandler(this.comenzarBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(637, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "Pausa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // algRunningLbl
            // 
            this.algRunningLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.algRunningLbl.AutoSize = true;
            this.algRunningLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algRunningLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.algRunningLbl.Location = new System.Drawing.Point(333, 523);
            this.algRunningLbl.Name = "algRunningLbl";
            this.algRunningLbl.Size = new System.Drawing.Size(195, 18);
            this.algRunningLbl.TabIndex = 33;
            this.algRunningLbl.Text = "Algoritmo en ejecución...";
            this.algRunningLbl.Visible = false;
            // 
            // workingPbx
            // 
            this.workingPbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.workingPbx.Image = global::nsga2win.Properties.Resources.ajax_loader;
            this.workingPbx.Location = new System.Drawing.Point(311, 527);
            this.workingPbx.Name = "workingPbx";
            this.workingPbx.Size = new System.Drawing.Size(16, 11);
            this.workingPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.workingPbx.TabIndex = 35;
            this.workingPbx.TabStop = false;
            this.workingPbx.Visible = false;
            // 
            // detenerBtn
            // 
            this.detenerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.detenerBtn.Enabled = false;
            this.detenerBtn.Location = new System.Drawing.Point(706, 520);
            this.detenerBtn.Name = "detenerBtn";
            this.detenerBtn.Size = new System.Drawing.Size(63, 27);
            this.detenerBtn.TabIndex = 36;
            this.detenerBtn.Text = "Detener";
            this.detenerBtn.UseVisualStyleBackColor = true;
            this.detenerBtn.Click += new System.EventHandler(this.detenerBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "NSGA-II";
            this.notifyIcon1.Visible = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.zedGraphControl4);
            this.tabPage2.Controls.Add(this.zedGraphControl2);
            this.tabPage2.Controls.Add(this.bestZgc);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gráficas mejor individuo, tiempo iteración, muestra población";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(383, 286);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(193, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Chromosomas de los mejores individuos";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(383, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(213, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Duración de cada iteración en milisegundos";
            // 
            // zedGraphControl4
            // 
            this.zedGraphControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl4.Location = new System.Drawing.Point(383, 302);
            this.zedGraphControl4.Name = "zedGraphControl4";
            this.zedGraphControl4.ScrollGrace = 0D;
            this.zedGraphControl4.ScrollMaxX = 35D;
            this.zedGraphControl4.ScrollMaxY = 8D;
            this.zedGraphControl4.ScrollMaxY2 = 0D;
            this.zedGraphControl4.ScrollMinX = 0D;
            this.zedGraphControl4.ScrollMinY = 0D;
            this.zedGraphControl4.ScrollMinY2 = 0D;
            this.zedGraphControl4.Size = new System.Drawing.Size(369, 158);
            this.zedGraphControl4.TabIndex = 14;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl2.Location = new System.Drawing.Point(383, 23);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(372, 260);
            this.zedGraphControl2.TabIndex = 12;
            // 
            // bestZgc
            // 
            this.bestZgc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bestZgc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bestZgc.Location = new System.Drawing.Point(8, 23);
            this.bestZgc.Name = "bestZgc";
            this.bestZgc.ScrollGrace = 0D;
            this.bestZgc.ScrollMaxX = 0D;
            this.bestZgc.ScrollMaxY = 0D;
            this.bestZgc.ScrollMaxY2 = 0D;
            this.bestZgc.ScrollMinX = 0D;
            this.bestZgc.ScrollMinY = 0D;
            this.bestZgc.ScrollMinY2 = 0D;
            this.bestZgc.Size = new System.Drawing.Size(369, 437);
            this.bestZgc.TabIndex = 11;
            // 
            // mainTbp
            // 
            this.mainTbp.Controls.Add(this.comboBox1);
            this.mainTbp.Controls.Add(this.label15);
            this.mainTbp.Controls.Add(this.groupBox4);
            this.mainTbp.Controls.Add(this.populationZgc);
            this.mainTbp.Controls.Add(this.groupBox3);
            this.mainTbp.Controls.Add(this.groupBox2);
            this.mainTbp.Controls.Add(this.groupBox1);
            this.mainTbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTbp.Location = new System.Drawing.Point(4, 22);
            this.mainTbp.Name = "mainTbp";
            this.mainTbp.Padding = new System.Windows.Forms.Padding(3);
            this.mainTbp.Size = new System.Drawing.Size(761, 466);
            this.mainTbp.TabIndex = 0;
            this.mainTbp.Text = "Parámetros principales, Gráfica de población ordenada";
            this.mainTbp.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Monobjetivo: Problema del viajante",
            "Multiobjetivo: Distribución en planta"});
            this.comboBox1.Location = new System.Drawing.Point(349, 24);
            this.comboBox1.MaxDropDownItems = 1;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.Text = "Mono-objetivo: Problema del viajante";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(349, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Problema y algoritmo a ejecutar";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.bestIndividualTxt);
            this.groupBox4.Controls.Add(this.bestChromosomeTbx);
            this.groupBox4.Controls.Add(this.betFitnessTxt);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(348, 360);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(407, 100);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mejor individuo";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Cromosoma";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Fitness";
            // 
            // bestIndividualTxt
            // 
            this.bestIndividualTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bestIndividualTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestIndividualTxt.Location = new System.Drawing.Point(10, 71);
            this.bestIndividualTxt.Multiline = true;
            this.bestIndividualTxt.Name = "bestIndividualTxt";
            this.bestIndividualTxt.ReadOnly = true;
            this.bestIndividualTxt.Size = new System.Drawing.Size(389, 20);
            this.bestIndividualTxt.TabIndex = 30;
            // 
            // bestChromosomeTbx
            // 
            this.bestChromosomeTbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bestChromosomeTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestChromosomeTbx.Location = new System.Drawing.Point(79, 45);
            this.bestChromosomeTbx.Name = "bestChromosomeTbx";
            this.bestChromosomeTbx.ReadOnly = true;
            this.bestChromosomeTbx.Size = new System.Drawing.Size(320, 20);
            this.bestChromosomeTbx.TabIndex = 34;
            // 
            // betFitnessTxt
            // 
            this.betFitnessTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.betFitnessTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betFitnessTxt.Location = new System.Drawing.Point(79, 19);
            this.betFitnessTxt.Name = "betFitnessTxt";
            this.betFitnessTxt.ReadOnly = true;
            this.betFitnessTxt.Size = new System.Drawing.Size(320, 20);
            this.betFitnessTxt.TabIndex = 28;
            // 
            // populationZgc
            // 
            this.populationZgc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.populationZgc.Location = new System.Drawing.Point(6, 6);
            this.populationZgc.Name = "populationZgc";
            this.populationZgc.ScrollGrace = 0D;
            this.populationZgc.ScrollMaxX = 0D;
            this.populationZgc.ScrollMaxY = 0D;
            this.populationZgc.ScrollMaxY2 = 0D;
            this.populationZgc.ScrollMinX = 0D;
            this.populationZgc.ScrollMinY = 0D;
            this.populationZgc.ScrollMinY2 = 0D;
            this.populationZgc.Size = new System.Drawing.Size(336, 454);
            this.populationZgc.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.borrarGraficasBtn);
            this.groupBox3.Controls.Add(this.borrarGráficasCbx);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.superponerGeneracionesCbx);
            this.groupBox3.Controls.Add(this.monitorizaGraficasCbx);
            this.groupBox3.Controls.Add(this.monitorizaEstadisticasCbx);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(348, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 130);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones de monitorización en tiempo real";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(283, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 26);
            this.label17.TabIndex = 6;
            this.label17.Text = "Las estadísticas finales \r\nsiempre se muestran";
            // 
            // borrarGraficasBtn
            // 
            this.borrarGraficasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarGraficasBtn.Location = new System.Drawing.Point(288, 34);
            this.borrarGraficasBtn.Name = "borrarGraficasBtn";
            this.borrarGraficasBtn.Size = new System.Drawing.Size(115, 22);
            this.borrarGraficasBtn.TabIndex = 5;
            this.borrarGraficasBtn.Text = "Borrar gráficas ahora";
            this.borrarGraficasBtn.UseVisualStyleBackColor = true;
            this.borrarGraficasBtn.Click += new System.EventHandler(this.borrarGraficasBtn_Click);
            // 
            // borrarGráficasCbx
            // 
            this.borrarGráficasCbx.AutoSize = true;
            this.borrarGráficasCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarGráficasCbx.Location = new System.Drawing.Point(10, 38);
            this.borrarGráficasCbx.Name = "borrarGráficasCbx";
            this.borrarGráficasCbx.Size = new System.Drawing.Size(283, 17);
            this.borrarGráficasCbx.TabIndex = 4;
            this.borrarGráficasCbx.Text = "Borrar todas las gráficas al principio de cada ejecución";
            this.borrarGráficasCbx.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(5, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(332, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Puede cambiar cualquiera de estas opciones en tiempo de ejecución";
            // 
            // superponerGeneracionesCbx
            // 
            this.superponerGeneracionesCbx.AutoSize = true;
            this.superponerGeneracionesCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superponerGeneracionesCbx.Location = new System.Drawing.Point(30, 107);
            this.superponerGeneracionesCbx.Name = "superponerGeneracionesCbx";
            this.superponerGeneracionesCbx.Size = new System.Drawing.Size(202, 17);
            this.superponerGeneracionesCbx.TabIndex = 2;
            this.superponerGeneracionesCbx.Text = "Superponer generaciones (muy lento)";
            this.superponerGeneracionesCbx.UseVisualStyleBackColor = true;
            // 
            // monitorizaGraficasCbx
            // 
            this.monitorizaGraficasCbx.AutoSize = true;
            this.monitorizaGraficasCbx.Checked = true;
            this.monitorizaGraficasCbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.monitorizaGraficasCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorizaGraficasCbx.Location = new System.Drawing.Point(12, 84);
            this.monitorizaGraficasCbx.Name = "monitorizaGraficasCbx";
            this.monitorizaGraficasCbx.Size = new System.Drawing.Size(259, 17);
            this.monitorizaGraficasCbx.TabIndex = 1;
            this.monitorizaGraficasCbx.Text = "Monitoriza toda la población en tiempo real (lento)";
            this.monitorizaGraficasCbx.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.monitorizaGraficasCbx.UseVisualStyleBackColor = true;
            this.monitorizaGraficasCbx.CheckedChanged += new System.EventHandler(this.monitorizaGraficasCbx_CheckedChanged);
            // 
            // monitorizaEstadisticasCbx
            // 
            this.monitorizaEstadisticasCbx.AutoSize = true;
            this.monitorizaEstadisticasCbx.Checked = true;
            this.monitorizaEstadisticasCbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.monitorizaEstadisticasCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorizaEstadisticasCbx.Location = new System.Drawing.Point(10, 61);
            this.monitorizaEstadisticasCbx.Name = "monitorizaEstadisticasCbx";
            this.monitorizaEstadisticasCbx.Size = new System.Drawing.Size(251, 17);
            this.monitorizaEstadisticasCbx.TabIndex = 0;
            this.monitorizaEstadisticasCbx.Text = "Monitoriza estadísticas y gráficas en tiempo real";
            this.monitorizaEstadisticasCbx.UseVisualStyleBackColor = true;
            this.monitorizaEstadisticasCbx.CheckedChanged += new System.EventHandler(this.monitorizaEstadisticasCbx_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.duracionIteracionTbx);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.mutationsIterTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.durationTxt);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.iterationsSecTxt);
            this.groupBox2.Controls.Add(this.crossesSecTxt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.crossesTxt);
            this.groupBox2.Controls.Add(this.mutationsSecTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.generationTxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mutationsTxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(549, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 212);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estadísticas";
            // 
            // duracionIteracionTbx
            // 
            this.duracionIteracionTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duracionIteracionTbx.Location = new System.Drawing.Point(117, 164);
            this.duracionIteracionTbx.Name = "duracionIteracionTbx";
            this.duracionIteracionTbx.ReadOnly = true;
            this.duracionIteracionTbx.Size = new System.Drawing.Size(85, 20);
            this.duracionIteracionTbx.TabIndex = 46;
            this.duracionIteracionTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 189);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Duración total";
            // 
            // mutationsIterTxt
            // 
            this.mutationsIterTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mutationsIterTxt.Location = new System.Drawing.Point(117, 59);
            this.mutationsIterTxt.Name = "mutationsIterTxt";
            this.mutationsIterTxt.ReadOnly = true;
            this.mutationsIterTxt.Size = new System.Drawing.Size(85, 20);
            this.mutationsIterTxt.TabIndex = 44;
            this.mutationsIterTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mutaciones / iteración";
            // 
            // durationTxt
            // 
            this.durationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationTxt.Location = new System.Drawing.Point(117, 186);
            this.durationTxt.Name = "durationTxt";
            this.durationTxt.ReadOnly = true;
            this.durationTxt.Size = new System.Drawing.Size(85, 20);
            this.durationTxt.TabIndex = 42;
            this.durationTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Duración iteración";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Iteraciones / segundo";
            // 
            // iterationsSecTxt
            // 
            this.iterationsSecTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationsSecTxt.Location = new System.Drawing.Point(117, 143);
            this.iterationsSecTxt.Name = "iterationsSecTxt";
            this.iterationsSecTxt.ReadOnly = true;
            this.iterationsSecTxt.Size = new System.Drawing.Size(85, 20);
            this.iterationsSecTxt.TabIndex = 39;
            this.iterationsSecTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // crossesSecTxt
            // 
            this.crossesSecTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossesSecTxt.Location = new System.Drawing.Point(117, 101);
            this.crossesSecTxt.Name = "crossesSecTxt";
            this.crossesSecTxt.ReadOnly = true;
            this.crossesSecTxt.Size = new System.Drawing.Size(85, 20);
            this.crossesSecTxt.TabIndex = 38;
            this.crossesSecTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Cruces  / segundo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Cruces";
            // 
            // crossesTxt
            // 
            this.crossesTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossesTxt.Location = new System.Drawing.Point(117, 80);
            this.crossesTxt.Name = "crossesTxt";
            this.crossesTxt.ReadOnly = true;
            this.crossesTxt.Size = new System.Drawing.Size(85, 20);
            this.crossesTxt.TabIndex = 35;
            this.crossesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mutationsSecTxt
            // 
            this.mutationsSecTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mutationsSecTxt.Location = new System.Drawing.Point(117, 38);
            this.mutationsSecTxt.Name = "mutationsSecTxt";
            this.mutationsSecTxt.ReadOnly = true;
            this.mutationsSecTxt.Size = new System.Drawing.Size(85, 20);
            this.mutationsSecTxt.TabIndex = 34;
            this.mutationsSecTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Mutaciones / segundo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Iteraciones";
            // 
            // generationTxt
            // 
            this.generationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generationTxt.Location = new System.Drawing.Point(117, 122);
            this.generationTxt.Name = "generationTxt";
            this.generationTxt.ReadOnly = true;
            this.generationTxt.Size = new System.Drawing.Size(85, 20);
            this.generationTxt.TabIndex = 9;
            this.generationTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Mutaciones";
            // 
            // mutationsTxt
            // 
            this.mutationsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mutationsTxt.Location = new System.Drawing.Point(117, 17);
            this.mutationsTxt.Name = "mutationsTxt";
            this.mutationsTxt.ReadOnly = true;
            this.mutationsTxt.Size = new System.Drawing.Size(85, 20);
            this.mutationsTxt.TabIndex = 31;
            this.mutationsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.multiThreadCbx);
            this.groupBox1.Controls.Add(this.numberOfThreadsTbx);
            this.groupBox1.Controls.Add(this.popSizeTxt);
            this.groupBox1.Controls.Add(this.popSizeLbl);
            this.groupBox1.Controls.Add(this.maxIterationsTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.propParentsTxt);
            this.groupBox1.Controls.Add(this.probMutationTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(348, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 162);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros genéticos";
            // 
            // multiThreadCbx
            // 
            this.multiThreadCbx.AutoSize = true;
            this.multiThreadCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiThreadCbx.Location = new System.Drawing.Point(6, 135);
            this.multiThreadCbx.Name = "multiThreadCbx";
            this.multiThreadCbx.Size = new System.Drawing.Size(115, 17);
            this.multiThreadCbx.TabIndex = 30;
            this.multiThreadCbx.Text = "Alg. paralelo | Hilos";
            this.multiThreadCbx.UseVisualStyleBackColor = true;
            this.multiThreadCbx.CheckedChanged += new System.EventHandler(this.multiThreadCbx_CheckedChanged);
            // 
            // numberOfThreadsTbx
            // 
            this.numberOfThreadsTbx.Enabled = false;
            this.numberOfThreadsTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfThreadsTbx.Location = new System.Drawing.Point(126, 132);
            this.numberOfThreadsTbx.Name = "numberOfThreadsTbx";
            this.numberOfThreadsTbx.Size = new System.Drawing.Size(62, 20);
            this.numberOfThreadsTbx.TabIndex = 29;
            this.numberOfThreadsTbx.Text = "2";
            // 
            // popSizeTxt
            // 
            this.popSizeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popSizeTxt.Location = new System.Drawing.Point(126, 106);
            this.popSizeTxt.Name = "popSizeTxt";
            this.popSizeTxt.Size = new System.Drawing.Size(62, 20);
            this.popSizeTxt.TabIndex = 27;
            this.popSizeTxt.Text = "10000";
            // 
            // popSizeLbl
            // 
            this.popSizeLbl.AutoSize = true;
            this.popSizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popSizeLbl.Location = new System.Drawing.Point(6, 109);
            this.popSizeLbl.Name = "popSizeLbl";
            this.popSizeLbl.Size = new System.Drawing.Size(96, 13);
            this.popSizeLbl.TabIndex = 26;
            this.popSizeLbl.Text = "Tamaño Población";
            // 
            // maxIterationsTxt
            // 
            this.maxIterationsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxIterationsTxt.Location = new System.Drawing.Point(127, 77);
            this.maxIterationsTxt.Name = "maxIterationsTxt";
            this.maxIterationsTxt.Size = new System.Drawing.Size(62, 20);
            this.maxIterationsTxt.TabIndex = 19;
            this.maxIterationsTxt.Text = "30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Máximas iteraciones";
            // 
            // propParentsTxt
            // 
            this.propParentsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propParentsTxt.Location = new System.Drawing.Point(127, 51);
            this.propParentsTxt.Name = "propParentsTxt";
            this.propParentsTxt.Size = new System.Drawing.Size(62, 20);
            this.propParentsTxt.TabIndex = 16;
            this.propParentsTxt.Text = "0,3";
            // 
            // probMutationTxt
            // 
            this.probMutationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probMutationTxt.Location = new System.Drawing.Point(127, 23);
            this.probMutationTxt.Name = "probMutationTxt";
            this.probMutationTxt.Size = new System.Drawing.Size(62, 20);
            this.probMutationTxt.TabIndex = 15;
            this.probMutationTxt.Text = "0,05";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Proporcion padres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Probabilidad mutación";
            // 
            // mainTbc
            // 
            this.mainTbc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTbc.Controls.Add(this.mainTbp);
            this.mainTbc.Controls.Add(this.tabPage2);
            this.mainTbc.Controls.Add(this.tabPage1);
            this.mainTbc.Controls.Add(this.tabPage3);
            this.mainTbc.Location = new System.Drawing.Point(0, 24);
            this.mainTbc.Name = "mainTbc";
            this.mainTbc.SelectedIndex = 0;
            this.mainTbc.Size = new System.Drawing.Size(769, 492);
            this.mainTbc.TabIndex = 34;
            
            // 
            // procCoreInfoLbl
            // 
            this.procCoreInfoLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.procCoreInfoLbl.AutoSize = true;
            this.procCoreInfoLbl.Location = new System.Drawing.Point(1, 528);
            this.procCoreInfoLbl.Name = "procCoreInfoLbl";
            this.procCoreInfoLbl.Size = new System.Drawing.Size(220, 13);
            this.procCoreInfoLbl.TabIndex = 37;
            this.procCoreInfoLbl.Text = "Esperando información sobre procesadores...";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.paretoZgc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(761, 466);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Frente de Pareto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // paretoZgc
            // 
            this.paretoZgc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.paretoZgc.Location = new System.Drawing.Point(8, 6);
            this.paretoZgc.Name = "paretoZgc";
            this.paretoZgc.ScrollGrace = 0D;
            this.paretoZgc.ScrollMaxX = 0D;
            this.paretoZgc.ScrollMaxY = 0D;
            this.paretoZgc.ScrollMaxY2 = 0D;
            this.paretoZgc.ScrollMinX = 0D;
            this.paretoZgc.ScrollMinY = 0D;
            this.paretoZgc.ScrollMinY2 = 0D;
            this.paretoZgc.Size = new System.Drawing.Size(750, 454);
            this.paretoZgc.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(761, 466);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Información";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(5, 7);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(322, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Valor de fitness del mejor individuo de cada generación";
            // 
            // MainForm
            // 
            this.AcceptButton = this.comenzarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 552);
            this.Controls.Add(this.procCoreInfoLbl);
            this.Controls.Add(this.detenerBtn);
            this.Controls.Add(this.workingPbx);
            this.Controls.Add(this.mainTbc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comenzarBtn);
            this.Controls.Add(this.algRunningLbl);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "NSGA-II";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workingPbx)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.mainTbp.ResumeLayout(false);
            this.mainTbp.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainTbc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button comenzarBtn;
        private System.Windows.Forms.Button acercaDeBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label algRunningLbl;
        private System.Windows.Forms.PictureBox workingPbx;
        private System.Windows.Forms.Button detenerBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage tabPage2;
        private ZedGraph.ZedGraphControl zedGraphControl4;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private ZedGraph.ZedGraphControl bestZgc;
        private System.Windows.Forms.TabPage mainTbp;
        private System.Windows.Forms.TextBox betFitnessTxt;
        private System.Windows.Forms.TextBox bestIndividualTxt;
        private ZedGraph.ZedGraphControl populationZgc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox borrarGráficasCbx;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox superponerGeneracionesCbx;
        private System.Windows.Forms.CheckBox monitorizaGraficasCbx;
        private System.Windows.Forms.CheckBox monitorizaEstadisticasCbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox mutationsIterTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox durationTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox iterationsSecTxt;
        private System.Windows.Forms.TextBox crossesSecTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox crossesTxt;
        private System.Windows.Forms.TextBox mutationsSecTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox generationTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mutationsTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox multiThreadCbx;
        private System.Windows.Forms.TextBox numberOfThreadsTbx;
        private System.Windows.Forms.TextBox popSizeTxt;
        private System.Windows.Forms.Label popSizeLbl;
        private System.Windows.Forms.TextBox maxIterationsTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox propParentsTxt;
        private System.Windows.Forms.TextBox probMutationTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl mainTbc;
        private System.Windows.Forms.Button borrarGraficasBtn;
        private System.Windows.Forms.TextBox duracionIteracionTbx;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox bestChromosomeTbx;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label procCoreInfoLbl;
        private System.Windows.Forms.TabPage tabPage1;
        private ZedGraph.ZedGraphControl paretoZgc;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label20;
    }
}

