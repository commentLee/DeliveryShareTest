using DeliveryShare.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DeliveryShare.Commands
{
    class AddArticleCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public ArticleData articleData { get; set; }
        ArticleUserControl articleUserControl;
        public AddArticleCommand(ArticleData adata)
        {
            
            //articleData = adata;
            //articleUserControl.articleThumbnail ={
            //    Ca
            //    PlaceLabel.Content = articleThumbnail.Place;
            //    PeopleCountLabel.Content = articleThumbnail.PeopleCount;
            //    TitleTextBlock.Text = articleThumbnail.Title;
            //    ContentTextBlock.Text = articleThumbnail.Content;
            //}
        }

        public bool CanExecute(object parameter)
        {
            //string addName = parameter as string;
            //if (addName != "")
            //{
            //    return true;
            //}
            return false;
        }

        public void Execute(object parameter)
        {
            //string addName = parameter as string;
            //sampleData.StudentsCollection.Add(new Student() { Name = addName });
        }
    }
}
