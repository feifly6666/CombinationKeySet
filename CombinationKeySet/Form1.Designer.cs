namespace CombinationKeySet
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
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cobKey1 = new System.Windows.Forms.ComboBox();
            this.cobCombinKey = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(15, 106);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 32);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Setup";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.Text = "Key1:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.Text = "Key2:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(98, 106);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(65, 32);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Clear";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cobKey1
            // 
            this.cobKey1.Location = new System.Drawing.Point(63, 16);
            this.cobKey1.Name = "cobKey1";
            this.cobKey1.Size = new System.Drawing.Size(100, 23);
            this.cobKey1.TabIndex = 9;
            // 
            // cobCombinKey
            // 
            this.cobCombinKey.Location = new System.Drawing.Point(63, 58);
            this.cobCombinKey.Name = "cobCombinKey";
            this.cobCombinKey.Size = new System.Drawing.Size(100, 23);
            this.cobCombinKey.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(199, 157);
            this.Controls.Add(this.cobCombinKey);
            this.Controls.Add(this.cobKey1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CombinationKeySet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cobKey1;
        private System.Windows.Forms.ComboBox cobCombinKey;
    }
}

