using System.Diagnostics;
using System.Windows.Forms;

namespace EspressifBacktraceDecoder
{
    public partial class MainWindow : Form
    {
        string? idfPath;
        string? addr2LinePath = Path.Combine("tools", "xtensa-esp-elf", "esp-13.2.0_20230928", "xtensa-esp-elf", "bin", "xtensa-esp32-elf-addr2line.exe");
        string? fwPath;

        public MainWindow()
        {
            InitializeComponent();

            bool ifToolOk = CheckAddr2Line();
            if (ifToolOk)
            {
                labelAddr2LinePath.Text = "Path: " + addr2LinePath;
            }

            if (Properties.Settings.Default.LastFwPath != null)
            {
                fwPath = Properties.Settings.Default.LastFwPath;
                labelFwPath.Text = fwPath;
            }
        }

        private bool CheckAddr2Line()
        {
            bool _ok = false;
            if (string.IsNullOrEmpty(Properties.Settings.Default.Addr2LinePath))
            {
                string? _env = Environment.GetEnvironmentVariable("IDF_TOOLS_PATH");

                if (string.IsNullOrEmpty(_env))
                {
                    DialogResult result = MessageBox.Show("\"IDF_TOOLS_PATH\" not found \rDo you want to choose ESP-IDF tool folder manually?",
                                       "Missing tool",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Error,
                                       MessageBoxDefaultButton.Button1);


                    if (result == DialogResult.Yes)
                    {
                        using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                        {
                            fbd.Description = "Select folder where is ESP-IDF installed.";
                            fbd.InitialDirectory = "c:\\";

                            if (fbd.ShowDialog() == DialogResult.OK)
                            {
                                _env = fbd.SelectedPath;

                                if (File.Exists(Path.Combine(_env, addr2LinePath)))
                                {
                                    addr2LinePath = Path.Combine(_env, addr2LinePath);
                                    _ok = true;
                                }
                                else
                                {
                                    MessageBox.Show("\"xtensa-esp32-elf-addr2line.exe\" not found \rPlease reinstall ESP-IDF", "Missing tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    _ok = false;
                                }
                            }
                            else
                            {
                                //Cancel folder browse
                                _ok = false;
                            }
                        }
                    }
                    else
                    {
                        // If user clickt No
                        _ok = false;
                    }
                }
                else
                {
                    // When ENV Variable found 

                    if (File.Exists(Path.Combine(_env, addr2LinePath)))
                    {
                        addr2LinePath = Path.Combine(_env, addr2LinePath);
                    }
                }
            }
            else
            {
                addr2LinePath = Properties.Settings.Default.Addr2LinePath;
                _ok = true;
            }

            Properties.Settings.Default.Addr2LinePath = addr2LinePath;
            Properties.Settings.Default.Save();
            labelAddr2LinePath.Text = "Path: " + addr2LinePath;
            return _ok;
        }

        private void buttonSelectFw_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "ELF files (*.elf)|*.elf";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    fwPath = openFileDialog.FileName;
                }
            }

            labelFwPath.Text = fwPath;
            Properties.Settings.Default.LastFwPath = fwPath;
            Properties.Settings.Default.Save();
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length == 0)
            {
                MessageBox.Show("Please enter encoded backtrace into the text box.", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(fwPath))
            {
                MessageBox.Show("Please select a firmware.elf", "No firmware", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Start the child process.
            Process p = new Process();

            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.FileName = addr2LinePath;
            p.StartInfo.Arguments = $" -pfiaC -e {fwPath} {textBoxInput.Text}";
            p.Start();

            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            richTextBoxOutput.Text = output;
            p.WaitForExit();
        }
    }
}
