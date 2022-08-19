namespace Test_task_Cars.Views
{
    partial class FMain
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
            this.listBoxCarsList = new System.Windows.Forms.ListBox();
            this.groupBoxPanelControl = new System.Windows.Forms.GroupBox();
            this.labelLine = new System.Windows.Forms.Label();
            this.btnRemoveWeight = new System.Windows.Forms.Button();
            this.btnAddFuel = new System.Windows.Forms.Button();
            this.btnCreateAuto = new System.Windows.Forms.Button();
            this.btnAddWeight = new System.Windows.Forms.Button();
            this.btnRemoveFuel = new System.Windows.Forms.Button();
            this.btnRemovePassenger = new System.Windows.Forms.Button();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.groupBoxAdditionalInformation = new System.Windows.Forms.GroupBox();
            this.groupBoxCountPassenger = new System.Windows.Forms.GroupBox();
            this.groupBoxFuel = new System.Windows.Forms.GroupBox();
            this.groupBoxKmByFuel = new System.Windows.Forms.GroupBox();
            this.groupBoxTankAuto = new System.Windows.Forms.GroupBox();
            this.textBoxPassenger = new System.Windows.Forms.TextBox();
            this.textBoxFuel = new System.Windows.Forms.TextBox();
            this.textBoxKmPerFuel = new System.Windows.Forms.TextBox();
            this.textBoxTankFuel = new System.Windows.Forms.TextBox();
            this.groupBoxEngine = new System.Windows.Forms.GroupBox();
            this.textBoxEngine = new System.Windows.Forms.TextBox();
            this.groupBoxPanelControl.SuspendLayout();
            this.groupBoxAdditionalInformation.SuspendLayout();
            this.groupBoxCountPassenger.SuspendLayout();
            this.groupBoxFuel.SuspendLayout();
            this.groupBoxKmByFuel.SuspendLayout();
            this.groupBoxTankAuto.SuspendLayout();
            this.groupBoxEngine.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCarsList
            // 
            this.listBoxCarsList.FormattingEnabled = true;
            this.listBoxCarsList.ItemHeight = 15;
            this.listBoxCarsList.Location = new System.Drawing.Point(12, 12);
            this.listBoxCarsList.Name = "listBoxCarsList";
            this.listBoxCarsList.Size = new System.Drawing.Size(252, 244);
            this.listBoxCarsList.TabIndex = 0;
            // 
            // groupBoxPanelControl
            // 
            this.groupBoxPanelControl.Controls.Add(this.labelLine);
            this.groupBoxPanelControl.Controls.Add(this.btnRemoveWeight);
            this.groupBoxPanelControl.Controls.Add(this.btnAddFuel);
            this.groupBoxPanelControl.Controls.Add(this.btnCreateAuto);
            this.groupBoxPanelControl.Controls.Add(this.btnAddWeight);
            this.groupBoxPanelControl.Controls.Add(this.btnRemoveFuel);
            this.groupBoxPanelControl.Controls.Add(this.btnRemovePassenger);
            this.groupBoxPanelControl.Controls.Add(this.btnAddPassenger);
            this.groupBoxPanelControl.Location = new System.Drawing.Point(270, 12);
            this.groupBoxPanelControl.Name = "groupBoxPanelControl";
            this.groupBoxPanelControl.Size = new System.Drawing.Size(164, 237);
            this.groupBoxPanelControl.TabIndex = 1;
            this.groupBoxPanelControl.TabStop = false;
            this.groupBoxPanelControl.Text = "Панель управления";
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Location = new System.Drawing.Point(25, 161);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(117, 15);
            this.labelLine.TabIndex = 7;
            this.labelLine.Text = "----------------------";
            // 
            // btnRemoveWeight
            // 
            this.btnRemoveWeight.Location = new System.Drawing.Point(6, 135);
            this.btnRemoveWeight.Name = "btnRemoveWeight";
            this.btnRemoveWeight.Size = new System.Drawing.Size(152, 23);
            this.btnRemoveWeight.TabIndex = 6;
            this.btnRemoveWeight.Text = "Выгрузить груз(-5кг)";
            this.btnRemoveWeight.UseVisualStyleBackColor = true;
            // 
            // btnAddFuel
            // 
            this.btnAddFuel.Location = new System.Drawing.Point(6, 208);
            this.btnAddFuel.Name = "btnAddFuel";
            this.btnAddFuel.Size = new System.Drawing.Size(152, 23);
            this.btnAddFuel.TabIndex = 5;
            this.btnAddFuel.Text = "Заправить(+1л)";
            this.btnAddFuel.UseVisualStyleBackColor = true;
            // 
            // btnCreateAuto
            // 
            this.btnCreateAuto.Location = new System.Drawing.Point(6, 22);
            this.btnCreateAuto.Name = "btnCreateAuto";
            this.btnCreateAuto.Size = new System.Drawing.Size(152, 23);
            this.btnCreateAuto.TabIndex = 4;
            this.btnCreateAuto.Text = "Создать авто";
            this.btnCreateAuto.UseVisualStyleBackColor = true;
            // 
            // btnAddWeight
            // 
            this.btnAddWeight.Location = new System.Drawing.Point(6, 106);
            this.btnAddWeight.Name = "btnAddWeight";
            this.btnAddWeight.Size = new System.Drawing.Size(152, 23);
            this.btnAddWeight.TabIndex = 3;
            this.btnAddWeight.Text = "Добавить груз(+5кг)";
            this.btnAddWeight.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFuel
            // 
            this.btnRemoveFuel.Location = new System.Drawing.Point(6, 179);
            this.btnRemoveFuel.Name = "btnRemoveFuel";
            this.btnRemoveFuel.Size = new System.Drawing.Size(152, 23);
            this.btnRemoveFuel.TabIndex = 2;
            this.btnRemoveFuel.Text = "Сжечь топливо(-1л)";
            this.btnRemoveFuel.UseVisualStyleBackColor = true;
            // 
            // btnRemovePassenger
            // 
            this.btnRemovePassenger.Location = new System.Drawing.Point(6, 77);
            this.btnRemovePassenger.Name = "btnRemovePassenger";
            this.btnRemovePassenger.Size = new System.Drawing.Size(152, 23);
            this.btnRemovePassenger.TabIndex = 1;
            this.btnRemovePassenger.Text = "Высадить пассажира";
            this.btnRemovePassenger.UseVisualStyleBackColor = true;
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.Location = new System.Drawing.Point(6, 48);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(152, 23);
            this.btnAddPassenger.TabIndex = 0;
            this.btnAddPassenger.Text = "Посадить пассажира";
            this.btnAddPassenger.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdditionalInformation
            // 
            this.groupBoxAdditionalInformation.Controls.Add(this.groupBoxEngine);
            this.groupBoxAdditionalInformation.Controls.Add(this.groupBoxTankAuto);
            this.groupBoxAdditionalInformation.Controls.Add(this.groupBoxKmByFuel);
            this.groupBoxAdditionalInformation.Controls.Add(this.groupBoxFuel);
            this.groupBoxAdditionalInformation.Controls.Add(this.groupBoxCountPassenger);
            this.groupBoxAdditionalInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAdditionalInformation.Location = new System.Drawing.Point(12, 262);
            this.groupBoxAdditionalInformation.Name = "groupBoxAdditionalInformation";
            this.groupBoxAdditionalInformation.Size = new System.Drawing.Size(422, 150);
            this.groupBoxAdditionalInformation.TabIndex = 2;
            this.groupBoxAdditionalInformation.TabStop = false;
            this.groupBoxAdditionalInformation.Text = "Дополнительная информация:";
            // 
            // groupBoxCountPassenger
            // 
            this.groupBoxCountPassenger.Controls.Add(this.textBoxPassenger);
            this.groupBoxCountPassenger.Location = new System.Drawing.Point(145, 22);
            this.groupBoxCountPassenger.Name = "groupBoxCountPassenger";
            this.groupBoxCountPassenger.Size = new System.Drawing.Size(132, 52);
            this.groupBoxCountPassenger.TabIndex = 3;
            this.groupBoxCountPassenger.TabStop = false;
            this.groupBoxCountPassenger.Text = "Пассажиры:";
            // 
            // groupBoxFuel
            // 
            this.groupBoxFuel.Controls.Add(this.textBoxFuel);
            this.groupBoxFuel.Location = new System.Drawing.Point(283, 22);
            this.groupBoxFuel.Name = "groupBoxFuel";
            this.groupBoxFuel.Size = new System.Drawing.Size(132, 52);
            this.groupBoxFuel.TabIndex = 4;
            this.groupBoxFuel.TabStop = false;
            this.groupBoxFuel.Text = "Топливо(л):";
            // 
            // groupBoxKmByFuel
            // 
            this.groupBoxKmByFuel.Controls.Add(this.textBoxKmPerFuel);
            this.groupBoxKmByFuel.Location = new System.Drawing.Point(6, 80);
            this.groupBoxKmByFuel.Name = "groupBoxKmByFuel";
            this.groupBoxKmByFuel.Size = new System.Drawing.Size(132, 52);
            this.groupBoxKmByFuel.TabIndex = 4;
            this.groupBoxKmByFuel.TabStop = false;
            this.groupBoxKmByFuel.Text = "Запас топлива(км):";
            // 
            // groupBoxTankAuto
            // 
            this.groupBoxTankAuto.Controls.Add(this.textBoxTankFuel);
            this.groupBoxTankAuto.Location = new System.Drawing.Point(145, 80);
            this.groupBoxTankAuto.Name = "groupBoxTankAuto";
            this.groupBoxTankAuto.Size = new System.Drawing.Size(132, 52);
            this.groupBoxTankAuto.TabIndex = 5;
            this.groupBoxTankAuto.TabStop = false;
            this.groupBoxTankAuto.Text = "Объем бака:";
            // 
            // textBoxPassenger
            // 
            this.textBoxPassenger.Location = new System.Drawing.Point(6, 19);
            this.textBoxPassenger.Name = "textBoxPassenger";
            this.textBoxPassenger.Size = new System.Drawing.Size(120, 23);
            this.textBoxPassenger.TabIndex = 1;
            // 
            // textBoxFuel
            // 
            this.textBoxFuel.Location = new System.Drawing.Point(6, 19);
            this.textBoxFuel.Name = "textBoxFuel";
            this.textBoxFuel.Size = new System.Drawing.Size(120, 23);
            this.textBoxFuel.TabIndex = 2;
            // 
            // textBoxKmPerFuel
            // 
            this.textBoxKmPerFuel.Location = new System.Drawing.Point(6, 22);
            this.textBoxKmPerFuel.Name = "textBoxKmPerFuel";
            this.textBoxKmPerFuel.Size = new System.Drawing.Size(120, 23);
            this.textBoxKmPerFuel.TabIndex = 3;
            // 
            // textBoxTankFuel
            // 
            this.textBoxTankFuel.Location = new System.Drawing.Point(6, 22);
            this.textBoxTankFuel.Name = "textBoxTankFuel";
            this.textBoxTankFuel.Size = new System.Drawing.Size(120, 23);
            this.textBoxTankFuel.TabIndex = 4;
            // 
            // groupBoxEngine
            // 
            this.groupBoxEngine.Controls.Add(this.textBoxEngine);
            this.groupBoxEngine.Location = new System.Drawing.Point(13, 22);
            this.groupBoxEngine.Name = "groupBoxEngine";
            this.groupBoxEngine.Size = new System.Drawing.Size(132, 52);
            this.groupBoxEngine.TabIndex = 4;
            this.groupBoxEngine.TabStop = false;
            this.groupBoxEngine.Text = "Двигатель:";
            // 
            // textBoxEngine
            // 
            this.textBoxEngine.Location = new System.Drawing.Point(6, 19);
            this.textBoxEngine.Name = "textBoxEngine";
            this.textBoxEngine.Size = new System.Drawing.Size(120, 23);
            this.textBoxEngine.TabIndex = 1;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 424);
            this.Controls.Add(this.groupBoxAdditionalInformation);
            this.Controls.Add(this.groupBoxPanelControl);
            this.Controls.Add(this.listBoxCarsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FMain";
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.groupBoxPanelControl.ResumeLayout(false);
            this.groupBoxPanelControl.PerformLayout();
            this.groupBoxAdditionalInformation.ResumeLayout(false);
            this.groupBoxCountPassenger.ResumeLayout(false);
            this.groupBoxCountPassenger.PerformLayout();
            this.groupBoxFuel.ResumeLayout(false);
            this.groupBoxFuel.PerformLayout();
            this.groupBoxKmByFuel.ResumeLayout(false);
            this.groupBoxKmByFuel.PerformLayout();
            this.groupBoxTankAuto.ResumeLayout(false);
            this.groupBoxTankAuto.PerformLayout();
            this.groupBoxEngine.ResumeLayout(false);
            this.groupBoxEngine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxCarsList;
        private GroupBox groupBoxPanelControl;
        private Button btnAddPassenger;
        private Button btnRemoveWeight;
        private Button btnAddFuel;
        private Button btnCreateAuto;
        private Button btnAddWeight;
        private Button btnRemoveFuel;
        private Button btnRemovePassenger;
        private Label labelLine;
        private GroupBox groupBoxAdditionalInformation;
        private GroupBox groupBoxTankAuto;
        private TextBox textBoxTankFuel;
        private GroupBox groupBoxKmByFuel;
        private TextBox textBoxKmPerFuel;
        private GroupBox groupBoxFuel;
        private TextBox textBoxFuel;
        private GroupBox groupBoxCountPassenger;
        private TextBox textBoxPassenger;
        private GroupBox groupBoxEngine;
        private TextBox textBoxEngine;
    }
}