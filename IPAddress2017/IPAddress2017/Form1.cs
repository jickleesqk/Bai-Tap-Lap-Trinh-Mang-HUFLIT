using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace IPAddress2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxResolve.SelectedIndex = 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPHostEntry ipHostEntry = new IPHostEntry();
            if(cbxResolve.SelectedIndex == 0)               // Trường hợp chọn hostname
            {
                try
                {
                    ipHostEntry = Dns.GetHostByAddress(iputbx.Text); // Chương trình phân giải thành hostname
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else if (cbxResolve.SelectedIndex == 1)
            {
                try
                {
                    ipHostEntry = Dns.GetHostByName(iputbx.Text);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

            //In ra hostname
            try
            {
                hostbx.Text = ipHostEntry.HostName;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            //In ra aliases
            if (ipHostEntry.Aliases.Length == 0)        //nếu không có aliases
            {
                Aliasbx.Text = "Không có aliases";
            }
            else
            {
                string aliasText = "";
                foreach (string alias in ipHostEntry.Aliases)
                {
                    aliasText += alias + "\n";
                }
                Aliasbx.Text = aliasText;
            }

            //In địa chỉ IP
            string ipText = "";
            foreach (IPAddress ipAddress in ipHostEntry.AddressList)
            {
                ipText += ipAddress.ToString() + "\n";
            }
            ipbx.Text = ipText;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxResolve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
