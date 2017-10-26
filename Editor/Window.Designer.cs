namespace Editor
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItemNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.fileMenuItemNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.fileMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItemPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editMenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.editMenuItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceMenuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItemIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.helpMenuItemAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.textArea = new System.Windows.Forms.RichTextBox();
            this.panelTextArea = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.mainMenu.SuspendLayout();
            this.panelTextArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.LightGray;
            this.mainMenu.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItems,
            this.editMenuItems,
            this.serviceMenuItems,
            this.helpMenuItems});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenu.Size = new System.Drawing.Size(784, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileMenuItems
            // 
            this.fileMenuItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItemNewWindow,
            this.toolStripSeparator6,
            this.fileMenuItemNewFile,
            this.fileMenuItemOpen,
            this.toolStripSeparator,
            this.fileMenuItemSave,
            this.fileMenuItemSaveAs,
            this.toolStripSeparator1,
            this.fileMenuItemPrint,
            this.fileMenuItemPreview,
            this.toolStripSeparator2,
            this.fileMenuItemExit});
            this.fileMenuItems.Name = "fileMenuItems";
            this.fileMenuItems.Size = new System.Drawing.Size(49, 20);
            this.fileMenuItems.Text = "&Файл";
            // 
            // fileMenuItemNewWindow
            // 
            this.fileMenuItemNewWindow.Name = "fileMenuItemNewWindow";
            this.fileMenuItemNewWindow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.fileMenuItemNewWindow.Size = new System.Drawing.Size(235, 22);
            this.fileMenuItemNewWindow.Text = "&Новое окно";
            this.fileMenuItemNewWindow.Click += new System.EventHandler(this.fileMenuItemNewWindow_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(232, 6);
            // 
            // fileMenuItemNewFile
            // 
            this.fileMenuItemNewFile.Image = ((System.Drawing.Image)(resources.GetObject("fileMenuItemNewFile.Image")));
            this.fileMenuItemNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileMenuItemNewFile.Name = "fileMenuItemNewFile";
            this.fileMenuItemNewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileMenuItemNewFile.Size = new System.Drawing.Size(235, 22);
            this.fileMenuItemNewFile.Text = "&Создать";
            // 
            // fileMenuItemOpen
            // 
            this.fileMenuItemOpen.Image = ((System.Drawing.Image)(resources.GetObject("fileMenuItemOpen.Image")));
            this.fileMenuItemOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileMenuItemOpen.Name = "fileMenuItemOpen";
            this.fileMenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileMenuItemOpen.Size = new System.Drawing.Size(235, 22);
            this.fileMenuItemOpen.Text = "&Открыть";
            this.fileMenuItemOpen.Click += new System.EventHandler(this.fileMenuItemOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(232, 6);
            // 
            // fileMenuItemSave
            // 
            this.fileMenuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("fileMenuItemSave.Image")));
            this.fileMenuItemSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileMenuItemSave.Name = "fileMenuItemSave";
            this.fileMenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileMenuItemSave.Size = new System.Drawing.Size(235, 22);
            this.fileMenuItemSave.Text = "&Сохранить";
            // 
            // fileMenuItemSaveAs
            // 
            this.fileMenuItemSaveAs.Name = "fileMenuItemSaveAs";
            this.fileMenuItemSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.fileMenuItemSaveAs.Size = new System.Drawing.Size(235, 22);
            this.fileMenuItemSaveAs.Text = "Сохранить &как";
            this.fileMenuItemSaveAs.Click += new System.EventHandler(this.fileMenuItemSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // fileMenuItemPrint
            // 
            this.fileMenuItemPrint.Image = ((System.Drawing.Image)(resources.GetObject("fileMenuItemPrint.Image")));
            this.fileMenuItemPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileMenuItemPrint.Name = "fileMenuItemPrint";
            this.fileMenuItemPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.fileMenuItemPrint.Size = new System.Drawing.Size(235, 22);
            this.fileMenuItemPrint.Text = "&Печать";
            // 
            // fileMenuItemPreview
            // 
            this.fileMenuItemPreview.Image = ((System.Drawing.Image)(resources.GetObject("fileMenuItemPreview.Image")));
            this.fileMenuItemPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileMenuItemPreview.Name = "fileMenuItemPreview";
            this.fileMenuItemPreview.Size = new System.Drawing.Size(235, 22);
            this.fileMenuItemPreview.Text = "Предварительный про&смотр";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(232, 6);
            // 
            // fileMenuItemExit
            // 
            this.fileMenuItemExit.Name = "fileMenuItemExit";
            this.fileMenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.fileMenuItemExit.Size = new System.Drawing.Size(235, 22);
            this.fileMenuItemExit.Text = "Вы&ход";
            this.fileMenuItemExit.Click += new System.EventHandler(this.fileMenuItemExit_Click);
            // 
            // editMenuItems
            // 
            this.editMenuItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenuItemUndo,
            this.editMenuItemRedo,
            this.toolStripSeparator3,
            this.editMenuItemCut,
            this.editMenuItemCopy,
            this.editMenuItemPaste,
            this.toolStripSeparator4,
            this.editMenuItemSelectAll});
            this.editMenuItems.Name = "editMenuItems";
            this.editMenuItems.Size = new System.Drawing.Size(59, 20);
            this.editMenuItems.Text = "&Правка";
            // 
            // editMenuItemUndo
            // 
            this.editMenuItemUndo.Name = "editMenuItemUndo";
            this.editMenuItemUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.editMenuItemUndo.Size = new System.Drawing.Size(193, 22);
            this.editMenuItemUndo.Text = "&Отменить";
            this.editMenuItemUndo.Click += new System.EventHandler(this.editMenuItemUndo_Click);
            // 
            // editMenuItemRedo
            // 
            this.editMenuItemRedo.Name = "editMenuItemRedo";
            this.editMenuItemRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.editMenuItemRedo.Size = new System.Drawing.Size(193, 22);
            this.editMenuItemRedo.Text = "&Вернуть";
            this.editMenuItemRedo.Click += new System.EventHandler(this.editMenuItemRedo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(190, 6);
            // 
            // editMenuItemCut
            // 
            this.editMenuItemCut.Image = ((System.Drawing.Image)(resources.GetObject("editMenuItemCut.Image")));
            this.editMenuItemCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editMenuItemCut.Name = "editMenuItemCut";
            this.editMenuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.editMenuItemCut.Size = new System.Drawing.Size(193, 22);
            this.editMenuItemCut.Text = "Вырезат&ь";
            this.editMenuItemCut.Click += new System.EventHandler(this.editMenuItemCut_Click);
            // 
            // editMenuItemCopy
            // 
            this.editMenuItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("editMenuItemCopy.Image")));
            this.editMenuItemCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editMenuItemCopy.Name = "editMenuItemCopy";
            this.editMenuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.editMenuItemCopy.Size = new System.Drawing.Size(193, 22);
            this.editMenuItemCopy.Text = "&Копировать";
            this.editMenuItemCopy.Click += new System.EventHandler(this.editMenuItemCopy_Click);
            // 
            // editMenuItemPaste
            // 
            this.editMenuItemPaste.Image = ((System.Drawing.Image)(resources.GetObject("editMenuItemPaste.Image")));
            this.editMenuItemPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editMenuItemPaste.Name = "editMenuItemPaste";
            this.editMenuItemPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.editMenuItemPaste.Size = new System.Drawing.Size(193, 22);
            this.editMenuItemPaste.Text = "Вст&авка";
            this.editMenuItemPaste.Click += new System.EventHandler(this.editMenuItemPaste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(190, 6);
            // 
            // editMenuItemSelectAll
            // 
            this.editMenuItemSelectAll.Name = "editMenuItemSelectAll";
            this.editMenuItemSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.editMenuItemSelectAll.Size = new System.Drawing.Size(193, 22);
            this.editMenuItemSelectAll.Text = "Выделить &все";
            this.editMenuItemSelectAll.Click += new System.EventHandler(this.editMenuItemSelectAll_Click);
            // 
            // serviceMenuItems
            // 
            this.serviceMenuItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceMenuItemSettings,
            this.serviceMenuItemOptions});
            this.serviceMenuItems.Name = "serviceMenuItems";
            this.serviceMenuItems.Size = new System.Drawing.Size(59, 20);
            this.serviceMenuItems.Text = "&Сервис";
            // 
            // serviceMenuItemSettings
            // 
            this.serviceMenuItemSettings.Name = "serviceMenuItemSettings";
            this.serviceMenuItemSettings.Size = new System.Drawing.Size(137, 22);
            this.serviceMenuItemSettings.Text = "&Настройки";
            // 
            // serviceMenuItemOptions
            // 
            this.serviceMenuItemOptions.Name = "serviceMenuItemOptions";
            this.serviceMenuItemOptions.Size = new System.Drawing.Size(137, 22);
            this.serviceMenuItemOptions.Text = "&Параметры";
            // 
            // helpMenuItems
            // 
            this.helpMenuItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuItemIndex,
            this.helpMenuItemSearch,
            this.toolStripSeparator5,
            this.helpMenuItemAboutProgram});
            this.helpMenuItems.Name = "helpMenuItems";
            this.helpMenuItems.Size = new System.Drawing.Size(65, 20);
            this.helpMenuItems.Text = "Спра&вка";
            // 
            // helpMenuItemIndex
            // 
            this.helpMenuItemIndex.Name = "helpMenuItemIndex";
            this.helpMenuItemIndex.Size = new System.Drawing.Size(157, 22);
            this.helpMenuItemIndex.Text = "&Индекс";
            // 
            // helpMenuItemSearch
            // 
            this.helpMenuItemSearch.Name = "helpMenuItemSearch";
            this.helpMenuItemSearch.Size = new System.Drawing.Size(157, 22);
            this.helpMenuItemSearch.Text = "&Поиск";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(154, 6);
            // 
            // helpMenuItemAboutProgram
            // 
            this.helpMenuItemAboutProgram.Name = "helpMenuItemAboutProgram";
            this.helpMenuItemAboutProgram.Size = new System.Drawing.Size(157, 22);
            this.helpMenuItemAboutProgram.Text = "&О программе...";
            // 
            // textArea
            // 
            this.textArea.AcceptsTab = true;
            this.textArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textArea.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textArea.ForeColor = System.Drawing.Color.White;
            this.textArea.Location = new System.Drawing.Point(20, 15);
            this.textArea.Margin = new System.Windows.Forms.Padding(25);
            this.textArea.Name = "textArea";
            this.textArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textArea.Size = new System.Drawing.Size(744, 512);
            this.textArea.TabIndex = 1;
            this.textArea.Text = "";
            this.textArea.UseWaitCursor = true;
            // 
            // panelTextArea
            // 
            this.panelTextArea.BackColor = System.Drawing.Color.Transparent;
            this.panelTextArea.Controls.Add(this.textArea);
            this.panelTextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTextArea.Location = new System.Drawing.Point(0, 24);
            this.panelTextArea.Name = "panelTextArea";
            this.panelTextArea.Padding = new System.Windows.Forms.Padding(20, 15, 20, 10);
            this.panelTextArea.Size = new System.Drawing.Size(784, 537);
            this.panelTextArea.TabIndex = 2;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(769, 24);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(15, 537);
            this.vScrollBar1.TabIndex = 3;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panelTextArea);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTML Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Window_FormClosed);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panelTextArea.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItems;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItemNewFile;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItemSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItemPrint;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItemPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem editMenuItems;
        private System.Windows.Forms.ToolStripMenuItem editMenuItemUndo;
        private System.Windows.Forms.ToolStripMenuItem editMenuItemRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem editMenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem editMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem editMenuItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem editMenuItemSelectAll;
        private System.Windows.Forms.ToolStripMenuItem serviceMenuItems;
        private System.Windows.Forms.ToolStripMenuItem serviceMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem serviceMenuItemOptions;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItems;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItemIndex;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItemSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItemAboutProgram;
        private System.Windows.Forms.RichTextBox textArea;
        private System.Windows.Forms.Panel panelTextArea;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItemNewWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

