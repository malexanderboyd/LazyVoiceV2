using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Runtime.InteropServices;
using WindowsInput;
//using System.Speech.Synthesis; /// used to talk back
namespace LazyVoiceV2
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();


        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
IntPtr wParam, IntPtr lParam);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();

            commands.Add(new string[] { "turn up", "turn down", "volume up", "volume down", "mute", "unmute" });

            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(commands);
            Grammar g = new Grammar(gb);


            sre.LoadGrammarAsync(g); // keeps running all the time on different thread
            sre.SetInputToDefaultAudioDevice();
            sre.SpeechRecognized += Sre_SpeechRecognized;

        }

        private void Sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "volume up":
                case "turn up":
                    outputTextBox.Text += "Volume Up Heard\n";            
                    volumeUp();


                    break;
                case "volume down":
                case "turn down":
                    outputTextBox.Text += "Volume Down Heard\n";
                    volumeDown();
                    break;
                case "mute":
                    outputTextBox.Text += "Muted \n";
                    volumeDown();
                    mute();
                    break;

                case "unmute":
                    volumeUp();
                    volumeDown();
                    break;







                default:
                    outputTextBox.Text += e.Result.Text + " command not available. \n";
                    break;
            }
        }

        private void enableVoiceButton_Click(object sender, EventArgs e)
        {
            sre.RecognizeAsync(RecognizeMode.Multiple);
            disableVoiceButton.Enabled = true;
        }

        private void disableVoiceButton_Click(object sender, EventArgs e)
        {
            sre.RecognizeAsyncStop();
            disableVoiceButton.Enabled = false;
        }

        private void volumeUp()
        {
            for (int i = 0; i < 13; i++)
            {
                InputSimulator.SimulateKeyPress(VirtualKeyCode.VOLUME_UP);
            }
        }

        private void volumeDown()
        {
            for (int i = 0; i < 10; i++)
            {
                InputSimulator.SimulateKeyPress(VirtualKeyCode.VOLUME_DOWN);
            }
        }

        private void mute()
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.VOLUME_MUTE);
        }


    }
}
