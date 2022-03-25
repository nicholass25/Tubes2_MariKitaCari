namespace MariKitaCari
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.layoutLeft = new System.Windows.Forms.TableLayoutPanel();
            this.labelInput = new System.Windows.Forms.Label();
            this.ButtonChangeFolder = new System.Windows.Forms.Button();
            this.labelStartingDirectory = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.RichTextBox();
            this.checkBoxOccurence = new System.Windows.Forms.CheckBox();
            this.labelSearchingMethod = new System.Windows.Forms.Label();
            this.radiobtnBFS = new System.Windows.Forms.RadioButton();
            this.radiobtnDFS = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.layoutRight = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelList = new System.Windows.Forms.LinkLabel();
            this.labelOutput = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTimeSpent = new System.Windows.Forms.Label();
            this.labelOutputTimeSpent = new System.Windows.Forms.Label();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.layoutTop.SuspendLayout();
            this.layoutLeft.SuspendLayout();
            this.layoutRight.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            // layoutLeft
            // 
            this.layoutLeft.ColumnCount = 1;
            this.layoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutLeft.Controls.Add(this.labelInput, 0, 0);
            this.layoutLeft.Controls.Add(this.ButtonChangeFolder, 0, 2);
            this.layoutLeft.Controls.Add(this.labelStartingDirectory, 0, 1);
            this.layoutLeft.Controls.Add(this.labelPath, 0, 3);
            this.layoutLeft.Controls.Add(this.labelFileName, 0, 4);
            this.layoutLeft.Controls.Add(this.textBoxFileName, 0, 5);
            this.layoutLeft.Controls.Add(this.checkBoxOccurence, 0, 6);
            this.layoutLeft.Controls.Add(this.labelSearchingMethod, 0, 7);
            this.layoutLeft.Controls.Add(this.radiobtnBFS, 0, 8);
            this.layoutLeft.Controls.Add(this.radiobtnDFS, 0, 9);
            this.layoutLeft.Controls.Add(this.buttonSearch, 0, 10);
            this.layoutLeft.Location = new System.Drawing.Point(12, 48);
            this.layoutLeft.Name = "layoutLeft";
            this.layoutLeft.RowCount = 11;
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.34783F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.65217F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.layoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutLeft.Size = new System.Drawing.Size(244, 345);
            this.layoutLeft.TabIndex = 1;
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
            // ButtonChangeFolder
            // 
            this.ButtonChangeFolder.Location = new System.Drawing.Point(3, 48);
            this.ButtonChangeFolder.Name = "ButtonChangeFolder";
            this.ButtonChangeFolder.Size = new System.Drawing.Size(96, 23);
            this.ButtonChangeFolder.TabIndex = 1;
            this.ButtonChangeFolder.Text = "&Change Folder...";
            this.ButtonChangeFolder.UseVisualStyleBackColor = true;
            this.ButtonChangeFolder.Click += new System.EventHandler(this.ButtonChangeFolder_Click);
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
            this.labelPath.Location = new System.Drawing.Point(3, 77);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(51, 13);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "labelPath";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.Location = new System.Drawing.Point(3, 154);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(96, 13);
            this.labelFileName.TabIndex = 4;
            this.labelFileName.Text = "Input File Name";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(3, 176);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(238, 22);
            this.textBoxFileName.TabIndex = 5;
            this.textBoxFileName.Text = "";
            // 
            // checkBoxOccurence
            // 
            this.checkBoxOccurence.AutoSize = true;
            this.checkBoxOccurence.Location = new System.Drawing.Point(3, 207);
            this.checkBoxOccurence.Name = "checkBoxOccurence";
            this.checkBoxOccurence.Size = new System.Drawing.Size(132, 17);
            this.checkBoxOccurence.TabIndex = 6;
            this.checkBoxOccurence.Text = "Check All Occurences";
            this.checkBoxOccurence.UseVisualStyleBackColor = true;
            // 
            // labelSearchingMethod
            // 
            this.labelSearchingMethod.AutoSize = true;
            this.labelSearchingMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchingMethod.Location = new System.Drawing.Point(3, 233);
            this.labelSearchingMethod.Name = "labelSearchingMethod";
            this.labelSearchingMethod.Size = new System.Drawing.Size(143, 13);
            this.labelSearchingMethod.TabIndex = 7;
            this.labelSearchingMethod.Text = "Input Searching Method";
            // 
            // radiobtnBFS
            // 
            this.radiobtnBFS.AutoSize = true;
            this.radiobtnBFS.Location = new System.Drawing.Point(3, 256);
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
            this.radiobtnDFS.Location = new System.Drawing.Point(3, 284);
            this.radiobtnDFS.Name = "radiobtnDFS";
            this.radiobtnDFS.Size = new System.Drawing.Size(46, 17);
            this.radiobtnDFS.TabIndex = 9;
            this.radiobtnDFS.TabStop = true;
            this.radiobtnDFS.Text = "DFS";
            this.radiobtnDFS.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(3, 312);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(96, 23);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "&Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // layoutRight
            // 
            this.layoutRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutRight.ColumnCount = 1;
            this.layoutRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRight.Controls.Add(this.labelOutput, 0, 0);
            this.layoutRight.Controls.Add(this.panel1, 0, 1);
            this.layoutRight.Controls.Add(this.labelTimeSpent, 0, 2);
            this.layoutRight.Controls.Add(this.labelOutputTimeSpent, 0, 3);
            this.layoutRight.Controls.Add(this.labelFilePath, 0, 4);
            this.layoutRight.Controls.Add(this.flowLayoutPanel1, 0, 5);
            this.layoutRight.Location = new System.Drawing.Point(262, 48);
            this.layoutRight.Name = "layoutRight";
            this.layoutRight.RowCount = 6;
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.738544F));
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.26145F));
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.layoutRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.layoutRight.Size = new System.Drawing.Size(510, 502);
            this.layoutRight.TabIndex = 2;
            // 
            // linkLabelList
            // 
            this.linkLabelList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelList.AutoSize = true;
            this.linkLabelList.Location = new System.Drawing.Point(3, 0);
            this.linkLabelList.Name = "linkLabelList";
            this.linkLabelList.Size = new System.Drawing.Size(65, 13);
            this.linkLabelList.TabIndex = 0;
            this.linkLabelList.TabStop = true;
            this.linkLabelList.Text = "linkLabelList";
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(3, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 354);
            this.panel1.TabIndex = 3;
            // 
            // labelTimeSpent
            // 
            this.labelTimeSpent.AutoSize = true;
            this.labelTimeSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeSpent.Location = new System.Drawing.Point(3, 386);
            this.labelTimeSpent.Name = "labelTimeSpent";
            this.labelTimeSpent.Size = new System.Drawing.Size(71, 13);
            this.labelTimeSpent.TabIndex = 2;
            this.labelTimeSpent.Text = "Time Spent";
            // 
            // labelOutputTimeSpent
            // 
            this.labelOutputTimeSpent.AutoSize = true;
            this.labelOutputTimeSpent.Location = new System.Drawing.Point(3, 405);
            this.labelOutputTimeSpent.Name = "labelOutputTimeSpent";
            this.labelOutputTimeSpent.Size = new System.Drawing.Size(112, 13);
            this.labelOutputTimeSpent.TabIndex = 4;
            this.labelOutputTimeSpent.Text = "labelOutputTimeSpent";
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilePath.Location = new System.Drawing.Point(3, 429);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(57, 13);
            this.labelFilePath.TabIndex = 1;
            this.labelFilePath.Text = "File Path";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMinSize = new System.Drawing.Size(504, 48);
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.linkLabelList);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 451);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(504, 48);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.layoutRight);
            this.Controls.Add(this.layoutLeft);
            this.Controls.Add(this.layoutTop);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "MariKitaCari";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.layoutTop.ResumeLayout(false);
            this.layoutTop.PerformLayout();
            this.layoutLeft.ResumeLayout(false);
            this.layoutLeft.PerformLayout();
            this.layoutRight.ResumeLayout(false);
            this.layoutRight.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel layoutTop;
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.TableLayoutPanel layoutLeft;
    private System.Windows.Forms.Label labelInput;
    private System.Windows.Forms.TableLayoutPanel layoutRight;
    private System.Windows.Forms.Label labelOutput;
    private System.Windows.Forms.Button ButtonChangeFolder;
    private System.Windows.Forms.Label labelStartingDirectory;
    private System.Windows.Forms.Label labelPath;
    private System.Windows.Forms.Label labelFileName;
    private System.Windows.Forms.RichTextBox textBoxFileName;
    private System.Windows.Forms.CheckBox checkBoxOccurence;
    private System.Windows.Forms.Label labelSearchingMethod;
    private System.Windows.Forms.RadioButton radiobtnBFS;
    private System.Windows.Forms.RadioButton radiobtnDFS;
    private System.Windows.Forms.Button buttonSearch;
    private System.Windows.Forms.Label labelFilePath;
    private System.Windows.Forms.Label labelTimeSpent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelOutputTimeSpent;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabelList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

