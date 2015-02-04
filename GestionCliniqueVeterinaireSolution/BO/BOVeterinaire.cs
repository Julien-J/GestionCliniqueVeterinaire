using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BOVeterinaire
    {
        private Guid _codeVeto;
        private string _nom;
        private string _mdp;
        private bool _archive;


        public Guid codeVeto 
        { 
            get {return _codeVeto;}
            set { _codeVeto = value; } 
        }
        public string Nom 
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string MotDePasse
        {
            get { return _mdp; }
            set { _mdp = value; }
        }

        public bool Archive
        {
            get { return _archive; }
            set { _archive = value; }
        }

        public BOVeterinaire()
        { 
        }

    }
}
