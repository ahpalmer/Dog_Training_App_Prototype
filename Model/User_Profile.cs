using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_Training_App_Prototype
{
    public struct skill_identifier
    {
        public string Name;
        public DateTime? Start_Date;
        public bool skill_selected;
    }

    internal class User_Profile
    {
        private string username;
        private string password;
        skill_identifier sit = new skill_identifier();
        skill_identifier lay_down = new skill_identifier();
        skill_identifier come = new skill_identifier();

        internal User_Profile(string user, string pass)
        {
            username = user;
            password = pass;
            sit.Name = "Sit";
            sit.skill_selected = false;
            lay_down.Name = "Lay Down";
            lay_down.skill_selected = false;
            come.Name = "Come";
            come.skill_selected = false;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set {  password = value; }
        }

        #region set skills true/false
        public void set_sit_bool(bool sit)
        {
            this.sit.skill_selected = sit;
            this.sit.Start_Date = DateTime.Now;
        }
        public void set_lay_bool(bool sit)
        {
            this.lay_down.skill_selected = sit;
            this.lay_down.Start_Date= DateTime.Now;
        }
        public void set_come_bool(bool sit)
        {
            this.come.skill_selected = sit;
            this.lay_down.Start_Date = DateTime.Now;
        }
        #endregion
    }
}
