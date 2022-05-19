using System.Collections.Generic;

namespace TicTacToeMVC
{
    public interface IView
    {
        void ShowBoard();

        void InvalidOption();


        int AskForMove();

        int AskForView();

    }
}