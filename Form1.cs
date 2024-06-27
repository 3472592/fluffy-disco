namespace Ch2WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeText_Click(object sender, EventArgs e)
        {
            if (enableCheckbox.Checked == true)
            {
                if (labelToChange.Text == "Right")
                {
                    labelToChange.Text = "Left";
                    labelToChange.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    labelToChange.Text = "Right";
                    labelToChange.TextAlign = ContentAlignment.MiddleRight;
                }
            }
            else
            {
                // if changing text is disabled,
                // label will show text for the label.
                // label stays in the middle, || moves to middle,'
                // really depends on current situation of check & btn.
                labelToChange.Text = "Text Changing is Disabled";
                labelToChange.TextAlign= ContentAlignment.MiddleCenter;
            }
        }
    }
}