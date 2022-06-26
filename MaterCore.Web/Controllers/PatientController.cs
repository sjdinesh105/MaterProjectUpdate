using MaterCore.Web;
using MaterCore.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MaterCore.Web.Models;

namespace MaterCore.Web.Controllers
{
    public class PatientController : Controller
    {
        private readonly ILogger<PatientController> _logger;
        WebApiHelper _webAPI = new WebApiHelper();
        public PatientController(ILogger<PatientController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int patientId)
        {
            try
            {
                PatientSummaryDTO dto = new PatientSummaryDTO();

                HttpClient client = _webAPI.InitializeClient();
                var content = new StringContent(JsonConvert.SerializeObject(patientId), Encoding.UTF8, "application/json");

                HttpResponseMessage res = client.PostAsync("Patient/GetPatientSummary", content).Result;

                //Checking the response is successful or not which is sent using HttpClient  
                if (res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var result = res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list  
                    dto = JsonConvert.DeserializeObject<PatientSummaryDTO>(result);
                }
                //returning the employee list to view  
                return View(dto);
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
