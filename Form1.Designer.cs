namespace WinForms_DZ_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_TotalPayForFuel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_FuelSum = new System.Windows.Forms.TextBox();
            this.textBox_FuelAmount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_FuelSum = new System.Windows.Forms.RadioButton();
            this.radioButton_FuelAmount = new System.Windows.Forms.RadioButton();
            this.comboBox_FuelType = new System.Windows.Forms.ComboBox();
            this.textBox_FuelPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label_TotalToPayMarket = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ColaAmount = new System.Windows.Forms.TextBox();
            this.textBox_FreesAmount = new System.Windows.Forms.TextBox();
            this.textBox_HamburgerAmount = new System.Windows.Forms.TextBox();
            this.textBox_HotDogAmount = new System.Windows.Forms.TextBox();
            this.textBox_HamburgerPrice = new System.Windows.Forms.TextBox();
            this.textBox_FreesPrice = new System.Windows.Forms.TextBox();
            this.textBox_ColaPrice = new System.Windows.Forms.TextBox();
            this.textBox_HotDogPrice = new System.Windows.Forms.TextBox();
            this.checkBox_Cola = new System.Windows.Forms.CheckBox();
            this.checkBox_Frees = new System.Windows.Forms.CheckBox();
            this.checkBox_Hamburger = new System.Windows.Forms.CheckBox();
            this.checkBox_HotDog = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label_TotalMoney = new System.Windows.Forms.Label();
            this.button_TotalPaymentClalc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_FuelSum);
            this.groupBox1.Controls.Add(this.textBox_FuelAmount);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.comboBox_FuelType);
            this.groupBox1.Controls.Add(this.textBox_FuelPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(37, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label_TotalPayForFuel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(22, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 114);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "До сплати";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "грн.";
            // 
            // label_TotalPayForFuel
            // 
            this.label_TotalPayForFuel.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TotalPayForFuel.Location = new System.Drawing.Point(55, 20);
            this.label_TotalPayForFuel.Name = "label_TotalPayForFuel";
            this.label_TotalPayForFuel.Size = new System.Drawing.Size(129, 70);
            this.label_TotalPayForFuel.TabIndex = 9;
            this.label_TotalPayForFuel.Text = "00,00";
            this.label_TotalPayForFuel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_TotalPayForFuel.TextChanged += new System.EventHandler(this.label_TotalPayForFuel_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(262, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "грн.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(262, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "л.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(241, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "грн.";
            // 
            // textBox_FuelSum
            // 
            this.textBox_FuelSum.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_FuelSum.Location = new System.Drawing.Point(156, 213);
            this.textBox_FuelSum.MaxLength = 10;
            this.textBox_FuelSum.Name = "textBox_FuelSum";
            this.textBox_FuelSum.Size = new System.Drawing.Size(100, 27);
            this.textBox_FuelSum.TabIndex = 6;
            // 
            // textBox_FuelAmount
            // 
            this.textBox_FuelAmount.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_FuelAmount.Location = new System.Drawing.Point(156, 174);
            this.textBox_FuelAmount.MaxLength = 6;
            this.textBox_FuelAmount.Name = "textBox_FuelAmount";
            this.textBox_FuelAmount.Size = new System.Drawing.Size(100, 27);
            this.textBox_FuelAmount.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_FuelSum);
            this.groupBox2.Controls.Add(this.radioButton_FuelAmount);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(22, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // radioButton_FuelSum
            // 
            this.radioButton_FuelSum.AutoSize = true;
            this.radioButton_FuelSum.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FuelSum.Location = new System.Drawing.Point(7, 61);
            this.radioButton_FuelSum.Name = "radioButton_FuelSum";
            this.radioButton_FuelSum.Size = new System.Drawing.Size(68, 24);
            this.radioButton_FuelSum.TabIndex = 1;
            this.radioButton_FuelSum.TabStop = true;
            this.radioButton_FuelSum.Text = "Сума";
            this.radioButton_FuelSum.UseVisualStyleBackColor = true;
            this.radioButton_FuelSum.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_FuelAmount
            // 
            this.radioButton_FuelAmount.AutoSize = true;
            this.radioButton_FuelAmount.Location = new System.Drawing.Point(7, 22);
            this.radioButton_FuelAmount.Name = "radioButton_FuelAmount";
            this.radioButton_FuelAmount.Size = new System.Drawing.Size(96, 24);
            this.radioButton_FuelAmount.TabIndex = 0;
            this.radioButton_FuelAmount.TabStop = true;
            this.radioButton_FuelAmount.Text = "Кількість";
            this.radioButton_FuelAmount.UseVisualStyleBackColor = true;
            this.radioButton_FuelAmount.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // comboBox_FuelType
            // 
            this.comboBox_FuelType.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_FuelType.FormattingEnabled = true;
            this.comboBox_FuelType.Items.AddRange(new object[] {
            "А - 92",
            "А - 95",
            "А - 98",
            "ДТ",
            "Газ"});
            this.comboBox_FuelType.Location = new System.Drawing.Point(113, 52);
            this.comboBox_FuelType.Name = "comboBox_FuelType";
            this.comboBox_FuelType.Size = new System.Drawing.Size(121, 28);
            this.comboBox_FuelType.TabIndex = 3;
            this.comboBox_FuelType.SelectedIndexChanged += new System.EventHandler(this.comboBox_FuelType_SelectedIndexChanged);
            // 
            // textBox_FuelPrice
            // 
            this.textBox_FuelPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_FuelPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox_FuelPrice.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_FuelPrice.Location = new System.Drawing.Point(113, 106);
            this.textBox_FuelPrice.Name = "textBox_FuelPrice";
            this.textBox_FuelPrice.ReadOnly = true;
            this.textBox_FuelPrice.Size = new System.Drawing.Size(121, 27);
            this.textBox_FuelPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ціна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Паливо";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox_ColaAmount);
            this.groupBox4.Controls.Add(this.textBox_FreesAmount);
            this.groupBox4.Controls.Add(this.textBox_HamburgerAmount);
            this.groupBox4.Controls.Add(this.textBox_HotDogAmount);
            this.groupBox4.Controls.Add(this.textBox_HamburgerPrice);
            this.groupBox4.Controls.Add(this.textBox_FreesPrice);
            this.groupBox4.Controls.Add(this.textBox_ColaPrice);
            this.groupBox4.Controls.Add(this.textBox_HotDogPrice);
            this.groupBox4.Controls.Add(this.checkBox_Cola);
            this.groupBox4.Controls.Add(this.checkBox_Frees);
            this.groupBox4.Controls.Add(this.checkBox_Hamburger);
            this.groupBox4.Controls.Add(this.checkBox_HotDog);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(409, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 407);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Міні-Кафе";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label_TotalToPayMarket);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(18, 281);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(284, 114);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "До сплати";
            // 
            // label_TotalToPayMarket
            // 
            this.label_TotalToPayMarket.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TotalToPayMarket.Location = new System.Drawing.Point(55, 23);
            this.label_TotalToPayMarket.Name = "label_TotalToPayMarket";
            this.label_TotalToPayMarket.Size = new System.Drawing.Size(129, 70);
            this.label_TotalToPayMarket.TabIndex = 11;
            this.label_TotalToPayMarket.Text = "00,00";
            this.label_TotalToPayMarket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_TotalToPayMarket.TextChanged += new System.EventHandler(this.label_TotalToPayMarket_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "грн.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Кількість";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ціна";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_ColaAmount
            // 
            this.textBox_ColaAmount.Enabled = false;
            this.textBox_ColaAmount.Location = new System.Drawing.Point(241, 150);
            this.textBox_ColaAmount.Name = "textBox_ColaAmount";
            this.textBox_ColaAmount.Size = new System.Drawing.Size(61, 27);
            this.textBox_ColaAmount.TabIndex = 11;
            this.textBox_ColaAmount.Text = " 0";
            this.textBox_ColaAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_FreesAmount
            // 
            this.textBox_FreesAmount.Enabled = false;
            this.textBox_FreesAmount.Location = new System.Drawing.Point(241, 118);
            this.textBox_FreesAmount.Name = "textBox_FreesAmount";
            this.textBox_FreesAmount.Size = new System.Drawing.Size(61, 27);
            this.textBox_FreesAmount.TabIndex = 10;
            this.textBox_FreesAmount.Text = " 0";
            this.textBox_FreesAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_HamburgerAmount
            // 
            this.textBox_HamburgerAmount.Enabled = false;
            this.textBox_HamburgerAmount.Location = new System.Drawing.Point(241, 82);
            this.textBox_HamburgerAmount.Name = "textBox_HamburgerAmount";
            this.textBox_HamburgerAmount.Size = new System.Drawing.Size(61, 27);
            this.textBox_HamburgerAmount.TabIndex = 9;
            this.textBox_HamburgerAmount.Text = " 0";
            this.textBox_HamburgerAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_HotDogAmount
            // 
            this.textBox_HotDogAmount.Enabled = false;
            this.textBox_HotDogAmount.Location = new System.Drawing.Point(241, 44);
            this.textBox_HotDogAmount.MaxLength = 2;
            this.textBox_HotDogAmount.Name = "textBox_HotDogAmount";
            this.textBox_HotDogAmount.Size = new System.Drawing.Size(61, 27);
            this.textBox_HotDogAmount.TabIndex = 8;
            this.textBox_HotDogAmount.Text = " 0";
            this.textBox_HotDogAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_HamburgerPrice
            // 
            this.textBox_HamburgerPrice.Location = new System.Drawing.Point(160, 80);
            this.textBox_HamburgerPrice.Name = "textBox_HamburgerPrice";
            this.textBox_HamburgerPrice.ReadOnly = true;
            this.textBox_HamburgerPrice.Size = new System.Drawing.Size(61, 27);
            this.textBox_HamburgerPrice.TabIndex = 7;
            this.textBox_HamburgerPrice.Text = "60";
            this.textBox_HamburgerPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_FreesPrice
            // 
            this.textBox_FreesPrice.Location = new System.Drawing.Point(160, 118);
            this.textBox_FreesPrice.Name = "textBox_FreesPrice";
            this.textBox_FreesPrice.ReadOnly = true;
            this.textBox_FreesPrice.Size = new System.Drawing.Size(61, 27);
            this.textBox_FreesPrice.TabIndex = 6;
            this.textBox_FreesPrice.Text = "35";
            this.textBox_FreesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_ColaPrice
            // 
            this.textBox_ColaPrice.Location = new System.Drawing.Point(160, 150);
            this.textBox_ColaPrice.Name = "textBox_ColaPrice";
            this.textBox_ColaPrice.ReadOnly = true;
            this.textBox_ColaPrice.Size = new System.Drawing.Size(61, 27);
            this.textBox_ColaPrice.TabIndex = 5;
            this.textBox_ColaPrice.Text = "20";
            this.textBox_ColaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_HotDogPrice
            // 
            this.textBox_HotDogPrice.Location = new System.Drawing.Point(160, 44);
            this.textBox_HotDogPrice.Name = "textBox_HotDogPrice";
            this.textBox_HotDogPrice.ReadOnly = true;
            this.textBox_HotDogPrice.Size = new System.Drawing.Size(61, 27);
            this.textBox_HotDogPrice.TabIndex = 4;
            this.textBox_HotDogPrice.Text = "55";
            this.textBox_HotDogPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox_Cola
            // 
            this.checkBox_Cola.AutoSize = true;
            this.checkBox_Cola.Location = new System.Drawing.Point(18, 152);
            this.checkBox_Cola.Name = "checkBox_Cola";
            this.checkBox_Cola.Size = new System.Drawing.Size(110, 24);
            this.checkBox_Cola.TabIndex = 3;
            this.checkBox_Cola.Text = "Кока-Кола";
            this.checkBox_Cola.UseVisualStyleBackColor = true;
            this.checkBox_Cola.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox_Frees
            // 
            this.checkBox_Frees.AutoSize = true;
            this.checkBox_Frees.Location = new System.Drawing.Point(18, 120);
            this.checkBox_Frees.Name = "checkBox_Frees";
            this.checkBox_Frees.Size = new System.Drawing.Size(133, 24);
            this.checkBox_Frees.TabIndex = 2;
            this.checkBox_Frees.Text = "Картопля-фрі";
            this.checkBox_Frees.UseVisualStyleBackColor = true;
            this.checkBox_Frees.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox_Hamburger
            // 
            this.checkBox_Hamburger.AutoSize = true;
            this.checkBox_Hamburger.Location = new System.Drawing.Point(18, 82);
            this.checkBox_Hamburger.Name = "checkBox_Hamburger";
            this.checkBox_Hamburger.Size = new System.Drawing.Size(111, 24);
            this.checkBox_Hamburger.TabIndex = 1;
            this.checkBox_Hamburger.Text = "Гамбургер";
            this.checkBox_Hamburger.UseVisualStyleBackColor = true;
            this.checkBox_Hamburger.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox_HotDog
            // 
            this.checkBox_HotDog.AutoSize = true;
            this.checkBox_HotDog.Location = new System.Drawing.Point(18, 47);
            this.checkBox_HotDog.Name = "checkBox_HotDog";
            this.checkBox_HotDog.Size = new System.Drawing.Size(89, 24);
            this.checkBox_HotDog.TabIndex = 0;
            this.checkBox_HotDog.Text = "Хот-дог";
            this.checkBox_HotDog.UseVisualStyleBackColor = true;
            this.checkBox_HotDog.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label_TotalMoney);
            this.groupBox6.Controls.Add(this.button_TotalPaymentClalc);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(37, 473);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(703, 142);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Всього до сплати";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(580, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "грн.";
            // 
            // label_TotalMoney
            // 
            this.label_TotalMoney.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TotalMoney.Location = new System.Drawing.Point(387, 37);
            this.label_TotalMoney.Name = "label_TotalMoney";
            this.label_TotalMoney.Size = new System.Drawing.Size(187, 80);
            this.label_TotalMoney.TabIndex = 10;
            this.label_TotalMoney.Text = "00,00";
            this.label_TotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_TotalPaymentClalc
            // 
            this.button_TotalPaymentClalc.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_TotalPaymentClalc.Location = new System.Drawing.Point(156, 37);
            this.button_TotalPaymentClalc.Name = "button_TotalPaymentClalc";
            this.button_TotalPaymentClalc.Size = new System.Drawing.Size(192, 91);
            this.button_TotalPaymentClalc.TabIndex = 1;
            this.button_TotalPaymentClalc.Text = "Прорахувати";
            this.button_TotalPaymentClalc.UseVisualStyleBackColor = true;
            this.button_TotalPaymentClalc.Click += new System.EventHandler(this.button_TotalPaymentClalc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 648);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripDropDownButton1.Image = global::WinForms_DZ_3.Properties.Resources.icons8_часы;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = "1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 20);
            this.toolStripStatusLabel1.Text = "                   ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_TotalPayForFuel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_FuelSum;
        private System.Windows.Forms.TextBox textBox_FuelAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_FuelSum;
        private System.Windows.Forms.RadioButton radioButton_FuelAmount;
        private System.Windows.Forms.ComboBox comboBox_FuelType;
        private System.Windows.Forms.TextBox textBox_FuelPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ColaAmount;
        private System.Windows.Forms.TextBox textBox_FreesAmount;
        private System.Windows.Forms.TextBox textBox_HamburgerAmount;
        private System.Windows.Forms.TextBox textBox_HotDogAmount;
        private System.Windows.Forms.TextBox textBox_HamburgerPrice;
        private System.Windows.Forms.TextBox textBox_FreesPrice;
        private System.Windows.Forms.TextBox textBox_ColaPrice;
        private System.Windows.Forms.TextBox textBox_HotDogPrice;
        private System.Windows.Forms.CheckBox checkBox_Cola;
        private System.Windows.Forms.CheckBox checkBox_Frees;
        private System.Windows.Forms.CheckBox checkBox_Hamburger;
        private System.Windows.Forms.CheckBox checkBox_HotDog;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_TotalMoney;
        private System.Windows.Forms.Button button_TotalPaymentClalc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label_TotalToPayMarket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

