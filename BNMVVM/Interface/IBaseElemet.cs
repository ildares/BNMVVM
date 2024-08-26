using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNMVVM.Interface
{
    /// <summary>
    /// Интерфейс базового элемента списка
    /// </summary>
    public interface IBaseElement
    {
        /// <summary>
        /// Тип базового элемента
        /// </summary>
        string Type { get; }
        /// <summary>
        /// Имя базового элемента
        /// </summary>
        string Name { get; set; }
        //string Content {  get; set; }
        //RelayCommand OpenCommand {  get; }
    }
}
