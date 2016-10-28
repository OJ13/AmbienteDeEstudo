using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace _0001_DemonstracaoMVC.Models
{
    public class Repository
    {
        private Context db = new Context();

        public IEnumerable<Pessoa> GetAll()
        {
            return db.Pessoas;
        }

        public void Create(Pessoa pessoa)
        {
            db.Pessoas.Add(pessoa);
            db.SaveChanges();
        }

        public Pessoa Get(int id)
        {
            return db.Pessoas.Find(id);
        }
        public Pessoa GetByName(string name)
        { 
            //linq
            var query = from p in db.Pessoas
                        where p.Nome.Equals(name)
                        select p;

            return query.FirstOrDefault();
        }
        public Pessoa GetByName2(string name)
        {
            //Lambda

            return db.Pessoas.FirstOrDefault(x => x.Nome.Equals(name));
        }
        public void Edit(Pessoa pessoa) 
        {
            db.Entry(pessoa).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var pessoa = Get(id);
            db.Pessoas.Remove(pessoa);
            db.SaveChanges();
        }
    }
}