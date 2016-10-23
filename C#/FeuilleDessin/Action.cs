 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FeuilleDessin
{
    public interface ISupprimable
    {
        bool Supprimé { get; }
        void Supprime();
        void Restaure();
    }
    
    public enum Type_Action {Créer, Détruire, Déplacer }

    class Action
    {

        Type_Action type_action;
        List<ISupprimable> objets;
              
        public Action(Type_Action type,
            List<ISupprimable> objets)
        {
            type_action = type;
            this.objets = objets;
        }

        public void Undo()
        {
            switch (type_action)
            {
                case Type_Action.Détruire:
                    objets[0].Restaure();
                    break;
                case Type_Action.Créer:
                    objets[0].Supprime();
                    break;
            }
        }

        public void Redo()
        {
            switch (type_action)
            {
                case Type_Action.Détruire:
                    objets[0].Supprime();
                    break;
                case Type_Action.Créer:
                    objets[0].Restaure();
                    break;
            }
        }
    }
}
