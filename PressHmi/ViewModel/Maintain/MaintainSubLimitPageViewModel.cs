using FanucCnc;
using FanucCnc.Model;
using GalaSoft.MvvmLight;
using PressHmi.Model;
using PressHmi.View;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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

        public void ShowInputWindow()
        {

           // var dlg = new MacroDataInputDialog(fanuc, _fanuc.CurMacroBom.DJP_StopTime_3, _fanuc.CurLimitBom.DJP_StopTime_3, "输入P3停止时间(s)");
         //   dlg.ShowDialog();
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
                    var node = new MaintainSubLimitDto()
                    {
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
            ShowLimitWindowEvent?.Invoke(fanuc,obj);
        }
    }
}
