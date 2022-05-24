
namespace WindowsFormsApp1
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
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.button1 = new System.Windows.Forms.Button();
            this.Sendmsg = new System.Windows.Forms.Button();
            this.txtSendmsg = new System.Windows.Forms.TextBox();
            this.lblRecivmsg = new System.Windows.Forms.Label();
            this.btnShowChild = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(13, 114);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1437, 687);
            this.webView.Source = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            this.webView.WebMessageReceived += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs>(this.webView_WebMessageReceived);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sendmsg
            // 
            this.Sendmsg.Location = new System.Drawing.Point(589, 57);
            this.Sendmsg.Name = "Sendmsg";
            this.Sendmsg.Size = new System.Drawing.Size(121, 33);
            this.Sendmsg.TabIndex = 2;
            this.Sendmsg.Text = "Send Msg";
            this.Sendmsg.UseVisualStyleBackColor = true;
            this.Sendmsg.Click += new System.EventHandler(this.Sendmsg_Click);
            // 
            // txtSendmsg
            // 
            this.txtSendmsg.Location = new System.Drawing.Point(334, 62);
            this.txtSendmsg.Name = "txtSendmsg";
            this.txtSendmsg.Size = new System.Drawing.Size(179, 22);
            this.txtSendmsg.TabIndex = 3;
            // 
            // lblRecivmsg
            // 
            this.lblRecivmsg.AutoSize = true;
            this.lblRecivmsg.Location = new System.Drawing.Point(874, 62);
            this.lblRecivmsg.Name = "lblRecivmsg";
            this.lblRecivmsg.Size = new System.Drawing.Size(44, 16);
            this.lblRecivmsg.TabIndex = 4;
            this.lblRecivmsg.Text = "label1";
            // 
            // btnShowChild
            // 
            this.btnShowChild.Location = new System.Drawing.Point(1087, 51);
            this.btnShowChild.Name = "btnShowChild";
            this.btnShowChild.Size = new System.Drawing.Size(127, 38);
            this.btnShowChild.TabIndex = 5;
            this.btnShowChild.Text = "ShowChild";
            this.btnShowChild.UseVisualStyleBackColor = true;
            this.btnShowChild.Click += new System.EventHandler(this.btnShowChild_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 843);
            this.Controls.Add(this.btnShowChild);
            this.Controls.Add(this.lblRecivmsg);
            this.Controls.Add(this.txtSendmsg);
            this.Controls.Add(this.Sendmsg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Sendmsg;
        private System.Windows.Forms.TextBox txtSendmsg;
        private System.Windows.Forms.Label lblRecivmsg;
        private System.Windows.Forms.Button btnShowChild;
    }
}

