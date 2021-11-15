namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.currentTempOutput = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.conditionPicLabel = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.citySearchBar = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.conditionPicLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(9, 29);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(226, 31);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(172, 179);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(40, 30);
            this.maxOutput.TabIndex = 32;
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(175, 159);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(34, 15);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "High:";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(36, 179);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(40, 30);
            this.minOutput.TabIndex = 30;
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(40, 159);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(32, 15);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "Low:";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(131, 136);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(192, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(55, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // currentTempOutput
            // 
            this.currentTempOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentTempOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentTempOutput.Font = new System.Drawing.Font("Oswald", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTempOutput.ForeColor = System.Drawing.Color.White;
            this.currentTempOutput.Location = new System.Drawing.Point(103, 55);
            this.currentTempOutput.Name = "currentTempOutput";
            this.currentTempOutput.Size = new System.Drawing.Size(56, 44);
            this.currentTempOutput.TabIndex = 43;
            this.currentTempOutput.Text = "1";
            this.currentTempOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date2
            // 
            this.date2.BackColor = System.Drawing.Color.Transparent;
            this.date2.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.ForeColor = System.Drawing.Color.White;
            this.date2.Location = new System.Drawing.Point(3, 100);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(244, 36);
            this.date2.TabIndex = 44;
            this.date2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // conditionLabel
            // 
            this.conditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conditionLabel.Font = new System.Drawing.Font("Oswald", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.ForeColor = System.Drawing.Color.White;
            this.conditionLabel.Location = new System.Drawing.Point(35, 295);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(171, 36);
            this.conditionLabel.TabIndex = 45;
            this.conditionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // conditionPicLabel
            // 
            this.conditionPicLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionPicLabel.Location = new System.Drawing.Point(53, 334);
            this.conditionPicLabel.Name = "conditionPicLabel";
            this.conditionPicLabel.Size = new System.Drawing.Size(138, 66);
            this.conditionPicLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.conditionPicLabel.TabIndex = 48;
            this.conditionPicLabel.TabStop = false;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Oswald", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(86, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(83, 28);
            this.timeLabel.TabIndex = 49;
            this.timeLabel.Text = "Time";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // citySearchBar
            // 
            this.citySearchBar.Location = new System.Drawing.Point(27, 235);
            this.citySearchBar.Name = "citySearchBar";
            this.citySearchBar.Size = new System.Drawing.Size(147, 20);
            this.citySearchBar.TabIndex = 50;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(160, 233);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 51;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.backclear;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.citySearchBar);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.conditionPicLabel);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.currentTempOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentOutput);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(250, 400);
            this.Load += new System.EventHandler(this.CurrentScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conditionPicLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label currentTempOutput;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.PictureBox conditionPicLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox citySearchBar;
        private System.Windows.Forms.Button searchButton;
    }
}
