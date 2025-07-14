namespace CarRental.People.Employee
{
    partial class frmAddUpdateEmployee
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
            this.tabAddUpdateEmployee = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new CarRental.ctrlPersonCardWithFilter();
            this.tabEmployeeInfo = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCityName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tsIsExit = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBranch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDepartemnt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpExitDate = new System.Windows.Forms.DateTimePicker();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltitleExitDate = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.txtMonthlySalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabAddUpdateEmployee.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.tabEmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAddUpdateEmployee
            // 
            this.tabAddUpdateEmployee.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabAddUpdateEmployee.Controls.Add(this.tabPersonInfo);
            this.tabAddUpdateEmployee.Controls.Add(this.tabEmployeeInfo);
            this.tabAddUpdateEmployee.ItemSize = new System.Drawing.Size(180, 40);
            this.tabAddUpdateEmployee.Location = new System.Drawing.Point(12, 62);
            this.tabAddUpdateEmployee.Name = "tabAddUpdateEmployee";
            this.tabAddUpdateEmployee.SelectedIndex = 0;
            this.tabAddUpdateEmployee.Size = new System.Drawing.Size(915, 414);
            this.tabAddUpdateEmployee.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabAddUpdateEmployee.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabAddUpdateEmployee.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabAddUpdateEmployee.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabAddUpdateEmployee.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabAddUpdateEmployee.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabAddUpdateEmployee.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabAddUpdateEmployee.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabAddUpdateEmployee.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabAddUpdateEmployee.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabAddUpdateEmployee.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabAddUpdateEmployee.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabAddUpdateEmployee.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabAddUpdateEmployee.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabAddUpdateEmployee.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabAddUpdateEmployee.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabAddUpdateEmployee.TabIndex = 0;
            this.tabAddUpdateEmployee.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabAddUpdateEmployee.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabAddUpdateEmployee_Selecting);
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPersonInfo.Controls.Add(this.btnNext);
            this.tabPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPersonInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPersonInfo.Location = new System.Drawing.Point(184, 4);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonInfo.Size = new System.Drawing.Size(727, 406);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "Person Info";
            this.tabPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(586, 366);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 31);
            this.btnNext.TabIndex = 130;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(65, 23);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(620, 337);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonCardWithFilter1_OnPersonSelected);
            // 
            // tabEmployeeInfo
            // 
            this.tabEmployeeInfo.BackColor = System.Drawing.Color.Transparent;
            this.tabEmployeeInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabEmployeeInfo.Controls.Add(this.label10);
            this.tabEmployeeInfo.Controls.Add(this.cmbCityName);
            this.tabEmployeeInfo.Controls.Add(this.lblEmployeeID);
            this.tabEmployeeInfo.Controls.Add(this.label1);
            this.tabEmployeeInfo.Controls.Add(this.tsIsExit);
            this.tabEmployeeInfo.Controls.Add(this.label5);
            this.tabEmployeeInfo.Controls.Add(this.cmbBranch);
            this.tabEmployeeInfo.Controls.Add(this.label4);
            this.tabEmployeeInfo.Controls.Add(this.cmbDepartemnt);
            this.tabEmployeeInfo.Controls.Add(this.dtpExitDate);
            this.tabEmployeeInfo.Controls.Add(this.dtpHireDate);
            this.tabEmployeeInfo.Controls.Add(this.label3);
            this.tabEmployeeInfo.Controls.Add(this.label2);
            this.tabEmployeeInfo.Controls.Add(this.lbltitleExitDate);
            this.tabEmployeeInfo.Controls.Add(this.lable);
            this.tabEmployeeInfo.Controls.Add(this.txtMonthlySalary);
            this.tabEmployeeInfo.Controls.Add(this.btnBack);
            this.tabEmployeeInfo.Location = new System.Drawing.Point(184, 4);
            this.tabEmployeeInfo.Name = "tabEmployeeInfo";
            this.tabEmployeeInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployeeInfo.Size = new System.Drawing.Size(727, 406);
            this.tabEmployeeInfo.TabIndex = 1;
            this.tabEmployeeInfo.Text = "Employee Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(71, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 247;
            this.label10.Text = "City Name :";
            // 
            // cmbCityName
            // 
            this.cmbCityName.AutoRoundedCorners = true;
            this.cmbCityName.BackColor = System.Drawing.Color.Transparent;
            this.cmbCityName.BorderColor = System.Drawing.Color.Black;
            this.cmbCityName.BorderRadius = 17;
            this.cmbCityName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCityName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCityName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCityName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCityName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCityName.ForeColor = System.Drawing.Color.Black;
            this.cmbCityName.ItemHeight = 30;
            this.cmbCityName.Location = new System.Drawing.Point(221, 262);
            this.cmbCityName.Name = "cmbCityName";
            this.cmbCityName.Size = new System.Drawing.Size(172, 36);
            this.cmbCityName.TabIndex = 246;
            this.cmbCityName.SelectedIndexChanged += new System.EventHandler(this.cmbCityName_SelectedIndexChanged);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeID.Location = new System.Drawing.Point(546, 175);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(31, 21);
            this.lblEmployeeID.TabIndex = 245;
            this.lblEmployeeID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(427, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 244;
            this.label1.Text = "Employee ID :";
            // 
            // tsIsExit
            // 
            this.tsIsExit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsIsExit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsIsExit.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsIsExit.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsIsExit.Location = new System.Drawing.Point(202, 160);
            this.tsIsExit.Name = "tsIsExit";
            this.tsIsExit.Size = new System.Drawing.Size(95, 20);
            this.tsIsExit.TabIndex = 243;
            this.tsIsExit.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsIsExit.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsIsExit.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsIsExit.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsIsExit.CheckedChanged += new System.EventHandler(this.tsIsExit_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(108, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 242;
            this.label5.Text = "Is Exit ? ";
            // 
            // cmbBranch
            // 
            this.cmbBranch.AutoRoundedCorners = true;
            this.cmbBranch.BackColor = System.Drawing.Color.Transparent;
            this.cmbBranch.BorderColor = System.Drawing.Color.Black;
            this.cmbBranch.BorderRadius = 17;
            this.cmbBranch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBranch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBranch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBranch.ItemHeight = 30;
            this.cmbBranch.Location = new System.Drawing.Point(537, 262);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(172, 36);
            this.cmbBranch.TabIndex = 241;
            this.cmbBranch.Validating += new System.ComponentModel.CancelEventHandler(this.cbBranch_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(461, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 240;
            this.label4.Text = "Branch :";
            // 
            // cmbDepartemnt
            // 
            this.cmbDepartemnt.AutoRoundedCorners = true;
            this.cmbDepartemnt.BackColor = System.Drawing.Color.Transparent;
            this.cmbDepartemnt.BorderColor = System.Drawing.Color.Black;
            this.cmbDepartemnt.BorderRadius = 17;
            this.cmbDepartemnt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDepartemnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartemnt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepartemnt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepartemnt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDepartemnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDepartemnt.ItemHeight = 30;
            this.cmbDepartemnt.Location = new System.Drawing.Point(221, 332);
            this.cmbDepartemnt.Name = "cmbDepartemnt";
            this.cmbDepartemnt.Size = new System.Drawing.Size(172, 36);
            this.cmbDepartemnt.TabIndex = 239;
            this.cmbDepartemnt.SelectedIndexChanged += new System.EventHandler(this.cbDepartemnt_SelectedIndexChanged);
            this.cmbDepartemnt.Validating += new System.ComponentModel.CancelEventHandler(this.cbBranch_Validating);
            // 
            // dtpExitDate
            // 
            this.dtpExitDate.CustomFormat = "   dd/M/yyyy";
            this.dtpExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExitDate.Location = new System.Drawing.Point(228, 209);
            this.dtpExitDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpExitDate.MinDate = new System.DateTime(2023, 12, 25, 0, 0, 0, 0);
            this.dtpExitDate.Name = "dtpExitDate";
            this.dtpExitDate.Size = new System.Drawing.Size(165, 20);
            this.dtpExitDate.TabIndex = 238;
            this.dtpExitDate.Value = new System.DateTime(2024, 3, 16, 0, 0, 0, 0);
            this.dtpExitDate.Visible = false;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.CustomFormat = "dd/M/yyyy";
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHireDate.Location = new System.Drawing.Point(228, 102);
            this.dtpHireDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHireDate.MinDate = new System.DateTime(2023, 12, 25, 0, 0, 0, 0);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(165, 20);
            this.dtpHireDate.TabIndex = 237;
            this.dtpHireDate.Value = new System.DateTime(2024, 3, 16, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 236;
            this.label3.Text = "Monthly Salary :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(74, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 235;
            this.label2.Text = "Hire Date :";
            // 
            // lbltitleExitDate
            // 
            this.lbltitleExitDate.AutoSize = true;
            this.lbltitleExitDate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitleExitDate.ForeColor = System.Drawing.Color.Black;
            this.lbltitleExitDate.Location = new System.Drawing.Point(77, 209);
            this.lbltitleExitDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitleExitDate.Name = "lbltitleExitDate";
            this.lbltitleExitDate.Size = new System.Drawing.Size(87, 21);
            this.lbltitleExitDate.TabIndex = 234;
            this.lbltitleExitDate.Text = "Exit Date :";
            this.lbltitleExitDate.Visible = false;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.Black;
            this.lable.Location = new System.Drawing.Point(54, 336);
            this.lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(110, 21);
            this.lable.TabIndex = 233;
            this.lable.Text = "Department :";
            // 
            // txtMonthlySalary
            // 
            this.txtMonthlySalary.AutoRoundedCorners = true;
            this.txtMonthlySalary.BorderColor = System.Drawing.Color.Black;
            this.txtMonthlySalary.BorderRadius = 11;
            this.txtMonthlySalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonthlySalary.DefaultText = "";
            this.txtMonthlySalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMonthlySalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMonthlySalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonthlySalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonthlySalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonthlySalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMonthlySalary.ForeColor = System.Drawing.Color.Black;
            this.txtMonthlySalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonthlySalary.Location = new System.Drawing.Point(228, 39);
            this.txtMonthlySalary.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMonthlySalary.Name = "txtMonthlySalary";
            this.txtMonthlySalary.PasswordChar = '\0';
            this.txtMonthlySalary.PlaceholderText = "";
            this.txtMonthlySalary.SelectedText = "";
            this.txtMonthlySalary.Size = new System.Drawing.Size(172, 24);
            this.txtMonthlySalary.TabIndex = 131;
            this.txtMonthlySalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonthlySalary_KeyPress);
            this.txtMonthlySalary.Validating += new System.ComponentModel.CancelEventHandler(this.txtMonthlySalary_Validating);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(586, 355);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 31);
            this.btnBack.TabIndex = 129;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(824, 507);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 31);
            this.btnSave.TabIndex = 131;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(691, 507);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 31);
            this.btnClose.TabIndex = 135;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(911, 50);
            this.lblTitle.TabIndex = 136;
            this.lblTitle.Text = "Add Update Employee";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // frmAddUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 572);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabAddUpdateEmployee);
            this.Name = "frmAddUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Update Employee";
            this.Load += new System.EventHandler(this.frmAddUpdateEmployee_Load);
            this.tabAddUpdateEmployee.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.tabEmployeeInfo.ResumeLayout(false);
            this.tabEmployeeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabAddUpdateEmployee;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private System.Windows.Forms.TabPage tabEmployeeInfo;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtMonthlySalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltitleExitDate;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.DateTimePicker dtpExitDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDepartemnt;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBranch;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsIsExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCityName;
    }
}