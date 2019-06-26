using System;
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
            var width = (int)this.fieldWidthBox.Value;
            var height = (int)this.fieldHeightBox.Value;
            var objectSize = (int)this.objectSizeBox.Value;
            var particleCount = (int)this.particleCountBox.Value;
            var wrongRate = this.observationWrongProbabilityBar.Value / 100.0;
            var fieldSize = new Backend.Size(width, height);
            var objectPosition = new Position(fieldSize.Width / 2, fieldSize.Height / 2);
            var trakingObject = new Circle(objectPosition, objectSize, fieldSize);
            var field = new Field(fieldSize, trakingObject);
            var estimator = new ParticleFilterObserver(field, particleCount);
            this.backendSystem = new BackendSystem(field, estimator, wrongRate);
            this.timeStep = 0;
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

        private void applyButton_Click(object sender, EventArgs e)
        {
            this.InitializeField();
        }
    }
}
