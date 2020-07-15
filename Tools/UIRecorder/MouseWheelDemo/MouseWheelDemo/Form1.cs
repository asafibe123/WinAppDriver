using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;


namespace MouseWheelDemo
{
    public partial class Form1 : Form
    {
        int _totalDelta = 0;

        public Form1()
        {
            InitializeComponent();
            this.MouseWheel += Form_MouseWheel;
        }

        void Form_MouseWheel(object sender, MouseEventArgs e)
        {
            _totalDelta = _totalDelta + e.Delta;
            DeltaLabel.Text = e.Delta.ToString();
            TotalDeltaLabel.Text = _totalDelta.ToString();
            LinesLabel.Text = (SystemInformation.MouseWheelScrollLines * _totalDelta / 120).ToString();
        }

        void ReadEventXml (string[] _log)
        {
            String logName = "Application";
            String queryString = "*[System/Level=2]";

            EventLogQuery eventsQuery = new EventLogQuery(logName,
                PathType.LogName, queryString);

            EventLogReader logReader;
            Console.WriteLine("Querying the Application channel event log for all events...");
            try
            {
                // Query the log and create a stream of selected events
                logReader = new EventLogReader(eventsQuery);
            }
            catch (EventLogNotFoundException e)
            {
                Console.WriteLine("Failed to query the log!");
                Console.WriteLine(e);
                return;
            }

            int numberOfEvents = 0;
            // For each event returned from the query
            for (EventRecord eventInstance = logReader.ReadEvent();
                    eventInstance != null;
                    eventInstance = logReader.ReadEvent())
            {
                String eventXml = eventInstance.ToXml();
                Console.WriteLine("Event " + (++numberOfEvents) + " : " + System.Environment.NewLine + eventXml);
                Console.WriteLine("---------------------------------");
                //Console.ReadLine();
            }
        }
    }
}

