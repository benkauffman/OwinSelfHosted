using System.Collections.Generic;
using System.Web.Http;

namespace OwinSelfHosted
{
    [RoutePrefix("example")]
    public class ExampleController : ApiController
    {
        // GET api/values 
        public IEnumerable<string> Get()
        {
            List<string> strList = new List<string>();
            for(int i = 1; i <= 10; i++)
            {
                strList.Add("example value " + i);
            }

            return strList;
        }

        // GET api/values/5 
        [Route("{id:int}")]
        public string Get(int id)
        {
            return id.ToString();
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    }
}