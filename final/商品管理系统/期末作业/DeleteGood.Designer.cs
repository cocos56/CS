namespace 期末作业
{
    partial class DeleteGood
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_theNameWay = new System.Windows.Forms.GroupBox();
            this.textBox_DeleteName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_WaysToDelete = new System.Windows.Forms.ComboBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox_theCodeWay = new System.Windows.Forms.GroupBox();
            this.textBox_DeleteCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_theNameWay.SuspendLayout();
            this.groupBox_theCodeWay.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择删除商品的方式";
            // 
            // groupBox_theNameWay
            // 
            this.groupBox_theNameWay.Controls.Add(this.textBox_DeleteName);
            this.groupBox_theNameWay.Controls.Add(this.label2);
            this.groupBox_theNameWay.Location = new System.Drawing.Point(78, 100);
            this.groupBox_theNameWay.Name = "groupBox_theNameWay";
            this.groupBox_theNameWay.Size = new System.Drawing.Size(234, 108);
            this.groupBox_theNameWay.TabIndex = 1;
            this.groupBox_theNameWay.TabStop = false;
            this.groupBox_theNameWay.Text = "groupBox_theNameWay";
            this.groupBox_theNameWay.Visible = false;
            // 
            // textBox_DeleteName
            // 
            this.textBox_DeleteName.Location = new System.Drawing.Point(112, 48);
            this.textBox_DeleteName.Name = "textBox_DeleteName";
            this.textBox_DeleteName.Size = new System.Drawing.Size(100, 21);
            this.textBox_DeleteName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "输入商品名称";
            // 
            // comboBox_WaysToDelete
            // 
            this.comboBox_WaysToDelete.FormattingEnabled = true;
            this.comboBox_WaysToDelete.Items.AddRange(new object[] {
            "通过查询商品名字删除",
            "通过查询商品条码删除"});
            this.comboBox_WaysToDelete.Location = new System.Drawing.Point(213, 39);
            this.comboBox_WaysToDelete.Name = "comboBox_WaysToDelete";
            this.comboBox_WaysToDelete.Size = new System.Drawing.Size(121, 20);
            this.comboBox_WaysToDelete.TabIndex = 2;
            this.comboBox_WaysToDelete.SelectedIndexChanged += new System.EventHandler(this.comboBox_WaysToDelete_SelectedIndexChanged);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(145, 240);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "删除";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // groupBox_theCodeWay
            // 
            this.groupBox_theCodeWay.Controls.Add(this.textBox_DeleteCode);
            this.groupBox_theCodeWay.Controls.Add(this.label3);
            this.groupBox_theCodeWay.Location = new System.Drawing.Point(78, 100);
            this.groupBox_theCodeWay.Name = "groupBox_theCodeWay";
            this.groupBox_theCodeWay.Size = new System.Drawing.Size(234, 108);
            this.groupBox_theCodeWay.TabIndex = 4;
            this.groupBox_theCodeWay.TabStop = false;
            this.groupBox_theCodeWay.Text = "groupBox_theCodeWay";
            this.groupBox_theCodeWay.Visible = false;
            // 
            // textBox_DeleteCode
            // 
            this.textBox_DeleteCode.Location = new System.Drawing.Point(112, 41);
            this.textBox_DeleteCode.Name = "textBox_DeleteCode";
            this.textBox_DeleteCode.Size = new System.Drawing.Size(116, 21);
            this.textBox_DeleteCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "输入商品条码";
            // 
            // DeleteGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 297);
            this.Controls.Add(this.groupBox_theCodeWay);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.comboBox_WaysToDelete);
            this.Controls.Add(this.groupBox_theNameWay);
            this.Controls.Add(this.label1);
            this.Name = "DeleteGood";
            this.Text = "删除商品";
            this.groupBox_theNameWay.ResumeLayout(false);
            this.groupBox_theNameWay.PerformLayout();
            this.groupBox_theCodeWay.ResumeLayout(false);
            this.groupBox_theCodeWay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_theNameWay;
        private System.Windows.Forms.ComboBox comboBox_WaysToDelete;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.TextBox textBox_DeleteName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_theCodeWay;
        private System.Windows.Forms.TextBox textBox_DeleteCode;
        private System.Windows.Forms.Label label3;
    }
}