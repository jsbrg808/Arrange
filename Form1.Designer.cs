namespace ProcessWindowInfo
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProcesses = new System.Windows.Forms.Label();
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCascade = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnFirst1stHalf = new System.Windows.Forms.Button();
            this.btnFirst2ndHalf = new System.Windows.Forms.Button();
            this.btnSecond1stHalf = new System.Windows.Forms.Button();
            this.btnSecond2ndHalf = new System.Windows.Forms.Button();
            this.First1stThird = new System.Windows.Forms.Button();
            this.First2ndThird = new System.Windows.Forms.Button();
            this.First3rdThird = new System.Windows.Forms.Button();
            this.Second1stThird = new System.Windows.Forms.Button();
            this.Second2ndThird = new System.Windows.Forms.Button();
            this.Second3rdThird = new System.Windows.Forms.Button();
            this.btnFirst1stDouble = new System.Windows.Forms.Button();
            this.btnFirst2ndDouble = new System.Windows.Forms.Button();
            this.btnSecond1stDouble = new System.Windows.Forms.Button();
            this.btnSecond2ndDouble = new System.Windows.Forms.Button();
            this.First1stQuarter = new System.Windows.Forms.Button();
            this.First2ndQuarter = new System.Windows.Forms.Button();
            this.First3rdQuarter = new System.Windows.Forms.Button();
            this.First4thQuarter = new System.Windows.Forms.Button();
            this.Second1stQuarter = new System.Windows.Forms.Button();
            this.Second2ndQuarter = new System.Windows.Forms.Button();
            this.Second3rdQuarter = new System.Windows.Forms.Button();
            this.Second4thQuarter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProcesses
            // 
            this.lblProcesses.AutoSize = true;
            this.lblProcesses.Location = new System.Drawing.Point(10, 10);
            this.lblProcesses.Name = "lblProcesses";
            this.lblProcesses.Size = new System.Drawing.Size(66, 12);
            this.lblProcesses.TabIndex = 2;
            this.lblProcesses.Text = "Processes";
            this.lblProcesses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstProcesses
            // 
            this.lstProcesses.FormattingEnabled = true;
            this.lstProcesses.ItemHeight = 12;
            this.lstProcesses.Location = new System.Drawing.Point(10, 35);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.Size = new System.Drawing.Size(600, 196);
            this.lstProcesses.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(630, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 25);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCascade
            // 
            this.btnCascade.Location = new System.Drawing.Point(630, 45);
            this.btnCascade.Name = "btnCascade";
            this.btnCascade.Size = new System.Drawing.Size(75, 25);
            this.btnCascade.TabIndex = 30;
            this.btnCascade.Text = "Cascade";
            this.btnCascade.UseVisualStyleBackColor = true;
            this.btnCascade.Click += new System.EventHandler(this.btnCascade_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(10, 245);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(600, 25);
            this.btnDouble.TabIndex = 3;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(10, 280);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(300, 25);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSecond
            // 
            this.btnSecond.Location = new System.Drawing.Point(310, 280);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(300, 25);
            this.btnSecond.TabIndex = 5;
            this.btnSecond.Text = "Second";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // btnFirst1stHalf
            // 
            this.btnFirst1stHalf.Location = new System.Drawing.Point(10, 315);
            this.btnFirst1stHalf.Name = "btnFirst1stHalf";
            this.btnFirst1stHalf.Size = new System.Drawing.Size(150, 25);
            this.btnFirst1stHalf.TabIndex = 6;
            this.btnFirst1stHalf.Text = "First 1st Half";
            this.btnFirst1stHalf.UseVisualStyleBackColor = true;
            this.btnFirst1stHalf.Click += new System.EventHandler(this.btnFirst1stHalf_Click);
            // 
            // btnFirst2ndHalf
            // 
            this.btnFirst2ndHalf.Location = new System.Drawing.Point(160, 315);
            this.btnFirst2ndHalf.Name = "btnFirst2ndHalf";
            this.btnFirst2ndHalf.Size = new System.Drawing.Size(150, 25);
            this.btnFirst2ndHalf.TabIndex = 7;
            this.btnFirst2ndHalf.Text = "First 2nd Half";
            this.btnFirst2ndHalf.UseVisualStyleBackColor = true;
            this.btnFirst2ndHalf.Click += new System.EventHandler(this.btnFirst2ndHalf_Click);
            // 
            // btnSecond1stHalf
            // 
            this.btnSecond1stHalf.Location = new System.Drawing.Point(310, 315);
            this.btnSecond1stHalf.Name = "btnSecond1stHalf";
            this.btnSecond1stHalf.Size = new System.Drawing.Size(150, 25);
            this.btnSecond1stHalf.TabIndex = 8;
            this.btnSecond1stHalf.Text = "Second 1st Half";
            this.btnSecond1stHalf.UseVisualStyleBackColor = true;
            this.btnSecond1stHalf.Click += new System.EventHandler(this.btnSecond1stHalf_Click);
            // 
            // btnSecond2ndHalf
            // 
            this.btnSecond2ndHalf.Location = new System.Drawing.Point(460, 315);
            this.btnSecond2ndHalf.Name = "btnSecond2ndHalf";
            this.btnSecond2ndHalf.Size = new System.Drawing.Size(150, 25);
            this.btnSecond2ndHalf.TabIndex = 9;
            this.btnSecond2ndHalf.Text = "Second 2nd Half";
            this.btnSecond2ndHalf.UseVisualStyleBackColor = true;
            this.btnSecond2ndHalf.Click += new System.EventHandler(this.btnSecond2ndHalf_Click);
            // 
            // First1stThird
            // 
            this.First1stThird.Location = new System.Drawing.Point(10, 350);
            this.First1stThird.Name = "First1stThird";
            this.First1stThird.Size = new System.Drawing.Size(100, 50);
            this.First1stThird.TabIndex = 10;
            this.First1stThird.Text = "First 1st Third";
            this.First1stThird.UseVisualStyleBackColor = true;
            this.First1stThird.Click += new System.EventHandler(this.First1stThird_Click);
            // 
            // First2ndThird
            // 
            this.First2ndThird.Location = new System.Drawing.Point(110, 350);
            this.First2ndThird.Name = "First2ndThird";
            this.First2ndThird.Size = new System.Drawing.Size(100, 50);
            this.First2ndThird.TabIndex = 11;
            this.First2ndThird.Text = "First 2nd Third";
            this.First2ndThird.UseVisualStyleBackColor = true;
            this.First2ndThird.Click += new System.EventHandler(this.First2ndThird_Click);
            // 
            // First3rdThird
            // 
            this.First3rdThird.Location = new System.Drawing.Point(210, 350);
            this.First3rdThird.Name = "First3rdThird";
            this.First3rdThird.Size = new System.Drawing.Size(100, 50);
            this.First3rdThird.TabIndex = 12;
            this.First3rdThird.Text = "First 3rd Third";
            this.First3rdThird.UseVisualStyleBackColor = true;
            this.First3rdThird.Click += new System.EventHandler(this.First3rdThird_Click);
            // 
            // Second1stThird
            // 
            this.Second1stThird.Location = new System.Drawing.Point(310, 350);
            this.Second1stThird.Name = "Second1stThird";
            this.Second1stThird.Size = new System.Drawing.Size(100, 50);
            this.Second1stThird.TabIndex = 14;
            this.Second1stThird.Text = "Second 1st Third";
            this.Second1stThird.UseVisualStyleBackColor = true;
            this.Second1stThird.Click += new System.EventHandler(this.Second1stThird_Click);
            // 
            // Second2ndThird
            // 
            this.Second2ndThird.Location = new System.Drawing.Point(410, 350);
            this.Second2ndThird.Name = "Second2ndThird";
            this.Second2ndThird.Size = new System.Drawing.Size(100, 50);
            this.Second2ndThird.TabIndex = 15;
            this.Second2ndThird.Text = "Second 2nd Third";
            this.Second2ndThird.UseVisualStyleBackColor = true;
            this.Second2ndThird.Click += new System.EventHandler(this.Second2ndThird_Click);
            // 
            // Second3rdThird
            // 
            this.Second3rdThird.Location = new System.Drawing.Point(510, 350);
            this.Second3rdThird.Name = "Second3rdThird";
            this.Second3rdThird.Size = new System.Drawing.Size(100, 50);
            this.Second3rdThird.TabIndex = 16;
            this.Second3rdThird.Text = "Second 3rd Third";
            this.Second3rdThird.UseVisualStyleBackColor = true;
            this.Second3rdThird.Click += new System.EventHandler(this.Second3rdThird_Click);
            // 
            // btnFirst1stDouble
            // 
            this.btnFirst1stDouble.Location = new System.Drawing.Point(10, 410);
            this.btnFirst1stDouble.Name = "btnFirst1stDouble";
            this.btnFirst1stDouble.Size = new System.Drawing.Size(200, 25);
            this.btnFirst1stDouble.TabIndex = 26;
            this.btnFirst1stDouble.Text = "First 1st Double";
            this.btnFirst1stDouble.UseVisualStyleBackColor = true;
            this.btnFirst1stDouble.Click += new System.EventHandler(this.First1stDouble_Click);
            // 
            // btnFirst2ndDouble
            // 
            this.btnFirst2ndDouble.Location = new System.Drawing.Point(110, 435);
            this.btnFirst2ndDouble.Name = "btnFirst2ndDouble";
            this.btnFirst2ndDouble.Size = new System.Drawing.Size(200, 25);
            this.btnFirst2ndDouble.TabIndex = 27;
            this.btnFirst2ndDouble.Text = "First 2nd Double";
            this.btnFirst2ndDouble.UseVisualStyleBackColor = true;
            this.btnFirst2ndDouble.Click += new System.EventHandler(this.First2ndDouble_Click);
            // 
            // btnSecond1stDouble
            // 
            this.btnSecond1stDouble.Location = new System.Drawing.Point(310, 410);
            this.btnSecond1stDouble.Name = "btnSecond1stDouble";
            this.btnSecond1stDouble.Size = new System.Drawing.Size(200, 25);
            this.btnSecond1stDouble.TabIndex = 28;
            this.btnSecond1stDouble.Text = "Second 1st Double";
            this.btnSecond1stDouble.UseVisualStyleBackColor = true;
            this.btnSecond1stDouble.Click += new System.EventHandler(this.Second1stDouble_Click);
            // 
            // btnSecond2ndDouble
            // 
            this.btnSecond2ndDouble.Location = new System.Drawing.Point(410, 435);
            this.btnSecond2ndDouble.Name = "btnSecond2ndDouble";
            this.btnSecond2ndDouble.Size = new System.Drawing.Size(200, 25);
            this.btnSecond2ndDouble.TabIndex = 29;
            this.btnSecond2ndDouble.Text = "Second 2nd Double";
            this.btnSecond2ndDouble.UseVisualStyleBackColor = true;
            this.btnSecond2ndDouble.Click += new System.EventHandler(this.Second2ndDouble_Click);
            // 
            // First1stQuarter
            // 
            this.First1stQuarter.Location = new System.Drawing.Point(10, 470);
            this.First1stQuarter.Name = "First1stQuarter";
            this.First1stQuarter.Size = new System.Drawing.Size(75, 50);
            this.First1stQuarter.TabIndex = 18;
            this.First1stQuarter.Text = "First 1st Quarter";
            this.First1stQuarter.UseVisualStyleBackColor = true;
            this.First1stQuarter.Click += new System.EventHandler(this.First1stQuarter_Click);
            // 
            // First2ndQuarter
            // 
            this.First2ndQuarter.Location = new System.Drawing.Point(85, 470);
            this.First2ndQuarter.Name = "First2ndQuarter";
            this.First2ndQuarter.Size = new System.Drawing.Size(75, 50);
            this.First2ndQuarter.TabIndex = 19;
            this.First2ndQuarter.Text = "First 2nd Quarter";
            this.First2ndQuarter.UseVisualStyleBackColor = true;
            this.First2ndQuarter.Click += new System.EventHandler(this.First2ndQuarter_Click);
            // 
            // First3rdQuarter
            // 
            this.First3rdQuarter.Location = new System.Drawing.Point(160, 470);
            this.First3rdQuarter.Name = "First3rdQuarter";
            this.First3rdQuarter.Size = new System.Drawing.Size(75, 50);
            this.First3rdQuarter.TabIndex = 20;
            this.First3rdQuarter.Text = "First 3rd Quarter";
            this.First3rdQuarter.UseVisualStyleBackColor = true;
            this.First3rdQuarter.Click += new System.EventHandler(this.First3rdQuarter_Click);
            // 
            // First4thQuarter
            // 
            this.First4thQuarter.Location = new System.Drawing.Point(235, 470);
            this.First4thQuarter.Name = "First4thQuarter";
            this.First4thQuarter.Size = new System.Drawing.Size(75, 50);
            this.First4thQuarter.TabIndex = 21;
            this.First4thQuarter.Text = "First 4th Quarter";
            this.First4thQuarter.UseVisualStyleBackColor = true;
            this.First4thQuarter.Click += new System.EventHandler(this.First4thQuarter_Click);
            // 
            // Second1stQuarter
            // 
            this.Second1stQuarter.Location = new System.Drawing.Point(310, 470);
            this.Second1stQuarter.Name = "Second1stQuarter";
            this.Second1stQuarter.Size = new System.Drawing.Size(75, 50);
            this.Second1stQuarter.TabIndex = 22;
            this.Second1stQuarter.Text = "Second 1st Quarter";
            this.Second1stQuarter.UseVisualStyleBackColor = true;
            this.Second1stQuarter.Click += new System.EventHandler(this.Second1stQuarter_Click);
            // 
            // Second2ndQuarter
            // 
            this.Second2ndQuarter.Location = new System.Drawing.Point(385, 470);
            this.Second2ndQuarter.Name = "Second2ndQuarter";
            this.Second2ndQuarter.Size = new System.Drawing.Size(75, 50);
            this.Second2ndQuarter.TabIndex = 23;
            this.Second2ndQuarter.Text = "Second 2nd Quarter";
            this.Second2ndQuarter.UseVisualStyleBackColor = true;
            this.Second2ndQuarter.Click += new System.EventHandler(this.Second2ndQuarter_Click);
            // 
            // Second3rdQuarter
            // 
            this.Second3rdQuarter.Location = new System.Drawing.Point(460, 470);
            this.Second3rdQuarter.Name = "Second3rdQuarter";
            this.Second3rdQuarter.Size = new System.Drawing.Size(75, 50);
            this.Second3rdQuarter.TabIndex = 24;
            this.Second3rdQuarter.Text = "Second 3rd Quarter";
            this.Second3rdQuarter.UseVisualStyleBackColor = true;
            this.Second3rdQuarter.Click += new System.EventHandler(this.Second3rdQuarter_Click);
            // 
            // Second4thQuarter
            // 
            this.Second4thQuarter.Location = new System.Drawing.Point(535, 470);
            this.Second4thQuarter.Name = "Second4thQuarter";
            this.Second4thQuarter.Size = new System.Drawing.Size(75, 50);
            this.Second4thQuarter.TabIndex = 25;
            this.Second4thQuarter.Text = "Second 4th Quarter";
            this.Second4thQuarter.UseVisualStyleBackColor = true;
            this.Second4thQuarter.Click += new System.EventHandler(this.Second4thQuarter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 530);
            this.Controls.Add(this.btnSecond2ndDouble);
            this.Controls.Add(this.btnSecond1stDouble);
            this.Controls.Add(this.btnFirst2ndDouble);
            this.Controls.Add(this.btnFirst1stDouble);
            this.Controls.Add(this.Second4thQuarter);
            this.Controls.Add(this.Second3rdQuarter);
            this.Controls.Add(this.Second2ndQuarter);
            this.Controls.Add(this.Second1stQuarter);
            this.Controls.Add(this.First4thQuarter);
            this.Controls.Add(this.First3rdQuarter);
            this.Controls.Add(this.First2ndQuarter);
            this.Controls.Add(this.First1stQuarter);
            this.Controls.Add(this.Second3rdThird);
            this.Controls.Add(this.Second2ndThird);
            this.Controls.Add(this.Second1stThird);
            this.Controls.Add(this.First3rdThird);
            this.Controls.Add(this.First2ndThird);
            this.Controls.Add(this.First1stThird);
            this.Controls.Add(this.btnSecond2ndHalf);
            this.Controls.Add(this.btnSecond1stHalf);
            this.Controls.Add(this.btnFirst2ndHalf);
            this.Controls.Add(this.btnFirst1stHalf);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnCascade);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstProcesses);
            this.Controls.Add(this.lblProcesses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcesses;
        private System.Windows.Forms.ListBox lstProcesses;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCascade;

        private System.Windows.Forms.Button btnDouble;

        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSecond;

        private System.Windows.Forms.Button btnFirst1stHalf;
        private System.Windows.Forms.Button btnFirst2ndHalf;
        private System.Windows.Forms.Button btnSecond1stHalf;
        private System.Windows.Forms.Button btnSecond2ndHalf;

        private System.Windows.Forms.Button First1stThird;
        private System.Windows.Forms.Button First2ndThird;
        private System.Windows.Forms.Button First3rdThird;
        private System.Windows.Forms.Button Second1stThird;
        private System.Windows.Forms.Button Second2ndThird;
        private System.Windows.Forms.Button Second3rdThird;

        private System.Windows.Forms.Button btnFirst1stDouble;
        private System.Windows.Forms.Button btnFirst2ndDouble;
        private System.Windows.Forms.Button btnSecond1stDouble;
        private System.Windows.Forms.Button btnSecond2ndDouble;

        private System.Windows.Forms.Button First1stQuarter;
        private System.Windows.Forms.Button First2ndQuarter;
        private System.Windows.Forms.Button First3rdQuarter;
        private System.Windows.Forms.Button First4thQuarter;
        private System.Windows.Forms.Button Second1stQuarter;
        private System.Windows.Forms.Button Second2ndQuarter;
        private System.Windows.Forms.Button Second3rdQuarter;
        private System.Windows.Forms.Button Second4thQuarter;
    }
}

