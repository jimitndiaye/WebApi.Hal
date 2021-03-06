﻿namespace WebApi.Hal.Web.Api.Resources
{
    public class BeerRepresentation : Representation
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? BreweryId { get; set; }
        public string BreweryName { get; set; }

        public int? StyleId { get; set; }
        public string StyleName { get; set; }

        protected override void CreateHypermedia()
        {
            var selfLink = LinkTemplates.Beers.Beer.CreateLink(id => Id);
            Href = selfLink.Href;
            Rel = selfLink.Rel;

            if (StyleId != null)
                Links.Add(LinkTemplates.BeerStyles.Style.CreateLink(id => StyleId));
            if (BreweryId != null)
                Links.Add(LinkTemplates.Breweries.Brewery.CreateLink(id => BreweryId));
        }
    }
}
