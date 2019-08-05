using Game.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Model.Logic model = new Model.Logic();
            View.View view = new View.View();
            Presenter.Presenter presenter = new Presenter.Presenter(model, view.obiekt);

            Application.Run((Form)view);
            //Application.Run(new View.View());
        }
    }
}
