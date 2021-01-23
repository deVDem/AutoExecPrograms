using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoExec2.Objects
{
    public class Process
    {
        public string name;
        public string path;
        public string args;

        public Process(string name, string path, string args)
        {
            this.name = name;
            this.path = path;
            this.args = args;
        }

        public void run()
        {
            try
            {
                System.Diagnostics.Process.Start(path, args);
            } catch (Exception e)
            {
                throw e;
            }
        }
    }
}
