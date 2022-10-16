namespace Model.Concrete;
    public class User
    {
        public int id { get; set; }
        public string userName { get; set; }

        public User() { }
        public User(int id, string userName)
        {
            this.id = id;
            this.userName = userName;
        }
        public User(int id)
        {
          this.id = id;
        }
}

