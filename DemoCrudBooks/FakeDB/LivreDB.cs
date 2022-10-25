using DemoCrudBooks.Models;

namespace DemoCrudBooks.FakeDB
{
    public static class LivreDB
    {
        private static List<Livre> Bibliotheque { get; set; } = new List<Livre>();

        private static int _currentId = 0;

        public static void Ajouter(Livre l)
        {
            l.Id = ++_currentId;
                
            Bibliotheque.Add(l);
        }

        public static List<Livre> GetAll()
        {
            return Bibliotheque;
        }

        public static Livre GetById(int id)
        {
            return Bibliotheque.FirstOrDefault(l => l.Id == id);
        }

        public static void Delete(int id)
        {
            Livre aSupprimer = GetById(id);
            Bibliotheque.Remove(aSupprimer);
        }

        public static void Update(Livre l)
        {
            Delete(l.Id);
            Ajouter(l);
        }
    }
}
