namespace SoftwareEngineering
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchDropDown = new System.Windows.Forms.ComboBox();
            this.searchGroup = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.resultsGroup = new System.Windows.Forms.GroupBox();
            this.calendarGroup = new System.Windows.Forms.GroupBox();
            this.courseCheckBox = new System.Windows.Forms.CheckBox();
            this.courseName = new System.Windows.Forms.Label();
            this.courseLocation = new System.Windows.Forms.Label();
            this.courseDateTime = new System.Windows.Forms.Label();
            this.courseSeatsAvail = new System.Windows.Forms.Label();
            this.searchGroup.SuspendLayout();
            this.resultsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(187, 31);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(310, 20);
            this.searchBox.TabIndex = 0;
            // 
            // searchDropDown
            // 
            this.searchDropDown.FormattingEnabled = true;
            this.searchDropDown.Items.AddRange(new object[] {
            "Course Code"});
            this.searchDropDown.Location = new System.Drawing.Point(22, 30);
            this.searchDropDown.Name = "searchDropDown";
            this.searchDropDown.Size = new System.Drawing.Size(145, 21);
            this.searchDropDown.TabIndex = 1;
            this.searchDropDown.Text = "Course Code";
            // 
            // searchGroup
            // 
            this.searchGroup.Controls.Add(this.dateTimePicker);
            this.searchGroup.Controls.Add(this.searchBox);
            this.searchGroup.Controls.Add(this.searchDropDown);
            this.searchGroup.Location = new System.Drawing.Point(12, 12);
            this.searchGroup.Name = "searchGroup";
            this.searchGroup.Size = new System.Drawing.Size(515, 111);
            this.searchGroup.TabIndex = 2;
            this.searchGroup.TabStop = false;
            this.searchGroup.Text = "Search";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(22, 70);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // resultsGroup
            // 
            this.resultsGroup.Controls.Add(this.courseSeatsAvail);
            this.resultsGroup.Controls.Add(this.courseDateTime);
            this.resultsGroup.Controls.Add(this.courseLocation);
            this.resultsGroup.Controls.Add(this.courseName);
            this.resultsGroup.Controls.Add(this.courseCheckBox);
            this.resultsGroup.Location = new System.Drawing.Point(548, 12);
            this.resultsGroup.Name = "resultsGroup";
            this.resultsGroup.Size = new System.Drawing.Size(394, 492);
            this.resultsGroup.TabIndex = 3;
            this.resultsGroup.TabStop = false;
            this.resultsGroup.Text = "Results";
            // 
            // calendarGroup
            // 
            this.calendarGroup.Location = new System.Drawing.Point(12, 138);
            this.calendarGroup.Name = "calendarGroup";
            this.calendarGroup.Size = new System.Drawing.Size(515, 366);
            this.calendarGroup.TabIndex = 4;
            this.calendarGroup.TabStop = false;
            this.calendarGroup.Text = "Calendar";
            // 
            // courseCheckBox
            // 
            this.courseCheckBox.AutoSize = true;
            this.courseCheckBox.Location = new System.Drawing.Point(26, 32);
            this.courseCheckBox.Name = "courseCheckBox";
            this.courseCheckBox.Size = new System.Drawing.Size(87, 17);
            this.courseCheckBox.TabIndex = 0;
            this.courseCheckBox.Text = "Course Code";
            this.courseCheckBox.UseVisualStyleBackColor = true;
            // 
            // courseName
            // 
            this.courseName.AutoSize = true;
            this.courseName.Location = new System.Drawing.Point(150, 33);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(71, 13);
            this.courseName.TabIndex = 1;
            this.courseName.Text = "Course Name";
            // 
            // courseLocation
            // 
            this.courseLocation.AutoSize = true;
            this.courseLocation.Location = new System.Drawing.Point(150, 57);
            this.courseLocation.Name = "courseLocation";
            this.courseLocation.Size = new System.Drawing.Size(48, 13);
            this.courseLocation.TabIndex = 2;
            this.courseLocation.Text = "Location";
            // 
            // courseDateTime
            // 
            this.courseDateTime.AutoSize = true;
            this.courseDateTime.Location = new System.Drawing.Point(266, 33);
            this.courseDateTime.Name = "courseDateTime";
            this.courseDateTime.Size = new System.Drawing.Size(73, 13);
            this.courseDateTime.TabIndex = 3;
            this.courseDateTime.Text = "Day and Time";
            // 
            // courseSeatsAvail
            // 
            this.courseSeatsAvail.AutoSize = true;
            this.courseSeatsAvail.Location = new System.Drawing.Point(266, 57);
            this.courseSeatsAvail.Name = "courseSeatsAvail";
            this.courseSeatsAvail.Size = new System.Drawing.Size(93, 13);
            this.courseSeatsAvail.TabIndex = 4;
            this.courseSeatsAvail.Text = "Seats Available: #";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 516);
            this.Controls.Add(this.calendarGroup);
            this.Controls.Add(this.resultsGroup);
            this.Controls.Add(this.searchGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.searchGroup.ResumeLayout(false);
            this.searchGroup.PerformLayout();
            this.resultsGroup.ResumeLayout(false);
            this.resultsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox searchDropDown;
        private System.Windows.Forms.GroupBox searchGroup;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox resultsGroup;
        private System.Windows.Forms.Label courseSeatsAvail;
        private System.Windows.Forms.Label courseDateTime;
        private System.Windows.Forms.Label courseLocation;
        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.CheckBox courseCheckBox;
        private System.Windows.Forms.GroupBox calendarGroup;
    }
}

