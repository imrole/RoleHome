using System;
using System.Collections.Generic;
using System.Text;
using RoleHome.Model.Response;

namespace RoleHome.IServices
{
    public interface ITestService
    {
        List<TestModel> GetAllTestuser();
    }
}
