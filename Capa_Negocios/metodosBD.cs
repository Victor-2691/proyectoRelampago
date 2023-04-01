using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;

namespace Capa_Negocios
{
    public class metodosBD
    {

        public void selectusuarios()
        {
            try
            {

                tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities();
                var query = from u in db.Usuarios
                            select u;

                List<Usuario> usuariosLista = query.ToList();

                foreach (var item in usuariosLista)
                {
                    string usuario = item.usuario1;
                    string contra = item.contra;

                }


            }   

            catch (Exception ex)
            {

                throw new Exception(ex.Message);
           
            }


        }

        #region Iniciar Sesion

        public bool Login(string user, string pass)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    Usuario usuario = new Usuario();
                    usuario = db.Usuarios.Find(user);
                    usuario = db.Usuarios.Find(pass);

                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
                return false;
            }
        }

        #endregion

        #region Caracteristicas



        #endregion


        #region Ideas

        public void AgregarIdea(string idea)
        {
            using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
            {
                try
                {

                    Idea new_idea = new Idea();
                    new_idea.idea1 = idea;

                    db.Ideas.Add(new_idea);
                    db.SaveChanges();

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public DataTable VerIdeas()
        {
            DataTable dt = new DataTable();

            try
            {

                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    var lista = from d in db.Ideas
                                select d;
                    dt = ConvertirListaToDataTable(lista.ToList());
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return dt;
        }

        public void ModificarIdeas(int idIdea, string idea)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    Idea new_idea = new Idea();
                    new_idea.Id_idea = idIdea;
                    new_idea.idea1 = idea;

                    db.Entry(new_idea).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void EliminarIdeas(int idIdea)
        {
            try
            {
                using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
                {
                    Idea new_idea = new Idea();
                    new_idea = db.Ideas.Find(idIdea);

                    db.Ideas.Remove(new_idea);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region MetodosInternos

        private DataTable ConvertirListaToDataTable(IList data)
        {

            var properties = TypeDescriptor.GetProperties(typeof(Idea));

            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (Idea item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties) row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        #endregion
    }
}

