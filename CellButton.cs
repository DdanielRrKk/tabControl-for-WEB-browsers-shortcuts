using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace dom12
{
    public class CellButton : Button
    {
        private int id;
        private string image;
        private string url;
        private int x;
        private int y;

        public string Image_Location
        {
            get { return image; }
            set { image = value; this.Image = (Image)new Bitmap(Image.FromFile(image), new Size(100, 100)); }
        }

        public string URL_Location
        {
            get { return url; }
            set { url = value; }
        }

        public int X_value
        {
            get { return x; }
            set { x = value; }
        }

        public int Y_value
        {
            get { return y; }
            set { y = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public CellButton()
        {
            this.Size = new Size(100, 100);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            id = 0;
            url = "";
            image = "";
            x = 0;
            y = 0;
        }

        public CellButton(int id, string url, string image, Point p)
        {
            this.Size = new Size(100, 100);
            this.Image = (Image)new Bitmap(Image.FromFile(image), new Size(100, 100));
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Location = p;

            this.id = id;
            this.url = url;
            this.image = image;
        }

        public void setLocation(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.Location = new Point(x, y);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            System.Diagnostics.Process.Start(url);
        }
    }
}
