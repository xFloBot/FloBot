using FloBot.MemoryClass;
using FloBot.Model;
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
        private Player player;
        private Thread botThread;
        public StateMachine(mainForm main_form,Player player)
        {
            this.main_form = main_form;
            this.mc = new MemoryRW();
            this.player = player;
            currentState = new FindGameState();
            AddressUtil.setMemoryRW(this.mc);
            botThread = new Thread(start_Method);
            botThread.Start();
        }

        public void endBotThread()
        {
            botThread.Abort();
        }

        private IState currentState;
        private void start_Method()
        {
            while (!main_form.IsDisposed )
            {
                currentState = currentState.doTasks(main_form, mc, player);
                Thread.Sleep(100);
            }
                
        }
    }
}
