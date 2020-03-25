namespace hamsi4
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblkasa = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblgazlt = new System.Windows.Forms.Label();
            this.lblproeurodiesellt = new System.Windows.Forms.Label();
            this.lblmaxeurodiesellt = new System.Windows.Forms.Label();
            this.lblmaxkurşunsuz95lt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.prggaz = new System.Windows.Forms.ProgressBar();
            this.prgproeurodiesel = new System.Windows.Forms.ProgressBar();
            this.prgmaxeurodiesel = new System.Windows.Forms.ProgressBar();
            this.prgkursunsuz95 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndepodoldur = new System.Windows.Forms.Button();
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtgaz = new System.Windows.Forms.TextBox();
            this.txtproeuro = new System.Windows.Forms.TextBox();
            this.txtmaxeuro = new System.Windows.Forms.TextBox();
            this.txtkurşunsuz = new System.Windows.Forms.TextBox();
            this.nmrgazlt = new System.Windows.Forms.NumericUpDown();
            this.nmrproeurolt = new System.Windows.Forms.NumericUpDown();
            this.nmrmaxeurolt = new System.Windows.Forms.NumericUpDown();
            this.nmrkursunsuzlt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblgaz = new System.Windows.Forms.Label();
            this.lblproeurodiesel = new System.Windows.Forms.Label();
            this.lblmaxeurodiesel = new System.Windows.Forms.Label();
            this.lblkursunsuz95 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrgazlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrproeurolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrmaxeurolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrkursunsuzlt)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.lblkasa);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(947, 449);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(494, 160);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // lblkasa
            // 
            this.lblkasa.AutoSize = true;
            this.lblkasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkasa.Location = new System.Drawing.Point(126, 56);
            this.lblkasa.Name = "lblkasa";
            this.lblkasa.Size = new System.Drawing.Size(40, 20);
            this.lblkasa.TabIndex = 8;
            this.lblkasa.Text = "0,00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(33, 52);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 27);
            this.label15.TabIndex = 3;
            this.label15.Text = "KASA =";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblgazlt);
            this.groupBox3.Controls.Add(this.lblproeurodiesellt);
            this.groupBox3.Controls.Add(this.lblmaxeurodiesellt);
            this.groupBox3.Controls.Add(this.lblmaxkurşunsuz95lt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.prggaz);
            this.groupBox3.Controls.Add(this.prgproeurodiesel);
            this.groupBox3.Controls.Add(this.prgmaxeurodiesel);
            this.groupBox3.Controls.Add(this.prgkursunsuz95);
            this.groupBox3.Location = new System.Drawing.Point(947, 67);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(494, 364);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // lblgazlt
            // 
            this.lblgazlt.AutoSize = true;
            this.lblgazlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgazlt.Location = new System.Drawing.Point(401, 256);
            this.lblgazlt.Name = "lblgazlt";
            this.lblgazlt.Size = new System.Drawing.Size(40, 20);
            this.lblgazlt.TabIndex = 8;
            this.lblgazlt.Text = "0,00";
            // 
            // lblproeurodiesellt
            // 
            this.lblproeurodiesellt.AutoSize = true;
            this.lblproeurodiesellt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblproeurodiesellt.Location = new System.Drawing.Point(401, 204);
            this.lblproeurodiesellt.Name = "lblproeurodiesellt";
            this.lblproeurodiesellt.Size = new System.Drawing.Size(40, 20);
            this.lblproeurodiesellt.TabIndex = 7;
            this.lblproeurodiesellt.Text = "0,00";
            // 
            // lblmaxeurodiesellt
            // 
            this.lblmaxeurodiesellt.AutoSize = true;
            this.lblmaxeurodiesellt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmaxeurodiesellt.Location = new System.Drawing.Point(401, 153);
            this.lblmaxeurodiesellt.Name = "lblmaxeurodiesellt";
            this.lblmaxeurodiesellt.Size = new System.Drawing.Size(40, 20);
            this.lblmaxeurodiesellt.TabIndex = 6;
            this.lblmaxeurodiesellt.Text = "0,00";
            // 
            // lblmaxkurşunsuz95lt
            // 
            this.lblmaxkurşunsuz95lt.AutoSize = true;
            this.lblmaxkurşunsuz95lt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmaxkurşunsuz95lt.Location = new System.Drawing.Point(401, 102);
            this.lblmaxkurşunsuz95lt.Name = "lblmaxkurşunsuz95lt";
            this.lblmaxkurşunsuz95lt.Size = new System.Drawing.Size(40, 20);
            this.lblmaxkurşunsuz95lt.TabIndex = 5;
            this.lblmaxkurşunsuz95lt.Text = "0,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(42, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(369, 27);
            this.label9.TabIndex = 4;
            this.label9.Text = "DEPODA KALAN PETROL MİKTARI";
            // 
            // prggaz
            // 
            this.prggaz.Location = new System.Drawing.Point(47, 249);
            this.prggaz.Maximum = 10000;
            this.prggaz.Name = "prggaz";
            this.prggaz.Size = new System.Drawing.Size(320, 35);
            this.prggaz.TabIndex = 3;
            // 
            // prgproeurodiesel
            // 
            this.prgproeurodiesel.Location = new System.Drawing.Point(47, 202);
            this.prgproeurodiesel.Maximum = 10000;
            this.prgproeurodiesel.Name = "prgproeurodiesel";
            this.prgproeurodiesel.Size = new System.Drawing.Size(320, 35);
            this.prgproeurodiesel.TabIndex = 2;
            // 
            // prgmaxeurodiesel
            // 
            this.prgmaxeurodiesel.Location = new System.Drawing.Point(47, 151);
            this.prgmaxeurodiesel.Maximum = 10000;
            this.prgmaxeurodiesel.Name = "prgmaxeurodiesel";
            this.prgmaxeurodiesel.Size = new System.Drawing.Size(320, 35);
            this.prgmaxeurodiesel.TabIndex = 1;
            // 
            // prgkursunsuz95
            // 
            this.prgkursunsuz95.Location = new System.Drawing.Point(47, 99);
            this.prgkursunsuz95.Maximum = 10000;
            this.prgkursunsuz95.Name = "prgkursunsuz95";
            this.prgkursunsuz95.Size = new System.Drawing.Size(320, 35);
            this.prgkursunsuz95.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btndepodoldur);
            this.groupBox2.Controls.Add(this.txtplaka);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtgaz);
            this.groupBox2.Controls.Add(this.txtproeuro);
            this.groupBox2.Controls.Add(this.txtmaxeuro);
            this.groupBox2.Controls.Add(this.txtkurşunsuz);
            this.groupBox2.Controls.Add(this.nmrgazlt);
            this.groupBox2.Controls.Add(this.nmrproeurolt);
            this.groupBox2.Controls.Add(this.nmrmaxeurolt);
            this.groupBox2.Controls.Add(this.nmrkursunsuzlt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(474, 67);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(424, 542);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btndepodoldur
            // 
            this.btndepodoldur.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndepodoldur.Location = new System.Drawing.Point(69, 414);
            this.btndepodoldur.Name = "btndepodoldur";
            this.btndepodoldur.Size = new System.Drawing.Size(284, 57);
            this.btndepodoldur.TabIndex = 13;
            this.btndepodoldur.Text = "DEPOYU DOLDUR";
            this.btndepodoldur.UseVisualStyleBackColor = true;
            this.btndepodoldur.Click += new System.EventHandler(this.btndepodoldur_Click);
            // 
            // txtplaka
            // 
            this.txtplaka.Location = new System.Drawing.Point(252, 334);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(125, 22);
            this.txtplaka.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(131, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "PLAKA =";
            // 
            // txtgaz
            // 
            this.txtgaz.Location = new System.Drawing.Point(252, 254);
            this.txtgaz.Name = "txtgaz";
            this.txtgaz.Size = new System.Drawing.Size(125, 22);
            this.txtgaz.TabIndex = 10;
            // 
            // txtproeuro
            // 
            this.txtproeuro.Location = new System.Drawing.Point(252, 197);
            this.txtproeuro.Name = "txtproeuro";
            this.txtproeuro.Size = new System.Drawing.Size(125, 22);
            this.txtproeuro.TabIndex = 9;
            // 
            // txtmaxeuro
            // 
            this.txtmaxeuro.Location = new System.Drawing.Point(252, 151);
            this.txtmaxeuro.Name = "txtmaxeuro";
            this.txtmaxeuro.Size = new System.Drawing.Size(125, 22);
            this.txtmaxeuro.TabIndex = 8;
            // 
            // txtkurşunsuz
            // 
            this.txtkurşunsuz.Location = new System.Drawing.Point(252, 99);
            this.txtkurşunsuz.Name = "txtkurşunsuz";
            this.txtkurşunsuz.Size = new System.Drawing.Size(125, 22);
            this.txtkurşunsuz.TabIndex = 7;
            // 
            // nmrgazlt
            // 
            this.nmrgazlt.Location = new System.Drawing.Point(39, 254);
            this.nmrgazlt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrgazlt.Name = "nmrgazlt";
            this.nmrgazlt.Size = new System.Drawing.Size(120, 22);
            this.nmrgazlt.TabIndex = 6;
            this.nmrgazlt.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // nmrproeurolt
            // 
            this.nmrproeurolt.Location = new System.Drawing.Point(39, 202);
            this.nmrproeurolt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrproeurolt.Name = "nmrproeurolt";
            this.nmrproeurolt.Size = new System.Drawing.Size(120, 22);
            this.nmrproeurolt.TabIndex = 5;
            this.nmrproeurolt.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // nmrmaxeurolt
            // 
            this.nmrmaxeurolt.Location = new System.Drawing.Point(39, 151);
            this.nmrmaxeurolt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrmaxeurolt.Name = "nmrmaxeurolt";
            this.nmrmaxeurolt.Size = new System.Drawing.Size(120, 22);
            this.nmrmaxeurolt.TabIndex = 4;
            this.nmrmaxeurolt.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // nmrkursunsuzlt
            // 
            this.nmrkursunsuzlt.Location = new System.Drawing.Point(39, 104);
            this.nmrkursunsuzlt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrkursunsuzlt.Name = "nmrkursunsuzlt";
            this.nmrkursunsuzlt.Size = new System.Drawing.Size(120, 22);
            this.nmrkursunsuzlt.TabIndex = 3;
            this.nmrkursunsuzlt.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(268, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "TUTAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "LİTRE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblgaz);
            this.groupBox1.Controls.Add(this.lblproeurodiesel);
            this.groupBox1.Controls.Add(this.lblmaxeurodiesel);
            this.groupBox1.Controls.Add(this.lblkursunsuz95);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Y);
            this.groupBox1.Location = new System.Drawing.Point(13, 220);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(429, 389);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblgaz
            // 
            this.lblgaz.AutoSize = true;
            this.lblgaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgaz.Location = new System.Drawing.Point(257, 254);
            this.lblgaz.Name = "lblgaz";
            this.lblgaz.Size = new System.Drawing.Size(40, 20);
            this.lblgaz.TabIndex = 9;
            this.lblgaz.Text = "0,00";
            // 
            // lblproeurodiesel
            // 
            this.lblproeurodiesel.AutoSize = true;
            this.lblproeurodiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblproeurodiesel.Location = new System.Drawing.Point(257, 204);
            this.lblproeurodiesel.Name = "lblproeurodiesel";
            this.lblproeurodiesel.Size = new System.Drawing.Size(40, 20);
            this.lblproeurodiesel.TabIndex = 8;
            this.lblproeurodiesel.Text = "0,00";
            // 
            // lblmaxeurodiesel
            // 
            this.lblmaxeurodiesel.AutoSize = true;
            this.lblmaxeurodiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmaxeurodiesel.Location = new System.Drawing.Point(257, 151);
            this.lblmaxeurodiesel.Name = "lblmaxeurodiesel";
            this.lblmaxeurodiesel.Size = new System.Drawing.Size(40, 20);
            this.lblmaxeurodiesel.TabIndex = 7;
            this.lblmaxeurodiesel.Text = "0,00";
            // 
            // lblkursunsuz95
            // 
            this.lblkursunsuz95.AutoSize = true;
            this.lblkursunsuz95.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkursunsuz95.Location = new System.Drawing.Point(257, 106);
            this.lblkursunsuz95.Name = "lblkursunsuz95";
            this.lblkursunsuz95.Size = new System.Drawing.Size(40, 20);
            this.lblkursunsuz95.TabIndex = 6;
            this.lblkursunsuz95.Text = "0,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(114, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Gaz =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(32, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pro EuroDiesel =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Max EuroDiesel =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Max Kurşunsuz 95 =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(237, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "LİTRE FİYATI";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Y.Location = new System.Drawing.Point(27, 44);
            this.Y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(142, 27);
            this.Y.TabIndex = 0;
            this.Y.Text = "YAKIT TÜRÜ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(558, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 41);
            this.label10.TabIndex = 8;
            this.label10.Text = "HAMSİ PETROL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1481, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrgazlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrproeurolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrmaxeurolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrkursunsuzlt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblkasa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblgazlt;
        private System.Windows.Forms.Label lblproeurodiesellt;
        private System.Windows.Forms.Label lblmaxeurodiesellt;
        private System.Windows.Forms.Label lblmaxkurşunsuz95lt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar prggaz;
        private System.Windows.Forms.ProgressBar prgproeurodiesel;
        private System.Windows.Forms.ProgressBar prgmaxeurodiesel;
        private System.Windows.Forms.ProgressBar prgkursunsuz95;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btndepodoldur;
        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtgaz;
        private System.Windows.Forms.TextBox txtproeuro;
        private System.Windows.Forms.TextBox txtmaxeuro;
        private System.Windows.Forms.TextBox txtkurşunsuz;
        private System.Windows.Forms.NumericUpDown nmrgazlt;
        private System.Windows.Forms.NumericUpDown nmrproeurolt;
        private System.Windows.Forms.NumericUpDown nmrmaxeurolt;
        private System.Windows.Forms.NumericUpDown nmrkursunsuzlt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblgaz;
        private System.Windows.Forms.Label lblproeurodiesel;
        private System.Windows.Forms.Label lblmaxeurodiesel;
        private System.Windows.Forms.Label lblkursunsuz95;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

