using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace Homework2._2_CSharp
{
    class MyPictureBox : PictureBox
    {
        Point point;
        public MyPictureBox(IContainer container)
        {
            container.Add(this);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            point = e.Location;
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
            
            base.OnMouseMove(e);
        }

    }
}
