using System;
using Microsoft.AspNetCore.Mvc;

namespace KitcPPW.Controllers.Base
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            Console.WriteLine("Base Controller Execute..");
        }
    }
}