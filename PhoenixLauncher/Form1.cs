using System;
using System.Threading.Tasks;
using CmlLib.Core;
using CmlLib.Core.Auth;
using CmlLib.Core.ProcessBuilder;
using CmlLib.Core.Installers;
using static System.Collections.Specialized.BitVector32;

namespace PhoenixLauncher
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public async Task NoPuedeSer()
        {
            var path = new MinecraftPath();

            var auth = MSession.CreateOfflineSession(TxtUsername.Text);

            var Opciones = new MLaunchOption
            {
                Session = auth,
                MaximumRamMb = 2048, // Ajusta según tu sistema
                GameLauncherName = "PhoenixLauncher"
            };


            var launcher = new MinecraftLauncher(path);

            launcher.FileProgressChanged += (s, e) =>
            {
                int Porcentaje = (int)(100.0 * e.ProgressedTasks / e.TotalTasks);
                progressBar1.Invoke(new Action(() =>
                {
                    progressBar1.Value = Porcentaje;
                }));
            };

            var process = await launcher.CreateProcessAsync(TxtVersion.Text, Opciones);


            process.Start();
        }

        private async void BtnPlay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUsername.Text) || string.IsNullOrWhiteSpace(TxtVersion.Text))
            {
                MessageBox.Show("Por favor, ingresa un nombre de usuario y una versión.");
                return;
            }
            else
            {
                await NoPuedeSer();
            }
        }
    }
}
