
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BackB = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.FilePathT = new System.Windows.Forms.TextBox();
            this.Gob = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.CreateF = new System.Windows.Forms.Button();
            this.CreateP = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.CopyB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackB
            // 
            this.BackB.Location = new System.Drawing.Point(0, 21);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(75, 20);
            this.BackB.TabIndex = 0;
            this.BackB.Text = "Back";
            this.BackB.UseVisualStyleBackColor = true;
            this.BackB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.IconList;
            this.listView1.Location = new System.Drawing.Point(0, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1069, 345);
            this.listView1.SmallImageList = this.IconList;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "png-clipart-directory-computer-icons-others-miscellaneous-angle.png");
            this.IconList.Images.SetKeyName(1, "png-transparent-blue-note-illustration-computer-icons-document-checklist-icon-blu" +
        "e-blue-checklist-document-miscellaneous-blue-angle.png");
            this.IconList.Images.SetKeyName(2, "png-transparent-music-icon-pink-purple-symbol-itunes-purple-violet-magenta.png");
            this.IconList.Images.SetKeyName(3, "img_98042.png");
            this.IconList.Images.SetKeyName(4, "png-transparent-computer-icons-cmd-exe-command-line-interface-others-miscellaneou" +
        "s-angle-text.png");
            this.IconList.Images.SetKeyName(5, "png-transparent-computer-icons-video-editing-movies-angle-text-rectangle.png");
            this.IconList.Images.SetKeyName(6, "png-transparent-pdf-computer-icons-adobe-acrobat-document-file-format-acent-alask" +
        "a-center-for-ent-blue-text-rectangle.png");
            this.IconList.Images.SetKeyName(7, "png-transparent-computer-icons-google-docs-document-google-text-rectangle-doc.png" +
        "");
            // 
            // FilePathT
            // 
            this.FilePathT.Location = new System.Drawing.Point(165, 21);
            this.FilePathT.Name = "FilePathT";
            this.FilePathT.Size = new System.Drawing.Size(904, 20);
            this.FilePathT.TabIndex = 2;
            // 
            // Gob
            // 
            this.Gob.Location = new System.Drawing.Point(81, 20);
            this.Gob.Name = "Gob";
            this.Gob.Size = new System.Drawing.Size(78, 21);
            this.Gob.TabIndex = 3;
            this.Gob.Text = "Go";
            this.Gob.UseVisualStyleBackColor = true;
            this.Gob.Click += new System.EventHandler(this.Gob_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(804, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(867, 417);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(16, 13);
            this.fileNameLabel.TabIndex = 5;
            this.fileNameLabel.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(804, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип";
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(836, 441);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(16, 13);
            this.fileTypeLabel.TabIndex = 7;
            this.fileTypeLabel.Text = "---";
            // 
            // CreateF
            // 
            this.CreateF.Location = new System.Drawing.Point(12, 407);
            this.CreateF.Name = "CreateF";
            this.CreateF.Size = new System.Drawing.Size(97, 47);
            this.CreateF.TabIndex = 8;
            this.CreateF.Text = "Создание Файла";
            this.CreateF.UseVisualStyleBackColor = true;
            this.CreateF.Click += new System.EventHandler(this.CreateF_Click);
            // 
            // CreateP
            // 
            this.CreateP.Location = new System.Drawing.Point(133, 407);
            this.CreateP.Name = "CreateP";
            this.CreateP.Size = new System.Drawing.Size(96, 47);
            this.CreateP.TabIndex = 9;
            this.CreateP.Text = "Создание Папки";
            this.CreateP.UseVisualStyleBackColor = true;
            this.CreateP.Click += new System.EventHandler(this.CreateP_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(258, 407);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(99, 47);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Удаление";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // CopyB
            // 
            this.CopyB.Location = new System.Drawing.Point(379, 407);
            this.CopyB.Name = "CopyB";
            this.CopyB.Size = new System.Drawing.Size(102, 47);
            this.CopyB.TabIndex = 11;
            this.CopyB.Text = "Копирование";
            this.CopyB.UseVisualStyleBackColor = true;
            this.CopyB.Click += new System.EventHandler(this.CopyB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 477);
            this.Controls.Add(this.CopyB);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.CreateP);
            this.Controls.Add(this.CreateF);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gob);
            this.Controls.Add(this.FilePathT);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BackB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox FilePathT;
        private System.Windows.Forms.Button Gob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.Button CreateF;
        private System.Windows.Forms.Button CreateP;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button CopyB;
    }
}

