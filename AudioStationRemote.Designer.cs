namespace AudioStationRemote
{
	partial class AudioStationRemote
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioStationRemote));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.playbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.playToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnPrev = new System.Windows.Forms.ToolStripButton();
			this.btnPlayPause = new System.Windows.Forms.ToolStripButton();
			this.btnStop = new System.Windows.Forms.ToolStripButton();
			this.btnNext = new System.Windows.Forms.ToolStripButton();
			this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
			this.lblVolume = new System.Windows.Forms.ToolStripLabel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.AlbumListTabstrip = new System.Windows.Forms.TabControl();
			this.tabAlbumTree = new System.Windows.Forms.TabPage();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.libraryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.playToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.queueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.afterThisSongsamePriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.afterThisSonghigherPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.afterThisSonghigherPriorityIncrementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.treeList = new System.Windows.Forms.ImageList(this.components);
			this.tabAlbumList = new System.Windows.Forms.TabPage();
			this.tabAlbumTags = new System.Windows.Forms.TabPage();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.replaceQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabQueue = new System.Windows.Forms.TabPage();
			this.queue = new System.Windows.Forms.ListView();
			this.playingIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Track = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.queueMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enqueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.pingTimer = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.AlbumListTabstrip.SuspendLayout();
			this.tabAlbumTree.SuspendLayout();
			this.libraryMenu.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabMenu.SuspendLayout();
			this.tabQueue.SuspendLayout();
			this.queueMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.playbackToolStripMenuItem,
            this.libraryToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1285, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+f";
			this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.findToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.findToolStripMenuItem.Text = "&Find";
			// 
			// playbackToolStripMenuItem
			// 
			this.playbackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousToolStripMenuItem,
            this.playToolStripMenuItem2,
            this.nextToolStripMenuItem});
			this.playbackToolStripMenuItem.Name = "playbackToolStripMenuItem";
			this.playbackToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.playbackToolStripMenuItem.Text = "Playback";
			// 
			// previousToolStripMenuItem
			// 
			this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
			this.previousToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.previousToolStripMenuItem.Text = "Previous";
			// 
			// playToolStripMenuItem2
			// 
			this.playToolStripMenuItem2.Name = "playToolStripMenuItem2";
			this.playToolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
			this.playToolStripMenuItem2.Text = "Play";
			// 
			// nextToolStripMenuItem
			// 
			this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
			this.nextToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.nextToolStripMenuItem.Text = "Next";
			// 
			// libraryToolStripMenuItem
			// 
			this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
			this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
			this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.libraryToolStripMenuItem.Text = "Library";
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.updateToolStripMenuItem.Text = "Update";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrev,
            this.btnPlayPause,
            this.btnStop,
            this.btnNext,
            this.toolStripComboBox1,
            this.lblVolume});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1285, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnPrev
			// 
			this.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
			this.btnPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(23, 22);
			this.btnPrev.Text = "toolStripButton1";
			this.btnPrev.ToolTipText = "Previous Song";
			this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			// 
			// btnPlayPause
			// 
			this.btnPlayPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnPlayPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayPause.Image")));
			this.btnPlayPause.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPlayPause.Name = "btnPlayPause";
			this.btnPlayPause.Size = new System.Drawing.Size(23, 22);
			this.btnPlayPause.Text = "toolStripButton2";
			this.btnPlayPause.ToolTipText = "Play / Pause";
			this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
			// 
			// btnStop
			// 
			this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
			this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(23, 22);
			this.btnStop.Text = "toolStripButton3";
			this.btnStop.ToolTipText = "Stop";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnNext
			// 
			this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
			this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(23, 22);
			this.btnNext.Text = "toolStripButton4";
			this.btnNext.ToolTipText = "Next Song";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// toolStripComboBox1
			// 
			this.toolStripComboBox1.Name = "toolStripComboBox1";
			this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
			// 
			// lblVolume
			// 
			this.lblVolume.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.lblVolume.Name = "lblVolume";
			this.lblVolume.Size = new System.Drawing.Size(47, 22);
			this.lblVolume.Text = "Volume";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 49);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.AlbumListTabstrip);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Size = new System.Drawing.Size(1285, 572);
			this.splitContainer1.SplitterDistance = 219;
			this.splitContainer1.TabIndex = 2;
			// 
			// AlbumListTabstrip
			// 
			this.AlbumListTabstrip.Controls.Add(this.tabAlbumTree);
			this.AlbumListTabstrip.Controls.Add(this.tabAlbumList);
			this.AlbumListTabstrip.Controls.Add(this.tabAlbumTags);
			this.AlbumListTabstrip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AlbumListTabstrip.Location = new System.Drawing.Point(0, 0);
			this.AlbumListTabstrip.Name = "AlbumListTabstrip";
			this.AlbumListTabstrip.SelectedIndex = 0;
			this.AlbumListTabstrip.Size = new System.Drawing.Size(219, 572);
			this.AlbumListTabstrip.TabIndex = 1;
			// 
			// tabAlbumTree
			// 
			this.tabAlbumTree.Controls.Add(this.treeView1);
			this.tabAlbumTree.Location = new System.Drawing.Point(4, 22);
			this.tabAlbumTree.Name = "tabAlbumTree";
			this.tabAlbumTree.Padding = new System.Windows.Forms.Padding(3);
			this.tabAlbumTree.Size = new System.Drawing.Size(211, 546);
			this.tabAlbumTree.TabIndex = 0;
			this.tabAlbumTree.Text = "Treeview";
			this.tabAlbumTree.UseVisualStyleBackColor = true;
			// 
			// treeView1
			// 
			this.treeView1.ContextMenuStrip = this.libraryMenu;
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.ImageIndex = 0;
			this.treeView1.ImageList = this.treeList;
			this.treeView1.Location = new System.Drawing.Point(3, 3);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = 0;
			this.treeView1.Size = new System.Drawing.Size(205, 540);
			this.treeView1.TabIndex = 0;
			this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
			// 
			// libraryMenu
			// 
			this.libraryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem1,
            this.queueToolStripMenuItem});
			this.libraryMenu.Name = "libraryMenu";
			this.libraryMenu.Size = new System.Drawing.Size(110, 48);
			// 
			// playToolStripMenuItem1
			// 
			this.playToolStripMenuItem1.Name = "playToolStripMenuItem1";
			this.playToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
			this.playToolStripMenuItem1.Text = "Play";
			// 
			// queueToolStripMenuItem
			// 
			this.queueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afterThisSongsamePriorityToolStripMenuItem,
            this.afterThisSonghigherPriorityToolStripMenuItem,
            this.afterThisSonghigherPriorityIncrementToolStripMenuItem});
			this.queueToolStripMenuItem.Name = "queueToolStripMenuItem";
			this.queueToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.queueToolStripMenuItem.Text = "Queue";
			// 
			// afterThisSongsamePriorityToolStripMenuItem
			// 
			this.afterThisSongsamePriorityToolStripMenuItem.Name = "afterThisSongsamePriorityToolStripMenuItem";
			this.afterThisSongsamePriorityToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
			this.afterThisSongsamePriorityToolStripMenuItem.Text = "After this song (same priority)";
			// 
			// afterThisSonghigherPriorityToolStripMenuItem
			// 
			this.afterThisSonghigherPriorityToolStripMenuItem.Name = "afterThisSonghigherPriorityToolStripMenuItem";
			this.afterThisSonghigherPriorityToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
			this.afterThisSonghigherPriorityToolStripMenuItem.Text = "After this song (higher priority)";
			// 
			// afterThisSonghigherPriorityIncrementToolStripMenuItem
			// 
			this.afterThisSonghigherPriorityIncrementToolStripMenuItem.Name = "afterThisSonghigherPriorityIncrementToolStripMenuItem";
			this.afterThisSonghigherPriorityIncrementToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
			this.afterThisSonghigherPriorityIncrementToolStripMenuItem.Text = "After this song (higher priority, increment)";
			// 
			// treeList
			// 
			this.treeList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeList.ImageStream")));
			this.treeList.TransparentColor = System.Drawing.Color.Transparent;
			this.treeList.Images.SetKeyName(0, "folder.png");
			this.treeList.Images.SetKeyName(1, "song.png");
			// 
			// tabAlbumList
			// 
			this.tabAlbumList.Location = new System.Drawing.Point(4, 22);
			this.tabAlbumList.Name = "tabAlbumList";
			this.tabAlbumList.Padding = new System.Windows.Forms.Padding(3);
			this.tabAlbumList.Size = new System.Drawing.Size(211, 546);
			this.tabAlbumList.TabIndex = 1;
			this.tabAlbumList.Text = "Explorer View";
			this.tabAlbumList.UseVisualStyleBackColor = true;
			// 
			// tabAlbumTags
			// 
			this.tabAlbumTags.Location = new System.Drawing.Point(4, 22);
			this.tabAlbumTags.Name = "tabAlbumTags";
			this.tabAlbumTags.Padding = new System.Windows.Forms.Padding(3);
			this.tabAlbumTags.Size = new System.Drawing.Size(211, 546);
			this.tabAlbumTags.TabIndex = 2;
			this.tabAlbumTags.Text = "Tag view";
			this.tabAlbumTags.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.AllowDrop = true;
			this.tabControl1.ContextMenuStrip = this.tabMenu;
			this.tabControl1.Controls.Add(this.tabQueue);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1062, 572);
			this.tabControl1.TabIndex = 0;
			// 
			// tabMenu
			// 
			this.tabMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addToQueueToolStripMenuItem,
            this.replaceQueueToolStripMenuItem});
			this.tabMenu.Name = "contextMenuStrip1";
			this.tabMenu.Size = new System.Drawing.Size(154, 92);
			// 
			// renameToolStripMenuItem
			// 
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.renameToolStripMenuItem.Text = "Rename";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			// 
			// addToQueueToolStripMenuItem
			// 
			this.addToQueueToolStripMenuItem.Name = "addToQueueToolStripMenuItem";
			this.addToQueueToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.addToQueueToolStripMenuItem.Text = "Add to Queue";
			// 
			// replaceQueueToolStripMenuItem
			// 
			this.replaceQueueToolStripMenuItem.Name = "replaceQueueToolStripMenuItem";
			this.replaceQueueToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.replaceQueueToolStripMenuItem.Text = "Replace Queue";
			// 
			// tabQueue
			// 
			this.tabQueue.Controls.Add(this.queue);
			this.tabQueue.Location = new System.Drawing.Point(4, 22);
			this.tabQueue.Name = "tabQueue";
			this.tabQueue.Padding = new System.Windows.Forms.Padding(3);
			this.tabQueue.Size = new System.Drawing.Size(1054, 546);
			this.tabQueue.TabIndex = 0;
			this.tabQueue.Text = "Queue";
			this.tabQueue.UseVisualStyleBackColor = true;
			// 
			// queue
			// 
			this.queue.AllowColumnReorder = true;
			this.queue.AllowDrop = true;
			this.queue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playingIndex,
            this.Artist,
            this.Track,
            this.Title,
            this.Filename});
			this.queue.ContextMenuStrip = this.queueMenu;
			this.queue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.queue.FullRowSelect = true;
			this.queue.HideSelection = false;
			this.queue.Location = new System.Drawing.Point(3, 3);
			this.queue.Name = "queue";
			this.queue.ShowGroups = false;
			this.queue.Size = new System.Drawing.Size(1048, 540);
			this.queue.SmallImageList = this.treeList;
			this.queue.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.queue.TabIndex = 0;
			this.queue.UseCompatibleStateImageBehavior = false;
			this.queue.View = System.Windows.Forms.View.Details;
			// 
			// playingIndex
			// 
			this.playingIndex.Text = "";
			this.playingIndex.Width = 14;
			// 
			// Artist
			// 
			this.Artist.Text = "Artist/Album";
			// 
			// Track
			// 
			this.Track.Text = "Track";
			// 
			// Title
			// 
			this.Title.Text = "Title";
			// 
			// Filename
			// 
			this.Filename.Text = "Filename";
			// 
			// queueMenu
			// 
			this.queueMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.enqueueToolStripMenuItem,
            this.deleteToolStripMenuItem1});
			this.queueMenu.Name = "queueMenu";
			this.queueMenu.Size = new System.Drawing.Size(121, 70);
			// 
			// playToolStripMenuItem
			// 
			this.playToolStripMenuItem.Name = "playToolStripMenuItem";
			this.playToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.playToolStripMenuItem.Text = "Play";
			// 
			// enqueueToolStripMenuItem
			// 
			this.enqueueToolStripMenuItem.Name = "enqueueToolStripMenuItem";
			this.enqueueToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.enqueueToolStripMenuItem.Text = "Enqueue";
			// 
			// deleteToolStripMenuItem1
			// 
			this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
			this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
			this.deleteToolStripMenuItem1.Text = "Delete";
			// 
			// pingTimer
			// 
			this.pingTimer.Enabled = true;
			this.pingTimer.Interval = 1000;
			this.pingTimer.Tick += new System.EventHandler(this.pingTimer_Tick);
			// 
			// AudioStationRemote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1285, 621);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "AudioStationRemote";
			this.Text = "AudioStation Remote";
			this.Load += new System.EventHandler(this.AudioStationRemote_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.AlbumListTabstrip.ResumeLayout(false);
			this.tabAlbumTree.ResumeLayout(false);
			this.libraryMenu.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabMenu.ResumeLayout(false);
			this.tabQueue.ResumeLayout(false);
			this.queueMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem playbackToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnPrev;
		private System.Windows.Forms.ToolStripButton btnPlayPause;
		private System.Windows.Forms.ToolStripButton btnStop;
		private System.Windows.Forms.ToolStripButton btnNext;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView treeView1;
		public System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabQueue;
		private System.Windows.Forms.TabControl AlbumListTabstrip;
		private System.Windows.Forms.TabPage tabAlbumTree;
		private System.Windows.Forms.TabPage tabAlbumList;
		private System.Windows.Forms.TabPage tabAlbumTags;
		private System.Windows.Forms.ListView queue;
		private System.Windows.Forms.ColumnHeader Track;
		private System.Windows.Forms.ColumnHeader Artist;
		private System.Windows.Forms.ColumnHeader Title;
		private System.Windows.Forms.ColumnHeader Filename;
		private System.Windows.Forms.ColumnHeader playingIndex;
		public System.Windows.Forms.ImageList treeList;
		private System.Windows.Forms.Timer pingTimer;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip libraryMenu;
		private System.Windows.Forms.ToolStripMenuItem queueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem afterThisSongsamePriorityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem afterThisSonghigherPriorityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem afterThisSonghigherPriorityIncrementToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip tabMenu;
		private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToQueueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem replaceQueueToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip queueMenu;
		private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem enqueueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
		private System.Windows.Forms.ToolStripLabel lblVolume;
	}
}

