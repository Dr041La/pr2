using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace filik
{
    static class AllFiles
    {
        public static List<File> allfiles { get; private set; }

        public static void init()
        {
            allfiles = new List<File>
            {
                new File("храз.png", DateTime.Now.AddMilliseconds(1000)),
                new File("сеченов.bmp", DateTime.Now),
                new File("ханкуль.jpg", DateTime.Now),
                new File("канхуль.png", DateTime.Now),
                new File("2с.jpg", DateTime.Now),
                new File("С*.png", DateTime.Now)
            };
        }
    }
}
