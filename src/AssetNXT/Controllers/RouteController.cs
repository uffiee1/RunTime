﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetNXT.Dtos;
using AssetNXT.Models.Data;
using AssetNXT.Repository;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Ruuvi.Controllers
{
    [Produces("application/json")]
    [Route("api/routes")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private readonly IMongoDataRepository<Route> _repository;
        private readonly IMapper _mapper;

        public RouteController(IMongoDataRepository<Route> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRoutes()
        {
            var routes = await _repository.GetAllAsync();

            if (routes != null)
            {
                return Ok(_mapper.Map<IEnumerable<RouteReadDto>>(routes));
            }

            return NotFound();
        }

        [HttpGet("{id}", Name = "GetRouteByDeviceId")]
        public async Task<IActionResult> GetRouteByDeviceId(string id)
        {
            var route = await _repository.GetObjectByIdAsync(id);

            if (route != null)
            {
                return Ok(_mapper.Map<RouteReadDto>(route));
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoute(RouteCreateDto routeCreateDto)
        {
            var route = _mapper.Map<Route>(routeCreateDto);

            await _repository.CreateObjectAsync(route);

            var routeReadDto = _mapper.Map<RouteReadDto>(route);

            // https://docs.microsoft.com/en-us/dotnet/api/system.web.http.apicontroller.createdatroute?view=aspnetcore-2.2
            return CreatedAtRoute(nameof(GetRouteByDeviceId), new { Id = routeReadDto.Id }, routeReadDto);
        }
    }
}