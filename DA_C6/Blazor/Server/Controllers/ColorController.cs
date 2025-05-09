﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Blazor.Shared.Model;
using Blazor.Server.Services;

namespace Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private readonly IColor color;
        public ColorController(IColor co) => color = co;

        [HttpGet]
        [Route("GetColors")]
        public IEnumerable<Colors> GetColors()
        {
            return color.GetColors();
        }
        [HttpPost]
        public Colors Add(Colors col)
        {
            return color.AddColor(new Colors
            {
                Color = col.Color,
            });
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Colors colors)
        {
            var existingColor = color.GetColorById(id);


            if (existingColor == null)
            {
                return NotFound();
            }

            existingColor.Color = colors.Color;
            color.UpdateColor(id, existingColor);
            return NoContent();
        }
        [HttpGet("{id}")]
        public IActionResult GetColorById(int id)
        {
            var color1 = color.GetColorById(id);
            if (color1 == null)
            {
                return NotFound();
            }
            return Ok(color1);
        }

    }
}
