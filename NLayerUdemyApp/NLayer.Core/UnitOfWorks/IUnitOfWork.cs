using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        #region Notlarım
        /*
         Unit Of Work, toplu veritabanı işlemlerini tek seferde bir kereye mahsus execute eden ve böylece bu 
         toplu işlem neticesinde kaç kayıtın etkilendiğini rapor olarak sunabilen bir tasarım desenidir. 
         Örneğin repositorylerde Update ve Remove dan sonra SaveChanges() işlemi yaptığımız için bu 
         savechanges leri toplu olarak yapmak için UnitOfWork Interface' inden yaralanıyoruz.
         */
        #endregion

        Task CommitAsync(); // Async metotlar için
        void Commit(); // Normal metotlar için
    }
}
