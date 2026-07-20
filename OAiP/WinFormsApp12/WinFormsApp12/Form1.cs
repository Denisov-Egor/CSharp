namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = panel1.Width;
            int height = panel1.Height;
            int stripeHeight = height / 3;
            using (SolidBrush brush = new SolidBrush(Color.White))
                g.FillRectangle(brush, 0, 0, width, stripeHeight);
            using (SolidBrush brush = new SolidBrush(Color.Blue))
                g.FillRectangle(brush, 0, stripeHeight, width, stripeHeight);
            using (SolidBrush brush = new SolidBrush(Color.Red))
                g.FillRectangle(brush, 0, stripeHeight * 2, width, stripeHeight);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = panel2.Width;
            int height = panel2.Height;
            using (SolidBrush brush = new SolidBrush(Color.White))
                g.FillRectangle(brush, 0, 0, width, height);
            int diameter = (int)(height * 0.6);
            Rectangle circleRect = new Rectangle(
                (width - diameter) / 2,
                (height - diameter) / 2,
                diameter,
                diameter
            );
            using (SolidBrush brush = new SolidBrush(Color.Red))
                g.FillEllipse(brush, circleRect);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = panel3.Width;
            int height = panel3.Height;
            int halfHeight = height / 2;
            using (SolidBrush brush = new SolidBrush(Color.White))
                g.FillRectangle(brush, 0, 0, width, halfHeight);
            using (SolidBrush brush = new SolidBrush(Color.Red))
                g.FillRectangle(brush, 0, halfHeight, width, halfHeight);
            Point[] trianglePoints = new Point[]
            {
        new Point(0, 0),                
        new Point(0, height),
        new Point(width / 2, halfHeight)
            };
            using (SolidBrush brush = new SolidBrush(Color.Blue))
                g.FillPolygon(brush, trianglePoints);
        }
    }
}
