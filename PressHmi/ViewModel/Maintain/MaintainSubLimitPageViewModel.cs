using FanucCnc;
using FanucCnc.Model;
using GalaSoft.MvvmLight;
using Newtonsoft.Json;
using PressHmi.Model;
using PressHmi.View;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PressHmi.ViewModel
{
    public class MaintainSubLimitPageViewModel : ViewModelBase
    {

        public List<MaintainSubLimitDto> LimitNodes { get; set; }
        Fanuc fanuc;

        public event Action<Fanuc, MaintainSubLimitDto> ShowLimitWindowEvent;
        public MaintainSubLimitPageViewModel(Fanuc fanuc)
        {
            this.fanuc = fanuc;
            LoadData();
        }

        public ICommand SaveCommand
        {
            get { return new GalaSoft.MvvmLight.Command.RelayCommand(SaveConfig); }
        }
        private void SaveConfig()
        {
            var type = fanuc.CurLimitBom.GetType();
            foreach (PropertyInfo item in type.GetProperties())
            {
                var limit = item.GetValue(fanuc.CurLimitBom) as LimitBomItem;
                if (limit == null)
                {
                    limit = new LimitBomItem();
                    item.SetValue(fanuc.CurLimitBom, limit);
                }
                var prop = LimitNodes.FirstOrDefault(d => d.PropertyName == item.Name);
                if (prop != null)
                {
                    limit.LimitUp = prop.LimitUp;
                    limit.LimitDown = prop.LimitDown;
                }
               

            }
            var jsonLimitBom = JsonConvert.SerializeObject(fanuc.CurLimitBom, Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(@"limitbom.cfg", false))
            {
                sw.Write(jsonLimitBom);
            }

        }
        private void LoadData()
        {
            var type = fanuc.CurLimitBom.GetType();
            LimitNodes = new List<MaintainSubLimitDto>();
            foreach (PropertyInfo item in type.GetProperties())
            {
                var attributes = item.GetCustomAttribute<DisplayAttribute>();

                if (attributes != null && (attributes.GetAutoGenerateField() ?? true))
                {
                    var limit = item.GetValue(fanuc.CurLimitBom) as LimitBomItem;
                    if (limit == null)
                    {
                        continue;
                    }
                    var node = new MaintainSubLimitDto()
                    {
                        PropertyName = item.Name,
                        Title = attributes.Name,
                        LimitUp = limit.LimitUp ?? 0,
                        LimitDown = limit.LimitDown ?? 0
                    };
                    node.ShowLimitWindowEvent += Node_ShowLimitWindowEvent;
                    LimitNodes.Add(node);
                }

            }
         
        }

        private void Node_ShowLimitWindowEvent(MaintainSubLimitDto obj)
        {
            ShowLimitWindowEvent?.Invoke(fanuc, obj);
        }
    }
}
