namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbMakeSunny = new System.Windows.Forms.TrackBar();
            this.lblSunny = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMakeSunny)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picDisplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDisplay.BackgroundImage")));
            this.picDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDisplay.Location = new System.Drawing.Point(-115, -149);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(1024, 578);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbMakeSunny
            // 
            this.tbMakeSunny.Location = new System.Drawing.Point(928, 34);
            this.tbMakeSunny.Maximum = 100;
            this.tbMakeSunny.Name = "tbMakeSunny";
            this.tbMakeSunny.Size = new System.Drawing.Size(179, 56);
            this.tbMakeSunny.TabIndex = 1;
            this.tbMakeSunny.Scroll += new System.EventHandler(this.tbMakeSunny_Scroll);
            // 
            // lblSunny
            // 
            this.lblSunny.AutoSize = true;
            this.lblSunny.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSunny.Location = new System.Drawing.Point(928, 93);
            this.lblSunny.Name = "lblSunny";
            this.lblSunny.Size = new System.Drawing.Size(226, 55);
            this.lblSunny.TabIndex = 2;
            this.lblSunny.Text = "It\'s rainy T_T";
            this.lblSunny.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 531);
            this.Controls.Add(this.lblSunny);
            this.Controls.Add(this.tbMakeSunny);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMakeSunny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbMakeSunny;
        private System.Windows.Forms.Label lblSunny;
    }
}

