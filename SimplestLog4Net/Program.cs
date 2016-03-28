namespace SimplestLog4Net
{
    using log4net;

    class Program
    {
        static void Main(string[] args)
        {
            var errors = log4net.Config.XmlConfigurator.Configure();
            var log = LogManager.GetLogger("");
            log.Debug("Simple!");
        }
    }
}
