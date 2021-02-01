using System.Collections.Generic;
using InstaDev.Models;

namespace InstaDev.Interfaces
{
    public interface IUser
    {
        // CRUD
        void Create(User newUser);
        List<User> ReadAllItems();
        void Update();
        void Delete();
    }
    }