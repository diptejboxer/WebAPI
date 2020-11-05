using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Common
{
    public class SwaggerConfig
    {
        public const string EndPointDescription = "Mobile API V1";



#if DEBUG
        public static readonly string EndpointUrl = Environment.GetEnvironmentVariable("ProfilePathType");
#else
        public const string EndpointUrl = "/MobileAPI/swagger/v1/swagger.json";
#endif


    }
}
