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
        private bool prIvate = false;

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
                var t = (String.IsNullOrEmpty(this.title)) ? String.Empty : String.Format(" - {0}", this.title);
                return t;
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
                var tl = (String.IsNullOrEmpty(this.tagLine)) ? "Join the digital revolution" : this.tagLine;
                return tl;
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
                if (String.IsNullOrEmpty(this.imgCat))
                {
                    return string.Empty;
                }
                else
                {
                    return String.Format("{0}/", this.imgCat);
                }
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

        public bool Private 
        {
            get
            {
                return this.prIvate;
            }
            set
            {
                this.prIvate = value;
            }
        }

        public string PrivateKey { get; set; }

        //TODO: move into the view model class
        public string ImagePath
        {
            get
            {
                return string.Format("{0}{1}.gif", ImgCat, imgId);
            }
        }
    }
}
