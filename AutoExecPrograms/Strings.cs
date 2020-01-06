using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoExecPrograms
{
    class StringsIDs
    {
        public StringsIDs()
        {

        }
        public int getId(String s)
        {
            switch (s)
            {
                case "APP_NAME":
                    return 0;
                case "EXEC_BUTTON":
                    return 1;
                case "ADD":
                    return 2;
                case "REMOVE":
                    return 3;
                case "NAME_PROCESS":
                    return 4;
                case "PATH_PROCESS":
                    return 5;
                case "ARGS_PROCESS":
                    return 6;
                default:
                    return -1;
            }
        }
    }
    class Strings
    {
        private static String APP_NAME = "AutoExec Programs";
        private static String EXEC_BUTTON = "Execute!";
        private static String ADD = "Add";
        private static String REMOVE = "Remove";
        private static String NAME_PROCESS = "Name";
        private static String PATH_PROCESS = "Path";
        private static String ARGS_PROCESS = "Arguments";

        public Strings()
        {

        }
        public String getString(int id)
        {
            switch(id)
            {
                case 0:
                    return APP_NAME;
                case 1:
                    return EXEC_BUTTON;
                case 2:
                    return ADD;
                case 3:
                    return REMOVE;
                case 4:
                    return NAME_PROCESS;
                case 5:
                    return PATH_PROCESS;
                case 6:
                    return ARGS_PROCESS;
                default:
                    return null;
            }
        }
    }
}
