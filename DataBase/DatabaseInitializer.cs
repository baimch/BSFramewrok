using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DatabaseModels;
using System.Data.Entity.Validation;
using System.Data.Entity.Migrations;

namespace DataBase
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists <DataBaseContext>
    {
        protected override void Seed(DataBaseContext context)
        {
            UserModels m1 = new UserModels()
            {
                UserGUID = Guid.NewGuid().ToString(),
                UserName = "张一",
                UserNumber = "0001",
                UserBirthDay = "1990.1.1",
                UserMail = "aaa@qq.com",
                UserPhone = "13100001111",
                Password="aaaaaa"
            };

            UserModels m2 = new UserModels()
            {
                UserGUID = Guid.NewGuid().ToString(),
                UserName = "张二",
                UserNumber = "0002",
                UserBirthDay = "1989.12.12",
                UserMail = "bbb@qq.com",
                UserPhone = "13100002222",
                Password = "aaaaaa"
            };

            UserModels m3 = new UserModels()
            {
                UserGUID = Guid.NewGuid().ToString(),
                UserName = "张三",
                UserNumber = "0003",
                UserBirthDay = "1989.12.12",
                UserMail = "ccc@qq.com",
                UserPhone = "13100003333",
                Password = "aaaaaa"
            };


            try { // 写数据库 

                context.UserContext.AddOrUpdate(m1);
                context.UserContext.AddOrUpdate(m2);
                context.UserContext.AddOrUpdate(m3);
            context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx) { }
            base.Seed(context);
        }

    }
}
