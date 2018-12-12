namespace BF2WeaponDuplicator
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
			this.bukaButton = new System.Windows.Forms.Button();
			this.lokInfoBox = new System.Windows.Forms.Label();
			this.duplicateButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.outputBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nilaiBox = new System.Windows.Forms.TextBox();
			this.bagianBox = new System.Windows.Forms.ComboBox();
			this.statusBox = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bukaButton
			// 
			this.bukaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bukaButton.Location = new System.Drawing.Point(12, 43);
			this.bukaButton.Name = "bukaButton";
			this.bukaButton.Size = new System.Drawing.Size(235, 87);
			this.bukaButton.TabIndex = 0;
			this.bukaButton.Text = "Buka";
			this.bukaButton.UseVisualStyleBackColor = true;
			this.bukaButton.Click += new System.EventHandler(this.bukaButton_Click);
			// 
			// lokInfoBox
			// 
			this.lokInfoBox.AutoSize = true;
			this.lokInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lokInfoBox.Location = new System.Drawing.Point(12, 9);
			this.lokInfoBox.Name = "lokInfoBox";
			this.lokInfoBox.Size = new System.Drawing.Size(86, 31);
			this.lokInfoBox.TabIndex = 1;
			this.lokInfoBox.Text = "label1";
			// 
			// duplicateButton
			// 
			this.duplicateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.duplicateButton.Location = new System.Drawing.Point(343, 44);
			this.duplicateButton.Name = "duplicateButton";
			this.duplicateButton.Size = new System.Drawing.Size(235, 87);
			this.duplicateButton.TabIndex = 2;
			this.duplicateButton.Text = "Duplikasikan";
			this.duplicateButton.UseVisualStyleBackColor = true;
			this.duplicateButton.Click += new System.EventHandler(this.duplicateButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 31);
			this.label1.TabIndex = 3;
			this.label1.Text = "Sebagai : ";
			// 
			// outputBox
			// 
			this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.outputBox.Location = new System.Drawing.Point(153, 137);
			this.outputBox.Name = "outputBox";
			this.outputBox.Size = new System.Drawing.Size(425, 29);
			this.outputBox.TabIndex = 1;
			this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(186, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Status yang bisa diganti :";
			// 
			// nilaiBox
			// 
			this.nilaiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nilaiBox.Location = new System.Drawing.Point(402, 222);
			this.nilaiBox.Name = "nilaiBox";
			this.nilaiBox.Size = new System.Drawing.Size(176, 31);
			this.nilaiBox.TabIndex = 7;
			this.nilaiBox.TextChanged += new System.EventHandler(this.nilaiBox_TextChanged);
			// 
			// bagianBox
			// 
			this.bagianBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.bagianBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bagianBox.FormattingEnabled = true;
			this.bagianBox.Location = new System.Drawing.Point(12, 223);
			this.bagianBox.Name = "bagianBox";
			this.bagianBox.Size = new System.Drawing.Size(189, 32);
			this.bagianBox.TabIndex = 8;
			this.bagianBox.SelectedIndexChanged += new System.EventHandler(this.bagianBox_SelectedIndexChanged);
			// 
			// statusBox
			// 
			this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.statusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusBox.FormattingEnabled = true;
			this.statusBox.Location = new System.Drawing.Point(207, 223);
			this.statusBox.Name = "statusBox";
			this.statusBox.Size = new System.Drawing.Size(189, 32);
			this.statusBox.TabIndex = 9;
			this.statusBox.SelectedIndexChanged += new System.EventHandler(this.statusBox_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(140, 261);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(318, 87);
			this.button1.TabIndex = 10;
			this.button1.Text = "Konfirmasikan Nilainya";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.statusBox);
			this.Controls.Add(this.bagianBox);
			this.Controls.Add(this.nilaiBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.outputBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.duplicateButton);
			this.Controls.Add(this.lokInfoBox);
			this.Controls.Add(this.bukaButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bukaButton;
		private System.Windows.Forms.Label lokInfoBox;
		private System.Windows.Forms.Button duplicateButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox outputBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nilaiBox;
		private System.Windows.Forms.ComboBox bagianBox;
		private System.Windows.Forms.ComboBox statusBox;
		private System.Windows.Forms.Button button1;
	}
}

