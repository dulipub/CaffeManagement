using System;

namespace CaffeManagementCore.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public bool isDeleted { get; set; }

        public void Delete()
        {
            isDeleted = true;
        }

        public void UnDelete()
        {
            isDeleted = false;
        }
    }
}