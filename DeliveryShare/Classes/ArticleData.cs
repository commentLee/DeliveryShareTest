using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryShare.Classes
{
    class ArticleData
    {
        public ObservableCollection<Article> ArticleCollection { get; set; }
        
        //public AddStudentCommand addStudentCommand { get; set; }
        public ArticleData()
        {
            ArticleCollection = new ObservableCollection<Article>();
            

            //StudentsCollection.Add(new Student() { Name = "김형기" });
            //StudentsCollection.Add(new Student() { Name = "홍길동" });
            //StudentsCollection.Add(new Student() { Name = "김철수" });
            //StudentsCollection.Add(new Student() { Name = "김영희" });

            //addStudentCommand = new AddStudentCommand(this);
        }
    }
}
