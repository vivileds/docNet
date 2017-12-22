using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPim
{
    public class PIM
    {
        private PimState state = PimState.Deconnecter;
        private PimState State
        {
            get { return this.state; }
            set {
                OnPimStateChanged(value); }
        }

        public event PimStateEventHandler PimStateChanged;
        public delegate void PimStateEventHandler(object sender, PimState state);

        private void OnPimStateChanged(PimState newState)
        {
            if (newState != this.state)
            {
                this.state = newState;
                if (this.PimStateChanged != null)
                {
                    PimStateChanged(this, this.state);
                }
            }
        }


    }






}
