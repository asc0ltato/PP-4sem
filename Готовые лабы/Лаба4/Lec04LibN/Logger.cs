using System.Text;

namespace Lec04LibN
{
    public class Logger : ILogger
    {
        private static Logger instance;
        private int count = 1;
        private string file;
        List<string> list = new List<string>();

        private Logger() 
        {
            file = $"{Directory.GetCurrentDirectory()}/LOG{DateTime.Now.ToString("yyyyMMdd-HH-mm-ss")}.txt";
        }

        public void log(string message)
        {
            using (StreamWriter w = File.AppendText(instance.file))
            {
                StringBuilder logBuilder = new StringBuilder();
                logBuilder.Append($"{instance.count:D6}-{DateTime.Now:dd.MM.yyyy HH:mm:ss}-INFO {string.Join(":", list)} {message}");
                w.WriteLine(logBuilder.ToString());
                instance.count++;
            }
        }

        public static ILogger create()
        {
            if (instance == null)
            {
                instance = new Logger();
                using (StreamWriter w = File.AppendText(instance.file))
                {
                    w.WriteLine($"{instance.count.ToString("D6")}-{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}-INIT");
                    instance.count++;
                }
            }
            return instance;
        }

        public void start(string title)
        {
            list.Add(title);
            using (StreamWriter w = File.AppendText(instance.file))
            {
                StringBuilder logBuilder = new StringBuilder();
                logBuilder.Append($"{instance.count:D6}-{DateTime.Now:dd.MM.yyyy HH:mm:ss}-STRT {string.Join(":", list)}");
                w.WriteLine(logBuilder.ToString());
                instance.count++;
            }
        }

        public void stop()
        {
            list.RemoveAt(list.Count - 1);
            using (StreamWriter w = File.AppendText(instance.file))
            {
                StringBuilder logBuilder = new StringBuilder();
                logBuilder.Append($"{instance.count:D6}-{DateTime.Now:dd.MM.yyyy HH:mm:ss}-STOP {string.Join(":", list)}");
                w.WriteLine(logBuilder.ToString());
                instance.count++;
            }
        }
    }
}