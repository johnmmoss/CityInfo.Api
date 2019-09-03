using System;
using System.Collections.Generic;
using CityInfo.Api.Model;
using Microsoft.AspNetCore.Mvc;
using CityInfo.Data;

namespace CityInfo.Api.Controllers
{
    [Route("api/place")]
    public class PlaceController : Controller
    {
        private IPlaceRepository _placeRepository;

        public PlaceController(IPlaceRepository citiesInfoRepository)
        {
            _placeRepository = citiesInfoRepository ?? throw new ArgumentNullException(nameof(citiesInfoRepository));
        }

        [HttpGet]
        public IActionResult GetPlaces()
        {
            var placeEntities = _placeRepository.GetPlaces();

            //var results = AutoMapper.Mapper.Map<PlaceRequest>>(placeEntities);

            return Ok(placeEntities);
        }

        [HttpGet("{id}")]
        public IActionResult GetPlace(int id)
        {
            var cityEntity = _placeRepository.GetPlace(id);

            if (cityEntity == null)
            {
                return NotFound();
            }

            //var cityNoPointsOfInterest = AutoMapper.Mapper.Map<CityNoPointsOfInterest>(cityEntity);

            return Ok();
        }
    }
}
