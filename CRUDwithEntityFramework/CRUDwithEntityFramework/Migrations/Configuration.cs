namespace CRUDwithEntityFramework.Migrations
{
    using CRUDwithEntityFramework.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

    internal sealed class Configuration : DbMigrationsConfiguration<CRUDwithEntityFramework.Models.MyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CRUDwithEntityFramework.Models.MyDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            IList<Detail> defaultDetail = new List<Detail>();

            defaultDetail.Add(new Detail() { FName = "First Name 1", LName = "Last Name 1", Address = "Address 1", Age = 20, DOB = DateTime.Now });
            defaultDetail.Add(new Detail() { FName = "First Name 2", LName = "Last Name 2", Address = "Address 2", Age = 30, DOB = DateTime.Now });
            defaultDetail.Add(new Detail() { FName = "First Name 3", LName = "Last Name 3", Address = "Address 3", Age = 40, DOB = DateTime.Now });

            //context.details.AddRange(defaultDetail);
            foreach (Detail std in defaultDetail)
                context.Details.Add(std);

            base.Seed(context);
        }
    }
}
