namespace BulidCode
{
    partial class BulidCode
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
            this.tblog = new System.Windows.Forms.TextBox();
            this.txtip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdb = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtnamespace = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbmysql = new System.Windows.Forms.RadioButton();
            this.rbSqlServer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "生成代码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblog
            // 
            this.tblog.Location = new System.Drawing.Point(7, 107);
            this.tblog.MaxLength = 88888;
            this.tblog.Multiline = true;
            this.tblog.Name = "tblog";
            this.tblog.ReadOnly = true;
            this.tblog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tblog.Size = new System.Drawing.Size(680, 412);
            this.tblog.TabIndex = 1;
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(314, 12);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(209, 21);
            this.txtip.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "服务器";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "命名空间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "数据库";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "用户名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "密码";
            // 
            // txtdb
            // 
            this.txtdb.Location = new System.Drawing.Point(54, 47);
            this.txtdb.Name = "txtdb";
            this.txtdb.Size = new System.Drawing.Size(143, 21);
            this.txtdb.TabIndex = 8;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(248, 47);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(139, 21);
            this.txtuser.TabIndex = 9;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(428, 47);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(152, 21);
            this.txtpwd.TabIndex = 10;
            // 
            // txtnamespace
            // 
            this.txtnamespace.Location = new System.Drawing.Point(54, 12);
            this.txtnamespace.Name = "txtnamespace";
            this.txtnamespace.Size = new System.Drawing.Size(198, 21);
            this.txtnamespace.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "生成日志：";
            // 
            // rbmysql
            // 
            this.rbmysql.AutoSize = true;
            this.rbmysql.Location = new System.Drawing.Point(536, 15);
            this.rbmysql.Name = "rbmysql";
            this.rbmysql.Size = new System.Drawing.Size(53, 16);
            this.rbmysql.TabIndex = 13;
            this.rbmysql.Text = "MySql";
            this.rbmysql.UseVisualStyleBackColor = true;
            // 
            // rbSqlServer
            // 
            this.rbSqlServer.AutoSize = true;
            this.rbSqlServer.Checked = true;
            this.rbSqlServer.Location = new System.Drawing.Point(600, 16);
            this.rbSqlServer.Name = "rbSqlServer";
            this.rbSqlServer.Size = new System.Drawing.Size(77, 16);
            this.rbSqlServer.TabIndex = 14;
            this.rbSqlServer.TabStop = true;
            this.rbSqlServer.Text = "SqlServer";
            this.rbSqlServer.UseVisualStyleBackColor = true;
            // 
            // BulidCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 527);
            this.Controls.Add(this.rbSqlServer);
            this.Controls.Add(this.rbmysql);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnamespace);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtdb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.tblog);
            this.Controls.Add(this.button1);
            this.Name = "BulidCode";
            this.Text = "代码生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tblog;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdb;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtnamespace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbmysql;
        private System.Windows.Forms.RadioButton rbSqlServer;
    }
}

