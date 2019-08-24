namespace Evolution
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.ticker = new System.Windows.Forms.Timer(this.components);
			this.creatureCountLabel = new System.Windows.Forms.Label();
			this.maxEnergyLabel = new System.Windows.Forms.Label();
			this.welt = new Evolution.FastPanel();
			this.minEnergyLabel = new System.Windows.Forms.Label();
			this.maxSpeedLabel = new System.Windows.Forms.Label();
			this.minSpeedLabel = new System.Windows.Forms.Label();
			this.maxAgeBaseLabel = new System.Windows.Forms.Label();
			this.minAgeBaseLabel = new System.Windows.Forms.Label();
			this.maxSensePointsLabel = new System.Windows.Forms.Label();
			this.minSensePointsLabel = new System.Windows.Forms.Label();
			this.maxGenerationLabel = new System.Windows.Forms.Label();
			this.minGenerationLabel = new System.Windows.Forms.Label();
			this.dominantSpeciesLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ticker
			// 
			this.ticker.Enabled = true;
			this.ticker.Interval = 1;
			this.ticker.Tick += new System.EventHandler(this.ticker_Tick);
			// 
			// creatureCountLabel
			// 
			this.creatureCountLabel.AutoSize = true;
			this.creatureCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.creatureCountLabel.ForeColor = System.Drawing.Color.White;
			this.creatureCountLabel.Location = new System.Drawing.Point(1115, 137);
			this.creatureCountLabel.Name = "creatureCountLabel";
			this.creatureCountLabel.Size = new System.Drawing.Size(175, 24);
			this.creatureCountLabel.TabIndex = 2;
			this.creatureCountLabel.Text = "Anzahl Kreaturen: 0";
			// 
			// maxEnergyLabel
			// 
			this.maxEnergyLabel.AutoSize = true;
			this.maxEnergyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maxEnergyLabel.ForeColor = System.Drawing.Color.White;
			this.maxEnergyLabel.Location = new System.Drawing.Point(1115, 161);
			this.maxEnergyLabel.Name = "maxEnergyLabel";
			this.maxEnergyLabel.Size = new System.Drawing.Size(309, 24);
			this.maxEnergyLabel.TabIndex = 2;
			this.maxEnergyLabel.Text = "Energie der lebendigsten Kreatur: 0";
			// 
			// welt
			// 
			this.welt.BackColor = System.Drawing.Color.Black;
			this.welt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.welt.Location = new System.Drawing.Point(0, 0);
			this.welt.Margin = new System.Windows.Forms.Padding(0);
			this.welt.Name = "welt";
			this.welt.Size = new System.Drawing.Size(1000, 1000);
			this.welt.TabIndex = 1;
			// 
			// label1
			// 
			this.minEnergyLabel.AutoSize = true;
			this.minEnergyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minEnergyLabel.ForeColor = System.Drawing.Color.White;
			this.minEnergyLabel.Location = new System.Drawing.Point(1115, 185);
			this.minEnergyLabel.Name = "label1";
			this.minEnergyLabel.Size = new System.Drawing.Size(310, 24);
			this.minEnergyLabel.TabIndex = 2;
			this.minEnergyLabel.Text = "Energie der schwächsten Kreatur: 0";
			// 
			// label2
			// 
			this.maxSpeedLabel.AutoSize = true;
			this.maxSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maxSpeedLabel.ForeColor = System.Drawing.Color.White;
			this.maxSpeedLabel.Location = new System.Drawing.Point(1115, 209);
			this.maxSpeedLabel.Name = "label2";
			this.maxSpeedLabel.Size = new System.Drawing.Size(167, 24);
			this.maxSpeedLabel.TabIndex = 2;
			this.maxSpeedLabel.Text = "Höchster Speed: 0";
			// 
			// label3
			// 
			this.minSpeedLabel.AutoSize = true;
			this.minSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minSpeedLabel.ForeColor = System.Drawing.Color.White;
			this.minSpeedLabel.Location = new System.Drawing.Point(1115, 233);
			this.minSpeedLabel.Name = "label3";
			this.minSpeedLabel.Size = new System.Drawing.Size(182, 24);
			this.minSpeedLabel.TabIndex = 2;
			this.minSpeedLabel.Text = "Niedrigster Speed: 0";
			// 
			// label4
			// 
			this.maxAgeBaseLabel.AutoSize = true;
			this.maxAgeBaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maxAgeBaseLabel.ForeColor = System.Drawing.Color.White;
			this.maxAgeBaseLabel.Location = new System.Drawing.Point(1115, 257);
			this.maxAgeBaseLabel.Name = "label4";
			this.maxAgeBaseLabel.Size = new System.Drawing.Size(182, 24);
			this.maxAgeBaseLabel.TabIndex = 2;
			this.maxAgeBaseLabel.Text = "Höchste AgeBase: 0";
			// 
			// label5
			// 
			this.minAgeBaseLabel.AutoSize = true;
			this.minAgeBaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minAgeBaseLabel.ForeColor = System.Drawing.Color.White;
			this.minAgeBaseLabel.Location = new System.Drawing.Point(1115, 281);
			this.minAgeBaseLabel.Name = "label5";
			this.minAgeBaseLabel.Size = new System.Drawing.Size(197, 24);
			this.minAgeBaseLabel.TabIndex = 2;
			this.minAgeBaseLabel.Text = "Niedrigste AgeBase: 0";
			// 
			// label6
			// 
			this.maxSensePointsLabel.AutoSize = true;
			this.maxSensePointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maxSensePointsLabel.ForeColor = System.Drawing.Color.White;
			this.maxSensePointsLabel.Location = new System.Drawing.Point(1115, 305);
			this.maxSensePointsLabel.Name = "label6";
			this.maxSensePointsLabel.Size = new System.Drawing.Size(210, 24);
			this.maxSensePointsLabel.TabIndex = 2;
			this.maxSensePointsLabel.Text = "Höchste SensePoints: 0";
			// 
			// label7
			// 
			this.minSensePointsLabel.AutoSize = true;
			this.minSensePointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minSensePointsLabel.ForeColor = System.Drawing.Color.White;
			this.minSensePointsLabel.Location = new System.Drawing.Point(1115, 329);
			this.minSensePointsLabel.Name = "label7";
			this.minSensePointsLabel.Size = new System.Drawing.Size(225, 24);
			this.minSensePointsLabel.TabIndex = 2;
			this.minSensePointsLabel.Text = "Niedrigste SensePoints: 0";
			// 
			// label8
			// 
			this.maxGenerationLabel.AutoSize = true;
			this.maxGenerationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maxGenerationLabel.ForeColor = System.Drawing.Color.White;
			this.maxGenerationLabel.Location = new System.Drawing.Point(1115, 353);
			this.maxGenerationLabel.Name = "label8";
			this.maxGenerationLabel.Size = new System.Drawing.Size(198, 24);
			this.maxGenerationLabel.TabIndex = 2;
			this.maxGenerationLabel.Text = "Höchste Generation: 0";
			// 
			// label9
			// 
			this.minGenerationLabel.AutoSize = true;
			this.minGenerationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minGenerationLabel.ForeColor = System.Drawing.Color.White;
			this.minGenerationLabel.Location = new System.Drawing.Point(1115, 377);
			this.minGenerationLabel.Name = "label9";
			this.minGenerationLabel.Size = new System.Drawing.Size(194, 24);
			this.minGenerationLabel.TabIndex = 2;
			this.minGenerationLabel.Text = "Kleinste Generation: 0";
			// 
			// label10
			// 
			this.dominantSpeciesLabel.AutoSize = true;
			this.dominantSpeciesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dominantSpeciesLabel.ForeColor = System.Drawing.Color.White;
			this.dominantSpeciesLabel.Location = new System.Drawing.Point(1115, 401);
			this.dominantSpeciesLabel.Name = "label10";
			this.dominantSpeciesLabel.Size = new System.Drawing.Size(384, 24);
			this.dominantSpeciesLabel.TabIndex = 2;
			this.dominantSpeciesLabel.Text = "Startwesen mit den meisten Nachkommen: 0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(1916, 1054);
			this.Controls.Add(this.dominantSpeciesLabel);
			this.Controls.Add(this.minGenerationLabel);
			this.Controls.Add(this.maxGenerationLabel);
			this.Controls.Add(this.minSensePointsLabel);
			this.Controls.Add(this.maxSensePointsLabel);
			this.Controls.Add(this.minAgeBaseLabel);
			this.Controls.Add(this.maxAgeBaseLabel);
			this.Controls.Add(this.minSpeedLabel);
			this.Controls.Add(this.maxSpeedLabel);
			this.Controls.Add(this.minEnergyLabel);
			this.Controls.Add(this.maxEnergyLabel);
			this.Controls.Add(this.creatureCountLabel);
			this.Controls.Add(this.welt);
			this.Name = "MainForm";
			this.Text = "Evolution-Sim";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer ticker;
		private FastPanel welt;
		private System.Windows.Forms.Label creatureCountLabel;
		private System.Windows.Forms.Label maxEnergyLabel;
		private System.Windows.Forms.Label minEnergyLabel;
		private System.Windows.Forms.Label maxSpeedLabel;
		private System.Windows.Forms.Label minSpeedLabel;
		private System.Windows.Forms.Label maxAgeBaseLabel;
		private System.Windows.Forms.Label minAgeBaseLabel;
		private System.Windows.Forms.Label maxSensePointsLabel;
		private System.Windows.Forms.Label minSensePointsLabel;
		private System.Windows.Forms.Label maxGenerationLabel;
		private System.Windows.Forms.Label minGenerationLabel;
		private System.Windows.Forms.Label dominantSpeciesLabel;
	}
}

