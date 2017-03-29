using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AIS_API.Models;
using System.Collections;

namespace AIS_API.Controllers
{
    public class PlantController : ApiController
    {
        // GET: api/Plant
        /// <summary>
        ///     Get all plants
        /// </summary>
        /// <returns></returns>
        public ArrayList Get()
        {
            PlantPersistence pp = new PlantPersistence();
            return pp.getplants();
        }

        // GET: api/Plant/5
        /// <summary>
        /// Get specific plant by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Plant Get(long id)
        {
            PlantPersistence pp = new PlantPersistence();
            Plant plant = pp.getplant(id);

            return plant;
    }

        // POST: api/Plant
        /// <summary>
        /// Post to api
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public HttpResponseMessage Post([FromBody]Plant value)
        {
            PlantPersistence pp = new PlantPersistence();
            long id;
            id = pp.savePlant(value);
            value.ID = id;
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, string.Format("Plant/{0}", id));
            return response;
        }

        // PUT: api/Plant/5
        /// <summary>
        /// Update (PUT) plant by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public HttpResponseMessage Put(long id, [FromBody]Plant value)
        {
            PlantPersistence pp = new PlantPersistence();
            bool recordExisted = false;
            recordExisted = pp.updatePlant(id, value);

            HttpResponseMessage response;

            if (recordExisted)
            {
                response = Request.CreateResponse(HttpStatusCode.NoContent);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return response;

        }

        // DELETE: api/Plant/5
        /// <summary>
        /// Delete plant by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HttpResponseMessage Delete(long id)
        {
            PlantPersistence pp = new PlantPersistence();
            bool recordExisted = false;
            recordExisted = pp.deletePlant(id);

            HttpResponseMessage response;

            if (recordExisted)
            {
                response = Request.CreateResponse(HttpStatusCode.NoContent);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return response;

        }
    }
}
