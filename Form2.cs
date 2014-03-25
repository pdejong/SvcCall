using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SiriusSVCcall.SvcCreate;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;

namespace SiriusSVCcall {
    public partial class Form2 : Form {
        private string m_Phoenix;
        public Form2() {
            InitializeComponent();
        }

        private void btn_Patient_Click(object sender, EventArgs e) {
            create_send.Enabled = false;
            if (string.IsNullOrEmpty(create_ID.Text)) {
                create_ID.Text = "PID" + DateTime.Now.ToString("HHmmss");
                create_FN.Text = "John";
                create_LN.Text = "Doe";
                cmb_Gender.SelectedIndex = 0;
                create_dateTimePicker.Value = DateTime.Parse("1967-04-01");
                create_send.Enabled = true;
                txt_Comment.Text = "Comment";
                txt_AccessionNumber.Text = "AN" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
            else {
                create_ID.Clear();
                create_FN.Clear();
                create_LN.Clear();
                create_dateTimePicker.Value = DateTime.Parse("2012-12-31");
                txt_Age.Clear();
                txt_Comment.Clear();
                txt_AccessionNumber.Clear();
            }
        }

        private void create_dateTimePicker_ValueChanged(object sender, EventArgs e) {
            txt_Age.Text = (DateTime.Now.Year - create_dateTimePicker.Value.Year).ToString();
        }

        private void btn_Refraction_Click(object sender, EventArgs e) {
            if (refraction_OD_Sph.Value == 0) {
                refraction_OD_Sph.Value = (decimal)-3;
                refraction_OD_Cyl.Value = 0;
                refraction_OD_ax.Value = 0;
                refraction_OD_CVD.Value = (decimal)12.5;
                refraction_OS_Sph.Value = (decimal)-2.5;
                refraction_OS_Cyl.Value = 0;
                refraction_OS_ax.Value = 0;
                refraction_OS_CVD.Value = (decimal)12.5;
            }
            else {
                refraction_OD_Sph.Value = 0;
                refraction_OD_Cyl.Value = 0;
                refraction_OD_ax.Value = 0;
                refraction_OD_CVD.Value = 0;
                refraction_OS_Sph.Value = 0;
                refraction_OS_Cyl.Value = 0;
                refraction_OS_ax.Value = 0;
                refraction_OS_CVD.Value = 0;
            }
        }

        private void create_send_Click(object sender, EventArgs e) {
            HttpCreateClient client = Program.Create;
            try {
                client.CreatePatient(create_PMSid.Text, create_ID.Text, create_FN.Text, create_LN.Text, cmb_Gender.SelectedIndex == 0 ? "M" : "F", create_dateTimePicker.Value);
            }
            catch { // patient exists..
            }
            client.ScheduleProcedure(create_ID.Text, DateTime.Now, txt_AccessionNumber.Text, "");
            // you might want to insert other checks on validity of the refractive data...
            if (refraction_OD_Sph.Value != 0) {
                client.AddRefraction(create_ID.Text, (float)refraction_OD_Sph.Value, (float)refraction_OD_Cyl.Value, (int)refraction_OD_ax.Value, refraction_OD_UcVA.Text, refraction_OS_BCVA.Text,
                                                     (float)refraction_OS_Sph.Value, (float)refraction_OS_Cyl.Value, (int)refraction_OS_ax.Value, refraction_OD_UcVA.Text, refraction_OS_BCVA.Text,
                                                     (float)refraction_OD_CVD.Value, (float)refraction_OS_CVD.Value);
            }
            if(chk_RestartPhoenix.Checked && File.Exists(m_Phoenix)) {
                Process[] procs = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(m_Phoenix));
                if (procs.Length == 1) {
                    procs[0].Kill();
                }
                Process.Start(m_Phoenix, cmb_Args.SelectedIndex == 1 ? string.Format("\"AccessionNumber=\\\"{0}\\\"\"", txt_AccessionNumber.Text) : string.Format("\"PatientId=\\\"{0}\\\"\"", create_ID.Text));
            }

        }

        private void Form2_Load(object sender, EventArgs e) {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\CSO\Phoenix", RegistryKeyPermissionCheck.ReadSubTree, System.Security.AccessControl.RegistryRights.ReadKey);
            if (key != null)
                try {
                    string ID = key.GetValue("InstallDir").ToString();
                    string Executable = key.GetValue("Executable").ToString();
                    m_Phoenix = Path.Combine(ID, Executable + ".exe");
                }
                catch (Exception ex) { }
            if (!File.Exists(m_Phoenix)) {
                string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
                if (File.Exists(location = Path.Combine(Path.GetDirectoryName(location), "Phoenix.exe")))
                    m_Phoenix = location;
                else {
                    MessageBox.Show(this, "Phoenix not found!");
                }
            }
            chk_RestartPhoenix.Enabled = File.Exists(m_Phoenix);
            if (!chk_RestartPhoenix.Enabled) chk_RestartPhoenix.Checked = false;
        }

        private void chk_RestartPhoenix_CheckedChanged(object sender, EventArgs e) {
            cmb_Args.Enabled = chk_RestartPhoenix.Checked;
        }
    }
}
