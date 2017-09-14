using System;

namespace QwikPix.Entities.Content
{
    public class Pix
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsDeleted { get; set; }
        public string ImageUrl { get; set; }

        public string ShortDescription
        {
            get
            {
                var retValue = Description;

                if (!string.IsNullOrEmpty(Description) && Description.Length > 20)
                {
                    retValue = $"{ Description.Substring(0, 16) }...";
                }

                return retValue;
            }
        }
    }
}
