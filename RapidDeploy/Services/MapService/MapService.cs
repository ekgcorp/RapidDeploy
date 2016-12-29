﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace RapidDeploy.Services.MapService
{
    public class MapService : IMapService
    {
        MapHelper _helper = default(MapHelper);

        public MapService(string mapKey)
        {
            _helper = new MapHelper(mapKey);
        }

        public async Task<List<MapHelper.Resource>> FindLocationByPointAsync(double latitude, double longitude) => await _helper.FindLocationByPointAsync(latitude, longitude);

        public Uri GetMapUrl(IEnumerable<MapHelper.StaticMapPushpin> items, MapHelper.StaticMapPushpin user, MapHelper.StaticMapPushpin center, Windows.Foundation.Size size, int? zoom = null, MapHelper.StaticMapImagerySets imagery = MapHelper.StaticMapImagerySets.Road) => _helper.GetMapUrl(items, user, center, size, zoom, imagery);

        public Task<List<MapHelper.Resource>> FindLocationByQueryAsync(string query, int maxResults = 5) => _helper.FindLocationByQueryAsync(query, maxResults);
    }
}
