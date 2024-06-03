namespace proyecto2_prograIII
{
    partial class frmEquipo
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
            this.lstEquipo = new System.Windows.Forms.TextBox();
            this.btnMostrarE = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnELiminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.txtCommonName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtMatches = new System.Windows.Forms.TextBox();
            this.txtWins = new System.Windows.Forms.TextBox();
            this.txtLosses = new System.Windows.Forms.TextBox();
            this.txtDraws = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstEquipo
            // 
            this.lstEquipo.Location = new System.Drawing.Point(26, 455);
            this.lstEquipo.Multiline = true;
            this.lstEquipo.Name = "lstEquipo";
            this.lstEquipo.Size = new System.Drawing.Size(776, 131);
            this.lstEquipo.TabIndex = 0;
            // 
            // btnMostrarE
            // 
            this.btnMostrarE.Location = new System.Drawing.Point(10, 193);
            this.btnMostrarE.Name = "btnMostrarE";
            this.btnMostrarE.Size = new System.Drawing.Size(122, 23);
            this.btnMostrarE.TabIndex = 1;
            this.btnMostrarE.Text = "Mostrar Equipo";
            this.btnMostrarE.UseVisualStyleBackColor = true;
            this.btnMostrarE.Click += new System.EventHandler(this.btnMostrarE_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(204, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnELiminar
            // 
            this.btnELiminar.Location = new System.Drawing.Point(10, 236);
            this.btnELiminar.Name = "btnELiminar";
            this.btnELiminar.Size = new System.Drawing.Size(122, 23);
            this.btnELiminar.TabIndex = 3;
            this.btnELiminar.Text = "Eliminar";
            this.btnELiminar.UseVisualStyleBackColor = true;
            this.btnELiminar.Click += new System.EventHandler(this.btnELiminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(10, 281);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(122, 23);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(273, 190);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(178, 20);
            this.txtTeamName.TabIndex = 5;
            // 
            // txtCommonName
            // 
            this.txtCommonName.Location = new System.Drawing.Point(273, 238);
            this.txtCommonName.Name = "txtCommonName";
            this.txtCommonName.Size = new System.Drawing.Size(178, 20);
            this.txtCommonName.TabIndex = 6;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(273, 281);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(178, 20);
            this.txtCountry.TabIndex = 7;
            // 
            // txtMatches
            // 
            this.txtMatches.Location = new System.Drawing.Point(608, 193);
            this.txtMatches.Name = "txtMatches";
            this.txtMatches.Size = new System.Drawing.Size(178, 20);
            this.txtMatches.TabIndex = 8;
            // 
            // txtWins
            // 
            this.txtWins.Location = new System.Drawing.Point(608, 236);
            this.txtWins.Name = "txtWins";
            this.txtWins.Size = new System.Drawing.Size(178, 20);
            this.txtWins.TabIndex = 9;
            // 
            // txtLosses
            // 
            this.txtLosses.Location = new System.Drawing.Point(608, 284);
            this.txtLosses.Name = "txtLosses";
            this.txtLosses.Size = new System.Drawing.Size(178, 20);
            this.txtLosses.TabIndex = 10;
            // 
            // txtDraws
            // 
            this.txtDraws.Location = new System.Drawing.Point(444, 326);
            this.txtDraws.Name = "txtDraws";
            this.txtDraws.Size = new System.Drawing.Size(178, 20);
            this.txtDraws.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Team Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Common Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Matches Played";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Wins";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Losses";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Draw";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(305, 60);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(304, 20);
            this.txtBuscar.TabIndex = 19;
            // 
            // frmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 598);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDraws);
            this.Controls.Add(this.txtLosses);
            this.Controls.Add(this.txtWins);
            this.Controls.Add(this.txtMatches);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCommonName);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnELiminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnMostrarE);
            this.Controls.Add(this.lstEquipo);
            this.Name = "frmEquipo";
            this.Text = "frmEquipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lstEquipo;
        private System.Windows.Forms.Button btnMostrarE;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnELiminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.TextBox txtCommonName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtMatches;
        private System.Windows.Forms.TextBox txtWins;
        private System.Windows.Forms.TextBox txtLosses;
        private System.Windows.Forms.TextBox txtDraws;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}