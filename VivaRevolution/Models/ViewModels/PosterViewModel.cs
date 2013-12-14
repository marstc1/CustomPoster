using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VivaRevolution.Models.Mappers;

namespace VivaRevolution.Models.ViewModels
{
    public class PosterViewModel
    {
        private string imgId;
        private string imgCat;
        private string quote;
        private string name;
        private string title;
        private string tagLine;
        private PosterViewModelMapper mapper;

        public PosterViewModel()
        {
            this.mapper = new PosterViewModelMapper();
        }

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

        [Display(Name = "Select a photo ...")]
        public List<PosterImage> Images
        {
            get
            {
                return this.mapper.CreatePosterImagesDropDownValues();
            }
        }

        [Display(Name = "Quote ...")]
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

        [Display(Name = "Type a Tag Line ...")]
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

        public string ImagePath
        {
            get
            {
                return string.Format("{0}{1}.gif", ImgCat, imgId);
            }
        }

        public string CreatedBy { get; set; }
    }
}