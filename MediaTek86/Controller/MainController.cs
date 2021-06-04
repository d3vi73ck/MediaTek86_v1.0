using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.Views;
using MediaTek86.DAL;
namespace MediaTek86.Controller
{
    public class MainController
    {
        #region Forms 
        private LoginForm lg { get; set; }
        private  GestionEmpFrm GEF { get; set; }
        private  GestionAbsenceFrm GAF { get; set; }

        #endregion
        public MainController()
        {
            lg = new LoginForm(this);
            lg.ShowDialog();
        }

        public bool Connect(string login, string password)
        {
            try
            {
                var loginstatus = DBAccess.PerformLogin(login, password);
                if ( loginstatus)
                {
                    GEF = new GestionEmpFrm();
                    GEF.ShowDialog();
                    lg.Hide();
                    return true;
                }
                else
                {
                    // login failed 
                    return false;
                }
            }
            catch (Exception )
            {
                return false;   
            }
        }
    }
}
