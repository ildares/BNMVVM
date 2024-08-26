using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BNMVVM.Interface;

namespace BNMVVM.Model
{
    /// <summary>
    /// Класс документа
    /// </summary>
    public class Document : INotifyPropertyChanged, IBaseElement
    {
        private int? id;
        private string name = string.Empty;
        private string content = string.Empty;
        private Guid? signature = null;

        public string Type
        {
            get
            {
                return "Документ";
            }
        }

        public int? ID
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

        public Guid? Signature
        {
            get { return signature; }
            set
            {
                signature = value;
                OnPropertyChanged("Signature");
            }
        }
        /// <summary>
        /// Делегат метода, который будет обрабатывать событие PrpertyChanged
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
