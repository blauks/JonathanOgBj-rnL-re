namespace Læringsapplikasjon
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
            this.pStartmeny = new System.Windows.Forms.Panel();
            this.pSpillmeny = new System.Windows.Forms.Panel();
            this.btSpillmenyI = new System.Windows.Forms.Button();
            this.btSpillmenyT = new System.Windows.Forms.Button();
            this.btSpillmenyS = new System.Windows.Forms.Button();
            this.lNavnSpill = new System.Windows.Forms.Label();
            this.pbSpillmeny = new System.Windows.Forms.PictureBox();
            this.labelStartMeny = new System.Windows.Forms.Label();
            this.btStartD = new System.Windows.Forms.Button();
            this.btStartT = new System.Windows.Forms.Button();
            this.btStartF = new System.Windows.Forms.Button();
            this.pbStartmeny = new System.Windows.Forms.PictureBox();
            this.FigurTimer = new System.Windows.Forms.Timer(this.components);
            this.Ubrkuelig_Shit = new System.Windows.Forms.PictureBox();
            this.pStartmeny.SuspendLayout();
            this.pSpillmeny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpillmeny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartmeny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ubrkuelig_Shit)).BeginInit();
            this.SuspendLayout();
            // 
            // pStartmeny
            // 
            this.pStartmeny.Controls.Add(this.labelStartMeny);
            this.pStartmeny.Controls.Add(this.btStartD);
            this.pStartmeny.Controls.Add(this.btStartT);
            this.pStartmeny.Controls.Add(this.btStartF);
            this.pStartmeny.Controls.Add(this.pbStartmeny);
            this.pStartmeny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pStartmeny.Location = new System.Drawing.Point(0, 0);
            this.pStartmeny.Name = "pStartmeny";
            this.pStartmeny.Size = new System.Drawing.Size(1004, 621);
            this.pStartmeny.TabIndex = 7;
            // 
            // pSpillmeny
            // 
            this.pSpillmeny.Controls.Add(this.btSpillmenyI);
            this.pSpillmeny.Controls.Add(this.btSpillmenyT);
            this.pSpillmeny.Controls.Add(this.btSpillmenyS);
            this.pSpillmeny.Controls.Add(this.lNavnSpill);
            this.pSpillmeny.Controls.Add(this.pbSpillmeny);
            this.pSpillmeny.Location = new System.Drawing.Point(35, 100);
            this.pSpillmeny.Name = "pSpillmeny";
            this.pSpillmeny.Size = new System.Drawing.Size(593, 417);
            this.pSpillmeny.TabIndex = 12;
            // 
            // btSpillmenyI
            // 
            this.btSpillmenyI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSpillmenyI.Location = new System.Drawing.Point(319, 411);
            this.btSpillmenyI.Name = "btSpillmenyI";
            this.btSpillmenyI.Size = new System.Drawing.Size(343, 71);
            this.btSpillmenyI.TabIndex = 3;
            this.btSpillmenyI.Text = "Instruksjon";
            this.btSpillmenyI.UseVisualStyleBackColor = true;
            // 
            // btSpillmenyT
            // 
            this.btSpillmenyT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSpillmenyT.Location = new System.Drawing.Point(319, 305);
            this.btSpillmenyT.Name = "btSpillmenyT";
            this.btSpillmenyT.Size = new System.Drawing.Size(343, 71);
            this.btSpillmenyT.TabIndex = 2;
            this.btSpillmenyT.Text = "Toppresultater";
            this.btSpillmenyT.UseVisualStyleBackColor = true;
            // 
            // btSpillmenyS
            // 
            this.btSpillmenyS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSpillmenyS.Location = new System.Drawing.Point(319, 202);
            this.btSpillmenyS.Name = "btSpillmenyS";
            this.btSpillmenyS.Size = new System.Drawing.Size(343, 71);
            this.btSpillmenyS.TabIndex = 1;
            this.btSpillmenyS.Text = "Spill";
            this.btSpillmenyS.UseVisualStyleBackColor = true;
            // 
            // lNavnSpill
            // 
            this.lNavnSpill.AutoSize = true;
            this.lNavnSpill.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNavnSpill.Location = new System.Drawing.Point(321, 71);
            this.lNavnSpill.Name = "lNavnSpill";
            this.lNavnSpill.Size = new System.Drawing.Size(337, 63);
            this.lNavnSpill.TabIndex = 0;
            this.lNavnSpill.Text = "Navn på spill";
            // 
            // pbSpillmeny
            // 
            this.pbSpillmeny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSpillmeny.Location = new System.Drawing.Point(0, 0);
            this.pbSpillmeny.Name = "pbSpillmeny";
            this.pbSpillmeny.Size = new System.Drawing.Size(593, 417);
            this.pbSpillmeny.TabIndex = 4;
            this.pbSpillmeny.TabStop = false;
            // 
            // labelStartMeny
            // 
            this.labelStartMeny.AutoSize = true;
            this.labelStartMeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartMeny.Location = new System.Drawing.Point(368, 57);
            this.labelStartMeny.Name = "labelStartMeny";
            this.labelStartMeny.Size = new System.Drawing.Size(273, 63);
            this.labelStartMeny.TabIndex = 11;
            this.labelStartMeny.Text = "Startmeny";
            // 
            // btStartD
            // 
            this.btStartD.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStartD.Location = new System.Drawing.Point(393, 361);
            this.btStartD.Name = "btStartD";
            this.btStartD.Size = new System.Drawing.Size(203, 203);
            this.btStartD.TabIndex = 10;
            this.btStartD.Text = "Dyr";
            this.btStartD.UseVisualStyleBackColor = true;
            this.btStartD.MouseHover += new System.EventHandler(this.StartmenyHover);
            // 
            // btStartT
            // 
            this.btStartT.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStartT.Location = new System.Drawing.Point(511, 141);
            this.btStartT.Name = "btStartT";
            this.btStartT.Size = new System.Drawing.Size(203, 203);
            this.btStartT.TabIndex = 8;
            this.btStartT.Text = "Tall";
            this.btStartT.UseVisualStyleBackColor = true;
            this.btStartT.MouseHover += new System.EventHandler(this.StartmenyHover);
            // 
            // btStartF
            // 
            this.btStartF.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStartF.Location = new System.Drawing.Point(291, 141);
            this.btStartF.Name = "btStartF";
            this.btStartF.Size = new System.Drawing.Size(203, 203);
            this.btStartF.TabIndex = 7;
            this.btStartF.Text = "Figurer";
            this.btStartF.UseVisualStyleBackColor = true;
            this.btStartF.Click += new System.EventHandler(this.btStartF_Click);
            this.btStartF.MouseHover += new System.EventHandler(this.StartmenyHover);
            // 
            // pbStartmeny
            // 
            this.pbStartmeny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbStartmeny.Location = new System.Drawing.Point(0, 0);
            this.pbStartmeny.Name = "pbStartmeny";
            this.pbStartmeny.Size = new System.Drawing.Size(1004, 621);
            this.pbStartmeny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStartmeny.TabIndex = 13;
            this.pbStartmeny.TabStop = false;
            // 
            // FigurTimer
            // 
            this.FigurTimer.Interval = 1000;
            this.FigurTimer.Tick += new System.EventHandler(this.FigurTimer_Tick);
            // 
            // Ubrkuelig_Shit
            // 
            this.Ubrkuelig_Shit.Location = new System.Drawing.Point(0, 0);
            this.Ubrkuelig_Shit.Name = "Ubrkuelig_Shit";
            this.Ubrkuelig_Shit.Size = new System.Drawing.Size(1004, 621);
            this.Ubrkuelig_Shit.TabIndex = 13;
            this.Ubrkuelig_Shit.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 621);
            this.Controls.Add(this.pSpillmeny);
            this.Controls.Add(this.pStartmeny);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pStartmeny.ResumeLayout(false);
            this.pStartmeny.PerformLayout();
            this.pSpillmeny.ResumeLayout(false);
            this.pSpillmeny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpillmeny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartmeny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ubrkuelig_Shit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pStartmeny;
        private System.Windows.Forms.Label labelStartMeny;
        private System.Windows.Forms.Button btStartD;
        private System.Windows.Forms.Button btStartT;
        private System.Windows.Forms.Button btStartF;
        private System.Windows.Forms.Panel pSpillmeny;
        private System.Windows.Forms.Button btSpillmenyI;
        private System.Windows.Forms.Button btSpillmenyT;
        private System.Windows.Forms.Button btSpillmenyS;
        private System.Windows.Forms.Label lNavnSpill;
        private System.Windows.Forms.Timer FigurTimer;
        private System.Windows.Forms.PictureBox Ubrkuelig_Shit;
        private System.Windows.Forms.PictureBox pbSpillmeny;
        private System.Windows.Forms.PictureBox pbStartmeny;
    }
}

