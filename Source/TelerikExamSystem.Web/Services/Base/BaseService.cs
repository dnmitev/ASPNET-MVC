namespace TelerikExamSystem.Web.Services.Base
{
    using System;
    using System.Linq;
    using TelerikExamSystem.Data.UnitOfWork;

    public abstract class BaseService
    {
        private ITelerikExamSystemData data;

        public BaseService(ITelerikExamSystemData data)
        {
            this.data = data;
        }

        public ITelerikExamSystemData Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }
}