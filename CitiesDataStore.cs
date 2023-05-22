using System;
using CityInfo.API.Models;
namespace CityInfo.API
{
	public class CitiesDataStore
	{
		public List<CityDto> Cities { get; set; }
		public static CitiesDataStore Current { get; } = new CitiesDataStore();

		public CitiesDataStore()
		{
			Cities = new List<CityDto>()
			{
				new CityDto()
				{
					Id = 1,
					Name = "New York City",
					Desctription = "The one with that big park",
					PointsOfInterest = new List<PointOfInterestDto>()
					{
						new PointOfInterestDto()
						{
							Id = 1,
							Name = "Central Park",
							Desctription = "The most visited urban park in the United States"
						},
						new PointOfInterestDto()
						{
							Id = 2,
							Name = "Empire state Building",
							Desctription = "A 102-story skyscraper located in Midtown Manhatten"
						}
					}
				},
				new CityDto()
				{
					Id = 2,
					Name = "Antwerk",
					Desctription = "The one with cathedral that was never really finished",
                    PointsOfInterest = new List<PointOfInterestDto>()
					{
						new PointOfInterestDto()
						{
							Id = 3,
							Name = "Church",
							Desctription = "A Gothic style cathedral, concieved by architects Jan and Piete"
						},
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Antwerp Central Station",
                            Desctription = "The Finest example of railway architecture in Belgium"
                        }
                    }
                },
				new CityDto()
				{
					Id = 3,
					Name = "Paris",
					Desctription = "The one with that big tower",
					PointsOfInterest = new List<PointOfInterestDto>()
					{
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Eiffel Tower",
                            Desctription = "A wrought iron lattice tower on the Champ de Mars named after his maker"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "The louvre",
                            Desctription = "The world's largest museum"
                        }
                    }

				}
			};
		}
	}
}

