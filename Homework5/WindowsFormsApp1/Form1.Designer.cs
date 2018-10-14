namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Green = new System.Windows.Forms.RadioButton();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.Red = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Thickness = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Angel1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Angel2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OffRandom = new System.Windows.Forms.RadioButton();
            this.RandomCheck = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Length1 = new System.Windows.Forms.NumericUpDown();
            this.Length2 = new System.Windows.Forms.NumericUpDown();
            this.Factor = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angel2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Length1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Factor)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(882, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Green);
            this.groupBox1.Controls.Add(this.Blue);
            this.groupBox1.Controls.Add(this.Red);
            this.groupBox1.Location = new System.Drawing.Point(745, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "颜色";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(31, 129);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(58, 19);
            this.Green.TabIndex = 2;
            this.Green.TabStop = true;
            this.Green.Text = "绿色\r\n";
            this.Green.UseVisualStyleBackColor = true;
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Checked = true;
            this.Blue.Location = new System.Drawing.Point(31, 83);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(58, 19);
            this.Blue.TabIndex = 1;
            this.Blue.TabStop = true;
            this.Blue.Text = "蓝色\r\n";
            this.Blue.UseVisualStyleBackColor = true;
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(31, 44);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(58, 19);
            this.Red.TabIndex = 0;
            this.Red.TabStop = true;
            this.Red.Text = "红色\r\n";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "粗细\r\n";
            // 
            // Thickness
            // 
            this.Thickness.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Thickness.Location = new System.Drawing.Point(825, 327);
            this.Thickness.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Thickness.Name = "Thickness";
            this.Thickness.ReadOnly = true;
            this.Thickness.Size = new System.Drawing.Size(120, 25);
            this.Thickness.TabIndex = 3;
            this.Thickness.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "分支1角度";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Angel1
            // 
            this.Angel1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Angel1.Location = new System.Drawing.Point(825, 372);
            this.Angel1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Angel1.Name = "Angel1";
            this.Angel1.ReadOnly = true;
            this.Angel1.Size = new System.Drawing.Size(120, 25);
            this.Angel1.TabIndex = 5;
            this.Angel1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Angel1.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "分支2角度";
            // 
            // Angel2
            // 
            this.Angel2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Angel2.Location = new System.Drawing.Point(825, 418);
            this.Angel2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Angel2.Name = "Angel2";
            this.Angel2.ReadOnly = true;
            this.Angel2.Size = new System.Drawing.Size(120, 25);
            this.Angel2.TabIndex = 7;
            this.Angel2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Angel2.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OffRandom);
            this.groupBox2.Controls.Add(this.RandomCheck);
            this.groupBox2.Location = new System.Drawing.Point(990, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 208);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // OffRandom
            // 
            this.OffRandom.AutoSize = true;
            this.OffRandom.Checked = true;
            this.OffRandom.Location = new System.Drawing.Point(6, 110);
            this.OffRandom.Name = "OffRandom";
            this.OffRandom.Size = new System.Drawing.Size(73, 19);
            this.OffRandom.TabIndex = 1;
            this.OffRandom.TabStop = true;
            this.OffRandom.Text = "不随机";
            this.OffRandom.UseVisualStyleBackColor = true;
            this.OffRandom.CheckedChanged += new System.EventHandler(this.OffRandom_CheckedChanged);
            // 
            // RandomCheck
            // 
            this.RandomCheck.AutoSize = true;
            this.RandomCheck.Location = new System.Drawing.Point(6, 48);
            this.RandomCheck.Name = "RandomCheck";
            this.RandomCheck.Size = new System.Drawing.Size(88, 19);
            this.RandomCheck.TabIndex = 0;
            this.RandomCheck.TabStop = true;
            this.RandomCheck.Text = "随机生成\r\n";
            this.RandomCheck.UseVisualStyleBackColor = true;
            this.RandomCheck.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(990, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "分支1长度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(990, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "分支2长度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(987, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "分支位置系数";
            // 
            // Length1
            // 
            this.Length1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Length1.Location = new System.Drawing.Point(1083, 326);
            this.Length1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Length1.Name = "Length1";
            this.Length1.ReadOnly = true;
            this.Length1.Size = new System.Drawing.Size(120, 25);
            this.Length1.TabIndex = 12;
            this.Length1.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // Length2
            // 
            this.Length2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Length2.Location = new System.Drawing.Point(1083, 374);
            this.Length2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Length2.Name = "Length2";
            this.Length2.ReadOnly = true;
            this.Length2.Size = new System.Drawing.Size(120, 25);
            this.Length2.TabIndex = 13;
            this.Length2.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // Factor
            // 
            this.Factor.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Factor.Location = new System.Drawing.Point(1083, 418);
            this.Factor.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Factor.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Factor.Name = "Factor";
            this.Factor.ReadOnly = true;
            this.Factor.Size = new System.Drawing.Size(120, 25);
            this.Factor.TabIndex = 14;
            this.Factor.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 548);
            this.Controls.Add(this.Factor);
            this.Controls.Add(this.Length2);
            this.Controls.Add(this.Length1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Angel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Angel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Thickness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angel2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Length1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Factor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Thickness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Angel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Angel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton OffRandom;
        private System.Windows.Forms.RadioButton RandomCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Length1;
        private System.Windows.Forms.NumericUpDown Length2;
        private System.Windows.Forms.NumericUpDown Factor;
    }
}

