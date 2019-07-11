namespace ParticleFilterTraking
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fieldWidthBox = new System.Windows.Forms.NumericUpDown();
            this.fieldHeightBox = new System.Windows.Forms.NumericUpDown();
            this.objectSizeBox = new System.Windows.Forms.NumericUpDown();
            this.particleCountBox = new System.Windows.Forms.NumericUpDown();
            this.observationWrongProbabilityBar = new System.Windows.Forms.TrackBar();
            this.minimumParticleCountBox = new System.Windows.Forms.NumericUpDown();
            this.minimumPaticleCountLabel = new System.Windows.Forms.Label();
            this.particleDecreaseRateTrackBar = new System.Windows.Forms.TrackBar();
            this.particleDecreaseRateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldWidthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectSizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particleCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observationWrongProbabilityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumParticleCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particleDecreaseRateTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(12, 43);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(806, 577);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // notificationLabel
            // 
            this.notificationLabel.AutoSize = true;
            this.notificationLabel.Location = new System.Drawing.Point(12, 17);
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(89, 12);
            this.notificationLabel.TabIndex = 1;
            this.notificationLabel.Text = "notificationLabel";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(632, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(713, 12);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(839, 597);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(145, 23);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Apply Above Settings";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(838, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Field width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(838, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Field height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(837, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Object size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(838, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Particle count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(837, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Observation wrong probability (%)";
            // 
            // fieldWidthBox
            // 
            this.fieldWidthBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fieldWidthBox.Location = new System.Drawing.Point(840, 60);
            this.fieldWidthBox.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.fieldWidthBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.fieldWidthBox.Name = "fieldWidthBox";
            this.fieldWidthBox.Size = new System.Drawing.Size(120, 19);
            this.fieldWidthBox.TabIndex = 14;
            this.fieldWidthBox.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // fieldHeightBox
            // 
            this.fieldHeightBox.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fieldHeightBox.Location = new System.Drawing.Point(839, 109);
            this.fieldHeightBox.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.fieldHeightBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.fieldHeightBox.Name = "fieldHeightBox";
            this.fieldHeightBox.Size = new System.Drawing.Size(120, 19);
            this.fieldHeightBox.TabIndex = 15;
            this.fieldHeightBox.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // objectSizeBox
            // 
            this.objectSizeBox.Location = new System.Drawing.Point(839, 169);
            this.objectSizeBox.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.objectSizeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.objectSizeBox.Name = "objectSizeBox";
            this.objectSizeBox.Size = new System.Drawing.Size(120, 19);
            this.objectSizeBox.TabIndex = 16;
            this.objectSizeBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // particleCountBox
            // 
            this.particleCountBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.particleCountBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.particleCountBox.Location = new System.Drawing.Point(839, 231);
            this.particleCountBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.particleCountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.particleCountBox.Name = "particleCountBox";
            this.particleCountBox.Size = new System.Drawing.Size(120, 19);
            this.particleCountBox.TabIndex = 17;
            this.particleCountBox.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // observationWrongProbabilityBar
            // 
            this.observationWrongProbabilityBar.Location = new System.Drawing.Point(839, 297);
            this.observationWrongProbabilityBar.Maximum = 100;
            this.observationWrongProbabilityBar.Name = "observationWrongProbabilityBar";
            this.observationWrongProbabilityBar.Size = new System.Drawing.Size(145, 45);
            this.observationWrongProbabilityBar.TabIndex = 19;
            this.observationWrongProbabilityBar.TickFrequency = 10;
            this.observationWrongProbabilityBar.Value = 20;
            // 
            // minimumParticleCountBox
            // 
            this.minimumParticleCountBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.minimumParticleCountBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.minimumParticleCountBox.Location = new System.Drawing.Point(838, 360);
            this.minimumParticleCountBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.minimumParticleCountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minimumParticleCountBox.Name = "minimumParticleCountBox";
            this.minimumParticleCountBox.Size = new System.Drawing.Size(120, 19);
            this.minimumParticleCountBox.TabIndex = 21;
            this.minimumParticleCountBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // minimumPaticleCountLabel
            // 
            this.minimumPaticleCountLabel.AutoSize = true;
            this.minimumPaticleCountLabel.Location = new System.Drawing.Point(837, 345);
            this.minimumPaticleCountLabel.Name = "minimumPaticleCountLabel";
            this.minimumPaticleCountLabel.Size = new System.Drawing.Size(125, 12);
            this.minimumPaticleCountLabel.TabIndex = 20;
            this.minimumPaticleCountLabel.Text = "Minimum Particle count";
            // 
            // particleDecreaseRateTrackBar
            // 
            this.particleDecreaseRateTrackBar.Location = new System.Drawing.Point(838, 410);
            this.particleDecreaseRateTrackBar.Maximum = 100;
            this.particleDecreaseRateTrackBar.Name = "particleDecreaseRateTrackBar";
            this.particleDecreaseRateTrackBar.Size = new System.Drawing.Size(145, 45);
            this.particleDecreaseRateTrackBar.TabIndex = 23;
            this.particleDecreaseRateTrackBar.TickFrequency = 10;
            this.particleDecreaseRateTrackBar.Value = 95;
            // 
            // particleDecreaseRateLabel
            // 
            this.particleDecreaseRateLabel.AutoSize = true;
            this.particleDecreaseRateLabel.Location = new System.Drawing.Point(836, 395);
            this.particleDecreaseRateLabel.Name = "particleDecreaseRateLabel";
            this.particleDecreaseRateLabel.Size = new System.Drawing.Size(136, 12);
            this.particleDecreaseRateLabel.TabIndex = 22;
            this.particleDecreaseRateLabel.Text = "Particle decrease rate (%)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 632);
            this.Controls.Add(this.particleDecreaseRateTrackBar);
            this.Controls.Add(this.particleDecreaseRateLabel);
            this.Controls.Add(this.minimumParticleCountBox);
            this.Controls.Add(this.minimumPaticleCountLabel);
            this.Controls.Add(this.observationWrongProbabilityBar);
            this.Controls.Add(this.particleCountBox);
            this.Controls.Add(this.objectSizeBox);
            this.Controls.Add(this.fieldHeightBox);
            this.Controls.Add(this.fieldWidthBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "ParticleFilterTraking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldWidthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectSizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particleCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observationWrongProbabilityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumParticleCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particleDecreaseRateTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown fieldWidthBox;
        private System.Windows.Forms.NumericUpDown fieldHeightBox;
        private System.Windows.Forms.NumericUpDown objectSizeBox;
        private System.Windows.Forms.NumericUpDown particleCountBox;
        private System.Windows.Forms.TrackBar observationWrongProbabilityBar;
        private System.Windows.Forms.NumericUpDown minimumParticleCountBox;
        private System.Windows.Forms.Label minimumPaticleCountLabel;
        private System.Windows.Forms.TrackBar particleDecreaseRateTrackBar;
        private System.Windows.Forms.Label particleDecreaseRateLabel;
    }
}

