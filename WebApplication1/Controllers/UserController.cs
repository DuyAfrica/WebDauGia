﻿using BotDetect.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Helpers;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        [CaptchaValidation("CaptchaCode", "ExampleCaptcha", "Incorrect CAPTCHA code!")]
        public ActionResult DangKy(ThanhVien model)
        {
            
            if (!ModelState.IsValid)
            {
                // TODO: Captcha validation failed, show error message
                ViewBag.ErrorMsg = "Bạn nhập sai Captcha!";
                return View();
            }
            else
            {
                // TODO: Captcha validation passed, proceed with protected action
                ThanhVien m = new ThanhVien
                {

                    TenDangNhap = model.TenDangNhap,
                    MatKhau = StringUtils.Md5(model.MatKhau),
                    Email = model.Email,
                    HoTen = model.HoTen,
                    DiaChi = model.DiaChi

                };
                using (WebDauGiaEntities ctx = new WebDauGiaEntities())
                {
                    ctx.ThanhViens.Add(m);
                    ctx.SaveChanges();
                }
                return RedirectToAction("DangNhap", "User");
            }

            
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(ThanhVien model)
        {
            string pass = StringUtils.Md5(model.MatKhau);
            using (var ctx = new WebDauGiaEntities())
            {
                var member = ctx.ThanhViens
                    .Where(u => u.TenDangNhap == model.TenDangNhap && u.MatKhau == pass)
                    .FirstOrDefault();
                if(member !=null)
                {
                    Session["isLogin"] = 1;
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    ViewBag.ErrorMsg = "Đăng nhập thất bạn";
                    return View();
                }
             }

                
        }
        [HttpPost]
        public ActionResult DangXuat()
        {
            CurrentContext.Destroy();
            return RedirectToAction("Index", "Home");
        }
    }
}