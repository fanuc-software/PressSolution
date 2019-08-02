using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using FanucCnc;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using FanucCnc.Model;
using System.IO;
using Newtonsoft.Json;

namespace PressHmi.ViewModel
{

    public class SystemMacroViewModel
    {

        public List<SystemMacroItemViewModel> MacroNodes { get; set; }
        Fanuc fanuc;
        public SystemMacroViewModel(Fanuc fanuc)
        {
            MacroNodes = new List<SystemMacroItemViewModel>();
            this.fanuc = fanuc;
            this.LoadData();
        }
        public ICommand SaveCommand
        {
            get { return new GalaSoft.MvvmLight.Command.RelayCommand(SaveConfig); }
        }
        private void SaveConfig()
        {
            var type = fanuc.CurMacroBom.GetType();
            foreach (PropertyInfo item in type.GetProperties())
            {
                var limit = item.GetValue(fanuc.CurMacroBom) as MacroBomItem;
                if (limit == null)
                {
                    limit = new MacroBomItem();
                    item.SetValue(fanuc.CurMacroBom, limit);
                }
                var prop = MacroNodes.FirstOrDefault(d => d.PropertyName == item.Name);
                if (prop != null)
                {
                    limit.Adr = prop.Address;
                }


            }
            var jsonLimitBom = JsonConvert.SerializeObject(fanuc.CurMacroBom, Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(@"macrobom.cfg", false))
            {
                sw.Write(jsonLimitBom);
            }

        }
        private void LoadData()
        {
            var type = fanuc.CurMacroBom.GetType();
            foreach (PropertyInfo item in type.GetProperties())
            {
                var attributes = item.GetCustomAttribute<DisplayAttribute>();

                if (attributes != null && (attributes.GetAutoGenerateField() ?? true))
                {
                    var limit = item.GetValue(fanuc.CurMacroBom) as MacroBomItem;
                    if (limit == null)
                    {
                        continue;
                    }
                    var node = new SystemMacroItemViewModel()
                    {
                        PropertyName = item.Name,
                        Title = attributes.Name,
                        Address = limit?.Adr ?? 0
                    };
                    node.ShowDialogEvent += Node_ShowDialogEvent;
                    MacroNodes.Add(node);
                }

            }
        }

        public event Action<SystemMacroItemViewModel> ShowDialogWindowEvent;
        private void Node_ShowDialogEvent(SystemMacroItemViewModel arg1)
        {
            ShowDialogWindowEvent?.Invoke(arg1);
        }
    }
    public class SystemMacroItemViewModel : ViewModelBase
    {

        public string PropertyName { get; set; }
        public string Title { get; set; }

        private short address;

        public short Address
        {
            get { return address; }
            set
            {
                if (address != value)
                {
                    address = value;
                    RaisePropertyChanged(() => Address);
                }
            }
        }

        public ICommand ShowDialogCommand
        {

            get
            {
                return new RelayCommand(() =>
                {
                    ShowDialogEvent?.Invoke(this);
                });
            }
        }

        public event Action<SystemMacroItemViewModel> ShowDialogEvent;

    }
}
