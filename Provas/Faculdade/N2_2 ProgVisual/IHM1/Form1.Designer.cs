
namespace IHM1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPortCom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PilotoConectar = new MfgControl.AdvancedHMI.Controls.PilotLight();
            this.btnFechar = new MfgControl.AdvancedHMI.Controls.MomemtaryButton();
            this.btnDesconectar = new MfgControl.AdvancedHMI.Controls.MomemtaryButton();
            this.btnConectar = new MfgControl.AdvancedHMI.Controls.MomemtaryButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblT4 = new System.Windows.Forms.Label();
            this.lblT3 = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblT1 = new System.Windows.Forms.Label();
            this.tank4 = new MfgControl.AdvancedHMI.Controls.Tank();
            this.tank3 = new MfgControl.AdvancedHMI.Controls.Tank();
            this.tank2 = new MfgControl.AdvancedHMI.Controls.Tank();
            this.tank1 = new MfgControl.AdvancedHMI.Controls.Tank();
            this.lblA0 = new System.Windows.Forms.Label();
            this.btnEN = new MfgControl.AdvancedHMI.Controls.MomemtaryButton();
            this.btnDN = new MfgControl.AdvancedHMI.Controls.MomemtaryButton();
            this.pilotL1 = new MfgControl.AdvancedHMI.Controls.PilotLight();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxBaudRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxPortCom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexão Serial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud - Rate";
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(15, 102);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(158, 24);
            this.cbxBaudRate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port Com";
            // 
            // cbxPortCom
            // 
            this.cbxPortCom.FormattingEnabled = true;
            this.cbxPortCom.Location = new System.Drawing.Point(15, 44);
            this.cbxPortCom.Name = "cbxPortCom";
            this.cbxPortCom.Size = new System.Drawing.Size(158, 24);
            this.cbxPortCom.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PilotoConectar);
            this.groupBox2.Controls.Add(this.btnFechar);
            this.groupBox2.Controls.Add(this.btnDesconectar);
            this.groupBox2.Controls.Add(this.btnConectar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controles";
            // 
            // PilotoConectar
            // 
            this.PilotoConectar.Blink = false;
            this.PilotoConectar.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.PilotoConectar.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.PilotoConectar.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.PilotoConectar.Location = new System.Drawing.Point(98, 145);
            this.PilotoConectar.Name = "PilotoConectar";
            this.PilotoConectar.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.PilotoConectar.Size = new System.Drawing.Size(75, 110);
            this.PilotoConectar.TabIndex = 9;
            this.PilotoConectar.Text = "Piloto ON";
            this.PilotoConectar.Value = false;
            // 
            // btnFechar
            // 
            this.btnFechar.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Red;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large;
            this.btnFechar.Location = new System.Drawing.Point(15, 145);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.btnFechar.Size = new System.Drawing.Size(75, 110);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Blue;
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large;
            this.btnDesconectar.Location = new System.Drawing.Point(98, 29);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.btnDesconectar.Size = new System.Drawing.Size(75, 110);
            this.btnDesconectar.TabIndex = 7;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large;
            this.btnConectar.Location = new System.Drawing.Point(15, 29);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.btnConectar.Size = new System.Drawing.Size(75, 110);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblT4);
            this.groupBox3.Controls.Add(this.lblT3);
            this.groupBox3.Controls.Add(this.lblT2);
            this.groupBox3.Controls.Add(this.lblT1);
            this.groupBox3.Controls.Add(this.tank4);
            this.groupBox3.Controls.Add(this.tank3);
            this.groupBox3.Controls.Add(this.tank2);
            this.groupBox3.Controls.Add(this.tank1);
            this.groupBox3.Controls.Add(this.lblA0);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(212, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 315);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Painel de Instrumentação";
            // 
            // lblT4
            // 
            this.lblT4.AutoSize = true;
            this.lblT4.Location = new System.Drawing.Point(324, 257);
            this.lblT4.Name = "lblT4";
            this.lblT4.Size = new System.Drawing.Size(40, 16);
            this.lblT4.TabIndex = 8;
            this.lblT4.Text = "0000";
            // 
            // lblT3
            // 
            this.lblT3.AutoSize = true;
            this.lblT3.Location = new System.Drawing.Point(231, 257);
            this.lblT3.Name = "lblT3";
            this.lblT3.Size = new System.Drawing.Size(40, 16);
            this.lblT3.TabIndex = 7;
            this.lblT3.Text = "0000";
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Location = new System.Drawing.Point(135, 257);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(40, 16);
            this.lblT2.TabIndex = 6;
            this.lblT2.Text = "0000";
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Location = new System.Drawing.Point(34, 257);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(40, 16);
            this.lblT1.TabIndex = 5;
            this.lblT1.Text = "0000";
            // 
            // tank4
            // 
            this.tank4.Location = new System.Drawing.Point(301, 56);
            this.tank4.MaxValue = 1030;
            this.tank4.MinValue = 0;
            this.tank4.Name = "tank4";
            this.tank4.Size = new System.Drawing.Size(88, 198);
            this.tank4.TabIndex = 4;
            this.tank4.TankContentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tank4.Text = "tank4";
            this.tank4.Value = 0F;
            this.tank4.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tank3
            // 
            this.tank3.Location = new System.Drawing.Point(207, 56);
            this.tank3.MaxValue = 1030;
            this.tank3.MinValue = 0;
            this.tank3.Name = "tank3";
            this.tank3.Size = new System.Drawing.Size(88, 198);
            this.tank3.TabIndex = 3;
            this.tank3.TankContentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tank3.Text = "tank3";
            this.tank3.Value = 0F;
            this.tank3.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tank2
            // 
            this.tank2.Location = new System.Drawing.Point(113, 56);
            this.tank2.MaxValue = 1030;
            this.tank2.MinValue = 0;
            this.tank2.Name = "tank2";
            this.tank2.Size = new System.Drawing.Size(88, 198);
            this.tank2.TabIndex = 2;
            this.tank2.TankContentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tank2.Text = "tank2";
            this.tank2.Value = 0F;
            this.tank2.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tank1
            // 
            this.tank1.Location = new System.Drawing.Point(9, 56);
            this.tank1.MaxValue = 1030;
            this.tank1.MinValue = 0;
            this.tank1.Name = "tank1";
            this.tank1.Size = new System.Drawing.Size(88, 198);
            this.tank1.TabIndex = 1;
            this.tank1.TankContentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tank1.Text = "tank1";
            this.tank1.Value = 0F;
            this.tank1.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblA0
            // 
            this.lblA0.AutoSize = true;
            this.lblA0.Location = new System.Drawing.Point(6, 296);
            this.lblA0.Name = "lblA0";
            this.lblA0.Size = new System.Drawing.Size(26, 16);
            this.lblA0.TabIndex = 0;
            this.lblA0.Text = "A0";
            // 
            // btnEN
            // 
            this.btnEN.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Green;
            this.btnEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEN.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large;
            this.btnEN.Location = new System.Drawing.Point(16, 40);
            this.btnEN.Name = "btnEN";
            this.btnEN.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.btnEN.Size = new System.Drawing.Size(41, 60);
            this.btnEN.TabIndex = 7;
            this.btnEN.Text = "EN";
            this.btnEN.Click += new System.EventHandler(this.btnEN_Click);
            // 
            // btnDN
            // 
            this.btnDN.ButtonColor = MfgControl.AdvancedHMI.Controls.MomemtaryButton.ButtonColors.Blue;
            this.btnDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.LegendPlate = MfgControl.AdvancedHMI.Controls.MomemtaryButton.LegendPlates.Large;
            this.btnDN.Location = new System.Drawing.Point(104, 40);
            this.btnDN.Name = "btnDN";
            this.btnDN.OutputType = MfgControl.AdvancedHMI.Controls.MomemtaryButton.OutputTypes.MomentarySet;
            this.btnDN.Size = new System.Drawing.Size(43, 63);
            this.btnDN.TabIndex = 8;
            this.btnDN.Text = "DN";
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // pilotL1
            // 
            this.pilotL1.Blink = false;
            this.pilotL1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotL1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotL1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red;
            this.pilotL1.Location = new System.Drawing.Point(189, 40);
            this.pilotL1.Name = "pilotL1";
            this.pilotL1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotL1.Size = new System.Drawing.Size(43, 63);
            this.pilotL1.TabIndex = 10;
            this.pilotL1.Text = "L1";
            this.pilotL1.Value = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEN);
            this.groupBox4.Controls.Add(this.pilotL1);
            this.groupBox4.Controls.Add(this.btnDN);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(221, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 125);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controle do Painel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 466);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPortCom;
        private System.Windows.Forms.GroupBox groupBox2;
        private MfgControl.AdvancedHMI.Controls.PilotLight PilotoConectar;
        private MfgControl.AdvancedHMI.Controls.MomemtaryButton btnFechar;
        private MfgControl.AdvancedHMI.Controls.MomemtaryButton btnDesconectar;
        private MfgControl.AdvancedHMI.Controls.MomemtaryButton btnConectar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblA0;
        private MfgControl.AdvancedHMI.Controls.MomemtaryButton btnEN;
        private MfgControl.AdvancedHMI.Controls.MomemtaryButton btnDN;
        private MfgControl.AdvancedHMI.Controls.PilotLight pilotL1;
        private MfgControl.AdvancedHMI.Controls.Tank tank4;
        private MfgControl.AdvancedHMI.Controls.Tank tank3;
        private MfgControl.AdvancedHMI.Controls.Tank tank2;
        private MfgControl.AdvancedHMI.Controls.Tank tank1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblT4;
        private System.Windows.Forms.Label lblT3;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblT1;
    }
}

