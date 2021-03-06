using System;
using System.Windows.Forms;

using MapView.Forms.MapObservers.TileViews;

using XCom;


namespace MapView
{
	/// <summary>
	/// General HelpScreen.
	/// </summary>
	internal sealed class Help
		:
			Form
	{
		internal Help()
		{
			InitializeComponent();

			 l1.ForeColor = TilePanel.TileColors[(int)SpecialType.Tile];
			 l2.ForeColor = TilePanel.TileColors[(int)SpecialType.StartPoint];
			 l3.ForeColor = TilePanel.TileColors[(int)SpecialType.IonBeamAccel];
			 l4.ForeColor = TilePanel.TileColors[(int)SpecialType.DestroyObjective];
			 l5.ForeColor = TilePanel.TileColors[(int)SpecialType.MagneticNav];
			 l6.ForeColor = TilePanel.TileColors[(int)SpecialType.AlienCryo];
			 l7.ForeColor = TilePanel.TileColors[(int)SpecialType.AlienClon];
			 l8.ForeColor = TilePanel.TileColors[(int)SpecialType.AlienLearn];
			 l9.ForeColor = TilePanel.TileColors[(int)SpecialType.AlienImplant];
			l10.ForeColor = TilePanel.TileColors[(int)SpecialType.AlienPlastics];
			l11.ForeColor = TilePanel.TileColors[(int)SpecialType.ExamRoom];
			l12.ForeColor = TilePanel.TileColors[(int)SpecialType.DeadTile];
			l13.ForeColor = TilePanel.TileColors[(int)SpecialType.EndPoint];
			l14.ForeColor = TilePanel.TileColors[(int)SpecialType.MustDestroy];
		}

		private void keyClose(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Escape:
				case Keys.Enter:
					Close();
					break;
			}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
				components.Dispose();

			base.Dispose(disposing);
		}

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;


		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l14 = new System.Windows.Forms.Label();
            this.l13 = new System.Windows.Forms.Label();
            this.l12 = new System.Windows.Forms.Label();
            this.l11 = new System.Windows.Forms.Label();
            this.l10 = new System.Windows.Forms.Label();
            this.l9 = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Controls.Add(this.tabPage4);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(454, 276);
            this.tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(446, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Window";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(5, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(440, 27);
            this.label17.TabIndex = 3;
            this.label17.Text = "You MUST SAVE before selecting another map or your changes will be lost. You will" +
    " be prompted.";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(5, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(440, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Your window locations will be saved on program exit.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turning the animation off makes it harder to see which tile you are going to clic" +
    "k on.";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click anywhere to set the tile to edit.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(446, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Top View";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(85, 220);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 15);
            this.label23.TabIndex = 10;
            this.label23.Text = "Northwall";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(5, 135);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(440, 25);
            this.label22.TabIndex = 9;
            this.label22.Text = "Right clicking on the grid will set the selected tile in tileView in the selected" +
    " portion on the bottom.";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(5, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(440, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Setting the size will make things larger/smaller.";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(5, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tile Colors:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(85, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Westwall";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(85, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Content";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(85, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Floor";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(440, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Double right click to clear the clicked on tile.";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(440, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Right click to set the currently selected tile to the one selected in Tile View.";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Double left click to set the currently selected tile in Tile View.";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Click anywhere to set the tile to edit.";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(446, 250);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rmp View";
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(90, 145);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 15);
            this.label24.TabIndex = 20;
            this.label24.Text = "Northwall";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(5, 85);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(440, 15);
            this.label20.TabIndex = 19;
            this.label20.Text = "Right click on the grid to place a new node.";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(5, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(440, 15);
            this.label18.TabIndex = 18;
            this.label18.Text = "After editing the distance, you must press enter to save the change.";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(5, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(440, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "Clicking a green square will select a node to edit.";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(5, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Tile Colors:";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(90, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 15);
            this.label15.TabIndex = 15;
            this.label15.Text = "Westwall";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(90, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 15);
            this.label16.TabIndex = 14;
            this.label16.Text = "Content";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(5, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(440, 15);
            this.label21.TabIndex = 9;
            this.label21.Text = "Click anywhere to set the tile to edit.";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(446, 250);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tile View";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.l14);
            this.groupBox1.Controls.Add(this.l13);
            this.groupBox1.Controls.Add(this.l12);
            this.groupBox1.Controls.Add(this.l11);
            this.groupBox1.Controls.Add(this.l10);
            this.groupBox1.Controls.Add(this.l9);
            this.groupBox1.Controls.Add(this.l8);
            this.groupBox1.Controls.Add(this.l7);
            this.groupBox1.Controls.Add(this.l6);
            this.groupBox1.Controls.Add(this.l5);
            this.groupBox1.Controls.Add(this.l4);
            this.groupBox1.Controls.Add(this.l3);
            this.groupBox1.Controls.Add(this.l2);
            this.groupBox1.Controls.Add(this.l1);
            this.groupBox1.Location = new System.Drawing.Point(60, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 144);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tile Colors";
            // 
            // l14
            // 
            this.l14.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l14.Location = new System.Drawing.Point(115, 120);
            this.l14.Name = "l14";
            this.l14.Size = new System.Drawing.Size(95, 15);
            this.l14.TabIndex = 25;
            this.l14.Text = "Must Destroy";
            // 
            // l13
            // 
            this.l13.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l13.Location = new System.Drawing.Point(10, 120);
            this.l13.Name = "l13";
            this.l13.Size = new System.Drawing.Size(95, 15);
            this.l13.TabIndex = 24;
            this.l13.Text = "End Point";
            // 
            // l12
            // 
            this.l12.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l12.Location = new System.Drawing.Point(220, 95);
            this.l12.Name = "l12";
            this.l12.Size = new System.Drawing.Size(95, 15);
            this.l12.TabIndex = 23;
            this.l12.Text = "Dead tile";
            // 
            // l11
            // 
            this.l11.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l11.Location = new System.Drawing.Point(115, 95);
            this.l11.Name = "l11";
            this.l11.Size = new System.Drawing.Size(95, 15);
            this.l11.TabIndex = 22;
            this.l11.Text = "Exam room";
            // 
            // l10
            // 
            this.l10.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l10.Location = new System.Drawing.Point(10, 95);
            this.l10.Name = "l10";
            this.l10.Size = new System.Drawing.Size(95, 15);
            this.l10.TabIndex = 21;
            this.l10.Text = "Plastics";
            // 
            // l9
            // 
            this.l9.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l9.Location = new System.Drawing.Point(220, 70);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(95, 15);
            this.l9.TabIndex = 20;
            this.l9.Text = "Implanter";
            // 
            // l8
            // 
            this.l8.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l8.Location = new System.Drawing.Point(115, 70);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(95, 15);
            this.l8.TabIndex = 19;
            this.l8.Text = "Learning Array";
            // 
            // l7
            // 
            this.l7.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l7.Location = new System.Drawing.Point(10, 70);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(95, 15);
            this.l7.TabIndex = 18;
            this.l7.Text = "Cloning";
            // 
            // l6
            // 
            this.l6.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6.Location = new System.Drawing.Point(220, 45);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(95, 15);
            this.l6.TabIndex = 17;
            this.l6.Text = "Cryogenics";
            // 
            // l5
            // 
            this.l5.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.Location = new System.Drawing.Point(115, 45);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(95, 15);
            this.l5.TabIndex = 16;
            this.l5.Text = "Navigation";
            // 
            // l4
            // 
            this.l4.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(10, 45);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(95, 15);
            this.l4.TabIndex = 15;
            this.l4.Text = "Destroy Objective";
            // 
            // l3
            // 
            this.l3.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(220, 20);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(95, 15);
            this.l3.TabIndex = 14;
            this.l3.Text = "Ion beam accelerator";
            // 
            // l2
            // 
            this.l2.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(115, 20);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(95, 15);
            this.l2.TabIndex = 13;
            this.l2.Text = "Xcom start";
            // 
            // l1
            // 
            this.l1.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.l1.Location = new System.Drawing.Point(10, 20);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(95, 15);
            this.l1.TabIndex = 12;
            this.l1.Text = "Tile";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(5, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(440, 15);
            this.label19.TabIndex = 10;
            this.label19.Text = "Left click to select the tile to place.";
            // 
            // Help
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.ClientSize = new System.Drawing.Size(454, 276);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyClose);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private TabControl tabMain;
		private TabPage tabPage1;
		private Label label1;
		private Label label2;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private TabPage tabPage4;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private Label label14;
		private Label label15;
		private Label label16;
		private Label label21;
		private Label label13;
		private Label label17;
		private Label label18;
		private Label label19;
		private Label label20;
		private Label label22;
		private GroupBox groupBox1;
		private Label l1;
		private Label l2;
		private Label l3;
		private Label l6;
		private Label l5;
		private Label l4;
		private Label l9;
		private Label l8;
		private Label l7;
		private Label l12;
		private Label l11;
		private Label l10;
		private Label l14;
		private Label l13;
		private Label label23;
		private Label label24;
	}
}
