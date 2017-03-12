using SelfHostedMicroService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SelfHostedMicroService
{
    public class Website
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    [EnableCors(origins:"*",headers: "*",methods: "*")]
    public class WebsitesController : ApiController
    {
        Website[] websites = new Website[]
        {
            new Website { Id = 1, Name = "www.google.com", Description = "Search engine"},
            new Website { Id = 2, Name = "www.espire.com", Description = "Espire Infolabs"},
            new Website { Id = 3, Name = "www.facebook.com", Description = "Social Networking"},
            new Website { Id = 4, Name = "hem-kant.blogspot.in", Description = "Hem Kant "}
        };

        // GET api/Websites 
        public IEnumerable<Website> Get()
        {
            return websites;
        }
        //Get api/Websites/1
        public Website Get(int id)
        {
            try
            {
                return websites[id];
            }
            catch (Exception ex)
            {

                return new Website();
            }
        }

        //Post api/values
        public void Post([FromBody]string value)
        {
            Console.WriteLine("Post Method called with value : " +value);
        }

        //Put api/values/1
        public void Put( int id,[FromBody]string value)
        {
            Console.WriteLine("Put Method called with value : " + value);
        }

        //Delete api/values/1
        public void Delete(int id)
        {
            Console.WriteLine("Delet Method called with value : " + id);
        }
    }
}
