
namespace Tic_Tac_Toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Xlabel = new System.Windows.Forms.Label();
            this.XAmount = new System.Windows.Forms.Label();
            this.OAmount = new System.Windows.Forms.Label();
            this.Olabel = new System.Windows.Forms.Label();
            this.Drawslabel = new System.Windows.Forms.Label();
            this.drawsAmount = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.A00 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xlabel.Location = new System.Drawing.Point(52, 11);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(26, 20);
            this.Xlabel.TabIndex = 0;
            this.Xlabel.Text = "X:";
            // 
            // XAmount
            // 
            this.XAmount.AutoSize = true;
            this.XAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XAmount.Location = new System.Drawing.Point(84, 11);
            this.XAmount.Name = "XAmount";
            this.XAmount.Size = new System.Drawing.Size(19, 20);
            this.XAmount.TabIndex = 1;
            this.XAmount.Text = "0";
            // 
            // OAmount
            // 
            this.OAmount.AutoSize = true;
            this.OAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OAmount.Location = new System.Drawing.Point(237, 11);
            this.OAmount.Name = "OAmount";
            this.OAmount.Size = new System.Drawing.Size(19, 20);
            this.OAmount.TabIndex = 2;
            this.OAmount.Text = "0";
            // 
            // Olabel
            // 
            this.Olabel.AutoSize = true;
            this.Olabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Olabel.Location = new System.Drawing.Point(203, 11);
            this.Olabel.Name = "Olabel";
            this.Olabel.Size = new System.Drawing.Size(27, 20);
            this.Olabel.TabIndex = 3;
            this.Olabel.Text = "O:";
            // 
            // Drawslabel
            // 
            this.Drawslabel.AutoSize = true;
            this.Drawslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drawslabel.Location = new System.Drawing.Point(353, 9);
            this.Drawslabel.Name = "Drawslabel";
            this.Drawslabel.Size = new System.Drawing.Size(64, 20);
            this.Drawslabel.TabIndex = 4;
            this.Drawslabel.Text = "Draws:";
            // 
            // drawsAmount
            // 
            this.drawsAmount.AutoSize = true;
            this.drawsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawsAmount.Location = new System.Drawing.Point(423, 9);
            this.drawsAmount.Name = "drawsAmount";
            this.drawsAmount.Size = new System.Drawing.Size(19, 20);
            this.drawsAmount.TabIndex = 5;
            this.drawsAmount.Text = "0";
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(12, 417);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(460, 32);
            this.newGameButton.TabIndex = 6;
            this.newGameButton.Text = "New game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(50, 50);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(100, 100);
            this.A00.TabIndex = 7;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.buttionClick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(200, 50);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(100, 100);
            this.A01.TabIndex = 8;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.buttionClick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(350, 50);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(100, 100);
            this.A02.TabIndex = 9;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.buttionClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(200, 175);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(100, 100);
            this.A11.TabIndex = 10;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.buttionClick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(50, 175);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(100, 100);
            this.A10.TabIndex = 11;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.buttionClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(350, 175);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(100, 100);
            this.A12.TabIndex = 12;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.buttionClick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(50, 300);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(100, 100);
            this.A20.TabIndex = 13;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.buttionClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(200, 300);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(100, 100);
            this.A21.TabIndex = 14;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.buttionClick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(350, 300);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(100, 100);
            this.A22.TabIndex = 15;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.buttionClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A00);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.drawsAmount);
            this.Controls.Add(this.Drawslabel);
            this.Controls.Add(this.Olabel);
            this.Controls.Add(this.OAmount);
            this.Controls.Add(this.XAmount);
            this.Controls.Add(this.Xlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Label XAmount;
        private System.Windows.Forms.Label OAmount;
        private System.Windows.Forms.Label Olabel;
        private System.Windows.Forms.Label Drawslabel;
        private System.Windows.Forms.Label drawsAmount;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A22;
    }
}

