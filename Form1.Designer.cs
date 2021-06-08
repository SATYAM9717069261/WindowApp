
namespace SampleApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dbtext = new System.Windows.Forms.TextBox();
            this.urltxt = new System.Windows.Forms.TextBox();
            this.dbbtn = new System.Windows.Forms.Button();
            this.urlchkbtn = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dbtext
            // 
            this.dbtext.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dbtext.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.dbtext.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dbtext.Location = new System.Drawing.Point(55, 41);
            this.dbtext.Name = "dbtext";
            this.dbtext.PlaceholderText = "Connect to Database";
            this.dbtext.Size = new System.Drawing.Size(404, 27);
            this.dbtext.TabIndex = 0;
            // 
            // urltxt
            // 
            this.urltxt.Location = new System.Drawing.Point(55, 293);
            this.urltxt.Name = "urltxt";
            this.urltxt.PlaceholderText = "Check Your URL";
            this.urltxt.Size = new System.Drawing.Size(404, 27);
            this.urltxt.TabIndex = 1;
            // 
            // dbbtn
            // 
            this.dbbtn.Location = new System.Drawing.Point(465, 38);
            this.dbbtn.Name = "dbbtn";
            this.dbbtn.Size = new System.Drawing.Size(107, 30);
            this.dbbtn.TabIndex = 2;
            this.dbbtn.Text = "Connect";
            this.dbbtn.UseVisualStyleBackColor = true;
            this.dbbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // urlchkbtn
            // 
            this.urlchkbtn.Location = new System.Drawing.Point(466, 293);
            this.urlchkbtn.Name = "urlchkbtn";
            this.urlchkbtn.Size = new System.Drawing.Size(93, 27);
            this.urlchkbtn.TabIndex = 3;
            this.urlchkbtn.Text = "Check";
            this.urlchkbtn.UseVisualStyleBackColor = true;
            this.urlchkbtn.Click += new System.EventHandler(this.urlchkbtn_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(55, 433);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(52, 20);
            this.status.TabIndex = 4;
            this.status.Text = "Status:";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.status);
            this.Controls.Add(this.urlchkbtn);
            this.Controls.Add(this.dbbtn);
            this.Controls.Add(this.urltxt);
            this.Controls.Add(this.dbtext);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Url Check";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dbtext;
        private System.Windows.Forms.TextBox urltxt;
        private System.Windows.Forms.Button dbbtn;
        private System.Windows.Forms.Button urlchkbtn;
        private System.Windows.Forms.Label status;
    }
}

