using System;


namespace PckView
{
	partial class About
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
				components.Dispose();

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.lblVer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(290, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Main coding and design: Ben Ratzlaff";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblVer
			// 
			this.lblVer.Location = new System.Drawing.Point(0, 40);
			this.lblVer.Name = "lblVer";
			this.lblVer.Size = new System.Drawing.Size(290, 14);
			this.lblVer.TabIndex = 3;
			this.lblVer.Text = "Release version 1.6.0.0";
			this.lblVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// About
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.ClientSize = new System.Drawing.Size(292, 72);
			this.Controls.Add(this.lblVer);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblVer;
	}
}
