﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryShare.Classes
{
    class Article
    {
        //글번호
        //제목,
        //본문,
        //장소,
        //모인인원,
        //카테고리,
        //링크
        //만든날짜?
        //public int ArticleNo { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Place { get; set; }
        public int PeopleCount { get; set; }
        public string Category { get; set; }
        public string ChatLink { get; set; }

        
    }
}
