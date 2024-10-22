namespace WindowsFormsApp1
{
    partial class FormThree
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
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Node 1.1");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Node 1.2");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Node 1", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Node 2.1");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Node 2.2");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Node 2", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode41});
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnGet = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(70, 25);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(73, 29);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.Location = new System.Drawing.Point(215, 25);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(166, 29);
            this.currentTime.TabIndex = 1;
            this.currentTime.Text = "Current Time";
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(75, 101);
            this.treeView.Name = "treeView";
            treeNode36.Name = "Node1.1";
            treeNode36.Text = "Node 1.1";
            treeNode37.Name = "Node4";
            treeNode37.Text = "Node 1.2";
            treeNode38.Name = "Node1";
            treeNode38.Text = "Node 1";
            treeNode39.Name = "Node5";
            treeNode39.Text = "Node 2.1";
            treeNode40.Name = "Node6";
            treeNode40.Text = "Node 2.2";
            treeNode41.Name = "Node2";
            treeNode41.Text = "Node 2";
            treeNode42.Name = "Node0";
            treeNode42.Text = "Root";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode42});
            this.treeView.Size = new System.Drawing.Size(236, 247);
            this.treeView.TabIndex = 2;
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.SystemColors.Control;
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(647, 376);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(108, 41);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "Get";
            this.toolTip1.SetToolTip(this.btnGet, "Testing");
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            this.btnGet.MouseLeave += new System.EventHandler(this.btnGet_MouseLeave);
            this.btnGet.MouseHover += new System.EventHandler(this.btnGet_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Click Here";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(611, 91);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(88, 33);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(371, 91);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(181, 29);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Select Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(614, 130);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(119, 33);
            this.rbFemale.TabIndex = 6;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(462, 377);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(132, 40);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFile
            // 
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(363, 222);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(392, 126);
            this.txtFile.TabIndex = 8;
            // 
            // FormThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.lblTime);
            this.Name = "FormThree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThree";
            this.Load += new System.EventHandler(this.FormThree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerShow;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFile;
    }
}