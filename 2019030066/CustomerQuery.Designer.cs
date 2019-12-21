namespace _2019030066
{
    partial class CustomerQuery
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btNew = new System.Windows.Forms.Button();
            this.btAll = new System.Windows.Forms.Button();
            this.btQuery = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textRoomID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btNew);
            this.groupBox1.Controls.Add(this.btAll);
            this.groupBox1.Controls.Add(this.btQuery);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textCustomerID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textRoomID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(335, 64);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(105, 29);
            this.btNew.TabIndex = 8;
            this.btNew.Text = "重置";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btAll
            // 
            this.btAll.Location = new System.Drawing.Point(180, 64);
            this.btAll.Name = "btAll";
            this.btAll.Size = new System.Drawing.Size(105, 29);
            this.btAll.TabIndex = 7;
            this.btAll.Text = "全部";
            this.btAll.UseVisualStyleBackColor = true;
            this.btAll.Click += new System.EventHandler(this.btAll_Click);
            // 
            // btQuery
            // 
            this.btQuery.Location = new System.Drawing.Point(22, 63);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(105, 29);
            this.btQuery.TabIndex = 6;
            this.btQuery.Text = "查询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(375, 26);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(78, 25);
            this.textName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓名";
            // 
            // textCustomerID
            // 
            this.textCustomerID.Location = new System.Drawing.Point(244, 26);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.Size = new System.Drawing.Size(82, 25);
            this.textCustomerID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "客户编号";
            // 
            // textRoomID
            // 
            this.textRoomID.Location = new System.Drawing.Point(89, 26);
            this.textRoomID.Name = "textRoomID";
            this.textRoomID.Size = new System.Drawing.Size(76, 25);
            this.textRoomID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "房屋编号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(466, 190);
            this.dataGridView1.TabIndex = 1;
            // 
            // CustomerQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 375);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerQuery";
            this.Text = "客户查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btAll;
        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRoomID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}