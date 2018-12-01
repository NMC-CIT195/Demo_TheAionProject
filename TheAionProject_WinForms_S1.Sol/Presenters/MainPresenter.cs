using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAionProject.Views;
using TheAionProject.Assets;

namespace TheAionProject.Presenters
{
    public class MainPresenter
    {
        MainForm _mainForm;

        public MainPresenter()
        {

        }

        public MainPresenter(MainForm maigForm)
        {
            _mainForm = maigForm;
            InitializeMainForm();
        }

        private void InitializeMainForm()
        {

        }
    }
}
