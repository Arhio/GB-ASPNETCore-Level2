﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.ServiceHosting.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static readonly List<string> _values = Enumerable.Range(1, 10).Select(n => $"Value {n}").ToList();
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() => _values;

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 0)
                return BadRequest();
            if (id >= _values.Count)
                return NotFound();
            return _values[id];
        }

        [HttpPost]
        public void Post(string value) => _values.Add(value);

        [HttpPut("{id}")]
        public ActionResult Put(int id, string value)
        {
            if (id < 0 || id >= _values.Count)
                return BadRequest();
            _values[id] = value;
            return Ok();
        }

        [HttpDelete("id")]
        public ActionResult Delete(int id)
        {
            if (id < 0)
                return BadRequest();
            if (id >= _values.Count)
                return NotFound();

            _values.RemoveAt(id);
            return Ok();
        }
    }
}