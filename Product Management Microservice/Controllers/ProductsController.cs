using Microsoft.AspNetCore.Mvc;
using Product_Management_Microservice.Model;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Product_Management_Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<AppProduct> products = new List<AppProduct>();
        public ProductsController()
        {
           products.Add(new AppProduct { Id=1, Name="Mobile", Make="ABC", Model="12345", Cost=400, CreatedDate= DateTime.Now });
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<AppProduct> Get()
        {
            return products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]

        public string Get(int id)
        {
            IDictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            string jsonResponse;
            if (products.Count == 0)
            {

                response.Add("error", true);
                response.Add("message", "Product not found");
                jsonResponse = JsonConvert.SerializeObject(response);
                return jsonResponse;
            }

            var product =  products.FirstOrDefault(p => p.Id==id);
            if (product == null)
            {
                response.Add("error", true);
                response.Add("message", "Product not found");
                jsonResponse = JsonConvert.SerializeObject(response);
                return jsonResponse;
                
            }

            response.Add("error", false);
            response.Add("message", "Servies Fetch");
            response.Add("data",products);



           jsonResponse = JsonConvert.SerializeObject(response);



            return jsonResponse;
           

        }
        // POST api/<ProductsController>
        [HttpPost]
        public string Post([FromBody] AppProduct product)
        {

            //products.Id;
            //products.Name;
            //products.Model;
            //products.Make;
            //products.Cost;
            //products.CreatedDate;
            System.Diagnostics.Debug.WriteLine("from app product");
            Random r = new Random();
            System.Diagnostics.Debug.WriteLine(product.Name);
            this.products.Add(product);
           //this.products.Add(new AppProduct { Id = r.Next(), Name = product.Name, Make = product.Make, Model = product.Model, Cost = product.Cost, CreatedDate = DateTime.Now });
            return "product added";
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] AppProduct product)
        {
            if(id != product.Id)
            {
                return NotFound("Updated");

            }

        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           var product = product.AppProducts.FirstAsync(x => x.Id == id);
            if (products == null)
            {
                products.Remove(product);
                //await product.SaveChangesAsync();
                //return Ok(product);
                //}
                //return NotFound($"Product with Id: {id} not found");

                public IActionResult Delete(int id,
                              AppUser user)
                {
                    var u = users.SingleOrDefault(x => x.Id == id);
                    if (u == null)
                    {
                        return NotFound("no user found");
                    }
                    users.Remove(u);



                    if (users.Count == 0)
                    {
                        return NotFound("No list Found");
                    }
                    return Ok(users);
                }

    }
}
