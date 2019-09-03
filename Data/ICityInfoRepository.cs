using CityInfo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.Data
{
    public interface IPlaceRepository
    {
        IEnumerable<Place> GetPlaces();

        Place GetPlace(int placeId);

        //IEnumerable<PointOfInterest> GetPointOfInterests(int cityId);

        //PointOfInterest GetPointOfInterestsForCity(int cityId, int pointOfInterestId);

        //bool CityExists(int cityId);

        //void AddPointOfInterest(int cityId, PointOfInterest pointOfInterest);

        //void DeletePointOfInterest(PointOfInterest pointOfInterest);

        bool Save();
    }
}
