using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Ioc;
using AutoMapper;
using PressHmi.Model;
using PressHmi.View;
using FanucCnc;
using FanucCnc.Model;

namespace PressHmi.ViewModel
{
    public class SParaSubEncodePageViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadedCommand { get; set; }
        public ICommand UnloadedCommand { get; set; }

        public ICommand IM_RESOLUTIONSetCmd { get; set; }
        public ICommand IM_MOVEPITCHSetCmd { get; set; }
        public ICommand IM_UPPOSITIONSetCmd { get; set; }
        public ICommand IM_DOWNPOSITIONSetCmd { get; set; }
        public ICommand IM_SPEEDCHANGEPOSITIONSetCmd { get; set; }
        public ICommand IM_LIMITUPSetCmd { get; set; }
        public ICommand IM_LIMITDOWNSetCmd { get; set; }
        public ICommand IM_ERRORSetCmd { get; set; }
        public ICommand IM_DIRECTIONSetCmd { get; set; }
        public ICommand AC_RESOLUTIONSetCmd { get; set; }
        public ICommand AC_MOVEPITCHSetCmd { get; set; }
        public ICommand AC_UPPOSITIONSetCmd { get; set; }
        public ICommand AC_DOWNPOSITIONSetCmd { get; set; }
        public ICommand AC_LIMITUPSetCmd { get; set; }
        public ICommand AC_LIMITDOWNSetCmd { get; set; }
        public ICommand AC_ERRORSetCmd { get; set; }
        public ICommand AC_DIRECTIONSetCmd { get; set; }

        private SParaEncodeInfoDto m_SParaEncodeInfo = new SParaEncodeInfoDto();
        public SParaEncodeInfoDto SParaEncodeInfo
        {
            get { return m_SParaEncodeInfo; }
            set
            {
                if (m_SParaEncodeInfo != value)
                {
                    m_SParaEncodeInfo = value;
                    RaisePropertyChanged(() => SParaEncodeInfo);
                }
            }
        }

        public SParaSubEncodePageViewModel(IMapper mapper, Fanuc fanuc)
        {
            _fanuc = fanuc;
            _mapper = mapper;

            LoadedCommand = new RelayCommand(OnLoaded);
            UnloadedCommand = new RelayCommand(OnUnloaded);

            IM_RESOLUTIONSetCmd = new RelayCommand(OnIM_RESOLUTIONSetCmd);
            IM_MOVEPITCHSetCmd = new RelayCommand(OnIM_MOVEPITCHSetCmd);
            IM_UPPOSITIONSetCmd = new RelayCommand(OnIM_UPPOSITIONSetCmd);
            IM_DOWNPOSITIONSetCmd = new RelayCommand(OnIM_DOWNPOSITIONSetCmd);
            IM_SPEEDCHANGEPOSITIONSetCmd = new RelayCommand(OnIM_SPEEDCHANGEPOSITIONSetCmd);
            IM_LIMITUPSetCmd = new RelayCommand(OnIM_LIMITUPSetCmd);
            IM_LIMITDOWNSetCmd = new RelayCommand(OnIM_LIMITDOWNSetCmd);
            IM_ERRORSetCmd = new RelayCommand(OnIM_ERRORSetCmd);
            IM_DIRECTIONSetCmd = new RelayCommand(OnIM_DIRECTIONSetCmd);
            AC_RESOLUTIONSetCmd = new RelayCommand(OnAC_RESOLUTIONSetCmd);
            AC_MOVEPITCHSetCmd = new RelayCommand(OnAC_MOVEPITCHSetCmd);
            AC_UPPOSITIONSetCmd = new RelayCommand(OnAC_UPPOSITIONSetCmd);
            AC_DOWNPOSITIONSetCmd = new RelayCommand(OnAC_DOWNPOSITIONSetCmd);
            AC_LIMITUPSetCmd = new RelayCommand(OnAC_LIMITUPSetCmd);
            AC_LIMITDOWNSetCmd = new RelayCommand(OnAC_LIMITDOWNSetCmd);
            AC_ERRORSetCmd = new RelayCommand(OnAC_ERRORSetCmd);
            AC_DIRECTIONSetCmd = new RelayCommand(OnAC_DIRECTIONSetCmd);

            Messenger.Default.Register<SParaEncodeInfo>(this, "SParaEncodeInfoMsg", msg =>
            {
                SParaEncodeInfo = _mapper.Map<SParaEncodeInfo, SParaEncodeInfoDto>(msg);
            });

        }

        private void OnLoaded()
        {
            _fanuc.ChangePageEvent(sparaencode: true);
        }

        private void OnUnloaded()
        {

        }

        private void OnIM_RESOLUTIONSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_IM_RESOLUTION,
                    _fanuc.CurLimitBom.SPA_IM_RESOLUTION,
                    "装模高度编码器设置--每圈分辨率");
            dlg.ShowDialog();
        }

        private void OnIM_MOVEPITCHSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_IM_MOVEPITCH,
                    _fanuc.CurLimitBom.SPA_IM_MOVEPITCH,
                    "装模高度编码器设置--每圈移动量mm");
            dlg.ShowDialog();
        }

        private void OnIM_UPPOSITIONSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_IM_UPPOSITION,
                    _fanuc.CurLimitBom.SPA_IM_UPPOSITION,
                    "装模高度编码器设置--上升达到范围mm");
            dlg.ShowDialog();

        }

        private void OnIM_DOWNPOSITIONSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_IM_DOWNPOSITION,
                    _fanuc.CurLimitBom.SPA_IM_DOWNPOSITION,
                    "装模高度编码器设置-下降达到范围mm");
            dlg.ShowDialog();

        }
        private void OnIM_SPEEDCHANGEPOSITIONSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_IM_SPEEDCHANGEPOSITION,
                    _fanuc.CurLimitBom.SPA_IM_SPEEDCHANGEPOSITION,
                    "装模高度编码器设置-速度切换点mm");
            dlg.ShowDialog();
        }
        private void OnIM_LIMITUPSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_IM_LIMITUP,
                    _fanuc.CurLimitBom.SPA_IM_LIMITUP,
                    "装模高度编码器设置--模高上限mm");
            dlg.ShowDialog();
        }
        private void OnIM_LIMITDOWNSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_IM_LIMITDOWN,
                    _fanuc.CurLimitBom.SPA_IM_LIMITDOWN,
                    "装模高度编码器设置--模高下限mm");
            dlg.ShowDialog();
        }
        private void OnIM_ERRORSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_IM_ERROR,
                    _fanuc.CurLimitBom.SPA_IM_ERROR,
                    "装模高度编码器设置--偏差值mm");
            dlg.ShowDialog();
        }
        private void OnIM_DIRECTIONSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_IM_DIRECTION,
                    _fanuc.CurLimitBom.SPA_IM_DIRECTION,
                    "装模高度编码器设置--编码器方向");
            dlg.ShowDialog();
        }

        private void OnAC_RESOLUTIONSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_AC_RESOLUTION,
                    _fanuc.CurLimitBom.SPA_AC_RESOLUTION,
                    "气垫高度编码器设置--每圈分辨率");
            dlg.ShowDialog();
        }

        private void OnAC_MOVEPITCHSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_AC_MOVEPITCH,
                    _fanuc.CurLimitBom.SPA_AC_MOVEPITCH,
                    "气垫高度编码器设置--每圈移动量mm");
            dlg.ShowDialog();
        }

        private void OnAC_UPPOSITIONSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_AC_UPPOSITION,
                    _fanuc.CurLimitBom.SPA_AC_UPPOSITION,
                    "气垫高度编码器设置--上升达到范围mm");
            dlg.ShowDialog();

        }

        private void OnAC_DOWNPOSITIONSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_AC_DOWNPOSITION,
                    _fanuc.CurLimitBom.SPA_AC_DOWNPOSITION,
                    "气垫高度编码器设置-下降达到范围mm");
            dlg.ShowDialog();

        }
        private void OnAC_LIMITUPSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_AC_LIMITUP,
                    _fanuc.CurLimitBom.SPA_AC_LIMITUP,
                    "气垫高度编码器设置--模高上限mm");
            dlg.ShowDialog();
        }
        private void OnAC_LIMITDOWNSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_AC_LIMITDOWN,
                    _fanuc.CurLimitBom.SPA_AC_LIMITDOWN,
                    "气垫高度编码器设置--模高下限mm");
            dlg.ShowDialog();
        }
        private void OnAC_ERRORSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_AC_ERROR,
                    _fanuc.CurLimitBom.SPA_AC_ERROR,
                    "气垫高度编码器设置--偏差值mm");
            dlg.ShowDialog();
        }
        private void OnAC_DIRECTIONSetCmd()
        {
            var dlg = new DataInputDialog(_fanuc,
                    _fanuc.CurPmcBom.SPA_AC_DIRECTION,
                    _fanuc.CurLimitBom.SPA_AC_DIRECTION,
                    "气垫高度编码器设置--编码器方向");
            dlg.ShowDialog();
        }

    }

}
