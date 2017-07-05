namespace Barber_sleep_problem
{
    partial class Barber_sleep_problem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barber_sleep_problem));
            this.waithome = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.warning = new System.Windows.Forms.PictureBox();
            this.chair_haircut = new System.Windows.Forms.PictureBox();
            this.chair2 = new System.Windows.Forms.PictureBox();
            this.chair3 = new System.Windows.Forms.PictureBox();
            this.chair1 = new System.Windows.Forms.PictureBox();
            this.waithome.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chair_haircut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chair2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chair3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chair1)).BeginInit();
            this.SuspendLayout();
            // 
            // waithome
            // 
            this.waithome.Controls.Add(this.chair2);
            this.waithome.Controls.Add(this.chair3);
            this.waithome.Controls.Add(this.chair1);
            this.waithome.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.waithome.Location = new System.Drawing.Point(241, 29);
            this.waithome.Name = "waithome";
            this.waithome.Size = new System.Drawing.Size(560, 411);
            this.waithome.TabIndex = 0;
            this.waithome.TabStop = false;
            this.waithome.Text = "WaitingRoom";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chair_haircut);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(31, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 411);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HairCutRoom";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(313, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add a customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // warning
            // 
            this.warning.BackColor = System.Drawing.Color.Transparent;
            this.warning.Location = new System.Drawing.Point(271, 442);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(290, 20);
            this.warning.TabIndex = 4;
            this.warning.TabStop = false;
            // 
            // chair_haircut
            // 
            this.chair_haircut.Location = new System.Drawing.Point(20, 50);
            this.chair_haircut.Name = "chair_haircut";
            this.chair_haircut.Size = new System.Drawing.Size(160, 320);
            this.chair_haircut.TabIndex = 0;
            this.chair_haircut.TabStop = false;
            // 
            // chair2
            // 
            this.chair2.BackgroundImage = global::Barber_sleep_problem.Resource1.chair;
            this.chair2.Location = new System.Drawing.Point(202, 50);
            this.chair2.Name = "chair2";
            this.chair2.Size = new System.Drawing.Size(160, 320);
            this.chair2.TabIndex = 2;
            this.chair2.TabStop = false;
            // 
            // chair3
            // 
            this.chair3.BackgroundImage = global::Barber_sleep_problem.Resource1.chair;
            this.chair3.Location = new System.Drawing.Point(380, 50);
            this.chair3.Name = "chair3";
            this.chair3.Size = new System.Drawing.Size(160, 320);
            this.chair3.TabIndex = 1;
            this.chair3.TabStop = false;
            // 
            // chair1
            // 
            this.chair1.BackgroundImage = global::Barber_sleep_problem.Resource1.chair;
            this.chair1.Location = new System.Drawing.Point(20, 50);
            this.chair1.Name = "chair1";
            this.chair1.Size = new System.Drawing.Size(160, 320);
            this.chair1.TabIndex = 0;
            this.chair1.TabStop = false;
            // 
            // Barber_sleep_problem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(832, 524);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.waithome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Barber_sleep_problem";
            this.Text = "Barber sleep problem by CS1504 WangXuSheng";
            this.Load += new System.EventHandler(this.Barber_sleep_problem_Load);
            this.waithome.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chair_haircut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chair2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chair3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chair1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox waithome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox chair2;
        private System.Windows.Forms.PictureBox chair3;
        private System.Windows.Forms.PictureBox chair1;
        private System.Windows.Forms.PictureBox chair_haircut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox warning;
    }
}

