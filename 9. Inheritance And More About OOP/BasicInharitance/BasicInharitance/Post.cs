using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInharitance
{
    class Post
    {
        private static int CurrentPostID = 0; //static element create when programs runs
        public static string StaticVar { set; get; } //call without object.
        private string PrivateVar { get; set; }
        public string PublicVar { get; set; }
        protected int PostID { get; set; }
        protected string Title { get; set; }
        protected string UserName { get; set; }

        public Post()
        {
            PostID = NextPostID();
            Title = "Default Title";
            UserName = "Default UserName";
            PrivateVar = "From Base Class";
            PublicVar = "I'm public, from base class";
            StaticVar = "I'm Static Var, from base class";
        }

        public Post(string title, string userName)
        {
            PostID = NextPostID();
            Title = title;
            UserName = userName;
            PrivateVar = "From Base Class";
        }

        protected int NextPostID()
        {
            return ++CurrentPostID;
        }

        public override string ToString()
        {
            return "-------> This is Base Class Post <------"+ "\nPost Id : " + PostID + "\nTitle : " + Title + "\nUser Name : " +  UserName + "\nPrivate Var : " + PrivateVar;
        }
    }
}
