using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using NdCRM.Model.IServices;
using NdCRM.Models.admin_NDCrM;
using NdCRM.Models.DTO;

namespace NdCRM.Model.Repository
{
    public class LoginRepo : ILogin
    {
        private AdminNdcrMContext _context;
        public LoginRepo(AdminNdcrMContext context)
        {
            _context = context;
        }
        public bool Login(Login model)
        {
            try
            {
                bool isvalid = _context.CustomerRegistrations.Any(x => x.ContactPersonName == model.UserName && x.Password == model.Password);
                if (isvalid)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }
        }
    }
}
