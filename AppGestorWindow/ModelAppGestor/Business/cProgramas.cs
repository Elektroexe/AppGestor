﻿using System;
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
    public class cProgramas
    {
        public BindingList<ProgramaDTO> GetAllProgramas()
        {
            try
            {
                List<ProgramaDTO> query;
                using (GestorDeAppsEntities db = new GestorDeAppsEntities())
                {
                    query = db.PROGRAMAs
                        .OrderBy(a => a.NOMBRE)
                        .Select(a => new ProgramaDTO
                        {
                            NOMBRE = a.NOMBRE,
                            CODIGO = a.CODIGO,
                            CODIGOCAT = a.CODIGOCAT,
                            HOST = a.HOST,
                            DESCARGAS = a.DESCARGAS,
                            INSTALADO = a.INSTALADO,
                            PLATAFORMA = a.PLATAFORMA,
                            VERSION = a.VERSION
                        })
                        .ToList();
                }

                BindingList<ProgramaDTO> result = new BindingList<ProgramaDTO>(query);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Fallada en rebre tots els programes.\nError del missatge: " + ex.Message);
            }
        }
        public BindingList<ProgramaDTO> GetProgramByCode(int code)
        {
            try
            {
                List<ProgramaDTO> query;
                using (GestorDeAppsEntities db = new GestorDeAppsEntities())
                {
                    query = db.PROGRAMAs
                        .OrderBy(a => a.NOMBRE)
                        .Where(a => a.CODIGO == code)
                        .Select(a => new ProgramaDTO
                        {
                            NOMBRE = a.NOMBRE,
                            CODIGO = a.CODIGO,
                            CODIGOCAT = a.CODIGOCAT,
                            HOST = a.HOST,
                            DESCARGAS = a.DESCARGAS,
                            INSTALADO = a.INSTALADO,
                            PLATAFORMA = a.PLATAFORMA,
                            VERSION = a.VERSION
                        })
                        .ToList();
                }

                BindingList<ProgramaDTO> result = new BindingList<ProgramaDTO>(query);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Fallada en rebre el programa per codi.\nError del missatge: " + ex.Message);
            }
        }
    }
}