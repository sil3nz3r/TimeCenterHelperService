using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TimeCenterHelper
{
    public partial class TimeCenterHelperService : ServiceBase
    {
        private readonly string sourceName = "TimeCenterHelper";
        private readonly string logName = "TimeCenterHelperLog";

        public TimeCenterHelperService()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists(sourceName))
            {
                System.Diagnostics.EventLog.CreateEventSource(sourceName, logName);
            }
            TimeCenterEventLog.Source = sourceName;
            TimeCenterEventLog.Log = logName;
        }

        protected override void OnStart(string[] args)
        {
            TimeCenterEventLog.WriteEntry("In OnStart");
            forms
        }

        protected override void OnContinue()
        {
            TimeCenterEventLog.WriteEntry("In OnContinue.");
        }

        protected override void OnStop()
        {
            TimeCenterEventLog.WriteEntry("In OnStop");
        }
    }
}
