using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Threading;

namespace CronometroSolid
{
    public class Crono : DispatcherTimer, ICronometrar
    {
        private int CurrentSecond { get; set; }

        public string ValueCrono => TimeSpan.FromSeconds(CurrentSecond).ToString();

        private Crono()
        {
            CurrentSecond = 0;
        }

        public static Crono Create(EventHandler eventHandler)
        {
            Crono chrono = new Crono
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            chrono.Tick += eventHandler;

            return chrono;
        }

        public void Pause()
        {
            base.Stop();
        }

        public void AddSecond()
        {
            CurrentSecond++;
        }

        public new void Start()
        {
            base.Start();
        }

        public new void Stop()
        {
            base.Stop();
            CurrentSecond = 0;
        }
    }
}
