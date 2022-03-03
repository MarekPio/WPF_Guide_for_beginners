using InstaUserControlDemo.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaUserControlDemo.Models
{
    public class VideoPostModel
    {
        public Uri _videoPlayerSource;
        public Uri VideoPlayerSource
        {
            get
            {
                if (_videoPlayerSource == null)
                    return MockDb.GetPostVideo();
                else
                    return _videoPlayerSource;
            }
            set
            {
                _videoPlayerSource = value;
            }
        }
    }
}
