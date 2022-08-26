using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PileRa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Pile> pileList = new List<Pile>();
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void btnGetRa_Click(object sender, EventArgs e)
        {
            double diameter = Convert.ToDouble(textBoxDia.Text);
            foreach (var pile in pileList)
            {
                pile.Diameter = diameter;
                textBoxCircumference.Text = pile.Circumference.ToString();
                textBoxArea.Text = pile.Area.ToString();
            }
        }
        Pile pile = new Pile();
        private void 读取文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Title = "打开土层信息文件xml";
            openFileDialog1.Filter = "xml files(*.xml)|*.xml";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                ImportFile(path);   
            }
        }
        private void ImportFile(string path)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].DisplayIndex = i;
            }
            pileList = pile.ReadFile(@path);
            dataGridView1.DataSource = pileList;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "xml files(*.xml)|*.xml";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportFile(saveFileDialog1.FileName);
                MessageBox.Show("保存成功");
            }
        }

        private void 写入文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "xml files(*.xml)|*.xml";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportFile(saveFileDialog1.FileName);
                MessageBox.Show("保存成功");
            }
        }

        private void ExportFile(string path)
        {
            //创建xml文档
            XmlDocument doc = new XmlDocument();
            //增加描述文件
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            //增加根节点
            XmlElement pile = doc.CreateElement("pile");
            doc.AppendChild(pile);
            //创建子节点

            XmlElement info = doc.CreateElement("info");
            pile.AppendChild(info);
            XmlElement diameter = doc.CreateElement("diameter");
            diameter.InnerText = dataGridView1.Rows[0].Cells[0].Value.ToString();
            info.AppendChild(diameter);
            XmlElement scoeffient = doc.CreateElement("scoeffient");
            scoeffient.InnerText = dataGridView1.Rows[0].Cells[10].Value.ToString();// "1.0";
            info.AppendChild(scoeffient);
            XmlElement ecoeffient = doc.CreateElement("ecoeffient");
            ecoeffient.InnerText = dataGridView1.Rows[0].Cells[11].Value.ToString();// "1.0";
            info.AppendChild(ecoeffient);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                XmlElement layer = doc.CreateElement("layer");
                pile.AppendChild(layer);
                XmlElement label = doc.CreateElement("label");
                label.InnerText = dataGridView1.Rows[i].Cells[7].Value.ToString(); // "HoleNo1"; 
                layer.AppendChild(label);
                XmlElement name = doc.CreateElement("name");
                name.InnerText = dataGridView1.Rows[i].Cells[6].Value.ToString();// "clay";
                layer.AppendChild(name);
                XmlElement startelevation = doc.CreateElement("startelevation");
                startelevation.InnerText = dataGridView1.Rows[i].Cells[3].Value.ToString(); //"20";
                layer.AppendChild(startelevation);
                XmlElement endelevation = doc.CreateElement("endelevation");
                endelevation.InnerText = dataGridView1.Rows[i].Cells[4].Value.ToString();// "21";
                layer.AppendChild(endelevation);
                XmlElement qs = doc.CreateElement("qs");
                qs.InnerText = dataGridView1.Rows[i].Cells[8].Value.ToString();//  "21";
                layer.AppendChild(qs);
                XmlElement qu = doc.CreateElement("qu");
                qu.InnerText = dataGridView1.Rows[i].Cells[9].Value.ToString();// "21";
                layer.AppendChild(qu);
                XmlElement tcoeffient = doc.CreateElement("tcoeffient");
                tcoeffient.InnerText = dataGridView1.Rows[i].Cells[12].Value.ToString();// "1.0";
                layer.AppendChild(tcoeffient);
            }
            doc.Save(@path);
        }

        private void 显示全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Visible = true;
            }

        }

        private void 增加一行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 读入文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Title = "打开土层信息文件xml";
            openFileDialog1.Filter = "xml files(*.xml)|*.xml";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                ImportFile(path);
            }
        }

        private void 删除一行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 导出文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "xml files(*.xml)|*.xml";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportFile(saveFileDialog1.FileName);
                MessageBox.Show("保存成功");
            }
        }

        private void 简化显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;


        }


    }
}
