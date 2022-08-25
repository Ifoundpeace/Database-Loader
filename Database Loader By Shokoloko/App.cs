using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Database_Loader_By_Shokoloko
{
    public partial class DatabaseLoader : Form
    {
        List<List<string>> Identities = new List<List<string>>();
        List<string> Keywords = new List<string>();
        string Seperator;
        Thread SearchProcess;
        public DatabaseLoader()
        {
            InitializeComponent();
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
            }

            #region watcher

            this.BuildDirWatcher();

            #endregion watcher

            if (Directory.GetFiles("data").Length == 0)
            {
                Console.WriteLine("Add databases to the data folder");
            }
            foreach (string file in Directory.GetFiles("data"))
            {
                this.DatabaseSelectMenu.Items.Add(file.Split(new char[] { '\\', '/' }, StringSplitOptions.None).Last());
            }
            if (this.DatabaseSelectMenu.Items.Count > 0)
            {
                this.DatabaseSelectMenu.SelectedIndex = 0;
            }
            this.Seperator = this.SeperatorTxtBox.Text;
        }
        private void BuildDirWatcher()
        {
            // Another problem to fix: I need to detect when someone renames the data folder and rename it back to "data"
            FileSystemWatcher watcher = new FileSystemWatcher($"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}\\data");
            watcher.NotifyFilter = NotifyFilters.Attributes
                                    | NotifyFilters.CreationTime
                                    | NotifyFilters.DirectoryName
                                    | NotifyFilters.FileName
                                    | NotifyFilters.LastAccess
                                    | NotifyFilters.LastWrite
                                    | NotifyFilters.Security
                                    | NotifyFilters.Size;

            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
            watcher.Created += ((a, b) => ReloadDatabasesBtn_Click(new object { }, new EventArgs()));
            watcher.Changed += ((a, b) => ReloadDatabasesBtn_Click(new object { }, new EventArgs()));
            watcher.Deleted += ((a, b) => ReloadDatabasesBtn_Click(new object { }, new EventArgs()));
            watcher.Renamed += ((a, b) => {
                if (Directory.Exists(b.FullPath) && b.FullPath == watcher.Path)
                {
                    Thread.Sleep(200);
                    Directory.Move(b.FullPath, b.OldFullPath);
                }
                else
                {
                    ReloadDatabasesBtn_Click(new object { }, new EventArgs());
                }
            });
            watcher.Error += ((a, b) =>
            {
                // I did it cuz the latency of creating / updating directories... very weird, if you have any solution please make a pull
                // If you have any other solution instead of this shitty recursion make a pull
                Thread.Sleep(800);
                var spin = new ConsoleSpinner();
                Console.WriteLine("Creating new data folder...");
                while (!Directory.Exists(watcher.Path))
                {
                    Directory.CreateDirectory(watcher.Path);
                    spin.Turn();
                }
                Console.SetCursorPosition(Console.WindowLeft, Console.CursorTop);
                Console.WriteLine("Created data folder");
                Thread.Sleep(200);
                BuildDirWatcher();
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            this.Keywords = this.KeywordsTxtBox.Text.Split('\n').Select(x => x.Trim()).Where(x => x != String.Empty && x != Environment.NewLine).ToList();
            if (this.Keywords.Count == 0)
            {
                MessageBox.Show("You are not using any keywords, insert your keywords.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (this.Identities.Count == 0)
            {
                MessageBox.Show("You didn't load any database.", "Error", MessageBoxButtons.OK);
                return;
            }
            this.SearchBtn.Enabled = false;
            this.StopSearchBtn.Enabled = true;
            this.SearchProcess = new Thread(new ThreadStart(() =>
            {
                new Task(() =>
                {
                    var spin = new ConsoleSpinner();
                    Console.Write("Searching....");
                    while (true)
                    {
                        spin.Turn();
                    }
                }).Start();
                List<List<string>> FoundIdentities;
                if(this.ExactResultsCheckBox.Checked)
                {
                    FoundIdentities = this.Identities.Where(x => this.Keywords.All(y => x.Any(z => z == y))).ToList();
                }
                else
                {
                    FoundIdentities = this.Identities.Where(x => this.Keywords.All(y => x.Any(z => z.Contains(y)))).ToList();
                }

                Console.SetCursorPosition(Console.WindowLeft, Console.CursorTop);
                Console.WriteLine($"Found {FoundIdentities.Count} results.");

                this.StopSearchBtn.Enabled = false;
                this.SearchBtn.Enabled = true;
                this.SearchProcess = null;

                if (FoundIdentities.Count == 0)
                {
                    MessageBox.Show("Found 0 matches.", "Error", MessageBoxButtons.OK);
                    return;
                }
                
                this.ResultsTxtBox.Text += String.Join(Environment.NewLine, FoundIdentities.Select(x => String.Join(", ", x))) + Environment.NewLine;
                

            }));
            this.SearchProcess.Start();
        }

        private void StopSearchBtn_Click(object sender, EventArgs e)
        {
            Console.SetCursorPosition(Console.WindowLeft, Console.CursorTop);
            Console.WriteLine("Stopping the search...");
            try
            {
                this.SearchProcess?.Abort();
            }
            catch
            {

            }
            this.SearchProcess = null;
            this.StopSearchBtn.Enabled = false;
            this.SearchBtn.Enabled = true;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.ResultsTxtBox.Text = String.Empty;
            this.ClearBtn.Enabled = false;
        }

        private void LoadDatabaseBtn_Click(object sender, EventArgs e)
        {
            if (DatabaseSelectMenu.Text == String.Empty)
            {
                MessageBox.Show("No database selected.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (this.SeperatorTxtBox.Text == String.Empty)
            {
                this.SeperatorTxtBox.Text = ":";
            }
            
            this.Seperator = this.SeperatorTxtBox.Text;

            Console.WriteLine($"Loading database - {DatabaseSelectMenu.Text}");
            this.LoadDatabaseBtn.Enabled = false;
            this.SeperatorTxtBox.Enabled = false;
            new Thread(new ThreadStart(() =>
            {
                try
                {
                    new Task(() =>
                    {
                        var spin = new ConsoleSpinner();
                        Console.Write("Loading....");
                        while (true)
                        {
                            spin.Turn();
                        }
                    }).Start();
                    this.Identities.Clear();
                    using (FileStream fs = File.Open($"data/{DatabaseSelectMenu.Text}", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (BufferedStream bs = new BufferedStream(fs))
                    
                    using (StreamReader sr = new StreamReader(bs))
                    {
                        this.Identities = sr.ReadToEnd().Split('\n').Select(x => x.Trim().Split(this.Seperator.ToCharArray()).Where(y => y != String.Empty && y != "\r").ToList()).ToList();
                    }
                    if (this.Identities.Count == 0)
                    {
                        Console.WriteLine("Load your database");
                    }
                    Console.SetCursorPosition(Console.WindowLeft, Console.CursorTop);
                    Console.WriteLine($"Loaded database - {DatabaseSelectMenu.Text} with {this.Identities.Count} lines");
                    this.LoadDatabaseBtn.Enabled = true;
                    this.SeperatorTxtBox.Enabled = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            })).Start();
        }

        private void ReloadDatabasesBtn_Click(object sender, EventArgs e)
        {
            this.DatabaseSelectMenu.Items.Clear();
            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
            }
            foreach (string file in Directory.GetFiles("data", "*", SearchOption.AllDirectories))
            {
                this.DatabaseSelectMenu.Items.Add(file.Split(new char[] { '\\', '/' }, StringSplitOptions.None).Last());
            }
            if (this.DatabaseSelectMenu.Items.Count > 0)
            {
                this.DatabaseSelectMenu.SelectedIndex = 0;
            }
        }
        private void KeywordsTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                try
                {
                    Clipboard.SetText(Clipboard.GetText().Replace("\r", "").Replace("\n", Environment.NewLine));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void ResultsTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (this.ResultsTxtBox.Text.Length > 0)
            {
                this.ClearBtn.Enabled = true;
            }
        }
    }
}
