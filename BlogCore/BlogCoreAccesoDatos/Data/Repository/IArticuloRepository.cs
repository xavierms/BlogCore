using BlogCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogCore.AccesoDatos.Data.Repository
{
    public interface IArticuloRepository:IRepository<Articulo>
    {
       
        void Update(Articulo articulo);
    }
}
