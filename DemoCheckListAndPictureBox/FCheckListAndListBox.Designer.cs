namespace DemoCheckListAndPictureBox
{
    partial class fDemo
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
            this.clbDanhSach = new System.Windows.Forms.CheckedListBox();
            this.lbDanhSach = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbDanhSach
            // 
            this.clbDanhSach.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.clbDanhSach.BackColor = System.Drawing.Color.IndianRed;
            this.clbDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbDanhSach.CheckOnClick = true;
            this.clbDanhSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clbDanhSach.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clbDanhSach.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.clbDanhSach.FormattingEnabled = true;
            this.clbDanhSach.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.clbDanhSach.IntegralHeight = false;
            this.clbDanhSach.Items.AddRange(new object[] {
            "C",
            "C#",
            "C++",
            "Dart",
            "Go",
            "Java",
            "JS",
            "Kotlin",
            "Pascal",
            "PHP",
            "Python",
            "R",
            "Ruby",
            "Scala",
            "Swift"});
            this.clbDanhSach.Location = new System.Drawing.Point(94, 26);
            this.clbDanhSach.MultiColumn = true;
            this.clbDanhSach.Name = "clbDanhSach";
            this.clbDanhSach.ScrollAlwaysVisible = true;
            this.clbDanhSach.Size = new System.Drawing.Size(586, 158);
            this.clbDanhSach.Sorted = true;
            this.clbDanhSach.TabIndex = 0;
            this.clbDanhSach.TabStop = false;
            this.clbDanhSach.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.BackColor = System.Drawing.Color.LightCoral;
            this.lbDanhSach.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbDanhSach.ForeColor = System.Drawing.Color.Honeydew;
            this.lbDanhSach.FormattingEnabled = true;
            this.lbDanhSach.ItemHeight = 41;
            this.lbDanhSach.Location = new System.Drawing.Point(94, 227);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbDanhSach.Size = new System.Drawing.Size(398, 168);
            this.lbDanhSach.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(535, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 69);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(535, 227);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 69);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // fDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(752, 485);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbDanhSach);
            this.Controls.Add(this.clbDanhSach);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Brown;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "fDemo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo";
            this.TransparencyKey = System.Drawing.Color.Orchid;
            this.Load += new System.EventHandler(this.fDemo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox clbDanhSach;
        private ListBox lbDanhSach;
        private Button btnDelete;
        private Button btnReset;
    }
}