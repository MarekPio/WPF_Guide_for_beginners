using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaUserControlDemo.Database
{
    internal class MockDb
    {
        public static Uri GetPostVideo()
        {
            return new Uri(Environment.CurrentDirectory + @"\..\..\Videos\cat.mp4",
                UriKind.RelativeOrAbsolute);
        }
    }
}
