using DeliveryShare.Classes;
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

namespace DeliveryShare
{
    /// <summary>
    /// ArticleUserControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ArticleUserControl : UserControl
    {
        //public class ArticleThumbnail 
        //{
        //    public string Title { get; set; }
        //    public string Content { get; set; }
        //    public string Place { get; set; }
        //    public int PeopleCount { get; set; }
        //    public string Category { get; set; }
        //    //public string ChatLink { get; set; }
        //}
        //public ArticleThumbnail articleThumbnail;

        //public ArticleThumbnail ArticleThumb
        //{
        //    get { return articleThumbnail; }
        //    set {
        //        articleThumbnail = value;
        //        FoodCategoryLabel.Content = articleThumbnail.Category;
        //        PlaceLabel.Content = articleThumbnail.Place;
        //        PeopleCountLabel.Content = articleThumbnail.PeopleCount;
        //        TitleTextBlock.Text = articleThumbnail.Title;
        //        ContentTextBlock.Text = articleThumbnail.Content;
        //    }
        //}
        Article 
        public ArticleUserControl()
        {
            InitializeComponent();
            
        }
    }
}
