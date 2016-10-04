using FloBot.MemoryClass;
using FloBot.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloBot.Main
{
    class StateMachine
    {
        private mainForm main_form;
        private MemoryClass.MemoryRW mc;


        public StateMachine(mainForm main_form)
        {
            this.main_form = main_form;
            this.mc = new MemoryRW();
            currentState = new FindGameState();
            AddressUtil.setMemoryRW(this.mc);
            new Thread(start_Method).Start();
        }
        private IState currentState;
        private void start_Method()
        {
            while (!main_form.IsDisposed )
            {
                currentState = currentState.doTasks(main_form, mc);
                Thread.Sleep(1000);
            }
                
        }
    }
}
