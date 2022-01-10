
namespace CopyFile
{
    partial class mainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.txt_Origin = new System.Windows.Forms.TextBox();
            this.txt_Purpose = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AllCopy = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Opt1 = new System.Windows.Forms.Button();
            this.btn_Opt2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Origin
            // 
            this.txt_Origin.Font = new System.Drawing.Font("新細明體", 12F);
            this.txt_Origin.Location = new System.Drawing.Point(12, 42);
            this.txt_Origin.Name = "txt_Origin";
            this.txt_Origin.Size = new System.Drawing.Size(210, 27);
            this.txt_Origin.TabIndex = 0;
            this.txt_Origin.TextChanged += new System.EventHandler(this.txt_Origin_TextChanged);
            // 
            // txt_Purpose
            // 
            this.txt_Purpose.Font = new System.Drawing.Font("新細明體", 12F);
            this.txt_Purpose.Location = new System.Drawing.Point(14, 120);
            this.txt_Purpose.Name = "txt_Purpose";
            this.txt_Purpose.Size = new System.Drawing.Size(208, 27);
            this.txt_Purpose.TabIndex = 1;
            this.txt_Purpose.TextChanged += new System.EventHandler(this.txt_Purpose_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "來源路徑";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "目標路徑";
            // 
            // btn_AllCopy
            // 
            this.btn_AllCopy.Location = new System.Drawing.Point(12, 173);
            this.btn_AllCopy.Name = "btn_AllCopy";
            this.btn_AllCopy.Size = new System.Drawing.Size(83, 46);
            this.btn_AllCopy.TabIndex = 4;
            this.btn_AllCopy.Text = "全部覆蓋";
            this.btn_AllCopy.UseVisualStyleBackColor = true;
            this.btn_AllCopy.Click += new System.EventHandler(this.btn_AllCopy_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(101, 173);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(83, 46);
            this.btn_Copy.TabIndex = 5;
            this.btn_Copy.Text = "部分覆蓋";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(190, 173);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(83, 46);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "離開";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Opt1
            // 
            this.btn_Opt1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Opt1.Location = new System.Drawing.Point(228, 40);
            this.btn_Opt1.Name = "btn_Opt1";
            this.btn_Opt1.Size = new System.Drawing.Size(44, 32);
            this.btn_Opt1.TabIndex = 7;
            this.btn_Opt1.Text = "···";
            this.btn_Opt1.UseVisualStyleBackColor = true;
            this.btn_Opt1.Click += new System.EventHandler(this.btn_Opt1_Click);
            // 
            // btn_Opt2
            // 
            this.btn_Opt2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Opt2.Location = new System.Drawing.Point(228, 118);
            this.btn_Opt2.Name = "btn_Opt2";
            this.btn_Opt2.Size = new System.Drawing.Size(44, 32);
            this.btn_Opt2.TabIndex = 8;
            this.btn_Opt2.Text = "···";
            this.btn_Opt2.UseVisualStyleBackColor = true;
            this.btn_Opt2.Click += new System.EventHandler(this.btn_Opt2_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 234);
            this.Controls.Add(this.btn_Opt2);
            this.Controls.Add(this.btn_Opt1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.btn_AllCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Purpose);
            this.Controls.Add(this.txt_Origin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "覆蓋工具";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Origin;
        private System.Windows.Forms.TextBox txt_Purpose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AllCopy;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Opt1;
        private System.Windows.Forms.Button btn_Opt2;
    }
}

