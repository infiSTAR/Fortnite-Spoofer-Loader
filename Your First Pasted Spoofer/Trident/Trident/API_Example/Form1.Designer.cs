namespace API_Example
{
	// Token: 0x0200000A RID: 10
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000051 RID: 81 RVA: 0x0000A094 File Offset: 0x00008294
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000A0CC File Offset: 0x000082CC
		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			this.button2.Location = new global::System.Drawing.Point(93, 12);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Register";
			this.button2.UseVisualStyleBackColor = true;
			this.textBox1.Location = new global::System.Drawing.Point(68, 131);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(100, 19);
			this.textBox1.TabIndex = 2;
			this.textBox2.Location = new global::System.Drawing.Point(183, 131);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(100, 19);
			this.textBox2.TabIndex = 3;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(309, 227);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Name = "Form1";
			this.Text = "LOGIN l Trident Spoofer l ver 0.6";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001C RID: 28
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.TextBox textBox2;
	}
}
