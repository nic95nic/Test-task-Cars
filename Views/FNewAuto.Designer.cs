namespace Test_task_Cars.Views
{
    partial class FNewAuto
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
            this.groupBoxTypeAuto = new System.Windows.Forms.GroupBox();
            this.rbSportCar = new System.Windows.Forms.RadioButton();
            this.rbPassengerType = new System.Windows.Forms.RadioButton();
            this.rbCargoType = new System.Windows.Forms.RadioButton();
            this.labelModelName = new System.Windows.Forms.Label();
            this.textBoxNameAuto = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxTypeAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTypeAuto
            // 
            this.groupBoxTypeAuto.Controls.Add(this.rbSportCar);
            this.groupBoxTypeAuto.Controls.Add(this.rbPassengerType);
            this.groupBoxTypeAuto.Controls.Add(this.rbCargoType);
            this.groupBoxTypeAuto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxTypeAuto.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTypeAuto.Name = "groupBoxTypeAuto";
            this.groupBoxTypeAuto.Size = new System.Drawing.Size(257, 100);
            this.groupBoxTypeAuto.TabIndex = 0;
            this.groupBoxTypeAuto.TabStop = false;
            this.groupBoxTypeAuto.Text = "Тип авто";
            // 
            // rbSportCar
            // 
            this.rbSportCar.AutoSize = true;
            this.rbSportCar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSportCar.Location = new System.Drawing.Point(6, 72);
            this.rbSportCar.Name = "rbSportCar";
            this.rbSportCar.Size = new System.Drawing.Size(95, 19);
            this.rbSportCar.TabIndex = 2;
            this.rbSportCar.Text = "Спортивный";
            this.rbSportCar.UseVisualStyleBackColor = true;
            // 
            // rbPassengerType
            // 
            this.rbPassengerType.AutoSize = true;
            this.rbPassengerType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbPassengerType.Location = new System.Drawing.Point(6, 47);
            this.rbPassengerType.Name = "rbPassengerType";
            this.rbPassengerType.Size = new System.Drawing.Size(107, 19);
            this.rbPassengerType.TabIndex = 1;
            this.rbPassengerType.Text = "Пассажирский";
            this.rbPassengerType.UseVisualStyleBackColor = true;
            // 
            // rbCargoType
            // 
            this.rbCargoType.AutoSize = true;
            this.rbCargoType.Checked = true;
            this.rbCargoType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCargoType.Location = new System.Drawing.Point(6, 22);
            this.rbCargoType.Name = "rbCargoType";
            this.rbCargoType.Size = new System.Drawing.Size(76, 19);
            this.rbCargoType.TabIndex = 0;
            this.rbCargoType.TabStop = true;
            this.rbCargoType.Text = "Грузовой";
            this.rbCargoType.UseVisualStyleBackColor = true;
            // 
            // labelModelName
            // 
            this.labelModelName.AutoSize = true;
            this.labelModelName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelModelName.Location = new System.Drawing.Point(12, 121);
            this.labelModelName.Name = "labelModelName";
            this.labelModelName.Size = new System.Drawing.Size(155, 15);
            this.labelModelName.TabIndex = 1;
            this.labelModelName.Text = "Наименование (Модель):";
            // 
            // textBoxNameAuto
            // 
            this.textBoxNameAuto.Location = new System.Drawing.Point(12, 139);
            this.textBoxNameAuto.Name = "textBoxNameAuto";
            this.textBoxNameAuto.Size = new System.Drawing.Size(257, 23);
            this.textBoxNameAuto.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 168);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(144, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // FNewAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 198);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxNameAuto);
            this.Controls.Add(this.labelModelName);
            this.Controls.Add(this.groupBoxTypeAuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FNewAuto";
            this.Text = "Добавить авто";
            this.groupBoxTypeAuto.ResumeLayout(false);
            this.groupBoxTypeAuto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxTypeAuto;
        private RadioButton rbSportCar;
        private RadioButton rbPassengerType;
        private RadioButton rbCargoType;
        private Label labelModelName;
        private TextBox textBoxNameAuto;
        private Button btnOK;
        private Button btnCancel;
    }
}