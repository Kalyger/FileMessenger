using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string filePath = "D:";
        private bool isFile = false;
        private string currentlySelectedItemName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilePathT.Text = filePath;
            loadFilesAnddirectories();
        }
        public void loadFilesAnddirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileNameLabel.Text = fileDetails.Name;
                    fileTypeLabel.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);
                   
                }
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)

                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();
                    string fileExtension = "";
                    listView1.Items.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        switch(fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView1.Items.Add(files[i].Name, 2);
                                break;
                            case ".EXE":
                            case ".COM":
                                listView1.Items.Add(files[i].Name, 4);
                                break;
                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView1.Items.Add(files[i].Name, 5);
                                break;
                            case ".PDF":
                                listView1.Items.Add(files[i].Name, 6);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView1.Items.Add(files[i].Name, 7);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView1.Items.Add(files[i].Name, 3);
                                break;

                            default:
                                listView1.Items.Add(files[i].Name, 1);
                                break;

                        }
                       
                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 0);
                    }
                }
                else
                {
                    fileNameLabel.Text = this.currentlySelectedItemName;
                }

            }
            catch(Exception e)
            { 
            
            }
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            BackBu();
            loadButtonAction();

        }

        public void loadButtonAction()
        {
            removeBackSlash();
            filePath = FilePathT.Text;
            loadFilesAnddirectories();
            isFile = false;
        }

        public void removeBackSlash()
        {
            string path = FilePathT.Text;
            if (path.LastIndexOf("/") == path.Length - 1)
            {
                FilePathT.Text = path.Substring(0, path.Length - 1);
            }
        }

        public void BackBu()
        {
            try
            {
                removeBackSlash();
                string path = FilePathT.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                FilePathT.Text = path;
                removeBackSlash();
            }

            catch(Exception e)
            {

            }

        }

        private void Gob_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
            FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                FilePathT.Text = filePath + "/" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }

        private void CreateP_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 addform = new Form3();
                addform.filePath = filePath;
                addform.Show();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void CreateF_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 addform = new Form2();
                addform.filePath = filePath;
                addform.Show();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                FileAttributes fileAttributes = File.GetAttributes(filePath + "/" + currentlySelectedItemName);
                if (fileAttributes.ToString().IndexOf("Directory") != -1)
                    Directory.Delete(filePath + "/" + currentlySelectedItemName,true);
                else
                    File.Delete(filePath + "/" + currentlySelectedItemName);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void CopyB_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browse = new FolderBrowserDialog();
            browse.ShowDialog();
            FileAttributes fileAttributes = File.GetAttributes(filePath + "\\" + currentlySelectedItemName);
            if (fileAttributes.ToString().IndexOf("Directory") != -1)
            {
                copy(filePath + "\\" + currentlySelectedItemName, browse.SelectedPath + "\\" + currentlySelectedItemName, true);
            }
            else
                File.Copy(filePath + "\\" + currentlySelectedItemName, browse.SelectedPath + "\\" + currentlySelectedItemName);
            MessageBox.Show("Копирование прошло успешно!", "Завершено");
        }

        public void copy(string copiedFile, string finishedFile, bool recursive)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(copiedFile);
                Directory.CreateDirectory(finishedFile);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (FileInfo file in dir.GetFiles())
                {
                    string targetFilePath = Path.Combine(finishedFile, file.Name);
                    file.CopyTo(targetFilePath);
                }
                if (recursive)
                {
                    foreach (DirectoryInfo subDir in dirs)
                    {
                        string newDestinationDir = Path.Combine(finishedFile, subDir.Name);
                        copy(subDir.FullName, newDestinationDir, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }

        }
    }
}
