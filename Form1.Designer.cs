namespace MealDBExporter
{
    /// <summary>
    /// Main Class for program
    /// </summary>
    partial class MealDBExporter
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
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.lbMealName = new System.Windows.Forms.Label();
            this.lbNextParticipant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnWriteNext = new System.Windows.Forms.Button();
            this.tbInStartTime = new System.Windows.Forms.TextBox();
            this.tbInMealName = new System.Windows.Forms.TextBox();
            this.tbInMealNumber = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbInEndTime = new System.Windows.Forms.TextBox();
            this.tbInLocation = new System.Windows.Forms.TextBox();
            this.tbInCompany = new System.Windows.Forms.TextBox();
            this.tbInActivity = new System.Windows.Forms.TextBox();
            this.tbOutStartTime = new System.Windows.Forms.TextBox();
            this.tbOutEndTime = new System.Windows.Forms.TextBox();
            this.tbOutLocation = new System.Windows.Forms.TextBox();
            this.tbOutMealName = new System.Windows.Forms.TextBox();
            this.tbOutCompany = new System.Windows.Forms.TextBox();
            this.tbOutActivity = new System.Windows.Forms.TextBox();
            this.tbOutMealNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCurrentDirectory = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbParentPath = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.tbInDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbOpFilePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(65, 26);
            this.tbFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(933, 22);
            this.tbFileName.TabIndex = 0;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(1045, 25);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(140, 30);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // lbMealName
            // 
            this.lbMealName.AutoSize = true;
            this.lbMealName.Location = new System.Drawing.Point(628, 137);
            this.lbMealName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMealName.Name = "lbMealName";
            this.lbMealName.Size = new System.Drawing.Size(79, 17);
            this.lbMealName.TabIndex = 2;
            this.lbMealName.Text = "Meal Name";
            // 
            // lbNextParticipant
            // 
            this.lbNextParticipant.Location = new System.Drawing.Point(1197, 26);
            this.lbNextParticipant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbNextParticipant.Name = "lbNextParticipant";
            this.lbNextParticipant.Size = new System.Drawing.Size(148, 28);
            this.lbNextParticipant.TabIndex = 3;
            this.lbNextParticipant.Text = "Next Participant";
            this.lbNextParticipant.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Meal Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(839, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1017, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Activity";
            // 
            // btnWriteNext
            // 
            this.btnWriteNext.Location = new System.Drawing.Point(1204, 252);
            this.btnWriteNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWriteNext.Name = "btnWriteNext";
            this.btnWriteNext.Size = new System.Drawing.Size(120, 28);
            this.btnWriteNext.TabIndex = 4;
            this.btnWriteNext.Text = "Write and Next";
            this.btnWriteNext.UseVisualStyleBackColor = true;
            this.btnWriteNext.Click += new System.EventHandler(this.btnWriteNext_Click);
            // 
            // tbInStartTime
            // 
            this.tbInStartTime.Location = new System.Drawing.Point(224, 158);
            this.tbInStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbInStartTime.Name = "tbInStartTime";
            this.tbInStartTime.Size = new System.Drawing.Size(108, 22);
            this.tbInStartTime.TabIndex = 5;
            // 
            // tbInMealName
            // 
            this.tbInMealName.Location = new System.Drawing.Point(601, 158);
            this.tbInMealName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbInMealName.Name = "tbInMealName";
            this.tbInMealName.Size = new System.Drawing.Size(149, 22);
            this.tbInMealName.TabIndex = 5;
            // 
            // tbInMealNumber
            // 
            this.tbInMealNumber.Location = new System.Drawing.Point(143, 158);
            this.tbInMealNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbInMealNumber.Name = "tbInMealNumber";
            this.tbInMealNumber.Size = new System.Drawing.Size(39, 22);
            this.tbInMealNumber.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(-411, 153);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(39, 22);
            this.textBox4.TabIndex = 5;
            // 
            // tbInEndTime
            // 
            this.tbInEndTime.Location = new System.Drawing.Point(341, 158);
            this.tbInEndTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbInEndTime.Name = "tbInEndTime";
            this.tbInEndTime.Size = new System.Drawing.Size(108, 22);
            this.tbInEndTime.TabIndex = 5;
            // 
            // tbInLocation
            // 
            this.tbInLocation.Location = new System.Drawing.Point(468, 158);
            this.tbInLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbInLocation.Name = "tbInLocation";
            this.tbInLocation.Size = new System.Drawing.Size(108, 22);
            this.tbInLocation.TabIndex = 5;
            // 
            // tbInCompany
            // 
            this.tbInCompany.Location = new System.Drawing.Point(793, 158);
            this.tbInCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbInCompany.Name = "tbInCompany";
            this.tbInCompany.Size = new System.Drawing.Size(149, 22);
            this.tbInCompany.TabIndex = 5;
            // 
            // tbInActivity
            // 
            this.tbInActivity.Location = new System.Drawing.Point(975, 158);
            this.tbInActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbInActivity.Name = "tbInActivity";
            this.tbInActivity.Size = new System.Drawing.Size(149, 22);
            this.tbInActivity.TabIndex = 5;
            // 
            // tbOutStartTime
            // 
            this.tbOutStartTime.Location = new System.Drawing.Point(224, 190);
            this.tbOutStartTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOutStartTime.Name = "tbOutStartTime";
            this.tbOutStartTime.Size = new System.Drawing.Size(108, 22);
            this.tbOutStartTime.TabIndex = 5;
            // 
            // tbOutEndTime
            // 
            this.tbOutEndTime.Location = new System.Drawing.Point(341, 190);
            this.tbOutEndTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOutEndTime.Name = "tbOutEndTime";
            this.tbOutEndTime.Size = new System.Drawing.Size(108, 22);
            this.tbOutEndTime.TabIndex = 5;
            // 
            // tbOutLocation
            // 
            this.tbOutLocation.Location = new System.Drawing.Point(468, 190);
            this.tbOutLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOutLocation.Name = "tbOutLocation";
            this.tbOutLocation.Size = new System.Drawing.Size(108, 22);
            this.tbOutLocation.TabIndex = 5;
            // 
            // tbOutMealName
            // 
            this.tbOutMealName.Location = new System.Drawing.Point(601, 190);
            this.tbOutMealName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOutMealName.Name = "tbOutMealName";
            this.tbOutMealName.Size = new System.Drawing.Size(149, 22);
            this.tbOutMealName.TabIndex = 5;
            // 
            // tbOutCompany
            // 
            this.tbOutCompany.Location = new System.Drawing.Point(793, 190);
            this.tbOutCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOutCompany.Name = "tbOutCompany";
            this.tbOutCompany.Size = new System.Drawing.Size(149, 22);
            this.tbOutCompany.TabIndex = 5;
            // 
            // tbOutActivity
            // 
            this.tbOutActivity.Location = new System.Drawing.Point(975, 190);
            this.tbOutActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOutActivity.Name = "tbOutActivity";
            this.tbOutActivity.Size = new System.Drawing.Size(149, 22);
            this.tbOutActivity.TabIndex = 5;
            // 
            // tbOutMealNumber
            // 
            this.tbOutMealNumber.Location = new System.Drawing.Point(143, 190);
            this.tbOutMealNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOutMealNumber.Name = "tbOutMealNumber";
            this.tbOutMealNumber.Size = new System.Drawing.Size(39, 22);
            this.tbOutMealNumber.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Events File";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Output";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Current Participant";
            // 
            // tbCurrentDirectory
            // 
            this.tbCurrentDirectory.Location = new System.Drawing.Point(236, 70);
            this.tbCurrentDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCurrentDirectory.Name = "tbCurrentDirectory";
            this.tbCurrentDirectory.Size = new System.Drawing.Size(108, 22);
            this.tbCurrentDirectory.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Parent Path";
            // 
            // tbParentPath
            // 
            this.tbParentPath.Location = new System.Drawing.Point(552, 70);
            this.tbParentPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbParentPath.Name = "tbParentPath";
            this.tbParentPath.Size = new System.Drawing.Size(771, 22);
            this.tbParentPath.TabIndex = 5;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(1200, 137);
            this.Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(79, 17);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description";
            // 
            // tbInDescription
            // 
            this.tbInDescription.Location = new System.Drawing.Point(1157, 158);
            this.tbInDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbInDescription.Name = "tbInDescription";
            this.tbInDescription.Size = new System.Drawing.Size(149, 22);
            this.tbInDescription.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Output File";
            // 
            // tbOpFilePath
            // 
            this.tbOpFilePath.Location = new System.Drawing.Point(190, 259);
            this.tbOpFilePath.Name = "tbOpFilePath";
            this.tbOpFilePath.Size = new System.Drawing.Size(560, 22);
            this.tbOpFilePath.TabIndex = 8;
            this.tbOpFilePath.Text = "C:\\ShimmerData\\TabBase.txt";
            // 
            // MealDBExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 417);
            this.Controls.Add(this.tbOpFilePath);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tbOutMealNumber);
            this.Controls.Add(this.tbOutActivity);
            this.Controls.Add(this.tbInMealNumber);
            this.Controls.Add(this.tbOutCompany);
            this.Controls.Add(this.tbInDescription);
            this.Controls.Add(this.tbInActivity);
            this.Controls.Add(this.tbOutMealName);
            this.Controls.Add(this.tbInCompany);
            this.Controls.Add(this.tbOutLocation);
            this.Controls.Add(this.tbInMealName);
            this.Controls.Add(this.tbOutEndTime);
            this.Controls.Add(this.tbInLocation);
            this.Controls.Add(this.tbOutStartTime);
            this.Controls.Add(this.tbInEndTime);
            this.Controls.Add(this.tbParentPath);
            this.Controls.Add(this.tbCurrentDirectory);
            this.Controls.Add(this.tbInStartTime);
            this.Controls.Add(this.btnWriteNext);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.lbNextParticipant);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbMealName);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.tbFileName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MealDBExporter";
            this.Text = "MealDBExporter";
            this.Load += new System.EventHandler(this.MealDBExporter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label lbMealName;
        private System.Windows.Forms.Button lbNextParticipant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnWriteNext;
        private System.Windows.Forms.TextBox tbInStartTime;
        private System.Windows.Forms.TextBox tbInMealName;
        private System.Windows.Forms.TextBox tbInMealNumber;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tbInEndTime;
        private System.Windows.Forms.TextBox tbInLocation;
        private System.Windows.Forms.TextBox tbInCompany;
        private System.Windows.Forms.TextBox tbInActivity;
        private System.Windows.Forms.TextBox tbOutStartTime;
        private System.Windows.Forms.TextBox tbOutEndTime;
        private System.Windows.Forms.TextBox tbOutLocation;
        private System.Windows.Forms.TextBox tbOutMealName;
        private System.Windows.Forms.TextBox tbOutCompany;
        private System.Windows.Forms.TextBox tbOutActivity;
        private System.Windows.Forms.TextBox tbOutMealNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCurrentDirectory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbParentPath;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox tbInDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbOpFilePath;
    }
}

