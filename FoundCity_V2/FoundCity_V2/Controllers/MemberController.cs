using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoundCity_V2.Models;
namespace FoundCity_V2.Controllers
{
    public class MemberController : Controller
    {
        Member MemberData = new Member();

        #region 會員中心首頁
        // GET: Member
        public ActionResult Index()
        {
            return View();
        }
        #endregion
        #region 基本資料
        public ActionResult Basic() {
            return View();
        }
        #endregion
        #region 變更密碼
        public ActionResult Modify() {
            return View();
        }
        #endregion
        #region 會員登入
        public ActionResult Login() {
            return View();
        }
        #endregion
        #region 會員註冊
        public ActionResult Register() {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Member newMember) {
            return View();
        }
        #endregion
        #region 忘記密碼
        public ActionResult Forget() {
            return View();
        }
        #endregion
    }
}