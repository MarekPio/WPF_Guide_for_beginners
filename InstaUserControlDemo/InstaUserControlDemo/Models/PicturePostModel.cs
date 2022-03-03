using InstaUserControlDemo.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace InstaUserControlDemo.Models
{
    public class PicturePostModel
    {
        BitmapImage _PostImage;

        public BitmapImage PostImage
        {
            get
            {
                if (_PostImage == null)
                    return MockDb.GetPostPicture();
                else
                    return _PostImage;

            }
            set
            {
                _PostImage = value;
            }
        }
    }
}
