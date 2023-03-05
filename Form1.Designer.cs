
namespace NetworkCalc
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коммутаторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.концентраторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.серверToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.радиоКлиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проводнойКлиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.удалитьСвязьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройка топологии сети";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage1_Paint);
            this.tabPage1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabPage1_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьСвязьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 397);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.коммутаторToolStripMenuItem,
            this.концентраторToolStripMenuItem,
            this.toolStripSeparator2,
            this.серверToolStripMenuItem,
            this.toolStripSeparator1,
            this.радиоКлиентToolStripMenuItem,
            this.проводнойКлиентToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // коммутаторToolStripMenuItem
            // 
            this.коммутаторToolStripMenuItem.Name = "коммутаторToolStripMenuItem";
            this.коммутаторToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.коммутаторToolStripMenuItem.Tag = "Commutator";
            this.коммутаторToolStripMenuItem.Text = "Коммутатор";
            this.коммутаторToolStripMenuItem.Click += new System.EventHandler(this.AddObject);
            // 
            // концентраторToolStripMenuItem
            // 
            this.концентраторToolStripMenuItem.Name = "концентраторToolStripMenuItem";
            this.концентраторToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.концентраторToolStripMenuItem.Tag = "Conchetrator";
            this.концентраторToolStripMenuItem.Text = "Концентратор";
            this.концентраторToolStripMenuItem.Click += new System.EventHandler(this.AddObject);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // серверToolStripMenuItem
            // 
            this.серверToolStripMenuItem.Name = "серверToolStripMenuItem";
            this.серверToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.серверToolStripMenuItem.Tag = "Server";
            this.серверToolStripMenuItem.Text = "Сервер";
            this.серверToolStripMenuItem.Click += new System.EventHandler(this.AddObject);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // радиоКлиентToolStripMenuItem
            // 
            this.радиоКлиентToolStripMenuItem.Name = "радиоКлиентToolStripMenuItem";
            this.радиоКлиентToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.радиоКлиентToolStripMenuItem.Tag = "Mobile";
            this.радиоКлиентToolStripMenuItem.Text = "Радио клиент";
            this.радиоКлиентToolStripMenuItem.Click += new System.EventHandler(this.AddObject);
            // 
            // проводнойКлиентToolStripMenuItem
            // 
            this.проводнойКлиентToolStripMenuItem.Name = "проводнойКлиентToolStripMenuItem";
            this.проводнойКлиентToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.проводнойКлиентToolStripMenuItem.Tag = "PC";
            this.проводнойКлиентToolStripMenuItem.Text = "Проводной клиент";
            this.проводнойКлиентToolStripMenuItem.Click += new System.EventHandler(this.AddObject);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройка клиентов сети";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Расчет пропускной способности";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // удалитьСвязьToolStripMenuItem
            // 
            this.удалитьСвязьToolStripMenuItem.Name = "удалитьСвязьToolStripMenuItem";
            this.удалитьСвязьToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.удалитьСвязьToolStripMenuItem.Text = "Удалить связь";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NetworkCalc - Сетевой калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem концентраторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коммутаторToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem серверToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem радиоКлиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проводнойКлиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСвязьToolStripMenuItem;
    }
}

