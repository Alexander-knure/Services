namespace Course_forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cCPU = new CircularProgressBar.CircularProgressBar();
            this.cRAM = new CircularProgressBar.CircularProgressBar();
            this.cTCPU = new CircularProgressBar.CircularProgressBar();
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelTCPU = new System.Windows.Forms.Label();
            this.labelMobo = new System.Windows.Forms.Label();
            this.cTMB = new CircularProgressBar.CircularProgressBar();
            this.labelVoltage = new System.Windows.Forms.Label();
            this.сSB = new CircularProgressBar.CircularProgressBar();
            this.TempCPU = new System.Diagnostics.PerformanceCounter();
            this.tempMOBO = new System.Diagnostics.PerformanceCounter();
            this.Voltage = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempMOBO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Voltage)).BeginInit();
            this.SuspendLayout();
            // 
            // cCPU
            // 
            this.cCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CubicEaseIn;
            this.cCPU.AnimationSpeed = 500;
            this.cCPU.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.cCPU, "cCPU");
            this.cCPU.ForeColor = System.Drawing.Color.GhostWhite;
            this.cCPU.InnerColor = System.Drawing.Color.Transparent;
            this.cCPU.InnerMargin = 2;
            this.cCPU.InnerWidth = -1;
            this.cCPU.MarqueeAnimationSpeed = 500;
            this.cCPU.Name = "cCPU";
            this.cCPU.OuterColor = System.Drawing.Color.White;
            this.cCPU.OuterMargin = -20;
            this.cCPU.OuterWidth = 25;
            this.cCPU.ProgressColor = System.Drawing.Color.Red;
            this.cCPU.ProgressWidth = 25;
            this.cCPU.SecondaryFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cCPU.StartAngle = 270;
            this.cCPU.SubscriptColor = System.Drawing.Color.White;
            this.cCPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cCPU.SubscriptText = "";
            this.cCPU.SuperscriptColor = System.Drawing.Color.Black;
            this.cCPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cCPU.SuperscriptText = "";
            this.cCPU.TextMargin = new System.Windows.Forms.Padding(0);
            this.cCPU.Value = 68;
            this.cCPU.Click += new System.EventHandler(this.cCPU_Click);
            // 
            // cRAM
            // 
            this.cRAM.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cRAM.AnimationSpeed = 300;
            this.cRAM.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.cRAM, "cRAM");
            this.cRAM.ForeColor = System.Drawing.Color.GhostWhite;
            this.cRAM.InnerColor = System.Drawing.Color.Transparent;
            this.cRAM.InnerMargin = 2;
            this.cRAM.InnerWidth = -1;
            this.cRAM.MarqueeAnimationSpeed = 2000;
            this.cRAM.Name = "cRAM";
            this.cRAM.OuterColor = System.Drawing.Color.White;
            this.cRAM.OuterMargin = -20;
            this.cRAM.OuterWidth = 25;
            this.cRAM.ProgressColor = System.Drawing.Color.LawnGreen;
            this.cRAM.ProgressWidth = 25;
            this.cRAM.SecondaryFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cRAM.StartAngle = 270;
            this.cRAM.SubscriptColor = System.Drawing.Color.White;
            this.cRAM.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cRAM.SubscriptText = "";
            this.cRAM.SuperscriptColor = System.Drawing.Color.Black;
            this.cRAM.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cRAM.SuperscriptText = "";
            this.cRAM.TextMargin = new System.Windows.Forms.Padding(0);
            this.cRAM.Value = 68;
            this.cRAM.Click += new System.EventHandler(this.cRAM_Click);
            // 
            // cTCPU
            // 
            this.cTCPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cTCPU.AnimationSpeed = 500;
            this.cTCPU.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.cTCPU, "cTCPU");
            this.cTCPU.ForeColor = System.Drawing.Color.GhostWhite;
            this.cTCPU.InnerColor = System.Drawing.Color.Transparent;
            this.cTCPU.InnerMargin = 2;
            this.cTCPU.InnerWidth = -1;
            this.cTCPU.MarqueeAnimationSpeed = 2000;
            this.cTCPU.Name = "cTCPU";
            this.cTCPU.OuterColor = System.Drawing.Color.White;
            this.cTCPU.OuterMargin = -20;
            this.cTCPU.OuterWidth = 25;
            this.cTCPU.ProgressColor = System.Drawing.Color.DarkOrange;
            this.cTCPU.ProgressWidth = 25;
            this.cTCPU.SecondaryFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cTCPU.StartAngle = 270;
            this.cTCPU.SubscriptColor = System.Drawing.Color.White;
            this.cTCPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cTCPU.SubscriptText = "";
            this.cTCPU.SuperscriptColor = System.Drawing.Color.Black;
            this.cTCPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cTCPU.SuperscriptText = "";
            this.cTCPU.TextMargin = new System.Windows.Forms.Padding(0);
            this.cTCPU.Value = 68;
            // 
            // CPU
            // 
            this.CPU.CategoryName = "Processor";
            this.CPU.CounterName = "% Processor Time";
            this.CPU.InstanceName = "_Total";
            // 
            // RAM
            // 
            this.RAM.CategoryName = "Memory";
            this.RAM.CounterName = "% Committed Bytes In Use";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelCPU
            // 
            resources.ApplyResources(this.labelCPU, "labelCPU");
            this.labelCPU.BackColor = System.Drawing.Color.Transparent;
            this.labelCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCPU.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCPU.Name = "labelCPU";
            // 
            // labelRAM
            // 
            resources.ApplyResources(this.labelRAM, "labelRAM");
            this.labelRAM.BackColor = System.Drawing.Color.Transparent;
            this.labelRAM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelRAM.Name = "labelRAM";
            // 
            // labelTCPU
            // 
            resources.ApplyResources(this.labelTCPU, "labelTCPU");
            this.labelTCPU.BackColor = System.Drawing.Color.Transparent;
            this.labelTCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTCPU.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTCPU.Name = "labelTCPU";
            this.labelTCPU.Click += new System.EventHandler(this.labelHDD_Click);
            // 
            // labelMobo
            // 
            resources.ApplyResources(this.labelMobo, "labelMobo");
            this.labelMobo.BackColor = System.Drawing.Color.Transparent;
            this.labelMobo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMobo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMobo.Name = "labelMobo";
            this.labelMobo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cTMB
            // 
            this.cTMB.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cTMB.AnimationSpeed = 500;
            this.cTMB.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.cTMB, "cTMB");
            this.cTMB.ForeColor = System.Drawing.Color.GhostWhite;
            this.cTMB.InnerColor = System.Drawing.Color.Transparent;
            this.cTMB.InnerMargin = 2;
            this.cTMB.InnerWidth = -1;
            this.cTMB.MarqueeAnimationSpeed = 2000;
            this.cTMB.Name = "cTMB";
            this.cTMB.OuterColor = System.Drawing.Color.White;
            this.cTMB.OuterMargin = -20;
            this.cTMB.OuterWidth = 25;
            this.cTMB.ProgressColor = System.Drawing.Color.Blue;
            this.cTMB.ProgressWidth = 25;
            this.cTMB.SecondaryFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cTMB.StartAngle = 270;
            this.cTMB.SubscriptColor = System.Drawing.Color.White;
            this.cTMB.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cTMB.SubscriptText = "";
            this.cTMB.SuperscriptColor = System.Drawing.Color.Black;
            this.cTMB.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cTMB.SuperscriptText = "";
            this.cTMB.TextMargin = new System.Windows.Forms.Padding(0);
            this.cTMB.Value = 68;
            // 
            // labelVoltage
            // 
            resources.ApplyResources(this.labelVoltage, "labelVoltage");
            this.labelVoltage.BackColor = System.Drawing.Color.Transparent;
            this.labelVoltage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelVoltage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelVoltage.Name = "labelVoltage";
            this.labelVoltage.Click += new System.EventHandler(this.label2_Click);
            // 
            // сSB
            // 
            this.сSB.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.сSB.AnimationSpeed = 500;
            this.сSB.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.сSB, "сSB");
            this.сSB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.сSB.InnerColor = System.Drawing.Color.Transparent;
            this.сSB.InnerMargin = 2;
            this.сSB.InnerWidth = -1;
            this.сSB.MarqueeAnimationSpeed = 2000;
            this.сSB.Name = "сSB";
            this.сSB.OuterColor = System.Drawing.Color.White;
            this.сSB.OuterMargin = -20;
            this.сSB.OuterWidth = 25;
            this.сSB.ProgressColor = System.Drawing.Color.Yellow;
            this.сSB.ProgressWidth = 25;
            this.сSB.SecondaryFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сSB.StartAngle = 270;
            this.сSB.SubscriptColor = System.Drawing.Color.White;
            this.сSB.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.сSB.SubscriptText = "";
            this.сSB.SuperscriptColor = System.Drawing.Color.Black;
            this.сSB.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.сSB.SuperscriptText = "";
            this.сSB.TextMargin = new System.Windows.Forms.Padding(0);
            this.сSB.Value = 68;
            // 
            // TempCPU
            // 
            this.TempCPU.CategoryName = "Thermal Zone Information";
            this.TempCPU.CounterName = "% Temperature";
            this.TempCPU.InstanceName = "_TZ.THRM";
            // 
            // tempMOBO
            // 
            this.tempMOBO.CategoryName = "Memory";
            this.tempMOBO.CounterName = "% Committed Bytes In Use";
            // 
            // Voltage
            // 
            this.Voltage.CategoryName = "Memory";
            this.Voltage.CounterName = "% Committed Bytes In Use";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.labelVoltage);
            this.Controls.Add(this.сSB);
            this.Controls.Add(this.labelMobo);
            this.Controls.Add(this.cTMB);
            this.Controls.Add(this.labelTCPU);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.cTCPU);
            this.Controls.Add(this.cRAM);
            this.Controls.Add(this.cCPU);
            this.ForeColor = System.Drawing.Color.GhostWhite;
            this.HelpButton = true;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.TempCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempMOBO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Voltage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar cCPU;
        private CircularProgressBar.CircularProgressBar cRAM;
        private CircularProgressBar.CircularProgressBar cTCPU;
        private CircularProgressBar.CircularProgressBar cTMB;
        private CircularProgressBar.CircularProgressBar сSB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelMobo;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelTCPU;
        private System.Windows.Forms.Label labelVoltage;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Diagnostics.PerformanceCounter RAM;
        private System.Diagnostics.PerformanceCounter Voltage;
        private System.Diagnostics.PerformanceCounter TempCPU;
        private System.Diagnostics.PerformanceCounter tempMOBO;
    }
}

