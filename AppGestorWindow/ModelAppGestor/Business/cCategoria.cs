using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelAppGestor;
using ModelAppGestor.Data;
using System.ComponentModel;
using ModelAppGestor.Model;

namespace ModelAppGestor.Business
{
    public class cCategoria
    {
        public BindingList<CategoriaDTO> GetAllCategoria()
        {
            try
            {
                List<CategoriaDTO> query;
                GestorDeAppsEntities db = new GestorDeAppsEntities();
                    {
                    query = db.CATEGORIAs
                        .OrderBy(a => a.NOMCATEGORIA)
                        .Select(a => new CategoriaDTO
                        {
                            CODCATEGORIA = a.CODCATEGORIA,
                            NOMCATEGORIA = a.NOMCATEGORIA
                        })
                        .ToList();
                }

                BindingList<CategoriaDTO> result = new BindingList<CategoriaDTO>(query);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Fallada en rebre tots les categories.\nError del missatge: " + ex.Message);
            }
        }
        public BindingList<CategoriaDTO> GetCategoriaByCode(int code)
        {
            try
            {
                List<CategoriaDTO> query;
                GestorDeAppsEntities db = new GestorDeAppsEntities();
                {
                    query = db.CATEGORIAs
                        .OrderBy(a => a.NOMCATEGORIA)
                        .Where(a => a.CODCATEGORIA == code)
                        .Select(a => new CategoriaDTO
                        {
                            CODCATEGORIA = a.CODCATEGORIA,
                            NOMCATEGORIA = a.NOMCATEGORIA
                        })
                        .ToList();
                }

                BindingList<CategoriaDTO> result = new BindingList<CategoriaDTO>(query);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Fallada en rebre la categoría per codi.\nError del missatge: " + ex.Message);
            }
        }
    }
}
