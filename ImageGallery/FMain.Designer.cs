
namespace ImageGallery
{
    partial class FMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btOpen = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btZoom = new System.Windows.Forms.Button();
            this.btSmall = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btLeftMove = new System.Windows.Forms.Button();
            this.btRightMove = new System.Windows.Forms.Button();
            this.btFullScreen = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pnControls = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.64247F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.35753F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnControls, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.87716F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.12284F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(923, 412);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.btOpen);
            this.flowLayoutPanel1.Controls.Add(this.btClear);
            this.flowLayoutPanel1.Controls.Add(this.btPrev);
            this.flowLayoutPanel1.Controls.Add(this.btNext);
            this.flowLayoutPanel1.Controls.Add(this.btZoom);
            this.flowLayoutPanel1.Controls.Add(this.btSmall);
            this.flowLayoutPanel1.Controls.Add(this.btSave);
            this.flowLayoutPanel1.Controls.Add(this.btClose);
            this.flowLayoutPanel1.Controls.Add(this.btLeftMove);
            this.flowLayoutPanel1.Controls.Add(this.btRightMove);
            this.flowLayoutPanel1.Controls.Add(this.btFullScreen);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 348);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(917, 61);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btOpen
            // 
            this.btOpen.AutoSize = true;
            this.btOpen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btOpen.Location = new System.Drawing.Point(3, 3);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "Відкрити";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btClear
            // 
            this.btClear.AutoSize = true;
            this.btClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClear.Location = new System.Drawing.Point(84, 3);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(113, 23);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "Очистити малюнок";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btPrev
            // 
            this.btPrev.AutoSize = true;
            this.btPrev.Dock = System.Windows.Forms.DockStyle.Right;
            this.btPrev.Location = new System.Drawing.Point(203, 3);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(75, 23);
            this.btPrev.TabIndex = 3;
            this.btPrev.Text = "<<";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btNext
            // 
            this.btNext.AutoSize = true;
            this.btNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btNext.Location = new System.Drawing.Point(284, 3);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 4;
            this.btNext.Text = ">>";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btZoom
            // 
            this.btZoom.AutoSize = true;
            this.btZoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.btZoom.Location = new System.Drawing.Point(365, 3);
            this.btZoom.Name = "btZoom";
            this.btZoom.Size = new System.Drawing.Size(75, 23);
            this.btZoom.TabIndex = 5;
            this.btZoom.Text = "Збільшити";
            this.btZoom.UseVisualStyleBackColor = true;
            this.btZoom.Click += new System.EventHandler(this.btZoom_Click);
            // 
            // btSmall
            // 
            this.btSmall.AutoSize = true;
            this.btSmall.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSmall.Location = new System.Drawing.Point(446, 3);
            this.btSmall.Name = "btSmall";
            this.btSmall.Size = new System.Drawing.Size(110, 23);
            this.btSmall.TabIndex = 6;
            this.btSmall.Text = "Зменшити";
            this.btSmall.UseVisualStyleBackColor = true;
            this.btSmall.Click += new System.EventHandler(this.btSmall_Click);
            // 
            // btSave
            // 
            this.btSave.AutoSize = true;
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.Location = new System.Drawing.Point(562, 3);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Зберегти";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.AutoSize = true;
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.Location = new System.Drawing.Point(643, 3);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 9;
            this.btClose.Text = "Закрити";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btLeftMove
            // 
            this.btLeftMove.AutoSize = true;
            this.btLeftMove.Location = new System.Drawing.Point(724, 3);
            this.btLeftMove.Name = "btLeftMove";
            this.btLeftMove.Size = new System.Drawing.Size(75, 23);
            this.btLeftMove.TabIndex = 12;
            this.btLeftMove.Text = "↩";
            this.btLeftMove.UseVisualStyleBackColor = true;
            this.btLeftMove.Click += new System.EventHandler(this.btLeftMove_Click);
            // 
            // btRightMove
            // 
            this.btRightMove.AutoSize = true;
            this.btRightMove.Location = new System.Drawing.Point(805, 3);
            this.btRightMove.Name = "btRightMove";
            this.btRightMove.Size = new System.Drawing.Size(75, 23);
            this.btRightMove.TabIndex = 13;
            this.btRightMove.Text = "↪";
            this.btRightMove.UseVisualStyleBackColor = true;
            this.btRightMove.Click += new System.EventHandler(this.btRightMove_Click);
            // 
            // btFullScreen
            // 
            this.btFullScreen.AutoSize = true;
            this.btFullScreen.Location = new System.Drawing.Point(3, 32);
            this.btFullScreen.Name = "btFullScreen";
            this.btFullScreen.Size = new System.Drawing.Size(905, 23);
            this.btFullScreen.TabIndex = 14;
            this.btFullScreen.Text = "На весь екран";
            this.btFullScreen.UseVisualStyleBackColor = true;
            this.btFullScreen.Click += new System.EventHandler(this.btFullScreen_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(92, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(828, 339);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // pnControls
            // 
            this.pnControls.AutoScroll = true;
            this.pnControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControls.Location = new System.Drawing.Point(3, 3);
            this.pnControls.Name = "pnControls";
            this.pnControls.Size = new System.Drawing.Size(83, 339);
            this.pnControls.TabIndex = 2;
            this.pnControls.TabStop = true;
            this.pnControls.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnControls_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 412);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Галерея";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btZoom;
        private System.Windows.Forms.Button btSmall;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel pnControls;
        private System.Windows.Forms.Button btLeftMove;
        private System.Windows.Forms.Button btRightMove;
        private System.Windows.Forms.Button btFullScreen;
    }
}

