using System;

namespace FileData
{
    public static class Program
    {        
        public static void Main(string[] args)
        {            
            //check any args were passed
            if (args.Length.Equals(0))
            {
                Console.WriteLine("No arguments passed");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                return;
            }

            FileDataHelper.ArgType argType = FileDataHelper.ArgType.NONE;
            if (!FileDataHelper.ValidArgs(args, ref argType))
            {                
                Console.WriteLine(string.Format("{0} {1}", string.Join(" ", args), "contains invalid arguments."));
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                return;
            }

            var thirdPartyTools = new ThirdPartyTools.FileDetails();

            //valid args - return version or size
            switch (argType)
            {
                case FileDataHelper.ArgType.VERSION:
                    Console.WriteLine(string.Format("{0} {1}{2}", args[1], "File version: ", thirdPartyTools.Version(args[1])));
                    break;

                case FileDataHelper.ArgType.SIZE:
                    Console.WriteLine(string.Format("{0} {1}{2}", args[1], "File size: ", thirdPartyTools.Size(args[1])));
                    break;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }              
    }
}
