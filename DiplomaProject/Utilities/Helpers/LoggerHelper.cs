namespace DiplomaProject.Utilities.Helpers;

public static class LoggerHelper
{
    private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

    static LoggerHelper()
    {
        _logger = LogManager.GetCurrentClassLogger();
    }
    
    public static void LogEventAll(string logMessage)
    {
        _logger.Trace(logMessage);
        _logger.Debug(logMessage);
        _logger.Error(logMessage);
        _logger.Warn(logMessage);
        _logger.Info(logMessage);
        _logger.Fatal(logMessage); 
    }
    
    public static void LogEventFromWarning(string logMessage)
    {
        _logger.Warn(logMessage);
        _logger.Error(logMessage);
        _logger.Fatal(logMessage); 
    }
}