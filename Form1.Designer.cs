namespace AllDice
{
    partial class AllDice
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.roll = new System.Windows.Forms.Button();
            this.D4 = new System.Windows.Forms.Label();
            this.D6 = new System.Windows.Forms.Label();
            this.D8 = new System.Windows.Forms.Label();
            this.D10 = new System.Windows.Forms.Label();
            this.D12 = new System.Windows.Forms.Label();
            this.D20 = new System.Windows.Forms.Label();
            this.num4 = new System.Windows.Forms.NumericUpDown();
            this.num6 = new System.Windows.Forms.NumericUpDown();
            this.num8 = new System.Windows.Forms.NumericUpDown();
            this.num10 = new System.Windows.Forms.NumericUpDown();
            this.num12 = new System.Windows.Forms.NumericUpDown();
            this.num20 = new System.Windows.Forms.NumericUpDown();
            this.totalAll = new System.Windows.Forms.Label();
            this.total4 = new System.Windows.Forms.Label();
            this.total6 = new System.Windows.Forms.Label();
            this.total8 = new System.Windows.Forms.Label();
            this.total10 = new System.Windows.Forms.Label();
            this.total12 = new System.Windows.Forms.Label();
            this.total20 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.ButtonInfo = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num20)).BeginInit();
            this.SuspendLayout();
            // 
            // roll
            // 
            this.roll.BackColor = System.Drawing.Color.Gray;
            this.roll.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roll.Location = new System.Drawing.Point(140, 320);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(160, 75);
            this.roll.TabIndex = 0;
            this.roll.Text = "ROLL";
            this.roll.UseVisualStyleBackColor = false;
            this.roll.Click += new System.EventHandler(this.roll_Click);
            // 
            // D4
            // 
            this.D4.AutoSize = true;
            this.D4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.D4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D4.ForeColor = System.Drawing.Color.DimGray;
            this.D4.Location = new System.Drawing.Point(100, 120);
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(37, 23);
            this.D4.TabIndex = 1;
            this.D4.Text = "D4";
            this.D4.Click += new System.EventHandler(this.D4_Click);
            // 
            // D6
            // 
            this.D6.AutoSize = true;
            this.D6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.D6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D6.ForeColor = System.Drawing.Color.DimGray;
            this.D6.Location = new System.Drawing.Point(100, 170);
            this.D6.Name = "D6";
            this.D6.Size = new System.Drawing.Size(37, 23);
            this.D6.TabIndex = 2;
            this.D6.Text = "D6";
            this.D6.Click += new System.EventHandler(this.D6_Click);
            // 
            // D8
            // 
            this.D8.AutoSize = true;
            this.D8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.D8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D8.ForeColor = System.Drawing.Color.DimGray;
            this.D8.Location = new System.Drawing.Point(100, 220);
            this.D8.Name = "D8";
            this.D8.Size = new System.Drawing.Size(37, 23);
            this.D8.TabIndex = 3;
            this.D8.Text = "D8";
            this.D8.Click += new System.EventHandler(this.D8_Click);
            // 
            // D10
            // 
            this.D10.AutoSize = true;
            this.D10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.D10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D10.ForeColor = System.Drawing.Color.DimGray;
            this.D10.Location = new System.Drawing.Point(380, 120);
            this.D10.Name = "D10";
            this.D10.Size = new System.Drawing.Size(49, 23);
            this.D10.TabIndex = 4;
            this.D10.Text = "D10";
            this.D10.Click += new System.EventHandler(this.label4_Click);
            // 
            // D12
            // 
            this.D12.AutoSize = true;
            this.D12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.D12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D12.ForeColor = System.Drawing.Color.DimGray;
            this.D12.Location = new System.Drawing.Point(380, 170);
            this.D12.Name = "D12";
            this.D12.Size = new System.Drawing.Size(49, 23);
            this.D12.TabIndex = 5;
            this.D12.Text = "D12";
            this.D12.Click += new System.EventHandler(this.D12_Click);
            // 
            // D20
            // 
            this.D20.AutoSize = true;
            this.D20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.D20.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D20.ForeColor = System.Drawing.Color.DimGray;
            this.D20.Location = new System.Drawing.Point(380, 220);
            this.D20.Name = "D20";
            this.D20.Size = new System.Drawing.Size(49, 23);
            this.D20.TabIndex = 6;
            this.D20.Text = "D20";
            this.D20.Click += new System.EventHandler(this.D20_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num4.ForeColor = System.Drawing.Color.Black;
            this.num4.Location = new System.Drawing.Point(170, 120);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(60, 27);
            this.num4.TabIndex = 7;
            this.num4.ValueChanged += new System.EventHandler(this.num4_ValueChanged);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num6.ForeColor = System.Drawing.Color.Black;
            this.num6.Location = new System.Drawing.Point(170, 170);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(60, 27);
            this.num6.TabIndex = 8;
            this.num6.ValueChanged += new System.EventHandler(this.num6_ValueChanged);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num8.ForeColor = System.Drawing.Color.Black;
            this.num8.Location = new System.Drawing.Point(170, 220);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(60, 27);
            this.num8.TabIndex = 9;
            this.num8.ValueChanged += new System.EventHandler(this.num8_ValueChanged);
            // 
            // num10
            // 
            this.num10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num10.ForeColor = System.Drawing.Color.Black;
            this.num10.Location = new System.Drawing.Point(460, 120);
            this.num10.Name = "num10";
            this.num10.Size = new System.Drawing.Size(60, 27);
            this.num10.TabIndex = 10;
            this.num10.ValueChanged += new System.EventHandler(this.num10_ValueChanged);
            // 
            // num12
            // 
            this.num12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num12.ForeColor = System.Drawing.Color.Black;
            this.num12.Location = new System.Drawing.Point(460, 170);
            this.num12.Name = "num12";
            this.num12.Size = new System.Drawing.Size(60, 27);
            this.num12.TabIndex = 11;
            this.num12.ValueChanged += new System.EventHandler(this.num12_ValueChanged);
            // 
            // num20
            // 
            this.num20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num20.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num20.ForeColor = System.Drawing.Color.Black;
            this.num20.Location = new System.Drawing.Point(460, 220);
            this.num20.Name = "num20";
            this.num20.Size = new System.Drawing.Size(60, 27);
            this.num20.TabIndex = 12;
            this.num20.ValueChanged += new System.EventHandler(this.num20_ValueChanged);
            // 
            // totalAll
            // 
            this.totalAll.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalAll.ForeColor = System.Drawing.Color.Black;
            this.totalAll.Location = new System.Drawing.Point(490, 320);
            this.totalAll.Name = "totalAll";
            this.totalAll.Size = new System.Drawing.Size(160, 75);
            this.totalAll.TabIndex = 14;
            this.totalAll.Text = "000";
            this.totalAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalAll.Click += new System.EventHandler(this.totalAll_Click);
            // 
            // total4
            // 
            this.total4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total4.ForeColor = System.Drawing.Color.Black;
            this.total4.Location = new System.Drawing.Point(260, 120);
            this.total4.Name = "total4";
            this.total4.Size = new System.Drawing.Size(60, 27);
            this.total4.TabIndex = 15;
            this.total4.Text = "000";
            this.total4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.total4.Click += new System.EventHandler(this.total4_Click);
            // 
            // total6
            // 
            this.total6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total6.ForeColor = System.Drawing.Color.Black;
            this.total6.Location = new System.Drawing.Point(260, 170);
            this.total6.Name = "total6";
            this.total6.Size = new System.Drawing.Size(60, 27);
            this.total6.TabIndex = 16;
            this.total6.Text = "000";
            this.total6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.total6.Click += new System.EventHandler(this.total6_Click);
            // 
            // total8
            // 
            this.total8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total8.ForeColor = System.Drawing.Color.Black;
            this.total8.Location = new System.Drawing.Point(260, 220);
            this.total8.Name = "total8";
            this.total8.Size = new System.Drawing.Size(60, 27);
            this.total8.TabIndex = 17;
            this.total8.Text = "000";
            this.total8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.total8.Click += new System.EventHandler(this.total8_Click);
            // 
            // total10
            // 
            this.total10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total10.ForeColor = System.Drawing.Color.Black;
            this.total10.Location = new System.Drawing.Point(550, 120);
            this.total10.Name = "total10";
            this.total10.Size = new System.Drawing.Size(60, 27);
            this.total10.TabIndex = 18;
            this.total10.Text = "000";
            this.total10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.total10.Click += new System.EventHandler(this.total10_Click);
            // 
            // total12
            // 
            this.total12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total12.ForeColor = System.Drawing.Color.Black;
            this.total12.Location = new System.Drawing.Point(550, 170);
            this.total12.Name = "total12";
            this.total12.Size = new System.Drawing.Size(60, 27);
            this.total12.TabIndex = 19;
            this.total12.Text = "000";
            this.total12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.total12.Click += new System.EventHandler(this.total12_Click);
            // 
            // total20
            // 
            this.total20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total20.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total20.ForeColor = System.Drawing.Color.Black;
            this.total20.Location = new System.Drawing.Point(550, 220);
            this.total20.Name = "total20";
            this.total20.Size = new System.Drawing.Size(60, 27);
            this.total20.TabIndex = 20;
            this.total20.Text = "000";
            this.total20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.total20.Click += new System.EventHandler(this.total20_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTotal.Location = new System.Drawing.Point(380, 350);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(90, 30);
            this.txtTotal.TabIndex = 21;
            this.txtTotal.Text = "TOTAL:";
            this.txtTotal.Click += new System.EventHandler(this.txtTotal_Click);
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.AutoSize = true;
            this.ButtonInfo.BackColor = System.Drawing.Color.Transparent;
            this.ButtonInfo.Font = new System.Drawing.Font("Webdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ButtonInfo.ForeColor = System.Drawing.Color.DimGray;
            this.ButtonInfo.Location = new System.Drawing.Point(670, 10);
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.Size = new System.Drawing.Size(50, 40);
            this.ButtonInfo.TabIndex = 22;
            this.ButtonInfo.Text = "i";
            this.ButtonInfo.UseVisualStyleBackColor = false;
            this.ButtonInfo.Click += new System.EventHandler(this.info_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(140, 420);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(160, 50);
            this.reset.TabIndex = 23;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // AllDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.ButtonInfo);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.total20);
            this.Controls.Add(this.total12);
            this.Controls.Add(this.total10);
            this.Controls.Add(this.total8);
            this.Controls.Add(this.total6);
            this.Controls.Add(this.total4);
            this.Controls.Add(this.totalAll);
            this.Controls.Add(this.num20);
            this.Controls.Add(this.num12);
            this.Controls.Add(this.num10);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.D20);
            this.Controls.Add(this.D12);
            this.Controls.Add(this.D10);
            this.Controls.Add(this.D8);
            this.Controls.Add(this.D6);
            this.Controls.Add(this.D4);
            this.Controls.Add(this.roll);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AllDice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button roll;
        private System.Windows.Forms.Label D4;
        private System.Windows.Forms.Label D6;
        private System.Windows.Forms.Label D8;
        private System.Windows.Forms.Label D10;
        private System.Windows.Forms.Label D12;
        private System.Windows.Forms.Label D20;
        private System.Windows.Forms.NumericUpDown num4;
        private System.Windows.Forms.NumericUpDown num6;
        private System.Windows.Forms.NumericUpDown num8;
        private System.Windows.Forms.NumericUpDown num10;
        private System.Windows.Forms.NumericUpDown num12;
        private System.Windows.Forms.NumericUpDown num20;
        private System.Windows.Forms.Label totalAll;
        private System.Windows.Forms.Label total4;
        private System.Windows.Forms.Label total6;
        private System.Windows.Forms.Label total8;
        private System.Windows.Forms.Label total10;
        private System.Windows.Forms.Label total12;
        private System.Windows.Forms.Label total20;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Button ButtonInfo;
        private System.Windows.Forms.Button reset;
    }
}

