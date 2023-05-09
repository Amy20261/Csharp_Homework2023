using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_NotePad
{
    public partial class frmNotePad : Form
    {
        public frmNotePad()
        {
            InitializeComponent();
        }

        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory= Application.StartupPath;
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }

            //try
            //{
            //    richTextBox1.LoadFile("test.rtf",RichTextBoxStreamType.RichText);
            //}catch (Exception ex) {
            //    MessageBox.Show(ex.Message); 
            //}
        }

        private void NotePad_Load(object sender, EventArgs e)
        {
            richTextBox1.Dock = DockStyle.Fill;
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 列印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            
            printDialog1.Document = printDoc;
            printDialog1.AllowSelection = true;
            printDialog1.AllowSomePages = true;
            //Call ShowDialog  
             
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void 瀏覽列印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            PrintDocument document = new PrintDocument();
            
            printPreviewDialog1.Document = document;
            printPreviewDialog1.ShowDialog();
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 全選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor=colorDialog.Color;
            }
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void toUpperUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //String s;
            //s.ToUpper();
            //return s;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor =Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        }

        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fa=new frmAbout();
            fa.Show();
        }
    }
}
