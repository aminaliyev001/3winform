namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private int width;
        private int height;

        private int x1;
        private int y1;

        private int x2;
        private int y2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show($"Location: {clickedButton.Location.X}, {clickedButton.Location.Y}\n" +
                            $"Size: {clickedButton.Width}x{clickedButton.Height}");
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;

            width = Math.Abs(x2 - x1);
            height = Math.Abs(y2 - y1);

            if (width < 10 || 10 > height)
            {
                MessageBox.Show("Minimum 10x10 ola biler");
                return;
            }
            Button btn = new Button();
            btn.Location = new Point(x1, y1);
            btn.Size = new Size(width, height);
            btn.Text = "nese btn";
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Red;
            MessageBox.Show("Yarandi");
            btn.Click += btn_Click;
            Controls.Add(btn);
        }
    }
}