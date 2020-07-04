namespace Crystal_TBA_Tools
{
    partial class Form1
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
            this.roomName = new System.Windows.Forms.TextBox();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.mapIdLabel = new System.Windows.Forms.Label();
            this.northLabel = new System.Windows.Forms.Label();
            this.westLabel = new System.Windows.Forms.Label();
            this.eastLabel = new System.Windows.Forms.Label();
            this.southLabel = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapId = new System.Windows.Forms.NumericUpDown();
            this.northId = new System.Windows.Forms.NumericUpDown();
            this.westId = new System.Windows.Forms.NumericUpDown();
            this.eastId = new System.Windows.Forms.NumericUpDown();
            this.southId = new System.Windows.Forms.NumericUpDown();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.addRoomBtn = new System.Windows.Forms.Button();
            this.itemLabel = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.TextBox();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.enemyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enemyWeapon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.enemyDamage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.enemyHealth = new System.Windows.Forms.NumericUpDown();
            this.accessible = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.accessCondition = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.accessItem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.itemList = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadRoom = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.westId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eastId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.southId)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHealth)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomName
            // 
            this.roomName.Location = new System.Drawing.Point(47, 74);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(212, 20);
            this.roomName.TabIndex = 0;
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameLabel.Location = new System.Drawing.Point(47, 49);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(75, 13);
            this.roomNameLabel.TabIndex = 6;
            this.roomNameLabel.Text = "Room Name";
            // 
            // mapIdLabel
            // 
            this.mapIdLabel.AutoSize = true;
            this.mapIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapIdLabel.Location = new System.Drawing.Point(47, 112);
            this.mapIdLabel.Name = "mapIdLabel";
            this.mapIdLabel.Size = new System.Drawing.Size(48, 13);
            this.mapIdLabel.TabIndex = 7;
            this.mapIdLabel.Text = "Map ID";
            // 
            // northLabel
            // 
            this.northLabel.AutoSize = true;
            this.northLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.northLabel.Location = new System.Drawing.Point(244, 133);
            this.northLabel.Name = "northLabel";
            this.northLabel.Size = new System.Drawing.Size(16, 13);
            this.northLabel.TabIndex = 8;
            this.northLabel.Text = "N";
            // 
            // westLabel
            // 
            this.westLabel.AutoSize = true;
            this.westLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.westLabel.Location = new System.Drawing.Point(244, 159);
            this.westLabel.Name = "westLabel";
            this.westLabel.Size = new System.Drawing.Size(19, 13);
            this.westLabel.TabIndex = 9;
            this.westLabel.Text = "W";
            // 
            // eastLabel
            // 
            this.eastLabel.AutoSize = true;
            this.eastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eastLabel.Location = new System.Drawing.Point(244, 185);
            this.eastLabel.Name = "eastLabel";
            this.eastLabel.Size = new System.Drawing.Size(15, 13);
            this.eastLabel.TabIndex = 10;
            this.eastLabel.Text = "E";
            // 
            // southLabel
            // 
            this.southLabel.AutoSize = true;
            this.southLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.southLabel.Location = new System.Drawing.Point(244, 211);
            this.southLabel.Name = "southLabel";
            this.southLabel.Size = new System.Drawing.Size(15, 13);
            this.southLabel.TabIndex = 11;
            this.southLabel.Text = "S";
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionLabel.Location = new System.Drawing.Point(186, 112);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(58, 13);
            this.directionLabel.TabIndex = 12;
            this.directionLabel.Text = "Direction";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mapId
            // 
            this.mapId.Location = new System.Drawing.Point(47, 133);
            this.mapId.Name = "mapId";
            this.mapId.Size = new System.Drawing.Size(120, 20);
            this.mapId.TabIndex = 20;
            // 
            // northId
            // 
            this.northId.Location = new System.Drawing.Point(189, 131);
            this.northId.Name = "northId";
            this.northId.Size = new System.Drawing.Size(41, 20);
            this.northId.TabIndex = 21;
            // 
            // westId
            // 
            this.westId.Location = new System.Drawing.Point(189, 157);
            this.westId.Name = "westId";
            this.westId.Size = new System.Drawing.Size(41, 20);
            this.westId.TabIndex = 22;
            // 
            // eastId
            // 
            this.eastId.Location = new System.Drawing.Point(189, 183);
            this.eastId.Name = "eastId";
            this.eastId.Size = new System.Drawing.Size(41, 20);
            this.eastId.TabIndex = 23;
            // 
            // southId
            // 
            this.southId.Location = new System.Drawing.Point(189, 209);
            this.southId.Name = "southId";
            this.southId.Size = new System.Drawing.Size(41, 20);
            this.southId.TabIndex = 24;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 552);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(988, 22);
            this.statusStrip.TabIndex = 25;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoToolTip = true;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(480, 49);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(71, 13);
            this.descriptionLabel.TabIndex = 26;
            this.descriptionLabel.Text = "Description";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(483, 74);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(454, 103);
            this.description.TabIndex = 27;
            this.description.Text = "";
            // 
            // addRoomBtn
            // 
            this.addRoomBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addRoomBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addRoomBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.addRoomBtn.FlatAppearance.BorderSize = 2;
            this.addRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomBtn.Location = new System.Drawing.Point(30, 480);
            this.addRoomBtn.Name = "addRoomBtn";
            this.addRoomBtn.Size = new System.Drawing.Size(302, 60);
            this.addRoomBtn.TabIndex = 28;
            this.addRoomBtn.Text = "Add Room";
            this.addRoomBtn.UseVisualStyleBackColor = false;
            this.addRoomBtn.Click += new System.EventHandler(this.addRoomBtn_Click);
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(489, 211);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(31, 13);
            this.itemLabel.TabIndex = 29;
            this.itemLabel.Text = "Item";
            // 
            // item
            // 
            this.item.Location = new System.Drawing.Point(516, 181);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(238, 20);
            this.item.TabIndex = 30;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(807, 211);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(101, 40);
            this.addItemBtn.TabIndex = 31;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // enemyName
            // 
            this.enemyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyName.Location = new System.Drawing.Point(65, 37);
            this.enemyName.Name = "enemyName";
            this.enemyName.Size = new System.Drawing.Size(238, 20);
            this.enemyName.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Health :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enemyWeapon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.enemyDamage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.enemyHealth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.enemyName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(483, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 173);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enemy";
            // 
            // enemyWeapon
            // 
            this.enemyWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyWeapon.Location = new System.Drawing.Point(65, 140);
            this.enemyWeapon.Name = "enemyWeapon";
            this.enemyWeapon.Size = new System.Drawing.Size(236, 20);
            this.enemyWeapon.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Weapon:";
            // 
            // enemyDamage
            // 
            this.enemyDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyDamage.Location = new System.Drawing.Point(65, 107);
            this.enemyDamage.Name = "enemyDamage";
            this.enemyDamage.Size = new System.Drawing.Size(120, 20);
            this.enemyDamage.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Damage :";
            // 
            // enemyHealth
            // 
            this.enemyHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyHealth.Location = new System.Drawing.Point(65, 72);
            this.enemyHealth.Name = "enemyHealth";
            this.enemyHealth.Size = new System.Drawing.Size(120, 20);
            this.enemyHealth.TabIndex = 39;
            // 
            // accessible
            // 
            this.accessible.AutoSize = true;
            this.accessible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessible.Location = new System.Drawing.Point(50, 243);
            this.accessible.Name = "accessible";
            this.accessible.Size = new System.Drawing.Size(87, 17);
            this.accessible.TabIndex = 41;
            this.accessible.Text = "Accessible";
            this.accessible.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Access Condition";
            // 
            // accessCondition
            // 
            this.accessCondition.Location = new System.Drawing.Point(53, 288);
            this.accessCondition.Name = "accessCondition";
            this.accessCondition.Size = new System.Drawing.Size(319, 58);
            this.accessCondition.TabIndex = 43;
            this.accessCondition.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Access Item";
            // 
            // accessItem
            // 
            this.accessItem.Location = new System.Drawing.Point(53, 397);
            this.accessItem.Name = "accessItem";
            this.accessItem.Size = new System.Drawing.Size(252, 20);
            this.accessItem.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.itemList);
            this.groupBox2.Controls.Add(this.item);
            this.groupBox2.Location = new System.Drawing.Point(30, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(946, 434);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(516, 212);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(236, 21);
            this.itemList.TabIndex = 0;
            // 
            // loadBtn
            // 
            this.loadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.loadBtn.FlatAppearance.BorderSize = 2;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.Location = new System.Drawing.Point(385, 480);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(302, 60);
            this.loadBtn.TabIndex = 47;
            this.loadBtn.Text = "Load Room";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(721, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Load Room";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(459, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Added";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // loadRoom
            // 
            this.loadRoom.FormattingEnabled = true;
            this.loadRoom.Location = new System.Drawing.Point(724, 503);
            this.loadRoom.Name = "loadRoom";
            this.loadRoom.Size = new System.Drawing.Size(213, 21);
            this.loadRoom.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(988, 574);
            this.Controls.Add(this.loadRoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.accessItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.accessCondition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accessible);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.addRoomBtn);
            this.Controls.Add(this.description);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.southId);
            this.Controls.Add(this.eastId);
            this.Controls.Add(this.westId);
            this.Controls.Add(this.northId);
            this.Controls.Add(this.mapId);
            this.Controls.Add(this.directionLabel);
            this.Controls.Add(this.southLabel);
            this.Controls.Add(this.eastLabel);
            this.Controls.Add(this.westLabel);
            this.Controls.Add(this.northLabel);
            this.Controls.Add(this.mapIdLabel);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.roomName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Crystal Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.westId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eastId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.southId)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyHealth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roomName;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Label mapIdLabel;
        private System.Windows.Forms.Label northLabel;
        private System.Windows.Forms.Label westLabel;
        private System.Windows.Forms.Label eastLabel;
        private System.Windows.Forms.Label southLabel;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown mapId;
        private System.Windows.Forms.NumericUpDown northId;
        private System.Windows.Forms.NumericUpDown westId;
        private System.Windows.Forms.NumericUpDown eastId;
        private System.Windows.Forms.NumericUpDown southId;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Button addRoomBtn;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.TextBox item;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.TextBox enemyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown enemyHealth;
        private System.Windows.Forms.NumericUpDown enemyDamage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox accessible;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox accessCondition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox accessItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox enemyWeapon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ComboBox itemList;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox loadRoom;
    }
}

