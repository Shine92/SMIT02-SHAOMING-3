using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
namespace FoundCity_V2.Models {
    public class CMemberService {

        NewPetEntities db = new NewPetEntities();

        #region 註冊會員
        public void Register(Member newMember) {
            /*密碼加密*/
            newMember.Password = HasPassword(newMember.Password);
            /*新增資料到資料庫實體*/
            db.Members.Add(newMember);
            /*儲存資料庫變更*/
            db.SaveChanges();
        }
        #endregion
        #region 密碼加密 SHA1
        public string HasPassword(string password) {
            /*定義SHA1的Hash物件*/
           SHA1 sha1 =  new SHA1CryptoServiceProvider();
            string resultSha1 = Convert.ToBase64String(sha1.ComputeHash(Encoding.Default.GetBytes(password)));
            return resultSha1;
        }
        #endregion
        #region 帳號註冊重複確認
        public bool AccountCheck(string Account) {
            /*在資料表查詢有無此帳號*/
            Member serch = db.Members.Find(Account);
            /*判斷是否有搜尋到會員*/
            bool result = (serch == null);
            /*傳回結果*/
            return result;
        }
        #endregion
    }
}