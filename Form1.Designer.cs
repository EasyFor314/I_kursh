namespace l_kursh
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddKnot = new System.Windows.Forms.ToolStripDropDownButton();
            this.ParentKnot = new System.Windows.Forms.ToolStripMenuItem();
            this.ChildKnot = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteKnot = new System.Windows.Forms.ToolStripButton();
            this.EditKnot = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked_1);
            // 
            // toolStripFile
            // 
            this.toolStripFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripFileCreate,
            this.ToolStripFileOpen,
            this.ToolStripSaveFile});
            this.toolStripFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFile.Image")));
            this.toolStripFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(49, 22);
            this.toolStripFile.Text = "Файл";
            // 
            // ToolStripFileCreate
            // 
            this.ToolStripFileCreate.Name = "ToolStripFileCreate";
            this.ToolStripFileCreate.Size = new System.Drawing.Size(132, 22);
            this.ToolStripFileCreate.Text = "Создать";
            this.ToolStripFileCreate.Click += new System.EventHandler(this.ToolStripFileCreate_Click);
            // 
            // ToolStripFileOpen
            // 
            this.ToolStripFileOpen.Name = "ToolStripFileOpen";
            this.ToolStripFileOpen.Size = new System.Drawing.Size(132, 22);
            this.ToolStripFileOpen.Text = "Открыть";
            this.ToolStripFileOpen.Click += new System.EventHandler(this.ToolStripFileOpen_Click);
            // 
            // ToolStripSaveFile
            // 
            this.ToolStripSaveFile.Name = "ToolStripSaveFile";
            this.ToolStripSaveFile.Size = new System.Drawing.Size(132, 22);
            this.ToolStripSaveFile.Text = "Сохранить";
            this.ToolStripSaveFile.Click += new System.EventHandler(this.ToolStripSaveFile_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddKnot,
            this.DeleteKnot,
            this.EditKnot});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddKnot
            // 
            this.AddKnot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddKnot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ParentKnot,
            this.ChildKnot});
            this.AddKnot.Image = ((System.Drawing.Image)(resources.GetObject("AddKnot.Image")));
            this.AddKnot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddKnot.Name = "AddKnot";
            this.AddKnot.Size = new System.Drawing.Size(29, 22);
            this.AddKnot.Text = "AddMenu";
            // 
            // ParentKnot
            // 
            this.ParentKnot.Name = "ParentKnot";
            this.ParentKnot.Size = new System.Drawing.Size(178, 22);
            this.ParentKnot.Text = "Родительский узел";
            this.ParentKnot.Click += new System.EventHandler(this.ParentKnot_Click);
            // 
            // ChildKnot
            // 
            this.ChildKnot.Name = "ChildKnot";
            this.ChildKnot.Size = new System.Drawing.Size(180, 22);
            this.ChildKnot.Text = "Дочерний узел";
            this.ChildKnot.Click += new System.EventHandler(this.ChildKnot_Click);
            // 
            // DeleteKnot
            // 
            this.DeleteKnot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteKnot.Image = ((System.Drawing.Image)(resources.GetObject("DeleteKnot.Image")));
            this.DeleteKnot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteKnot.Name = "DeleteKnot";
            this.DeleteKnot.Size = new System.Drawing.Size(23, 22);
            this.DeleteKnot.Text = "Delete";
            this.DeleteKnot.Click += new System.EventHandler(this.DeleteKnot_Click);
            // 
            // EditKnot
            // 
            this.EditKnot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditKnot.Image = ((System.Drawing.Image)(resources.GetObject("EditKnot.Image")));
            this.EditKnot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditKnot.Name = "EditKnot";
            this.EditKnot.Size = new System.Drawing.Size(23, 22);
            this.EditKnot.Text = "Edit";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Редактор иерархических структур";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripFileCreate;
        private System.Windows.Forms.ToolStripMenuItem ToolStripFileOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSaveFile;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripDropDownButton AddKnot;
        private System.Windows.Forms.ToolStripMenuItem ParentKnot;
        private System.Windows.Forms.ToolStripMenuItem ChildKnot;
        private System.Windows.Forms.ToolStripButton DeleteKnot;
        private System.Windows.Forms.ToolStripButton EditKnot;
    }
}

