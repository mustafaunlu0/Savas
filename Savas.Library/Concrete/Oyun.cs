using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Savas.Library.Enum;
using Savas.Library.Interface;

namespace Savas.Library.Concrete
{
    public class Oyun : IOyun
    {
        #region Alanlar
        private readonly Timer _gecenSureTimer = new Timer { Interval = 1000 };
        private TimeSpan _gecenSure;
        #endregion

        #region Olaylar
        public event EventHandler GecenSureDegisti;
        #endregion

        #region Özellikler
        public bool DevamEdiyorMu { get; private set; }

        public TimeSpan GecenSure {
            get => _gecenSure;
            private set 
            {
                _gecenSure = value;
                GecenSureDegisti?.Invoke(this, EventArgs.Empty);
            } 
        }
        #endregion

        #region Metotlar

       
        public Oyun()
        {
            _gecenSureTimer.Tick += _gecenSureTimer_Tick;//ilişkilendirme işlemi
        }

        private  void _gecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
        }
        public void AtesEt()
        {
            throw new NotImplementedException();
        }

        private void Bitir()
        {
            if (!DevamEdiyorMu) return;
            
            DevamEdiyorMu = false;
            _gecenSureTimer.Stop();
        }

        public void Baslat()
        {
            if (DevamEdiyorMu) return;

            DevamEdiyorMu = true;
            _gecenSureTimer.Start();
        }

        public void UcakSavariHareketEttir(Yon yon)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
