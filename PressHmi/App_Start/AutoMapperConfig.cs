using AutoMapper;

namespace PressHmi.App_Start
{
    public class AutoMapperConfig
    {
        private static MapperConfiguration _mapperConfiguration;

        /// <summary>
        /// 注册模块
        /// </summary>
        public static void Register()
        {

            _mapperConfiguration = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<MainTitleInfo, MainTitleInfoDto>();
            });
        }

        /// <summary>
        /// 获取配置
        /// </summary>
        /// <returns></returns>
        public static MapperConfiguration GetMapperConfiguration()
        {
            if (_mapperConfiguration == null)
                Register();

            return _mapperConfiguration;
        }
    }
}
