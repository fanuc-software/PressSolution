using GalaSoft.MvvmLight.Ioc;
using AutoMapper;
using PressHmi.ViewModel;
using FanucCnc;
using PressHmi.Roles;

namespace PressHmi.App_Start
{
    public class IocConfig
    {
        public static void Register()
        {
            SimpleIoc.Default.Register<IMapper>(() => AutoMapperConfig.GetMapperConfiguration().CreateMapper());

            //fanuc
            SimpleIoc.Default.Register<Fanuc>(() => Fanuc.CreateInstance());

            //role
            SimpleIoc.Default.Register<Role>(() => Role.CreateInstance());



            SimpleIoc.Default.Register<MainWindowViewModel>();
            SimpleIoc.Default.Register<StateMonitorPageViewModel>();

            SimpleIoc.Default.Register<ParaMainPageViewModel>();
            SimpleIoc.Default.Register<ParaSubDieChangePageViewModel>();
            SimpleIoc.Default.Register<ParaSubDieClosingPageViewModel>();
            SimpleIoc.Default.Register<ParaSubDiePartingPageViewModel>();
            SimpleIoc.Default.Register<ParaSubPressureMaintPageViewModel>();
            SimpleIoc.Default.Register<ParaSubAutoAirSourcePageViewModel>();
            SimpleIoc.Default.Register<ParaSubWorkCountPageViewModel>();
            SimpleIoc.Default.Register<ParaSubDieClampPageViewModel>();
            SimpleIoc.Default.Register<ParaSubProcManagementPageViewModel>();

            SimpleIoc.Default.Register<MessageMainPageViewModel>();

            SimpleIoc.Default.Register<MaintainMainPageViewModel>();
            SimpleIoc.Default.Register<MaintainSubLimitPageViewModel>();


            SimpleIoc.Default.Register<SystemMainPageViewModel>();

            SimpleIoc.Default.Register<SParaMainPageViewModel>();
            SimpleIoc.Default.Register<SParaSubMachinePageViewModel>();
            SimpleIoc.Default.Register<SParaSubLubricatePageViewModel>();
            SimpleIoc.Default.Register<SParaSubAnalogPageViewModel>();
            SimpleIoc.Default.Register<SParaSubEncodePageViewModel>();
        }

    }
}
