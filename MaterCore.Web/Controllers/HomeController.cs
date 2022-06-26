using MaterCore.Web;
using MaterCore.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        WebApiHelper _webAPI = new WebApiHelper();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                SummaryDTO dto = new SummaryDTO();

                HttpClient client = _webAPI.InitializeClient();
                HttpResponseMessage res = await client.GetAsync("BedSummary/GetBedSummary");

                //Checking the response is successful or not which is sent using HttpClient  
                if (res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var result = res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list  
                    dto = JsonConvert.DeserializeObject<SummaryDTO>(result);
                }
                //returning the employee list to view  
                return View(dto);
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

       
        public IActionResult AddComment(int id)
        {
            CommentDTO dto = new CommentDTO();
            dto.BedId = id;
            return View(dto);
        }

        public IActionResult Discharge(int id)
        {
            CommentDTO dto = new CommentDTO();
            dto.BedId = id;
            return View(dto);
        }

        public async Task<IActionResult> Admit(int id)
        {

            try
            {
                List <PatientDTO> pdto = new List<PatientDTO>();

                HttpClient client = _webAPI.InitializeClient();
                HttpResponseMessage res = await client.GetAsync("Patient/GetPatients");

                //Checking the response is successful or not which is sent using HttpClient  
                if (res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var result = res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list  
                    pdto = JsonConvert.DeserializeObject< List<PatientDTO>>(result);
                }
                var listItems = new List<SelectListItem>();
                AdmitDTO dto = new AdmitDTO();
                dto.BedId = id;
                foreach (var item in pdto)
                {
                    listItems.Add(new SelectListItem
                    {
                        Text = item.Name,
                        Value = item.Id.ToString()
                    });
                }
                dto.Patients = listItems;
                //returning the employee list to view  
                return View(dto);
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }


        [HttpPost]
        public IActionResult Admit([Bind("BedId,PatientId,PresentingIssue,LastComment,NurseId")] AdmitDTO admit)
        {
            if (ModelState.IsValid)
            {
                HttpClient client = _webAPI.InitializeClient();

                var content = new StringContent(JsonConvert.SerializeObject(admit), Encoding.UTF8, "application/json");

                HttpResponseMessage res = client.PostAsync("Patient/AdmitPatient", content).Result;

                if (res.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View("Admit");
        }


        [HttpPost]
        public IActionResult Create([Bind("BedId,Comments,NurseId")] CommentDTO comment)
        {
            if (ModelState.IsValid)
            {
                HttpClient client = _webAPI.InitializeClient();

                var content = new StringContent(JsonConvert.SerializeObject(comment), Encoding.UTF8, "application/json");

                HttpResponseMessage res =  client.PostAsync("Comment/AddComment", content).Result;
              
                if (res.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View("addcomment");
        }


        [HttpPost]
        public IActionResult Discharge([Bind("BedId,Comments,NurseId")] CommentDTO comment)
        {
            if (ModelState.IsValid)
            {
                HttpClient client = _webAPI.InitializeClient();
                /*Add the IsDischarge Flag*/
                comment.IsDischarge = true;
                var content = new StringContent(JsonConvert.SerializeObject(comment), Encoding.UTF8, "application/json");
               
                HttpResponseMessage res = client.PostAsync("Comment/AddComment", content).Result;
                if (res.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View("addcomment");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
