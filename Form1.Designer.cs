namespace Interface_Button_Test
{
    partial class MainForm
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
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.textSentence = new System.Windows.Forms.TextBox();
            this.textCopy = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.checkBoxExit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(64, 295);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "&Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(64, 344);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(75, 23);
            this.buttonFinish.TabIndex = 1;
            this.buttonFinish.Text = "&Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // textSentence
            // 
            this.textSentence.Location = new System.Drawing.Point(355, 78);
            this.textSentence.Name = "textSentence";
            this.textSentence.Size = new System.Drawing.Size(182, 20);
            this.textSentence.TabIndex = 2;
            // 
            // textCopy
            // 
            this.textCopy.Location = new System.Drawing.Point(355, 123);
            this.textCopy.Name = "textCopy";
            this.textCopy.ReadOnly = true;
            this.textCopy.Size = new System.Drawing.Size(182, 20);
            this.textCopy.TabIndex = 3;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(403, 178);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 4;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // checkBoxExit
            // 
            this.checkBoxExit.AutoSize = true;
            this.checkBoxExit.Location = new System.Drawing.Point(373, 295);
            this.checkBoxExit.Name = "checkBoxExit";
            this.checkBoxExit.Size = new System.Drawing.Size(49, 17);
            this.checkBoxExit.TabIndex = 5;
            this.checkBoxExit.Text = "Exit?";
            this.checkBoxExit.UseVisualStyleBackColor = true;
            this.checkBoxExit.CheckedChanged += new System.EventHandler(this.CheckBoxExit_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxExit);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.textCopy);
            this.Controls.Add(this.textSentence);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonShow);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.TextBox textSentence;
        private System.Windows.Forms.TextBox textCopy;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.CheckBox checkBoxExit;
    }
}

