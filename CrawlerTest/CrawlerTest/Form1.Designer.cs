namespace CrawlerTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnGetTse = new System.Windows.Forms.Button();
            this.btnGetList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(713, 31);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 33);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(695, 20);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "https://www.sahamyab.com/hashtag/%D9%81%D9%88%D9%84%D8%A7%D8%AF";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 60);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(776, 347);
            this.txtResult.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // btnGetTse
            // 
            this.btnGetTse.Location = new System.Drawing.Point(551, 415);
            this.btnGetTse.Name = "btnGetTse";
            this.btnGetTse.Size = new System.Drawing.Size(75, 23);
            this.btnGetTse.TabIndex = 3;
            this.btnGetTse.Text = "tse";
            this.btnGetTse.UseVisualStyleBackColor = true;
            this.btnGetTse.Click += new System.EventHandler(this.btnGetTse_Click);
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(470, 415);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(75, 23);
            this.btnGetList.TabIndex = 4;
            this.btnGetList.Text = "Get List";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetList);
            this.Controls.Add(this.btnGetTse);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnGetTse;
        private System.Windows.Forms.Button btnGetList;
    }
}

