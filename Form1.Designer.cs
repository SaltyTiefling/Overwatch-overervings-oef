namespace Overwatch_overervingsoef
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
            this.lbxHeroes = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtHero = new System.Windows.Forms.TextBox();
            this.gbAblities = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lbxHeroes
            // 
            this.lbxHeroes.FormattingEnabled = true;
            this.lbxHeroes.Location = new System.Drawing.Point(12, 12);
            this.lbxHeroes.Name = "lbxHeroes";
            this.lbxHeroes.Size = new System.Drawing.Size(120, 134);
            this.lbxHeroes.TabIndex = 0;
            this.lbxHeroes.SelectedIndexChanged += new System.EventHandler(this.lbxHeroes_SelectedIndexChanged);
            // 
            // txtHero
            // 
            this.txtHero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHero.Location = new System.Drawing.Point(139, 13);
            this.txtHero.Multiline = true;
            this.txtHero.Name = "txtHero";
            this.txtHero.ReadOnly = true;
            this.txtHero.Size = new System.Drawing.Size(557, 134);
            this.txtHero.TabIndex = 1;
            // 
            // gbAblities
            // 
            this.gbAblities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAblities.Location = new System.Drawing.Point(12, 152);
            this.gbAblities.Name = "gbAblities";
            this.gbAblities.Size = new System.Drawing.Size(684, 21);
            this.gbAblities.TabIndex = 2;
            this.gbAblities.TabStop = false;
            this.gbAblities.Text = "Abilities";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(708, 185);
            this.Controls.Add(this.gbAblities);
            this.Controls.Add(this.txtHero);
            this.Controls.Add(this.lbxHeroes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxHeroes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtHero;
        private System.Windows.Forms.GroupBox gbAblities;
    }
}

