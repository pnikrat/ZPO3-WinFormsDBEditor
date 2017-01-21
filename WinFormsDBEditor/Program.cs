using System;
using System.Windows.Forms;
using WinFormsDBEditor.Presenter;

namespace WinFormsDBEditor {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainView view = new MainView();
            MainPresenter presenter = new MainPresenter(view);
            
            Application.Run(view);
        }
    }
}
