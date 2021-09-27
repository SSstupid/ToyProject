namespace CustomerList
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
            this.NewcusCreate = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CusNewLastName = new System.Windows.Forms.TextBox();
            this.CusNewFirstName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CusNewBirthday = new System.Windows.Forms.TextBox();
            this.CusNewAddress = new System.Windows.Forms.TextBox();
            this.CusNewDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CusDetail = new System.Windows.Forms.Panel();
            this.CusDecription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CusAge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CusFullName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CusView = new System.Windows.Forms.Panel();
            this.CusList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewcusCreate.SuspendLayout();
            this.CusDetail.SuspendLayout();
            this.CusView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CusList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewcusCreate
            // 
            this.NewcusCreate.Controls.Add(this.label1);
            this.NewcusCreate.Controls.Add(this.CusNewLastName);
            this.NewcusCreate.Controls.Add(this.CusNewFirstName);
            this.NewcusCreate.Controls.Add(this.button1);
            this.NewcusCreate.Controls.Add(this.CusNewBirthday);
            this.NewcusCreate.Controls.Add(this.CusNewAddress);
            this.NewcusCreate.Controls.Add(this.CusNewDescription);
            this.NewcusCreate.Controls.Add(this.label5);
            this.NewcusCreate.Controls.Add(this.label4);
            this.NewcusCreate.Controls.Add(this.label3);
            this.NewcusCreate.Controls.Add(this.label2);
            this.NewcusCreate.Location = new System.Drawing.Point(438, 34);
            this.NewcusCreate.Name = "NewcusCreate";
            this.NewcusCreate.Size = new System.Drawing.Size(361, 454);
            this.NewcusCreate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "성 :";
            // 
            // CusNewLastName
            // 
            this.CusNewLastName.Location = new System.Drawing.Point(71, 32);
            this.CusNewLastName.Name = "CusNewLastName";
            this.CusNewLastName.Size = new System.Drawing.Size(133, 22);
            this.CusNewLastName.TabIndex = 6;
            // 
            // CusNewFirstName
            // 
            this.CusNewFirstName.Location = new System.Drawing.Point(71, 58);
            this.CusNewFirstName.Name = "CusNewFirstName";
            this.CusNewFirstName.Size = new System.Drawing.Size(133, 22);
            this.CusNewFirstName.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // CusNewBirthday
            // 
            this.CusNewBirthday.Location = new System.Drawing.Point(71, 84);
            this.CusNewBirthday.Name = "CusNewBirthday";
            this.CusNewBirthday.Size = new System.Drawing.Size(133, 22);
            this.CusNewBirthday.TabIndex = 7;
            // 
            // CusNewAddress
            // 
            this.CusNewAddress.Location = new System.Drawing.Point(71, 108);
            this.CusNewAddress.Name = "CusNewAddress";
            this.CusNewAddress.Size = new System.Drawing.Size(208, 22);
            this.CusNewAddress.TabIndex = 7;
            // 
            // CusNewDescription
            // 
            this.CusNewDescription.Location = new System.Drawing.Point(71, 137);
            this.CusNewDescription.Multiline = true;
            this.CusNewDescription.Name = "CusNewDescription";
            this.CusNewDescription.Size = new System.Drawing.Size(282, 271);
            this.CusNewDescription.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "설명 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "주소 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "생일 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "이름 :";
            // 
            // CusDetail
            // 
            this.CusDetail.Controls.Add(this.CusDecription);
            this.CusDetail.Controls.Add(this.label6);
            this.CusDetail.Controls.Add(this.CusAddress);
            this.CusDetail.Controls.Add(this.label7);
            this.CusDetail.Controls.Add(this.CusAge);
            this.CusDetail.Controls.Add(this.label9);
            this.CusDetail.Controls.Add(this.CusFullName);
            this.CusDetail.Controls.Add(this.label8);
            this.CusDetail.Location = new System.Drawing.Point(431, 108);
            this.CusDetail.Name = "CusDetail";
            this.CusDetail.Size = new System.Drawing.Size(365, 464);
            this.CusDetail.TabIndex = 4;
            // 
            // CusDecription
            // 
            this.CusDecription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CusDecription.Enabled = false;
            this.CusDecription.Location = new System.Drawing.Point(76, 103);
            this.CusDecription.Name = "CusDecription";
            this.CusDecription.Size = new System.Drawing.Size(208, 15);
            this.CusDecription.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "설명 :";
            // 
            // CusAddress
            // 
            this.CusAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CusAddress.Enabled = false;
            this.CusAddress.Location = new System.Drawing.Point(76, 79);
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(133, 15);
            this.CusAddress.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "주소 :";
            // 
            // CusAge
            // 
            this.CusAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CusAge.Enabled = false;
            this.CusAge.Location = new System.Drawing.Point(76, 53);
            this.CusAge.Name = "CusAge";
            this.CusAge.Size = new System.Drawing.Size(133, 15);
            this.CusAge.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "이름 :";
            // 
            // CusFullName
            // 
            this.CusFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CusFullName.Enabled = false;
            this.CusFullName.HideSelection = false;
            this.CusFullName.Location = new System.Drawing.Point(76, 27);
            this.CusFullName.Name = "CusFullName";
            this.CusFullName.Size = new System.Drawing.Size(133, 15);
            this.CusFullName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "생일 : ";
            // 
            // CusView
            // 
            this.CusView.Controls.Add(this.CusList);
            this.CusView.Location = new System.Drawing.Point(3, 34);
            this.CusView.Name = "CusView";
            this.CusView.Size = new System.Drawing.Size(429, 454);
            this.CusView.TabIndex = 5;
            // 
            // CusList
            // 
            this.CusList.AllowUserToAddRows = false;
            this.CusList.AllowUserToDeleteRows = false;
            this.CusList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CusList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.CusList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CusList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CusList.Location = new System.Drawing.Point(0, 0);
            this.CusList.MultiSelect = false;
            this.CusList.Name = "CusList";
            this.CusList.ReadOnly = true;
            this.CusList.RowHeadersWidth = 51;
            this.CusList.RowTemplate.Height = 24;
            this.CusList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CusList.Size = new System.Drawing.Size(429, 454);
            this.CusList.TabIndex = 0;
            this.CusList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CusList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "이름";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "나이";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "주소";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem1.Text = "신규회원";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.NewCusCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 491);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.CusDetail);
            this.Controls.Add(this.NewcusCreate);
            this.Controls.Add(this.CusView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DesignSet);
            this.NewcusCreate.ResumeLayout(false);
            this.NewcusCreate.PerformLayout();
            this.CusDetail.ResumeLayout(false);
            this.CusDetail.PerformLayout();
            this.CusView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CusList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NewcusCreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CusNewBirthday;
        private System.Windows.Forms.TextBox CusNewFirstName;
        private System.Windows.Forms.TextBox CusNewLastName;
        private System.Windows.Forms.TextBox CusNewDescription;
        private System.Windows.Forms.TextBox CusNewAddress;
        private System.Windows.Forms.Panel CusDetail;
        private System.Windows.Forms.TextBox CusDecription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CusAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CusAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CusFullName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel CusView;
        private System.Windows.Forms.DataGridView CusList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

