using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using GeneticModelExamplesLib;
using nsga2lib;
using ZedGraph;

namespace nsga2win {
    public partial class MainForm : Form
    {

        #region Properties
        private GeneticAlgorithm alg;
        //private Population solution;
        private Thread workerThread;
        #endregion


        /* First you have to create the 2 performance counters 
           using the System.Diagnostics.PerformanceCounter class. 
        */


        #region Constructor
        public MainForm() {
            InitializeComponent();
            InitGraphs();



            Thread t = new Thread(new ThreadStart(GetProcessorsAndCores));
            t.Start();
            
        }
        #endregion
        
        #region Get CPU Utilisation data

        protected PerformanceCounter[] cpuCounter;
        protected PerformanceCounter ramCounter;
        private PointPairList[] CpuList;
        private int NumProcessors;
        private int NumCores;
        //private Object NumProcLock;
        private bool NumProcInitialised = false;
        private void InitProcCounters()
        {

            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            cpuCounter = new PerformanceCounter[NumProcessors];
            CpuList = new PointPairList[NumProcessors];
            
            for (int i = 0 ; i < NumProcessors ; i++ )
            {
                CpuList[i] = new PointPairList();
                cpuCounter[i] = new PerformanceCounter();
                cpuCounter[i].CategoryName = "Processor";
                cpuCounter[i].CounterName = "% Processor Time";
                //cpuCounter.InstanceName = "_Total";
                cpuCounter[i].InstanceName = i.ToString();
                //LineItem cpuCurve = zedGraphControl3.GraphPane.AddCurve("% uso procesador", CpuList[i], Color.Green,
                //                                                SymbolType.None);
                //cpuCurve.Line.Fill = new Fill(Color.White, Color.FromArgb(60, 230, 145, 205), 90F);
            }


            NumProcInitialised = true;
        }
        private void RegisterProcUsage(double milliseconds)
        {
            if ( NumProcessors > 0 )
            {
                if ( ! NumProcInitialised ) InitProcCounters();
                for ( int i = 0 ; i < NumProcessors ; i++ )
                {
                    //CpuList[i].Add(milliseconds,cpuCounter[i].NextValue());
                }
                //zedGraphControl3.Invalidate();

            }
        }

        #endregion

        #region Get Processors and Cores info in a separate thread
        public void GetProcessorsAndCores()
        {


            NumProcessors = WMI_ProcessorInformation.WMI_Processor_Information.GetCpuNumberOfLogicalProcessors();

            NumCores = WMI_ProcessorInformation.WMI_Processor_Information.GetCpuCores();
            WriteProcessorsAndCoresToUi();
            InitProcCounters();
        }
        private delegate void FinishGetingProcCoresInfo();
        public void WriteProcessorsAndCoresToUi()
        {
            if ( this.procCoreInfoLbl.InvokeRequired )
            {
                this.procCoreInfoLbl.Invoke(new FinishGetingProcCoresInfo(WriteProcessorsAndCoresToUi));
            } else
            {
                procCoreInfoLbl.Text = "Nucleos:  " + NumCores.ToString() +
                                       "  |  Procesadores lógicos: " + NumProcessors.ToString();
                procCoreInfoLbl.Invalidate();
            }
        }
        #endregion

        #region Algorithm start
        private void comenzarBtn_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Prueba algoritmo genético");
            //Inicializamos la factoria de individuos
            InitGraphs();

            if ( alg == null )
            {
                alg = new GeneticAlgorithm
                          {
                              ParentsProportion = Convert.ToDouble(propParentsTxt.Text),
                              MutationProbability = Convert.ToDouble(probMutationTxt.Text),
                              PopulationSize = Convert.ToInt32(popSizeTxt.Text),
                              MaxGeneration = Convert.ToInt32(maxIterationsTxt.Text),
                              Model = new ViajanteAndalucia(),
                              MultiThread = this.multiThreadCbx.Checked,
                              NumThreads = Convert.ToInt32(this.numberOfThreadsTbx.Text),
                              ActivateGraphics = monitorizaGraficasCbx.Checked,
                              ActivateStatistics = monitorizaEstadisticasCbx.Checked,
                              DrawStatisticsMethod = new GeneticAlgorithm.DrawStatistics(UIDrawStatistics),
                              DrawGraphicsMethod = new GeneticAlgorithm.DrawGraphics(UIDrawGraphs),

                              FinishEvent = new GeneticAlgorithm.FinishHandle(Finish)

                          }; 
                
                workerThread = new Thread(alg.Start);

                // Start the worker thread.
                workerThread.Start();

                // Loop until worker thread activates.
                //while (!workerThread.IsAlive) ;
                // Put the main thread to sleep for 1 millisecond to
                // allow the worker thread to do some work:
                //Thread.Sleep(1);
                // Request that the worker thread stop itself:
                //workerObject.RequestStop();
                // Use the Join method to block the current thread 
                // until the object's thread terminates.
                //workerThread.Join();
            }

            betFitnessTxt.Text = "";
            bestIndividualTxt.Text = "";
            comenzarBtn.Enabled = false;
            
            multiThreadCbx.Enabled = false;
            numberOfThreadsTbx.Enabled = false;

            workingPbx.Visible = true;
            algRunningLbl.Visible = true;
            probMutationTxt.ReadOnly = true;
            propParentsTxt.ReadOnly = true;
            maxIterationsTxt.ReadOnly = true;
            popSizeTxt.ReadOnly = true;
            detenerBtn.Enabled = true;
            button1.Enabled = true;



            generationTxt.Text = "";
            bestIndividualTxt.Text = "";
            bestChromosomeTbx.Text = "";
            mutationsTxt.Text = "";
            mutationsSecTxt.Text = "";
            crossesTxt.Text = "";
            crossesSecTxt.Text = "";
            iterationsSecTxt.Text = "";
            durationTxt.Text = "";
            betFitnessTxt.Text = "";
            mutationsIterTxt.Text = "";
            duracionIteracionTbx.Text = "";

            PreviousGenerationTimeMilliseconds = 0;

            if (this.borrarGráficasCbx.Checked)
            {
                BorrarGraficas();
            }
            else
            {
                ChangeAllCurvesColor(populationZgc, Color.Green);
                ChangeAllCurvesColor(bestZgc, Color.Blue);
                ChangeAllCurvesColor(zedGraphControl2, Color.Blue);
                //ChangeAllCurvesColor(zedGraphControl3, Color.Blue);
            }

            generationTimeList = new PointPairList();
            bestFitnessList = new PointPairList();



            //if (zedGraphControl3.GraphPane.CurveList.Count > 1)
            //{
            //    zedGraphControl3.GraphPane.CurveList.Move(zedGraphControl3.GraphPane.CurveList.Count - 1,
            //        -(zedGraphControl3.GraphPane.CurveList.Count - 1));
            //}

        }
 
        #endregion

        #region Statistics drawing

        private PointPairList bestFitnessList;
        private PointPairList generationTimeList;
        private Double PreviousGenerationTimeMilliseconds = 0;

        public string runningTime;
        public void UIDrawStatistics(GeneticStats stats)
        {

            if (generationTxt.InvokeRequired)
            {
                generationTxt.Invoke(new GeneticAlgorithm.DrawStatistics(UIDrawStatistics), stats);
            }
            else
            {
                runningTime = stats.RunningTime.ToString().Substring(0, 12);
                int stringCut = runningTime.Length < 12 ? runningTime.Length : 12;
                try
                {
                    durationTxt.Text = runningTime.Substring(0, stringCut);
                } catch(Exception)
                {
                    durationTxt.Text = runningTime;
                } 

                generationTxt.Text = stats.Generation.ToString();
                bestIndividualTxt.Text = alg.Model.Decode(stats.BestIndividualChromosome.Genes);
                betFitnessTxt.Text = stats.BestFitness.ToString();
                bestChromosomeTbx.Text = stats.BestIndividualChromosome.ToString();

                mutationsTxt.Text = stats.TotalMutations.ToString();
                mutationsSecTxt.Text = stats.MutationsPerSecond.ToString("F2");
                crossesTxt.Text = stats.TotalCrosses.ToString();
                crossesSecTxt.Text = stats.CrossesPerSecond.ToString("F2");
                iterationsSecTxt.Text = stats.IterationsPerSecond.ToString("F2");
                

                mutationsIterTxt.Text = stats.MutationsPerIteration.ToString("F2");
                this.Invalidate();

                bestFitnessList.Add(stats.Generation,stats.BestFitness);
                //bestZgc.GraphPane.CurveList.Clear();
                bestZgc.GraphPane.AddCurve("Valor de Fitness", bestFitnessList, Color.Red, SymbolType.Diamond);
                bestZgc.AxisChange();
                bestZgc.Invalidate();

                Double generationTime = stats.RunningTimeMilliseconds - PreviousGenerationTimeMilliseconds;
                PreviousGenerationTimeMilliseconds = stats.RunningTimeMilliseconds;

                duracionIteracionTbx.Text = generationTime.ToString("F2");

                //bestZgc.GraphPane.CurveList.Clear();
                if (stats.Generation > 1)
                {
                    generationTimeList.Add(stats.Generation, generationTime);
                    zedGraphControl2.GraphPane.AddCurve("Tiempo Generación", generationTimeList, Color.Red,
                                                        SymbolType.Diamond);
                }
                zedGraphControl2.AxisChange();
                zedGraphControl2.Invalidate();

                //Gráfica de los procesadores y los núcleos
                //RegisterProcUsage(stats.RunningTimeMilliseconds);
                //zedGraphControl3.AxisChange();
                //zedGraphControl3.Invalidate();
            }
        }
        #endregion

        #region Graph drawing
      
        private void InitGraphs()
        {

            // Gráfica Población

            // Get a reference to the GraphPane instance in the ZedGraphControl
            SetUpGraphPane(populationZgc.GraphPane);
            populationZgc.GraphPane.Title.Text = "Población significativa ordenada";
            populationZgc.GraphPane.XAxis.Title.Text = "Individuos";
            populationZgc.GraphPane.YAxis.Title.Text = "Valor de fitness";
            
            // Gráfica 1
            SetUpGraphPane(bestZgc.GraphPane);
            bestZgc.GraphPane.Title.Text = "";
            bestZgc.GraphPane.XAxis.Title.Text = "Generación";
            bestZgc.GraphPane.YAxis.Title.Text = "Valor de fitness";

            // Gráfica 2
            SetUpGraphPane(zedGraphControl2.GraphPane);
            zedGraphControl2.GraphPane.Title.Text = "";
            zedGraphControl2.GraphPane.XAxis.Title.Text = "Generación";
            zedGraphControl2.GraphPane.YAxis.Title.Text = "Milisegundos";

            // Gráfica 3
            //SetUpGraphPane(zedGraphControl3.GraphPane);
            //zedGraphControl3.GraphPane.Title.Text = "";
            //zedGraphControl3.GraphPane.XAxis.Title.Text = "";
            //zedGraphControl3.GraphPane.YAxis.Title.Text = "";

            // Gráfica 4
            SetUpGraphPane(zedGraphControl4.GraphPane);
            zedGraphControl4.GraphPane.Title.Text = "";
            zedGraphControl4.GraphPane.XAxis.Title.Text = "Mejores individuos";
            zedGraphControl4.GraphPane.YAxis.Title.Text = "Genes";

            // Frente de Pareto
            // Get a reference to the GraphPane instance in the ZedGraphControl
            SetUpGraphPane(paretoZgc.GraphPane);
            paretoZgc.GraphPane.Title.Text = "Frente de Pareto";
            paretoZgc.GraphPane.XAxis.Title.Text = "f1";
            paretoZgc.GraphPane.YAxis.Title.Text = "f2";
        }

        public void SetUpGraphPane(GraphPane myPane)
        {
            //Inicialización de la gráfica
            myPane.Legend.IsVisible = false;

            // Set the titles and axis labels
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsVisible = true;

            // Make the Y axis scale red
            myPane.YAxis.Scale.FontSpec.FontColor = Color.Red;
            myPane.YAxis.Title.FontSpec.FontColor = Color.Red;
            // turn off the opposite tics so the Y tics don't show up on the Y2 axis
            myPane.YAxis.MajorTic.IsOpposite = false;
            myPane.YAxis.MinorTic.IsOpposite = false;
            // Don't display the Y zero line
            myPane.YAxis.MajorGrid.IsZeroLine = false;
            // Align the Y axis labels so they are flush to the axis
            myPane.YAxis.Scale.Align = AlignP.Inside;
            // Manually set the axis range
            //myPane.YAxis.Scale.Min = -30;
            //myPane.YAxis.Scale.Max = 30;

            // Fill the axis background with a gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);

            // Enable scrollbars if needed
            //populationZgc.IsShowHScrollBar = true;
            //populationZgc.IsShowVScrollBar = true;
            //populationZgc.IsAutoScrollRange = true;
            //populationZgc.IsScrollY2 = true;
        }

        private void BorrarGraficas()
        {
            populationZgc.GraphPane.CurveList.Clear();
            populationZgc.Invalidate();
            bestZgc.GraphPane.CurveList.Clear();
            bestZgc.Invalidate();
            zedGraphControl2.GraphPane.CurveList.Clear();
            zedGraphControl2.Invalidate();
            //zedGraphControl3.GraphPane.CurveList.Clear();
            //zedGraphControl3.Invalidate();
            zedGraphControl4.GraphPane.CurveList.Clear();
            zedGraphControl4.Invalidate();
        }
        public void ChangeAllCurvesColor(ZedGraphControl zedGraphControl, Color color)
        {
            if (zedGraphControl.GraphPane.CurveList.Count > 0)
            {
                for (int i = 0; i < zedGraphControl.GraphPane.CurveList.Count; i++)
                {
                    LineItem myBar =
                        zedGraphControl.GraphPane.CurveList[i] as
                        LineItem;
                    if (myBar != null)
                        myBar.Color = color;
                }
            }
        }
        public void AddPointToGraph(ZedGraphControl zgc)
        {
           
        }
        public void UIDrawGraphs(Population population, bool firstInvocation)
        {
            if (populationZgc.InvokeRequired)
            {
                populationZgc.Invoke(new GeneticAlgorithm.DrawGraphics(UIDrawGraphs), population, firstInvocation);
            }
            else
            {
               
                // Get a reference to the GraphPane instance in the ZedGraphControl
                GraphPane myPane = populationZgc.GraphPane;
                PointPairList list = new PointPairList();

                
                for (int i = 0; i < population.Members.Length; i++)
                {
                    if (population.Members[i].FitnessValue < 10000)
                    {
                        list.Add(i, population.Members[i].FitnessValue);

                    }
                }
                if ( superponerGeneracionesCbx.Checked || (firstInvocation && ! this.borrarGráficasCbx.Checked ) )
                {
                    ChangeAllCurvesColor(populationZgc, Color.Blue);
                }
                else
                {
                    this.populationZgc.GraphPane.CurveList.Clear();
                }

                // Generate a red curve with diamond symbols, and "Alpha" in the legend
                LineItem myCurve = myPane.AddCurve("Valor de Fitness",
                    list, Color.Red, SymbolType.None);
                myPane.CurveList.Move(myPane.CurveList.Count - 1, -(myPane.CurveList.Count - 1));
                // Fill the symbols with white
                //myCurve.Symbol.Fill = new Fill(Color.White);
                myCurve.Line.Fill = new Fill(Color.White, Color.FromArgb(160, 230, 145, 205), 90F);
                // Tell ZedGraph to calculate the axis ranges
                // Note that you MUST call this after enabling IsAutoScrollRange, since AxisChange() sets
                // up the proper scrolling parameters
                populationZgc.AxisChange();
                // Make sure the Graph gets redrawn
                populationZgc.Invalidate();


                // Muestra los 100 mejores genes
                PointPairList[] genes = new PointPairList[alg.Model.GenValues.Count];
                for (int i = 0; i < alg.Model.GenValues.Count; i++)
                {
                    genes[i] = new PointPairList();
                }
                for (int i = 0; i < population.Members.Length && i < 35; i++)
                {
                    for (int j = 0; j < population.Members[i].Chromosome.Genes.Length; j++)
                    {
                        genes[j].Add(i, population.Members[i].Chromosome.Genes[j]+1);
                    }
                }
                this.zedGraphControl4.GraphPane.CurveList.Clear();
                for (int i = 0; i < genes.Length; i++)
                {
                    LineItem gCurve = this.zedGraphControl4.GraphPane.AddCurve("Genes", genes[i], Color.Transparent,
                                                                               SymbolType.Circle);
                    
                    int colorFactor = Convert.ToInt32(255.0 * (1 - (1.0*i) / alg.Model.GenValues.Count ));

                    gCurve.Symbol.Fill = new Fill(Color.FromArgb(colorFactor, 0, 0, 255));
                    gCurve.Symbol.Size = 30.0F;
                }
                // up the proper scrolling parameters
                zedGraphControl4.AxisChange();
                // Make sure the Graph gets redrawn
                zedGraphControl4.Invalidate();
            }
        }



        #endregion

        #region Finish delegate

        public void Finish()
        {

            if (algRunningLbl.InvokeRequired)
            {
                generationTxt.Invoke(new GeneticAlgorithm.FinishHandle(Finish));
            }
            else
            {
                algRunningLbl.Visible = false;
                workingPbx.Visible = false;
                comenzarBtn.Enabled = true;
                probMutationTxt.ReadOnly = false;
                propParentsTxt.ReadOnly = false;
                maxIterationsTxt.ReadOnly = false;
                popSizeTxt.ReadOnly = false;
                button1.Enabled = false;
                detenerBtn.Enabled = false;

                multiThreadCbx.Enabled = true;
                numberOfThreadsTbx.Enabled = multiThreadCbx.Checked;

                alg = null;

            }
        }
        #endregion

        #region UI events handlers
        private void salirBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeBtn_Click(object sender, EventArgs e)
        {
            Form f = new AcercaDe();
            f.ShowDialog();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (alg != null )
            {
                if (alg.Pause)
                {
                    alg.Pause = false;
                    this.button1.Text = "Pausa";
                    this.workingPbx.Visible = true;
                    this.algRunningLbl.Visible = true;
                } else
                {
                    alg.Pause = true;
                    this.button1.Text = "Reanudar";
                    this.workingPbx.Visible = false;
                    this.algRunningLbl.Visible = false;
                }
            }
        }

        private void monitorizaEstadisticasCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (this.alg != null )
            {
                this.alg.ActivateStatistics = monitorizaEstadisticasCbx.Checked;
            }
        }

        private void monitorizaGraficasCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (this.alg != null)
            {
                this.alg.ActivateGraphics = monitorizaGraficasCbx.Checked;
            }
            superponerGeneracionesCbx.Enabled = monitorizaGraficasCbx.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.workerThread != null && this.workerThread.IsAlive)
            {
                this.workerThread.Abort();
            }
        }

        private void detenerBtn_Click(object sender, EventArgs e)
        {
            if (this.workerThread != null && this.workerThread.IsAlive)
            {
                this.workerThread.Abort();
            }
            button1.Text = "Pausa";
            Finish();
            if (alg != null)
            {
                UIDrawGraphs(alg.Population,true);
                UIDrawStatistics(alg.Stats);
                alg = null;
            }
            detenerBtn.Enabled = false;

        }
        private void multiThreadCbx_CheckedChanged(object sender, EventArgs e)
        {
            this.numberOfThreadsTbx.Enabled = this.multiThreadCbx.Checked;
        }

        private void borrarGraficasBtn_Click(object sender, EventArgs e)
        {
            BorrarGraficas();
        }

        private void generarSemillaBtn_Click(object sender, EventArgs e)
        {
            
        }
        #endregion





    }
}