using System.IO;


namespace CopyDir
{
    public class Log
    {
        public static void Message(string message, string lDir, string lFile)
        {            
            string log = Path.Combine(lDir,lFile);
            using (StreamWriter writer = File.AppendText(log))
            {
                writer.WriteLine(message);
            }
        }
    }
}
