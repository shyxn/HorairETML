using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using HtmlAgilityPack;

namespace HorairETML
{
    public partial class MainWindow : Form
    {
        private DateTime _currentDate;
        private string _currentDay;
        private string _currentDayOfWeek;
        private string _currentTime;
        private string _currentCourseType;
        private TimeSpan _timePast;
        private TimeSpan _timeLeft;
        private TimeSpan _globalTimePast;
        private TimeSpan _globalTimeLeft;
        private double _percent;
        private double _globalPercent;
        private double _pbComplete;
        private double _globalPbComplete;
        public int round = 2; //variable pour l'arrondi
        private string[] _percentSplits;
        private string[] _globalPercentSplits;
        private string _percentString;
        private string _globalPercentString;
        public bool arePercentsActivated = true;
        private Bitmap _bmp;
        private Bitmap _glbbmp;
        private Graphics _g;
        private Graphics _globalG;
        private int _PB_WIDTH;
        private int _PB_HEIGHT; // largeur, hauteur de l'accomplissement
        private int _GPB_WIDTH;
        private int _GPB_HEIGHT;
        private double _pbUnit; //taille d'un pas (1%)
        private double _gPbUnit;
        private string _decimals;
        private int _fontHeight; 
        private int _gFontHeight;
        private Data _dataSQL = new Data();
        private bool _hasToFetch = true;
        private List<object> _currentCourseRow = new List<object>();
        //private List<object[]> _currentAllCourses = new List<object[]>();
        //private List<object[]> _currentAllPeriods = new List<object[]>();
        private Utils _utils = new Utils();
        public List<Label> _allLabels = new List<Label>();
        private Settings _settingsFrm;


        public MainWindow()
        {
            InitializeComponent();
            this.Text = "HoraireETML - " + this._utils.currentVersion;
            this.versionLbl.Text = this._utils.currentVersion;

            this._allLabels.Add(currentTime);
            this._allLabels.Add(currentDate);
            this._allLabels.Add(moduleLbl);
            this._allLabels.Add(nameLbl);
            this._allLabels.Add(teacherLbl);
            this._allLabels.Add(roomLbl);
            this._allLabels.Add(teacherDataLbl);
            this._allLabels.Add(roomDataLbl);
            this._allLabels.Add(linkPDF);
            this._allLabels.Add(periodTimeLeft);
            this._allLabels.Add(globalTimeLeft);
            this._allLabels.Add(globalLbl);
            this._allLabels.Add(normalLbl);
            foreach (Label lbl in this._allLabels)
            {
                lbl.ForeColor = Design.textColor;
                if (lbl is LinkLabel)
                {
                    LinkLabel llbl = (LinkLabel)lbl;
                    llbl.LinkColor = Design.textColor;
                }
            }
            Design.SetRandomTheme();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Set dimensions
            this._PB_WIDTH = periodPB.Width;
            this._PB_HEIGHT = periodPB.Height;
            
            this._pbUnit = _PB_WIDTH / 100.00;
            this._fontHeight = _PB_HEIGHT / 2;

            // Create bitmap
            this._bmp = new Bitmap(this._PB_WIDTH, this._PB_WIDTH);
            
            // Graphics
            this._g = Graphics.FromImage(this._bmp);
            this._g.Clear(Design.normalPBbackgroundColor);
            periodPB.Image = this._bmp;


            this._GPB_WIDTH = globalPeriodPB.Width;
            this._GPB_HEIGHT = globalPeriodPB.Height;
            this._gPbUnit = _GPB_WIDTH / 100.00;
            this._gFontHeight = _GPB_HEIGHT / 2;

            this._glbbmp = new Bitmap(this._GPB_WIDTH, this._GPB_HEIGHT);

            this._globalG = Graphics.FromImage(this._glbbmp);
            this._globalG.Clear(Design.globalPBbackgroundColor);
            globalPeriodPB.Image = this._glbbmp;

            // Ticks
            int speed = 1;
            timeTick.Interval = speed;
            timeTick.Tick += new EventHandler(timeTick_Tick);
            timeTick.Start();
        }

        private void timeTick_Tick(object sender, EventArgs e)
        {
            this.BackColor = Design.backgroundColor;
            this._currentDate = DateTime.Now;// - new TimeSpan(0, 10, 0, 0);
            this._currentDayOfWeek = new CultureInfo("fr-FR").DateTimeFormat.GetDayName(this._currentDate.DayOfWeek);
            this._currentTime = this._currentDate.ToString("T");
            this._currentDay = this._currentDate.ToString("yyyy-MM-dd");

            // Actualiser les affichages
            this.currentTime.Text = this._currentTime;
            this.currentDate.Text = this._currentDate.ToString("D");

            // Ne recherche les données que toutes les minutes seulement
            if (this._currentDate.Second == 0 && this._currentDate.Millisecond > 0 && this._currentDate.Millisecond < 100)
            {
                this._hasToFetch = true;
                Debug.WriteLine("Le programme doit fetch");
            }

            // Requête SELECT SQL
            if (this._hasToFetch)
            {
                this._currentCourseRow = this._dataSQL.GetRowData(this._currentTime, this._currentDayOfWeek, this._currentDay);
                this._hasToFetch = false;
            }
            
            
            // Si aucun résultat trouvé
            if (this._currentCourseRow.Count == 0)
            {
                Debug.WriteLine("Il n'y a pas de cours actuellement." + this._currentDate.Millisecond);
                noCourse();

            }
            else
            {
                this.UpdatePeriod();
            }
        }

        private void UpdatePeriod()
        {
            this._currentCourseType = (string)this._currentCourseRow[4]; // Periods.periodType
            this.roomLbl.Text = "Salle :";
            this.teacherLbl.Text = "Prof :";
            this.normalLbl.Text = "Fin de la période : ";
            this.globalLbl.Text = "Fin du cours : ";
            this.linkPDF.Text = "Identification du module";

            this._timePast = this._currentDate - DateTime.Parse(this._currentDate.Date.ToString("d") + " " + this._currentCourseRow[1].ToString()); // startHour, TODO : enlever la partie avant courseData pour ne pas tester
            this._timeLeft = DateTime.Parse(this._currentDate.Date.ToString("d") + " " + this._currentCourseRow[2].ToString()) - this._currentDate; // endHour
            this.periodTimeLeft.Text = string.Format("{0:mm}min {0:ss}s", this._timeLeft);
            
            // Pourcentage accompli
            this._percent = this._timePast.TotalSeconds / Convert.ToDouble(this._currentCourseRow[3]); // durationScnds
            this._pbComplete = this._percent * 100.00;
            
            string doublestr = String.Format(CultureInfo.InvariantCulture, "{0:f10}", this._pbComplete);
            this._percentSplits = doublestr.Split('.');

            this._percentSplits[1] = this._percentSplits[1].Substring(0, this.round);
            if (this.round == 0)
            {
                this._percentString = this._percentSplits[0];
            }
            else
            {
                this._percentString = (this._percentSplits[0] + '.' + this._percentSplits[1]);
            }

            this._g.Clear(Design.normalPBbackgroundColor);
            this._g.FillRectangle(Design.normalPBforegroundColor, new Rectangle(0, 0, (int)(this._pbComplete * this._pbUnit), this._PB_HEIGHT));

            if (this.arePercentsActivated)
            {
                this._g.DrawString(this._percentString + " %", new Font("Calibri", this._fontHeight), Design.normalPBFontColor, new PointF(this._PB_WIDTH / 2 - this._fontHeight * this._percentString.Length / 2, this._fontHeight / 5));
            }
            periodPB.Image = this._bmp;

            // Autres labels
            this.moduleLbl.Text = (string)this._currentCourseRow[10]; // numModule
            if (this._currentCourseType == "c")
            {
                this.nameLbl.Text = (string)this._currentCourseRow[11]; // name
            }
            else if (this._currentCourseType == "p")
            {
                if (Convert.ToInt32(this._currentCourseRow[3]) == 300)
                {
                    this.nameLbl.Text = "Pause de 5 minutes :)";
                }
                else if (Convert.ToInt32(this._currentCourseRow[3]) == 900)
                {
                    this.nameLbl.Text = "Pause de 15 minutes :D";
                }
            }
            this.roomDataLbl.Text = (string)this._currentCourseRow[12]; // room
            this.teacherDataLbl.Text = (string)this._currentCourseRow[13]; // teacher
            
            //// GLOBAL
            UpdateGlobal();
        }
        private void UpdateGlobal()
        {
            int sumDuration = Convert.ToInt32(this._currentCourseRow[9]); // Courses.durationScnds ; somme de toutes les périodes en secondes
            DateTime startTime = DateTime.Parse(this._currentDate.Date.ToString("d") + " " + this._currentCourseRow[7].ToString()); // Courses.startHour
            DateTime endTime = DateTime.Parse(this._currentDate.Date.ToString("d") + " " + this._currentCourseRow[8].ToString()); // Courses.endHour
            this._globalTimePast = this._currentDate - startTime; // startHour, TODO : enlever la partie avant courseData pour ne pas tester
            this._globalTimeLeft = endTime - this._currentDate; // endHour
            this.globalTimeLeft.Text = string.Format("{0:hh}h {0:mm}min {0:ss}s", this._globalTimeLeft);

            // Pourcentage accompli
            this._globalPercent = this._globalTimePast.TotalSeconds / Convert.ToDouble(sumDuration);
            this._globalPbComplete = this._globalPercent * 100.00;
            
            string doublestr = String.Format(CultureInfo.InvariantCulture, "{0:f10}", this._globalPbComplete);
            this._globalPercentSplits = doublestr.Split('.');
            this._globalPercentSplits[1] = this._globalPercentSplits[1].Substring(0, this.round);

            if (this.round == 0)
            {
                this._globalPercentString = this._globalPercentSplits[0];
            }
            else
            {
                this._globalPercentString = (this._globalPercentSplits[0] + '.' + this._globalPercentSplits[1]);
            }
            
            
            
            //this._globalPercentString = this._globalPbComplete.ToString(this._decimals, new CultureInfo("en-US"));

            this._globalG.Clear(Design.globalPBbackgroundColor);
            this._globalG.FillRectangle(Design.globalPBforegroundColor, new Rectangle(0, 0, (int)(this._globalPbComplete * this._gPbUnit), this._GPB_HEIGHT));
            if (this.arePercentsActivated)
            {
                this._globalG.DrawString(this._globalPercentString + " %", new Font("Carlito", this._gFontHeight), Design.globalPBFontColor, new PointF(this._GPB_WIDTH / 2 - this._gFontHeight * this._globalPercentString.Length / 2, this._gFontHeight / 5));
            }

            globalPeriodPB.Image = this._glbbmp;
            //Debug.WriteLine(this._currentDate.Millisecond);
        }
        private void noCourse()
        {
            this.nameLbl.Text = "Pas de cours !";
            this.roomLbl.Text = "";
            this.teacherLbl.Text = "";
            this.moduleLbl.Text = "";
            this.roomDataLbl.Text = "";
            this.teacherDataLbl.Text = "";
            this.periodTimeLeft.Text = "";
            this.globalTimeLeft.Text = "";
            this.globalLbl.Text = "";
            this.linkPDF.Text = "";
            this.normalLbl.Text = "";
        }

        private void linkPDF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filePath;
            string numberModule = this._currentCourseRow[10].ToString().Substring(1);
            filePath = numberModule + "_identification-de-modulefr.pdf";
            filePath = Environment.CurrentDirectory + "\\Assets\\AllDescModules\\" + filePath;
            Process.Start(filePath);
        }

        private void chance_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int numSite = rnd.Next(this._utils.funWebsites.Count);
            Process.Start(this._utils.funWebsites[numSite]);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            if (this._settingsFrm == null || this._settingsFrm.Visible == false)
            {
                _settingsFrm = new Settings(this);
            }
            _settingsFrm.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            _settingsFrm.Show();
        }
        private string GetETMLRestaurantURL()
        {
            // Obtenir l'URL de l'image du menu du restaurant 
            HtmlAgilityPack.HtmlDocument htmldoc = new HtmlAgilityPack.HtmlDocument();
            var html = @"https://www.etml.ch/vie-de-lecole/menus-du-restaurant.html/";
            HtmlWeb web = new HtmlWeb();
            htmldoc = web.Load(html);

            // Sélectionner le chemin de l'URL (sans le site www.etml.ch)
            var name = htmldoc.DocumentNode.SelectSingleNode("//div[@class='itemFullText']/p[14]/img").Attributes["src"].Value;

            // URL complète de l'image du menu
            string ETMLRestaurantMenuURL = "https://etml.ch" + name;
            return ETMLRestaurantMenuURL;
        }

        private void RestaurantButton_Click(object sender, EventArgs e)
        {
            string url = GetETMLRestaurantURL();
            Process.Start(url);
        }

        private void WikiButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://fr.wikipedia.org/wiki/Sp%C3%A9cial:Page_au_hasard");
        }
    }
}
