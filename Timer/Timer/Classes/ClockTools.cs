using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public class ClockTools
    {

        private static Form frm_Clock = new Form();
        private static bool _firstTime = true;
        private static int _mode = 2;
        private static Graphics g;
        public static double map(
           double originalStart, double originalEnd, // original range
           double newStart, double newEnd, // desired range
           double value) // value to convert
        {
            double scale = (newEnd - newStart) / (originalEnd - originalStart);
            return (newStart + ((value - originalStart) * scale));
        }
        public static Point AnglePoint(double angle, double distanceFromCenter, double angleIncrement, 
            Form frm, int controlWidth, int controlHeight)
        {
            angle += angleIncrement;
            angle *= Math.PI / 180;
            Point p = new Point()
            {
                X = (int)(frm.ClientRectangle.Width / 2 + Math.Cos(angle) * distanceFromCenter - controlWidth/2),
                Y = (int)(frm.ClientRectangle.Height / 2 - Math.Sin(angle) * distanceFromCenter- controlHeight/2)
            };
            return p;
        }

        public static Point AnglePoint(double angle, double distanceFromCenter, double angleIncrement,
            Control control, int controlWidth, int controlHeight)
        {
            angle += angleIncrement;
            angle *= Math.PI / 180;
            Point p = new Point()
            {
                X = (int)(control.ClientRectangle.Width / 2 + Math.Cos(angle) * distanceFromCenter - controlWidth / 2),
                Y = (int)(control.ClientRectangle.Height / 2 - Math.Sin(angle) * distanceFromCenter - controlHeight / 2)
            };
            return p;
        }

        public static Point CenterPoint(Form frm)
        {
            Point p = new Point()
            {

                X = frm.ClientRectangle.Width / 2,
                Y = frm.ClientRectangle.Height / 2
            };
            return p;
        }
        public static Point CenterPoint(Form frm, int controlWidth, int controlHeight)
        {
            Point p = new Point()
            {
                X = (frm.ClientRectangle.Width - controlWidth) / 2,
                Y = (frm.ClientRectangle.Height - controlHeight) / 2
            };
            return p;
        }
        public static Point CenterPoint(Control control)
        {
            Point p = new Point()
            {

                X = (control.ClientRectangle.Width ) / 2,
                Y = (control.ClientRectangle.Height) / 2
            };
            return p;
        }
        public static Point CenterPoint(Control control, int itemWidth, int itemHeight )
        {
            Point p = new Point()
            {

                X = (control.ClientRectangle.Width - itemWidth) / 2,
                Y = (control.ClientRectangle.Height - itemHeight) / 2
            };
            return p;
        }
        public static Color ColorMode(int mode, Color defaultColor)
        {
            Color clr;
            if (mode == 1)
            {
                clr = Color.FromArgb((int)map(0, 60, 0, 255, DateTime.Now.Second),
                 (int)map(0, 60, 255, 0, DateTime.Now.Second),
                 (int)map(0, 23, 0, 255, DateTime.Now.Hour));
            }
            else if (mode == 2)
            {
                clr = Color.FromArgb((int)map(0, 60, 0, 255, DateTime.Now.Second),
                 (int)map(0, 60, 255, 0, DateTime.Now.Second),
                 (int)map(0, 1000, 0, 255, DateTime.Now.Millisecond));
            }
            else if (mode == 3)
            {
                clr = Color.FromArgb((int)map(0, 60, 0, 255, DateTime.Now.Second),
                 (int)map(0, 1000, 255, 0, DateTime.Now.Millisecond),
                 (int)map(0, 1000, 0, 255, DateTime.Now.Millisecond));
            }
            else if (mode == 4)
            {
                clr = Color.FromArgb((int)map(0, 1000, 0, 255, DateTime.Now.Millisecond),
                 (int)map(0, 1000, 255, 0, DateTime.Now.Millisecond),
                 (int)map(0, 1000, 0, 255, DateTime.Now.Millisecond));
            }
            else if (mode == 5)
            {
                if (DateTime.Now.Millisecond <= 250)
                {
                    clr = Color.FromArgb((int)map(0, 250, 0, 255, DateTime.Now.Millisecond),
                 (int)map(0, 250, 255, 0, DateTime.Now.Millisecond),
                 (int)map(0, 250, 0, 255, DateTime.Now.Millisecond));
                }
                else if (DateTime.Now.Millisecond > 250 && DateTime.Now.Millisecond <= 500)
                {
                    clr = Color.FromArgb((int)map(251, 500, 0, 255, DateTime.Now.Millisecond),
                (int)map(251, 500, 255, 0, DateTime.Now.Millisecond),
                (int)map(251, 500, 0, 255, DateTime.Now.Millisecond));
                }
                else if (DateTime.Now.Millisecond > 500 && DateTime.Now.Millisecond <= 750)
                {
                    clr = Color.FromArgb((int)map(501, 750, 0, 255, DateTime.Now.Millisecond),
                (int)map(501, 750, 255, 0, DateTime.Now.Millisecond),
                (int)map(501, 750, 0, 255, DateTime.Now.Millisecond));
                }
                else
                {
                    clr = Color.FromArgb((int)map(751, 1000, 0, 255, DateTime.Now.Millisecond),
                (int)map(751, 1000, 255, 0, DateTime.Now.Millisecond),
                (int)map(751, 1000, 0, 255, DateTime.Now.Millisecond));
                }
            }
            else
            {
                clr = defaultColor;
            }
            return clr;
        }
        public static Color ColorMode(int mode)
        {
            
            return ColorMode(mode, Color.Red);
        }

        public static void ClockStart(Form frm, Color colorFrame,
           Color colorClock, int clockThickness,
           Color colorSec, int SecThickness,
           Color colorMin, int MinThickness,
           Color colorHour, int HourThickness,
           int clockDiameter, int mode)
        {
            Random rndColor = new Random(255);
            Pen pSec = new Pen(ColorMode(mode, colorSec), SecThickness);
            Pen pFrame = new Pen(colorFrame, 10);
            Pen pMin = new Pen(colorMin, MinThickness);
            Pen pHour = new Pen(colorHour, HourThickness);
            Pen pCan = new Pen(colorClock, clockThickness);
            double angleSec, angleMin, angleHour;
            int circleDiameter = clockDiameter;
            angleSec = map(0, 60000, 360, 0, DateTime.Now.Millisecond + (DateTime.Now.Second) * 1000);
            angleMin = map(0, 60, 360, 0, DateTime.Now.Minute);
            angleHour = map(0, 12, 360, 0, DateTime.Now.Hour);
            //oxi megali diafora me milliseconds
            //angleMin = map(0, 216000000, 360, 0, DateTime.Now.Millisecond + (DateTime.Now.Second) * 1000
            //    + (DateTime.Now.Minute * 3600000));
            //angleHour = map(0, 2592000000, 360, 0, DateTime.Now.Millisecond + (DateTime.Now.Second) * 1000
            //    + (DateTime.Now.Minute * 3600000)+ (DateTime.Now.Hour * 216000000));
            try
            {
                frm.BackColor = Color.LimeGreen;
                g= frm.CreateGraphics();

                g.DrawLine(pHour, CenterPoint(frm), AnglePoint(angleHour, (circleDiameter / 4), 90, frm, 0, 0));
                g.DrawLine(pSec, CenterPoint(frm), AnglePoint(angleSec, circleDiameter  / 2, 90, frm, 0, 0));
                g.DrawLine(pMin, CenterPoint(frm), AnglePoint(angleMin, (circleDiameter / 2) - 10, 90, frm, 0, 0));
                if(DateTime.Now.Second == 0 && DateTime.Now.Millisecond < 100 || _firstTime)
                {
                    g.FillEllipse(pFrame.Brush, CenterPoint(frm, circleDiameter, circleDiameter).X,
                        CenterPoint(frm, circleDiameter, circleDiameter).Y,
                        circleDiameter, circleDiameter);
                    _firstTime = false;
                }
                g.FillEllipse(pCan.Brush, CenterPoint(frm, circleDiameter / 12, circleDiameter / 12).X,
                   CenterPoint(frm, circleDiameter / 12, circleDiameter / 12).Y,
                   circleDiameter / 12, circleDiameter / 12);
                g.FillEllipse(pCan.Brush, AnglePoint(90, (circleDiameter - 40) / 2, 0, frm, circleDiameter / 15, circleDiameter / 15).X,
                    AnglePoint(90, (circleDiameter - 40) / 2, 0, frm, circleDiameter / 15, circleDiameter / 15).Y,
                    circleDiameter / 15, circleDiameter / 15);
                g.FillEllipse(pCan.Brush, AnglePoint(180, (circleDiameter - 40) / 2, 0, frm, circleDiameter / 15, circleDiameter / 15).X,
                    AnglePoint(180, (circleDiameter - 40) / 2, 0, frm, circleDiameter / 15, circleDiameter / 15).Y,
                    circleDiameter / 15, circleDiameter / 15);
                g.FillEllipse(pCan.Brush, AnglePoint(270, (circleDiameter - 40) / 2, 0, frm, circleDiameter / 15, circleDiameter / 15).X,
                    AnglePoint(270, (circleDiameter - 40) / 2, 0, frm, circleDiameter / 15, circleDiameter / 15).Y,
                    circleDiameter / 15, circleDiameter / 15);
                g.FillEllipse(pCan.Brush, AnglePoint(0, (circleDiameter - 40) / 2, 0, frm, circleDiameter / 15, circleDiameter / 15).X,
                    AnglePoint(0, (circleDiameter - 40) / 2, 0, frm, circleDiameter / 15, circleDiameter / 15).Y,
                    circleDiameter / 15, circleDiameter / 15);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
        public static void ClockStart(Form frm, int mode)
        {
            ClockStart(frm,Color.Black, Color.White, 12,
                Color.Red, 4,
                Color.Blue, 9,
                Color.DarkBlue, 14,
                250, mode);
        }
        public static void ClockStart(int mode)
        {
            ClockStart(frm_Clock, Color.Black, Color.White, 12,
                Color.Red, 4,
                Color.Blue, 9,
                Color.DarkBlue, 14,
                250, mode);
            _mode = mode;
            frm_Clock.FormClosing += new FormClosingEventHandler(frm_Clock_Closing);
            frm_Clock.Paint += new PaintEventHandler(frm_Clock_Paint);
            frm_Clock.TransparencyKey = Color.LimeGreen;
            frm_Clock.Height = 300;
            frm_Clock.Width = 300;
            frm_Clock.MaximumSize = new Size(300, 300);
            frm_Clock.MinimumSize = new Size(300, 300);
            frm_Clock.MaximizeBox = false;
            System.Windows.Forms.Timer tmr_Clock = new System.Windows.Forms.Timer();
            tmr_Clock.Interval = 50;
            tmr_Clock.Enabled = true;
            tmr_Clock.Tick += new EventHandler(tmr_Clock_Tick);
            tmr_Clock.Start();

            

            frm_Clock.Show();
            _firstTime = true;
           
        }
        public static void ClockStart()
        {
            ClockStart(_mode);

        }
        private static void tmr_Clock_Tick(object sender, EventArgs e)
        {
            ClockStart(frm_Clock , _mode);
            if (DateTime.Now.Second == 0 && DateTime.Now.Millisecond < 60)
            {
                frm_Clock.Invalidate();
            }
        }
        private static void frm_Clock_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            frm_Clock.Visible = false;
            _firstTime = true;
        }

        private static void frm_Clock_Paint(object sender, PaintEventArgs e)
        {
            g = frm_Clock.CreateGraphics();
            int circleDiameter = 250;
            g.FillEllipse(Brushes.Black, CenterPoint(frm_Clock, circleDiameter, circleDiameter).X,
                        CenterPoint(frm_Clock, circleDiameter, circleDiameter).Y,
                        circleDiameter, circleDiameter);
           
        }

        public static void ClockStart(Control control, Color colorFrame,
           Color colorClock, int clockThickness,
           Color colorSec, int SecThickness,
           Color colorMin, int MinThickness,
           Color colorHour, int HourThickness,
           int clockDiameter, int mode, bool firstTime)
        {
            Random rndColor = new Random(255);
            Pen pSec = new Pen(ColorMode(mode, colorSec), SecThickness);
            Pen pFrame = new Pen(colorFrame, 10);
            Pen pMin = new Pen(colorMin, MinThickness);
            Pen pHour = new Pen(colorHour, HourThickness);
            Pen pCan = new Pen(colorClock, clockThickness);
            double angleSec, angleMin, angleHour;
            int circleDiameter = clockDiameter;
            angleSec = map(0, 60000, 360, 0, DateTime.Now.Millisecond + (DateTime.Now.Second) * 1000);
            angleMin = map(0, 60, 360, 0, DateTime.Now.Minute);
            angleHour = map(0, 12, 360, 0, DateTime.Now.Hour);
            //oxi megali diafora me milliseconds
            //angleMin = map(0, 216000000, 360, 0, DateTime.Now.Millisecond + (DateTime.Now.Second) * 1000
            //    + (DateTime.Now.Minute * 3600000));
            //angleHour = map(0, 2592000000, 360, 0, DateTime.Now.Millisecond + (DateTime.Now.Second) * 1000
            //    + (DateTime.Now.Minute * 3600000)+ (DateTime.Now.Hour * 216000000));
            try
            {
                control.BackColor = System.Drawing.Color.Transparent;
                g = control.CreateGraphics();

                g.DrawLine(pHour, CenterPoint(control), AnglePoint(angleHour, (circleDiameter / 4), 90, control, 0, 0));
                g.DrawLine(pSec, CenterPoint(control), AnglePoint(angleSec, circleDiameter / 2, 90, control, 0, 0));
                g.DrawLine(pMin, CenterPoint(control), AnglePoint(angleMin, (circleDiameter / 2) - 10, 90, control, 0, 0));
                if (DateTime.Now.Second == 0 && DateTime.Now.Millisecond < 100 || firstTime)
                {
                    g.FillEllipse(pFrame.Brush, CenterPoint(control, circleDiameter, circleDiameter).X,
                        CenterPoint(control, circleDiameter, circleDiameter).Y,
                        circleDiameter, circleDiameter);
                    _firstTime = false;
                }
                g.FillEllipse(pCan.Brush, CenterPoint(control, circleDiameter / 12, circleDiameter / 12).X,
                   CenterPoint(control, circleDiameter / 12, circleDiameter / 12).Y,
                   circleDiameter / 12, circleDiameter / 12);
                g.FillEllipse(pCan.Brush, AnglePoint(90, (circleDiameter - 40) / 2, 0, control, circleDiameter / 15, circleDiameter / 15).X,
                    AnglePoint(90, (circleDiameter - 40) / 2, 0, control, circleDiameter / 15, circleDiameter / 15).Y,
                    circleDiameter / 15, circleDiameter / 15);
                g.FillEllipse(pCan.Brush, AnglePoint(180, (circleDiameter - 40) / 2, 0, control, circleDiameter / 15, circleDiameter / 15).X,
                    AnglePoint(180, (circleDiameter - 40) / 2, 0, control, circleDiameter / 15, circleDiameter / 15).Y,
                    circleDiameter / 15, circleDiameter / 15);
                g.FillEllipse(pCan.Brush, AnglePoint(270, (circleDiameter - 40) / 2, 0, control, circleDiameter / 15, circleDiameter / 15).X,
                    AnglePoint(270, (circleDiameter - 40) / 2, 0, control, circleDiameter / 15, circleDiameter / 15).Y,
                    circleDiameter / 15, circleDiameter / 15);
                g.FillEllipse(pCan.Brush, AnglePoint(0, (circleDiameter - 40) / 2, 0, control, circleDiameter / 15, circleDiameter / 15).X,
                    AnglePoint(0, (circleDiameter - 40) / 2, 0, control, circleDiameter / 15, circleDiameter / 15).Y,
                    circleDiameter / 15, circleDiameter / 15);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
    }
}
