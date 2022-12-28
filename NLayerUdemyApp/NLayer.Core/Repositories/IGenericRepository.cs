using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        #region Notlarım
        /*
         Not: IEnumerable tipi veriyi önce belleğe atıp ardından bellekteki bu veri üzerinden 
         belirtilen koşulları çalıştırır ve veriye uygular. IQueryable tipinde ise belirtilen 
         sorgular direk olarak server üzerinde çalıştırılır ve dönüş sağlar.
         Expression fonksiyonunu yazmamızın sebebi veritabanında filtreleme işlemleri yapabilmemiz
         için kullandık. Örn:Orderby vb.
         Update ve Remove da Async kullanmamamızın sebebi var olan veri üzerinde sadece verinin
         durumunu değiştireceğimiz için async kullanmadık.
         Kod akışının sırayla işlemediği, işlemlerin birbirini beklemediği, kod akışının 
         işlem durumlarına göre devam ettiği programlamaya Asenkron Programlama denir.
         */
        #endregion

        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
