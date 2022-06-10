using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;


namespace Dog_Training_App_Prototype
{
    public class SkillIdentifier : INotifyPropertyChanged
    {
        private string _name;

        #region Properties
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
                }
            }
        }

        private DateTime? _startDate;
        public DateTime? startDate
        {
            get { return _startDate; }
            set
            {
                if (_startDate != value)
                {
                    _startDate = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(startDate)));
                }
            }
        }

        private bool _skillSelected;
        public bool skillSelected
        {
            get { return _skillSelected; }
            set
            {
                if(_skillSelected != value)
                {
                    _skillSelected = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(skillSelected)));
                }
            }
        }
        #endregion

        #region Constructor
        public SkillIdentifier(string name)
        {
            _name = name;
            startDate = DateTime.Now;
            skillSelected = false;
        }
        #endregion

        public event PropertyChangedEventHandler? PropertyChanged;
    }

    public class UserProfile : INotifyPropertyChanged
    {
        private string _password;
        public SkillIdentifier sit { get; set; }
        public SkillIdentifier layDown { get; set; } 
        public SkillIdentifier come { get; set; }

        internal UserProfile(string user, string pass)
        {
            Username = user;
            _password = pass;

            sit = new SkillIdentifier("sit");
            layDown = new SkillIdentifier("laydown");
            come = new SkillIdentifier("come");

        }

        public string Username { get; }

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    /*if (PropertyChanged is not null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs(nameof(Password)));
                    }*/
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Password)));
                }
            }
        }

        #region set skills true/false
        public void set_sit_bool(bool sit)
        {
            this.sit.skillSelected = sit;
            this.sit.startDate = DateTime.Now;
        }
        public void set_lay_bool(bool sit)
        {
            this.layDown.skillSelected = sit;
            this.layDown.startDate= DateTime.Now;
        }
        public void set_come_bool(bool sit)
        {
            this.come.skillSelected = sit;
            this.layDown.startDate = DateTime.Now;
        }
        #endregion

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
