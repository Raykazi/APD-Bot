using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using NAudio.Wave;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace APD_Bot
{
    public partial class FrmMain : Form
    {   
        SpeechSynthesizer speech;
        KeyboardHook kbdHook;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void SetupCharges()
        {
            dgvChargesList.Rows.Add(new object[] { "Aiding in a Blackwater Robbery", 0, 112500 });
            dgvChargesList.Rows.Add(new object[] { "Aiding in a Federal Reserve Robbery", 0, 112500 });
            dgvChargesList.Rows.Add(new object[] { "Aiding in a Jail Break ", 0, 86000 });
            dgvChargesList.Rows.Add(new object[] { "Aiding in a Pharmaceutical Robbery", 0, 40000 });
            dgvChargesList.Rows.Add(new object[] { "Assault", 0, 500 });
            dgvChargesList.Rows.Add(new object[] { "Attempted Blackwater Robbery", 0, 82500 });
            dgvChargesList.Rows.Add(new object[] { "Attempted Federal Reserve Robbery", 0, 82500 });
            dgvChargesList.Rows.Add(new object[] { "Attempted Jail Break", 0, 63750 });
            dgvChargesList.Rows.Add(new object[] { "Attempted Manslaughter", 0, 26250 });
            dgvChargesList.Rows.Add(new object[] { "Attempted Robbery", 0, 8000 });
            dgvChargesList.Rows.Add(new object[] { "Attempted Vehicle Theft", 0, 5000 });
            dgvChargesList.Rows.Add(new object[] { "Destruction of Government property", 0, 63750 });
            dgvChargesList.Rows.Add(new object[] { "Destruction of property", 0, 63750 });
            dgvChargesList.Rows.Add(new object[] { "Disobeying an order from an officer", 0, 8000 });
            dgvChargesList.Rows.Add(new object[] { "Disturbing the Peace", 0, 1125 });
            dgvChargesList.Rows.Add(new object[] { "Driving an illegal vehicle", 0, 31500 });
            dgvChargesList.Rows.Add(new object[] { "Driving without a license", 0, 6250 });
            dgvChargesList.Rows.Add(new object[] { "Driving without lights", 0, 2000 });
            dgvChargesList.Rows.Add(new object[] { "Drug Possession ", 0, 45000 });
            dgvChargesList.Rows.Add(new object[] { "Entering an APD controlled area", 0, 6000 });
            dgvChargesList.Rows.Add(new object[] { "Escaping from Jail", 0, 0 });
            dgvChargesList.Rows.Add(new object[] { "Evading arrest", 0, 16500 });
            dgvChargesList.Rows.Add(new object[] { "Failure to stop at a police checkpoint (fixed or mobile)", 0, 30000 });
            dgvChargesList.Rows.Add(new object[] { "Failure to use collision lights", 0, 2000 });
            dgvChargesList.Rows.Add(new object[] { "Flying without a Pilot's License", 0, 10500 });
            dgvChargesList.Rows.Add(new object[] { "Flying/Hovering below 150 meters", 0, 15000 });
            dgvChargesList.Rows.Add(new object[] { "Gang Homicide", 0, 25000 });
            dgvChargesList.Rows.Add(new object[] { "Gas Station Robbery", 0, 18750 });
            dgvChargesList.Rows.Add(new object[] { "Government Cyber Attack", 0, 30000 });
            dgvChargesList.Rows.Add(new object[] { "Grand Theft Auto", 0, 17500 });
            dgvChargesList.Rows.Add(new object[] { "Hit and Run", 0, 7500 });
            dgvChargesList.Rows.Add(new object[] { "Hostage Situation", 0, 86500 });
            dgvChargesList.Rows.Add(new object[] { "Illegal Aerial Vehicle Landing ", 0, 48750 });
            dgvChargesList.Rows.Add(new object[] { "Insurance Fraud", 0, 1500 });
            dgvChargesList.Rows.Add(new object[] { "Kidnapping", 0, 11250 });
            dgvChargesList.Rows.Add(new object[] { "Kidnapping a Government Official", 0, 92750 });
            dgvChargesList.Rows.Add(new object[] { "L.E.O. Manslaughter", 0, 37500 });
            dgvChargesList.Rows.Add(new object[] { "Man Slaughter", 0, 30000 });
            dgvChargesList.Rows.Add(new object[] { "Misuse Of Emergency", 0, 40000 });
            dgvChargesList.Rows.Add(new object[] { "Obstruction Of Justice", 0, 15750 });
            dgvChargesList.Rows.Add(new object[] { "Obstruction of Traffic", 0, 4625 });
            dgvChargesList.Rows.Add(new object[] { "Organ Harvesting", 0, 11250 });
            dgvChargesList.Rows.Add(new object[] { "Party to a crime", 0, 15000 });
            dgvChargesList.Rows.Add(new object[] { "Possession of A.P.D. equipment", 0, 25500 });
            dgvChargesList.Rows.Add(new object[] { "Possession of an Illegal organ", 0, 22500 });
            dgvChargesList.Rows.Add(new object[] { "Possession of firearm w/o a License", 0, 11000 });
            dgvChargesList.Rows.Add(new object[] { "Possession of illegal firearms", 0, 12000 });
            dgvChargesList.Rows.Add(new object[] { "Reckless Driving", 0, 3000 });
            dgvChargesList.Rows.Add(new object[] { "Robbery", 0, 20000 });
            dgvChargesList.Rows.Add(new object[] { "Speeding", 0, 1500 });
            dgvChargesList.Rows.Add(new object[] { "Terrorist Acts (calling terror)", 0, 93750 });
            dgvChargesList.Rows.Add(new object[] { "Unlawful Taser Usage", 0, 30000 });
            dgvChargesList.Rows.Add(new object[] { "Use of firearms within the city", 0, 5000 });
            dgvChargesList.Rows.Add(new object[] { "Using drugs in public", 0, 10000 });
            dgvChargesList.Rows.Add(new object[] { "Vehicular Manslaughter", 0, 35000 });
            dgvChargesList.Rows.Add(new object[] { "Verbal Insults", 0, 3000 });
            dgvChargesList.Rows.Add(new object[] { "Verbal Threats", 0, 8000 });
            dgvChargesList.Rows.Add(new object[] { "Weapons Trafficking ", 0, 15125 });
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetupCharges();
            SetupLicenses();
            RegisterHotKeys();
            SetupAudioDevices();
            SetupVoices();
        }

        private void SetupAudioDevices()
        {
            for (int n = -1; n < WaveOut.DeviceCount; n++)
            {
                var caps = WaveOut.GetCapabilities(n);
                cbAudio.Items.Add(new AudioDevice(caps.ProductName, n));
            }
            for(int i = 0; i < cbAudio.Items.Count; i++)
            {
                if (cbAudio.Items[i].ToString().Contains(Properties.Settings.Default.DeviceName))
                    cbAudio.SelectedIndex = i;
            }
        }

        private void SetupVoices()
        {
            speech = new SpeechSynthesizer();
            speech.SpeakStarted += SpeechSynthesizerObj_SpeakStarted;
            speech.SpeakCompleted += SpeechSynthesizerObj_SpeakCompleted;
            foreach (InstalledVoice voice in speech.GetInstalledVoices())
            {
                cbVoices.Items.Add(voice.VoiceInfo.Name);
            }
            for (int i = 0; i < cbVoices.Items.Count; i++)
            {
                if (cbVoices.Items[i].ToString().Contains(Properties.Settings.Default.VoiceName))
                    cbVoices.SelectedIndex = i;
            }
        }

        private void SetupLicenses()
        {
            cbLicenses.Items.Add("Vigilante");
            cbLicenses.Items.Add("Firearms");
            cbLicenses.Items.Add("Worker's Protection");
        }

        private void RegisterHotKeys()
        {
            kbdHook = new KeyboardHook();
            kbdHook.KeyPressed += KbdHook_KeyPressed;
            kbdHook.RegisterHotKey(APD_Bot.ModifierKeys.None, Keys.F1);
            kbdHook.RegisterHotKey(APD_Bot.ModifierKeys.None, Keys.F2);
            kbdHook.RegisterHotKey(APD_Bot.ModifierKeys.None, Keys.F3);
            kbdHook.RegisterHotKey(APD_Bot.ModifierKeys.None, Keys.F4);
            kbdHook.RegisterHotKey(APD_Bot.ModifierKeys.None, Keys.F5);
            kbdHook.RegisterHotKey(APD_Bot.ModifierKeys.None, Keys.F6);
            kbdHook.RegisterHotKey(APD_Bot.ModifierKeys.None, Keys.F7);
            kbdHook.RegisterHotKey(APD_Bot.ModifierKeys.None, Keys.F8);
            kbdHook.RegisterHotKey(APD_Bot.ModifierKeys.None, Keys.F9);
            kbdHook.RegisterHotKey(APD_Bot.ModifierKeys.None, Keys.F10);
            kbdHook.RegisterHotKey(APD_Bot.ModifierKeys.None, Keys.F11);
        }

        private void KbdHook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            var modifier = e.Modifier;
            var key = e.Key;
            switch (e.Modifier)
            {
                case APD_Bot.ModifierKeys.None:
                    switch (key)
                    {
                        case Keys.F1:
                            btnEngage.PerformClick();
                            break;
                        case Keys.F2:
                            btnComms.PerformClick();
                            break;
                        case Keys.F3:
                            btnLicenses.PerformClick();
                            break;
                        case Keys.F4:
                            btnIllegal.PerformClick();
                            break;
                        case Keys.F5:
                            btnSeize.PerformClick();
                            break;
                        case Keys.F6:
                            btnTicket1.PerformClick();
                            break;
                        case Keys.F7:
                            btnWaitTime.PerformClick();
                            break;
                        case Keys.F8:
                            btnTicket2.PerformClick();
                            break;
                        case Keys.F9:
                            btnJail.PerformClick();
                            break;
                        case Keys.F10:
                            btnCustom.PerformClick();
                            break;
                    }
                    break;
            }
        }
        private void SpeechSynthesizerObj_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            btnComms.Enabled = true;
            btnEngage.Enabled = true;
            btnIllegal.Enabled = true;
            btnJail.Enabled = true;
            btnLicenses.Enabled = true;
            btnSeize.Enabled = true;
            btnTicket1.Enabled = true;
            btnTicket2.Enabled = true;
            btnWaitTime.Enabled = true;
            btnCustom.Enabled = true;
        }

        private void SpeechSynthesizerObj_SpeakStarted(object sender, SpeakStartedEventArgs e)
        {
            btnComms.Enabled = false;
            btnEngage.Enabled = false;
            btnIllegal.Enabled = false;
            btnJail.Enabled = false;
            btnLicenses.Enabled = false;
            btnSeize.Enabled = false;
            btnTicket1.Enabled = false;
            btnTicket2.Enabled = false;
            btnWaitTime.Enabled = false;
            btnCustom.Enabled = false;
        }

        private void dgvChargesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cbVoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            speech.SelectVoice(cbVoices.SelectedItem.ToString());
            Properties.Settings.Default.VoiceName = cbVoices.SelectedItem.ToString();
        }
        private void cbAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            AudioDevice device = (AudioDevice)cbAudio.SelectedItem;
            Properties.Settings.Default.DeviceName = device.DeviceName;
            Properties.Settings.Default.DeviceNumber = device.DeviceNumber;
        }
        private void Speak(string text)
        {
            AudioDevice device = (AudioDevice)cbAudio.SelectedItem;
            MemoryStream stream = new MemoryStream();
            speech.SetOutputToWaveStream(stream);
            speech.SpeakAsync(text);
            stream.Flush();
            stream.Seek(0, SeekOrigin.Begin);
            var reader = new WaveFileReader(stream);
            var waveOut = new WaveOut
            {
                DeviceNumber = device.DeviceNumber,
            };
            waveOut.Init(reader);
            waveOut.Play();
        }
        private void btnEngage_Click(object sender, EventArgs e)
        {
            Speak("Hands up or be taysd");
        }

        private void btnComms_Click(object sender, EventArgs e)
        {
            Speak("I'm taking your comms and GPS");
        }

        private void btnLicenses_Click(object sender, EventArgs e)
        {
            Speak("I'm searching for your licenses");
        }

        private void btnIllegal_Click(object sender, EventArgs e)
        {
            Speak("I'll be searching you for any illegal items");
        }

        private void btnSeize_Click(object sender, EventArgs e)
        {
            string mainMessage = "I'll be seizing your illegal contraband and weapons ";
            string additional = "along with your ";
            int count = cbLicenses.CheckedItems.Count;
            for (int i = 0; i < count; i++)
            {
                if (count > 1 && i >= 1 && i == (count - 1))
                {
                    additional += "and " + cbLicenses.CheckedItems[i];
                }
                else
                {
                    additional += cbLicenses.CheckedItems[i] + (count > 1 ? ", " : "");
                }

            }
            additional += (count > 1 ? " licenses " : " license");

            if (count > 0)
                mainMessage += additional;
            Speak(mainMessage);
        }

        private void btnTicket1_Click(object sender, EventArgs e)
        {
            int total = 0;
            string message = ((tbName.Text.Length > 0 ? tbName.Text : "Alright you criminal dirtbag") + ", your wanted for, ");
            foreach (DataGridViewRow row in dgvChargesList.Rows)
            {
                string charge = row.Cells[0].Value.ToString();
                int counts = Convert.ToInt32(row.Cells[1].Value);
                int chargeAmount = Convert.ToInt32(row.Cells[2].Value);
                if (counts != 0)
                {
                    message += ($"{counts} {(counts > 1 ? "counts" : "count")} of {charge},");
                    total += chargeAmount * counts;
                }
            }
            message += (String.Format(" for a total of {0:C}. You will have two chances to pay your ticket, failure to do so will result in you being sent to jail.", total));
            Speak(message);
        }

        private void btnTicket2_Click(object sender, EventArgs e)
        {
            Speak("Here's your 2nd chance to pay your ticket.");
        }

        private void btnJail_Click(object sender, EventArgs e)
        {
            Speak("I'll be sending you to jail now.");
        }


        private void btnWaitTime_Click(object sender, EventArgs e)
        {
            Speak("You have 5 more seconds to pay this ticket. 5, 4, 3, 2, 1.");
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            if (tbCustom.Text.Length > 0)
                Speak(tbCustom.Text);
        }
    }
}
