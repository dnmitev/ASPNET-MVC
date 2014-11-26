namespace TicketingSystem.Web.Areas.Admin.Controllers.Base
{
    using System.Web.Mvc;

    using TelerikExamSystem.Common;
    using TelerikExamSystem.Data.UnitOfWork;
    using TelerikExamSystem.Web.Controllers.Base;

    [Authorize(Roles = GlobalConstants.AdminRoleName)]
    public abstract class AdminController : BaseController
    {
        public AdminController(ITelerikExamSystemData data)
            : base(data)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Data.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}