using InstaUserControlDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InstaUserControlDemo.UserControls
{
    /// <summary>
    /// Interaction logic for VideoPostUC.xaml
    /// </summary>
    public partial class VideoPostUC : UserControl
    {
        public VideoPostUC(VideoPostModel videoPostModel)
        {
            InitializeComponent();

            VideoPlayer.Source = videoPostModel.VideoPlayerSource;
        }

        private void ContentControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (!PostOps.PostLiked)
                PostOps.LikePost();
            else
                PostOps.UnLikePost();
        }
    }
}
