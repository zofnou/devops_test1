using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zofnouCommon
{
    /// <summary>
    /// 日志辅助类
    /// </summary>
    public class LogHelper
    {
        private static log4net.ILog log = null;
        static LogHelper()
        {
            log = log4net.LogManager.GetLogger("zofnouApi");
        }

        private static LogMessage CreateEntity(object message)
        {
            if (message is LogMessage) return (LogMessage)message;
            var entity = new LogMessage()
            {
                Message = (string)message,
                UserId = "123456",
                KeyId = "abcde",
                LogType = 0,
                No = "1000"
            };
            return entity;
        }

        /// <summary>
        /// 普通日志
        /// </summary>
        /// <param name="content"></param>
        public static void Info(object content)
        {
            try
            {
                log.Info(content);
                log.Info(content);
                log.Info(content);
                log.Info(content);
                log.Info(content);
                log.Info(content);
                log.Info(content);
                log.Info(content);
                log.Info(content);
                log.Info(content);
                log.Info(content);
                //Debug(content, new Exception {});
                //Error(content, new Exception { });
                //Fatal(content, new Exception { });
                //Warn(content, new Exception { });
            }
            catch (Exception ex){
                string msg = ex.ToString();
            }
        }

        /// <summary>
        /// 调试日志
        /// </summary>
        /// <param name="content"></param>
        public static void Debug(object content, Exception ex = null)
        {
            try
            {
                log.Debug(CreateEntity(content), ex);
            }
            catch { }
        }

        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="content"></param>
        public static void Error(object content, Exception ex = null)
        {
            try
            {
                log.Error(CreateEntity(content), ex);
            }
            catch { }
        }

        /// <summary>
        /// 严重错误日志
        /// </summary>
        /// <param name="content"></param>
        public static void Fatal(object content, Exception ex = null)
        {
            try
            {
                log.Fatal(CreateEntity(content), ex);
            }
            catch { }
        }

        /// <summary>
        /// 警告日志
        /// </summary>
        /// <param name="content"></param>
        public static void Warn(object content, Exception ex = null)
        {
            try
            {
                log.Warn(CreateEntity(content), ex);
            }
            catch { }
        }
    }
}
