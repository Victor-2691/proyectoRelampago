using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    internal class Class1
    {
        public void AgregarIdea(string idea)
        {
            using (tiusr7pl_proyecto_relampagoEntities db = new tiusr7pl_proyecto_relampagoEntities())
            {
                Idea new_idea = new Idea();
                new_idea.idea1 = idea;                
            }
        }
    }
}
