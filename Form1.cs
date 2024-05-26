using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WutheringWavesFPSUnlocker
{
    public partial class WWFpsUnlocker : Form
    {
        internal SQLiteConnection connection;
        internal GameConfig gameConfig;
        internal Config config;
        internal string configPath = "config.json";
        public WWFpsUnlocker()
        {
            InitializeComponent();
            LoadConfig();
            LoadWWConfig();
        }

        internal void UpdateSlider()
        {
            fpsHsb.Value = gameConfig.KeyCustomFrameRate;
            fpsLbl.Text = $"FPS: {gameConfig.KeyCustomFrameRate}";
        }

        internal void PromtSelectGameFolder()
        {
            MessageBox.Show("Select Wuthering Waves executable file", "Info");
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var actualPath = dialog.FileName;
                if (dialog.FileName.EndsWith(".exe"))
                {
                    var arr = dialog.FileName.Split('\\');
                    actualPath = dialog.FileName.Replace($"{arr[arr.Length - 1]}", "");
                }
                config.gamePath = actualPath;
                MessageBox.Show($"Updated path to Wuthering Waves:\n{config.gamePath}", "Info");
                SaveConfig();
            }
        }

        internal void SaveConfig()
        {
            File.WriteAllText(configPath, JsonConvert.SerializeObject(config));
            gamePathlbl.Text = $"Game folder:\n{config.gamePath}";
        }

        internal void LoadConfig()
        {
            if (!File.Exists(configPath) || string.IsNullOrEmpty(File.ReadAllText(configPath)))
            {
                File.Create(configPath).Close();
            }
            config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(configPath));
            if (config == null)
            {
                config = new Config();
                PromtSelectGameFolder();
            }
            else
            {
                gamePathlbl.Text = $"Game folder:\n{config.gamePath}";
            }
        }

        internal void SaveWWConfig()
        {
            try
            {
                var configStr = JsonConvert.SerializeObject(gameConfig);
                var text = $"UPDATE LocalStorage SET 'value' = '{configStr}' where key = 'GameQualitySetting'";
                var sqliteCommand = new SQLiteCommand(text, connection);
                sqliteCommand.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Error saving config: {exc.Message}", "Error");
            }
        }
        internal void LoadWWConfig()
        {
            try
            {
                var path = $"{config.gamePath}\\Client\\Saved\\LocalStorage\\LocalStorage.db";
                connection = new SQLiteConnection($"Data Source={path};Version=3;");
                connection.Open();
                string text = "SELECT value FROM LocalStorage WHERE key = 'GameQualitySetting'";
                SQLiteCommand sqliteCommand = new SQLiteCommand(text, connection);
                using (SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader())
                {
                    sqliteDataReader.Read();

                    gameConfig = JsonConvert.DeserializeObject<GameConfig>(sqliteDataReader.GetValue(0).ToString());

                    UpdateSlider();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Failed to load config: {exc.Message}", "Error");
            }
        }

        private void fpsHsb_Scroll(object sender, ScrollEventArgs e)
        {
            if (gameConfig == null)
            {
                MessageBox.Show("Config not loaded", "Error");
                return;
            }
            gameConfig.KeyCustomFrameRate = e.NewValue;
            UpdateSlider();
        }

        private void setFpsBtn_Click(object sender, EventArgs e)
        {
            SaveWWConfig();
        }

        private void selectGameBtn_Click(object sender, EventArgs e)
        {
            PromtSelectGameFolder();
        }
    }
}
