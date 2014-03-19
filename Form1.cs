using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SiriusSVCcall.SvcCreate;
using SiriusSVCcall.SvcSearch;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] CommandLineArgs;

        public Form1()
        {
            InitializeComponent();
           // if (args.Length == 0) { richTextBox_msg.Text = "aa"; }

            CommandLineArgs = Environment.GetCommandLineArgs();


            if (CommandLineArgs.Length > 1) // the 0th element is the exe name
            {
                //richTextBox_msg.AppendText("Number of Arguments:" + CommandLineArgs.Length.ToString() + "\n");
                //for (int i = 1; i < CommandLineArgs.Length; i++)
                //{
                //    richTextBox_msg.AppendText(i.ToString() + ": " + CommandLineArgs[i].ToString() + "\n");
                //}


                if (CommandLineArgs[1].ToString() == "create")
                {
                    groupBox_refration.Visible = false;
                    groupBox_schedule.Visible = false;
                    
                    

                    if ((CommandLineArgs.Length < 7) | (CommandLineArgs.Length > 8) )
                    {
                        richTextBox_msg.AppendText("Create- invalid number of arguments\n");
                        //this.WindowState = FormWindowState.Normal;
                        return;
                    }


                    if ((CommandLineArgs[6].ToString() != "F") && (CommandLineArgs[6].ToString() != "M")) 
                    {
                        richTextBox_msg.AppendText("Create- gender error\n");
                        //this.WindowState = FormWindowState.Normal;
                        return;                        
                    }
                  

                    create_ID.Text = CommandLineArgs[2].ToString();
                    create_FN.Text = CommandLineArgs[3].ToString();
                    create_LN.Text = CommandLineArgs[4].ToString();
                    create_gender.Text = CommandLineArgs[6].ToString();
                    try { create_dateTimePicker.Value = DateTime.ParseExact(CommandLineArgs[5], "yyyyMMdd", null); }
                    catch (Exception)
                    {
                        create_send.Visible = false;
                        schedule_send.Visible = false;
                        refraction_send.Visible = false;
                        richTextBox_msg.AppendText("Create- DOB Error\n");
                        //this.WindowState = FormWindowState.Normal;
                        return;  
                    }


                    // Now Send to Sirius
                    if (CommandLineArgs.Length == 8)
                    {
                        if (CommandLineArgs[7].ToString() == "debug") { this.WindowState = FormWindowState.Normal; }
                    }
                    else
                    {
                        //create_send.PerformClick();
                        btn_Create_Click(null, null);
                        timer_exitApp.Enabled = true; 
                      //  if (richTextBox_msg.Text == "Create OK")
                      //  {
                      //      //this.WindowState = FormWindowState.Normal;
                       //     timer_exitApp.Enabled = true;                               

                      //  }
                        //  else
                       // {
                      //      this.WindowState = FormWindowState.Normal;
                       //     return;  
                        //  }

                        
                    }
                    
                }
                else








                if (CommandLineArgs[1].ToString() == "schedule")
                {
                    groupBox_refration.Visible = false;
                    groupBox_create.Visible = false;


                    if ((CommandLineArgs.Length < 6) | (CommandLineArgs.Length > 7))
                    {
                        richTextBox_msg.AppendText("Schedule- invalid number of arguments\n");
                        //this.WindowState = FormWindowState.Normal;
                        return;
                    }



                    schedule_ID.Text = CommandLineArgs[2].ToString();
                    schedule_AccessionNumber.Text = CommandLineArgs[3].ToString();
                    schedule_physician.Text = CommandLineArgs[5].ToString();
                    

                    try { schedule_date.Value = DateTime.ParseExact(CommandLineArgs[4], "yyyyMMddHHmm", null); }
                    catch (Exception)
                    {
                        create_send.Visible = false;
                        schedule_send.Visible = false;
                        refraction_send.Visible = false;
                        richTextBox_msg.AppendText("Schedule- Date Error\n");
                        //this.WindowState = FormWindowState.Normal;
                        return;
                    }




                    // Now Send to Sirius
                    if (CommandLineArgs.Length == 7)
                    {
                        if (CommandLineArgs[6].ToString() == "debug") { this.WindowState = FormWindowState.Normal; }
                    }
                    else
                    {
                        //create_send.PerformClick();
                        schedule_send_Click(null, null);
                        
                        timer_exitApp.Enabled = true;
                        //  if (richTextBox_msg.Text == "Schedule OK")
                        //  {
                        //      //this.WindowState = FormWindowState.Normal;
                        //     timer_exitApp.Enabled = true;                               

                        //  }
                        //  else
                        // {
                        //      this.WindowState = FormWindowState.Normal;
                        //     return;  
                        //  }
                    

                    }




                }
                else
                if (CommandLineArgs[1].ToString() == "refraction")
                {
                    groupBox_create.Visible = false;
                    groupBox_schedule.Visible = false;


                    //[PatID] [OD_Sph] [OD_Cyl] [OD_Ax] [OD_UcVA] [OD_BCVA] [OS_CVD] [OS_Sph] [OS_Cyl] [OS_Ax] [OS_UcVA] [OS_BCVA] [OS_CVD]

                    if ((CommandLineArgs.Length < 15) | (CommandLineArgs.Length > 16))
                    {
                        richTextBox_msg.AppendText("Refraction- invalid number of arguments\n");
                        //this.WindowState = FormWindowState.Normal;
                        return;
                    }

                    refraction_ID.Text = CommandLineArgs[2].ToString();
                    refraction_OD_UcVA.Text = CommandLineArgs[6].ToString();
                    refraction_OS_UcVA.Text = CommandLineArgs[12].ToString();
                    refraction_OD_BCVA.Text = CommandLineArgs[7].ToString();
                    refraction_OS_BCVA.Text = CommandLineArgs[13].ToString();

                    try
                    {
                        refraction_OD_Sph.Value = Convert.ToDecimal(CommandLineArgs[3].ToString());
                        refraction_OD_Cyl.Value = Convert.ToDecimal(CommandLineArgs[4].ToString());
                        refraction_OD_ax.Value = Convert.ToDecimal(CommandLineArgs[5].ToString());
                        refraction_OD_CVD.Value = Convert.ToDecimal(CommandLineArgs[8].ToString());
                        refraction_OS_Sph.Value = Convert.ToDecimal(CommandLineArgs[9].ToString());
                        refraction_OS_Cyl.Value = Convert.ToDecimal(CommandLineArgs[10].ToString());
                        refraction_OS_ax.Value = Convert.ToDecimal(CommandLineArgs[11].ToString());
                        refraction_OS_CVD.Value = Convert.ToDecimal(CommandLineArgs[14].ToString());
                    }
                    catch (Exception)
                    {
                        create_send.Visible = false;
                        schedule_send.Visible = false;
                        refraction_send.Visible = false;
                        richTextBox_msg.AppendText("Refraction- Value Conversion Error\n");
                        //this.WindowState = FormWindowState.Normal;
                        return;
                    }




                     // Now Send to Sirius
                    if (CommandLineArgs.Length == 16)
                    {
                        if (CommandLineArgs[15].ToString() == "debug") { this.WindowState = FormWindowState.Normal; }
                    }
                    else
                    {
                        //create_send.PerformClick();
                        refraction_send_Click(null, null);

                        timer_exitApp.Enabled = true;
                        //  if (richTextBox_msg.Text == "Refraction OK")
                        //  {
                        //      //this.WindowState = FormWindowState.Normal;
                        //     timer_exitApp.Enabled = true;                               

                        //  }
                        //  else
                        // {
                        //      this.WindowState = FormWindowState.Normal;
                        //     return;  
                        //  }

                    }


                }

                else
                if (CommandLineArgs[1].ToString() == "launch") 
                {
                    RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\CSO\Phoenix", RegistryKeyPermissionCheck.ReadSubTree, System.Security.AccessControl.RegistryRights.ReadKey);
                    string phoenix = null;
                    if (key != null)
                        try {
                            string ID = key.GetValue("InstallDir").ToString();
                            string Executable = key.GetValue("Executable").ToString();
                            phoenix = Path.Combine(ID, Executable + ".exe");
                        }
                        catch (Exception ex) { }
                    if (!File.Exists(phoenix)) {
                        //if (args.Length > 1 && File.Exists(args[0])) m_Executable = args[1];
                        //else {
                        string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
                        if (File.Exists(location = Path.Combine(Path.GetDirectoryName(location), "Phoenix.exe")))
                            phoenix = location;
                    }
                    if ((CommandLineArgs.Length < 3)) 
                    {
                        richTextBox_msg.AppendText("Launch- invalid number of arguments\n");
                        //this.WindowState = FormWindowState.Normal;
                        return;
                    }

                    if (CommandLineArgs[2].ToString() == "PatientId") 
                    {
                        Process.Start(phoenix, string.Format("{0}=\\\"{1}\\\"", CommandLineArgs[2], CommandLineArgs[3]));
                    }
                    else
                    if (CommandLineArgs[2].ToString() == "StudyId") 
                    {
                        Process.Start(phoenix, string.Format("{0}=\\\"{1}\\\"", CommandLineArgs[2], CommandLineArgs[3]));
                    }
                    else
                    if (CommandLineArgs[2].ToString() == "AccessionNumber") 
                    {
                        Process.Start(phoenix, string.Format("{0}=\\\"{1}\\\"", CommandLineArgs[2], CommandLineArgs[3]));
                    }


                }
                else {
                        richTextBox_msg.AppendText("-> Argument(1) error!\n");
                        this.WindowState = FormWindowState.Normal; // show window
                    }                

            }
            else
            {
                richTextBox_msg.AppendText("No arguments defined -> Manual mode\n");
                richTextBox_msg.AppendText("Arguments:\n");
                richTextBox_msg.AppendText("  create [PatID] [FN] [LN] [DOB in form of yyyymmdd] [Gender: M|F]\n");
                richTextBox_msg.AppendText("  schedule [PatID] [Accession Number] [yyyymmddhhmm] [physicianName]\n");
                richTextBox_msg.AppendText("  refraction [PatID] [OD_Sph] [OD_Cyl] [OD_Ax] [OD_UcVA] [OD_BCVA] [OS_CVD] [OS_Sph] [OS_Cyl] [OS_Ax] [OS_UcVA] [OS_BCVA] [OS_CVD]\n");
                richTextBox_msg.AppendText("  launch PatientId [PatID]\n");
                richTextBox_msg.AppendText("  launch AccessionNumber [PatID]\n");
                richTextBox_msg.AppendText("As an option, the last argument may be: -debug- to display window instead of doing the action immediately.\n");
                this.WindowState = FormWindowState.Normal; // show window
            }

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            using (HttpCreateClient client = new HttpCreateClient())
            {
                            
                try
                {
                    client.CreatePatient(create_PMSid.Text, create_ID.Text, create_FN.Text, create_LN.Text, create_gender.Text, create_dateTimePicker.Value);
                    richTextBox_msg.Text = "Create OK";
                }
                catch (Exception ex)
                    {
                        create_send.Visible = false;
                        schedule_send.Visible = false;
                        refraction_send.Visible = false;    
                        richTextBox_msg.AppendText("Create- Send Error\n");
                        richTextBox_msg.Text = ex.Message;
                    }                
            }
        }

        private void schedule_send_Click(object sender, EventArgs e)
        {
            using (HttpCreateClient client = new HttpCreateClient())
            {
                try
                {
                    client.ScheduleProcedure(schedule_ID.Text, schedule_date.Value, schedule_AccessionNumber.Text, schedule_physician.Text);
                    richTextBox_msg.Text = "Schedule OK";
                }
                catch (Exception ex)
                {
                    create_send.Visible = false;
                    schedule_send.Visible = false;
                    refraction_send.Visible = false;
                    richTextBox_msg.AppendText("Schedule- Send Error\n");
                    richTextBox_msg.Text = ex.Message;
                }
            }
        }

        private void refraction_send_Click(object sender, EventArgs e)
        {
            using (HttpCreateClient client = new HttpCreateClient())
            {
                try
                {
                    client.AddRefraction(refraction_ID.Text,
                        (float)refraction_OD_Sph.Value, (float)refraction_OD_Cyl.Value, (int)refraction_OD_ax.Value,
                        refraction_OD_UcVA.Text, refraction_OD_BCVA.Text,
                        (float)refraction_OS_Sph.Value, (float)refraction_OS_Cyl.Value, (int)refraction_OS_ax.Value,
                        refraction_OS_UcVA.Text, refraction_OS_BCVA.Text,
                        (float)refraction_OD_CVD.Value, (float)refraction_OS_CVD.Value);
                    richTextBox_msg.Text = "Refraction OK";
                }
                catch (Exception ex)
                {
                    create_send.Visible = false;
                    schedule_send.Visible = false;
                    refraction_send.Visible = false;
                    richTextBox_msg.AppendText("Refraction- Send Error\n");
                    richTextBox_msg.Text = ex.Message;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer_exitApp_Tick(null, null);


            

        }

        private void timer_exitApp_Tick(object sender, EventArgs e)
        {
            this.Enabled = false;
            Console.WriteLine(richTextBox_msg.Text); // output error message to console (if the program was called by console)
            if ((richTextBox_msg.Text == "Create OK") | (richTextBox_msg.Text == "Refraction OK") | (richTextBox_msg.Text == "Schedule OK"))
            {
                Environment.Exit(0);  // exit, sucessfully result
            }
            else
            {
                Environment.Exit(1); // error has happend
            }
        }


    }
}
