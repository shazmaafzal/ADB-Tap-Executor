using SharpAdbClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emulate
{
    public partial class Emulator : Form
    {
        public Emulator()
        {
            InitializeComponent();
        }

        private void btnEmulateTouch_Click(object sender, EventArgs e)
        {
            var client = new AdbClient();
            var device = client.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();

            client.ExecuteRemoteCommand($"input tap {txtX.Text} {txtY.Text}", device, receiver);

            Console.WriteLine(receiver.ToString());
        }

        private void btnInitAdb_Click(object sender, EventArgs e)
        {
            AdbServer server = new AdbServer();
            StartServerResult result = server.StartServer(this.txtAdbPath.Text, restartServerIfNewer: false);
            MessageBox.Show(result.ToString());
        }
    }
}
