namespace CVE20190604Forms
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
            this.textBoxCmd = new System.Windows.Forms.TextBox();
            this.textBoxXml = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenXmlFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPayload = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEncodeEntity = new System.Windows.Forms.Button();
            this.buttonDecodeEntity = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCmd
            // 
            this.textBoxCmd.Location = new System.Drawing.Point(113, 15);
            this.textBoxCmd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCmd.Multiline = true;
            this.textBoxCmd.Name = "textBoxCmd";
            this.textBoxCmd.Size = new System.Drawing.Size(688, 71);
            this.textBoxCmd.TabIndex = 0;
            this.textBoxCmd.Text = "calc.exe";
            // 
            // textBoxXml
            // 
            this.textBoxXml.Location = new System.Drawing.Point(113, 97);
            this.textBoxXml.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxXml.Multiline = true;
            this.textBoxXml.Name = "textBoxXml";
            this.textBoxXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxXml.Size = new System.Drawing.Size(801, 213);
            this.textBoxXml.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cmd:";
            // 
            // buttonOpenXmlFile
            // 
            this.buttonOpenXmlFile.Location = new System.Drawing.Point(815, 51);
            this.buttonOpenXmlFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenXmlFile.Name = "buttonOpenXmlFile";
            this.buttonOpenXmlFile.Size = new System.Drawing.Size(99, 35);
            this.buttonOpenXmlFile.TabIndex = 3;
            this.buttonOpenXmlFile.Text = "Update XML";
            this.buttonOpenXmlFile.UseVisualStyleBackColor = true;
            this.buttonOpenXmlFile.Click += new System.EventHandler(this.buttonOpenXmlFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Xml:";
            // 
            // textBoxPayload
            // 
            this.textBoxPayload.Location = new System.Drawing.Point(112, 361);
            this.textBoxPayload.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPayload.Multiline = true;
            this.textBoxPayload.Name = "textBoxPayload";
            this.textBoxPayload.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPayload.Size = new System.Drawing.Size(801, 122);
            this.textBoxPayload.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Payload:";
            // 
            // buttonEncodeEntity
            // 
            this.buttonEncodeEntity.Location = new System.Drawing.Point(720, 318);
            this.buttonEncodeEntity.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEncodeEntity.Name = "buttonEncodeEntity";
            this.buttonEncodeEntity.Size = new System.Drawing.Size(194, 35);
            this.buttonEncodeEntity.TabIndex = 7;
            this.buttonEncodeEntity.Text = "EncodeEntity";
            this.buttonEncodeEntity.UseVisualStyleBackColor = true;
            this.buttonEncodeEntity.Click += new System.EventHandler(this.buttonEncodeEntity_Click);
            // 
            // buttonDecodeEntity
            // 
            this.buttonDecodeEntity.Location = new System.Drawing.Point(719, 490);
            this.buttonDecodeEntity.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDecodeEntity.Name = "buttonDecodeEntity";
            this.buttonDecodeEntity.Size = new System.Drawing.Size(194, 35);
            this.buttonDecodeEntity.TabIndex = 8;
            this.buttonDecodeEntity.Text = "DecodeEntity";
            this.buttonDecodeEntity.UseVisualStyleBackColor = true;
            this.buttonDecodeEntity.Click += new System.EventHandler(this.buttonDecodeEntity_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(259, 490);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 35);
            this.button4.TabIndex = 9;
            this.button4.Text = "k8gege\'s payload";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(112, 491);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 35);
            this.button5.TabIndex = 10;
            this.button5.Text = "Calc.exe payload";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(927, 542);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonDecodeEntity);
            this.Controls.Add(this.buttonEncodeEntity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPayload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOpenXmlFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxXml);
            this.Controls.Add(this.textBoxCmd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CVE-2019-0604 Payload Maker  - https://github.com/boxhg/CVE-2019-0604";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCmd;
        private System.Windows.Forms.TextBox textBoxXml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenXmlFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPayload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEncodeEntity;
        private System.Windows.Forms.Button buttonDecodeEntity;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

