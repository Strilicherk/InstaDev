using System.Collections.Generic;
using InstaDev.Models;

namespace InstaDev.Interfaces
{
    public interface IUsuario
    {
        // CRUD
        void Create(User newUser);
        List<User> ReadAllItems();
        void Update(User update);
        void Delete(int id);
    }
}
