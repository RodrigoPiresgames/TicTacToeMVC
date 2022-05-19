using System;
using System.Collections.Generic;

namespace TicTacToeMVC
{
    abstract class DefaultView : IView
    {
        private Controller controller;

        public DefaultView(Controller controller)
        {
            this.controller = controller;
        }

        public abstract void ShowBoard();

        public abstract void InvalidOption();
        
        public abstract int AskForMove();
        

        public int AskForView()
        {

        }
        
    }
}