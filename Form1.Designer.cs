namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_refration = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.refraction_send = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.refraction_OS_CVD = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.refraction_OS_BCVA = new System.Windows.Forms.TextBox();
            this.refraction_OS_UcVA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.refraction_OS_ax = new System.Windows.Forms.NumericUpDown();
            this.refraction_OS_Cyl = new System.Windows.Forms.NumericUpDown();
            this.refraction_OS_Sph = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.refraction_OD_CVD = new System.Windows.Forms.NumericUpDown();
            this.refraction_OD_CVD_label = new System.Windows.Forms.Label();
            this.refraction_OD_BCVA = new System.Windows.Forms.TextBox();
            this.refraction_OD_UcVA = new System.Windows.Forms.TextBox();
            this.lbl_BCVAOD = new System.Windows.Forms.Label();
            this.lbl_UcVAOD = new System.Windows.Forms.Label();
            this.refraction_OD_ax = new System.Windows.Forms.NumericUpDown();
            this.refraction_OD_Cyl = new System.Windows.Forms.NumericUpDown();
            this.refraction_OD_Sph = new System.Windows.Forms.NumericUpDown();
            this.lbl_Ax = new System.Windows.Forms.Label();
            this.lbl_Cyl = new System.Windows.Forms.Label();
            this.lbl_Sph = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.refraction_ID = new System.Windows.Forms.TextBox();
            this.groupBox_schedule = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.schedule_physician = new System.Windows.Forms.TextBox();
            this.schedule_send = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.schedule_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.schedule_AccessionNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.schedule_ID = new System.Windows.Forms.TextBox();
            this.groupBox_create = new System.Windows.Forms.GroupBox();
            this.create_gender = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.create_PMSid = new System.Windows.Forms.TextBox();
            this.create_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Birthdate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.create_FN = new System.Windows.Forms.TextBox();
            this.create_LN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.create_send = new System.Windows.Forms.Button();
            this.lbl_PatientId = new System.Windows.Forms.Label();
            this.create_ID = new System.Windows.Forms.TextBox();
            this.richTextBox_msg = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer_exitApp = new System.Windows.Forms.Timer(this.components);
            this.groupBox_refration.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OS_CVD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OS_ax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OS_Cyl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OS_Sph)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OD_CVD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OD_ax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OD_Cyl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OD_Sph)).BeginInit();
            this.groupBox_schedule.SuspendLayout();
            this.groupBox_create.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_refration
            // 
            this.groupBox_refration.Controls.Add(this.label15);
            this.groupBox_refration.Controls.Add(this.refraction_send);
            this.groupBox_refration.Controls.Add(this.groupBox5);
            this.groupBox_refration.Controls.Add(this.groupBox4);
            this.groupBox_refration.Controls.Add(this.label3);
            this.groupBox_refration.Controls.Add(this.refraction_ID);
            this.groupBox_refration.Location = new System.Drawing.Point(346, 12);
            this.groupBox_refration.Name = "groupBox_refration";
            this.groupBox_refration.Size = new System.Drawing.Size(314, 337);
            this.groupBox_refration.TabIndex = 5;
            this.groupBox_refration.TabStop = false;
            this.groupBox_refration.Text = "Assign Refractive data";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 301);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 18);
            this.label15.TabIndex = 64;
            this.label15.Text = "CVD default is 12,5mm";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refraction_send
            // 
            this.refraction_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refraction_send.Location = new System.Drawing.Point(222, 308);
            this.refraction_send.Name = "refraction_send";
            this.refraction_send.Size = new System.Drawing.Size(75, 23);
            this.refraction_send.TabIndex = 1;
            this.refraction_send.Text = "Send";
            this.refraction_send.UseVisualStyleBackColor = true;
            this.refraction_send.Click += new System.EventHandler(this.refraction_send_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.refraction_OS_CVD);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.refraction_OS_BCVA);
            this.groupBox5.Controls.Add(this.refraction_OS_UcVA);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.refraction_OS_ax);
            this.groupBox5.Controls.Add(this.refraction_OS_Cyl);
            this.groupBox5.Controls.Add(this.refraction_OS_Sph);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(6, 187);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(288, 111);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "OS";
            // 
            // refraction_OS_CVD
            // 
            this.refraction_OS_CVD.DecimalPlaces = 2;
            this.refraction_OS_CVD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.refraction_OS_CVD.Location = new System.Drawing.Point(106, 81);
            this.refraction_OS_CVD.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.refraction_OS_CVD.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.refraction_OS_CVD.Name = "refraction_OS_CVD";
            this.refraction_OS_CVD.Size = new System.Drawing.Size(82, 20);
            this.refraction_OS_CVD.TabIndex = 64;
            this.refraction_OS_CVD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(8, 82);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 16);
            this.label14.TabIndex = 65;
            this.label14.Text = "Vertex CVD [mm]";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refraction_OS_BCVA
            // 
            this.refraction_OS_BCVA.Location = new System.Drawing.Point(211, 55);
            this.refraction_OS_BCVA.MaxLength = 10;
            this.refraction_OS_BCVA.Name = "refraction_OS_BCVA";
            this.refraction_OS_BCVA.Size = new System.Drawing.Size(74, 20);
            this.refraction_OS_BCVA.TabIndex = 4;
            // 
            // refraction_OS_UcVA
            // 
            this.refraction_OS_UcVA.Location = new System.Drawing.Point(67, 55);
            this.refraction_OS_UcVA.MaxLength = 10;
            this.refraction_OS_UcVA.Name = "refraction_OS_UcVA";
            this.refraction_OS_UcVA.Size = new System.Drawing.Size(74, 20);
            this.refraction_OS_UcVA.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(148, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 61;
            this.label4.Text = "BCVA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 59;
            this.label5.Text = "UcVA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refraction_OS_ax
            // 
            this.refraction_OS_ax.Location = new System.Drawing.Point(203, 32);
            this.refraction_OS_ax.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.refraction_OS_ax.Name = "refraction_OS_ax";
            this.refraction_OS_ax.Size = new System.Drawing.Size(82, 20);
            this.refraction_OS_ax.TabIndex = 2;
            this.refraction_OS_ax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // refraction_OS_Cyl
            // 
            this.refraction_OS_Cyl.DecimalPlaces = 2;
            this.refraction_OS_Cyl.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.refraction_OS_Cyl.Location = new System.Drawing.Point(111, 33);
            this.refraction_OS_Cyl.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.refraction_OS_Cyl.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.refraction_OS_Cyl.Name = "refraction_OS_Cyl";
            this.refraction_OS_Cyl.Size = new System.Drawing.Size(82, 20);
            this.refraction_OS_Cyl.TabIndex = 1;
            this.refraction_OS_Cyl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // refraction_OS_Sph
            // 
            this.refraction_OS_Sph.DecimalPlaces = 2;
            this.refraction_OS_Sph.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.refraction_OS_Sph.Location = new System.Drawing.Point(7, 32);
            this.refraction_OS_Sph.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.refraction_OS_Sph.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.refraction_OS_Sph.Name = "refraction_OS_Sph";
            this.refraction_OS_Sph.Size = new System.Drawing.Size(82, 20);
            this.refraction_OS_Sph.TabIndex = 0;
            this.refraction_OS_Sph.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(193, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Ax [°]";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(108, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Cyl [D]";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Sph [D]";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.refraction_OD_CVD);
            this.groupBox4.Controls.Add(this.refraction_OD_CVD_label);
            this.groupBox4.Controls.Add(this.refraction_OD_BCVA);
            this.groupBox4.Controls.Add(this.refraction_OD_UcVA);
            this.groupBox4.Controls.Add(this.lbl_BCVAOD);
            this.groupBox4.Controls.Add(this.lbl_UcVAOD);
            this.groupBox4.Controls.Add(this.refraction_OD_ax);
            this.groupBox4.Controls.Add(this.refraction_OD_Cyl);
            this.groupBox4.Controls.Add(this.refraction_OD_Sph);
            this.groupBox4.Controls.Add(this.lbl_Ax);
            this.groupBox4.Controls.Add(this.lbl_Cyl);
            this.groupBox4.Controls.Add(this.lbl_Sph);
            this.groupBox4.Location = new System.Drawing.Point(6, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 114);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OD";
            // 
            // refraction_OD_CVD
            // 
            this.refraction_OD_CVD.DecimalPlaces = 2;
            this.refraction_OD_CVD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.refraction_OD_CVD.Location = new System.Drawing.Point(109, 81);
            this.refraction_OD_CVD.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.refraction_OD_CVD.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.refraction_OD_CVD.Name = "refraction_OD_CVD";
            this.refraction_OD_CVD.Size = new System.Drawing.Size(82, 20);
            this.refraction_OD_CVD.TabIndex = 62;
            this.refraction_OD_CVD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // refraction_OD_CVD_label
            // 
            this.refraction_OD_CVD_label.Location = new System.Drawing.Point(11, 83);
            this.refraction_OD_CVD_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.refraction_OD_CVD_label.Name = "refraction_OD_CVD_label";
            this.refraction_OD_CVD_label.Size = new System.Drawing.Size(97, 12);
            this.refraction_OD_CVD_label.TabIndex = 63;
            this.refraction_OD_CVD_label.Text = "Vertex CVD [mm]";
            this.refraction_OD_CVD_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refraction_OD_BCVA
            // 
            this.refraction_OD_BCVA.Location = new System.Drawing.Point(210, 55);
            this.refraction_OD_BCVA.MaxLength = 10;
            this.refraction_OD_BCVA.Name = "refraction_OD_BCVA";
            this.refraction_OD_BCVA.Size = new System.Drawing.Size(74, 20);
            this.refraction_OD_BCVA.TabIndex = 4;
            // 
            // refraction_OD_UcVA
            // 
            this.refraction_OD_UcVA.Location = new System.Drawing.Point(66, 55);
            this.refraction_OD_UcVA.MaxLength = 10;
            this.refraction_OD_UcVA.Name = "refraction_OD_UcVA";
            this.refraction_OD_UcVA.Size = new System.Drawing.Size(74, 20);
            this.refraction_OD_UcVA.TabIndex = 3;
            // 
            // lbl_BCVAOD
            // 
            this.lbl_BCVAOD.Location = new System.Drawing.Point(147, 55);
            this.lbl_BCVAOD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BCVAOD.Name = "lbl_BCVAOD";
            this.lbl_BCVAOD.Size = new System.Drawing.Size(56, 21);
            this.lbl_BCVAOD.TabIndex = 61;
            this.lbl_BCVAOD.Text = "BCVA";
            this.lbl_BCVAOD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_UcVAOD
            // 
            this.lbl_UcVAOD.Location = new System.Drawing.Point(3, 55);
            this.lbl_UcVAOD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UcVAOD.Name = "lbl_UcVAOD";
            this.lbl_UcVAOD.Size = new System.Drawing.Size(56, 21);
            this.lbl_UcVAOD.TabIndex = 59;
            this.lbl_UcVAOD.Text = "UcVA";
            this.lbl_UcVAOD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refraction_OD_ax
            // 
            this.refraction_OD_ax.Location = new System.Drawing.Point(202, 32);
            this.refraction_OD_ax.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.refraction_OD_ax.Name = "refraction_OD_ax";
            this.refraction_OD_ax.Size = new System.Drawing.Size(82, 20);
            this.refraction_OD_ax.TabIndex = 2;
            this.refraction_OD_ax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // refraction_OD_Cyl
            // 
            this.refraction_OD_Cyl.DecimalPlaces = 2;
            this.refraction_OD_Cyl.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.refraction_OD_Cyl.Location = new System.Drawing.Point(110, 33);
            this.refraction_OD_Cyl.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.refraction_OD_Cyl.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.refraction_OD_Cyl.Name = "refraction_OD_Cyl";
            this.refraction_OD_Cyl.Size = new System.Drawing.Size(82, 20);
            this.refraction_OD_Cyl.TabIndex = 1;
            this.refraction_OD_Cyl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // refraction_OD_Sph
            // 
            this.refraction_OD_Sph.DecimalPlaces = 2;
            this.refraction_OD_Sph.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.refraction_OD_Sph.Location = new System.Drawing.Point(6, 32);
            this.refraction_OD_Sph.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.refraction_OD_Sph.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.refraction_OD_Sph.Name = "refraction_OD_Sph";
            this.refraction_OD_Sph.Size = new System.Drawing.Size(82, 20);
            this.refraction_OD_Sph.TabIndex = 0;
            this.refraction_OD_Sph.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Ax
            // 
            this.lbl_Ax.Location = new System.Drawing.Point(192, 16);
            this.lbl_Ax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ax.Name = "lbl_Ax";
            this.lbl_Ax.Size = new System.Drawing.Size(80, 16);
            this.lbl_Ax.TabIndex = 55;
            this.lbl_Ax.Text = "Ax [°]";
            this.lbl_Ax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Cyl
            // 
            this.lbl_Cyl.Location = new System.Drawing.Point(107, 16);
            this.lbl_Cyl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Cyl.Name = "lbl_Cyl";
            this.lbl_Cyl.Size = new System.Drawing.Size(80, 16);
            this.lbl_Cyl.TabIndex = 54;
            this.lbl_Cyl.Text = "Cyl [D]";
            this.lbl_Cyl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Sph
            // 
            this.lbl_Sph.Location = new System.Drawing.Point(7, 16);
            this.lbl_Sph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sph.Name = "lbl_Sph";
            this.lbl_Sph.Size = new System.Drawing.Size(80, 16);
            this.lbl_Sph.TabIndex = 53;
            this.lbl_Sph.Text = "Sph [D]";
            this.lbl_Sph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Patient ID:";
            // 
            // refraction_ID
            // 
            this.refraction_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.refraction_ID.Location = new System.Drawing.Point(9, 44);
            this.refraction_ID.Name = "refraction_ID";
            this.refraction_ID.Size = new System.Drawing.Size(140, 20);
            this.refraction_ID.TabIndex = 0;
            // 
            // groupBox_schedule
            // 
            this.groupBox_schedule.Controls.Add(this.label13);
            this.groupBox_schedule.Controls.Add(this.schedule_physician);
            this.groupBox_schedule.Controls.Add(this.schedule_send);
            this.groupBox_schedule.Controls.Add(this.label12);
            this.groupBox_schedule.Controls.Add(this.schedule_date);
            this.groupBox_schedule.Controls.Add(this.label2);
            this.groupBox_schedule.Controls.Add(this.schedule_AccessionNumber);
            this.groupBox_schedule.Controls.Add(this.label1);
            this.groupBox_schedule.Controls.Add(this.schedule_ID);
            this.groupBox_schedule.Location = new System.Drawing.Point(179, 12);
            this.groupBox_schedule.Name = "groupBox_schedule";
            this.groupBox_schedule.Size = new System.Drawing.Size(161, 337);
            this.groupBox_schedule.TabIndex = 4;
            this.groupBox_schedule.TabStop = false;
            this.groupBox_schedule.Text = "Schedule Procedure";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Physician:";
            // 
            // schedule_physician
            // 
            this.schedule_physician.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.schedule_physician.Location = new System.Drawing.Point(9, 164);
            this.schedule_physician.Name = "schedule_physician";
            this.schedule_physician.Size = new System.Drawing.Size(140, 20);
            this.schedule_physician.TabIndex = 50;
            // 
            // schedule_send
            // 
            this.schedule_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.schedule_send.Location = new System.Drawing.Point(71, 308);
            this.schedule_send.Name = "schedule_send";
            this.schedule_send.Size = new System.Drawing.Size(75, 23);
            this.schedule_send.TabIndex = 3;
            this.schedule_send.Text = "Send";
            this.schedule_send.UseVisualStyleBackColor = true;
            this.schedule_send.Click += new System.EventHandler(this.schedule_send_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Date:";
            // 
            // schedule_date
            // 
            this.schedule_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.schedule_date.CustomFormat = "yyyy-MM-dd HH:mm";
            this.schedule_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.schedule_date.Location = new System.Drawing.Point(6, 122);
            this.schedule_date.MaxDate = new System.DateTime(3333, 12, 31, 0, 0, 0, 0);
            this.schedule_date.MinDate = new System.DateTime(1899, 1, 1, 0, 0, 0, 0);
            this.schedule_date.Name = "schedule_date";
            this.schedule_date.Size = new System.Drawing.Size(143, 20);
            this.schedule_date.TabIndex = 2;
            this.schedule_date.Value = new System.DateTime(2012, 12, 31, 23, 59, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Accession Number:";
            // 
            // schedule_AccessionNumber
            // 
            this.schedule_AccessionNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.schedule_AccessionNumber.Location = new System.Drawing.Point(9, 83);
            this.schedule_AccessionNumber.Name = "schedule_AccessionNumber";
            this.schedule_AccessionNumber.Size = new System.Drawing.Size(140, 20);
            this.schedule_AccessionNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Patient ID:";
            // 
            // schedule_ID
            // 
            this.schedule_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.schedule_ID.Location = new System.Drawing.Point(9, 44);
            this.schedule_ID.Name = "schedule_ID";
            this.schedule_ID.Size = new System.Drawing.Size(140, 20);
            this.schedule_ID.TabIndex = 0;
            // 
            // groupBox_create
            // 
            this.groupBox_create.Controls.Add(this.create_gender);
            this.groupBox_create.Controls.Add(this.label9);
            this.groupBox_create.Controls.Add(this.create_PMSid);
            this.groupBox_create.Controls.Add(this.create_dateTimePicker);
            this.groupBox_create.Controls.Add(this.lbl_Gender);
            this.groupBox_create.Controls.Add(this.lbl_Birthdate);
            this.groupBox_create.Controls.Add(this.label10);
            this.groupBox_create.Controls.Add(this.create_FN);
            this.groupBox_create.Controls.Add(this.create_LN);
            this.groupBox_create.Controls.Add(this.label11);
            this.groupBox_create.Controls.Add(this.create_send);
            this.groupBox_create.Controls.Add(this.lbl_PatientId);
            this.groupBox_create.Controls.Add(this.create_ID);
            this.groupBox_create.Location = new System.Drawing.Point(12, 12);
            this.groupBox_create.Name = "groupBox_create";
            this.groupBox_create.Size = new System.Drawing.Size(161, 337);
            this.groupBox_create.TabIndex = 3;
            this.groupBox_create.TabStop = false;
            this.groupBox_create.Text = "Create Patient";
            // 
            // create_gender
            // 
            this.create_gender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.create_gender.Location = new System.Drawing.Point(11, 203);
            this.create_gender.Name = "create_gender";
            this.create_gender.Size = new System.Drawing.Size(140, 20);
            this.create_gender.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "PMS Identifier:";
            // 
            // create_PMSid
            // 
            this.create_PMSid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.create_PMSid.Enabled = false;
            this.create_PMSid.Location = new System.Drawing.Point(11, 258);
            this.create_PMSid.Name = "create_PMSid";
            this.create_PMSid.Size = new System.Drawing.Size(140, 20);
            this.create_PMSid.TabIndex = 5;
            this.create_PMSid.Text = "SCHWIND_medNet";
            // 
            // create_dateTimePicker
            // 
            this.create_dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.create_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.create_dateTimePicker.Location = new System.Drawing.Point(9, 164);
            this.create_dateTimePicker.MaxDate = new System.DateTime(2037, 12, 31, 0, 0, 0, 0);
            this.create_dateTimePicker.Name = "create_dateTimePicker";
            this.create_dateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.create_dateTimePicker.TabIndex = 3;
            this.create_dateTimePicker.Value = new System.DateTime(2012, 12, 31, 0, 0, 0, 0);
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Location = new System.Drawing.Point(8, 187);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(71, 13);
            this.lbl_Gender.TabIndex = 51;
            this.lbl_Gender.Text = "Gender  [M|F]";
            // 
            // lbl_Birthdate
            // 
            this.lbl_Birthdate.AutoSize = true;
            this.lbl_Birthdate.Location = new System.Drawing.Point(8, 145);
            this.lbl_Birthdate.Name = "lbl_Birthdate";
            this.lbl_Birthdate.Size = new System.Drawing.Size(52, 13);
            this.lbl_Birthdate.TabIndex = 50;
            this.lbl_Birthdate.Text = "Birthdate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "First Name:";
            // 
            // create_FN
            // 
            this.create_FN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.create_FN.Location = new System.Drawing.Point(9, 83);
            this.create_FN.Name = "create_FN";
            this.create_FN.Size = new System.Drawing.Size(140, 20);
            this.create_FN.TabIndex = 1;
            // 
            // create_LN
            // 
            this.create_LN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.create_LN.Location = new System.Drawing.Point(9, 122);
            this.create_LN.Name = "create_LN";
            this.create_LN.Size = new System.Drawing.Size(140, 20);
            this.create_LN.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Last Name:";
            // 
            // create_send
            // 
            this.create_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.create_send.Location = new System.Drawing.Point(80, 308);
            this.create_send.Name = "create_send";
            this.create_send.Size = new System.Drawing.Size(75, 23);
            this.create_send.TabIndex = 6;
            this.create_send.Text = "Send";
            this.create_send.UseVisualStyleBackColor = true;
            this.create_send.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // lbl_PatientId
            // 
            this.lbl_PatientId.AutoSize = true;
            this.lbl_PatientId.Location = new System.Drawing.Point(6, 28);
            this.lbl_PatientId.Name = "lbl_PatientId";
            this.lbl_PatientId.Size = new System.Drawing.Size(57, 13);
            this.lbl_PatientId.TabIndex = 42;
            this.lbl_PatientId.Text = "Patient ID:";
            // 
            // create_ID
            // 
            this.create_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.create_ID.Location = new System.Drawing.Point(9, 44);
            this.create_ID.Name = "create_ID";
            this.create_ID.Size = new System.Drawing.Size(140, 20);
            this.create_ID.TabIndex = 0;
            // 
            // richTextBox_msg
            // 
            this.richTextBox_msg.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox_msg.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_msg.Location = new System.Drawing.Point(12, 355);
            this.richTextBox_msg.Name = "richTextBox_msg";
            this.richTextBox_msg.ReadOnly = true;
            this.richTextBox_msg.Size = new System.Drawing.Size(645, 198);
            this.richTextBox_msg.TabIndex = 6;
            this.richTextBox_msg.TabStop = false;
            this.richTextBox_msg.Text = "";
            this.richTextBox_msg.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(585, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 7;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer_exitApp
            // 
            this.timer_exitApp.Interval = 1;
            this.timer_exitApp.Tick += new System.EventHandler(this.timer_exitApp_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox_msg);
            this.Controls.Add(this.groupBox_refration);
            this.Controls.Add(this.groupBox_schedule);
            this.Controls.Add(this.groupBox_create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiriusSVCcall";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox_refration.ResumeLayout(false);
            this.groupBox_refration.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OS_CVD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OS_ax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OS_Cyl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OS_Sph)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OD_CVD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OD_ax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OD_Cyl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refraction_OD_Sph)).EndInit();
            this.groupBox_schedule.ResumeLayout(false);
            this.groupBox_schedule.PerformLayout();
            this.groupBox_create.ResumeLayout(false);
            this.groupBox_create.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_refration;
        private System.Windows.Forms.Button refraction_send;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox refraction_OS_BCVA;
        private System.Windows.Forms.TextBox refraction_OS_UcVA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown refraction_OS_ax;
        private System.Windows.Forms.NumericUpDown refraction_OS_Cyl;
        private System.Windows.Forms.NumericUpDown refraction_OS_Sph;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox refraction_OD_BCVA;
        private System.Windows.Forms.TextBox refraction_OD_UcVA;
        private System.Windows.Forms.Label lbl_BCVAOD;
        private System.Windows.Forms.Label lbl_UcVAOD;
        private System.Windows.Forms.NumericUpDown refraction_OD_ax;
        private System.Windows.Forms.NumericUpDown refraction_OD_Cyl;
        private System.Windows.Forms.NumericUpDown refraction_OD_Sph;
        private System.Windows.Forms.Label lbl_Ax;
        private System.Windows.Forms.Label lbl_Cyl;
        private System.Windows.Forms.Label lbl_Sph;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox refraction_ID;
        private System.Windows.Forms.GroupBox groupBox_schedule;
        private System.Windows.Forms.Button schedule_send;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker schedule_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox schedule_AccessionNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox schedule_ID;
        private System.Windows.Forms.GroupBox groupBox_create;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox create_PMSid;
        private System.Windows.Forms.DateTimePicker create_dateTimePicker;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Birthdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox create_FN;
        private System.Windows.Forms.TextBox create_LN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button create_send;
        private System.Windows.Forms.Label lbl_PatientId;
        private System.Windows.Forms.TextBox create_ID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox schedule_physician;
        private System.Windows.Forms.NumericUpDown refraction_OS_CVD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown refraction_OD_CVD;
        private System.Windows.Forms.Label refraction_OD_CVD_label;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox richTextBox_msg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox create_gender;
        private System.Windows.Forms.Timer timer_exitApp;
    }
}

