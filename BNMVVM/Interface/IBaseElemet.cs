using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNMVVM.Interface
{
    public interface IBaseElement
    {
        string Type { get; }
        string Name { get; set; }
        //string Content {  get; set; }
        //RelayCommand OpenCommand {  get; }
    }
}
