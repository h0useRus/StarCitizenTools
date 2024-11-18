using NSW.StarCitizen.Tools.Helpers;

namespace NSW.StarCitizen.Tools.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = $"{AssemblyHelper.GetProduct()}  {AssemblyHelper.GetFileVersion()}";
        }
    }
}
