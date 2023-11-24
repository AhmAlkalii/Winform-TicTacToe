﻿namespace tictactoe
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.A1 = new System.Windows.Forms.Button();
			this.A2 = new System.Windows.Forms.Button();
			this.A3 = new System.Windows.Forms.Button();
			this.B1 = new System.Windows.Forms.Button();
			this.B2 = new System.Windows.Forms.Button();
			this.B3 = new System.Windows.Forms.Button();
			this.C1 = new System.Windows.Forms.Button();
			this.C2 = new System.Windows.Forms.Button();
			this.C3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.x_count = new System.Windows.Forms.Label();
			this.o_count = new System.Windows.Forms.Label();
			this.draw_count = new System.Windows.Forms.Label();
			this.resetWinCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(433, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.resetWinCountToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
			this.newGameToolStripMenuItem.Text = "New Game";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 32);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// A1
			// 
			this.A1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A1.Location = new System.Drawing.Point(11, 46);
			this.A1.Name = "A1";
			this.A1.Size = new System.Drawing.Size(139, 115);
			this.A1.TabIndex = 1;
			this.A1.UseVisualStyleBackColor = false;
			this.A1.Click += new System.EventHandler(this.button_click);
			this.A1.MouseEnter += new System.EventHandler(this.button_enter);
			this.A1.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// A2
			// 
			this.A2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A2.Location = new System.Drawing.Point(147, 46);
			this.A2.Name = "A2";
			this.A2.Size = new System.Drawing.Size(139, 115);
			this.A2.TabIndex = 2;
			this.A2.UseVisualStyleBackColor = false;
			this.A2.Click += new System.EventHandler(this.button_click);
			this.A2.MouseEnter += new System.EventHandler(this.button_enter);
			this.A2.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// A3
			// 
			this.A3.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A3.Location = new System.Drawing.Point(283, 46);
			this.A3.Name = "A3";
			this.A3.Size = new System.Drawing.Size(139, 115);
			this.A3.TabIndex = 3;
			this.A3.UseVisualStyleBackColor = false;
			this.A3.Click += new System.EventHandler(this.button_click);
			this.A3.MouseEnter += new System.EventHandler(this.button_enter);
			this.A3.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// B1
			// 
			this.B1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B1.Location = new System.Drawing.Point(11, 158);
			this.B1.Name = "B1";
			this.B1.Size = new System.Drawing.Size(139, 115);
			this.B1.TabIndex = 4;
			this.B1.UseVisualStyleBackColor = false;
			this.B1.Click += new System.EventHandler(this.button_click);
			this.B1.MouseEnter += new System.EventHandler(this.button_enter);
			this.B1.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// B2
			// 
			this.B2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B2.Location = new System.Drawing.Point(147, 158);
			this.B2.Name = "B2";
			this.B2.Size = new System.Drawing.Size(139, 115);
			this.B2.TabIndex = 5;
			this.B2.UseVisualStyleBackColor = false;
			this.B2.Click += new System.EventHandler(this.button_click);
			this.B2.MouseEnter += new System.EventHandler(this.button_enter);
			this.B2.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// B3
			// 
			this.B3.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B3.Location = new System.Drawing.Point(283, 158);
			this.B3.Name = "B3";
			this.B3.Size = new System.Drawing.Size(139, 115);
			this.B3.TabIndex = 6;
			this.B3.UseVisualStyleBackColor = false;
			this.B3.Click += new System.EventHandler(this.button_click);
			this.B3.MouseEnter += new System.EventHandler(this.button_enter);
			this.B3.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// C1
			// 
			this.C1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C1.Location = new System.Drawing.Point(11, 269);
			this.C1.Name = "C1";
			this.C1.Size = new System.Drawing.Size(139, 115);
			this.C1.TabIndex = 7;
			this.C1.UseVisualStyleBackColor = false;
			this.C1.Click += new System.EventHandler(this.button_click);
			this.C1.MouseEnter += new System.EventHandler(this.button_enter);
			this.C1.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// C2
			// 
			this.C2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C2.Location = new System.Drawing.Point(147, 269);
			this.C2.Name = "C2";
			this.C2.Size = new System.Drawing.Size(139, 115);
			this.C2.TabIndex = 8;
			this.C2.UseVisualStyleBackColor = false;
			this.C2.Click += new System.EventHandler(this.button_click);
			this.C2.MouseEnter += new System.EventHandler(this.button_enter);
			this.C2.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// C3
			// 
			this.C3.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C3.Location = new System.Drawing.Point(283, 269);
			this.C3.Name = "C3";
			this.C3.Size = new System.Drawing.Size(139, 115);
			this.C3.TabIndex = 9;
			this.C3.UseVisualStyleBackColor = false;
			this.C3.Click += new System.EventHandler(this.button_click);
			this.C3.MouseEnter += new System.EventHandler(this.button_enter);
			this.C3.MouseLeave += new System.EventHandler(this.button_leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 400);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "X Win Count";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(298, 400);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "O Win Count";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(162, 400);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "Draw Count";
			// 
			// x_count
			// 
			this.x_count.AutoSize = true;
			this.x_count.Location = new System.Drawing.Point(66, 426);
			this.x_count.Name = "x_count";
			this.x_count.Size = new System.Drawing.Size(18, 20);
			this.x_count.TabIndex = 13;
			this.x_count.Text = "0";
			// 
			// o_count
			// 
			this.o_count.AutoSize = true;
			this.o_count.Location = new System.Drawing.Point(339, 426);
			this.o_count.Name = "o_count";
			this.o_count.Size = new System.Drawing.Size(18, 20);
			this.o_count.TabIndex = 14;
			this.o_count.Text = "0";
			// 
			// draw_count
			// 
			this.draw_count.AutoSize = true;
			this.draw_count.Location = new System.Drawing.Point(197, 426);
			this.draw_count.Name = "draw_count";
			this.draw_count.Size = new System.Drawing.Size(18, 20);
			this.draw_count.TabIndex = 15;
			this.draw_count.Text = "0";
			// 
			// resetWinCountToolStripMenuItem
			// 
			this.resetWinCountToolStripMenuItem.Name = "resetWinCountToolStripMenuItem";
			this.resetWinCountToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.resetWinCountToolStripMenuItem.Text = "Reset Win Count";
			this.resetWinCountToolStripMenuItem.Click += new System.EventHandler(this.resetWinCountToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(433, 471);
			this.Controls.Add(this.draw_count);
			this.Controls.Add(this.o_count);
			this.Controls.Add(this.x_count);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.C3);
			this.Controls.Add(this.C2);
			this.Controls.Add(this.C1);
			this.Controls.Add(this.B3);
			this.Controls.Add(this.B2);
			this.Controls.Add(this.B1);
			this.Controls.Add(this.A3);
			this.Controls.Add(this.A2);
			this.Controls.Add(this.A1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TicTacToe";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Button A1;
		private System.Windows.Forms.Button A2;
		private System.Windows.Forms.Button A3;
		private System.Windows.Forms.Button B1;
		private System.Windows.Forms.Button B2;
		private System.Windows.Forms.Button B3;
		private System.Windows.Forms.Button C1;
		private System.Windows.Forms.Button C2;
		private System.Windows.Forms.Button C3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label x_count;
		private System.Windows.Forms.Label o_count;
		private System.Windows.Forms.Label draw_count;
		private System.Windows.Forms.ToolStripMenuItem resetWinCountToolStripMenuItem;
	}
}

