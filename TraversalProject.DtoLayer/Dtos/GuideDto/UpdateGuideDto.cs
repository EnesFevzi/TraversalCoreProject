using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.DtoLayer.Dtos.GuideDto
{
    public class UpdateGuideDto
    {
        public int GuideID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string? TwitterUrl { get; set; }
        public string? Description2 { get; set; }
        public string? GuideListImage { get; set; }
        public string? InstagramUrl { get; set; }
        public bool? Status { get; set; }
        public List<Destination> Destinations { get; set; }
    }
}
