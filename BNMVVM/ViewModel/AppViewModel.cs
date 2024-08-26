using BNMVVM.Interface;
using BNMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BNMVVM.Command;
using System.Windows;
//using BNMVVM;


namespace BNMVVM.ViewModel
{/// <summary>
/// Класс модели представления
/// </summary>
    public class AppViewModel : INotifyPropertyChanged
    {
        private IBaseElement? selectedElement;
        /// <summary>
        /// список задач и документов
        /// </summary>
        public ObservableCollection<IBaseElement> Elements { get; set; }
        /// <summary>
        /// Выбранный элемент из списка задач и элементов
        /// </summary>
        public IBaseElement? SelectedElement
        {
            get { return selectedElement; }
            set
            {
                selectedElement = value;
                OnPropertyChanged("SelectedElement");
            }
        }

        public AppViewModel()
        {
            Elements = new ObservableCollection<IBaseElement>
            {
                new Document { ID=1, Name="Оформление кода.doc" },
                new Document { ID=2, Name="Список задач.doc" },
                new Document { ID=3, Name="Заказы.doc" },
                new Goal { ID=1, Name="Оформи код.doc" },
                new Goal { ID=2, Name="Посмотри задачи.doc" },
                new Goal { ID=3, Name="Выполни заказы.doc" },
            };

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
        #region Команды
        /// <summary>
        /// Команда открытия документа или задачи
        /// </summary>
        public RelayCommand OpenCommand
        {
            get
            {
                return new RelayCommand(obj =>
                  {
                      //MessageBox.Show("work");
                      //c
                      if (obj != null)
                      {
                          var e = obj as IBaseElement;
                          selectedElement = e;
                          if (e.Type == "Документ")
                          {
                              DocumentWindow dw = new DocumentWindow(obj as Document);
                              dw.ShowDialog();

                          }
                          else if (e.Type == "Задача") 
                          {
                              GoalWindow gw = new GoalWindow(obj as Goal);
                              gw.ShowDialog();

                          }
                      }
                  },
                 (obj) => obj!=null);
            }
        }
        /// <summary>
        /// Команда подписи документа
        /// </summary>
        public RelayCommand SubscribeCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    //MessageBox.Show("work");
                    //c
                    if (obj != null)
                    {
                        (obj as Document).Signature = Guid.NewGuid();
                    }
                },
                 (obj) => obj!=null);
            }
        }
        /// <summary>
        /// Команда создания нового документа
        /// </summary>
        public RelayCommand NewDocumentCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Document NewDocument = new Document();
                    NewDocument.Name = "Новый документ";
                    Elements.Add(NewDocument);
                    //selectedElement = NewDocument;
                    DocumentWindow dw = new DocumentWindow(NewDocument);
                    dw.ShowDialog();
                },
                 (obj) => true);
            }
        }
        /// <summary>
        /// Команда создания новой задачи
        /// </summary>
        public RelayCommand NewGoalCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Goal NewGoal = new Goal();
                    NewGoal.Name = "Новая задача";
                    Elements.Add(NewGoal);
                    //selectedElement = NewDocument;
                    GoalWindow gw = new GoalWindow(NewGoal);
                    gw.ShowDialog();
                },
                 (obj) => true);
            }
        }
        #endregion
    }
}
