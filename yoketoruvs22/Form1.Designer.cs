
namespace yoketoruvs22
{
    partial class Form1
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
            this.titlelabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.scorelabel = new System.Windows.Forms.Label();
            this.copylabel = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gameoverlabel = new System.Windows.Forms.Label();
            this.toTitleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Yu Gothic UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titlelabel.ForeColor = System.Drawing.Color.Coral;
            this.titlelabel.Location = new System.Drawing.Point(204, 90);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titlelabel.Size = new System.Drawing.Size(393, 89);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "よけとる2022";
            this.titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.startButton.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(282, 279);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(237, 80);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "スタート!!";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scorelabel.Location = new System.Drawing.Point(282, 201);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(237, 45);
            this.scorelabel.TabIndex = 2;
            this.scorelabel.Text = "High Score 100";
            // 
            // copylabel
            // 
            this.copylabel.AutoSize = true;
            this.copylabel.Font = new System.Drawing.Font("Yu Gothic UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copylabel.Location = new System.Drawing.Point(238, 410);
            this.copylabel.Name = "copylabel";
            this.copylabel.Size = new System.Drawing.Size(324, 31);
            this.copylabel.TabIndex = 3;
            this.copylabel.Text = "Copyright©2022　ショウズイケン";
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timelabel.Location = new System.Drawing.Point(13, 13);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(149, 45);
            this.timelabel.TabIndex = 4;
            this.timelabel.Text = "Time 100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(670, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "★：10";
            // 
            // gameoverlabel
            // 
            this.gameoverlabel.AutoSize = true;
            this.gameoverlabel.BackColor = System.Drawing.SystemColors.Control;
            this.gameoverlabel.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameoverlabel.ForeColor = System.Drawing.Color.Crimson;
            this.gameoverlabel.Location = new System.Drawing.Point(435, 232);
            this.gameoverlabel.Name = "gameoverlabel";
            this.gameoverlabel.Size = new System.Drawing.Size(368, 86);
            this.gameoverlabel.TabIndex = 6;
            this.gameoverlabel.Text = "GAMEOVER";
            // 
            // toTitleButton
            // 
            this.toTitleButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.toTitleButton.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toTitleButton.Location = new System.Drawing.Point(453, 327);
            this.toTitleButton.Name = "toTitleButton";
            this.toTitleButton.Size = new System.Drawing.Size(237, 80);
            this.toTitleButton.TabIndex = 7;
            this.toTitleButton.Text = "タイトルへ";
            this.toTitleButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toTitleButton);
            this.Controls.Add(this.gameoverlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.copylabel);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titlelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Label copylabel;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gameoverlabel;
        private System.Windows.Forms.Button toTitleButton;
    }
}

