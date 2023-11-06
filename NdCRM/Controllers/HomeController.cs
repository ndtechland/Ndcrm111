using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using NdCRM.Models;
using NdCRM.Models.admin_NDCrM;
using NdCRM.Models.DTO;
using NdCRM.Utility;
using System.Data;
using System.Diagnostics;
using ToolBelt;

namespace NdCRM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AdminNdcrMContext context;
        string connectionString = ConnectionString.CName;
        public HomeController(ILogger<HomeController> logger, AdminNdcrMContext Context)
        {
            _logger = logger;
            context = Context;
        }

        public IActionResult Index()
        {
            var data=context.Products.ToList();
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult adminLogin(Login Logindetails)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd=new SqlCommand("usp_adminlogin", con);
                cmd.Parameters.AddWithValue("@UserName",Logindetails.UserName);
                cmd.Parameters.AddWithValue("@password", Logindetails.Password);
                cmd.CommandType=CommandType.StoredProcedure;
                DataTable dt=new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand= cmd;
                da.Fill(dt);
                if(dt!=null && dt.Rows.Count>0)
                {
                    return RedirectToAction(nameof(Dashboard));

                }
                else
                {
                    return RedirectToAction(nameof(Login));

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IActionResult Product()
        {
            return View();
        }

    }
}