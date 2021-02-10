namespace AdoDotNetProject_Elias
{
    partial class Course
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCid = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtInstractorName = new System.Windows.Forms.TextBox();
            this.txtCoursePrice = new System.Windows.Forms.TextBox();
            this.txtCourseDuration = new System.Windows.Forms.TextBox();
            this.lblInstractorName = new System.Windows.Forms.Label();
            this.lblCoursePrice = new System.Windows.Forms.Label();
            this.lblCourseDuration = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSid = new System.Windows.Forms.Label();
            this.lblHeadline = new System.Windows.Forms.Label();
            this.lblTitleOfGridView = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.dgViewCourse = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.lblCid);
            this.groupBox1.Controls.Add(this.txtCourseName);
            this.groupBox1.Controls.Add(this.txtInstractorName);
            this.groupBox1.Controls.Add(this.txtCoursePrice);
            this.groupBox1.Controls.Add(this.txtCourseDuration);
            this.groupBox1.Controls.Add(this.lblInstractorName);
            this.groupBox1.Controls.Add(this.lblCoursePrice);
            this.groupBox1.Controls.Add(this.lblCourseDuration);
            this.groupBox1.Controls.Add(this.lblCourseName);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 561);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD Operation";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.ForeColor = System.Drawing.Color.Red;
            this.lblCid.Location = new System.Drawing.Point(31, 490);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(0, 29);
            this.lblCid.TabIndex = 29;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(275, 83);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCourseName.Multiline = true;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(376, 41);
            this.txtCourseName.TabIndex = 28;
            // 
            // txtInstractorName
            // 
            this.txtInstractorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstractorName.Location = new System.Drawing.Point(275, 282);
            this.txtInstractorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInstractorName.Multiline = true;
            this.txtInstractorName.Name = "txtInstractorName";
            this.txtInstractorName.Size = new System.Drawing.Size(376, 41);
            this.txtInstractorName.TabIndex = 27;
            // 
            // txtCoursePrice
            // 
            this.txtCoursePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoursePrice.Location = new System.Drawing.Point(275, 210);
            this.txtCoursePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCoursePrice.Multiline = true;
            this.txtCoursePrice.Name = "txtCoursePrice";
            this.txtCoursePrice.Size = new System.Drawing.Size(376, 41);
            this.txtCoursePrice.TabIndex = 26;
            // 
            // txtCourseDuration
            // 
            this.txtCourseDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseDuration.Location = new System.Drawing.Point(275, 147);
            this.txtCourseDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCourseDuration.Multiline = true;
            this.txtCourseDuration.Name = "txtCourseDuration";
            this.txtCourseDuration.Size = new System.Drawing.Size(376, 41);
            this.txtCourseDuration.TabIndex = 25;
            this.txtCourseDuration.TextChanged += new System.EventHandler(this.txtCourseDuration_TextChanged);
            // 
            // lblInstractorName
            // 
            this.lblInstractorName.AutoSize = true;
            this.lblInstractorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstractorName.Location = new System.Drawing.Point(96, 282);
            this.lblInstractorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstractorName.Name = "lblInstractorName";
            this.lblInstractorName.Size = new System.Drawing.Size(149, 25);
            this.lblInstractorName.TabIndex = 24;
            this.lblInstractorName.Text = "Instractor Name";
            // 
            // lblCoursePrice
            // 
            this.lblCoursePrice.AutoSize = true;
            this.lblCoursePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursePrice.Location = new System.Drawing.Point(96, 210);
            this.lblCoursePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoursePrice.Name = "lblCoursePrice";
            this.lblCoursePrice.Size = new System.Drawing.Size(125, 25);
            this.lblCoursePrice.TabIndex = 23;
            this.lblCoursePrice.Text = "Course Price";
            // 
            // lblCourseDuration
            // 
            this.lblCourseDuration.AutoSize = true;
            this.lblCourseDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDuration.Location = new System.Drawing.Point(96, 147);
            this.lblCourseDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseDuration.Name = "lblCourseDuration";
            this.lblCourseDuration.Size = new System.Drawing.Size(154, 25);
            this.lblCourseDuration.TabIndex = 22;
            this.lblCourseDuration.Text = "Course Duration";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(96, 86);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(133, 25);
            this.lblCourseName.TabIndex = 2;
            this.lblCourseName.Text = "Course Name";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(266, 466);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(261, 76);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel Operation";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(500, 379);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(151, 66);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(121, 383);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 66);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(314, 379);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 66);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSid
            // 
            this.lblSid.AutoSize = true;
            this.lblSid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSid.Location = new System.Drawing.Point(316, 604);
            this.lblSid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSid.Name = "lblSid";
            this.lblSid.Size = new System.Drawing.Size(0, 25);
            this.lblSid.TabIndex = 44;
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHeadline.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadline.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHeadline.Location = new System.Drawing.Point(395, 20);
            this.lblHeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(326, 49);
            this.lblHeadline.TabIndex = 43;
            this.lblHeadline.Text = "Course Information \r\n";
            // 
            // lblTitleOfGridView
            // 
            this.lblTitleOfGridView.AutoSize = true;
            this.lblTitleOfGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleOfGridView.Location = new System.Drawing.Point(895, 44);
            this.lblTitleOfGridView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleOfGridView.Name = "lblTitleOfGridView";
            this.lblTitleOfGridView.Size = new System.Drawing.Size(649, 25);
            this.lblTitleOfGridView.TabIndex = 42;
            this.lblTitleOfGridView.Text = "Please Click Over any Cell of row to UPDATE or DELETE data of that row";
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.Red;
            this.lblLogOut.Location = new System.Drawing.Point(105, 651);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(130, 38);
            this.lblLogOut.TabIndex = 40;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // dgViewCourse
            // 
            this.dgViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewCourse.Location = new System.Drawing.Point(834, 87);
            this.dgViewCourse.Name = "dgViewCourse";
            this.dgViewCourse.RowHeadersWidth = 62;
            this.dgViewCourse.RowTemplate.Height = 28;
            this.dgViewCourse.Size = new System.Drawing.Size(802, 561);
            this.dgViewCourse.TabIndex = 46;
            this.dgViewCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewCourse_CellClick);
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 708);
            this.Controls.Add(this.dgViewCourse);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSid);
            this.Controls.Add(this.lblHeadline);
            this.Controls.Add(this.lblTitleOfGridView);
            this.Controls.Add(this.lblLogOut);
            this.Name = "Course";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Course_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtInstractorName;
        private System.Windows.Forms.TextBox txtCoursePrice;
        private System.Windows.Forms.TextBox txtCourseDuration;
        private System.Windows.Forms.Label lblInstractorName;
        private System.Windows.Forms.Label lblCoursePrice;
        private System.Windows.Forms.Label lblCourseDuration;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSid;
        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Label lblTitleOfGridView;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.DataGridView dgViewCourse;
    }
}