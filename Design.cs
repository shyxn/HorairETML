using System;
using System.Drawing;


namespace HorairETML
{
    public static class Design
    {
        // Fond de la barre 
        public static Color normalPBbackgroundColor = Color.FromArgb(40, 40, 40);
        public static Color globalPBbackgroundColor = Color.FromArgb(40, 40, 40);
        public static Brush normalPBforegroundColor = new SolidBrush(Color.FromArgb(133, 32, 50));
        public static Brush globalPBforegroundColor = new SolidBrush(Color.FromArgb(107, 9, 33));
        public static Brush normalPBFontColor = Brushes.White;
        public static Brush globalPBFontColor = Brushes.White;
        public static Color textColor = Color.White;
        public static Color backgroundColor = Color.Black;
        /// <summary>
        /// Change le fond en blanc, la police en noir
        /// </summary>
        public static void SetBlackOnWhite()
        {
            textColor = Color.Black;
            backgroundColor = Color.White;
        }
        /// <summary>
        /// Change le fond en noir, la police en blanc
        /// </summary>
        public static void SetWhiteOnBlack()
        {
            textColor = Color.White;
            backgroundColor = Color.Black;
        }
        public static void PurpleTheme()
        {
            normalPBforegroundColor = new SolidBrush(Color.FromArgb(108, 77, 133));
            globalPBforegroundColor = new SolidBrush(Color.FromArgb(58, 33, 89));
        }
        public static void RedTheme()
        {
            normalPBforegroundColor = new SolidBrush(Color.FromArgb(133, 32, 50));
            globalPBforegroundColor = new SolidBrush(Color.FromArgb(107, 9, 33));
        }
        public static void GreenTheme()
        {
            normalPBforegroundColor = new SolidBrush(Color.FromArgb(137, 169, 117));
            globalPBforegroundColor = new SolidBrush(Color.FromArgb(107, 134, 91));
        }
        public static void YellowTheme()
        {
            normalPBforegroundColor = new SolidBrush(Color.FromArgb(189, 163, 15));
            globalPBforegroundColor = new SolidBrush(Color.FromArgb(143, 121, 0));
        }
        public static void PinkTheme()
        {
            normalPBforegroundColor = new SolidBrush(Color.FromArgb(173, 133, 133));
            globalPBforegroundColor = new SolidBrush(Color.FromArgb(148, 98, 98));
        }
        public static void OrangeTheme()
        {
            normalPBforegroundColor = new SolidBrush(Color.FromArgb(197, 141, 86));
            globalPBforegroundColor = new SolidBrush(Color.FromArgb(209, 122, 35));
        }
        public static void BlueTheme()
        {
            normalPBforegroundColor = new SolidBrush(Color.FromArgb(11, 94, 107));
            globalPBforegroundColor = new SolidBrush(Color.FromArgb(9, 54, 61));
        }
        public static void DylanTheme()
        {
            normalPBforegroundColor = new SolidBrush(Color.FromArgb(255, 5, 229));
            globalPBforegroundColor = new SolidBrush(Color.FromArgb(186, 0, 230));
        }
        public static void SetRandomTheme()
        {
            Random rnd = new Random();
            int i = rnd.Next(7);
            switch (i)
            {
                case 0:
                    PurpleTheme();
                    break;
                case 1:
                    RedTheme();
                    break;
                case 2:
                    YellowTheme();
                    break;
                case 3:
                    PinkTheme();
                    break;
                case 4:
                    OrangeTheme();
                    break;
                case 5:
                    BlueTheme();
                    break;
                case 6:
                    GreenTheme();
                    break;
                default:
                    RedTheme();
                    break;
            }
        }
    }
}
