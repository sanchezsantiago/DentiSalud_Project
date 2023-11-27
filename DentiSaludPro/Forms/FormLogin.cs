namespace DentiSaludPro
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = true;
        }

        //Drag window

        bool isMouseDown = false; // Variable to track whether the mouse button is pressed
        Point originalMousePosition; // Variable to store the original mouse position when clicking on the panel
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            originalMousePosition = e.Location; // Store the original mouse position
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                // Calculate the difference between the current mouse position and the original position
                int deltaX = e.X - originalMousePosition.X;
                int deltaY = e.Y - originalMousePosition.Y;


                // Update the window position accordingly
                this.Location = new Point(this.Left + deltaX, this.Top + deltaY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false; // Reset to false when the mouse button is released
        }
    }
}
