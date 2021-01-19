using System;
using System.Collections.Generic;
using System.Text;
using RoleHome.IServices;
using RoleHome.Model.Response;

namespace RoleHome.Services
{
    public class TestService: ITestService
    {
        #region DataInit

        List<TestModel> testModels = new List<TestModel>()
        {
            new TestModel()
            {
                UserName = "zhangsan",
                PassWord = "zhangsan"
            },
            new TestModel()
            {
                UserName = "lishi",
                PassWord = "lishi"
            },
            new TestModel()
            {
                UserName = "wang",
                PassWord = "wang"
            }
        };

        #endregion

        public List<TestModel> GetAllTestuser()
        {
            return testModels;
        }
    }
}
