using NdCRM.Model.Repository;
using NdCRM.Models.DTO;

namespace NdCRM.Model.IServices
{
    public interface ILogin
    {
        public bool Login(Login model);
    }
}
