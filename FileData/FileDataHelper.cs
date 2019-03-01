using System;
using System.Text.RegularExpressions;

namespace FileData
{
    public static class FileDataHelper
    {
        /// <summary>
        /// Check the passed arguments are valid for the application
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static Boolean ValidArgs(string[] args, ref ArgType argType)
        {           
            if (!args.Length.Equals(2))
            {
                return false;
            }

            if (args[0].Trim().Equals("-v") || args[0].Trim().Equals("--v") || args[0].Trim().Equals("/v") || args[0].Trim().Equals("--version"))
            {
                argType = ArgType.VERSION;
                return true;
            }

            if (args[0].Trim().Equals("-s") || args[0].Trim().Equals("--s") || args[0].Trim().Equals("/s") || args[0].Trim().Equals("--size"))
            {
                argType = ArgType.SIZE;
                return true;
            }

            return false;
        }

        public enum ArgType
        {
            NONE,
            VERSION,
            SIZE
        }
    }
}
