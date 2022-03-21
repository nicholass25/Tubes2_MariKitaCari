namespace Tubes2Stima
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
            this.layoutTop = new System.Windows.Forms.TableLayoutPanel();
            this.layoutLeft = new System.Windows.Forms.TableLayoutPanel();
            this.layoutRight = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonChangeFolder = new System.Windows.Forms.Button();
            this.labelStartingDirectory = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelSearchingMethod = new System.Windows.Forms.Label();
            this.radiobtnBFS = new System.Windows.Forms.RadioButton();
            this.radiobtnDFS = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.labelTimeSpent = new System.Windows.Forms.Label();
            this.layoutTop.SuspendLayout();
            this.layoutLeft.SuspendLayout();
            this.layoutRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutTop
            // 
            this.layoutTop.ColumnCount = 1;
            this.layoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTop.Controls.Add(this.labelTitle, 0, 0);
            this.layoutTop.Location = new System.Drawing.Point(12, 12);
            this.layoutTop.Name = "layoutTop";
            this.layoutTop.RowCount = 1;
            this.layoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTop.Size = new System.Drawing.Size(760, 30);
            this.layoutTop.TabIndex = 0;
            // 
            // layoutLeft
            // 
            this.layoutLeft.ColumnCount = 1;
            this.layoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutLeft.Controls.Add(this.labelInput, 0, 0);
            this.layoutLeft.Controls.Add(this.buttonChangeFolder, 0, 2);
            this.layoutLeft.Controls.Add(this.labelStartingDirectory, 0, 1);
            this.layoutLeft.Controls.Add(this.labelPath, 0, 3);
            this.layoutLeft.Controls.Add(this.labelFileName, 0, 4);
            this.layoutLeft.Controls.Add(this.richTextBox1, 0, 5);
            this.layoutLeft.Controls.Add(this.checkBox1, 0, 6);
            this.layoutLeft.Controls.Add(this.labelSearchingMethod, 0, 7);
            this.layoutLeft.Controls.Add(this.radiobtnBFS, 0, 8);
            this.layoutLeft.Controls.Add(this.radiobtnDFS, 0, 9);
            this.layoutLeft.Controls.Add(this.buttonSearch, 0, 10);
            this.layoutLeft.Location = new System.Drawing.Point(12, 48);
            this.layoutLeft.Name = "layoutLeft";
            this.layoutLeft.RowCount = 11;
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutLeft.Size = new System.Drawing.Size(244, 302);
            this.layoutLeft.TabIndex = 1;
            // 
            // layoutRight
            // 
            this.layoutRight.ColumnCount = 1;
            this.layoutRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight.Controls.Add(this.labelOutput, 0, 0);
            this.layoutRight.Controls.Add(this.labelFilePath, 0, 2);
            this.layoutRight.Controls.Add(this.labelTimeSpent, 0, 4);
            this.layoutRight.Location = new System.Drawing.Point(262, 48);
            this.layoutRight.Name = "layoutRight";
            this.layoutRight.RowCount = 6;
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.67616F));
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.32384F));
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutRight.Size = new System.Drawing.Size(510, 302);
            this.layoutRight.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(754, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "MariKitaCari";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInput
            // 
            this.labelInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(3, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(238, 16);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input";
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelOutput
            // 
            this.labelOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(3, 0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(504, 16);
            this.labelOutput.TabIndex = 0;
            this.labelOutput.Text = "Output";
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonChangeFolder
            // 
            this.buttonChangeFolder.Location = new System.Drawing.Point(3, 49);
            this.buttonChangeFolder.Name = "buttonChangeFolder";
            this.buttonChangeFolder.Size = new System.Drawing.Size(96, 23);
            this.buttonChangeFolder.TabIndex = 1;
            this.buttonChangeFolder.Text = "Change Folder...";
            this.buttonChangeFolder.UseVisualStyleBackColor = true;
            this.buttonChangeFolder.Click += new System.EventHandler(this.buttonChangeFolder_Click);
            // 
            // labelStartingDirectory
            // 
            this.labelStartingDirectory.AutoSize = true;
            this.labelStartingDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartingDirectory.Location = new System.Drawing.Point(3, 25);
            this.labelStartingDirectory.Name = "labelStartingDirectory";
            this.labelStartingDirectory.Size = new System.Drawing.Size(152, 13);
            this.labelStartingDirectory.TabIndex = 2;
            this.labelStartingDirectory.Text = "Choose Starting Directory";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(3, 76);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(51, 13);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "labelPath";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.Location = new System.Drawing.Point(3, 111);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(96, 13);
            this.labelFileName.TabIndex = 4;
            this.labelFileName.Text = "Input File Name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 133);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(238, 22);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 164);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Check All Occurences";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelSearchingMethod
            // 
            this.labelSearchingMethod.AutoSize = true;
            this.labelSearchingMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchingMethod.Location = new System.Drawing.Point(3, 190);
            this.labelSearchingMethod.Name = "labelSearchingMethod";
            this.labelSearchingMethod.Size = new System.Drawing.Size(143, 13);
            this.labelSearchingMethod.TabIndex = 7;
            this.labelSearchingMethod.Text = "Input Searching Method";
            // 
            // radiobtnBFS
            // 
            this.radiobtnBFS.AutoSize = true;
            this.radiobtnBFS.Location = new System.Drawing.Point(3, 213);
            this.radiobtnBFS.Name = "radiobtnBFS";
            this.radiobtnBFS.Size = new System.Drawing.Size(45, 17);
            this.radiobtnBFS.TabIndex = 8;
            this.radiobtnBFS.TabStop = true;
            this.radiobtnBFS.Text = "BFS";
            this.radiobtnBFS.UseVisualStyleBackColor = true;
            // 
            // radiobtnDFS
            // 
            this.radiobtnDFS.AutoSize = true;
            this.radiobtnDFS.Location = new System.Drawing.Point(3, 241);
            this.radiobtnDFS.Name = "radiobtnDFS";
            this.radiobtnDFS.Size = new System.Drawing.Size(46, 17);
            this.radiobtnDFS.TabIndex = 9;
            this.radiobtnDFS.TabStop = true;
            this.radiobtnDFS.Text = "DFS";
            this.radiobtnDFS.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(3, 269);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(96, 23);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilePath.Location = new System.Drawing.Point(3, 221);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(57, 13);
            this.labelFilePath.TabIndex = 1;
            this.labelFilePath.Text = "File Path";
            // 
            // labelTimeSpent
            // 
            this.labelTimeSpent.AutoSize = true;
            this.labelTimeSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeSpent.Location = new System.Drawing.Point(3, 261);
            this.labelTimeSpent.Name = "labelTimeSpent";
            this.labelTimeSpent.Size = new System.Drawing.Size(71, 13);
            this.labelTimeSpent.TabIndex = 2;
            this.labelTimeSpent.Text = "Time Spent";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.layoutRight);
            this.Controls.Add(this.layoutLeft);
            this.Controls.Add(this.layoutTop);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "MariKitaCari";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.layoutTop.ResumeLayout(false);
            this.layoutTop.PerformLayout();
            this.layoutLeft.ResumeLayout(false);
            this.layoutLeft.PerformLayout();
            this.layoutRight.ResumeLayout(false);
            this.layoutRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel layoutLeft;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TableLayoutPanel layoutRight;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonChangeFolder;
        private System.Windows.Forms.Label labelStartingDirectory;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelSearchingMethod;
        private System.Windows.Forms.RadioButton radiobtnBFS;
        private System.Windows.Forms.RadioButton radiobtnDFS;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Label labelTimeSpent;
    }
}

