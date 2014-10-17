namespace NeuralGate
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radXorGate = new System.Windows.Forms.RadioButton();
            this.radOrGate = new System.Windows.Forms.RadioButton();
            this.radAndGate = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxOut4 = new System.Windows.Forms.TextBox();
            this.btnTrainOnce = new System.Windows.Forms.Button();
            this.btnTrain1000 = new System.Windows.Forms.Button();
            this.tbxIn42 = new System.Windows.Forms.TextBox();
            this.tbxOut3 = new System.Windows.Forms.TextBox();
            this.tbxOut2 = new System.Windows.Forms.TextBox();
            this.tbxIn32 = new System.Windows.Forms.TextBox();
            this.tbxOut1 = new System.Windows.Forms.TextBox();
            this.tbxIn22 = new System.Windows.Forms.TextBox();
            this.tbxIn12 = new System.Windows.Forms.TextBox();
            this.tbxIn41 = new System.Windows.Forms.TextBox();
            this.tbxIn31 = new System.Windows.Forms.TextBox();
            this.tbxIn21 = new System.Windows.Forms.TextBox();
            this.tbxIn11 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxInResult11 = new System.Windows.Forms.TextBox();
            this.tbxInResult21 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxInResult31 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxInResult41 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxInResult12 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxInResult22 = new System.Windows.Forms.TextBox();
            this.tbxOutResult4 = new System.Windows.Forms.TextBox();
            this.tbxOutResult1 = new System.Windows.Forms.TextBox();
            this.tbxInResult32 = new System.Windows.Forms.TextBox();
            this.btnRunGate = new System.Windows.Forms.Button();
            this.tbxOutResult2 = new System.Windows.Forms.TextBox();
            this.tbxInResult42 = new System.Windows.Forms.TextBox();
            this.tbxOutResult3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Gate";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(94, 260);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Gate";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(582, 260);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(501, 260);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset Gate";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.radXorGate);
            this.panel1.Controls.Add(this.radOrGate);
            this.panel1.Controls.Add(this.radAndGate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbxOut4);
            this.panel1.Controls.Add(this.btnTrainOnce);
            this.panel1.Controls.Add(this.btnTrain1000);
            this.panel1.Controls.Add(this.tbxIn42);
            this.panel1.Controls.Add(this.tbxOut3);
            this.panel1.Controls.Add(this.tbxOut2);
            this.panel1.Controls.Add(this.tbxIn32);
            this.panel1.Controls.Add(this.tbxOut1);
            this.panel1.Controls.Add(this.tbxIn22);
            this.panel1.Controls.Add(this.tbxIn12);
            this.panel1.Controls.Add(this.tbxIn41);
            this.panel1.Controls.Add(this.tbxIn31);
            this.panel1.Controls.Add(this.tbxIn21);
            this.panel1.Controls.Add(this.tbxIn11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 241);
            this.panel1.TabIndex = 1;
            // 
            // radXorGate
            // 
            this.radXorGate.AutoSize = true;
            this.radXorGate.Location = new System.Drawing.Point(172, 111);
            this.radXorGate.Name = "radXorGate";
            this.radXorGate.Size = new System.Drawing.Size(99, 17);
            this.radXorGate.TabIndex = 3;
            this.radXorGate.TabStop = true;
            this.radXorGate.Text = "Xor Truth Table";
            this.radXorGate.UseVisualStyleBackColor = true;
            this.radXorGate.CheckedChanged += new System.EventHandler(this.radGate_CheckedChanged);
            // 
            // radOrGate
            // 
            this.radOrGate.AutoSize = true;
            this.radOrGate.Location = new System.Drawing.Point(172, 88);
            this.radOrGate.Name = "radOrGate";
            this.radOrGate.Size = new System.Drawing.Size(94, 17);
            this.radOrGate.TabIndex = 3;
            this.radOrGate.TabStop = true;
            this.radOrGate.Text = "Or Truth Table";
            this.radOrGate.UseVisualStyleBackColor = true;
            this.radOrGate.CheckedChanged += new System.EventHandler(this.radGate_CheckedChanged);
            // 
            // radAndGate
            // 
            this.radAndGate.AutoSize = true;
            this.radAndGate.Location = new System.Drawing.Point(172, 65);
            this.radAndGate.Name = "radAndGate";
            this.radAndGate.Size = new System.Drawing.Size(102, 17);
            this.radAndGate.TabIndex = 3;
            this.radAndGate.TabStop = true;
            this.radAndGate.Text = "And Truth Table";
            this.radAndGate.UseVisualStyleBackColor = true;
            this.radAndGate.CheckedChanged += new System.EventHandler(this.radGate_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "=";
            // 
            // tbxOut4
            // 
            this.tbxOut4.Location = new System.Drawing.Point(100, 141);
            this.tbxOut4.Name = "tbxOut4";
            this.tbxOut4.Size = new System.Drawing.Size(27, 20);
            this.tbxOut4.TabIndex = 1;
            // 
            // btnTrainOnce
            // 
            this.btnTrainOnce.Location = new System.Drawing.Point(149, 186);
            this.btnTrainOnce.Name = "btnTrainOnce";
            this.btnTrainOnce.Size = new System.Drawing.Size(146, 35);
            this.btnTrainOnce.TabIndex = 0;
            this.btnTrainOnce.Text = "Train Once";
            this.btnTrainOnce.UseVisualStyleBackColor = true;
            this.btnTrainOnce.Click += new System.EventHandler(this.btnTrainOnce_Click);
            // 
            // btnTrain1000
            // 
            this.btnTrain1000.Location = new System.Drawing.Point(11, 186);
            this.btnTrain1000.Name = "btnTrain1000";
            this.btnTrain1000.Size = new System.Drawing.Size(132, 35);
            this.btnTrain1000.TabIndex = 0;
            this.btnTrain1000.Text = "Train 1000 Times";
            this.btnTrain1000.UseVisualStyleBackColor = true;
            this.btnTrain1000.Click += new System.EventHandler(this.btnTrain1000_Click);
            // 
            // tbxIn42
            // 
            this.tbxIn42.Location = new System.Drawing.Point(48, 141);
            this.tbxIn42.Name = "tbxIn42";
            this.tbxIn42.ReadOnly = true;
            this.tbxIn42.Size = new System.Drawing.Size(27, 20);
            this.tbxIn42.TabIndex = 1;
            this.tbxIn42.Text = "1";
            // 
            // tbxOut3
            // 
            this.tbxOut3.Location = new System.Drawing.Point(100, 115);
            this.tbxOut3.Name = "tbxOut3";
            this.tbxOut3.Size = new System.Drawing.Size(27, 20);
            this.tbxOut3.TabIndex = 1;
            // 
            // tbxOut2
            // 
            this.tbxOut2.Location = new System.Drawing.Point(100, 89);
            this.tbxOut2.Name = "tbxOut2";
            this.tbxOut2.Size = new System.Drawing.Size(27, 20);
            this.tbxOut2.TabIndex = 1;
            // 
            // tbxIn32
            // 
            this.tbxIn32.Location = new System.Drawing.Point(48, 115);
            this.tbxIn32.Name = "tbxIn32";
            this.tbxIn32.ReadOnly = true;
            this.tbxIn32.Size = new System.Drawing.Size(27, 20);
            this.tbxIn32.TabIndex = 1;
            this.tbxIn32.Text = "0";
            // 
            // tbxOut1
            // 
            this.tbxOut1.Location = new System.Drawing.Point(100, 63);
            this.tbxOut1.Name = "tbxOut1";
            this.tbxOut1.Size = new System.Drawing.Size(27, 20);
            this.tbxOut1.TabIndex = 1;
            // 
            // tbxIn22
            // 
            this.tbxIn22.Location = new System.Drawing.Point(48, 89);
            this.tbxIn22.Name = "tbxIn22";
            this.tbxIn22.ReadOnly = true;
            this.tbxIn22.Size = new System.Drawing.Size(27, 20);
            this.tbxIn22.TabIndex = 1;
            this.tbxIn22.Text = "1";
            // 
            // tbxIn12
            // 
            this.tbxIn12.Location = new System.Drawing.Point(48, 63);
            this.tbxIn12.Name = "tbxIn12";
            this.tbxIn12.ReadOnly = true;
            this.tbxIn12.Size = new System.Drawing.Size(27, 20);
            this.tbxIn12.TabIndex = 1;
            this.tbxIn12.Text = "0";
            // 
            // tbxIn41
            // 
            this.tbxIn41.Location = new System.Drawing.Point(11, 141);
            this.tbxIn41.Name = "tbxIn41";
            this.tbxIn41.ReadOnly = true;
            this.tbxIn41.Size = new System.Drawing.Size(27, 20);
            this.tbxIn41.TabIndex = 1;
            this.tbxIn41.Text = "1";
            // 
            // tbxIn31
            // 
            this.tbxIn31.Location = new System.Drawing.Point(11, 115);
            this.tbxIn31.Name = "tbxIn31";
            this.tbxIn31.ReadOnly = true;
            this.tbxIn31.Size = new System.Drawing.Size(27, 20);
            this.tbxIn31.TabIndex = 1;
            this.tbxIn31.Text = "1";
            // 
            // tbxIn21
            // 
            this.tbxIn21.Location = new System.Drawing.Point(11, 89);
            this.tbxIn21.Name = "tbxIn21";
            this.tbxIn21.ReadOnly = true;
            this.tbxIn21.Size = new System.Drawing.Size(27, 20);
            this.tbxIn21.TabIndex = 1;
            this.tbxIn21.Text = "0";
            // 
            // tbxIn11
            // 
            this.tbxIn11.Location = new System.Drawing.Point(11, 63);
            this.tbxIn11.Name = "tbxIn11";
            this.tbxIn11.ReadOnly = true;
            this.tbxIn11.Size = new System.Drawing.Size(27, 20);
            this.tbxIn11.TabIndex = 1;
            this.tbxIn11.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step 1 : Train the network using thruth table";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbxInResult11);
            this.panel2.Controls.Add(this.tbxInResult21);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbxInResult31);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbxInResult41);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbxInResult12);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbxInResult22);
            this.panel2.Controls.Add(this.tbxOutResult4);
            this.panel2.Controls.Add(this.tbxOutResult1);
            this.panel2.Controls.Add(this.tbxInResult32);
            this.panel2.Controls.Add(this.btnRunGate);
            this.panel2.Controls.Add(this.tbxOutResult2);
            this.panel2.Controls.Add(this.tbxInResult42);
            this.panel2.Controls.Add(this.tbxOutResult3);
            this.panel2.Location = new System.Drawing.Point(338, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 241);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Step 2 : Run the network and see";
            // 
            // tbxInResult11
            // 
            this.tbxInResult11.Location = new System.Drawing.Point(16, 63);
            this.tbxInResult11.Name = "tbxInResult11";
            this.tbxInResult11.ReadOnly = true;
            this.tbxInResult11.Size = new System.Drawing.Size(27, 20);
            this.tbxInResult11.TabIndex = 1;
            this.tbxInResult11.Text = "0";
            // 
            // tbxInResult21
            // 
            this.tbxInResult21.Location = new System.Drawing.Point(16, 89);
            this.tbxInResult21.Name = "tbxInResult21";
            this.tbxInResult21.ReadOnly = true;
            this.tbxInResult21.Size = new System.Drawing.Size(27, 20);
            this.tbxInResult21.TabIndex = 1;
            this.tbxInResult21.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "=";
            // 
            // tbxInResult31
            // 
            this.tbxInResult31.Location = new System.Drawing.Point(16, 115);
            this.tbxInResult31.Name = "tbxInResult31";
            this.tbxInResult31.ReadOnly = true;
            this.tbxInResult31.Size = new System.Drawing.Size(27, 20);
            this.tbxInResult31.TabIndex = 1;
            this.tbxInResult31.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "=";
            // 
            // tbxInResult41
            // 
            this.tbxInResult41.Location = new System.Drawing.Point(16, 141);
            this.tbxInResult41.Name = "tbxInResult41";
            this.tbxInResult41.ReadOnly = true;
            this.tbxInResult41.Size = new System.Drawing.Size(27, 20);
            this.tbxInResult41.TabIndex = 1;
            this.tbxInResult41.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "=";
            // 
            // tbxInResult12
            // 
            this.tbxInResult12.Location = new System.Drawing.Point(53, 63);
            this.tbxInResult12.Name = "tbxInResult12";
            this.tbxInResult12.ReadOnly = true;
            this.tbxInResult12.Size = new System.Drawing.Size(27, 20);
            this.tbxInResult12.TabIndex = 1;
            this.tbxInResult12.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "=";
            // 
            // tbxInResult22
            // 
            this.tbxInResult22.Location = new System.Drawing.Point(53, 89);
            this.tbxInResult22.Name = "tbxInResult22";
            this.tbxInResult22.ReadOnly = true;
            this.tbxInResult22.Size = new System.Drawing.Size(27, 20);
            this.tbxInResult22.TabIndex = 1;
            this.tbxInResult22.Text = "1";
            // 
            // tbxOutResult4
            // 
            this.tbxOutResult4.Location = new System.Drawing.Point(105, 141);
            this.tbxOutResult4.Name = "tbxOutResult4";
            this.tbxOutResult4.ReadOnly = true;
            this.tbxOutResult4.Size = new System.Drawing.Size(185, 20);
            this.tbxOutResult4.TabIndex = 1;
            // 
            // tbxOutResult1
            // 
            this.tbxOutResult1.Location = new System.Drawing.Point(105, 63);
            this.tbxOutResult1.Name = "tbxOutResult1";
            this.tbxOutResult1.ReadOnly = true;
            this.tbxOutResult1.Size = new System.Drawing.Size(185, 20);
            this.tbxOutResult1.TabIndex = 1;
            // 
            // tbxInResult32
            // 
            this.tbxInResult32.Location = new System.Drawing.Point(53, 115);
            this.tbxInResult32.Name = "tbxInResult32";
            this.tbxInResult32.ReadOnly = true;
            this.tbxInResult32.Size = new System.Drawing.Size(27, 20);
            this.tbxInResult32.TabIndex = 1;
            this.tbxInResult32.Text = "0";
            // 
            // btnRunGate
            // 
            this.btnRunGate.Location = new System.Drawing.Point(16, 186);
            this.btnRunGate.Name = "btnRunGate";
            this.btnRunGate.Size = new System.Drawing.Size(132, 35);
            this.btnRunGate.TabIndex = 0;
            this.btnRunGate.Text = "Run network";
            this.btnRunGate.UseVisualStyleBackColor = true;
            this.btnRunGate.Click += new System.EventHandler(this.btnRunGate_Click);
            // 
            // tbxOutResult2
            // 
            this.tbxOutResult2.Location = new System.Drawing.Point(105, 89);
            this.tbxOutResult2.Name = "tbxOutResult2";
            this.tbxOutResult2.ReadOnly = true;
            this.tbxOutResult2.Size = new System.Drawing.Size(185, 20);
            this.tbxOutResult2.TabIndex = 1;
            // 
            // tbxInResult42
            // 
            this.tbxInResult42.Location = new System.Drawing.Point(53, 141);
            this.tbxInResult42.Name = "tbxInResult42";
            this.tbxInResult42.ReadOnly = true;
            this.tbxInResult42.Size = new System.Drawing.Size(27, 20);
            this.tbxInResult42.TabIndex = 1;
            this.tbxInResult42.Text = "1";
            // 
            // tbxOutResult3
            // 
            this.tbxOutResult3.Location = new System.Drawing.Point(105, 115);
            this.tbxOutResult3.Name = "tbxOutResult3";
            this.tbxOutResult3.ReadOnly = true;
            this.tbxOutResult3.Size = new System.Drawing.Size(185, 20);
            this.tbxOutResult3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 295);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radXorGate;
        private System.Windows.Forms.RadioButton radOrGate;
        private System.Windows.Forms.RadioButton radAndGate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxOut4;
        private System.Windows.Forms.Button btnTrainOnce;
        private System.Windows.Forms.Button btnTrain1000;
        private System.Windows.Forms.TextBox tbxIn42;
        private System.Windows.Forms.TextBox tbxOut3;
        private System.Windows.Forms.TextBox tbxOut2;
        private System.Windows.Forms.TextBox tbxIn32;
        private System.Windows.Forms.TextBox tbxOut1;
        private System.Windows.Forms.TextBox tbxIn22;
        private System.Windows.Forms.TextBox tbxIn12;
        private System.Windows.Forms.TextBox tbxIn41;
        private System.Windows.Forms.TextBox tbxIn31;
        private System.Windows.Forms.TextBox tbxIn21;
        private System.Windows.Forms.TextBox tbxIn11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxInResult11;
        private System.Windows.Forms.TextBox tbxInResult21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxInResult31;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxInResult41;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxInResult12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxInResult22;
        private System.Windows.Forms.TextBox tbxOutResult4;
        private System.Windows.Forms.TextBox tbxOutResult1;
        private System.Windows.Forms.TextBox tbxInResult32;
        private System.Windows.Forms.Button btnRunGate;
        private System.Windows.Forms.TextBox tbxOutResult2;
        private System.Windows.Forms.TextBox tbxInResult42;
        private System.Windows.Forms.TextBox tbxOutResult3;
    }
}

