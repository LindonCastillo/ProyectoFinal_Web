using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProyectoFinal_Web.BLL
{
    public interface IRepository <T> where T : class
    {
        List<T> GetList(Expression<Func<T, bool>> Expression);
        T Buscar(int Id);
        bool Guardar(T entity);
        bool Modificar(T entity);
        bool Eliminar(int Id);
    }
}
