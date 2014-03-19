using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SvcCall {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            textBox1.Text = "John";
            textBox2.Text = "Doe";
            textBox3.Text = DateTime.Now.ToString("yyMMddHHmmssFFF");
            textBox4.Text = "01/01/1967";
            comboBox1.SelectedIndex = 1;
            textBox5.Text = DateTime.Now.ToString("yyMMddHHmmss");
            dtp_From.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e) {
            lv_ImagesOD.Visible = lv_ImagesOS.Visible = false;
            using (PCreate.HttpCreateClient client = new PCreate.HttpCreateClient()) {
                try {
                    client.CreatePatient("SCHWIND", textBox3.Text, textBox1.Text, textBox2.Text, comboBox1.SelectedIndex == 0 ? "M" : "F", DateTime.Parse(textBox4.Text));
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
                client.ScheduleProcedure(textBox3.Text, dtp_From.Value, textBox5.Text, "", textBox8.Text);
                client.AddRefraction(textBox3.Text, (float)numericUpDown1.Value, (float)numericUpDown2.Value, (int)numericUpDown3.Value,
                        txt_UcVAOD.Text, txt_BCVAOD.Text,
                        (float)numericUpDown6.Value, (float)numericUpDown5.Value, (int)numericUpDown4.Value,
                        textBox7.Text, textBox6.Text, float.Parse(textBox9.Text.Replace('.',',')), float.Parse(textBox9.Text.Replace('.',',')));
            }
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Program files\CSO\Phoenix\Phoenix.exe", string.Format("\"PatientId=\\\"{0}\\\"\"", textBox3.Text));
            Process p = Process.Start(psi);
            p.WaitForExit();
            lv_ImagesOD.Items.Clear();
            iml_ImagesOD.Images.Clear();
            lv_ImagesOS.Items.Clear();
            iml_ImagesOS.Images.Clear();
            lv_ImagesOD.Visible = lv_ImagesOS.Visible = true;
            using (PSearch.PSearchSvcClient client = new PSearch.PSearchSvcClient()) {
                PSearch.Study[] studies = client.FindStudies(textBox3.Text);
                PSearch.Study st = null;
                foreach (PSearch.Study s in studies)
                    if (s.AccessionNumber.Equals(textBox5.Text)) st = s;
                foreach (PSearch.Image image in client.FindImages(st.StudyId, null)) {
                    ListViewItem item = new ListViewItem(image.ImageId);
                    item.Tag = image;
                    Image thumbnail = Image.FromStream(client.GetImage(image.ImageId)).GetThumbnailImage(150, 113, null, IntPtr.Zero);
                    if ("OD".Equals(image.Laterality)) {
                        iml_ImagesOD.Images.Add(thumbnail);
                        lv_ImagesOD.Items.Add(item);
                        item.ImageIndex = iml_ImagesOD.Images.Count - 1;
                        if (lv_ImagesOD.SelectedItems.Count == 0) item.Selected = true;
                    }
                    else {
                        iml_ImagesOS.Images.Add(thumbnail);
                        lv_ImagesOS.Items.Add(item);
                        item.ImageIndex = iml_ImagesOS.Images.Count - 1;
                        if (lv_ImagesOS.SelectedItems.Count == 0) item.Selected = true;
                    }
                }
            }

        }

        private void lv_ImagesOS_ItemActivate(object sender, EventArgs e) {
            PSearch.Image image = ((ListView)sender).SelectedItems[0].Tag as PSearch.Image;
            Process.Start(@"C:\Program files\CSO\Phoenix\Phoenix.exe", image.Root);
        }

        private void lv_ImagesOD_ItemActivate(object sender, EventArgs e) {
            PSearch.Image image = ((ListView)sender).SelectedItems[0].Tag as PSearch.Image;
            Process.Start(@"C:\Program files\CSO\Phoenix\Phoenix.exe", image.Root);
        }
    }
}
