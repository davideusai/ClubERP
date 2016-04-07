using System;
using System.ComponentModel.DataAnnotations;

namespace ClubERP.DAO
{
    public class PaymentMode : Base
    {
        private string _id;
        private string _name;
        private string _description;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Display(Name = "Payment Mode Name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
