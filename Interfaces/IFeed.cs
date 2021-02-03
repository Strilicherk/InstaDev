using System.Collections.Generic;
using InstaDev.Models;

namespace InstaDev.Interfaces
{
    public interface IFeed
    {
        //  CRUD

        //Create
        void Create(Post e);

        //READ
        List<Post>ReadAll();

        //Update
        void Update(Post e);

        //Delete
        void Delete(Post idPub);



    }
}