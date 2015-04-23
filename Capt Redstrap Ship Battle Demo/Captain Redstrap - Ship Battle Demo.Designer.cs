namespace Capt_Redstrap_Ship_Battle_Demo
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.SummaryBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Ship_Health = new System.Windows.Forms.Label();
            this.Ship_Crew = new System.Windows.Forms.Label();
            this.Ship_Attack = new System.Windows.Forms.Label();
            this.Ship_Agility = new System.Windows.Forms.Label();
            this.Enemy_Agility = new System.Windows.Forms.Label();
            this.Enemy_Attack = new System.Windows.Forms.Label();
            this.Enemy_Crew = new System.Windows.Forms.Label();
            this.Enemy_Health = new System.Windows.Forms.Label();
            this.Attack_Button = new System.Windows.Forms.Button();
            this.Evade_Button = new System.Windows.Forms.Button();
            this.Repair_Button = new System.Windows.Forms.Button();
            this.Plunder_Button = new System.Windows.Forms.Button();
            this.Replay_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SummaryBox
            // 
            this.SummaryBox.Location = new System.Drawing.Point(191, 24);
            this.SummaryBox.Multiline = true;
            this.SummaryBox.Name = "SummaryBox";
            this.SummaryBox.Size = new System.Drawing.Size(400, 400);
            this.SummaryBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "The (Insert Ship\'s Name)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enemy Ship";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ship Health:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Crew Mates:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Attack Level:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ship Agility:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(611, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ship Agility:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(611, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Attack Level:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(611, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Crew Mates:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(611, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ship Health:";
            // 
            // Ship_Health
            // 
            this.Ship_Health.AutoSize = true;
            this.Ship_Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ship_Health.Location = new System.Drawing.Point(103, 73);
            this.Ship_Health.Name = "Ship_Health";
            this.Ship_Health.Size = new System.Drawing.Size(0, 17);
            this.Ship_Health.TabIndex = 11;
            // 
            // Ship_Crew
            // 
            this.Ship_Crew.AutoSize = true;
            this.Ship_Crew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ship_Crew.Location = new System.Drawing.Point(103, 103);
            this.Ship_Crew.Name = "Ship_Crew";
            this.Ship_Crew.Size = new System.Drawing.Size(12, 17);
            this.Ship_Crew.TabIndex = 12;
            this.Ship_Crew.Text = " ";
            // 
            // Ship_Attack
            // 
            this.Ship_Attack.AutoSize = true;
            this.Ship_Attack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ship_Attack.Location = new System.Drawing.Point(103, 134);
            this.Ship_Attack.Name = "Ship_Attack";
            this.Ship_Attack.Size = new System.Drawing.Size(12, 17);
            this.Ship_Attack.TabIndex = 13;
            this.Ship_Attack.Text = " ";
            // 
            // Ship_Agility
            // 
            this.Ship_Agility.AutoSize = true;
            this.Ship_Agility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ship_Agility.Location = new System.Drawing.Point(103, 167);
            this.Ship_Agility.Name = "Ship_Agility";
            this.Ship_Agility.Size = new System.Drawing.Size(12, 17);
            this.Ship_Agility.TabIndex = 14;
            this.Ship_Agility.Text = " ";
            // 
            // Enemy_Agility
            // 
            this.Enemy_Agility.AutoSize = true;
            this.Enemy_Agility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enemy_Agility.Location = new System.Drawing.Point(702, 167);
            this.Enemy_Agility.Name = "Enemy_Agility";
            this.Enemy_Agility.Size = new System.Drawing.Size(12, 17);
            this.Enemy_Agility.TabIndex = 18;
            this.Enemy_Agility.Text = " ";
            // 
            // Enemy_Attack
            // 
            this.Enemy_Attack.AutoSize = true;
            this.Enemy_Attack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enemy_Attack.Location = new System.Drawing.Point(702, 134);
            this.Enemy_Attack.Name = "Enemy_Attack";
            this.Enemy_Attack.Size = new System.Drawing.Size(12, 17);
            this.Enemy_Attack.TabIndex = 17;
            this.Enemy_Attack.Text = " ";
            // 
            // Enemy_Crew
            // 
            this.Enemy_Crew.AutoSize = true;
            this.Enemy_Crew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enemy_Crew.Location = new System.Drawing.Point(702, 103);
            this.Enemy_Crew.Name = "Enemy_Crew";
            this.Enemy_Crew.Size = new System.Drawing.Size(12, 17);
            this.Enemy_Crew.TabIndex = 16;
            this.Enemy_Crew.Text = " ";
            // 
            // Enemy_Health
            // 
            this.Enemy_Health.AutoSize = true;
            this.Enemy_Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enemy_Health.Location = new System.Drawing.Point(702, 73);
            this.Enemy_Health.Name = "Enemy_Health";
            this.Enemy_Health.Size = new System.Drawing.Size(0, 17);
            this.Enemy_Health.TabIndex = 15;
            // 
            // Attack_Button
            // 
            this.Attack_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attack_Button.ForeColor = System.Drawing.Color.Green;
            this.Attack_Button.Location = new System.Drawing.Point(12, 211);
            this.Attack_Button.Name = "Attack_Button";
            this.Attack_Button.Size = new System.Drawing.Size(157, 46);
            this.Attack_Button.TabIndex = 19;
            this.Attack_Button.Text = "Attack";
            this.Attack_Button.UseVisualStyleBackColor = true;
            this.Attack_Button.Click += new System.EventHandler(this.Attack_Button_Click);
            // 
            // Evade_Button
            // 
            this.Evade_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Evade_Button.ForeColor = System.Drawing.Color.Green;
            this.Evade_Button.Location = new System.Drawing.Point(12, 267);
            this.Evade_Button.Name = "Evade_Button";
            this.Evade_Button.Size = new System.Drawing.Size(157, 46);
            this.Evade_Button.TabIndex = 20;
            this.Evade_Button.Text = "Evade";
            this.Evade_Button.UseVisualStyleBackColor = true;
            this.Evade_Button.Click += new System.EventHandler(this.Evade_Button_Click);
            // 
            // Repair_Button
            // 
            this.Repair_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repair_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Repair_Button.Location = new System.Drawing.Point(12, 323);
            this.Repair_Button.Name = "Repair_Button";
            this.Repair_Button.Size = new System.Drawing.Size(157, 46);
            this.Repair_Button.TabIndex = 21;
            this.Repair_Button.Text = "Repair";
            this.Repair_Button.UseVisualStyleBackColor = true;
            this.Repair_Button.Click += new System.EventHandler(this.Repair_Button_Click);
            // 
            // Plunder_Button
            // 
            this.Plunder_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plunder_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Plunder_Button.Location = new System.Drawing.Point(12, 378);
            this.Plunder_Button.Name = "Plunder_Button";
            this.Plunder_Button.Size = new System.Drawing.Size(157, 46);
            this.Plunder_Button.TabIndex = 22;
            this.Plunder_Button.Text = "Plunder!!";
            this.Plunder_Button.UseVisualStyleBackColor = true;
            this.Plunder_Button.Click += new System.EventHandler(this.Plunder_Button_Click);
            // 
            // Replay_Button
            // 
            this.Replay_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replay_Button.Location = new System.Drawing.Point(191, 430);
            this.Replay_Button.Name = "Replay_Button";
            this.Replay_Button.Size = new System.Drawing.Size(400, 42);
            this.Replay_Button.TabIndex = 23;
            this.Replay_Button.Text = "REPLAY?";
            this.Replay_Button.UseVisualStyleBackColor = true;
            this.Replay_Button.Click += new System.EventHandler(this.Replay_Button_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 478);
            this.Controls.Add(this.Replay_Button);
            this.Controls.Add(this.Plunder_Button);
            this.Controls.Add(this.Repair_Button);
            this.Controls.Add(this.Evade_Button);
            this.Controls.Add(this.Attack_Button);
            this.Controls.Add(this.Enemy_Agility);
            this.Controls.Add(this.Enemy_Attack);
            this.Controls.Add(this.Enemy_Crew);
            this.Controls.Add(this.Enemy_Health);
            this.Controls.Add(this.Ship_Agility);
            this.Controls.Add(this.Ship_Attack);
            this.Controls.Add(this.Ship_Crew);
            this.Controls.Add(this.Ship_Health);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SummaryBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameWindow";
            this.ShowIcon = false;
            this.Text = "Ship Battle Demo V 0.1A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SummaryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Ship_Health;
        private System.Windows.Forms.Label Ship_Crew;
        private System.Windows.Forms.Label Ship_Attack;
        private System.Windows.Forms.Label Ship_Agility;
        private System.Windows.Forms.Label Enemy_Agility;
        private System.Windows.Forms.Label Enemy_Attack;
        private System.Windows.Forms.Label Enemy_Crew;
        private System.Windows.Forms.Label Enemy_Health;
        private System.Windows.Forms.Button Attack_Button;
        private System.Windows.Forms.Button Evade_Button;
        private System.Windows.Forms.Button Repair_Button;
        private System.Windows.Forms.Button Plunder_Button;
        private System.Windows.Forms.Button Replay_Button;
    }
}

