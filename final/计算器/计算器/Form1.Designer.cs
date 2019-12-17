namespace 计算器
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标准型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科学型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMC = new System.Windows.Forms.Button();
            this.btntg = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btndian = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btncheng = new System.Windows.Forms.Button();
            this.btnchu = new System.Windows.Forms.Button();
            this.btnjian = new System.Windows.Forms.Button();
            this.btnjia = new System.Windows.Forms.Button();
            this.btnzf = new System.Windows.Forms.Button();
            this.btnMjia = new System.Windows.Forms.Button();
            this.btndaoshu = new System.Windows.Forms.Button();
            this.btnbaifenbi = new System.Windows.Forms.Button();
            this.btndengyu = new System.Windows.Forms.Button();
            this.btnsqrt = new System.Windows.Forms.Button();
            this.btnMjian = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(13, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 14);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(248, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.标准型ToolStripMenuItem,
            this.科学型ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.查看ToolStripMenuItem.Text = "查看(&V)";
            // 
            // 标准型ToolStripMenuItem
            // 
            this.标准型ToolStripMenuItem.Name = "标准型ToolStripMenuItem";
            this.标准型ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.标准型ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.标准型ToolStripMenuItem.Text = "标准型 ";
            this.标准型ToolStripMenuItem.Click += new System.EventHandler(this.标准型ToolStripMenuItem_Click);
            // 
            // 科学型ToolStripMenuItem
            // 
            this.科学型ToolStripMenuItem.Name = "科学型ToolStripMenuItem";
            this.科学型ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.科学型ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.科学型ToolStripMenuItem.Text = "科学型";
            this.科学型ToolStripMenuItem.Click += new System.EventHandler(this.科学型ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑ToolStripMenuItem.Text = "编辑(&E)";
            this.编辑ToolStripMenuItem.Click += new System.EventHandler(this.编辑ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.说明ToolStripMenuItem,
            this.关于计算器ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 说明ToolStripMenuItem
            // 
            this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
            this.说明ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.说明ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.说明ToolStripMenuItem.Text = "说明";
            this.说明ToolStripMenuItem.Click += new System.EventHandler(this.说明ToolStripMenuItem_Click);
            // 
            // 关于计算器ToolStripMenuItem
            // 
            this.关于计算器ToolStripMenuItem.Name = "关于计算器ToolStripMenuItem";
            this.关于计算器ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.关于计算器ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.关于计算器ToolStripMenuItem.Text = "关于计算器";
            this.关于计算器ToolStripMenuItem.Click += new System.EventHandler(this.关于计算器ToolStripMenuItem_Click);
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.Color.Transparent;
            this.btnMC.Location = new System.Drawing.Point(13, 74);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(40, 23);
            this.btnMC.TabIndex = 3;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btntg
            // 
            this.btntg.Location = new System.Drawing.Point(13, 112);
            this.btntg.Name = "btntg";
            this.btntg.Size = new System.Drawing.Size(40, 23);
            this.btntg.TabIndex = 5;
            this.btntg.Text = "<--";
            this.btntg.UseVisualStyleBackColor = true;
            this.btntg.Click += new System.EventHandler(this.btntg_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 226);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 23);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(13, 264);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(85, 23);
            this.btn0.TabIndex = 6;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 188);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 23);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 150);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 23);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(59, 187);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 23);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(58, 149);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 23);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(59, 225);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 23);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(59, 111);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(40, 23);
            this.btnCE.TabIndex = 11;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnMR
            // 
            this.btnMR.Location = new System.Drawing.Point(59, 73);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(40, 23);
            this.btnMR.TabIndex = 10;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(105, 188);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 23);
            this.btn6.TabIndex = 21;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(104, 150);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 23);
            this.btn9.TabIndex = 20;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(105, 226);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 23);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btndian
            // 
            this.btndian.Location = new System.Drawing.Point(105, 264);
            this.btndian.Name = "btndian";
            this.btndian.Size = new System.Drawing.Size(40, 23);
            this.btndian.TabIndex = 18;
            this.btndian.Text = ".";
            this.btndian.UseVisualStyleBackColor = true;
            this.btndian.Click += new System.EventHandler(this.btndian_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(105, 112);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(40, 23);
            this.btnC.TabIndex = 17;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnMS
            // 
            this.btnMS.Location = new System.Drawing.Point(105, 74);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(40, 23);
            this.btnMS.TabIndex = 16;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btncheng
            // 
            this.btncheng.Location = new System.Drawing.Point(151, 188);
            this.btncheng.Name = "btncheng";
            this.btncheng.Size = new System.Drawing.Size(40, 23);
            this.btncheng.TabIndex = 27;
            this.btncheng.Text = "*";
            this.btncheng.UseVisualStyleBackColor = true;
            this.btncheng.Click += new System.EventHandler(this.btncheng_Click);
            // 
            // btnchu
            // 
            this.btnchu.Location = new System.Drawing.Point(150, 150);
            this.btnchu.Name = "btnchu";
            this.btnchu.Size = new System.Drawing.Size(40, 23);
            this.btnchu.TabIndex = 26;
            this.btnchu.Text = "/";
            this.btnchu.UseVisualStyleBackColor = true;
            this.btnchu.Click += new System.EventHandler(this.btnchu_Click);
            // 
            // btnjian
            // 
            this.btnjian.Location = new System.Drawing.Point(151, 226);
            this.btnjian.Name = "btnjian";
            this.btnjian.Size = new System.Drawing.Size(40, 23);
            this.btnjian.TabIndex = 25;
            this.btnjian.Text = "-";
            this.btnjian.UseVisualStyleBackColor = true;
            this.btnjian.Click += new System.EventHandler(this.btnjian_Click);
            // 
            // btnjia
            // 
            this.btnjia.Location = new System.Drawing.Point(151, 264);
            this.btnjia.Name = "btnjia";
            this.btnjia.Size = new System.Drawing.Size(40, 23);
            this.btnjia.TabIndex = 24;
            this.btnjia.Text = "+";
            this.btnjia.UseVisualStyleBackColor = true;
            this.btnjia.Click += new System.EventHandler(this.btnjia_Click);
            // 
            // btnzf
            // 
            this.btnzf.Location = new System.Drawing.Point(151, 112);
            this.btnzf.Name = "btnzf";
            this.btnzf.Size = new System.Drawing.Size(40, 23);
            this.btnzf.TabIndex = 23;
            this.btnzf.Text = "+/-";
            this.btnzf.UseVisualStyleBackColor = true;
            this.btnzf.Click += new System.EventHandler(this.btnzf_Click);
            // 
            // btnMjia
            // 
            this.btnMjia.Location = new System.Drawing.Point(151, 74);
            this.btnMjia.Name = "btnMjia";
            this.btnMjia.Size = new System.Drawing.Size(40, 23);
            this.btnMjia.TabIndex = 22;
            this.btnMjia.Text = "M+";
            this.btnMjia.UseVisualStyleBackColor = true;
            this.btnMjia.Click += new System.EventHandler(this.btnMjia_Click);
            // 
            // btndaoshu
            // 
            this.btndaoshu.Location = new System.Drawing.Point(197, 188);
            this.btndaoshu.Name = "btndaoshu";
            this.btndaoshu.Size = new System.Drawing.Size(40, 23);
            this.btndaoshu.TabIndex = 33;
            this.btndaoshu.Text = "1/x";
            this.btndaoshu.UseVisualStyleBackColor = true;
            this.btndaoshu.Click += new System.EventHandler(this.btndaoshu_Click);
            // 
            // btnbaifenbi
            // 
            this.btnbaifenbi.Location = new System.Drawing.Point(196, 150);
            this.btnbaifenbi.Name = "btnbaifenbi";
            this.btnbaifenbi.Size = new System.Drawing.Size(40, 23);
            this.btnbaifenbi.TabIndex = 32;
            this.btnbaifenbi.Text = "%";
            this.btnbaifenbi.UseVisualStyleBackColor = true;
            this.btnbaifenbi.Click += new System.EventHandler(this.btnbaifenbi_Click);
            // 
            // btndengyu
            // 
            this.btndengyu.Location = new System.Drawing.Point(197, 226);
            this.btndengyu.Name = "btndengyu";
            this.btndengyu.Size = new System.Drawing.Size(40, 61);
            this.btndengyu.TabIndex = 30;
            this.btndengyu.Text = "=";
            this.btndengyu.UseVisualStyleBackColor = true;
            this.btndengyu.Click += new System.EventHandler(this.btndengyu_Click);
            // 
            // btnsqrt
            // 
            this.btnsqrt.Location = new System.Drawing.Point(197, 112);
            this.btnsqrt.Name = "btnsqrt";
            this.btnsqrt.Size = new System.Drawing.Size(40, 23);
            this.btnsqrt.TabIndex = 29;
            this.btnsqrt.Text = "sqrt";
            this.btnsqrt.UseVisualStyleBackColor = true;
            this.btnsqrt.Click += new System.EventHandler(this.btnsqrt_Click);
            // 
            // btnMjian
            // 
            this.btnMjian.Location = new System.Drawing.Point(197, 74);
            this.btnMjian.Name = "btnMjian";
            this.btnMjian.Size = new System.Drawing.Size(40, 23);
            this.btnMjian.TabIndex = 28;
            this.btnMjian.Text = "M-";
            this.btnMjian.UseVisualStyleBackColor = true;
            this.btnMjian.Click += new System.EventHandler(this.btnMjian_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 12);
            this.label1.TabIndex = 34;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 35;
            // 
            // Form1
            // 
            this.AcceptButton = this.btndengyu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndaoshu);
            this.Controls.Add(this.btnbaifenbi);
            this.Controls.Add(this.btndengyu);
            this.Controls.Add(this.btnsqrt);
            this.Controls.Add(this.btnMjian);
            this.Controls.Add(this.btncheng);
            this.Controls.Add(this.btnchu);
            this.Controls.Add(this.btnjian);
            this.Controls.Add(this.btnjia);
            this.Controls.Add(this.btnzf);
            this.Controls.Add(this.btnMjia);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btndian);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btntg);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "计算器";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btntg;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btndian;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btncheng;
        private System.Windows.Forms.Button btnchu;
        private System.Windows.Forms.Button btnjian;
        private System.Windows.Forms.Button btnjia;
        private System.Windows.Forms.Button btnzf;
        private System.Windows.Forms.Button btnMjia;
        private System.Windows.Forms.Button btndaoshu;
        private System.Windows.Forms.Button btnbaifenbi;
        private System.Windows.Forms.Button btndengyu;
        private System.Windows.Forms.Button btnsqrt;
        private System.Windows.Forms.Button btnMjian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 标准型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 科学型ToolStripMenuItem;
    }
}

