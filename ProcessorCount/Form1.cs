using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ProcessorCount
{
    public partial class SysFormInfo : Form
    {
        public SysFormInfo()
        {
            InitializeComponent();
        }

        private void SysInfo_Click(object sender, EventArgs e)
        {
            infoTextBox.Text = "";
            infoTextBox.Text += "Number of CPUs: " + System.Environment.ProcessorCount + Environment.NewLine;
            infoTextBox.Text += "Is this process is 64-bit: " + System.Environment.Is64BitProcess + Environment.NewLine;
            infoTextBox.Text += "Is this OS is 64-bit: " + System.Environment.Is64BitOperatingSystem + Environment.NewLine;
            infoTextBox.Text += "OS version: " + System.Environment.OSVersion + Environment.NewLine;
            infoTextBox.Text += "NetBIOS name of this machine: " + System.Environment.MachineName + Environment.NewLine;
            infoTextBox.Text += "Pagefile size: " + System.Environment.SystemPageSize + Environment.NewLine;
            infoTextBox.Text += "User Domain name: " + System.Environment.UserDomainName + Environment.NewLine;
            infoTextBox.Text += "User Name: " + System.Environment.UserName + Environment.NewLine + 
                "==========================================" + Environment.NewLine;

            PerformanceCounter ramFree = new PerformanceCounter("Memory", "Available MBytes");
            infoTextBox.Text += "Free RAM: " + ramFree.NextValue() + " MB" + Environment.NewLine;

            ulong TotalRam = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;

            infoTextBox.Text += "Total RAM: " + TotalRam / (1024 * 1024) + " MB" + Environment.NewLine + 
                "==========================================" + Environment.NewLine;

            infoTextBox.Text += "Drives INFO:" + Environment.NewLine + Environment.NewLine;

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                infoTextBox.Text += "Drive " + d.Name + Environment.NewLine;
                infoTextBox.Text += "Drive type: " + d.DriveType + Environment.NewLine;
                if (d.IsReady == true)
                {
                    infoTextBox.Text += ">>  Volume label: " + d.VolumeLabel + Environment.NewLine;
                    infoTextBox.Text += ">>  File system: " + d.DriveFormat + Environment.NewLine;
                    infoTextBox.Text += 
                        ">>  Available space to current user: " +
                        d.AvailableFreeSpace + " bytes (" + d.AvailableFreeSpace/(1024*1024) + " Mb, " + 
                        d.AvailableFreeSpace/(1024*1024*1024) + " Gb)" + Environment.NewLine;

                    infoTextBox.Text += 
                        ">>  Total available space: " +
                        d.TotalFreeSpace + " bytes (" + d.TotalFreeSpace/(1024*1024) + " Mb, " + 
                        d.TotalFreeSpace/(1024*1024*1024) + " Gb)" + Environment.NewLine;

                    infoTextBox.Text += 
                        ">>  Total size of drive: " +
                        d.TotalSize + " bytes (" + d.TotalSize / (1024 * 1024) + " Mb, " + 
                        d.TotalSize / (1024 * 1024 * 1024) + " Gb)" + Environment.NewLine + Environment.NewLine;
                }
            }

        }
    }
}
