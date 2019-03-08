using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using zofnouCommon;

namespace zofnouApi.Controllers
{
    public class ZofnouController : ApiController
    {
        /// <summary>
        /// 测试
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public string Ge11t(string id)
        {
            LogHelper.Info(id+"11111");
            return "value";
        }
    }
}
