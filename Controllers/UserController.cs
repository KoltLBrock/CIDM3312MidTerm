using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EXAMMidTerm.Models;

namespace EXAMMidTerm.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateAccount(){
            return View();
        }
        [HttpPost]
        public IActionResult AddNewUser(LoginViewModel loginViewModel){
            if(ModelState.IsValid){
            Repository.AddAccount(loginViewModel);
            return View("AccountCreated",loginViewModel);
            }else{
                return View("CreateAccount");
            }
        }
        [HttpGet]
        public IActionResult Login(){
            return View();
        }
        [HttpPost]
        public IActionResult LoginResult(LoginViewModel loginViewModel){
            //this took a long time to figure out because I didnt know how to do the first if part, inside the foreach
            foreach(var i in Repository.Accounts){
                if(i.userName == loginViewModel.userName){
                    if(i.password == loginViewModel.password){
                        return View("Success", loginViewModel);
                    }
                    //at this point the password is wrong but the username is right
                }
            }
            return View("Failure");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}