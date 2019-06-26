using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParticleFilterTraking.Backend;

namespace ParticleFilterTraking
{
    public partial class MainForm : Form
    {
        private readonly Timer timer;
        private BackendSystem backendSystem;
        private int timeStep = 0;
        private bool isUpdating = false;
        public MainForm()
        {
            InitializeComponent();
            this.pictureBox.BackColor = Color.Black;
            //
            this.InitializeField();
            //
            this.timer = new Timer() { Interval = 500 };
            timer.Tick += async (sender, e) =>
              {
                  if (this.isUpdating)
                  {
                      this.notificationLabel.Text = $"step {this.timeStep} (Busy)";
                      return;
                  }
                  this.isUpdating = true;
                  this.notificationLabel.Text = $"step {this.timeStep}";
                  await Task.Run(() => this.backendSystem.Update());
                  var bitmap = await Task.Run(() => this.backendSystem.Draw());
                  this.pictureBox.Image = bitmap;
                  this.isUpdating = false;
                  this.timeStep++;
              };
        }
        private void InitializeField()
        {
            var fieldSize = new Backend.Size(300, 300);
            var objectPosition = new Position(fieldSize.Width / 2, fieldSize.Height / 2);
            var trakingObject = new Circle(objectPosition, 5.0, fieldSize);
            var field = new Field(fieldSize, trakingObject);
            var estimator = new ParticleFilterObserver(field, 10000);
            this.backendSystem = new BackendSystem(field, estimator, 0.2);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.startButton.Enabled = false;
            this.stopButton.Enabled = true;
            this.timer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.startButton.Enabled = true;
            this.stopButton.Enabled = false;
            this.timer.Stop();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.InitializeField();
        }
    }
}
