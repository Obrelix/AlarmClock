using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    //Κλάση για να ικανοποιεί τις συνθήκες των ξυπνητηριών σύμφωνα με τις ανάγκες του προγράμματος
    public class Alarms
    {
        //Ιδιότητα που κρατάει το μήνυμα του ξυπνητηριού
        public string Info { get; set; }
        
        //Ιδιότητα που κρατάει την ημερομηνία του ξυπνητηριού
        public DateTime Date { get; set; }

        //Ιδιότητα που κρατάει το Path απο το MediaS
        private string _videoPath = string.Empty;
        public string VideoPath
        {
            get { return _videoPath; }
            set { _videoPath = (value == string.Empty) ? (Application.StartupPath + "\\Alarm.wav") : value; }
        }

        //Ιδιότητα που κρατάει το Mode του ξυπνητηριού Σε μορφή ακεραίου
        public int Mode { get; set; }

        //Ιδιότητα που κρατάει το Mode του ξυπνητηριού Σε μορφή ακεραίου
        public int ModeValue { get; set; }

        //Ιδιότητα που κρατάει το Mode του ξυπνητηριού Σε μορφή String
        public string ModeDescr { get; set; }
        
        //Ιδιότητα που επιστρέφει την ώρα από την ημερομηνία 
        public int Hours
        {
            get { return Date.Hour; }
        }

        //Ιδιότητα που επιστρέφει τα λεπτά από την ημερομηνία 
        public int Minutes
        {
            get { return Date.Minute; }
        }

        //Ιδιότητα που επιστρέφει τα δευτερόλεπτα από την ημερομηνία 
        public int Seconds
        {
            get { return Date.Second; }
        }

        //Ιδιότητα που κρατάει το διάστημα μέχρι την ενεργοποίηση του ξυπνητηριού
        public TimeSpan TmSp { get; set; }

        //Ιδιότητα που επιστρέφει τα όλικά δευτερόλεπτα μέχρι την ενεργοποίηση του ξυπνητηριού
        public double TSTotalSeconds
        {
            get { return TmSp.TotalSeconds; }
        }

        // Μέθοδο που προσθέτει εβδομάδες στην ημερομηνία
        public void AddWeeks(double weeks)
        {
            Date = Date.AddDays(weeks*7.0);
        }

        // Μέθοδο που προσθέτει μέρες στην ημερομηνία
        public void AddDays(double days)
        {
            Date = Date.AddDays(days);
        }

        // Μέθοδο που προσθέτει ώρες στην ημερομηνία
        public void AddHours(double hours)
        {
            Date = Date.AddHours(hours);
        }

        // Μέθοδο που προσθέτει λεπτά στην ημερομηνία
        public void AddMinutes(double minutes)
        {
            Date = Date.AddMinutes(minutes);
        }

        // Μέθοδο που προσθέτει δευτερόλεπτά στην ημερομηνία
        public void AddSeconds(double seconds)
        {
            Date = Date.AddSeconds(seconds);
        }

        public static void AddExtraTime(Alarms obj)
        {
            switch (obj.Mode)
            {
                case 0:
                    obj.AddWeeks(obj.ModeValue);
                    break;
                case 1:
                    obj.AddDays(obj.ModeValue);
                    break;
                case 2:
                    obj.AddHours(obj.ModeValue);
                    break;
                case 3:
                    obj.AddMinutes(obj.ModeValue);
                    break;
                case 4:
                    obj.AddSeconds(obj.ModeValue);
                    break;
            }
        }


        //βασικός contsractor κενός
        public Alarms()
        {

        }

        //constractor με 2 ορίσματα
        public Alarms(string inf, DateTime dt)
        {
            Info = inf;
            Date = dt;
        }

        //constractor με 3 ορίσματα
        public Alarms(string inf, DateTime dt, string VP)
        {
            Info = inf;
            Date = dt;
            VideoPath = VP;
        }
        public Alarms(string inf, DateTime dt, string VP, int md, string descr, int mdv)
        {
            Info = inf;
            Date = dt;
            VideoPath = VP;
            Mode = md;
            ModeValue = mdv;
            ModeDescr = descr;
        }



        //Κάνε Override την μέθοδο ToString που κληρονόμησε η υπαρχουσα κλάση
        public override string ToString()
        {
                //επέστρεψε σε string format όλες τις ιδιότητες της κλάσης σύμφωνα με την παρακάτω μορφή
                return String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", 
                    "Message:", Info, 
                    "     Date:", Date.ToShortDateString(), 
                    "     Time:", Date.ToLongTimeString(), 
                    "     Repeat Every:",ModeValue+" "+ModeDescr,
                    "     Media:", VideoPath);
            

        }
    }
}
