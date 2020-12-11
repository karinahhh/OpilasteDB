namespace databasee
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
			this.components = new System.ComponentModel.Container();
			this.toodedBindingSource = new System.Windows.Forms.BindingSource(this.components);
		
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Tmail = new System.Windows.Forms.TextBox();
			this.Ttelef = new System.Windows.Forms.TextBox();
			this.Tnimi = new System.Windows.Forms.TextBox();
			this.btn_prev = new System.Windows.Forms.Button();
			this.btn_next = new System.Windows.Forms.Button();
			this.btn_add = new System.Windows.Forms.Button();
			this.btn_change = new System.Windows.Forms.Button();
			this.btn_del = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.lbl_nimi = new System.Windows.Forms.Label();
			this.lbl_tel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_ryhm = new System.Windows.Forms.Label();
			this.lbl_ots = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// toodedBindingSource
			// 
			this.toodedBindingSource.DataMember = "Tooded";
			// 
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(465, 77);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(323, 221);
			this.dataGridView1.TabIndex = 0;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(89, 186);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(142, 21);
			this.comboBox1.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(185, 154);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// Tmail
			// 
			this.Tmail.Location = new System.Drawing.Point(281, 64);
			this.Tmail.Name = "Tmail";
			this.Tmail.Size = new System.Drawing.Size(131, 20);
			this.Tmail.TabIndex = 3;
			// 
			// Ttelef
			// 
			this.Ttelef.Location = new System.Drawing.Point(281, 38);
			this.Ttelef.Name = "Ttelef";
			this.Ttelef.Size = new System.Drawing.Size(131, 20);
			this.Ttelef.TabIndex = 4;
			// 
			// Tnimi
			// 
			this.Tnimi.Location = new System.Drawing.Point(281, 12);
			this.Tnimi.Name = "Tnimi";
			this.Tnimi.Size = new System.Drawing.Size(131, 20);
			this.Tnimi.TabIndex = 5;
			// 
			// btn_prev
			// 
			this.btn_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.btn_prev.Location = new System.Drawing.Point(71, 213);
			this.btn_prev.Name = "btn_prev";
			this.btn_prev.Size = new System.Drawing.Size(106, 34);
			this.btn_prev.TabIndex = 6;
			this.btn_prev.Text = "Eelmine";
			this.btn_prev.UseVisualStyleBackColor = true;
			// 
			// btn_next
			// 
			this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.btn_next.Location = new System.Drawing.Point(183, 213);
			this.btn_next.Name = "btn_next";
			this.btn_next.Size = new System.Drawing.Size(106, 34);
			this.btn_next.TabIndex = 7;
			this.btn_next.Text = "Järgmine";
			this.btn_next.UseVisualStyleBackColor = true;
			// 
			// btn_add
			// 
			this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.btn_add.Location = new System.Drawing.Point(12, 253);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(106, 34);
			this.btn_add.TabIndex = 8;
			this.btn_add.Text = "Lisa";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_change
			// 
			this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.btn_change.Location = new System.Drawing.Point(124, 253);
			this.btn_change.Name = "btn_change";
			this.btn_change.Size = new System.Drawing.Size(106, 34);
			this.btn_change.TabIndex = 9;
			this.btn_change.Text = "Muuda";
			this.btn_change.UseVisualStyleBackColor = true;
			// 
			// btn_del
			// 
			this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.btn_del.Location = new System.Drawing.Point(236, 253);
			this.btn_del.Name = "btn_del";
			this.btn_del.Size = new System.Drawing.Size(106, 34);
			this.btn_del.TabIndex = 10;
			this.btn_del.Text = "Kustuta";
			this.btn_del.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(622, 38);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(166, 20);
			this.textBox4.TabIndex = 11;
			// 
			// lbl_nimi
			// 
			this.lbl_nimi.AutoSize = true;
			this.lbl_nimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.lbl_nimi.Location = new System.Drawing.Point(222, 12);
			this.lbl_nimi.Name = "lbl_nimi";
			this.lbl_nimi.Size = new System.Drawing.Size(39, 20);
			this.lbl_nimi.TabIndex = 12;
			this.lbl_nimi.Text = "Nimi";
			// 
			// lbl_tel
			// 
			this.lbl_tel.AutoSize = true;
			this.lbl_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.lbl_tel.Location = new System.Drawing.Point(231, 38);
			this.lbl_tel.Name = "lbl_tel";
			this.lbl_tel.Size = new System.Drawing.Size(30, 20);
			this.lbl_tel.TabIndex = 13;
			this.lbl_tel.Text = "Tel";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.label2.Location = new System.Drawing.Point(208, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 20);
			this.label2.TabIndex = 14;
			this.label2.Text = "E-mail";
			// 
			// lbl_ryhm
			// 
			this.lbl_ryhm.AutoSize = true;
			this.lbl_ryhm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.lbl_ryhm.Location = new System.Drawing.Point(8, 184);
			this.lbl_ryhm.Name = "lbl_ryhm";
			this.lbl_ryhm.Size = new System.Drawing.Size(75, 20);
			this.lbl_ryhm.TabIndex = 15;
			this.lbl_ryhm.Text = "Vali rühm";
			// 
			// lbl_ots
			// 
			this.lbl_ots.AutoSize = true;
			this.lbl_ots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.lbl_ots.Location = new System.Drawing.Point(461, 36);
			this.lbl_ots.Name = "lbl_ots";
			this.lbl_ots.Size = new System.Drawing.Size(121, 20);
			this.lbl_ots.TabIndex = 16;
			this.lbl_ots.Text = "Andmete otsing";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 331);
			this.Controls.Add(this.lbl_ots);
			this.Controls.Add(this.lbl_ryhm);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbl_tel);
			this.Controls.Add(this.lbl_nimi);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.btn_del);
			this.Controls.Add(this.btn_change);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.btn_next);
			this.Controls.Add(this.btn_prev);
			this.Controls.Add(this.Tnimi);
			this.Controls.Add(this.Ttelef);
			this.Controls.Add(this.Tmail);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource toodedBindingSource;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox Tmail;
		private System.Windows.Forms.TextBox Ttelef;
		private System.Windows.Forms.TextBox Tnimi;
		private System.Windows.Forms.Button btn_prev;
		private System.Windows.Forms.Button btn_next;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_change;
		private System.Windows.Forms.Button btn_del;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label lbl_nimi;
		private System.Windows.Forms.Label lbl_tel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_ryhm;
		private System.Windows.Forms.Label lbl_ots;
	}
}

