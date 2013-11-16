using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaRevolution.Domain.Entities
{
    public class Poster
    {
        private string quote;
        private string name;
        private string title;
        private string tagLine;
        private string imgCat;
        private string imgId;

        [Key]
        public int PosterId { get; set; }

        [Display(Name = "What did they say ...")]
        [StringLength(150)]
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

        [Display(Name = "Who said it ...")]
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

        [Display(Name = "What do they do ...")]
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

        [Display(Name = "Type a tag line ...")]
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

        [Display(Name = "Category ...")]
        public string ImgCat
        {
            get
            {
                return this.imgCat;
            }
            set
            {
                this.imgCat = value;
            }
        }

        [Display(Name = "Main Pic ...")]
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

        public DateTime DateCreated { get; set; }

        public string CreatedBy { get; set; }

        public bool Private { get; set; }

        public string PrivateKey { get; set; }

        //TODO: move into the view model class
        //public string ImagePath
        //{
        //    get
        //    {
        //        string folder = (!String.IsNullOrEmpty(this.imgCat)) ? String.Format("{0}/", this.imgCat) : String.Empty;
                
        //        return string.Format("{0}{1}.gif", folder, imgId);
        //    }
        //}
    }
}
