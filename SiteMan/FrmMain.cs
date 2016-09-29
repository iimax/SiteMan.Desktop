using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteMan
{
    public partial class FrmMain : Form
    {
        private List<Site> employees = new List<Site>();
        //private Dictionary<string, SiteState> Requests = new Dictionary<string, SiteState>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.PopulateLists();
            this.dgSites.AutoGenerateColumns = false;
            this.dgSites.DataSource = this.employees;
        }

        private void PopulateLists()
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "data.xml"))
            {
                Data data = new Data();
                this.employees = data.List(AppDomain.CurrentDomain.BaseDirectory);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dataGridViewRow in this.dgSites.Rows)
            {
                if (!(dataGridViewRow.Cells["colType"].Value.ToString() == "CG"))
                {
                    if (!(dataGridViewRow.Cells["colStatus"].Value.ToString() == "STOP"))
                    {
                        try
                        {
                            string text = dataGridViewRow.Cells["colUrl"].Value.ToString();
                            HttpClient http = new HttpClient();
                            //http.ResponseEncoding = Encoding.GetEncoding("GB2312");
                            this.SetStatus(string.Format("GET {0}", text));
                            //string text2 = http.GetStringAsync(text);
                            //if (text2.Contains("FRAMESET"))
                            //{
                            //    text = http.ExtractHtml(text2, "src=\"", "\"");
                            //    if (string.IsNullOrEmpty(text))
                            //    {
                            //        dataGridViewRow.Cells["colResult"].Value = "frame src not found.";
                            //        continue;
                            //    }
                            //    if (!text.EndsWith("/"))
                            //    {
                            //        text += "/";
                            //    }
                            //    dataGridViewRow.Cells["colUrl"].Value = text;
                            //    text2 = http.GET(text);
                            //}
                            //if (!text2.Contains("vcode.php"))
                            //{
                            //    dataGridViewRow.Cells["colResult"].Value = "vcode not found.";
                            //}
                            //else
                            //{
                            //    Stream stream = http.DownloadStream(string.Format("{0}vcode.php", text));
                            //    DataGridViewImageCell dataGridViewImageCell = dataGridViewRow.Cells["colVCode"] as DataGridViewImageCell;
                            //    if (dataGridViewImageCell == null)
                            //    {
                            //        dataGridViewRow.Cells["colResult"].Value = "Unable to find VCode cell.";
                            //    }
                            //    else
                            //    {
                            //        dataGridViewImageCell.Value = Image.FromStream(stream);
                            //        stream.Dispose();
                            //        SiteState siteState = new SiteState();
                            //        siteState.http = http;
                            //        this.Requests.Add(text, siteState);
                            //        Thread.Sleep(1000);
                            //    }
                            //}
                        }
                        catch (Exception)
                        {
                            dataGridViewRow.Cells["colResult"].Value = "ERROR";
                        }
                    }
                }
            }
        }



        private void SetStatus(string status)
        {
            this.lblStatus.Text = status;
            this.lblStatus.Invalidate();
            Application.DoEvents();
        }
    }
}
