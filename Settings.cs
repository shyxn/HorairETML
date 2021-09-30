using System;
using System.Windows.Forms;

namespace HorairETML
{
    public partial class Settings : Form
    {
        private MainWindow _mainWindow;
        string[] _themes = new string[]
            {
                "Bleuphorie",
                "Vie au lait",
                "Jon",
                "Roue Jeu",
                "Roz",
                "Eaux Rangées",
                "Vert Mifuge",
                "Pour 10 LANs"
            };
        string[] _backgrounds = new string[]
        {
            "Blan",
            "Noue Harre"
        };
        public Settings(MainWindow mainWindow)
        {
            this._mainWindow = mainWindow;

            InitializeComponent();

            themeCB.Items.AddRange(this._themes);
            backgroundCB.Items.AddRange(this._backgrounds);
        }


        public void Settings_Load(object sender, EventArgs e)
        {

        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            if (this._mainWindow.round < 5)
            {
                this._mainWindow.round++;
            }
        }

        private void lessBtn_Click(object sender, EventArgs e)
        {
            if (this._mainWindow.round > 0)
            {
                this._mainWindow.round--;
            }
        }

        private void ActivationPercents_Click(object sender, EventArgs e)
        {
            if (this._mainWindow.arePercentsActivated)
            {
                this._mainWindow.arePercentsActivated = false;
            }
            else
            {
                this._mainWindow.arePercentsActivated = true;
            }
        }

        private void themeCB_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (themeCB.SelectedItem)
            {
                case "Bleuphorie":
                    Design.BlueTheme();
                    break;
                case "Vie au lait":
                    Design.PurpleTheme();
                    break;
                case "Jon":
                    Design.YellowTheme();
                    break;
                case "Roue Jeu":
                    Design.RedTheme();
                    break;
                case "Eaux Rangées":
                    Design.OrangeTheme();
                    break;
                case "Vert Mifuge":
                    Design.GreenTheme();
                    break;
                case "Roz":
                    Design.PinkTheme();
                    break;
                case "Pour 10 LANs":
                    Design.DylanTheme();
                    break;
            }
        }
        private void backgroundCB_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (backgroundCB.SelectedItem)
            {
                case "Blan":
                    Design.SetBlackOnWhite();
                    break;
                case "Noue Harre":
                    Design.SetWhiteOnBlack();
                    break;
            }
            foreach (Label lbl in this._mainWindow._allLabels)
            {
                lbl.ForeColor = Design.textColor;
                if (lbl is LinkLabel)
                {
                    LinkLabel llbl = (LinkLabel)lbl;
                    llbl.LinkColor = Design.textColor;
                }
            }
        }


    }
}
