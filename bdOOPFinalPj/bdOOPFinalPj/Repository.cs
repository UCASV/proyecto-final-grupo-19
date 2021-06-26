using System;
using bdOOPFinalPj.SqlServerContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdOOPFinalPj
{
    class Repository
    {
        // Interfaz para asignar las funciones que harán cada clase
        public interface IRepository<T>
        {
            void insert(T item);
            void update(T item);
            List<T> consult();

        }

        public class CitizenRepo : IRepository<Citizen>
        {
            private PROYECTOFContext _Context;

            public CitizenRepo()
            {
                _Context = new PROYECTOFContext();
            }

            public List<Citizen> consult()
            {
                return _Context.Citizens
                    .Include(c => c.IdIdentifierNavigation).Include(c => c.IdVaccinationPNavigation)
                    .ToList();
            }

            public void insert(Citizen item)
            {
                _Context.Add(item);
                _Context.SaveChanges();
            }

            public void update(Citizen item)
            {
                _Context.Update(item);
                _Context.SaveChanges();
            }
        }

        public class DiseaseRepo : IRepository<Disease>
        {
            private PROYECTOFContext _Context;

            public DiseaseRepo()
            {
                _Context = new PROYECTOFContext();
            }

            public List<Disease> consult()
            {
                return _Context.Diseases
                    .Include(d => d.IdCitizenNavigation)
                    .ToList();
            }

            public void insert(Disease item)
            {
                _Context.Add(item);
                _Context.SaveChanges();
            }

            public void update(Disease item)
            {
                _Context.Update(item);
                _Context.SaveChanges();
            }
        }
        public class vaccinationRepo : IRepository<VaccinationProcess>
        {
            private PROYECTOFContext _Context;

            public vaccinationRepo()
            {
                _Context = new PROYECTOFContext();
            }

            public List<VaccinationProcess> consult()
            {
                return _Context.VaccinationProcesses.ToList();
            }

            public void insert(VaccinationProcess item)
            {
                _Context.Add(item);
                _Context.SaveChanges();
            }

            public void update(VaccinationProcess item)
            {
                _Context.Update(item);
                _Context.SaveChanges();
            }
        }

        public class EffectRepo : IRepository<Effect>
        {
            private PROYECTOFContext _Context;

            public EffectRepo()
            {
                _Context = new PROYECTOFContext();
            }

            public List<Effect> consult()
            {
                return _Context.Effects.Include(e => e.IdProcessNavigation).ToList();
            }

            public void insert(Effect item)
            {
                _Context.Add(item);
                _Context.SaveChanges();
            }

            public void update(Effect item)
            {
                _Context.Update(item);
                _Context.SaveChanges();
            }
        }

        public class IdentifierRepo : IRepository<Identifier>
        {
            private PROYECTOFContext _Context;

            public IdentifierRepo()
            {
                _Context = new PROYECTOFContext();
            }

            public List<Identifier> consult()
            {
                return _Context.Identifiers.ToList();
            }

            public void insert(Identifier item)
            {
                _Context.Add(item);
                _Context.SaveChanges();
            }

            public void update(Identifier item)
            {
                _Context.Update(item);
                _Context.SaveChanges();
            }
        }

    }
}
