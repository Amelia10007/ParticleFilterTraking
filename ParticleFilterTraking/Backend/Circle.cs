using System;
using System.Drawing;

namespace ParticleFilterTraking.Backend
{
    class Circle : ITrackedObject
    {
        private Position position;
        private readonly double radius;
        private readonly Size fieldSize;
        public Circle(Position position, double radius, Size fieldSize)
        {
            this.position = position;
            this.radius = radius;
            this.fieldSize = fieldSize;
        }
        public bool Contains(Position position) => this.position.Distance(position) <= this.radius;

        public Position Move()
        {
            var random = new Random();
            //移動量をランダムに決定
            var directionRandom = random.Next(4);
            var distanceRandom = random.Next(4) + 1;
            Position movement;
            switch (directionRandom)
            {
                case 0: movement = new Position(1, 0); break;
                case 1: movement = new Position(-1, 0); break;
                case 2: movement = new Position(0, 1); break;
                default: movement = new Position(0, -1); break;
            }
            movement *= distanceRandom;
            //もし，移動後の物体がフィールド内に入っているなら，移動する．そうでなければ，移動しない．
            var afterMovement = (this.position + movement)
                .Let(p => p.ChangeX(p.X.Round(0, this.fieldSize.Width - 1)))
                .Let(p => p.ChangeY(p.Y.Round(0, this.fieldSize.Height - 1)));
            var trueMovement = afterMovement - this.position;
            this.position = afterMovement;
            return trueMovement;
        }
        public void Draw(Bitmap canvas)
        {
            using (var graphics = Graphics.FromImage(canvas))
            {
                using (var pen = new Pen(Color.White))
                {
                    var left = (int)(this.position.X - this.radius);
                    var top = (int)(this.position.Y - this.radius);
                    var width = (int)(this.radius * 2);
                    var height = (int)(this.radius * 2);
                    var rectangle = new Rectangle(left, top, width, height);
                    graphics.DrawEllipse(pen, rectangle);
                }
            }
        }
    }
}
