using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class User
    {
        int id;
        char lastLetter;
        string name;
        string nickName;

        public int Id { get; set; }
        public char LastLetter { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }

        public User(int id, string name, string nickName)
        {
            Id = id;
            Name = name;
            NickName = nickName;
        }

    }
}
