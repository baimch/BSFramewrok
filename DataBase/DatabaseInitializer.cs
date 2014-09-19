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
    public class DatabaseInitializer : DropCreateDatabaseAlways<DataBaseContext>
    {
        protected override void Seed(DataBaseContext context)
        {
            #region 初始化用户信息
            UserModels m1 = new UserModels()
            {
                UserGUID = Guid.NewGuid().ToString(),
                UserName = "张一",
                UserNumber = "0001",
                UserBirthDay = "1990.1.1",
                UserMail = "aaa@qq.com",
                UserPhone = "13100001111",
                Password = "aaaaaa"
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
            #endregion

            #region 初始化Accordion
            AccordionModels a1 = new AccordionModels()
            {
                ID = Guid.NewGuid().ToString(),
                title = "系统管理",
                icon = "icon-application-cascade",
                order=1
            };
            AccordionModels a2 = new AccordionModels()
            {
                ID = Guid.NewGuid().ToString(),
                title = "人力资源管理",
                icon = "icon-application-form-edit",
                order=2
            };

            HrefModels h1 = new HrefModels()
            {
                ID = Guid.NewGuid().ToString(),
                title = "用户管理",
                icon = "icon-users",
                link = "/SystemManage/UserManage",
                iFrame = 0,
                Accordion = a1
            };
            HrefModels h2 = new HrefModels()
            {
                ID = Guid.NewGuid().ToString(),
                title = "功能菜单管理",
                icon = "icon-users",
                link = "/Home/AccordionManage",
                iFrame = 0,
                Accordion = a1
            };
            HrefModels h3 = new HrefModels()
            {
                ID = Guid.NewGuid().ToString(),
                title = "角色管理",
                icon = "icon-users",
                link = "/SystemManage/UserManage",
                iFrame = 0,
                Accordion = a1
            };
            #endregion

            try
            { // 写数据库 

                context.UserContext.AddOrUpdate(m1);
                context.UserContext.AddOrUpdate(m2);
                context.UserContext.AddOrUpdate(m3);

                context.AccordionContext.AddOrUpdate(a1);
                context.AccordionContext.AddOrUpdate(a2);

                context.HrefContext.AddOrUpdate(h1);
                context.HrefContext.AddOrUpdate(h2);
                context.HrefContext.AddOrUpdate(h3);

                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx) { }
            base.Seed(context);
        }

    }
}
