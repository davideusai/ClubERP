using System;

namespace ClubERP.DAO
{
    public class User : Base
    {
        private int _id;
        private string _userName;
        private string _firstName;
        private string _lastName;
        private string _eMail;
        private string _phoneNumber;
        private SkypperRank _skypperRank;
        private string _identityId;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string eMail
        {
            get { return _eMail; }
            set { _eMail = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public SkypperRank SkypperRank
        {
            get { return _skypperRank; }
            set { _skypperRank = value; }
        }
        public string IdentityId
        {
            get { return _identityId; }
            set { _identityId = value; }
        }
        public User()
        {
            SkypperRank = new SkypperRank();
        }
    }
}
