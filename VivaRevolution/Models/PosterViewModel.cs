using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VivaRevolution.Models
{
    public class PosterViewModel
    {
        private string imgId;
        private string quote;
        private string name;
        private string title;
        private string tagLine;

        public string ImgId 
        {
            get
            {
                return this.imgId;
            }
            set
            {
                this.imgId = value;
            }
        }

        public string Quote
        {
            get
            {
                return this.quote;
            }
            set
            {
                this.quote = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Title 
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public string TagLine 
        {
            get
            {
                return this.tagLine;
            }
            set
            {
                this.tagLine = value;
            }
        }
    }
}