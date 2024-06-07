namespace proyecto2_prograIII
{
    partial class frmPartidos
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscarDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Stadium = new System.Windows.Forms.Label();
            this.txtAway = new System.Windows.Forms.TextBox();
            this.txtAwayGo = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtReferee = new System.Windows.Forms.TextBox();
            this.txtHomeGo = new System.Windows.Forms.TextBox();
            this.txtHome = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTotalGo = new System.Windows.Forms.TextBox();
            this.txtStadium = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstPartidos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscarHome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuscarAway = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(580, 111);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 49;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(438, 111);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(312, 111);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 47;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBuscarDate
            // 
            this.txtBuscarDate.Location = new System.Drawing.Point(254, 55);
            this.txtBuscarDate.Name = "txtBuscarDate";
            this.txtBuscarDate.Size = new System.Drawing.Size(154, 20);
            this.txtBuscarDate.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(587, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(587, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Away Goals";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Away team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Referee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Home Goals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Home team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Total Goals";
            // 
            // Stadium
            // 
            this.Stadium.AutoSize = true;
            this.Stadium.Location = new System.Drawing.Point(85, 203);
            this.Stadium.Name = "Stadium";
            this.Stadium.Size = new System.Drawing.Size(45, 13);
            this.Stadium.TabIndex = 37;
            this.Stadium.Text = "Stadium";
            // 
            // txtAway
            // 
            this.txtAway.Location = new System.Drawing.Point(698, 200);
            this.txtAway.Name = "txtAway";
            this.txtAway.Size = new System.Drawing.Size(166, 20);
            this.txtAway.TabIndex = 36;
            // 
            // txtAwayGo
            // 
            this.txtAwayGo.Location = new System.Drawing.Point(698, 252);
            this.txtAwayGo.Name = "txtAwayGo";
            this.txtAwayGo.Size = new System.Drawing.Size(166, 20);
            this.txtAwayGo.TabIndex = 35;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(698, 302);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(166, 20);
            this.txtStatus.TabIndex = 34;
            // 
            // txtReferee
            // 
            this.txtReferee.Location = new System.Drawing.Point(423, 298);
            this.txtReferee.Name = "txtReferee";
            this.txtReferee.Size = new System.Drawing.Size(142, 20);
            this.txtReferee.TabIndex = 33;
            // 
            // txtHomeGo
            // 
            this.txtHomeGo.Location = new System.Drawing.Point(423, 255);
            this.txtHomeGo.Name = "txtHomeGo";
            this.txtHomeGo.Size = new System.Drawing.Size(142, 20);
            this.txtHomeGo.TabIndex = 32;
            // 
            // txtHome
            // 
            this.txtHome.Location = new System.Drawing.Point(423, 205);
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(142, 20);
            this.txtHome.TabIndex = 31;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(165, 298);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(146, 20);
            this.txtDate.TabIndex = 30;
            // 
            // txtTotalGo
            // 
            this.txtTotalGo.Enabled = false;
            this.txtTotalGo.Location = new System.Drawing.Point(165, 255);
            this.txtTotalGo.Name = "txtTotalGo";
            this.txtTotalGo.Size = new System.Drawing.Size(146, 20);
            this.txtTotalGo.TabIndex = 29;
            // 
            // txtStadium
            // 
            this.txtStadium.Location = new System.Drawing.Point(165, 205);
            this.txtStadium.Name = "txtStadium";
            this.txtStadium.Size = new System.Drawing.Size(146, 20);
            this.txtStadium.TabIndex = 28;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(117, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 23);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstPartidos
            // 
            this.lstPartidos.Location = new System.Drawing.Point(12, 418);
            this.lstPartidos.Multiline = true;
            this.lstPartidos.Name = "lstPartidos";
            this.lstPartidos.Size = new System.Drawing.Size(955, 150);
            this.lstPartidos.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Mostrar Partidos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(446, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Home Team";
            // 
            // txtBuscarHome
            // 
            this.txtBuscarHome.Location = new System.Drawing.Point(449, 55);
            this.txtBuscarHome.Name = "txtBuscarHome";
            this.txtBuscarHome.Size = new System.Drawing.Size(154, 20);
            this.txtBuscarHome.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(636, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Away Team";
            // 
            // txtBuscarAway
            // 
            this.txtBuscarAway.Location = new System.Drawing.Point(639, 55);
            this.txtBuscarAway.Name = "txtBuscarAway";
            this.txtBuscarAway.Size = new System.Drawing.Size(154, 20);
            this.txtBuscarAway.TabIndex = 53;
            // 
            // frmPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 596);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBuscarAway);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBuscarHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscarDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Stadium);
            this.Controls.Add(this.txtAway);
            this.Controls.Add(this.txtAwayGo);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtReferee);
            this.Controls.Add(this.txtHomeGo);
            this.Controls.Add(this.txtHome);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTotalGo);
            this.Controls.Add(this.txtStadium);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lstPartidos);
            this.Controls.Add(this.button1);
            this.Name = "frmPartidos";
            this.Text = "frmPartidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscarDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Stadium;
        private System.Windows.Forms.TextBox txtAway;
        private System.Windows.Forms.TextBox txtAwayGo;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtReferee;
        private System.Windows.Forms.TextBox txtHomeGo;
        private System.Windows.Forms.TextBox txtHome;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTotalGo;
        private System.Windows.Forms.TextBox txtStadium;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox lstPartidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscarHome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuscarAway;
    }
}