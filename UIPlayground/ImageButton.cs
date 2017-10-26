using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Brushes = System.Drawing.Brushes;

namespace UIPlayground
{
    public sealed class ImageButton : Button
    {
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle r = ClientRectangle;
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Blue, r.X, r.Y, r.Width * 30 / 100, r.Height);

            if (!DesignMode)
                g.DrawImage(Image.FromFile("gear.png"), new Rectangle(0, 0, r.Width * 30 / 100, r.Height));

            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, 20);

            this.Region = new Region(GraphPath);
            /*using (Pen pen = new Pen(Color.CadetBlue, 1f))
            {
                pen.Alignment = PenAlignment.Center;
                e.Graphics.DrawPath(pen, GraphPath);
            }*/
        }
    }
}