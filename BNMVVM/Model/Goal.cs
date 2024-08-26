using BNMVVM.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BNMVVM.Common;

namespace BNMVVM.Model
{
 
    public class Goal : INotifyPropertyChanged, IBaseElement
    {
        private int id;
        private string name = string.Empty;
        private string content = string.Empty;
        private GoalStatusEnum status;

        public string Type
        {
            get
            {
                return "Задача";
            }
        }
        public int ID
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("ID");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                OnPropertyChanged("Content");
            }
        }

        public GoalStatusEnum Status
        {
            get { return status; }
            set
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        /*private RelayCommand openCommand;
        public RelayCommand OpenCommand
        {
            get
            {
                return openCommand ??
                  (openCommand = new RelayCommand(obj =>
                  {
                      GoalWindow dw = new GoalWindow(obj as Goal);
                      dw.Show();
                  },
                 (obj) => true));
            }
        }*/
    }
}
