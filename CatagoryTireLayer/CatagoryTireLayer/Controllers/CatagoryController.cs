using CatagoryBusinessLL;
using CatagoryBusinessLL.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CatagoryTireLayer.Controllers
{
    public class CatagoryController : ApiController
    {
        [HttpGet]
        [Route("api/Catagory/all")]
        public HttpResponseMessage showAllCat()
        {
            var allcat = CatagoryBusinessLogic.AllCatagory();
            return Request.CreateResponse(HttpStatusCode.OK, allcat);
        }

        [HttpPost]
        [Route("api/InsertCatagory/Insert")]
        public HttpResponseMessage insertCat(CatagoryDTO cat)
        {
            var insertStatus = CatagoryBusinessLogic.CreateCata(cat);
            return Request.CreateResponse(HttpStatusCode.OK, insertStatus);
        }

        [HttpPost]
        [Route("api/UpdateCatagory/Update")]
        public HttpResponseMessage updateCat(CatagoryDTO cat)
        {
            var updateStatus = CatagoryBusinessLogic.updateCata(cat);
            return Request.CreateResponse(HttpStatusCode.OK, updateStatus);
        }

        [HttpDelete]
        [Route("api/DeleteCatagory/Delete")]
        public HttpResponseMessage deleteCat(CatagoryDTO cat)
        {
            var deleteStatus = CatagoryBusinessLogic.deleteCata(cat);
            return Request.CreateResponse(HttpStatusCode.OK, deleteStatus);
        }
    }
}
