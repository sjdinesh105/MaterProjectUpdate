using MaterCore.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MaterCore.Web.Controllers
{
   
    public class NurseController : Controller
    {
        WebApiHelper _webAPI = new WebApiHelper();
        public async Task<IActionResult> Index()
        {
          try { 
                    List<NurseDTO> dto = new List<NurseDTO>();

                    HttpClient client = _webAPI.InitializeClient();
                    HttpResponseMessage res = await client.GetAsync("Nurse/GetNurse");
                   
                    //Checking the response is successful or not which is sent using HttpClient  
                    if (res.IsSuccessStatusCode)
                    {
                        //Storing the response details recieved from web api   
                        var result = res.Content.ReadAsStringAsync().Result;
                        //Deserializing the response recieved from web api and storing into the Employee list  
                        dto = JsonConvert.DeserializeObject<List<NurseDTO>>(result);
                    }
                    //returning the employee list to view  
                    return View(dto);
            }
            catch(Exception ex)
            {
                throw ex;

            }


        }
    }
}
