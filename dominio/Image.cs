using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Image
    {
        public int idArticle { get; set; }
        public string ArtImage { get; set; }
        public override string ToString()
        {
            return ArtImage;
        }
    }
}
