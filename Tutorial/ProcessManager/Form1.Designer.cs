namespace ProcessManager
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProcessCurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this.CPUCurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this.MemoryCurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProcessView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProcessCurrent,
            this.CPUCurrent,
            this.MemoryCurrent});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(524, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProcessCurrent
            // 
            this.ProcessCurrent.Name = "ProcessCurrent";
            this.ProcessCurrent.Size = new System.Drawing.Size(152, 20);
            this.ProcessCurrent.Text = "toolStripStatusLabel1";
            // 
            // CPUCurrent
            // 
            this.CPUCurrent.Name = "CPUCurrent";
            this.CPUCurrent.Size = new System.Drawing.Size(90, 20);
            this.CPUCurrent.Text = "CPUCurrent";
            // 
            // MemoryCurrent
            // 
            this.MemoryCurrent.Name = "MemoryCurrent";
            this.MemoryCurrent.Size = new System.Drawing.Size(152, 20);
            this.MemoryCurrent.Text = "toolStripStatusLabel3";
            // 
            // ProcessView1
            // 
            this.ProcessView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ProcessView1.HideSelection = false;
            this.ProcessView1.Location = new System.Drawing.Point(10, 13);
            this.ProcessView1.Name = "ProcessView1";
            this.ProcessView1.Size = new System.Drawing.Size(502, 466);
            this.ProcessView1.TabIndex = 1;
            this.ProcessView1.UseCompatibleStateImageBehavior = false;
            this.ProcessView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PID";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "메모리";
            this.columnHeader4.Width = 151;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "프로세스 종료";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProcessView1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ProcessCurrent;
        private System.Windows.Forms.ToolStripStatusLabel CPUCurrent;
        private System.Windows.Forms.ToolStripStatusLabel MemoryCurrent;
        private System.Windows.Forms.ListView ProcessView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
    }
}

