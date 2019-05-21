using AutoMapper;
using DataCenter.Entities;
using DataCenter.Model;

namespace DataCenter
{
    public class PressModuleInitializer : ModuleInitializer
    {
        /// <summary>
        /// 加载AutoMapper配置
        /// </summary>
        public override void LoadMapper(IMapperConfigurationExpression config)
        {
            config.CreateMap<RoleInfo, RoleInfoDto>().ReverseMap();
        }

    }
}
