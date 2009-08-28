﻿namespace ganjoor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPreviousPoem = new System.Windows.Forms.ToolStripButton();
            this.btnNextPoem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHistoryBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnViewInSite = new System.Windows.Forms.ToolStripButton();
            this.btnComments = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnHighlight = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOptions = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblDummy = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentPage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlbrSearch = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtHighlight = new System.Windows.Forms.ToolStripTextBox();
            this.lblFoundItemCount = new System.Windows.Forms.ToolStripLabel();
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuNav = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPreviousPoem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNextPoem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHistoryBack = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewInSite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuComments = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSrch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHighlight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHlp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ganjoorView = new ganjoor.GanjoorViewer();
            this.toolStripMain.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tlbrSearch.SuspendLayout();
            this.mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHome,
            this.toolStripSeparator1,
            this.btnPreviousPoem,
            this.btnNextPoem,
            this.toolStripSeparator2,
            this.btnHistoryBack,
            this.toolStripSeparator4,
            this.btnViewInSite,
            this.btnComments,
            this.toolStripSeparator3,
            this.btnPrint,
            this.toolStripSeparator5,
            this.btnCopy,
            this.btnHighlight,
            this.btnSearch,
            this.toolStripSeparator7,
            this.btnOptions,
            this.toolStripSeparator6,
            this.btnAbout});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(716, 53);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "نوار ابزار";
            // 
            // btnHome
            // 
            this.btnHome.Image = global::ganjoor.Properties.Resources.home_next;
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(36, 50);
            this.btnHome.Text = "خانه";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // btnPreviousPoem
            // 
            this.btnPreviousPoem.Enabled = false;
            this.btnPreviousPoem.Image = global::ganjoor.Properties.Resources.fast_forward;
            this.btnPreviousPoem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreviousPoem.Name = "btnPreviousPoem";
            this.btnPreviousPoem.Size = new System.Drawing.Size(56, 50);
            this.btnPreviousPoem.Text = "شعر قبل";
            this.btnPreviousPoem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPreviousPoem.Click += new System.EventHandler(this.btnPreviousPoem_Click);
            // 
            // btnNextPoem
            // 
            this.btnNextPoem.Enabled = false;
            this.btnNextPoem.Image = global::ganjoor.Properties.Resources.rewind;
            this.btnNextPoem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextPoem.Name = "btnNextPoem";
            this.btnNextPoem.Size = new System.Drawing.Size(54, 50);
            this.btnNextPoem.Text = "شعر بعد";
            this.btnNextPoem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNextPoem.Click += new System.EventHandler(this.btnNextPoem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 53);
            // 
            // btnHistoryBack
            // 
            this.btnHistoryBack.Image = global::ganjoor.Properties.Resources.repeat;
            this.btnHistoryBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHistoryBack.Name = "btnHistoryBack";
            this.btnHistoryBack.Size = new System.Drawing.Size(49, 50);
            this.btnHistoryBack.Text = "برگشت";
            this.btnHistoryBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHistoryBack.Click += new System.EventHandler(this.btnHistoryBack_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 53);
            // 
            // btnViewInSite
            // 
            this.btnViewInSite.Image = global::ganjoor.Properties.Resources.firefox_alt;
            this.btnViewInSite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewInSite.Name = "btnViewInSite";
            this.btnViewInSite.Size = new System.Drawing.Size(36, 50);
            this.btnViewInSite.Text = "مرور";
            this.btnViewInSite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnViewInSite.Click += new System.EventHandler(this.btnViewInSite_Click);
            // 
            // btnComments
            // 
            this.btnComments.Enabled = false;
            this.btnComments.Image = global::ganjoor.Properties.Resources.comments;
            this.btnComments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(58, 50);
            this.btnComments.Text = "حاشیه‌ها";
            this.btnComments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnComments.Click += new System.EventHandler(this.btnComments_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 53);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::ganjoor.Properties.Resources.printer;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(36, 50);
            this.btnPrint.Text = "چاپ";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 53);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = global::ganjoor.Properties.Resources.note_accept;
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(56, 50);
            this.btnCopy.Text = "کپی متن";
            this.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCopy.Click += new System.EventHandler(this.btnCopyText_Click);
            // 
            // btnHighlight
            // 
            this.btnHighlight.CheckOnClick = true;
            this.btnHighlight.Image = global::ganjoor.Properties.Resources.search;
            this.btnHighlight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHighlight.Name = "btnHighlight";
            this.btnHighlight.Size = new System.Drawing.Size(81, 50);
            this.btnHighlight.Text = "برجسته‌سازی";
            this.btnHighlight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHighlight.CheckedChanged += new System.EventHandler(this.btnHighlight_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::ganjoor.Properties.Resources.database_search;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 50);
            this.btnSearch.Text = "جستجو";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 53);
            // 
            // btnOptions
            // 
            this.btnOptions.Image = global::ganjoor.Properties.Resources.process;
            this.btnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(51, 50);
            this.btnOptions.Text = "تنظیمات";
            this.btnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 53);
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::ganjoor.Properties.Resources.help;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.RightToLeftAutoMirrorImage = true;
            this.btnAbout.Size = new System.Drawing.Size(38, 50);
            this.btnAbout.Text = "درباره";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDummy,
            this.lblCurrentPage});
            this.statusStrip.Location = new System.Drawing.Point(0, 320);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.Size = new System.Drawing.Size(716, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "نوار وضعیت";
            // 
            // lblDummy
            // 
            this.lblDummy.Name = "lblDummy";
            this.lblDummy.Size = new System.Drawing.Size(672, 17);
            this.lblDummy.Spring = true;
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrentPage.Size = new System.Drawing.Size(29, 17);
            this.lblCurrentPage.Text = "خانه";
            // 
            // tlbrSearch
            // 
            this.tlbrSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlbrSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlbrSearch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlbrSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtHighlight,
            this.lblFoundItemCount});
            this.tlbrSearch.Location = new System.Drawing.Point(0, 295);
            this.tlbrSearch.Name = "tlbrSearch";
            this.tlbrSearch.Size = new System.Drawing.Size(716, 25);
            this.tlbrSearch.TabIndex = 3;
            this.tlbrSearch.Text = "نوار ابزار جستجوی محل";
            this.tlbrSearch.Visible = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabel1.Text = "متن:";
            // 
            // txtHighlight
            // 
            this.txtHighlight.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighlight.Name = "txtHighlight";
            this.txtHighlight.Size = new System.Drawing.Size(200, 25);
            this.txtHighlight.TextChanged += new System.EventHandler(this.txtHighlight_TextChanged);
            // 
            // lblFoundItemCount
            // 
            this.lblFoundItemCount.Name = "lblFoundItemCount";
            this.lblFoundItemCount.Size = new System.Drawing.Size(87, 22);
            this.lblFoundItemCount.Text = "0 مورد پیدا شد.";
            this.lblFoundItemCount.Visible = false;
            // 
            // mnu
            // 
            this.mnu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNav,
            this.mnuTools,
            this.mnuSrch,
            this.mnuHlp});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(716, 24);
            this.mnu.TabIndex = 4;
            this.mnu.Text = "منوی اصلی";
            // 
            // mnuNav
            // 
            this.mnuNav.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.toolStripSeparator8,
            this.mnuPreviousPoem,
            this.mnuNextPoem,
            this.toolStripSeparator9,
            this.mnuHistoryBack,
            this.toolStripSeparator10,
            this.mnuExit});
            this.mnuNav.Name = "mnuNav";
            this.mnuNav.Size = new System.Drawing.Size(49, 20);
            this.mnuNav.Text = "ناوبری";
            // 
            // mnuHome
            // 
            this.mnuHome.Image = global::ganjoor.Properties.Resources.home_next;
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuHome.Size = new System.Drawing.Size(180, 22);
            this.mnuHome.Text = "خانه";
            this.mnuHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuPreviousPoem
            // 
            this.mnuPreviousPoem.Enabled = false;
            this.mnuPreviousPoem.Image = global::ganjoor.Properties.Resources.fast_forward;
            this.mnuPreviousPoem.Name = "mnuPreviousPoem";
            this.mnuPreviousPoem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.mnuPreviousPoem.Size = new System.Drawing.Size(180, 22);
            this.mnuPreviousPoem.Text = "شعر قبل";
            this.mnuPreviousPoem.Click += new System.EventHandler(this.btnPreviousPoem_Click);
            // 
            // mnuNextPoem
            // 
            this.mnuNextPoem.Enabled = false;
            this.mnuNextPoem.Image = global::ganjoor.Properties.Resources.rewind;
            this.mnuNextPoem.Name = "mnuNextPoem";
            this.mnuNextPoem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.mnuNextPoem.Size = new System.Drawing.Size(180, 22);
            this.mnuNextPoem.Text = "شعر بعد";
            this.mnuNextPoem.Click += new System.EventHandler(this.btnNextPoem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuHistoryBack
            // 
            this.mnuHistoryBack.Image = global::ganjoor.Properties.Resources.repeat;
            this.mnuHistoryBack.Name = "mnuHistoryBack";
            this.mnuHistoryBack.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mnuHistoryBack.Size = new System.Drawing.Size(180, 22);
            this.mnuHistoryBack.Text = "برگشت";
            this.mnuHistoryBack.Click += new System.EventHandler(this.btnHistoryBack_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "خروج";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewInSite,
            this.mnuComments,
            this.toolStripSeparator11,
            this.mnuCopy,
            this.toolStripSeparator12,
            this.mnuPrint,
            this.mnuPrintPreview,
            this.toolStripSeparator13,
            this.mnuOptions});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(49, 20);
            this.mnuTools.Text = "ابزارها";
            // 
            // mnuViewInSite
            // 
            this.mnuViewInSite.Image = global::ganjoor.Properties.Resources.firefox_alt;
            this.mnuViewInSite.Name = "mnuViewInSite";
            this.mnuViewInSite.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.mnuViewInSite.Size = new System.Drawing.Size(267, 22);
            this.mnuViewInSite.Text = "مرور شعر در گنجور تحت وب";
            this.mnuViewInSite.Click += new System.EventHandler(this.btnViewInSite_Click);
            // 
            // mnuComments
            // 
            this.mnuComments.Enabled = false;
            this.mnuComments.Image = global::ganjoor.Properties.Resources.comments;
            this.mnuComments.Name = "mnuComments";
            this.mnuComments.Size = new System.Drawing.Size(267, 22);
            this.mnuComments.Text = "حاشیه‌های این شعر در گنجور تحت وب";
            this.mnuComments.Click += new System.EventHandler(this.btnComments_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(264, 6);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Image = global::ganjoor.Properties.Resources.note_accept;
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuCopy.Size = new System.Drawing.Size(267, 22);
            this.mnuCopy.Text = "کپی متن";
            this.mnuCopy.Click += new System.EventHandler(this.btnCopyText_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(264, 6);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Image = global::ganjoor.Properties.Resources.printer;
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuPrint.Size = new System.Drawing.Size(267, 22);
            this.mnuPrint.Text = "چاپ";
            this.mnuPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // mnuPrintPreview
            // 
            this.mnuPrintPreview.Name = "mnuPrintPreview";
            this.mnuPrintPreview.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.P)));
            this.mnuPrintPreview.Size = new System.Drawing.Size(267, 22);
            this.mnuPrintPreview.Text = "پیش‌نمایش چاپ";
            this.mnuPrintPreview.Click += new System.EventHandler(this.mnuPrintPreview_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(264, 6);
            // 
            // mnuOptions
            // 
            this.mnuOptions.Image = global::ganjoor.Properties.Resources.process;
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(267, 22);
            this.mnuOptions.Text = "تنظیمات";
            this.mnuOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // mnuSrch
            // 
            this.mnuSrch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHighlight,
            this.mnuSearch});
            this.mnuSrch.Name = "mnuSrch";
            this.mnuSrch.Size = new System.Drawing.Size(57, 20);
            this.mnuSrch.Text = "جستجو";
            // 
            // mnuHighlight
            // 
            this.mnuHighlight.Image = global::ganjoor.Properties.Resources.search;
            this.mnuHighlight.Name = "mnuHighlight";
            this.mnuHighlight.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuHighlight.Size = new System.Drawing.Size(222, 22);
            this.mnuHighlight.Text = "جستجو در شعر جاری";
            this.mnuHighlight.Click += new System.EventHandler(this.mnuHighlight_Click);
            // 
            // mnuSearch
            // 
            this.mnuSearch.Image = global::ganjoor.Properties.Resources.database_search;
            this.mnuSearch.Name = "mnuSearch";
            this.mnuSearch.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuSearch.Size = new System.Drawing.Size(222, 22);
            this.mnuSearch.Text = "جستجو در همۀ شعرها";
            this.mnuSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // mnuHlp
            // 
            this.mnuHlp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHlp.Name = "mnuHlp";
            this.mnuHlp.Size = new System.Drawing.Size(49, 20);
            this.mnuHlp.Text = "راهنما";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Image = global::ganjoor.Properties.Resources.help;
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuAbout.Size = new System.Drawing.Size(172, 22);
            this.mnuAbout.Text = "دربارۀ این برنامه";
            this.mnuAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // ganjoorView
            // 
            this.ganjoorView.AutoScroll = true;
            this.ganjoorView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ganjoorView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ganjoorView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ganjoorView.Location = new System.Drawing.Point(0, 77);
            this.ganjoorView.Name = "ganjoorView";
            this.ganjoorView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ganjoorView.Size = new System.Drawing.Size(716, 218);
            this.ganjoorView.TabIndex = 0;
            this.ganjoorView.OnPageChanged += new ganjoor.PageChangedEvent(this.ganjoorView_OnPageChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 342);
            this.Controls.Add(this.ganjoorView);
            this.Controls.Add(this.tlbrSearch);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mnu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گنجور رومیزی";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tlbrSearch.ResumeLayout(false);
            this.tlbrSearch.PerformLayout();
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GanjoorViewer ganjoorView;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPreviousPoem;
        private System.Windows.Forms.ToolStripButton btnNextPoem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnViewInSite;
        private System.Windows.Forms.ToolStripButton btnComments;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel lblDummy;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentPage;
        private System.Windows.Forms.ToolStripButton btnHistoryBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripButton btnOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnHighlight;
        private System.Windows.Forms.ToolStrip tlbrSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtHighlight;
        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuNav;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mnuPreviousPoem;
        private System.Windows.Forms.ToolStripMenuItem mnuNextPoem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem mnuHistoryBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuViewInSite;
        private System.Windows.Forms.ToolStripMenuItem mnuComments;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuSrch;
        private System.Windows.Forms.ToolStripMenuItem mnuHighlight;
        private System.Windows.Forms.ToolStripMenuItem mnuSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuHlp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripLabel lblFoundItemCount;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintPreview;





    }
}

